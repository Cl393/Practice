
namespace CoffeeShop
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso-Ũ������";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}