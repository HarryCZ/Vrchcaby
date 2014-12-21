using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vrchcaby.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vrchcaby.Logic
{
    public class GameControls
    {
        public Image[] DiceValuePicArr = new Image[6]
        {
            Properties.Resources.dice1, Properties.Resources.dice2, Properties.Resources.dice3, Properties.Resources.dice4,
            Properties.Resources.dice5, Properties.Resources.dice6
        };

        public Image[] selectedValuePicArr = new Image[6]
        {
            Properties.Resources.diceSelected1, Properties.Resources.diceSelected2, Properties.Resources.diceSelected3,
            Properties.Resources.diceSelected4, Properties.Resources.diceSelected5, Properties.Resources.diceSelected6
        };

        public void ThrowDices(List<Dice> dices)
        {
            foreach (var dice in dices)
            {
                if (!dice.Selected) ThrowResult(dice);
            }
        }

        public void ThrowResult(Dice dice)
        {
            System.Threading.Thread.Sleep(10);  //zpozdeni aby random vracel ruzne hodnoty
            var rnd = new Random();
            var throwResult = rnd.Next(6);
            dice.Value = throwResult + 1;
            dice.FormElement.BackgroundImage = GetThrowImage(throwResult);
        }

        public Image GetThrowImage(int throwResult)
        {
            return DiceValuePicArr[throwResult];
        }

        public void SelectUnselectDice(PictureBox pictureBox, List<Dice> dices)
        {
            Dice dice = FindDiceByName(pictureBox.Name, dices);
            if (!dice.Selected)
            {
                dice.Selected = true;
                pictureBox.BackgroundImage = selectedValuePicArr[(dice.Value - 1)];
            }
            else
            {
                dice.Selected = false;
                pictureBox.BackgroundImage = DiceValuePicArr[(dice.Value - 1)];
            }


        }

        public Dice FindDiceByName(string name, List<Dice> dices)
        {
            return dices.FirstOrDefault(dice => dice.FormElement.Name == name);
        }
    }
}
