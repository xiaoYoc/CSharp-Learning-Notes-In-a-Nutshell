using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 营救公主
{
    public class GameEnd : StartOrEnd
    {
        public override void Update()
        {
            Console.Clear();//清空
            Description = "继续游戏";
            GameStart.Content(Game.W / 2 - Title.Length, 8, Title);
            GameStart.Content(Game.W / 2 - Description.Length, 12, Description, ConsoleColor.Red);
            GameStart.Content(Game.W / 2 - EndStr.Length, 16, EndStr);
        }
        public void IsWin(bool judge)
        {
            if (judge) 
            {
                Title = "Win!英雄救美";
            }
            else
            {
                Title = "失败！癞蛤蟆想吃天鹅肉";
            }
        }
    }
}
