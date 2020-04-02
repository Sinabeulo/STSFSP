namespace S_DesignPattern.AbstractFactoryPattern
{
    interface AFP_IMakeCamera
    {
        AFP_ITake MakeLens();
        AFP_Camere MakeCamera();
    }
}