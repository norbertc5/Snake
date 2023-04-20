using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace snake
{
	public class BodyPart : Form
	{
		PictureBox picBox;
		
		public BodyPart()
		{
			picBox = new PictureBox();
			picBox.Location = new Point(0, 0);
			picBox.BackColor = Color.Green;
            this.Controls.Add(picBox);
        }
	}
}
