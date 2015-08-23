using System;

namespace HW_Arrays_Indexes__Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine("Поиск по названию или ID? (1-названию/2-ID)");
            int action = int.Parse(Console.ReadLine()); 
            switch (action)
            {
                case 1:
                {
                    Console.WriteLine("Введите название продукта:");
                    string name = Console.ReadLine();
                    Console.WriteLine(store[name]);
                }
                    break;
                case 2:
                {
                    Console.WriteLine("Введите ID:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(store[id]);
                }
                    break;
                default:
                {
                    Console.WriteLine("Ошибка выбора");
                }
                    break;
            }
        }
    }

    class Article
    {
        public Article(string prodName, string shopName, int price)
        {
            _price = price;
            _productName = prodName;
            _shopName = shopName;
        }
        private string _productName;
        private string _shopName;
        private int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public override string ToString()
        {
            return String.Format("Product Name: {0}\n Shop: {1}\n Price: {2}", _productName, _shopName, _price);
        }
    }

    class Store
    {
        private Article[] article;

        public Store()
        {
            article = new Article[3];
            article[0] = new Article("monitor", "shop1", 4500);
            article[1] = new Article("pc", "shop2", 3200);
            article[2] = new Article("phone", "shop3", 1300);
          
        }
        public string this[int index]
        {
            get
            {
                if (index <= article.Length)
                    return article[index].ToString();
                else
                    return "ID данного продукта не найден";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                {
                    if (article[i].ProductName == index)
                        return article[i].ToString(); 
                }

                return "Данный продукт не найден";
            }
        }
    }

}


