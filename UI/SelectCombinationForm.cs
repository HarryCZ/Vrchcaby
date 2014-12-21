using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vrchcaby.UI
{
    public partial class SelectCombinationForm : Form
    {
        private GamePlanForm gamePlan;
        public SelectCombinationForm(GamePlanForm instanceGamePlan)
        {
            InitializeComponent();
            gamePlan = instanceGamePlan;
        }

        private void combination_MouseOver(int position, Control box, Label label)
        {
            box.BackgroundImage = gamePlan.Game.GameCtrls.selectedValuePicArr[position];
        }

    }
}
