using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vrchcaby.Data;

namespace Vrchcaby.Logic
{
    public class Game
    {
        // Global properties setup
        public int Tries = 0;
        public int Player = 0;

        public List<Player> Players = new List<Player>(); 
        public List<Dice> Dices = new List<Dice>();

        public ResultCalc ResultCalc = new ResultCalc();
        public GameControls GameCtrls  = new GameControls();

        public void InitDices(PictureBox[] boxes)
        {
            for (int i = 0; i < boxes.Count(); i++)
            {
                Dice dice = new Dice();
                dice.Id = i;
                dice.Selected = false;
                dice.Value = 0;
                dice.FormElement = boxes[i];
                Dices.Add(dice);
            }
        }


    }
}
