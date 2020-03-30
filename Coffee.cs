namespace Coffee
{
    public abstract class Coffee
    {
        public virtual int Price()
        {
            return 0;
        }
        public abstract string Strength();
    }
}