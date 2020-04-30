
namespace CoffeeShop
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }


        public override string Description
        {
            get { return $"{beverage.Description}, Whip-длсм"; }
        }
        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}