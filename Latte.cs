namespace Coffee
{
    public class Latte : Coffee,IMilk
    {
        public override int Price()
        {
            return 40;
        }
        public override string Strength()
        {
            return "Weak";
        }
        public override string ToString()
        {
            return "This type of coffe is " + Strength() + ".";
        }
        public int mlMilk()
        {
            return 200;
        }
    }
}