using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.游戏资源
{
    public class Wap : IDraw
    {
        public Wall[] walls;

        public Wap()
        {
            walls = new Wall[Game.W -4 + Game.H*2];
            //walls = new Wall[300];
        }
        /// <summary>
        /// 初始化墙壁(固定资源)
        /// </summary>
        public void Draw()
        {
            int tempCount = 0;
            //画横墙
            for (int i = 2; i< Game.W-3;i+=2)
            {
                walls[tempCount++] = new Wall(i,0);
                walls[tempCount++] = new Wall(i,Game.H-1);
            }
            foreach (Wall wall in walls)
            {
                wall?.Draw();
            }
            //画纵墙
            for (int i = 0;i <= Game.H-1; i++)
            {
                walls[tempCount++] = new Wall(0, i);
                walls[tempCount++] = new Wall(Game.W - 2, i);
            }

            foreach (Wall wall in walls)
            {
                wall?.Draw();
            }
        }
    }
}
