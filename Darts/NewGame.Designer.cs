namespace Darts
{
    partial class NewGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(24, 171);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(540, 84);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Player2
            // 
            this.Player2.FormattingEnabled = true;
            this.Player2.Items.AddRange(new object[] {
            "Human",
            "Easy Computer",
            "Medium Computer",
            "Hard Computer"});
            this.Player2.Location = new System.Drawing.Point(128, 81);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(289, 33);
            this.Player2.TabIndex = 6;
            this.Player2.SelectedIndexChanged += new System.EventHandler(this.Player2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player 2";
            // 
            // Player1
            // 
            this.Player1.FormattingEnabled = true;
            this.Player1.Items.AddRange(new object[] {
            "Human",
            "Easy Computer",
            "Medium Computer",
            "Hard Computer"});
            this.Player1.Location = new System.Drawing.Point(128, 26);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(289, 33);
            this.Player1.TabIndex = 7;
            this.Player1.SelectedIndexChanged += new System.EventHandler(this.Player1_SelectedIndexChanged);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1072, 562);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox Player2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Player1;
    }
}