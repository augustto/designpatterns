using System;
using System.Data.SqlClient;
using System.Data;

namespace ObjectPoolPattern
{
    public class SqlConnectionPool : ObjectPool<SqlConnection>
    {
        private string _constr;

        public SqlConnectionPool(string constr)
        {
            this._constr = constr;
        }

        protected override SqlConnection create()
        {
            var con = new SqlConnection() { ConnectionString = _constr };
            con.Open();
            return con;
        }

        public override bool validate(SqlConnection o)
        {
            return (o.State != ConnectionState.Closed);
        }

        public override void expire(SqlConnection o)
        {
            o.Close();
        }
    }
}
