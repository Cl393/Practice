
namespace CoffeeShop
{
    /// <summary>
    /// Ä¦¿¨
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Mocha(Beverage beverage)
        { 
            this.beverage = beverage; 
        }    

        public override string Description 
        {
            get { return $"{beverage.Description}, MochaÄ¦¿¨"; } 
        }    

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}