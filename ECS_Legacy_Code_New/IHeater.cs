using System;
using System.Collections.Generic;
using System.Text;

namespace ECS_Legacy_Code_New
{
    public interface IHeater
    {
        public void TurnOn();
        public void TurnOff();
        public bool RunSelfTest();
    }
}
