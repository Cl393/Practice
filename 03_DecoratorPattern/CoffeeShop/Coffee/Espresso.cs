
namespace CoffeeShop
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso-Å¨Ëõ¿§·È";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}