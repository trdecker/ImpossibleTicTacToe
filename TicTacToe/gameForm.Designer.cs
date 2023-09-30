namespace TicTacToe
{
    partial class gameForm
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
            this.topLeft = new System.Windows.Forms.PictureBox();
            this.topRight = new System.Windows.Forms.PictureBox();
            this.topMiddle = new System.Windows.Forms.PictureBox();
            this.middleRight = new System.Windows.Forms.PictureBox();
            this.middleMiddle = new System.Windows.Forms.PictureBox();
            this.middleLeft = new System.Windows.Forms.PictureBox();
            this.bottomRight = new System.Windows.Forms.PictureBox();
            this.bottomMiddle = new System.Windows.Forms.PictureBox();
            this.bottomLeft = new System.Windows.Forms.PictureBox();
            this.lineLeft = new System.Windows.Forms.PictureBox();
            this.lineRight = new System.Windows.Forms.PictureBox();
            this.lineTop = new System.Windows.Forms.PictureBox();
            this.lineBottom = new System.Windows.Forms.PictureBox();
            this.turnLabel = new System.Windows.Forms.Label();
            this.turnLabelName = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameOverMessage = new System.Windows.Forms.Label();
            this.onePlayerRadio = new System.Windows.Forms.RadioButton();
            this.onePlayerImpossibleRadio = new System.Windows.Forms.RadioButton();
            this.twoPlayerRadio = new System.Windows.Forms.RadioButton();
            this.startGameGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBottom)).BeginInit();
            this.startGameGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLeft
            // 
            this.topLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topLeft.Location = new System.Drawing.Point(41, 54);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(91, 89);
            this.topLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topLeft.TabIndex = 0;
            this.topLeft.TabStop = false;
            this.topLeft.Visible = false;
            this.topLeft.Click += new System.EventHandler(this.topLeft_Click);
            // 
            // topRight
            // 
            this.topRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topRight.Location = new System.Drawing.Point(260, 55);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(91, 89);
            this.topRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topRight.TabIndex = 1;
            this.topRight.TabStop = false;
            this.topRight.Visible = false;
            this.topRight.Click += new System.EventHandler(this.topRight_Click);
            // 
            // topMiddle
            // 
            this.topMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topMiddle.Location = new System.Drawing.Point(151, 53);
            this.topMiddle.Name = "topMiddle";
            this.topMiddle.Size = new System.Drawing.Size(91, 89);
            this.topMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topMiddle.TabIndex = 2;
            this.topMiddle.TabStop = false;
            this.topMiddle.Visible = false;
            this.topMiddle.Click += new System.EventHandler(this.topTop_Click);
            // 
            // middleRight
            // 
            this.middleRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleRight.Location = new System.Drawing.Point(260, 162);
            this.middleRight.Name = "middleRight";
            this.middleRight.Size = new System.Drawing.Size(91, 89);
            this.middleRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.middleRight.TabIndex = 3;
            this.middleRight.TabStop = false;
            this.middleRight.Visible = false;
            this.middleRight.Click += new System.EventHandler(this.middleRight_Click);
            // 
            // middleMiddle
            // 
            this.middleMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleMiddle.Location = new System.Drawing.Point(151, 160);
            this.middleMiddle.Name = "middleMiddle";
            this.middleMiddle.Size = new System.Drawing.Size(91, 89);
            this.middleMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.middleMiddle.TabIndex = 4;
            this.middleMiddle.TabStop = false;
            this.middleMiddle.Visible = false;
            this.middleMiddle.Click += new System.EventHandler(this.middleMiddle_Click);
            // 
            // middleLeft
            // 
            this.middleLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.middleLeft.Location = new System.Drawing.Point(44, 161);
            this.middleLeft.Name = "middleLeft";
            this.middleLeft.Size = new System.Drawing.Size(91, 89);
            this.middleLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.middleLeft.TabIndex = 5;
            this.middleLeft.TabStop = false;
            this.middleLeft.Visible = false;
            this.middleLeft.Click += new System.EventHandler(this.middleLeft_Click);
            // 
            // bottomRight
            // 
            this.bottomRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomRight.Location = new System.Drawing.Point(259, 266);
            this.bottomRight.Name = "bottomRight";
            this.bottomRight.Size = new System.Drawing.Size(91, 89);
            this.bottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomRight.TabIndex = 6;
            this.bottomRight.TabStop = false;
            this.bottomRight.Visible = false;
            this.bottomRight.Click += new System.EventHandler(this.bottomRight_Click);
            // 
            // bottomMiddle
            // 
            this.bottomMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomMiddle.Location = new System.Drawing.Point(151, 266);
            this.bottomMiddle.Name = "bottomMiddle";
            this.bottomMiddle.Size = new System.Drawing.Size(91, 89);
            this.bottomMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomMiddle.TabIndex = 7;
            this.bottomMiddle.TabStop = false;
            this.bottomMiddle.Visible = false;
            this.bottomMiddle.Click += new System.EventHandler(this.bottomMiddle_Click);
            // 
            // bottomLeft
            // 
            this.bottomLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottomLeft.Location = new System.Drawing.Point(43, 266);
            this.bottomLeft.Name = "bottomLeft";
            this.bottomLeft.Size = new System.Drawing.Size(91, 89);
            this.bottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bottomLeft.TabIndex = 8;
            this.bottomLeft.TabStop = false;
            this.bottomLeft.Visible = false;
            this.bottomLeft.Click += new System.EventHandler(this.bottomLeft_Click);
            // 
            // lineLeft
            // 
            this.lineLeft.BackColor = System.Drawing.Color.Black;
            this.lineLeft.Location = new System.Drawing.Point(139, 53);
            this.lineLeft.Name = "lineLeft";
            this.lineLeft.Size = new System.Drawing.Size(7, 311);
            this.lineLeft.TabIndex = 9;
            this.lineLeft.TabStop = false;
            this.lineLeft.Visible = false;
            // 
            // lineRight
            // 
            this.lineRight.BackColor = System.Drawing.Color.Black;
            this.lineRight.Location = new System.Drawing.Point(248, 53);
            this.lineRight.Name = "lineRight";
            this.lineRight.Size = new System.Drawing.Size(7, 311);
            this.lineRight.TabIndex = 10;
            this.lineRight.TabStop = false;
            this.lineRight.Visible = false;
            // 
            // lineTop
            // 
            this.lineTop.BackColor = System.Drawing.Color.Black;
            this.lineTop.Location = new System.Drawing.Point(40, 149);
            this.lineTop.Name = "lineTop";
            this.lineTop.Size = new System.Drawing.Size(313, 5);
            this.lineTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineTop.TabIndex = 11;
            this.lineTop.TabStop = false;
            this.lineTop.Visible = false;
            // 
            // lineBottom
            // 
            this.lineBottom.BackColor = System.Drawing.Color.Black;
            this.lineBottom.Location = new System.Drawing.Point(40, 255);
            this.lineBottom.Name = "lineBottom";
            this.lineBottom.Size = new System.Drawing.Size(313, 5);
            this.lineBottom.TabIndex = 12;
            this.lineBottom.TabStop = false;
            this.lineBottom.Visible = false;
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Location = new System.Drawing.Point(480, 67);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(49, 20);
            this.turnLabel.TabIndex = 14;
            this.turnLabel.Text = "Turn: ";
            this.turnLabel.Visible = false;
            // 
            // turnLabelName
            // 
            this.turnLabelName.AutoSize = true;
            this.turnLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabelName.Location = new System.Drawing.Point(535, 60);
            this.turnLabelName.Name = "turnLabelName";
            this.turnLabelName.Size = new System.Drawing.Size(36, 36);
            this.turnLabelName.TabIndex = 15;
            this.turnLabelName.Text = "X";
            this.turnLabelName.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(33, 113);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 42);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Begin Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Clicked);
            // 
            // gameOverMessage
            // 
            this.gameOverMessage.AutoSize = true;
            this.gameOverMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverMessage.Location = new System.Drawing.Point(442, 110);
            this.gameOverMessage.Name = "gameOverMessage";
            this.gameOverMessage.Size = new System.Drawing.Size(148, 55);
            this.gameOverMessage.TabIndex = 17;
            this.gameOverMessage.Text = "NULL";
            this.gameOverMessage.Visible = false;
            // 
            // onePlayerRadio
            // 
            this.onePlayerRadio.AutoSize = true;
            this.onePlayerRadio.Location = new System.Drawing.Point(54, 25);
            this.onePlayerRadio.Name = "onePlayerRadio";
            this.onePlayerRadio.Size = new System.Drawing.Size(111, 24);
            this.onePlayerRadio.TabIndex = 19;
            this.onePlayerRadio.TabStop = true;
            this.onePlayerRadio.Text = "One Player";
            this.onePlayerRadio.UseVisualStyleBackColor = true;
            this.onePlayerRadio.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // onePlayerImpossibleRadio
            // 
            this.onePlayerImpossibleRadio.AutoSize = true;
            this.onePlayerImpossibleRadio.Location = new System.Drawing.Point(54, 53);
            this.onePlayerImpossibleRadio.Name = "onePlayerImpossibleRadio";
            this.onePlayerImpossibleRadio.Size = new System.Drawing.Size(213, 24);
            this.onePlayerImpossibleRadio.TabIndex = 20;
            this.onePlayerImpossibleRadio.TabStop = true;
            this.onePlayerImpossibleRadio.Text = "One Player IMPOSSIBLE";
            this.onePlayerImpossibleRadio.UseVisualStyleBackColor = true;
            this.onePlayerImpossibleRadio.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // twoPlayerRadio
            // 
            this.twoPlayerRadio.AutoSize = true;
            this.twoPlayerRadio.Location = new System.Drawing.Point(54, 83);
            this.twoPlayerRadio.Name = "twoPlayerRadio";
            this.twoPlayerRadio.Size = new System.Drawing.Size(110, 24);
            this.twoPlayerRadio.TabIndex = 21;
            this.twoPlayerRadio.TabStop = true;
            this.twoPlayerRadio.Text = "Two Player";
            this.twoPlayerRadio.UseVisualStyleBackColor = true;
            this.twoPlayerRadio.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // startGameGroup
            // 
            this.startGameGroup.Controls.Add(this.onePlayerRadio);
            this.startGameGroup.Controls.Add(this.twoPlayerRadio);
            this.startGameGroup.Controls.Add(this.onePlayerImpossibleRadio);
            this.startGameGroup.Controls.Add(this.startButton);
            this.startGameGroup.Location = new System.Drawing.Point(219, 101);
            this.startGameGroup.Name = "startGameGroup";
            this.startGameGroup.Size = new System.Drawing.Size(291, 174);
            this.startGameGroup.TabIndex = 22;
            this.startGameGroup.TabStop = false;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 402);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.startGameGroup);
            this.Controls.Add(this.lineBottom);
            this.Controls.Add(this.lineTop);
            this.Controls.Add(this.lineRight);
            this.Controls.Add(this.lineLeft);
            this.Controls.Add(this.gameOverMessage);
            this.Controls.Add(this.turnLabelName);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.bottomLeft);
            this.Controls.Add(this.bottomMiddle);
            this.Controls.Add(this.bottomRight);
            this.Controls.Add(this.middleLeft);
            this.Controls.Add(this.middleMiddle);
            this.Controls.Add(this.middleRight);
            this.Controls.Add(this.topMiddle);
            this.Controls.Add(this.topRight);
            this.Name = "gameForm";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.gameFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBottom)).EndInit();
            this.startGameGroup.ResumeLayout(false);
            this.startGameGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox topLeft;
        private System.Windows.Forms.PictureBox topRight;
        private System.Windows.Forms.PictureBox topMiddle;
        private System.Windows.Forms.PictureBox middleRight;
        private System.Windows.Forms.PictureBox middleMiddle;
        private System.Windows.Forms.PictureBox middleLeft;
        private System.Windows.Forms.PictureBox bottomRight;
        private System.Windows.Forms.PictureBox bottomMiddle;
        private System.Windows.Forms.PictureBox bottomLeft;
        private System.Windows.Forms.PictureBox lineLeft;
        private System.Windows.Forms.PictureBox lineRight;
        private System.Windows.Forms.PictureBox lineTop;
        private System.Windows.Forms.PictureBox lineBottom;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label turnLabelName;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label gameOverMessage;
        private System.Windows.Forms.RadioButton onePlayerRadio;
        private System.Windows.Forms.RadioButton onePlayerImpossibleRadio;
        private System.Windows.Forms.RadioButton twoPlayerRadio;
        private System.Windows.Forms.GroupBox startGameGroup;
    }
}

