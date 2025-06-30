using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.游戏资源
{

    public enum Grid
    {
        /// <summary>
        /// 普通方块
        /// </summary>
        Normal,
        /// <summary>
        /// 蛇身
        /// </summary>
        SnackBody,
        /// <summary>
        /// 蛇头
        /// </summary>
        SnackHead,
        /// <summary>
        /// 食物
        /// </summary>
        SnackFood
    }
    public struct Position
    {
        public int x;
        public int y;
        public Grid type;
        /// <summary>
        /// 格子位置
        /// </summary>
        /// <param name="x">横坐标</param>
        /// <param name="y">纵坐标</param>
        /// <param name="ty">格子类型</param>
        public Position(int x,int y ,Grid ty = Grid.Normal)
        {
            this.x = x;
            this.y = y;
            this.type = ty;
        }

        public static bool operator == (Position a,Position b)
        {
            if(a.x == b.x && a.y == b.y) return true;
            return false;
        }
        public static bool operator !=(Position a, Position b)
        {
            if (a.x == b.x && a.y == b.y) return false;
            return true;
        }
    }
}
