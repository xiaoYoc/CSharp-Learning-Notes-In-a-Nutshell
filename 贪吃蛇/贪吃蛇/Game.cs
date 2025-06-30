using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.场景;

namespace 贪吃蛇
{
    public enum Progress
    {
        Begin,
        Running,
        End
    }
    public class Game
    {
        /// <summary>
        /// 界面宽度
        /// </summary>
        public const int W = 80;
        /// <summary>
        /// 界面高度
        /// </summary>
        public const int H = 20;


        public static ISceneUpdate NowScene { set; get; }

        public Game() 
        {
            Console.SetWindowSize(W, H);
            Console.SetBufferSize(W, H);
            //隐藏鼠标
            Console.CursorVisible = false;
            ChangeScene(Progress.Begin);//进入开始界面
        }
        /// <summary>
        /// 游戏主循环
        /// </summary>
        public void MainLoop() 
        {
            while (true)
            {
                NowScene?.update();
            }
        }
        /// <summary>
        /// 切换场景
        /// </summary>
        /// <param name="pro">游戏进程</param>
        public static void ChangeScene(Progress pro) 
        {
            switch (pro)
            {
                case Progress.Begin:
                    NowScene = new GameStart();
                    break;
                case Progress.Running:
                    NowScene = new GameRunning();
                    break;
                case Progress.End:
                    //游戏结束界面
                    NowScene = new GameEnd();
                    break;
            }
        }
        /// <summary>
        /// 指定位置填入内容
        /// </summary>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        /// <param name="content">内容</param>
        /// <param name="color">文字颜色</param>
        public static void WriteContent(int x,int y,string content,ConsoleColor color = ConsoleColor.White) 
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(content);
            Console.ForegroundColor = ConsoleColor.White;//重置颜色
        }
    }
}
