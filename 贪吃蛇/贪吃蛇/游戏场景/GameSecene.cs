using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    public class GameSecene : ISeceneUpdate
    {
        public void Update()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("游戏场景");
        }
    }
}
