using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

using System.Threading;

namespace snake
{
    public partial class Screen : Form
    {
        // enums
        enum Directions { Up, Down, Left, Right };
        enum WidthOrHeight { Width, Height };  // using to "draw" background pasks

        // lists
        List<PictureBox> snakeBodyParts = new List<PictureBox>();

        // variables
        Directions actualDirection = Directions.Right;
        int stepLenght = 20;  // how big step make snake in one tick
        Random random;
        bool canSnakeMove = true;
        PictureBox lastBodyPart;
        int gameOverTicks;  // using to game over anim

        public Screen()
        {
            InitializeComponent();
            CreateBackgroundPasks(WidthOrHeight.Width);
            CreateBackgroundPasks(WidthOrHeight.Height);

            // set start locations
            SnakeHead.Location = new Point(100, 100);
            Apple.Location = new Point(240, 100);

            random = new Random();
            snakeBodyParts.Add(SnakeHead);
            this.Controls.SetChildIndex(SnakeHead, 0);

            // set start snake lenght
            CreateBody();
            CreateBody();
        }

        void MainTimerTick(object sender, EventArgs e)
        {
            if (canSnakeMove)
            {
                #region Moving body

                for (int i = snakeBodyParts.Count - 1; i > 0; i--)
                {
                    // all snake body parts are moving to next body part location in each tick
                    snakeBodyParts[i].Location = snakeBodyParts[i - 1].Location;
                }

                #endregion

                #region Move snake head

                // move snake head according to actualDirection
                Point snakeHeadLoc = SnakeHead.Location;
                switch (actualDirection)
                {
                    case Directions.Left:
                        snakeHeadLoc = new Point(snakeHeadLoc.X - stepLenght, snakeHeadLoc.Y);
                        break;

                    case Directions.Right:
                        snakeHeadLoc = new Point(snakeHeadLoc.X + stepLenght, snakeHeadLoc.Y);
                        break;

                    case Directions.Up:
                        snakeHeadLoc = new Point(snakeHeadLoc.X, snakeHeadLoc.Y - stepLenght);
                        break;

                    case Directions.Down:
                        snakeHeadLoc = new Point(snakeHeadLoc.X, snakeHeadLoc.Y + stepLenght);
                        break;
                }

                SnakeHead.Location = snakeHeadLoc;

                #endregion
            }

            #region When eat apple

            if (SnakeHead.Bounds.IntersectsWith(Apple.Bounds))
            {
                MoveApple();
            }

            foreach (Control obj in this.Controls)
            {
                if (obj is PictureBox && (string)obj.Tag == "GameOverWhenTouch")
                {
                    if (Apple.Bounds.IntersectsWith(obj.Bounds))
                    {
                        MoveApple();
                    }
                }
            }

            #endregion

            #region Game over

            foreach (Control obj in this.Controls)
            {
                if (obj is PictureBox && (string)obj.Tag == "GameOverWhenTouch")
                {
                    if (SnakeHead.Bounds.IntersectsWith(obj.Bounds) && obj != lastBodyPart)
                    {
                        Console.WriteLine(obj.Name);
                        this.Controls.SetChildIndex(GameOverLabel, 0);
                        canSnakeMove = false;
                    }
                }
            }

            // game over anim
            if (!canSnakeMove)
            {
                gameOverTicks++;
                Console.WriteLine(gameOverTicks);
                if (gameOverTicks >= 10)
                {
                   // GameOverBackground.Visible = !GameOverBackground.Visible;
                    GameOverLabel.Visible = !GameOverLabel.Visible;
                    gameOverTicks = 0;
                }
            }

            #endregion
        }

        void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            // read input from keyboard
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && actualDirection != Directions.Right)
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
            picBox.Tag = "GameOverWhenTouch";
            picBox.Name = "Body";
            lastBodyPart = picBox;
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

            if (widthOrHeight == WidthOrHeight.Width)
                screenLenghtInAxis = this.Width;
            else if (widthOrHeight == WidthOrHeight.Height)
                screenLenghtInAxis = this.Height;

            for (int i = 0; i <= screenLenghtInAxis; i += SnakeHead.Size.Width)
            {
                PictureBox line;
                line = new PictureBox();
                line.BackColor = Color.FromArgb(50, Color.Black);  // make pasks invisible in half
                this.Controls.Add(line);

                if (widthOrHeight == WidthOrHeight.Width)
                {
                    line.Location = new Point(i, 0);
                    line.Size = new Size(1, this.Height);
                }
                else if (widthOrHeight == WidthOrHeight.Height)
                {
                    line.Location = new Point(0, i);
                    line.Size = new Size(this.Width, 1);
                }
            }
        }

        void MoveApple()
        {
            // draw lots number so that apple set in playing area
            int x = random.Next(60, Size.Width - 60);
            int y = random.Next(80, Size.Height - 100);
            Console.WriteLine("X: " + x + " Y: " + y);

            // round number and snap apple to grid
            x = (int)Math.Round(Convert.ToDecimal((x + 0.0000001) / 20.00)) * 20;
            y = (int)Math.Round(Convert.ToDecimal((y + 0.0000001) / 20.00)) * 20;

            Apple.Location = new Point(x, y);
            CreateBody();
        }
    }
}
