
namespace CoffeeShop
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend--��ѡ����";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}