using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Elektron_Ovoz_Berish
{
	/// <summary>
	/// Description of KirishForm.
	/// </summary>
	public partial class KirishForm : Form
	{
		public KirishForm()
		{
			InitializeComponent();
		}
		
		void ButtonKirishClick(object sender, EventArgs e)
		{
			string login = textBoxLogin.Text.Trim();
		    string parol = textBoxParol.Text.Trim();
		
		    string connectionString = "Server=.;Database=El_ovoz_berish;Trusted_Connection=True;";
		    string query = @"SELECT FIO, Jins, Kasb, TuSana, TelRaqam, Viloyat, ShaharTuman
		                     FROM Foydalanuvchilar 
		                     WHERE Login = @login AND Parol = @parol";
		
		    string adminLogin = "admin";
		    string adminParol = "i.b.i-1.";
		
		    if (login == adminLogin && parol == adminParol)
		    {
		        AdminForm adminForm = new AdminForm();
		        adminForm.Show();
		        this.Hide();
		        return;
		    }
		
		    using (SqlConnection conn = new SqlConnection(connectionString))
		    using (SqlCommand cmd = new SqlCommand(query, conn))
		    {
		        cmd.Parameters.AddWithValue("@login", login);
		        cmd.Parameters.AddWithValue("@parol", parol);
		
		        conn.Open();
		        SqlDataReader reader = cmd.ExecuteReader();
		
		        if (reader.Read())
		        {
		            string fio = reader["FIO"].ToString();
		            string jins = reader["Jins"].ToString();
		            string kasb = reader["Kasb"].ToString();
		            DateTime tuSana = Convert.ToDateTime(reader["TuSana"]);
		            string tel = reader["TelRaqam"].ToString();
		            string vil = reader["Viloyat"].ToString();
		            string tum = reader["ShaharTuman"].ToString();
		
		            HisobForm profil = new HisobForm(fio, jins, kasb, tuSana, tel, vil, tum);
		            profil.Show();
		            this.Hide();
		        }
		        else
		        {
		            MessageBox.Show("Login yoki parol noto‘g‘ri!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
		        }
		    }
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked)
			{
				textBoxParol.PasswordChar='\0';
			}
			else
			{
				textBoxParol.PasswordChar='*';
			}
		}
		void LabelOrtgaClick(object sender, EventArgs e)
		{
			MainForm mainForm=new MainForm();
			mainForm.Show();
			this.Hide();
		}

	}
}
