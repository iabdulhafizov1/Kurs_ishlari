using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace Elektron_Ovoz_Berish
{
	/// <summary>
	/// Description of AdminForm3.
	/// </summary>
	public partial class AdminForm3 : Form
	{
		public AdminForm3()
		{
			InitializeComponent();
		}
		void BtnOchirishClick(object sender, EventArgs e)
		{
			string viloyat = txtViloyat.Text.Trim();
		    string shaharTuman = txtTuman.Text.Trim();
		    string obyekt = txtJoy.Text.Trim();
		
		    if (!string.IsNullOrEmpty(viloyat) &&
		        !string.IsNullOrEmpty(shaharTuman) &&
		        !string.IsNullOrEmpty(obyekt))
		    {
		        string connectionString = "Server=.t;Database=El_ovoz_berish;Integrated Security=True;";
		
		        using (SqlConnection connection = new SqlConnection(connectionString))
		        {
		            string query = "DELETE FROM Hududlar WHERE Viloyat = @Viloyat AND [Shahar/Tuman] = @ShaharTuman AND Obyekt = @Obyekt";
		
		            using (SqlCommand command = new SqlCommand(query, connection))
		            {
		                command.Parameters.AddWithValue("@Viloyat", viloyat);
		                command.Parameters.AddWithValue("@ShaharTuman", shaharTuman);
		                command.Parameters.AddWithValue("@Obyekt", obyekt);
		
		                try
		                {
		                    connection.Open();
		                    int rowsAffected = command.ExecuteNonQuery();
		                    connection.Close();
		
		                    if (rowsAffected > 0)
		                    {
		                        MessageBox.Show("Ma'lumot muvaffaqiyatli o‘chirildi.");
		                    }
		                    else
		                    {
		                        MessageBox.Show("Mos yozuv topilmadi.");
		                        
		                    }
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
			AdminForm2 adminForm2=new AdminForm2();
			adminForm2.Show();
			this.Hide();
		}
	}
}
