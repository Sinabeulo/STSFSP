using System;

namespace S_DesignPattern.AbstractFactoryPattern
{
    class AFP_EvLens : AFP_ITake
    {
        public void Take()
        {
            Console.WriteLine("EvLens Take");
        }

        public void AutoFocus()
        {
            Console.WriteLine("EvLens AutoFocus");
        }
    }
}