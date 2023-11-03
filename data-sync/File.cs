namespace data_sync
{
    internal class DbFile : IDatabase
    {
        private string _name;
        private string _type;
        private string _connection;

        public DbFile()
        {
            
        }

        public DbFile(string name, string type, string connection)
        {
            Name = name;
            Type = type;
            Connection = connection;
        }

        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Connection
        {
            get { return _connection; }
            set { _connection = value; }
        }

        public void FilePrint() {
            Console.WriteLine($"Filename: {_name}, Database Type: {_type}");
        }

    }
}
