using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SergiuRolnic
{
    class BasicColumn : AbstractColumn


    {
        public BasicColumn(Point position, Boolean type)
            :base(position,type)
        {

        }
        public override int UpdateHeight()
        {
            return 0;
        }
    }
}
