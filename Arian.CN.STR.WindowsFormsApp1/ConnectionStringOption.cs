using System;
using System.Linq;

namespace PayamHannan.Arian.ORM
{
    public class ConnectionStringOption
    {


        public ConnectionStringOption()
        {
        }
        public ConnectionStringOption(string connectionString)
        {
            var options = connectionString.Split(";".ToArray(), StringSplitOptions.RemoveEmptyEntries).ToDictionary(k => k.Split('=')[0], k => k.Split('=')[1]);

            DataSource = options["Data Source"];
            InitialCatalog = options["Initial Catalog"];
            Password = options["Password"];
            PersistSecurityInfo = Convert.ToBoolean(options.ContainsKey("Persist Security Info") ? options["Persist Security Info"] : "True");
            UserID = options["User ID"];

        }

        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public bool PersistSecurityInfo { get; set; }

        public override string ToString()
        => string.Format("Data Source={0};Initial Catalog={1};Persist Security Info={2};User ID={3};Password={4};", DataSource, InitialCatalog, PersistSecurityInfo ? "True" : "False", UserID, Password);

    }
}