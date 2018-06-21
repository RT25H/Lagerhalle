namespace MemeCreator
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.selectedMeme = new System.Windows.Forms.PictureBox();
			this.Text_Top = new System.Windows.Forms.TextBox();
			this.Text_bottom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.SizeBar_top = new System.Windows.Forms.TrackBar();
			this.SizeBar_bottom = new System.Windows.Forms.TrackBar();
			this.SizeLabel_bottom = new System.Windows.Forms.Label();
			this.SizeLabel_top = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Label_top = new MemeCreator.BorderLabel();
			this.Label_bottom = new MemeCreator.BorderLabel();
			((System.ComponentModel.ISupportInitialize)(this.selectedMeme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeBar_top)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeBar_bottom)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// selectedMeme
			// 
			this.selectedMeme.Location = new System.Drawing.Point(0, 0);
			this.selectedMeme.Name = "selectedMeme";
			this.selectedMeme.Size = new System.Drawing.Size(900, 900);
			this.selectedMeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.selectedMeme.TabIndex = 0;
			this.selectedMeme.TabStop = false;
			// 
			// Text_Top
			// 
			this.Text_Top.Location = new System.Drawing.Point(51, 97);
			this.Text_Top.Name = "Text_Top";
			this.Text_Top.Size = new System.Drawing.Size(467, 31);
			this.Text_Top.TabIndex = 3;
			this.Text_Top.Tag = "";
			this.Text_Top.TextChanged += new System.EventHandler(this.Text_Top_TextChanged);
			// 
			// Text_bottom
			// 
			this.Text_bottom.Location = new System.Drawing.Point(56, 360);
			this.Text_bottom.Name = "Text_bottom";
			this.Text_bottom.Size = new System.Drawing.Size(467, 31);
			this.Text_bottom.TabIndex = 4;
			this.Text_bottom.TextChanged += new System.EventHandler(this.Text_bottom_TextChanged);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(51, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Text top";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(51, 314);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Text bottom";
			// 
			// ButtonSave
			// 
			this.ButtonSave.Location = new System.Drawing.Point(51, 621);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(170, 48);
			this.ButtonSave.TabIndex = 7;
			this.ButtonSave.Text = "save";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// SizeBar_top
			// 
			this.SizeBar_top.Location = new System.Drawing.Point(120, 206);
			this.SizeBar_top.Maximum = 100;
			this.SizeBar_top.Minimum = 8;
			this.SizeBar_top.Name = "SizeBar_top";
			this.SizeBar_top.Size = new System.Drawing.Size(331, 90);
			this.SizeBar_top.TabIndex = 9;
			this.SizeBar_top.Tag = "";
			this.SizeBar_top.Value = 22;
			this.SizeBar_top.ValueChanged += new System.EventHandler(this.SizeBar_top_ValueChanged);
			// 
			// SizeBar_bottom
			// 
			this.SizeBar_bottom.Location = new System.Drawing.Point(120, 463);
			this.SizeBar_bottom.Maximum = 100;
			this.SizeBar_bottom.Minimum = 8;
			this.SizeBar_bottom.Name = "SizeBar_bottom";
			this.SizeBar_bottom.Size = new System.Drawing.Size(331, 90);
			this.SizeBar_bottom.TabIndex = 10;
			this.SizeBar_bottom.Value = 22;
			this.SizeBar_bottom.ValueChanged += new System.EventHandler(this.SizeBar_bottom_ValueChanged_1);
			// 
			// SizeLabel_bottom
			// 
			this.SizeLabel_bottom.AutoSize = true;
			this.SizeLabel_bottom.ForeColor = System.Drawing.Color.White;
			this.SizeLabel_bottom.Location = new System.Drawing.Point(115, 424);
			this.SizeLabel_bottom.Name = "SizeLabel_bottom";
			this.SizeLabel_bottom.Size = new System.Drawing.Size(173, 25);
			this.SizeLabel_bottom.TabIndex = 11;
			this.SizeLabel_bottom.Text = "Text Size bottom";
			// 
			// SizeLabel_top
			// 
			this.SizeLabel_top.AutoSize = true;
			this.SizeLabel_top.ForeColor = System.Drawing.Color.White;
			this.SizeLabel_top.Location = new System.Drawing.Point(115, 155);
			this.SizeLabel_top.Name = "SizeLabel_top";
			this.SizeLabel_top.Size = new System.Drawing.Size(138, 25);
			this.SizeLabel_top.TabIndex = 12;
			this.SizeLabel_top.Text = "Text Size top";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.SizeLabel_top);
			this.panel1.Controls.Add(this.Text_Top);
			this.panel1.Controls.Add(this.SizeLabel_bottom);
			this.panel1.Controls.Add(this.Text_bottom);
			this.panel1.Controls.Add(this.SizeBar_bottom);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.SizeBar_top);
			this.panel1.Controls.Add(this.ButtonSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(1189, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(536, 1354);
			this.panel1.TabIndex = 13;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.Controls.Add(this.Label_top);
			this.panel2.Controls.Add(this.Label_bottom);
			this.panel2.Controls.Add(this.selectedMeme);
			this.panel2.Location = new System.Drawing.Point(36, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(938, 934);
			this.panel2.TabIndex = 14;
			// 
			// Label_top
			// 
			this.Label_top.BorderColor = System.Drawing.Color.Black;
			this.Label_top.BorderSize = 2F;
			this.Label_top.Font = new System.Drawing.Font("Impact", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_top.ForeColor = System.Drawing.Color.White;
			this.Label_top.Location = new System.Drawing.Point(99, 88);
			this.Label_top.Name = "Label_top";
			this.Label_top.Size = new System.Drawing.Size(762, 367);
			this.Label_top.TabIndex = 1;
			this.Label_top.Text = "Topside";
			this.Label_top.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Label_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_top_MouseDown);
			this.Label_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Top_MouseMove);
			this.Label_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_top_MouseUp);
			// 
			// Label_bottom
			// 
			this.Label_bottom.BorderColor = System.Drawing.Color.Black;
			this.Label_bottom.BorderSize = 2F;
			this.Label_bottom.Font = new System.Drawing.Font("Impact", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label_bottom.ForeColor = System.Drawing.Color.White;
			this.Label_bottom.Location = new System.Drawing.Point(99, 433);
			this.Label_bottom.Name = "Label_bottom";
			this.Label_bottom.Size = new System.Drawing.Size(790, 393);
			this.Label_bottom.TabIndex = 2;
			this.Label_bottom.Text = "Bottom";
			this.Label_bottom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Label_bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_bottom_MouseDown);
			this.Label_bottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_bottom_MouseMove);
			this.Label_bottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label_bottom_MouseUp);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1725, 1354);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "Meme Creator";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.selectedMeme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeBar_top)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeBar_bottom)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox selectedMeme;
		private BorderLabel Label_top;
		private BorderLabel Label_bottom;
		private System.Windows.Forms.TextBox Text_Top;
		private System.Windows.Forms.TextBox Text_bottom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.TrackBar SizeBar_top;
		private System.Windows.Forms.TrackBar SizeBar_bottom;
		private System.Windows.Forms.Label SizeLabel_bottom;
		private System.Windows.Forms.Label SizeLabel_top;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}