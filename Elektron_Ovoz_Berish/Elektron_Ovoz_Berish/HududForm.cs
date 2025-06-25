using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace Elektron_Ovoz_Berish
{
    public partial class HududForm : Form
    {
        private string connectionString = "Server=localhost;Database=El_ovoz_berish;Integrated Security=True;";
        private string botToken = "7757739485:AAFtXqqhdquEzhnLQmmUsCSt5o5a7ZreziU";
        private string verificationCode;

        public HududForm()
        {
            InitializeComponent();
        }

        

        private void button1HududForm_Click(object sender, EventArgs e)
        {
            string phoneNumber = txt_Telefon.Text.Trim();
            string chatId = txt_ID.Text.Trim();

            if (!AreFieldsFilled(phoneNumber, chatId))
            {
                MessageBox.Show("Iltimos, telefon raqam va chat ID ni kiriting.");
                return;
            }

            Random rand = new Random();
            verificationCode = rand.Next(100000, 999999).ToString();
            string message = "Telefon raqam: " + phoneNumber + "\nTasdiqlash kodi: " + verificationCode;

            string url = "https://api.telegram.org/bot" + botToken + "/sendMessage?chat_id=" + chatId + "&text=" + Uri.EscapeDataString(message);

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    MessageBox.Show("Tasdiqlash kodi yuborildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xatolik: " + ex.Message);
            }
        }


        private bool AreFieldsFilled(params string[] fields)
        {
            foreach (string field in fields)
            {
                if (string.IsNullOrWhiteSpace(field))
                    return false;
            }
            return true;
        }

        private bool SaveToDatabase(string viloyat, string tuman, string obyekt, string telefon)
        {
            string query = "INSERT INTO Ovozlar (Viloyat, ShaharTuman, Obyekt, TelefonRaqam) " +
                           "VALUES (@viloyat, @tuman, @obyekt, @telefon)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@viloyat", viloyat);
                    cmd.Parameters.AddWithValue("@tuman", tuman);
                    cmd.Parameters.AddWithValue("@obyekt", obyekt);
                    cmd.Parameters.AddWithValue("@telefon", telefon);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bazaga yozishda xatolik: " + ex.Message, "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void OpenTelegramBot(string botUsername)
        {
            try
            {
                string botLink = "https://t.me/" + botUsername;
                ProcessStartInfo psi = new ProcessStartInfo(botLink);
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Telegram botga o'tishda xatolik:\n" + ex.Message);
            }
        }

        
		void Button2HududFormClick(object sender, EventArgs e)
		{
			if (textBox6HududForm.Text.Trim() != verificationCode)
            {
                MessageBox.Show("Tasdiqlash kodi noto‘g‘ri!");
                return;
            }

            string viloyat = comboBoxViloyat.Text.Trim();
            string tuman = comboBoxTuman.Text.Trim();
            string obyekt = comboBoxJoy.Text.Trim();
            string telefon = txt_Telefon.Text.Trim();

            if (!AreFieldsFilled(viloyat, tuman, obyekt, telefon))
            {
                MessageBox.Show("Barcha maydonlarni to‘ldiring!", "Eslatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool saved = SaveToDatabase(viloyat, tuman, obyekt, telefon);
            if (saved)
            {
                MessageBox.Show("Ma'lumotlar muvaffaqiyatli saqlandi!", "Muvaffaqiyat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ma'lumotlar saqlanmadi!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		
		void LinkLabel01HududFormLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			OpenTelegramBot("El_ovoz_bot");
		}
		
		void LinkLabel02HududFormLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			OpenTelegramBot("InfousersTgbot");
		}
		
		void HududFormLoad(object sender, EventArgs e)
		{
			LoadViloyatlar();
		}
		
		private void LoadViloyatlar()
		{
		    comboBoxViloyat.Items.Clear(); // Avvalgi elementlarni tozalash
		
		    string query = "SELECT DISTINCT Viloyat FROM Hududlar ORDER BY Viloyat";
		
		    using (SqlConnection conn = new SqlConnection(connectionString))
		    {
		        try
		        {
		            conn.Open();
		            using (SqlCommand cmd = new SqlCommand(query, conn))
		            {
		                SqlDataReader reader = cmd.ExecuteReader();
		                while (reader.Read())
		                {
		                    if (reader["Viloyat"] != DBNull.Value)
		                    {
		                        comboBoxViloyat.Items.Add(reader["Viloyat"].ToString());
		                    }
		                }
		            }
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Xatolik yuz berdi: " + ex.Message);
		        }
		    }
		}
		
		void ComboBoxViloyatSelectedIndexChanged(object sender, EventArgs e)
		{
			string tanlanganViloyat = comboBoxViloyat.SelectedItem.ToString();
    		LoadTumanlar(tanlanganViloyat);
		}
		
		private void LoadTumanlar(string viloyat)
		{
		    comboBoxTuman.Items.Clear(); // Avvalgi elementlarni tozalash
		    string query = "SELECT DISTINCT [Shahar/Tuman] FROM Hududlar WHERE Viloyat = @Viloyat ORDER BY [Shahar/Tuman]";
		
		    using (SqlConnection conn = new SqlConnection(connectionString))
		    {
		        try
		        {
		            conn.Open();
		            using (SqlCommand cmd = new SqlCommand(query, conn))
		            {
		                cmd.Parameters.AddWithValue("@Viloyat", viloyat);
		
		                SqlDataReader reader = cmd.ExecuteReader();
		                while (reader.Read())
		                {
		                    if (reader["Shahar/Tuman"] != DBNull.Value)
		                    {
		                        comboBoxTuman.Items.Add(reader["Shahar/Tuman"].ToString());
		                    }
		                }
		            }
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Tumanlarni yuklashda xatolik: " + ex.Message);
		        }
		    }
		}
		void ComboBoxTumanSelectedIndexChanged(object sender, EventArgs e)
		{
			string tanlanganViloyat = comboBoxViloyat.SelectedItem != null ? comboBoxViloyat.SelectedItem.ToString() : "";
		    string tanlanganTuman = comboBoxTuman.SelectedItem != null ? comboBoxTuman.SelectedItem.ToString() : "";
		
		    if (!string.IsNullOrEmpty(tanlanganViloyat) && !string.IsNullOrEmpty(tanlanganTuman))
		    {
		        LoadObyektlar(tanlanganViloyat, tanlanganTuman);
		    }
		}
		
		private void LoadObyektlar(string viloyat, string tuman)
		{
		    comboBoxJoy.Items.Clear(); // Avvalgi obyektlar ro‘yxatini tozalash
		
		    string query = "SELECT DISTINCT Obyekt FROM Hududlar WHERE Viloyat = @Viloyat AND [Shahar/Tuman] = @Tuman ORDER BY Obyekt";
		
		    using (SqlConnection conn = new SqlConnection(connectionString))
		    {
		        try
		        {
		            conn.Open();
		            using (SqlCommand cmd = new SqlCommand(query, conn))
		            {
		                cmd.Parameters.AddWithValue("@Viloyat", viloyat);
		                cmd.Parameters.AddWithValue("@Tuman", tuman);
		
		                SqlDataReader reader = cmd.ExecuteReader();
		                while (reader.Read())
		                {
		                    if (reader["Obyekt"] != DBNull.Value)
		                    {
		                        comboBoxJoy.Items.Add(reader["Obyekt"].ToString());
		                    }
		                }
		            }
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Obyektlarni yuklashda xatolik: " + ex.Message);
		        }
		    }
		}
		void LabelOrtgaClick(object sender, EventArgs e)
		{
			KirishForm kirishForm=new KirishForm();
			kirishForm.Show();
			this.Hide();
		}

    }
}
