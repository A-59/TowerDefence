using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Map
    {
        // 'это тестовый коментария для github

        private int _wight;

        public int Wight
        {
            get { return _wight; }
            set { _wight = value; }
        }

        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private Dictionary<Point, BlockProperties> _blocks;

        public Dictionary<Point, BlockProperties> Blocks
        {
            get { return _blocks; }
            set { _blocks = value; }
        }

        private int _pointOnBlock;

        public int PointOnBlock
        {
            get { return _pointOnBlock; }
            set { _pointOnBlock = value; }
        }
        
    }
}
