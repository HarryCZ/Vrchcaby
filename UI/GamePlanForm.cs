using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vrchcaby.Logic;
using Vrchcaby.UI;

namespace Vrchcaby
{
    public partial class GamePlanForm : Form
    {
        public Game Game = new Game();

        PictureBox[] DiceSpots;
        
        public GamePlanForm()
        {
            InitializeComponent();

            GameMenuForm gameMenu = new GameMenuForm(this);
            gameMenu.ShowDialog();
            DiceSpots = new PictureBox[6] {diceSpot1, diceSpot2, diceSpot3, diceSpot4, diceSpot5, diceSpot6};
            Game.InitDices(DiceSpots);
            initGamePlan();
        }

        private void initGamePlan()
        {
            //Fill players results table
            for (int i = 0; i < Game.Players.Count; i++)
            {
                resultsPannel.ColumnCount++;
                resultsPannel.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94));
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Name, Name = "labelPlayer" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 0);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.One.ToString(), Name = "labelOne" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 1);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.Two.ToString(), Name = "labelTwo" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 2);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.Three.ToString(), Name = "labelThree" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 3);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.Four.ToString(), Name = "labelFour" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 4);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.Five.ToString(), Name = "labelFive" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 5);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.Six.ToString(), Name = "labelSix" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 6);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.Row.ToString(), Name = "labelRow" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 7);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.Pairs.ToString(), Name = "labelPairs" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 8);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.PyramidTop.ToString(), Name = "labelPyramidTop" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 9);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.PyramidBottom.ToString(), Name = "labelPyramidBottom" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 10);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.Poker.ToString(), Name = "labelPoker" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 11);
                resultsPannel.Controls.Add(new Label() { Text = Game.Players.ElementAt(i).Score.General.ToString(), Name = "labelGeneral" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 12);
                resultsPannel.Controls.Add(new Label() { Text = Game.ResultCalc.CountTotalScore(Game.Players.ElementAt(i)), Name = "labelTotal" + i, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, (i + 1), 13);
            }

            resultsPannel.Width = (( 100 * Game.Players.Count ) + labelPlayers.Width + resultsPannel.Padding.Left +
                                  resultsPannel.Padding.Right);

            //Fill act player table
            labelActPlayer.Text = Game.Players.ElementAt(Game.Player).Name;
            labelThrows.Text = Game.Tries.ToString();
        }

        // Dices

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Game.GameCtrls.SelectUnselectDice(diceSpot1, Game.Dices);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Game.GameCtrls.SelectUnselectDice(diceSpot2, Game.Dices);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Game.GameCtrls.SelectUnselectDice(diceSpot3, Game.Dices);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Game.GameCtrls.SelectUnselectDice(diceSpot4, Game.Dices);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Game.GameCtrls.SelectUnselectDice(diceSpot5, Game.Dices);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Game.GameCtrls.SelectUnselectDice(diceSpot6, Game.Dices);
        }


        //Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            Game.GameCtrls.ThrowDices(Game.Dices);
            if (Game.Tries == 0)
            {
                SelectCombinationForm selectCombination = new SelectCombinationForm(this);
                selectCombination.ShowDialog();

            }
            Game.Tries++;
        }
    }
}
