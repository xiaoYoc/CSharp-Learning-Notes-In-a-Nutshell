using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class BeginOrEndSecene : ISeceneUpdate
    {
        protected int nowIndex = 0;
        protected string title;
        protected string strOne;
        protected readonly string strEnd = "结束游戏";
        public virtual void Update()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("开始或者结束场景");
        }
    }
}
