using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.游戏资源
{
    public enum MoveDirection
    { Left, Right, Up, Down }
    public class Snack : IDraw
    {
        public MoveDirection dir;
        public int Count = 0;
        public SnackComponent[] components;
        public Snack()
        {
            components = new SnackComponent[200];
            components[0] = new SnackComponent(Game.W / 2, Game.H / 2, Grid.SnackHead);
            Count++;
            components[0].Draw();//蛇头
            dir = MoveDirection.Right;
        }

        /// <summary>
        /// 画蛇
        /// </summary>
        public void Draw()
        {
           
            //画
            for (int i = 0; i < Count; i++)
            {
                components[i].Draw();
            }
        }
        /// <summary>
        /// 移动
        /// </summary>
        /// <param name="dir">方向</param>
        public void Move(MoveDirection dir)
        {
            if(components[Count - 1].pos.x!= 0  && components[Count - 1].pos.y != 0)
            {
                //清除最后的格子
                Game.WriteContent(components[Count - 1].pos.x, components[Count - 1].pos.y, "  ");
            }
            //数组搬家
            for (int i = Count - 1; i > 0; i--)
            {
                components[i].pos.x = components[i - 1].pos.x;
                components[i].pos.y = components[i - 1].pos.y;
                components[i].pos.type = Grid.SnackBody;
            }
            
            switch (dir)
            {
                case MoveDirection.Left:
                    components[0].pos.x -= 2;
                    break;
                case MoveDirection.Right:
                    components[0].pos.x += 2;
                    break;
                case MoveDirection.Up:
                    --components[0].pos.y;
                    break;
                case MoveDirection.Down:
                    ++components[0].pos.y;
                    break;
            } 
        }
        /// <summary>
        /// 检测与墙体碰撞或与自身碰撞
        /// </summary>
        /// <param name="wap"></param>
        /// <param name="dir"></param>
        /// <returns></returns>
        public bool Judge(Wap wap,MoveDirection dir)
        {
            //墙体检测
            for (int i = 0;i < wap.walls.Length;i++)
            {
                if (components[0].pos == wap.walls[i].pos) return true;
            }
            //自身碰撞检测
            for (int i = 1; i <Count;i++)
            {
                if (components[0].pos == components[i].pos) return true ;
            }
            return false;
        }
        /// <summary>
        /// 改变方向
        /// </summary>
        /// <param name="key">键</param>
        public void ChangeDir(ConsoleKey key)
        {
            if (Count == 1 || (Count > 1 && (this.dir == MoveDirection.Left && key != ConsoleKey.D) ||
               (this.dir == MoveDirection.Right && key != ConsoleKey.A) ||
               (this.dir == MoveDirection.Up && key != ConsoleKey.S) ||
               (this.dir == MoveDirection.Down && key != ConsoleKey.W)))
            {
                switch (key)
                {
                    case ConsoleKey.W:
                        dir = MoveDirection.Up;
                        break;
                    case ConsoleKey.S:
                        dir = MoveDirection.Down;
                        break;
                    case ConsoleKey.A:
                        dir = MoveDirection.Left;
                        break;
                    case ConsoleKey.D:
                        dir = MoveDirection.Right;
                        break;
                }
            }
        }
        /// <summary>
        /// 吃食物
        /// </summary>
        /// <param name="food">食物</param>
        /// <returns>吃到食物，则返回true</returns>
        public bool EatFood(Food food)
        {
            if (components[0].pos == food.pos)
            {
                components[Count++] = new SnackComponent();
                return true;//外部生成食物
            }
            return false;
        }
    }
}
