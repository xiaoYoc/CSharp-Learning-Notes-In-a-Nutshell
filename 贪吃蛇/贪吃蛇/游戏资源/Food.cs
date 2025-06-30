using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.游戏资源
{
    public class Food : DrawObject
    {
        public  void CreatFood(Snack snack) 
        {
            Random r = new Random();
            bool temp = true;
            do 
            {
                while (true)
                {
                    pos.x = r.Next(4, Game.W - 5);
                    if (pos.x % 2 == 0) break;//必须是偶数
                }
                pos.y = r.Next(3, Game.H - 2);
                temp = true;
                for (int i = 0; i < snack.Count; i++)
                {
                    //不能生成在蛇身上
                    if (pos == snack.components[i].pos)
                    {
                        temp = false;
                        break;
                    }
                }
            }
            while (!temp);
            pos = new Position(pos.x,pos.y,Grid.SnackFood);
            Draw();//画食物
        }
    }
}
