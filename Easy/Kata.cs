using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    public class Player
    {
        public int Health { get; set; } = 100;
        public bool CheckAlive() => this.Health > 0;
    }
}
