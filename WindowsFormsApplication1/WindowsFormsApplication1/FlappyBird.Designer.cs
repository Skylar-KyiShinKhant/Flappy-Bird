namespace WindowsFormsApplication1
{
    partial class FlappyBird
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
            this.bird = new System.Windows.Forms.PictureBox();
            this.lower1 = new System.Windows.Forms.PictureBox();
            this.upper1 = new System.Windows.Forms.PictureBox();
            this.upper2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lower2 = new System.Windows.Forms.PictureBox();
            this.lower3 = new System.Windows.Forms.PictureBox();
            this.upper3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upper3)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Image = global::WindowsFormsApplication1.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(121, 343);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(122, 97);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // lower1
            // 
            this.lower1.Image = global::WindowsFormsApplication1.Properties.Resources.pipe;
            this.lower1.Location = new System.Drawing.Point(507, 519);
            this.lower1.Name = "lower1";
            this.lower1.Size = new System.Drawing.Size(172, 355);
            this.lower1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lower1.TabIndex = 6;
            this.lower1.TabStop = false;
            // 
            // upper1
            // 
            this.upper1.Image = global::WindowsFormsApplication1.Properties.Resources.pipedown;
            this.upper1.Location = new System.Drawing.Point(679, -63);
            this.upper1.Name = "upper1";
            this.upper1.Size = new System.Drawing.Size(172, 391);
            this.upper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upper1.TabIndex = 9;
            this.upper1.TabStop = false;
            // 
            // upper2
            // 
            this.upper2.Image = global::WindowsFormsApplication1.Properties.Resources.pipedown;
            this.upper2.Location = new System.Drawing.Point(1333, -2);
            this.upper2.Name = "upper2";
            this.upper2.Size = new System.Drawing.Size(172, 391);
            this.upper2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upper2.TabIndex = 10;
            this.upper2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ground
            // 
            this.ground.Image = global::WindowsFormsApplication1.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 871);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1583, 166);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 927);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 61);
            this.label1.TabIndex = 11;
            // 
            // lower2
            // 
            this.lower2.Image = global::WindowsFormsApplication1.Properties.Resources.pipe;
            this.lower2.Location = new System.Drawing.Point(1074, 682);
            this.lower2.Name = "lower2";
            this.lower2.Size = new System.Drawing.Size(172, 355);
            this.lower2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lower2.TabIndex = 12;
            this.lower2.TabStop = false;
            // 
            // lower3
            // 
            this.lower3.Image = global::WindowsFormsApplication1.Properties.Resources.pipe;
            this.lower3.Location = new System.Drawing.Point(1682, 583);
            this.lower3.Name = "lower3";
            this.lower3.Size = new System.Drawing.Size(172, 355);
            this.lower3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lower3.TabIndex = 13;
            this.lower3.TabStop = false;
            // 
            // upper3
            // 
            this.upper3.Image = global::WindowsFormsApplication1.Properties.Resources.pipedown;
            this.upper3.Location = new System.Drawing.Point(1867, -127);
            this.upper3.Name = "upper3";
            this.upper3.Size = new System.Drawing.Size(172, 391);
            this.upper3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upper3.TabIndex = 14;
            this.upper3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 78);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 39);
            this.label4.TabIndex = 17;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1563, 1022);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upper3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upper2);
            this.Controls.Add(this.upper1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.lower2);
            this.Controls.Add(this.lower1);
            this.Controls.Add(this.lower3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FlappyBird_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upper3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox lower1;
        private System.Windows.Forms.PictureBox upper1;
        private System.Windows.Forms.PictureBox upper2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lower2;
        private System.Windows.Forms.PictureBox lower3;
        private System.Windows.Forms.PictureBox upper3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}

