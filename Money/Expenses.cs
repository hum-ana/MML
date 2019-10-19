﻿namespace MML.Money
{
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

        public enum Categories
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

        public Categories category { get; set; }

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

        public Expenses(string name, double price, Categories category, string date)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.date = date;
        }

    }
}
