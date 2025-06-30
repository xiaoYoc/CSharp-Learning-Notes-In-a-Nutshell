using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.游戏资源;

namespace 贪吃蛇.场景
{
    public class GameRunning : ISceneUpdate
    {
        public GameRunning()
        {
            Wap = new Wap();
            Food = new Food();
            Snack = new Snack();
        }
        public Wap Wap { get; set; }

        public Food Food { get; set; }

        public Snack Snack { get; set; }

        private int count = 0;
        public void update()
        {
            Console.Clear();

            Wap.Draw();//画墙
            Food.CreatFood(Snack);
            while (true)
            {
                if (count % 66666666 == 0)
                {
                    if (Console.KeyAvailable)
                    {
                        Snack.ChangeDir(Console.ReadKey(true).Key);
                    }
                    Snack.Move(Snack.dir);
                    if (Snack.Judge(Wap, Snack.dir))
                    {
                        break;
                    }
                    else 
                    {
                        Snack.Draw();
                        if (Snack.EatFood(Food))
                        {
                            Food.CreatFood(Snack);
                        }
                    } 
                    count = 0;
                }
                count++;
            }
            //切换场景
            Game.ChangeScene(Progress.End);
        }
    }
}
