using System;

namespace S_DesignPattern.AbstractFactoryPattern
{
    class Tester
    {
        AFP_IMakeCamera[] factories = new AFP_IMakeCamera[2];
        public Tester()
        {
            factories[0] = new AFP_EvDayFactory();
            factories[1] = new AFP_HoDayFactory();
        }

        private void TestCase(AFP_Camere camera, AFP_ITake lens)
        {
            Console.WriteLine("Test");
            if(camera.PutInLens(lens) == false)
            {
                Console.WriteLine("Lens not setted in camera");
            }
            if(camera.TakeAPicture() == false)
            {
                Console.WriteLine("Picture has not taken");
            }
        }

        public void Test()
        {
            TestDirect();
            TestUsingFactory();
        }

        private void TestUsingFactory()
        {
            AFP_Camere camera = null;
            AFP_ITake lens = null;
            foreach(AFP_IMakeCamera factory in factories)
            {
                camera = factory.MakeCamera();
                lens = factory.MakeLens();
                TestCase(camera, lens); // 호환성 테스트
            }
        }

        private void TestDirect()
        {
            AFP_Camere camera = new AFP_EvCamera();
            AFP_ITake lens = new AFP_HoLens();
            TestCase(camera, lens); // 호환성 테스트
        }
    }
}