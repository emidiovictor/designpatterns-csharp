namespace Structural.Bridge
{
    public abstract class Shape
    {
        protected DrawApi _implementor;

        protected Shape(DrawApi implementor)
        {
            _implementor = implementor;
        }

        public abstract void Draw();
    }
}