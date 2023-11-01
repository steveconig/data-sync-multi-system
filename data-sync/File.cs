namespace data_sync
{
    internal class DbFile
    {
        private string FileName;
        private string DatabaseType;

        public DbFile(string filename, string databaseType) {
            FileName = filename;
            DatabaseType = databaseType;
        }

        public void FilePrint() {
            Console.WriteLine($"Filename: {FileName}, Database Type: {DatabaseType}");
        }
    }
}
