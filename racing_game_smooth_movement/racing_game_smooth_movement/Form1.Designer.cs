namespace racing_game_smooth_movement
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
            this.auto = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.gameTimerEvent = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.auto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            this.SuspendLayout();
            // 
            // auto
            // 
            this.auto.BackColor = System.Drawing.Color.Transparent;
            this.auto.Image = ((System.Drawing.Image)(resources.GetObject("auto.Image")));
            this.auto.Location = new System.Drawing.Point(206, 496);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(34, 71);
            this.auto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.auto.TabIndex = 13;
            this.auto.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(261, -43);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(38, 36);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin1.TabIndex = 33;
            this.coin1.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.BackColor = System.Drawing.Color.White;
            this.pic7.Location = new System.Drawing.Point(261, -103);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(10, 45);
            this.pic7.TabIndex = 31;
            this.pic7.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.White;
            this.pic1.Location = new System.Drawing.Point(261, 509);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(10, 45);
            this.pic1.TabIndex = 30;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.White;
            this.pic2.Location = new System.Drawing.Point(261, 407);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(10, 45);
            this.pic2.TabIndex = 29;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.White;
            this.pic3.Location = new System.Drawing.Point(261, 305);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(10, 45);
            this.pic3.TabIndex = 28;
            this.pic3.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.White;
            this.pic5.Location = new System.Drawing.Point(261, 101);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(10, 45);
            this.pic5.TabIndex = 27;
            this.pic5.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.White;
            this.pic4.Location = new System.Drawing.Point(261, 203);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(10, 45);
            this.pic4.TabIndex = 26;
            this.pic4.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.Color.White;
            this.pic6.Location = new System.Drawing.Point(261, -1);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(10, 45);
            this.pic6.TabIndex = 25;
            this.pic6.TabStop = false;
            // 
            // gameTimerEvent
            // 
            this.gameTimerEvent.Enabled = true;
            this.gameTimerEvent.Interval = 10;
            this.gameTimerEvent.Tick += new System.EventHandler(this.gameTimerEvent_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(545, 606);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.auto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.auto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox auto;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.Timer gameTimerEvent;
    }
}

