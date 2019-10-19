using System;
using System.IO;

namespace MML.Money
{
    public enum CategoriesIncome
    {
        Work,
        Family,
        Friends
    }

    public class Income
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

        public CategoriesIncome category { get; set; }

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

        public Income(string name, double price, CategoriesIncome category, string date)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.date = date;
        }

        public Income() : this("", 0, CategoriesIncome.Work, "")
        {
        }
    }

    class BinWriterIncome : BinaryWriter
    {
        public BinWriterIncome(Stream str) : base(str)
        {
        }

        public void WriteIncome(Income e)
        {
            base.Write(e.Name);
            base.Write(e.Price);
            base.Write(e.Date);
            base.Write(Enum.GetName(typeof(CategoriesIncome), e.category));
        }
    }

    class BinReaderIncome : BinaryReader
    {
        public BinReaderIncome(Stream str) : base(str)
        {
        }

        public Income ReadIncome()
        {
            Income e = new Income();
            e.Name = base.ReadString();
            e.Price = base.ReadDouble();
            e.Date = base.ReadString();
            Enum.TryParse(base.ReadString(), out CategoriesIncome s);
            e.category = s;
            return e;
        }
    }
}
