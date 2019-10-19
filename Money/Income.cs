namespace MML.Money
{
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

        public enum Categories
        {
            Work,
            Family,
            Friends
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

        public Income(string name, double price, Categories category, string date)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.date = date;
        }

    }
}
