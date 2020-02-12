using System;
using System.Collections.Generic;
using System.Text;

namespace ECS_Legacy_Code_New
{
    public interface ITempSensor
    {
        public int GetTemp();
        public bool RunSelfTest();
    }
}
