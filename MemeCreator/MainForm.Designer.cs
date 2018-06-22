namespace MemeCreator
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lstMemes = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SuspendLayout();
			// 
			// lstMemes
			// 
			this.lstMemes.AllowDrop = true;
			this.lstMemes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lstMemes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstMemes.ForeColor = System.Drawing.Color.White;
			this.lstMemes.LargeImageList = this.imageList1;
			this.lstMemes.Location = new System.Drawing.Point(0, 0);
			this.lstMemes.Name = "lstMemes";
			this.lstMemes.Size = new System.Drawing.Size(1561, 1253);
			this.lstMemes.TabIndex = 0;
			this.lstMemes.UseCompatibleStateImageBehavior = false;
			this.lstMemes.SelectedIndexChanged += new System.EventHandler(this.lstMemes_SelectedIndexChanged);
			this.lstMemes.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstMemes_DragDrop);
			this.lstMemes.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstMemes_DragEnter);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1561, 1253);
			this.Controls.Add(this.lstMemes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Meme Creator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.TextChanged += new System.EventHandler(this.MainForm_TextChanged);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstMemes;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}

