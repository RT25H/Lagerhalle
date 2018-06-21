using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeCreator
{
	public partial class Form2 : Form
	{
		bool isdragging = false;
		Point delta = Point.Empty;
		
		
		public Form2()
		{
			InitializeComponent();

			Label_top.Parent = selectedMeme;
			Label_top.BackColor = Color.Transparent;
			Label_bottom.Parent = selectedMeme;
			Label_bottom.BackColor = Color.Transparent;
						
		}

		public Image MemeImage { get; set; }

		private void Form2_Load(object sender, EventArgs e)
		{
			Label_bottom.Text = "";
			Label_top.Text = "";

			SizeBar_top.Value = (int)Math.Round(Label_top.Font.Size);

			SizeBar_bottom.Value = (int)Math.Round(Label_bottom.Font.Size);
			

			selectedMeme.Image = MemeImage;
		}

		private void Text_Top_TextChanged(object sender, EventArgs e)
		{
			Label_top.Text = Text_Top.Text.ToUpper();
		}

		private void Text_bottom_TextChanged(object sender, EventArgs e)
		{
			Label_bottom.Text = Text_bottom.Text.ToUpper();


		}
		void label_Top_MouseMove(object sender, MouseEventArgs e)
		{
			if (isdragging == true)
			{
								
				var mousePositionOnForm = PointToClient(Control.MousePosition);
				var newX = mousePositionOnForm.X - delta.X;
				var newY = mousePositionOnForm.Y - delta.Y;

				Label_top.Location = new Point(newX,newY);

			}
		}

		private void SaveCurrentMeme(string filePath)
		{
			var bmp = new Bitmap(selectedMeme.Width, selectedMeme.Height);
			selectedMeme.DrawToBitmap(bmp, new Rectangle(Point.Empty, selectedMeme.Size));
			bmp.Save(filePath);
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog savefile = new SaveFileDialog();
			// set a default file name
			savefile.FileName = "Meme.png";
			// set filters - this can be done in properties as well
			savefile.Filter = "Image file (*.png)|*.png|All files (*.*)|*.*";

			if (savefile.ShowDialog() == DialogResult.OK)
			{
				SaveCurrentMeme(savefile.FileName);
			}
		}

		private void Label_top_MouseDown(object sender, MouseEventArgs e)
		{
			isdragging = true;
			delta = e.Location;
		}

		private void Label_top_MouseUp(object sender, MouseEventArgs e)
		{
			isdragging = false;
			delta = Point.Empty;

		}

		private void Label_bottom_MouseDown(object sender, MouseEventArgs e)
		{
			isdragging = true;
			delta = e.Location;
		}

		private void Label_bottom_MouseMove(object sender, MouseEventArgs e)
		{
			if (isdragging == true)
			{


				var mousePositionOnForm = PointToClient(Control.MousePosition);
				var newX = mousePositionOnForm.X - delta.X;
				var newY = mousePositionOnForm.Y - delta.Y;

				Label_bottom.Location = new Point(newX, newY);
			}
		}

		private void Label_bottom_MouseUp(object sender, MouseEventArgs e)
		{
			isdragging = false;
			delta = Point.Empty;
		}

		private void SizeBar_top_ValueChanged(object sender, EventArgs e)
		{
			Label_top.Font = new Font(Label_top.Font.FontFamily, SizeBar_top.Value);
		}
		
		private void SizeBar_bottom_ValueChanged_1(object sender, EventArgs e)
		{
			Label_bottom.Font = new Font(Label_bottom.Font.FontFamily, SizeBar_bottom.Value);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}

}
