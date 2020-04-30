namespace CoffeeShop
{
    public abstract class Beverage 
    {
        public virtual string Description { get; protected set; } = "��������";
        
        public abstract double Cost();
    }
}