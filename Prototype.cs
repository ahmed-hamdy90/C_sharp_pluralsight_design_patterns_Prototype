namespace PrototypePattern
{
    /// <summary>
    /// Abstract class for any class need to apply Prototype pattern to enable retrieve copy instance form concrete class
    /// </summary>
    public abstract class Prototype
    {
        /// <summary>
        /// Create new instance form concrete class from <see cref="Prototype"/> class using shallow copy way.
        /// for more details about shallow copy vs deep copy see link http://net-informations.com/faq/net/shallow-deep-copy.htm
        /// </summary>
        /// <returns>copied instance</returns>
        public abstract Prototype ShallowCopy();

        /// <summary>
        /// Create new instance form concrete class from <see cref="Prototype"/> class using deep copy way.
        /// for more details about shallow copy vs deep copy see link http://net-informations.com/faq/net/shallow-deep-copy.htm
        /// </summary>
        /// <returns>copied instance</returns>
        public abstract Prototype DeepCopy();

        /// <summary>
        /// Print all food order details into console screen.
        /// <b>Notice:</b> This method not related to Applying Prototype pattern,
        /// it just helper method for class will extend <see cref="Prototype"/> class
        /// </summary>
        public abstract void Debug();
    }
}