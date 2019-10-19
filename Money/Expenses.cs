using System;
using System.IO;

namespace MML.Money
{
    public enum CategoriesExpenses
    {
        Transport,
        Groceries,
        Clothes,
        Family,
        Entertainment,
        Friends,
        Health,
        ME
    }

    public class Expenses
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        double price;
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public CategoriesExpenses category { get; set; }

        string date;
        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public Expenses(string name, double price, CategoriesExpenses category, string date)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.date = date;
        }

        public Expenses() : this("", 0, CategoriesExpenses.Entertainment, "")
        {
        }
    }

    class BinWriterExpenses : BinaryWriter
    {
        public BinWriterExpenses(Stream str) : base(str)
        {
        }

        public void WriteExpenses(Expenses e)
        {
            base.Write(e.Name);
            base.Write(e.Price);
            base.Write(e.Date);
            base.Write(Enum.GetName(typeof(CategoriesExpenses), e.category));
        }
    }

    class BinReaderExpenses : BinaryReader
    {
        public BinReaderExpenses(Stream str) : base(str)
        {
        }

        public Expenses ReadExpenses()
        {
            Expenses e = new Expenses();
            e.Name  = base.ReadString();
            e.Price = base.ReadDouble();
            e.Date = base.ReadString();
            Enum.TryParse(base.ReadString(), out CategoriesExpenses s);
            e.category = s;
            return e;
        }
    }
}
