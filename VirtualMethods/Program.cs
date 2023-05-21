using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();

            sqlServer.Add();
            mySql.Add();
            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }
    }
    
    class SqlServer : Database
    {
        public override void Add()
        {
            //base.Add();
            Console.WriteLine("Added by Sql Code");
        }
    }

    class MySql : Database
    {

    }
}
