using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 营救公主
{
    public abstract class StartOrEnd : IScene
    {
        protected string Title {  get; set; }
        protected string Description { get; set; }
        protected string EndStr { get; } = "结束游戏";
        public abstract void Update();
        /// <summary>
        /// 选择进入某场景
        /// </summary>
        /// <returns>true进入游戏场景，false退出应用程序</returns>
        public bool Select()
        {
            int index = 0;
            while (true)
            {
                char input = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (input)
                {
                    case 'W':
                        index--;
                        if (index == -1) index = 0;
                        break;
                    case 'S':
                        index++;
                        if (index == 2) index = 1;
                        break;
                    case 'J':
                        if (index == 1) return false;
                        else return true;
                }
                if (index == 0)
                {
                    GameStart.Content(Game.W / 2 - Description.Length, 12, Description, ConsoleColor.Red);
                    GameStart.Content(Game.W / 2 - EndStr.Length, 16, EndStr, ConsoleColor.White);
                }
                else
                {
                    GameStart.Content(Game.W / 2 - Description.Length, 12, Description, ConsoleColor.White);
                    GameStart.Content(Game.W / 2 - EndStr.Length, 16, EndStr, ConsoleColor.Red);
                }
            }
        }
    }
}
