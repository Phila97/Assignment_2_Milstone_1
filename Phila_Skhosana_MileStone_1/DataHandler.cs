using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Phila_Skhosana_MileStone_1
{
    class DataHandler
    {
        public SqlConnection conn = new SqlConnection(@"Data Source = (local); Initial Catalog=BelgiumCampus_Students; Integrated Security=SSPI");
        public DataHandler()
        {

        }
    }
}
