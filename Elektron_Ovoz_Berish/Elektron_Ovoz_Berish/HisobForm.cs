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
	/// Description of ProfilForm.
	/// </summary>
	public partial class HisobForm : Form
	{
		public HisobForm(string fio, string jins, string kasb, DateTime tuSana, string telRaqam, string viloyat, string shaharTuman)
		{
			InitializeComponent();
			labelFIO.Text = fio;
	        labelJins.Text = jins;
	        labelKasb.Text = kasb;
	        labelTuSana.Text = tuSana.ToShortDateString();
	        labelTelRaqam.Text = telRaqam;
	        labelViloyat.Text = viloyat;
	        labelShaharTuman.Text = shaharTuman;
		}
		void LblOvozBerishClick(object sender, EventArgs e)
		{
			HududForm hududForm=new HududForm();
			hududForm.Show();
			this.Hide();
		}
		void LblOrtgaClick(object sender, EventArgs e)
		{
			MainForm mainform=new MainForm();
			mainform.Show();
			this.Hide();
		}
	}
}
