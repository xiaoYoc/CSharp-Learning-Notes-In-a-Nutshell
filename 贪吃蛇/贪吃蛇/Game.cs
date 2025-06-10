using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    /// <summary>
    /// 游戏场景类型枚举
    /// </summary>
    public enum E_SeceneType
    {
        Start,//游戏开始
        Game,//游戏中
        End//游戏结束
    }
    public class Game
    {
        //游戏窗口宽度
        private int width = 120;
        //游戏窗口高度
        private int height = 35;
        //当前游戏场景
        public ISeceneUpdate nowSecene;

        //初始化控制台
        public Game()
        {
            Console.CursorVisible = false;//隐藏光标
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);//缓冲区设置
            ChangeSecene(E_SeceneType.Start);
        }
        //游戏主循环
        public void Start()
        {
            while (true)
            {
                nowSecene?.Update();//
            }
        }
        /// <summary>
        /// 更新游戏场景
        /// </summary>
        /// <param name="type">游戏场景枚举值</param>
        public void ChangeSecene(E_SeceneType type)
        {
            Console.Clear();
            switch (type)
            {
                case E_SeceneType.Start:
                    nowSecene = new BeginOrEndSecene();
                    break;
                case E_SeceneType.Game:
                    nowSecene = new GameSecene();
                    break;
                case E_SeceneType.End:
                    nowSecene = new BeginOrEndSecene();
                    break;
            }
        }
    }
}
