using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.游戏资源
{
    public abstract class DrawObject : IDraw
    {
        public Position pos;
        public void Draw()
        {
            switch(pos.type)
            {
                case Grid.Normal:
                    Game.WriteContent(pos.x, pos.y, "■", ConsoleColor.Yellow);
                    break;
                case Grid.SnackFood:
                    Game.WriteContent(pos.x, pos.y, "★", ConsoleColor.Cyan);
                    break;
                case Grid.SnackBody:
                    Game.WriteContent(pos.x,pos.y,"◎",ConsoleColor.Green);
                    break;
                case Grid.SnackHead:
                    Game.WriteContent(pos.x, pos.y, "●", ConsoleColor.Red);
                    break;
            }
        }
    }
}
