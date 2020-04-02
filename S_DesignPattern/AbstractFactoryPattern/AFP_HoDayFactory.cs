namespace S_DesignPattern.AbstractFactoryPattern
{
    class AFP_HoDayFactory : AFP_IMakeCamera
    {
        public AFP_Camere MakeCamera()
        {
            return new AFP_HoCamera();
        }

        public AFP_ITake MakeLens()
        {
            return new AFP_HoLens();
        }
    }
}