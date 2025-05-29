namespace AirHockeyGame
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
            this.gameTitlePicture = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.quitButton = new AirHockeyGame.RJControls.RJButton();
            this.startButton = new AirHockeyGame.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.gameTitlePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTitlePicture
            // 
            this.gameTitlePicture.BackColor = System.Drawing.Color.Transparent;
            this.gameTitlePicture.Image = global::AirHockeyGame.Properties.Resources.air_hockey_logo;
            this.gameTitlePicture.Location = new System.Drawing.Point(12, 12);
            this.gameTitlePicture.Name = "gameTitlePicture";
            this.gameTitlePicture.Size = new System.Drawing.Size(562, 289);
            this.gameTitlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameTitlePicture.TabIndex = 1;
            this.gameTitlePicture.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.AutoSize = true;
            this.textBox.BackColor = System.Drawing.Color.Transparent;
            this.textBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(130, 623);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(308, 20);
            this.textBox.TabIndex = 5;
            this.textBox.Text = "Scott\'s Airhockey 2025. Style unmatched. ";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.BackColor = System.Drawing.Color.Transparent;
            this.player2Label.Font = new System.Drawing.Font("Bahnschrift", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.ForeColor = System.Drawing.Color.White;
            this.player2Label.Location = new System.Drawing.Point(24, 260);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(48, 54);
            this.player2Label.TabIndex = 10;
            this.player2Label.Text = "0";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player2Label.Visible = false;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.BackColor = System.Drawing.Color.Transparent;
            this.player1Label.Font = new System.Drawing.Font("Bahnschrift", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.ForeColor = System.Drawing.Color.White;
            this.player1Label.Location = new System.Drawing.Point(24, 376);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(48, 54);
            this.player1Label.TabIndex = 11;
            this.player1Label.Text = "0";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.player1Label.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Bahnschrift", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(125, 304);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(48, 54);
            this.winLabel.TabIndex = 12;
            this.winLabel.Text = "0";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Black;
            this.quitButton.BackgroundColor = System.Drawing.Color.Black;
            this.quitButton.BorderColor = System.Drawing.Color.Black;
            this.quitButton.BorderRadius = 35;
            this.quitButton.BorderSize = 0;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.Orange;
            this.quitButton.Location = new System.Drawing.Point(199, 440);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(176, 60);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "QUIT";
            this.quitButton.TextColor = System.Drawing.Color.Orange;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.BackgroundColor = System.Drawing.Color.Black;
            this.startButton.BorderColor = System.Drawing.Color.Black;
            this.startButton.BorderRadius = 35;
            this.startButton.BorderSize = 0;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Orange;
            this.startButton.Location = new System.Drawing.Point(199, 331);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(176, 60);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "START";
            this.startButton.TextColor = System.Drawing.Color.Orange;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::AirHockeyGame.Properties.Resources.pattern_seamless_memphis_geometric_graphic_pattern_136321_786;
            this.ClientSize = new System.Drawing.Size(592, 652);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.gameTitlePicture);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Air Hockey Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameTitlePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox gameTitlePicture;
        private System.Windows.Forms.Label textBox;
        private System.Windows.Forms.Timer gameTimer;
        private RJControls.RJButton startButton;
        private RJControls.RJButton quitButton;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label winLabel;
    }
}

