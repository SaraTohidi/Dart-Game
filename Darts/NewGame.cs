using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darts
{
    public partial class NewGame : Form
    {
        private readonly DartsGame mainForm;
        public String firstPlayer, secondPlayer;

        public NewGame(DartsGame mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Player1.SelectedIndex > -1  && Player2.SelectedIndex > -1)
            {
                startButton.Enabled = true;

                mainForm.InitializePlayers(firstPlayer, secondPlayer);

                this.Hide();
            }
        }

        private void Player1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Player1.Text))
            {

                if (Player1.Text == "Easy Computer")
                {
                    firstPlayer = "Easy Computer";
                }
                else if (Player1.Text == "Human")
                {
                    firstPlayer = "Human";
                }
                else if (Player1.Text == "Medium Computer")
                {
                    firstPlayer = "Medium Computer";
                }
                else if (Player1.Text == "Hard Computer")
                {
                    firstPlayer = "Hard Computer";
                }
            }

        }

        private void Player2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Player2.Text))
            {
                if (Player2.Text == "Easy Computer")
                {
                    secondPlayer = "Easy Computer";
                }
                else if (Player2.Text == "Human")
                {
                    secondPlayer = "Human";
                }
                else if (Player2.Text == "Medium Computer")
                {
                    secondPlayer = "Medium Computer";
                }
                else if (Player2.Text == "Hard Computer")
                {
                    secondPlayer = "Hard Computer";
                }
            }
        }
    }
}
