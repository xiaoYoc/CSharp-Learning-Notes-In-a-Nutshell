using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 营救公主
{
    public class Player:Hostility
    {
        public Player() 
        {
            Icon = "●";
            PositionX = 6;
            PositionY = 6;
            minAttack = 11;
            maxAttack = 14;
            Hp = 100;
        }
        //移动
        public void Move(Role role) 
        {
            bool temp = true;
            bool meet =false;
            while (true)
            {
                if(role is Boss)
                {
                    //在boss附近显示Boss
                    if (CalDistance(role) <= 3 && temp)
                    {
                        GameStart.Content(role.PositionX, role.PositionY, "                       ");
                        GameStart.Content(role.PositionX,role.PositionY, (role as Boss).Icon,ConsoleColor.Red);
                        temp = false;//仅显示一次
                    }
                }
                char c = char.ToUpper(Console.ReadKey(true).KeyChar);//获取用户字符
                GameStart.Content(PositionX, PositionY, "  ");//先清空当前位置
                switch (c)
                {
                    case 'W':
                        PositionY--;
                        if (Game.JudgeRepeat(this, role))
                        {
                            PositionY++;
                            meet = true;
                        }
                        break;
                    case 'S':
                        PositionY ++;
                        if(Game.JudgeRepeat(this,role))
                        {
                            PositionY--;
                            meet = true;
                        }
                        break;
                    case 'A':
                        PositionX-= 2;
                        if (Game.JudgeRepeat(this, role))
                        {
                            PositionX += 2;
                            meet = true;
                        }
                        break;
                    case 'D':
                        PositionX+= 2;
                        if (Game.JudgeRepeat(this, role))
                        {
                            PositionX -= 2;
                            meet = true;
                        }
                        break;
                    default:
                        GameStart.Content(PositionX, PositionY,Icon);//非指定字符，在原位置重新填入
                        break;
                }
                GameStart.Content(PositionX,PositionY,Icon,ConsoleColor.Green);
                if (meet) return;
                    
                        //碰见怪兽或公主退出Move方法，根据上下文进入战斗或什么画面
            }
        }
        //战斗，true赢了
        public bool Fight() 
        {
            Console.SetCursorPosition(2, Game.H - 6);
            GameStart.Content(2,Game.H - 6, "按任意键战斗！！！",ConsoleColor.Red);
            GameStart.Content(2, Game.H - 5, $"boss血量:{Boss.Instance.Hp},玩家血量{Hp}", ConsoleColor.Green);
            Random random = new Random();
            while (true)
            {
                //战斗逻辑
                //1.玩家打boos
                int attack = random.Next(minAttack, maxAttack);
                Console.ReadKey(true);
                Boss.Instance.Hp -= attack;//boss血量降低
                if (Boss.Instance.Hp <= 0) 
                {
                    GameStart.Content(Boss.Instance.PositionX, Boss.Instance.PositionY, "  ");//消除boss的方块
                    GameStart.Content(2, Game.H - 6, "boss已死前往营救公主，按任意键继续                             ", ConsoleColor.Green);
                    GameStart.Content(2, Game.H - 5, "                                                          ", ConsoleColor.Red);//去除文字
                    Console.ReadKey(true);
                    GameStart.Content(2, Game.H - 6, "                                                          ", ConsoleColor.Green);
                    GameStart.Content(2, Game.H - 5, "                                                         ", ConsoleColor.Red);//去除文字
                    return true;
                }
                GameStart.Content(2, Game.H - 6, $"玩家对boss造成了{attack}点伤害,Boss剩余{Boss.Instance.Hp}点血", ConsoleColor.Red);
                //2.boss打玩家
                attack = random.Next(Boss.Instance.minAttack,Boss.Instance.maxAttack);
                Hp -= attack;
                if(Hp <= 0) 
                {
                    GameStart.Content(2, Game.H - 6, "很遗憾你输了，按任意键继续                                        ", ConsoleColor.Green);
                    GameStart.Content(2, Game.H - 5, "                                                           ", ConsoleColor.Red);//去除文字
                    Console.ReadKey(true);
                    GameStart.Content(2, Game.H - 6, "                                                           ", ConsoleColor.Green);
                    GameStart.Content(2, Game.H - 5, "                                                           ", ConsoleColor.Red);//去除文字
                    return false;
                }
                GameStart.Content(2, Game.H - 5, $"boss对玩家造成了{attack}点伤害,玩家剩余{Hp}点血", ConsoleColor.Green);
            }
        }

        private int CalDistance(Role role)
        {
            int x2 = (PositionX - role.PositionX) * (PositionX - role.PositionX);
            int y2 = (PositionY - role.PositionY) * (PositionY - role.PositionY);
            return (int)Math.Sqrt(x2+y2);
        }
    }
}
