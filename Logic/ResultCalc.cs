using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vrchcaby.Data;

namespace Vrchcaby.Logic
{
    public class ResultCalc
    {
        public string CountTotalScore(Player player)
        {
            int? result = 0;
            if (player.Score.One != null) result += player.Score.One;
            if (player.Score.One != null) result += player.Score.Two;
            if (player.Score.One != null) result += player.Score.Three;
            if (player.Score.One != null) result += player.Score.Four;
            if (player.Score.One != null) result += player.Score.Five;
            if (player.Score.One != null) result += player.Score.Six;
            if (player.Score.One != null) result += player.Score.Row;
            if (player.Score.One != null) result += player.Score.Pairs;
            if (player.Score.One != null) result += player.Score.PyramidTop;
            if (player.Score.One != null) result += player.Score.PyramidBottom;
            if (player.Score.One != null) result += player.Score.Poker;
            if (player.Score.One != null) result += player.Score.General;

            return result.ToString();
        }
    }
}
