using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LogicOld
{
    public class Block
    {
        private Point _point;

        public Point Point
        {
            get { return _point; }
            set { _point = value; }
        }

        private bool _isPath;

        public bool IsPath
        {
            get { return _isPath; }
            set { _isPath = value; }
        }

        private bool _isField;

        public bool IsField
        {
            get { return _isField; }
            set { _isField = value; }
        }



    }
}
