using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.场景
{
    public class GameStart : GameStartOrEnd
    {
        public override string Title { get; } = "贪吃蛇";

        public override string StartOption { get; } = "开始游戏";
    }
}
