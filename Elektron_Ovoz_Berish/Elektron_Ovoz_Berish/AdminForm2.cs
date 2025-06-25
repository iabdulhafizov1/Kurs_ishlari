using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;


namespace Elektron_Ovoz_Berish
{
	/// <summary>
	/// Description of AdminForm2.
	/// </summary>
	public partial class AdminForm2 : Form
	{
		public AdminForm2()
		{
			InitializeComponent();
		}
		void BtnQoshishClick(object sender, EventArgs e)
		{
			string viloyat = txtViloyat1.Text.Trim();
		    string shaharTuman = txtTuman1.Text.Trim();
		    string obyekt = txtJoy1.Text.Trim();
		
		    if (!string.IsNullOrEmpty(viloyat) &&
		        !string.IsNullOrEmpty(shaharTuman) &&
		        !string.IsNullOrEmpty(obyekt))
		    {
		        string connectionString = "Server=.;Database=El_ovoz_berish;Integrated Security=True;";
		        
		        using (SqlConnection connection = new SqlConnection(connectionString))
		        {
		            string query = "INSERT INTO Hududlar (Viloyat, [Shahar/Tuman], Obyekt) VALUES (@Viloyat, @ShaharTuman, @Obyekt)";
		            
		            using (SqlCommand command = new SqlCommand(query, connection))
		            {
		                command.Parameters.AddWithValue("@Viloyat", viloyat);
		                command.Parameters.AddWithValue("@ShaharTuman", shaharTuman);
		                command.Parameters.AddWithValue("@Obyekt", obyekt);
		
		                try
		                {
		                    connection.Open();
		                    command.ExecuteNonQuery();
		                    MessageBox.Show("Ma'lumotlar muvaffaqiyatli saqlandi.");
		                }
		                catch (Exception ex)
		                {
		                    MessageBox.Show("Xatolik yuz berdi: " + ex.Message);
		                }
		            }
		        }
		    }
		    else
		    {
		        MessageBox.Show("Iltimos, barcha maydonlarni to‘ldiring!");
		    }
		}
		

		void Button1Click(object sender, EventArgs e)
		{
			AdminForm adminForm=new AdminForm();
			adminForm.Show();
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
			AdminForm3 adminForm3=new AdminForm3();
			adminForm3.Show();
			this.Hide();
		}
	}
}
