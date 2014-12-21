using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vrchcaby.Data;

namespace Vrchcaby.UI
{
    public partial class GameMenuForm : Form
    {
        private GamePlanForm gamePlan;
        TextBox[] playerInputs = new TextBox[4];

        public GameMenuForm(GamePlanForm instanceGamePlan)
        {
            InitializeComponent();
            gamePlan = instanceGamePlan;
            playerInputs[0] = inputPlayer1;
            playerInputs[1] = inputPlayer2;
            playerInputs[2] = inputPlayer3;
            playerInputs[3] = inputPlayer4;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playerInputs.Count(); i++)
            {
                if (playerInputs[i].Text != "")
                {
                    Player newPlayer = new Player();
                    newPlayer.Id = 0;
                    newPlayer.Name = playerInputs[i].Text;
                    gamePlan.Game.Players.Add(newPlayer);
                }    
            }
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
