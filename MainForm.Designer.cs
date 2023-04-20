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
            this.SnakeHead = new System.Windows.Forms.PictureBox();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.Apple = new System.Windows.Forms.PictureBox();
            this.Border1 = new System.Windows.Forms.PictureBox();
            this.Border2 = new System.Windows.Forms.PictureBox();
            this.Border3 = new System.Windows.Forms.PictureBox();
            this.Border4 = new System.Windows.Forms.PictureBox();
            this.Trigger = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trigger)).BeginInit();
            this.SuspendLayout();
            // 
            // SnakeHead
            // 
            this.SnakeHead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SnakeHead.BackColor = System.Drawing.Color.Blue;
            this.SnakeHead.Location = new System.Drawing.Point(74, 131);
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
            this.Apple.BackColor = System.Drawing.Color.Red;
            this.Apple.Location = new System.Drawing.Point(218, 131);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(20, 20);
            this.Apple.TabIndex = 1;
            this.Apple.TabStop = false;
            // 
            // Border1
            // 
            this.Border1.BackColor = System.Drawing.Color.Green;
            this.Border1.Location = new System.Drawing.Point(20, 60);
            this.Border1.Name = "Border1";
            this.Border1.Size = new System.Drawing.Size(20, 460);
            this.Border1.TabIndex = 2;
            this.Border1.TabStop = false;
            this.Border1.Tag = "GameOverWhenTouch";
            // 
            // Border2
            // 
            this.Border2.BackColor = System.Drawing.Color.Green;
            this.Border2.Location = new System.Drawing.Point(740, 60);
            this.Border2.Name = "Border2";
            this.Border2.Size = new System.Drawing.Size(20, 460);
            this.Border2.TabIndex = 3;
            this.Border2.TabStop = false;
            this.Border2.Tag = "GameOverWhenTouch";
            // 
            // Border3
            // 
            this.Border3.BackColor = System.Drawing.Color.Green;
            this.Border3.Location = new System.Drawing.Point(20, 60);
            this.Border3.Name = "Border3";
            this.Border3.Size = new System.Drawing.Size(740, 20);
            this.Border3.TabIndex = 4;
            this.Border3.TabStop = false;
            this.Border3.Tag = "GameOverWhenTouch";
            // 
            // Border4
            // 
            this.Border4.BackColor = System.Drawing.Color.Green;
            this.Border4.Location = new System.Drawing.Point(20, 500);
            this.Border4.Name = "Border4";
            this.Border4.Size = new System.Drawing.Size(740, 20);
            this.Border4.TabIndex = 5;
            this.Border4.TabStop = false;
            this.Border4.Tag = "GameOverWhenTouch";
            // 
            // Trigger
            // 
            this.Trigger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Trigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Trigger.Location = new System.Drawing.Point(115, 131);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(20, 20);
            this.Trigger.TabIndex = 6;
            this.Trigger.TabStop = false;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(781, 561);
            this.Controls.Add(this.Trigger);
            this.Controls.Add(this.Border4);
            this.Controls.Add(this.Border3);
            this.Controls.Add(this.Border2);
            this.Controls.Add(this.Border1);
            this.Controls.Add(this.Apple);
            this.Controls.Add(this.SnakeHead);
            this.Name = "Screen";
            this.Text = "snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trigger)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.PictureBox Border1;
        private System.Windows.Forms.PictureBox Border2;
        private System.Windows.Forms.PictureBox Border3;
        private System.Windows.Forms.PictureBox Border4;
        private System.Windows.Forms.PictureBox Trigger;
    }
}
