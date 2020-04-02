namespace S_DesignPattern.AbstractFactoryPattern
{
    class AFP_EvDayFactory : AFP_IMakeCamera
    {
        public AFP_Camere MakeCamera()
        {
            return new AFP_EvCamera();
        }

        public AFP_ITake MakeLens()
        {
            return new AFP_EvLens(); 
        }
    }
}