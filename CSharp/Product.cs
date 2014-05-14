using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class ProductCSharp1
    {
        string name;

        //public getter ,if we want setter even setters have to be public 
        public string Name { get { return name; } }

        decimal price;
        public decimal Price { get { return price; } }

        public ProductCSharp1(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProdcuts()
        {
            //No compile-time information . Exception only at runtime 
            //We need to cast when we are acessing it 
            ArrayList list = new ArrayList();
            list.Add(new ProductCSharp1("West Side Story", 9.99m));
            list.Add(new ProductCSharp1("Assassins", 14.99m));
            list.Add(new ProductCSharp1("Frogs", 13.99m));
            list.Add(new ProductCSharp1("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", name, price);
        }

    }

    public class ProductCharp2
    {
        string name;
        //We can have private setters
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public ProductCharp2(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<ProductCharp2> GetSampleProdcuts()
        {
            //More strongly type compilation error
            List<ProductCharp2> list = new List<ProductCharp2>();
            list.Add(new ProductCharp2("West Side Story", 9.99m));
            list.Add(new ProductCharp2("Assassins", 14.99m));
            list.Add(new ProductCharp2("Frogs", 13.99m));
            list.Add(new ProductCharp2("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", name, price);
        }
    }

    public class ProductCSharp3
    {
        //Automatically implemented properties //Check MSIL
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        //We can have private parameter constructor.This constructor is called for each item before properties are set
        ProductCSharp3()
        {

        }
        public ProductCSharp3(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<ProductCSharp3> GetSampleProdcuts()
        {
            //More strongly type compilation error
            List<ProductCSharp3> list = new List<ProductCSharp3>();
            list.Add(new ProductCSharp3("West Side Story", 9.99m));
            list.Add(new ProductCSharp3("Assassins", 14.99m));
            list.Add(new ProductCSharp3("Frogs", 13.99m));
            list.Add(new ProductCSharp3("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", Name, Price);
        }
    }

    public class ProductCharp4
    {
        readonly string name;
        public string Name { get { return name; } }

        readonly decimal price;
        public decimal Price { get { return price; } }

        public ProductCharp4(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<ProductCharp4> GetSampleProducts()
        {
            return new List<ProductCharp4>
      {
         new ProductCharp4( name: "West Side Story", price: 9.99m),
         new ProductCharp4( name: "Assassins", price: 14.99m),
         new ProductCharp4( name: "Frogs", price: 13.99m),
         new ProductCharp4( name: "Sweeney Todd", price: 10.99m)
      };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
