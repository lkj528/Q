
using System;
using System.Data;
using Oracle.DataAccess;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ConsoleApplication7
{
    class Program
    {

        static void Main(string[] args)
        {
            //아래에서 data source의 onj는 tnsnames.ora 파일의 DB접속이름이다.

            string str = "data source=onj;user id=scott; password=tiger";
            OracleConnection Conn = new OracleConnection(str);
            OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;
            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP";
                OracleDataReader reader = Comm.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}