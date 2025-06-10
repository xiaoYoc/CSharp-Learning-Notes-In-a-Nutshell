using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 营救公主
{
    public class GameStart : StartOrEnd
    {
        public GameStart()
        {
            Title = "营救公主";
            Description = "开始游戏";
        }
        public override void Update()
        {
            Console.Clear();//清除界面
            Content(Game.W / 2 - Title.Length, 8, Title);
            Content(Game.W / 2 - Description.Length, 12, Description, ConsoleColor.Red);
            Content(Game.W / 2 - EndStr.Length, 16, EndStr);
        }

       
        //在指定位置输入内容
        public static void Content(int x, int y, string input, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(input);
            //重置颜色
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
