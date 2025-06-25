namespace Elektron_Ovoz_Berish
{
	partial class KirishForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxParol;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnKirish;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label labelOrtga;
		
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
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxParol = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnKirish = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.labelOrtga = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.Location = new System.Drawing.Point(74, 57);
			this.textBoxLogin.Multiline = true;
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(183, 31);
			this.textBoxLogin.TabIndex = 0;
			// 
			// textBoxParol
			// 
			this.textBoxParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxParol.Location = new System.Drawing.Point(74, 125);
			this.textBoxParol.MaxLength = 8;
			this.textBoxParol.Multiline = true;
			this.textBoxParol.Name = "textBoxParol";
			this.textBoxParol.PasswordChar = '*';
			this.textBoxParol.Size = new System.Drawing.Size(183, 28);
			this.textBoxParol.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(74, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "Login";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(74, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "Parol";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnKirish
			// 
			this.btnKirish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnKirish.Location = new System.Drawing.Point(129, 159);
			this.btnKirish.Name = "btnKirish";
			this.btnKirish.Size = new System.Drawing.Size(75, 28);
			this.btnKirish.TabIndex = 4;
			this.btnKirish.Text = "Kirish";
			this.btnKirish.UseVisualStyleBackColor = true;
			this.btnKirish.Click += new System.EventHandler(this.ButtonKirishClick);
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.checkBox1.Location = new System.Drawing.Point(265, 125);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(57, 28);
			this.checkBox1.TabIndex = 23;
			this.checkBox1.Text = "Ko\'rish";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// labelOrtga
			// 
			this.labelOrtga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOrtga.Location = new System.Drawing.Point(12, 9);
			this.labelOrtga.Name = "labelOrtga";
			this.labelOrtga.Size = new System.Drawing.Size(27, 23);
			this.labelOrtga.TabIndex = 24;
			this.labelOrtga.Text = "←";
			this.labelOrtga.Click += new System.EventHandler(this.LabelOrtgaClick);
			// 
			// KirishForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(334, 265);
			this.Controls.Add(this.labelOrtga);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.btnKirish);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxParol);
			this.Controls.Add(this.textBoxLogin);
			this.Name = "KirishForm";
			this.Text = "Kirish";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
