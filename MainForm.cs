using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace snake
{
	public partial class Screen : Form
	{
		enum Directions {Up, Down, Left, Right};
		enum WidthOrHeight {Width, Height};
		
		Directions actualDirection = Directions.Right;
		
		int speed = 20;
		int a;
		Random random;
		List<PictureBox> snakeBodyParts = new List<PictureBox>();
		
		public Screen()
		{
			InitializeComponent();
			CreateBackgroundPasks(WidthOrHeight.Width);
			CreateBackgroundPasks(WidthOrHeight.Height);			
			
			SnakeHead.Location = new Point(0, 0);
			random = new Random();
			snakeBodyParts.Add(SnakeHead);
			CreateBody();
        }
		
		void MainTimerTick(object sender, EventArgs e)
		{		
            #region Moving body
            for (int i = snakeBodyParts.Count - 1; i > 0; i--)
            {
            	// all snake body parts are moving to next body part location in each tick
                snakeBodyParts[i].Location = snakeBodyParts[i - 1].Location;
            }
            #endregion

            #region Movement
            // move snakeHead
            Point shl = SnakeHead.Location;
			switch(actualDirection)
			{
					case Directions.Left: shl = new Point(shl.X - speed, shl.Y);
						break;
						
					case Directions.Right: shl = new Point(shl.X + speed, shl.Y);
						break;

					case Directions.Up: shl = new Point(shl.X, shl.Y - speed);
						break;						
						
					case Directions.Down: shl = new Point(shl.X, shl.Y + speed);
						break;							
			}
			
			SnakeHead.Location = shl;			
			#endregion
			
			#region When eat apple		
			if (SnakeHead.Bounds.IntersectsWith(Apple.Bounds))
			{
                int x = random.Next(10, Size.Width - 10);
				x = (int)Math.Round(Convert.ToDecimal((x + 0.0000001) / 10.00)) * 10; // snapping to grid
                int y = random.Next(10, Size.Height - 10);
				y = (int)Math.Round(Convert.ToDecimal((y + 0.0000001) / 10.00)) * 10;
                Apple.Location = new Point(x, y);
                CreateBody();
            }
            #endregion
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			// read input from keyboard
			if((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && actualDirection != Directions.Right)
			{
				actualDirection = Directions.Left;
            }
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && actualDirection != Directions.Left)
			{
                actualDirection = Directions.Right;
            }
            else if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && actualDirection != Directions.Down)
            {
                actualDirection = Directions.Up;
            }
            else if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && actualDirection != Directions.Up)
            {
                actualDirection = Directions.Down;
            }
		}

		
		void CreateBody()
		{
			// create new snake body part
			PictureBox picBox;
            picBox = new PictureBox();
            picBox.Location = SnakeHead.Location;
            picBox.BackColor = Color.DodgerBlue;
			picBox.Size = new Size(20, 20);
			snakeBodyParts.Add(picBox);
			
			this.Controls.Add(picBox);
            this.Controls.SetChildIndex(picBox, 1);  // make that snake body is above pasks in background 
        }

		
		void CreateBackgroundPasks(WidthOrHeight widthOrHeight)
		{	
			// create pasks in background
			// pasks are creating according to widthOrHeight variable
			// if widthOrHeight equals to WidthOrHeight.Width pasks are "painting" in width and vice versa
			
			int screenLenghtInAxis = 0;
						
			if(widthOrHeight == WidthOrHeight.Width)
				screenLenghtInAxis = this.Width;
			else if(widthOrHeight == WidthOrHeight.Height)
				screenLenghtInAxis = this.Height;				
			
			for(int i = 0; i <= screenLenghtInAxis; i += SnakeHead.Size.Width)
			{
				PictureBox line;
            	line = new PictureBox();
            	line.BackColor = Color.FromArgb(50, Color.Black);  // make pasks invisible in half
            	this.Controls.Add(line);
            	
            	if(widthOrHeight == WidthOrHeight.Width)
            	{
            		line.Location = new Point(i, 0);
            		line.Size = new Size(1, this.Height);
            	}
            	else if(widthOrHeight == WidthOrHeight.Height)
            	{
            	     line.Location = new Point(0, i);
            		line.Size = new Size(this.Width, 1);
            	}
			}
		}
    }
}
