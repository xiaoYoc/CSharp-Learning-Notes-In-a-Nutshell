using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.游戏资源;

namespace 贪吃蛇
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.MainLoop();
        }
    }
}
