using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇.游戏资源
{
    public class SnackComponent : DrawObject
    {
        public SnackComponent()
        {
            
        }
        public SnackComponent( int x,int y, Grid grid)
        {
            pos = new Position(x,y,grid);
        }
    }
}
