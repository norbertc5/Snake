namespace snake
{
	partial class Screen
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox SnakeHead;
		private System.Windows.Forms.Timer MainTimer;
		private System.Windows.Forms.PictureBox Apple;
		
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.SnakeHead = new System.Windows.Forms.PictureBox();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.Apple = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).BeginInit();
            this.SuspendLayout();
            // 
            // SnakeHead
            // 
            this.SnakeHead.BackColor = System.Drawing.Color.Blue;
            this.SnakeHead.Location = new System.Drawing.Point(10, 10);
            this.SnakeHead.Name = "SnakeHead";
            this.SnakeHead.Size = new System.Drawing.Size(20, 20);
            this.SnakeHead.TabIndex = 0;
            this.SnakeHead.TabStop = false;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimerTick);
            // 
            // Apple
            // 
            this.Apple.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Apple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Apple.BackgroundImage")));
            this.Apple.Location = new System.Drawing.Point(200, 10);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(20, 20);
            this.Apple.TabIndex = 1;
            this.Apple.TabStop = false;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(781, 561);
            this.Controls.Add(this.Apple);
            this.Controls.Add(this.SnakeHead);
            this.Name = "Screen";
            this.Text = "snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).EndInit();
            this.ResumeLayout(false);

		}
    }
}
