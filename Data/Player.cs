using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrchcaby.Data
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Result Score { get; set; }

        public Player()
        {
            Score = new Result();
        }
    }
}
