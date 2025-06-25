/*
 * Created by SharpDevelop.
 * User: os
 * Date: 12.06.2025
 * Time: 7:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Elektron_Ovoz_Berish
{
	partial class AdminForm3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnOchirish;
		private System.Windows.Forms.TextBox txtJoy;
		private System.Windows.Forms.TextBox txtTuman;
		private System.Windows.Forms.TextBox txtViloyat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label6 = new System.Windows.Forms.Label();
			this.btnOchirish = new System.Windows.Forms.Button();
			this.txtJoy = new System.Windows.Forms.TextBox();
			this.txtTuman = new System.Windows.Forms.TextBox();
			this.txtViloyat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(97, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(280, 27);
			this.label6.TabIndex = 55;
			this.label6.Text = "Hudud  olib tashlash";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnOchirish
			// 
			this.btnOchirish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnOchirish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOchirish.Location = new System.Drawing.Point(188, 180);
			this.btnOchirish.Name = "btnOchirish";
			this.btnOchirish.Size = new System.Drawing.Size(82, 23);
			this.btnOchirish.TabIndex = 54;
			this.btnOchirish.Text = "O\'chirish";
			this.btnOchirish.UseVisualStyleBackColor = false;
			this.btnOchirish.Click += new System.EventHandler(this.BtnOchirishClick);
			// 
			// txtJoy
			// 
			this.txtJoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtJoy.Location = new System.Drawing.Point(241, 153);
			this.txtJoy.Multiline = true;
			this.txtJoy.Name = "txtJoy";
			this.txtJoy.Size = new System.Drawing.Size(171, 24);
			this.txtJoy.TabIndex = 53;
			// 
			// txtTuman
			// 
			this.txtTuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTuman.Location = new System.Drawing.Point(241, 115);
			this.txtTuman.Multiline = true;
			this.txtTuman.Name = "txtTuman";
			this.txtTuman.Size = new System.Drawing.Size(171, 24);
			this.txtTuman.TabIndex = 52;
			// 
			// txtViloyat
			// 
			this.txtViloyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtViloyat.Location = new System.Drawing.Point(241, 85);
			this.txtViloyat.Multiline = true;
			this.txtViloyat.Name = "txtViloyat";
			this.txtViloyat.Size = new System.Drawing.Size(171, 24);
			this.txtViloyat.TabIndex = 51;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(7, 153);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(227, 24);
			this.label3.TabIndex = 50;
			this.label3.Text = "Ovoz berish uchun joy nomini kiriting:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(7, 115);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(227, 24);
			this.label4.TabIndex = 49;
			this.label4.Text = "Shahar/Tuman nomini kiriting:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(7, 85);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(227, 24);
			this.label5.TabIndex = 48;
			this.label5.Text = "Viloyat nomini kiriting:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(325, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 23);
			this.button1.TabIndex = 56;
			this.button1.Text = "Chiqish";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// AdminForm3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(434, 265);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnOchirish);
			this.Controls.Add(this.txtJoy);
			this.Controls.Add(this.txtTuman);
			this.Controls.Add(this.txtViloyat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Name = "AdminForm3";
			this.Text = "Hudud o\'chirish";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
