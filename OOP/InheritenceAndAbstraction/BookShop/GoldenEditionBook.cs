namespace BookShop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string name, string author, double price)
            : base(name, author, price)
        {

        }

        public override double Price
        {
            get { return base.Price * 1.3; }
        }
    }
}
