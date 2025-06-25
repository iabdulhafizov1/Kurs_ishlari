using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Elektron_Ovoz_Berish
{
	/// <summary>
	/// </summary>
	public partial class RoyxatdanOtishForm : Form
	{
		public RoyxatdanOtishForm()
		{
			InitializeComponent();
			comboBoxJins.Items.Add("Erkak");
			comboBoxJins.Items.Add("Ayol");
		}

		void BtnSaqlashClick(object sender, EventArgs e)
		{
		    string connectionString = "Server=.;Database=El_ovoz_berish;Trusted_Connection=True;";
		    
		    using (SqlConnection connection = new SqlConnection(connectionString))
		    {
		        string query = "INSERT INTO Foydalanuvchilar (FIO, Jins, Kasb, TuSana, TelRaqam, Viloyat, ShaharTuman, Login, Parol) " +
		                       "VALUES (@FIO, @Jins, @Kasb, @TuSana, @TelRaqam, @Viloyat, @ShaharTuman, @Login, @Parol)";
		
		        SqlCommand command = new SqlCommand(query, connection);
		
		        command.Parameters.AddWithValue("@FIO", textBoxFIO.Text);
		        command.Parameters.AddWithValue("@Jins", comboBoxJins.Text);
		        command.Parameters.AddWithValue("@Kasb", textBoxKasb.Text);
		        command.Parameters.AddWithValue("@TuSana", DateTime.Parse(textBoxSana.Text));
		        command.Parameters.AddWithValue("@TelRaqam", textBoxTelRaqam.Text);
		        command.Parameters.AddWithValue("@Viloyat", textBoxViloyat.Text);
		        command.Parameters.AddWithValue("@ShaharTuman", textBoxShaharTuman.Text);
		        command.Parameters.AddWithValue("@Login", textBoxLogin.Text);
		        command.Parameters.AddWithValue("@Parol", textBoxParol.Text);
		
		        try
		        {
		            connection.Open();
		            int rowsAffected = command.ExecuteNonQuery();
		            MessageBox.Show("Ma'lumot muvaffaqiyatli saqlandi.");
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Xatolik: " + ex.Message);
		        }
		    }
		}
		void Label10Click(object sender, EventArgs e)
		{
			MainForm mainForm=new MainForm();
			mainForm.Show();
			this.Hide();
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

	}
}
