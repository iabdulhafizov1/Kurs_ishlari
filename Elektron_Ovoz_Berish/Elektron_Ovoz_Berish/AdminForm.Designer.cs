namespace Elektron_Ovoz_Berish
{
	partial class AdminForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.Button buttonOrtga;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1AdminForm1;
		private System.Windows.Forms.Button btn_otish;
		
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.buttonOrtga = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1AdminForm1 = new System.Windows.Forms.Button();
			this.btn_otish = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(25, 67);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(406, 446);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// listView2
			// 
			this.listView2.Location = new System.Drawing.Point(453, 67);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(406, 446);
			this.listView2.TabIndex = 1;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// buttonOrtga
			// 
			this.buttonOrtga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.buttonOrtga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOrtga.Location = new System.Drawing.Point(762, 11);
			this.buttonOrtga.Name = "buttonOrtga";
			this.buttonOrtga.Size = new System.Drawing.Size(97, 23);
			this.buttonOrtga.TabIndex = 6;
			this.buttonOrtga.Text = "Chiqish";
			this.buttonOrtga.UseVisualStyleBackColor = false;
			this.buttonOrtga.Click += new System.EventHandler(this.ButtonOrtgaClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(84, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 27);
			this.label1.TabIndex = 7;
			this.label1.Text = "Berilgan ovozlar natijalari";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(519, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(280, 27);
			this.label2.TabIndex = 8;
			this.label2.Text = "Berilgan ovozlar soni";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1AdminForm1
			// 
			this.button1AdminForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1AdminForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1AdminForm1.Location = new System.Drawing.Point(179, 564);
			this.button1AdminForm1.Name = "button1AdminForm1";
			this.button1AdminForm1.Size = new System.Drawing.Size(84, 28);
			this.button1AdminForm1.TabIndex = 22;
			this.button1AdminForm1.Text = "Qo\'shish";
			this.button1AdminForm1.UseVisualStyleBackColor = false;
			// 
			// btn_otish
			// 
			this.btn_otish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_otish.Location = new System.Drawing.Point(675, 528);
			this.btn_otish.Name = "btn_otish";
			this.btn_otish.Size = new System.Drawing.Size(184, 25);
			this.btn_otish.TabIndex = 23;
			this.btn_otish.Text = "Hudud qo\'shish va o\'chirish";
			this.btn_otish.UseVisualStyleBackColor = true;
			this.btn_otish.Click += new System.EventHandler(this.Btn_otishClick);
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 565);
			this.Controls.Add(this.btn_otish);
			this.Controls.Add(this.button1AdminForm1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOrtga);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Name = "AdminForm";
			this.Text = "Natijalarni ko\'rish";
			this.Load += new System.EventHandler(this.AdminFormLoad);
			this.ResumeLayout(false);

		}
	}
}
