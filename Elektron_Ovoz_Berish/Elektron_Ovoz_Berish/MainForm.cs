using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace Elektron_Ovoz_Berish
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public void UmumiyOvozlarniChiqarish()
		{
		    string connectionString = "Server=.;Database=El_ovoz_berish;Trusted_Connection=True;";
		    string query = @"
		        SELECT SUM(MaxOvoz) AS UmumiyYigindi
		        FROM (
		            SELECT MAX(Ovozlar_Soni) AS MaxOvoz
		            FROM Ovozlar
		            GROUP BY Viloyat, ShaharTuman, Obyekt
		        ) AS MaxOvozlar";
		
		    using (SqlConnection connection = new SqlConnection(connectionString))
		    {
		        SqlCommand command = new SqlCommand(query, connection);
		        try
		        {
		            connection.Open();
		            object result = command.ExecuteScalar();
		            int umumiy = result != DBNull.Value ? Convert.ToInt32(result) : 0;
		
		            labelOvozlarSoni.Text = "Jami ovozlar soni: " + umumiy.ToString();
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Xatolik: " + ex.Message);
		        }
		    }
		}
		private void MainFormLoad(object sender, EventArgs e)
		{
			UmumiyOvozlarniChiqarish();
			
			string connectionString = "Server=localhost;Database=El_ovoz_berish;Trusted_Connection=True;";
		    string query = "SELECT COUNT(*) FROM Hududlar";
		
		    using (SqlConnection conn = new SqlConnection(connectionString))
		    using (SqlCommand cmd = new SqlCommand(query, conn))
		    {
		        try
		        {
		            conn.Open();
		            int satrlarSoni = (int)cmd.ExecuteScalar();
		            labelSatrlarSoni.Text = "Ro'yxatga kiritilganlar soni: " + satrlarSoni.ToString();
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Xatolik: " + ex.Message);
		        }
		    }
		}

		void RoyxatdanOtishToolStripMenuItemClick(object sender, EventArgs e)
		{
			RoyxatdanOtishForm royxatdanOtishForm=new RoyxatdanOtishForm();
			royxatdanOtishForm.Show();
			this.Hide();
		}
		
		void KirishToolStripMenuItemClick(object sender, EventArgs e)
		{
			KirishForm kirishForm=new KirishForm();
			kirishForm.Show();
			this.Hide();
		}
	}
}
