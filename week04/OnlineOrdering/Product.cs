namespace OnlineOrdering
{
    public class Product
    {
        public int _Id { get; set; }
        public string _Name { get; set; }
        public decimal _Price { get; set; }
        public int _Quantity { get; set; }
        public decimal _CostOfShipping {get; set;}

        public Product(int id, string name, decimal price, int quantity, decimal costofshipping)
        {
            _Id = id;
            _Name = name;
            _Price = price;
            _Quantity = quantity;
            _CostOfShipping = costofshipping;
        }

        public decimal GetTotalPrice()
        {
            return _Price * _Quantity + _CostOfShipping;
        }

        public decimal GetShippingPrice()
        {
            return _CostOfShipping;
        }
        public override string ToString()
        {
            return $"Product ID: {_Id}, Name: {_Name}, Price: {_Price:C}, Quantity: {_Quantity}, CostOfShipping: {GetShippingPrice():C}, Total Price: {GetTotalPrice():C}";
        }
    }
}