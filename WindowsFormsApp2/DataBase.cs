using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 身份证信息管理系统
{
    internal class Data
    {
        private static string connStr = @"Data Source=" + @"Data\Data.db;Initial Catalog=sqlite;Integrated Security=True;Max Pool Size=10";
        public static int ExecuteNoQuery(string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteNonQuery();

                }
            }
        }
        public static DataSet ExecuteDataSet(string sql)
        {
            using (SQLiteConnection xonn = new SQLiteConnection(connStr))
            {
                xonn.Open();
                using (SQLiteCommand cmd = xonn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    return dataset;
                }
            }
        }
        public static object ExecuteScalar(string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                using (SQLiteCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
