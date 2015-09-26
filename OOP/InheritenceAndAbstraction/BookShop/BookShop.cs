using System;

namespace BookShop
{
    class BookShop
    {
        static void Main()
        {
            Book book = new Book("Be phenomenal or be forgotten", "Erick Thomas", 17.0);

            GoldenEditionBook goldenBook = new GoldenEditionBook("Be phenomenal or be forgotten", "Erick Thomas", 17.0);

            Book mixBook = new GoldenEditionBook("Be phenomenal or be forgotten", "Erick Thomas", 17.0);

            Console.WriteLine("{0}\n{1}\n{2}\n{3}",book,goldenBook,mixBook, mixBook as GoldenEditionBook);

        }
    }
}
