using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using ProductFinderDal.Models;

namespace ProductFinderDal
{
    public class ProductFinderContext
    {

        AppConfiguration appconfig = new AppConfiguration();
        public string constr { get; set; }

        private readonly ConnectionStringConfig config;


        public Products GetSingleItemByBarCode(string BarCode)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<Products>($"SELECT * FROM DBO.[STOCK] where BarCode=@BarCode", new { BarCode = BarCode }).FirstOrDefault();
            }
        }


        public Products RegisterItemByBarCode(string BarCode,int Catagorey)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<Products>($"SELECT * FROM DBO.[STOCK] where BarCode=@BarCode", new { BarCode = BarCode }).FirstOrDefault();
            }
        }




    }
}
