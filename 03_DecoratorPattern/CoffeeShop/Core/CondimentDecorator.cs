
namespace CoffeeShop
{
    /// <summary>
    /// ����װ����
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}