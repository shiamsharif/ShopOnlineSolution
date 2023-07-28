namespace ShopOnline.Api.Eniities
{
    public class CartItem
    {
        public int id { get; set; }
        public int CartID { get; set; }
        public int ProductID { get; set;}
        public int Qty { get; set;}
    }
}
