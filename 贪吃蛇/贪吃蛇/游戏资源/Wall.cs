using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.游戏资源
{
    /// <summary>
    /// 普通方块
    /// </summary>
    public class Wall : DrawObject
    {
        public Wall(int x,int y)
        {
            pos = new Position(x,y);
        }
        //public override void Draw()
        //{
        //    Game.WriteContent(pos.x, pos.y,"■",ConsoleColor.Red);
        //}
    }
}
