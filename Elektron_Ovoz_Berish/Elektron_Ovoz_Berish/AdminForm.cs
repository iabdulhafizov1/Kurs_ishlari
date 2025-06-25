using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace Elektron_Ovoz_Berish
{
	/// <summary>
	/// </summary>
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}
		
		private void MalumotlarniYuklash()
		{

		    string connectionString = "Server=localhost;Database=El_ovoz_berish;Integrated Security=True;";
		    string query = "SELECT ID, Viloyat, [Shahar/Tuman], Obyekt FROM Hududlar";
		
		    try
		    {
		        using (SqlConnection connection = new SqlConnection(connectionString))
		        using (SqlCommand command = new SqlCommand(query, connection))
		        {
		            connection.Open();
		            using (SqlDataReader reader = command.ExecuteReader())
		            {
		                listView1.Items.Clear();
		
		                while (reader.Read())
		                {
		                    ListViewItem item = new ListViewItem(reader["ID"].ToString());
		                    item.SubItems.Add(reader["Viloyat"].ToString());
		                    item.SubItems.Add(reader["Shahar/Tuman"].ToString());
		                    item.SubItems.Add(reader["Obyekt"].ToString());
		                    
		                    listView1.Items.Add(item);

		                }
		            }
		        }
		    }
		    catch (Exception ex)
		    {
		        MessageBox.Show("Ma’lumotlarni yuklashda xatolik: " + ex.Message);
		    }
		}
				
		private void LoadOvozlarSoniData()
		{
		    listView2.Items.Clear();
		
		    string connectionString = @"Data Source=.;Initial Catalog=El_ovoz_berish;Integrated Security=True";
		    string query = "SELECT TartibRaqam, Viloyat, ShaharTuman, Obyekt, TelefonRaqam, Sana, Ovozlar_Soni FROM Ovozlar";
		
		    using (SqlConnection conn = new SqlConnection(connectionString))
		    using (SqlCommand cmd = new SqlCommand(query, conn))
		    {
		        conn.Open();
		        SqlDataReader reader = cmd.ExecuteReader();
		
		        while (reader.Read())
		        {
		            ListViewItem item = new ListViewItem(reader["TartibRaqam"].ToString());
		            item.SubItems.Add(reader["Viloyat"].ToString());
		            item.SubItems.Add(reader["ShaharTuman"].ToString());
		            item.SubItems.Add(reader["Obyekt"].ToString());
		            item.SubItems.Add(reader["TelefonRaqam"].ToString());
		            item.SubItems.Add(reader["Ovozlar_Soni"].ToString());
		            item.SubItems.Add(reader["Sana"].ToString());
		
		            listView2.Items.Add(item);
		        }
		    }
		}


		void AdminFormLoad(object sender, EventArgs e)
		{
			listView1.View = View.Details;
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
					
			listView1.Columns.Add("ID", 30);
			listView1.Columns.Add("Viloyat", 60);
			listView1.Columns.Add("Shahar/Tuman", 100);
			listView1.Columns.Add("Obyekt", 140);
			MalumotlarniYuklash();
			
			// ListView2 ustunlarini qo‘shish
			listView2.View = View.Details;
			listView2.Columns.Clear();
			listView2.Columns.Add("Tartib raqam", 100);
			listView2.Columns.Add("Viloyat", 100);
			listView2.Columns.Add("ShaharTuman", 120);
			listView2.Columns.Add("Obyekt", 120);
			listView2.Columns.Add("Telefon_Raqam", 120);
			listView2.Columns.Add("Ovozlar_soni", 100);
			listView2.Columns.Add("Sana", 150);

			
			LoadOvozlarSoniData();

		}
		
		void ButtonOrtgaClick(object sender, EventArgs e)
		{
			MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
		}
		void Btn_otishClick(object sender, EventArgs e)
		{
			AdminForm2 adminForm2=new AdminForm2();
			adminForm2.Show();
			this.Hide();
		}

	}
}
