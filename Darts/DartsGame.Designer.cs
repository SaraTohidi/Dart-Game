namespace Darts
{
    partial class DartsGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DartsGame));
            this.powerMeter = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.powerTimer = new System.Windows.Forms.Timer(this.components);
            this.player1 = new System.Windows.Forms.Label();
            this.Score1ShowP1 = new System.Windows.Forms.Label();
            this.Player1T1 = new System.Windows.Forms.PictureBox();
            this.target = new System.Windows.Forms.PictureBox();
            this.board = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.Label();
            this.Score1ShowP2 = new System.Windows.Forms.Label();
            this.Player2T1 = new System.Windows.Forms.PictureBox();
            this.Score2ShowP1 = new System.Windows.Forms.Label();
            this.Score3ShowP1 = new System.Windows.Forms.Label();
            this.Score2ShowP2 = new System.Windows.Forms.Label();
            this.Score3ShowP2 = new System.Windows.Forms.Label();
            this.Player1T2 = new System.Windows.Forms.PictureBox();
            this.Player1T3 = new System.Windows.Forms.PictureBox();
            this.Player2T2 = new System.Windows.Forms.PictureBox();
            this.Player2T3 = new System.Windows.Forms.PictureBox();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player1T1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2T1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1T2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1T3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2T2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2T3)).BeginInit();
            this.SuspendLayout();
            // 
            // powerMeter
            // 
            this.powerMeter.Location = new System.Drawing.Point(40, 770);
            this.powerMeter.Margin = new System.Windows.Forms.Padding(4);
            this.powerMeter.Name = "powerMeter";
            this.powerMeter.Size = new System.Drawing.Size(538, 29);
            this.powerMeter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 728);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Power Range";
            // 
            // powerTimer
            // 
            this.powerTimer.Interval = 1;
            this.powerTimer.Tick += new System.EventHandler(this.powerTimer_Tick);
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(830, 317);
            this.player1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(91, 25);
            this.player1.TabIndex = 7;
            this.player1.Text = "Player 1";
            // 
            // Score1ShowP1
            // 
            this.Score1ShowP1.AutoSize = true;
            this.Score1ShowP1.Location = new System.Drawing.Point(945, 317);
            this.Score1ShowP1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Score1ShowP1.Name = "Score1ShowP1";
            this.Score1ShowP1.Size = new System.Drawing.Size(42, 25);
            this.Score1ShowP1.TabIndex = 8;
            this.Score1ShowP1.Text = "     ";
            // 
            // Player1T1
            // 
            this.Player1T1.Image = ((System.Drawing.Image)(resources.GetObject("Player1T1.Image")));
            this.Player1T1.InitialImage = null;
            this.Player1T1.Location = new System.Drawing.Point(1120, 518);
            this.Player1T1.Margin = new System.Windows.Forms.Padding(6);
            this.Player1T1.Name = "Player1T1";
            this.Player1T1.Size = new System.Drawing.Size(42, 46);
            this.Player1T1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1T1.TabIndex = 9;
            this.Player1T1.TabStop = false;
            // 
            // target
            // 
            this.target.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.target.BackColor = System.Drawing.Color.Transparent;
            this.target.Image = ((System.Drawing.Image)(resources.GetObject("target.Image")));
            this.target.Location = new System.Drawing.Point(332, 180);
            this.target.Margin = new System.Windows.Forms.Padding(4);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(48, 44);
            this.target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.target.TabIndex = 1;
            this.target.TabStop = false;
            // 
            // board
            // 
            this.board.Image = global::Darts.Properties.Resources.hey_play_darts_dart_boards_hw3400013_64_1000;
            this.board.Location = new System.Drawing.Point(18, 15);
            this.board.Margin = new System.Windows.Forms.Padding(4);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(734, 688);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.board.TabIndex = 0;
            this.board.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(828, 385);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(91, 25);
            this.Player2.TabIndex = 10;
            this.Player2.Text = "Player 2";
            // 
            // Score1ShowP2
            // 
            this.Score1ShowP2.AutoSize = true;
            this.Score1ShowP2.Location = new System.Drawing.Point(945, 385);
            this.Score1ShowP2.Name = "Score1ShowP2";
            this.Score1ShowP2.Size = new System.Drawing.Size(36, 25);
            this.Score1ShowP2.TabIndex = 11;
            this.Score1ShowP2.Text = "    ";
            // 
            // Player2T1
            // 
            this.Player2T1.Image = ((System.Drawing.Image)(resources.GetObject("Player2T1.Image")));
            this.Player2T1.Location = new System.Drawing.Point(1185, 518);
            this.Player2T1.Name = "Player2T1";
            this.Player2T1.Size = new System.Drawing.Size(42, 46);
            this.Player2T1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2T1.TabIndex = 14;
            this.Player2T1.TabStop = false;
            // 
            // Score2ShowP1
            // 
            this.Score2ShowP1.AutoSize = true;
            this.Score2ShowP1.Location = new System.Drawing.Point(1021, 317);
            this.Score2ShowP1.Name = "Score2ShowP1";
            this.Score2ShowP1.Size = new System.Drawing.Size(30, 25);
            this.Score2ShowP1.TabIndex = 15;
            this.Score2ShowP1.Text = "   ";
            // 
            // Score3ShowP1
            // 
            this.Score3ShowP1.AutoSize = true;
            this.Score3ShowP1.Location = new System.Drawing.Point(1085, 317);
            this.Score3ShowP1.Name = "Score3ShowP1";
            this.Score3ShowP1.Size = new System.Drawing.Size(36, 25);
            this.Score3ShowP1.TabIndex = 16;
            this.Score3ShowP1.Text = "    ";
            // 
            // Score2ShowP2
            // 
            this.Score2ShowP2.AutoSize = true;
            this.Score2ShowP2.Location = new System.Drawing.Point(1021, 385);
            this.Score2ShowP2.Name = "Score2ShowP2";
            this.Score2ShowP2.Size = new System.Drawing.Size(30, 25);
            this.Score2ShowP2.TabIndex = 17;
            this.Score2ShowP2.Text = "   ";
            // 
            // Score3ShowP2
            // 
            this.Score3ShowP2.AutoSize = true;
            this.Score3ShowP2.Location = new System.Drawing.Point(1100, 385);
            this.Score3ShowP2.Name = "Score3ShowP2";
            this.Score3ShowP2.Size = new System.Drawing.Size(42, 25);
            this.Score3ShowP2.TabIndex = 18;
            this.Score3ShowP2.Text = "     ";
            // 
            // Player1T2
            // 
            this.Player1T2.Image = ((System.Drawing.Image)(resources.GetObject("Player1T2.Image")));
            this.Player1T2.Location = new System.Drawing.Point(1120, 574);
            this.Player1T2.Name = "Player1T2";
            this.Player1T2.Size = new System.Drawing.Size(42, 46);
            this.Player1T2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1T2.TabIndex = 20;
            this.Player1T2.TabStop = false;
            // 
            // Player1T3
            // 
            this.Player1T3.Image = ((System.Drawing.Image)(resources.GetObject("Player1T3.Image")));
            this.Player1T3.Location = new System.Drawing.Point(1120, 627);
            this.Player1T3.Name = "Player1T3";
            this.Player1T3.Size = new System.Drawing.Size(42, 46);
            this.Player1T3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1T3.TabIndex = 21;
            this.Player1T3.TabStop = false;
            // 
            // Player2T2
            // 
            this.Player2T2.Image = ((System.Drawing.Image)(resources.GetObject("Player2T2.Image")));
            this.Player2T2.Location = new System.Drawing.Point(1185, 574);
            this.Player2T2.Name = "Player2T2";
            this.Player2T2.Size = new System.Drawing.Size(42, 46);
            this.Player2T2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2T2.TabIndex = 22;
            this.Player2T2.TabStop = false;
            // 
            // Player2T3
            // 
            this.Player2T3.Image = ((System.Drawing.Image)(resources.GetObject("Player2T3.Image")));
            this.Player2T3.Location = new System.Drawing.Point(1185, 627);
            this.Player2T3.Name = "Player2T3";
            this.Player2T3.Size = new System.Drawing.Size(42, 46);
            this.Player2T3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2T3.TabIndex = 23;
            this.Player2T3.TabStop = false;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(835, 54);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(307, 121);
            this.NewGameButton.TabIndex = 24;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(647, 728);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(114, 72);
            this.Power.TabIndex = 25;
            this.Power.Text = "Hit!";
            this.Power.UseVisualStyleBackColor = true;
            // 
            // DartsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 820);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.Player2T3);
            this.Controls.Add(this.Player2T2);
            this.Controls.Add(this.Player1T3);
            this.Controls.Add(this.Player1T2);
            this.Controls.Add(this.Score3ShowP2);
            this.Controls.Add(this.Score2ShowP2);
            this.Controls.Add(this.Score3ShowP1);
            this.Controls.Add(this.Score2ShowP1);
            this.Controls.Add(this.Player2T1);
            this.Controls.Add(this.Score1ShowP2);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1T1);
            this.Controls.Add(this.Score1ShowP1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powerMeter);
            this.Controls.Add(this.target);
            this.Controls.Add(this.board);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DartsGame";
            this.Text = "Darts Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DartsGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player1T1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2T1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1T2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1T3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2T2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2T3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.PictureBox target;
        private System.Windows.Forms.ProgressBar powerMeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer powerTimer;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label Score1ShowP1;
        private System.Windows.Forms.PictureBox Player1T1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Score1ShowP2;
        private System.Windows.Forms.PictureBox Player2T1;
        private System.Windows.Forms.Label Score2ShowP1;
        private System.Windows.Forms.Label Score3ShowP1;
        private System.Windows.Forms.Label Score2ShowP2;
        private System.Windows.Forms.Label Score3ShowP2;
        private System.Windows.Forms.PictureBox Player1T2;
        private System.Windows.Forms.PictureBox Player1T3;
        private System.Windows.Forms.PictureBox Player2T2;
        private System.Windows.Forms.PictureBox Player2T3;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button Power;
    }
}

