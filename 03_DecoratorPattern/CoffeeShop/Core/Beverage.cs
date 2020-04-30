namespace CoffeeShop
{
    public abstract class Beverage 
    {
        public virtual string Description { get; protected set; } = "¸ÅÄîÒûÁÏ";
        
        public abstract double Cost();
    }
}