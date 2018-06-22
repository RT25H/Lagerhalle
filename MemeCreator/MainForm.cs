using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeCreator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();


			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var files = Directory.GetFiles("Memes", "*.jpg");

			foreach (var file in files)
			{

				try
				{
					var image = Image.FromFile(file);
					lstMemes.LargeImageList.Images.Add(image);
				}
				catch 
				{

					Console.WriteLine("This is not an Image");
					
				}

			}

			for (int j = 0; j < lstMemes.LargeImageList.Images.Count; j++)
			{
				ListViewItem item = new ListViewItem();
				item.ImageIndex = j;
				item.Tag = files[j];
				item.Text = Path.GetFileNameWithoutExtension(files[j]);
				item.ToolTipText = files[j];
				lstMemes.Items.Add(item);
			}




		}

		private void lstMemes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstMemes.SelectedIndices.Count == 0)
				return;

			var selectedItem = lstMemes.SelectedItems[0];
			var file = selectedItem.Tag.ToString();
			var image = Image.FromFile(file);

			var DetailForm = new DetailForm();
			DetailForm.MemeImage = image;
			DetailForm.ShowDialog();
		}

		private void lstMemes_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private void lstMemes_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (string file in files)
			{
				Image image;
				try
				{
					image = Image.FromFile(file);
				}
				catch (Exception)
				{
					continue;
				}

				var TargetFile = Path.Combine(Application.StartupPath, "Memes", Path.GetFileName(file));

				if (!File.Exists(TargetFile))
					File.Copy(file,TargetFile);

				lstMemes.LargeImageList.Images.Add(image);

				ListViewItem item = new ListViewItem();
				item.ImageIndex = lstMemes.LargeImageList.Images.Count - 1;
				item.Tag = file;
				item.Text = Path.GetFileNameWithoutExtension(file);
				item.ToolTipText = file;
				lstMemes.Items.Add(item);
			}
			
		}

		private void MainForm_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
