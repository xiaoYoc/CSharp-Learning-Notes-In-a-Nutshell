using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 营救公主
{
    public class Boss:Hostility
    {
        Boss() 
        {
            PositionY = 20;
            PositionX = 30;
            Icon = "■";
            Hp = 100;
            minAttack = 11;
            maxAttack = 13;
            InitialIcon = "???未知";
        }
        public string InitialIcon;
        public static Boss Instance { get; } = new Boss();
    }
}
