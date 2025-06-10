using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 营救公主
{
    public class GameRun : IScene
    {
        public void Update()
        {
            Console.Clear();//清空
            //绘制横墙
            for (int i = 2; i <= Game.W - 4; i+=2) 
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                Console.SetCursorPosition(i, Game.H - 1);
                Console.Write("■");
                Console.SetCursorPosition(i, Game.H - 7);
                Console.Write("■");
            }
            //绘制纵墙
            for (int i = 0; i < Game.H; i ++) 
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(Game.W-2, i);
                Console.Write("■");
            }
        }
    }
}
