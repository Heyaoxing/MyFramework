using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Autofac;
using Data.Entities;
using Data.Repositories;
using IServices.Demo;
using MySqlSugar;

namespace Test.Console.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                XmlDocument doc = new XmlDocument();
                doc.Load("Es_Article_Index.xml");
                foreach (XmlNode data in doc.SelectNodes("/index/type"))
                {
                    string className = data.Attributes["name"].InnerText;
                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
            System.Console.Read();
        }
    }
}
