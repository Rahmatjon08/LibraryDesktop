using System.Data.SqlClient;

namespace Secret_Library
{
    internal class SqlDateAdapter
    {
        public static implicit operator SqlDateAdapter(SqlDataAdapter v)
        {
            throw new NotImplementedException();
        }
    }
}