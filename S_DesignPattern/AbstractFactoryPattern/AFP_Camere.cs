namespace S_DesignPattern.AbstractFactoryPattern
{
    abstract class AFP_Camere
    {
        protected AFP_ITake Lens { get; set; }

        public virtual bool TakeAPicture()
        {
            if(Lens == null)
            {
                return false;
            }
            Lens.Take();
            return true;
        }

        public abstract bool PutInLens(AFP_ITake iTake);

        public AFP_ITake GetOutLens()
        {
            AFP_ITake re = Lens;
            Lens = null;
            return re;
        }
        public AFP_Camere()
        {
            Lens = null;
        }
    }
}