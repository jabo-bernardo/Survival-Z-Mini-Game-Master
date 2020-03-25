using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting_Games.Classes
{
    abstract class Gun
    {

        public int bulletVelocity { get; set; }

        public Gun(int bulletVelocity)
        {
            this.bulletVelocity = bulletVelocity;
        }

    }
}
