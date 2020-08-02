namespace PrototypePattern
{
    /// <summary>
    /// OrderInfo class include order food details.
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// Order's id value
        /// </summary>
        public int Id;

        /// <summary>
        /// OrderInfo constructor
        /// </summary>
        /// <param name="id">id value for food order</param>
        public OrderInfo(int id)
        {
            this.Id = id;
        }
    }
}