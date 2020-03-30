namespace Coffee
{
    public class Cortado : Coffee,IMilk
    {
        public override int Price()
        {
            return 25;
        }
        public override string Strength()
        {
            return "Medium";
        }
        public override string ToString()
        {
            return "This type of coffe is " + Strength() + ".";
        }
        public int mlMilk()
        {
            return 40;
        }
    }
}