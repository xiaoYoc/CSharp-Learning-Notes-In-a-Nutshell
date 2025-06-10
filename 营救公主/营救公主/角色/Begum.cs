using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 营救公主
{
    public class Begum:Role
    {
        public Begum() 
        {
            Icon = "⭐";
            PositionX = 40;
            PositionY = 10;
            //显示公主
            GameStart.Content(PositionX,PositionY,Icon,ConsoleColor.Blue);
        }
    }
}
