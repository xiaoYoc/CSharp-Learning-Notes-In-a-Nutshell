using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 营救公主
{
    public class Game
    {
        public Game() 
        {
            //初始化游戏开始界面
            Console.SetWindowSize(W, H);//界面尺寸
            Console.SetBufferSize(W, H);//缓冲区大小
            Console.CursorVisible = false;//隐藏定位
            Scene = new GameStart();//初始化的游戏开始界面
        }
        public IScene Scene { get; private set; }//游戏界面
        public const int W = 80;
        public const int H = 40;
        public Player player = new Player();
        public Boss boss;
        //游戏开始
        public void Start()
        {
            while (true) 
            {
                Scene?.Update();//进入游戏开始主界面
                                
                if (Scene is GameStart)
                {
                    //用户按WS键切换后按J键进入相关界面
                    if ((Scene as GameStart).Select())//开始界面选择进入游戏
                    {
                        Scene = new GameRun();
                        Scene?.Update();//显示地图
                        ShowHost();//显示主角与Boss
                        player.Move(Boss.Instance);//移动结束，战斗
                        if (player.Fight()) //胜利进入这里
                        {
                            //公主出现
                            Begum begum = new Begum();
                            //移动
                            player.Move(begum);//直到遇见公主，然后到结束界面胜利
                            GameStart.Content(player.PositionX, player.PositionY, "  ");//清除玩家
                            GameStart.Content(begum.PositionX, begum.PositionY, "  ");//清除公主
                            GameStart.Content(2, Game.H - 6, "成功营救公主按任意键继续                       ", ConsoleColor.Green);
                            Console.ReadKey(true);
                            Scene = new GameEnd();
                            (Scene as GameEnd).IsWin(true);//设置相关属性
                            Scene?.Update();//到结束界面
                            if ((Scene as GameEnd).Select())
                            {
                                //继续游戏
                                Scene = new GameStart();
                                player = new Player();
                                Boss.Instance.Hp = 100;//重置Boss
                            }
                            else
                            {
                                End();//游戏结束
                            }
                        }
                        else//游戏失败进入这里 
                        {
                            GameStart.Content(player.PositionX, player.PositionY, "  ");//清除玩家
                            GameStart.Content(Boss.Instance.PositionX, Boss.Instance.PositionY, "  ");//清除Boss
                            Scene = new GameEnd();
                            (Scene as GameEnd).IsWin(false);
                            Scene?.Update();
                            if ((Scene as GameEnd).Select())
                            {
                                //继续游戏
                                Scene = new GameStart();
                                player = new Player();
                                Boss.Instance.Hp = 100;//重置Boss

                            }
                            else
                            {
                                End();//游戏结束
                            }
                        }
                    }
                    else //开始界面选择退出游戏
                    {
                        End();//游戏结束
                    }
                }
            }
            
        }
        //游戏结束
        public void End()
        {
            Environment.Exit(0);//退出游戏
        }
        //显示主角与boss
        public void ShowHost() 
        {
            GameStart.Content(player.PositionX, player.PositionY, player.Icon,ConsoleColor.Green);
            GameStart.Content(Boss.Instance.PositionX, Boss.Instance.PositionY,Boss.Instance.InitialIcon,ConsoleColor.Cyan);
        }
        //判断位置
        public static bool JudgeRepeat(Player player,Role role)
        {
            if(player.PositionX <= 0) player.PositionX = 2;
            else if(player.PositionX >= W-4) player.PositionX = W-4;
            if(player.PositionY <= 1) player.PositionY = 1;
            else if(player.PositionY >= H-8) player.PositionY = H-8;
            //玩家与其他方块重合
            if(player.PositionX == role.PositionX && player.PositionY == role.PositionY)return true;
            return false;
        }
    }
}
