using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.场景
{
    public class GameEnd : GameStartOrEnd
    {
        public override string Title { get; } = "游戏结束";
        public override string StartOption { get; } = "返回主界面";
        /// <summary>
        /// 选项卡选择
        /// </summary>
        public override void Select()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                    colorIndex = 0;
                    break;
                case ConsoleKey.S:
                    colorIndex = 1;
                    break;
                case ConsoleKey.Enter:
                    if (colorIndex == 0) Game.ChangeScene(Progress.Begin);//进入游戏开始界面
                    else Environment.Exit(0);//结束游戏
                    break;
            }
        }
    }
}
