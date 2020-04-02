namespace S_DesignPattern.AbstractFactoryPattern
{
    class AFP_EvCamera : AFP_Camere
    {
        public override bool PutInLens(AFP_ITake iTake)
        {
            if (!(iTake is AFP_EvLens evLens)) return false;

            Lens = iTake;
            return true;
        }

        public override bool TakeAPicture()
        {
            if (!(Lens is AFP_EvLens evlens)) return false;

            evlens.AutoFocus();
            return base.TakeAPicture();
        }
    }
}