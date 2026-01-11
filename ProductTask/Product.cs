using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask
{
    public class Product
    {
        protected string _name;
        protected double _price;
        protected Currency _cost;
        protected int _quantity;
        protected string _produser;
        protected double _weight;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва товару не може бути порожньою");
                _name = value;
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ціна не може бути від'ємною");
                _price = value;
            }
        }
        public Currency Cost { get; set; }
        public int Quantity
        {
            get {return _quantity;}
            set
            {
                if (value < 0)
                    throw new ArgumentException("Кількість товару не може бути від'ємною");
                _quantity = value;
            }
            
        }
        public string Producer
        {
            get { return _produser; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва компанії-виробника не може бути порожньою");
                _produser = value;
            }
        }
        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Вага не може бути від'ємною");
                _weight = value;
            }
        }


        public Product(string name, double price, Currency cost, int quantity, string produser, double weight) 
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = produser;
            Weight = weight;
        }
        public Product(string name, double price, Currency cost)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
        }
        public Product()
        {
            Name = "Невідомо";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "Невідомо";
            Weight = 0;
        }
        public Product(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Cost = new Currency (product.Cost);
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }

        public double GetPriceInUAH()
        {
            double price = 0;
            price = Price * Cost.ExRate;
            return price;
        }

        public double GetTotalPriceInUAH()
        {
            double price = 0;
            price = GetPriceInUAH() * Quantity;
            return price;
        }

        public double GetTotalWeight()
        {
            double totalWeight = 0;
            totalWeight = Quantity * Weight;
            return totalWeight;
        }
    }
}
