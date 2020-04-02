namespace S_DesignPattern.AbstractFactoryPattern
{
    class AFP_HoCamera : AFP_Camere
    {
        public override bool PutInLens(AFP_ITake iTake)
        {
            if (!(iTake is AFP_HoLens holens)) return false;

            Lens = iTake;
            return true;
        }
        public override bool TakeAPicture()
        {
            if (!(Lens is AFP_HoLens hoLens)) return false;

            hoLens.ManualFocus();
            return base.TakeAPicture();
        }
    }
}