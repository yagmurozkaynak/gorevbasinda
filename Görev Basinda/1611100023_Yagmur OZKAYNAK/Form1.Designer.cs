namespace gorevbasinda
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yaprak_sepeti = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSkor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.yaprak_sepeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yaprak_sepeti
            // 
            this.yaprak_sepeti.BackColor = System.Drawing.Color.Transparent;
            this.yaprak_sepeti.Image = ((System.Drawing.Image)(resources.GetObject("yaprak_sepeti.Image")));
            this.yaprak_sepeti.Location = new System.Drawing.Point(406, 416);
            this.yaprak_sepeti.Name = "yaprak_sepeti";
            this.yaprak_sepeti.Size = new System.Drawing.Size(179, 110);
            this.yaprak_sepeti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yaprak_sepeti.TabIndex = 0;
            this.yaprak_sepeti.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "SKOR:";
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.BackColor = System.Drawing.Color.Transparent;
            this.labelSkor.Font = new System.Drawing.Font("Snap ITC", 20.25F);
            this.labelSkor.ForeColor = System.Drawing.Color.Maroon;
            this.labelSkor.Location = new System.Drawing.Point(128, 9);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(38, 35);
            this.labelSkor.TabIndex = 2;
            this.labelSkor.Text = "0";
            this.labelSkor.TextChanged += new System.EventHandler(this.labelSkor_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1022, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelCan
            // 
            this.labelCan.AutoSize = true;
            this.labelCan.BackColor = System.Drawing.Color.Transparent;
            this.labelCan.Font = new System.Drawing.Font("Snap ITC", 20.25F);
            this.labelCan.ForeColor = System.Drawing.Color.Maroon;
            this.labelCan.Location = new System.Drawing.Point(1143, 9);
            this.labelCan.Name = "labelCan";
            this.labelCan.Size = new System.Drawing.Size(37, 35);
            this.labelCan.TabIndex = 4;
            this.labelCan.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Snap ITC", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(1084, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yaprak_sepeti);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.yaprak_sepeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox yaprak_sepeti;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelSkor;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelCan;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
	}
}

