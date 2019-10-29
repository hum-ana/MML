using System.IO;

namespace MML.Life
{
    public class ToDo
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

        bool done;
        public bool Done
        {
            get
            {
                return this.done;
            }
            set
            {
                this.done = value;
            }
        }

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

        public ToDo(string name, bool done, string date)
        {
            this.name = name;
            this.done = done;
            this.date = date;
        }

        public ToDo() : this("", false, "")
        {
        }
    }

    class BinWriterToDo : BinaryWriter
    {
        public BinWriterToDo(Stream str) : base(str)
        {
        }

        public void WriteToDo(ToDo e)
        {
            base.Write(e.Name);
            base.Write(e.Done);
            base.Write(e.Date);
        }
    }

    class BinReaderToDo : BinaryReader
    {
        public BinReaderToDo(Stream str) : base(str)
        {
        }

        public ToDo ReadToDo()
        {
            ToDo e = new ToDo();
            e.Name = base.ReadString();
            e.Done = base.ReadBoolean();
            e.Date = base.ReadString();
            return e;
        }
    }
}
