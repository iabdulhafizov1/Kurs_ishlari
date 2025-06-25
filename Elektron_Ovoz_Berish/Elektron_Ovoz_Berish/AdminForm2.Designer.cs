/*
 * Created by SharpDevelop.
 * User: os
 * Date: 12.06.2025
 * Time: 7:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Elektron_Ovoz_Berish
{
	partial class AdminForm2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnQoshish;
		private System.Windows.Forms.TextBox txtJoy1;
		private System.Windows.Forms.TextBox txtTuman1;
		private System.Windows.Forms.TextBox txtViloyat1;
		private System.Windows.Forms.Label label3AdminForm1;
		private System.Windows.Forms.Label label2AdminForm1;
		private System.Windows.Forms.Label label1AdminForm1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.label7 = new System.Windows.Forms.Label();
			this.btnQoshish = new System.Windows.Forms.Button();
			this.txtJoy1 = new System.Windows.Forms.TextBox();
			this.txtTuman1 = new System.Windows.Forms.TextBox();
			this.txtViloyat1 = new System.Windows.Forms.TextBox();
			this.label3AdminForm1 = new System.Windows.Forms.Label();
			this.label2AdminForm1 = new System.Windows.Forms.Label();
			this.label1AdminForm1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(72, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(280, 27);
			this.label7.TabIndex = 48;
			this.label7.Text = "Hudud  qo\'shish";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnQoshish
			// 
			this.btnQoshish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnQoshish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnQoshish.Location = new System.Drawing.Point(188, 182);
			this.btnQoshish.Name = "btnQoshish";
			this.btnQoshish.Size = new System.Drawing.Size(82, 23);
			this.btnQoshish.TabIndex = 39;
			this.btnQoshish.Text = "Qo\'shish";
			this.btnQoshish.UseVisualStyleBackColor = false;
			this.btnQoshish.Click += new System.EventHandler(this.BtnQoshishClick);
			// 
			// txtJoy1
			// 
			this.txtJoy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtJoy1.Location = new System.Drawing.Point(241, 152);
			this.txtJoy1.Multiline = true;
			this.txtJoy1.Name = "txtJoy1";
			this.txtJoy1.Size = new System.Drawing.Size(171, 24);
			this.txtJoy1.TabIndex = 38;
			// 
			// txtTuman1
			// 
			this.txtTuman1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTuman1.Location = new System.Drawing.Point(241, 114);
			this.txtTuman1.Multiline = true;
			this.txtTuman1.Name = "txtTuman1";
			this.txtTuman1.Size = new System.Drawing.Size(171, 24);
			this.txtTuman1.TabIndex = 37;
			// 
			// txtViloyat1
			// 
			this.txtViloyat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtViloyat1.Location = new System.Drawing.Point(241, 84);
			this.txtViloyat1.Multiline = true;
			this.txtViloyat1.Name = "txtViloyat1";
			this.txtViloyat1.Size = new System.Drawing.Size(171, 24);
			this.txtViloyat1.TabIndex = 36;
			// 
			// label3AdminForm1
			// 
			this.label3AdminForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3AdminForm1.Location = new System.Drawing.Point(6, 152);
			this.label3AdminForm1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3AdminForm1.Name = "label3AdminForm1";
			this.label3AdminForm1.Size = new System.Drawing.Size(228, 24);
			this.label3AdminForm1.TabIndex = 35;
			this.label3AdminForm1.Text = "Ovoz berish uchun joy nomini kiriting:";
			this.label3AdminForm1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2AdminForm1
			// 
			this.label2AdminForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2AdminForm1.Location = new System.Drawing.Point(6, 114);
			this.label2AdminForm1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2AdminForm1.Name = "label2AdminForm1";
			this.label2AdminForm1.Size = new System.Drawing.Size(228, 24);
			this.label2AdminForm1.TabIndex = 34;
			this.label2AdminForm1.Text = "Shahar/Tuman nomini kiriting:";
			this.label2AdminForm1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1AdminForm1
			// 
			this.label1AdminForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1AdminForm1.Location = new System.Drawing.Point(6, 84);
			this.label1AdminForm1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1AdminForm1.Name = "label1AdminForm1";
			this.label1AdminForm1.Size = new System.Drawing.Size(228, 24);
			this.label1AdminForm1.TabIndex = 33;
			this.label1AdminForm1.Text = "Viloyat nomini kiriting:";
			this.label1AdminForm1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(325, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 23);
			this.button1.TabIndex = 50;
			this.button1.Text = "Chiqish";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(202, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(117, 23);
			this.button2.TabIndex = 51;
			this.button2.Text = "Hudud O\'chirish";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// AdminForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(434, 265);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnQoshish);
			this.Controls.Add(this.txtJoy1);
			this.Controls.Add(this.txtTuman1);
			this.Controls.Add(this.txtViloyat1);
			this.Controls.Add(this.label3AdminForm1);
			this.Controls.Add(this.label2AdminForm1);
			this.Controls.Add(this.label1AdminForm1);
			this.Name = "AdminForm2";
			this.Text = "Hudud qo\'shish";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
