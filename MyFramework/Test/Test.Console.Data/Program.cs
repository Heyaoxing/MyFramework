using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Repositories;
using MySqlSugar;

namespace Test.Console.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                T_exclude_websitesRepository repository = new T_exclude_websitesRepository();
                repository.Insert(new T_exclude_websites()
                {
                    WebSite_Name="asddd",
                    WebSite_Url="dsasdfgf",
                    create_time=DateTime.Now,
                    is_erased=0
                });
                var model= repository.Queryable().Where(p => p.ID==4).FirstOrDefault();
                System.Console.WriteLine(model.WebSite_Name);
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            System.Console.Read();
        }
    }
}
