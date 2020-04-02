using System;

namespace S_DesignPattern.AbstractFactoryPattern
{
    class AFP_HoLens : AFP_ITake
    {
        public void Take()
        {
            Console.WriteLine("HoLens Take");
        }

        public void ManualFocus()
        {
            Console.WriteLine("HoLens ManualFocus");
        }
    }
}