using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.场景
{
    public abstract class GameStartOrEnd : ISceneUpdate
    {
        /// <summary>
        /// 标题
        /// </summary>
        public virtual string Title { get;}
        /// <summary>
        /// 开始选项
        /// </summary>
        public virtual string StartOption { get; }

        public int colorIndex;
        public string EndOption { get; } = "结束游戏";
        public void update()
        {
            Console.Clear();//清屏
            Game.WriteContent(Game.W / 2 - Title.Length, 4, Title);//标题
            Game.WriteContent(Game.W/2-StartOption.Length, 8, StartOption,colorIndex==0 ? ConsoleColor.Red :ConsoleColor.White);
            Game.WriteContent(Game.W/2-EndOption.Length, 12, EndOption, colorIndex == 1 ? ConsoleColor.Red : ConsoleColor.White);
            Select();//用户选择
        }
        /// <summary>
        /// 选项卡选择
        /// </summary>
        public virtual void Select() 
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
                    if (colorIndex == 0) Game.ChangeScene(Progress.Running);//进入游戏界面
                    else Environment.Exit(0);//结束游戏
                    break;
            }
        }
    }
}
