using ConsoleAppEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace ConsoleAppEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cOut = 0;
            //using (Models.Database db = new Models.Database())
            //{
            //    db.Configuration.ProxyCreationEnabled = false;
            //    db.Database.Log = c => Console.WriteLine(c);
            //    //Group gFather = new Group();
            //    //Group gChildren1 = new Group() { Name = "Filho 3", GrupoId = gFather.Id };
            //    //Group gChildren2 = new Group() { Name = "Filho 4", GrupoId = gFather.Id };
            //    //gFather.Name = "Pai 2";
            //    //gFather.Items.Add(gChildren1);
            //    //gFather.Items.Add(gChildren2);

            //    //db.Group.Add(gFather);
            //    //cOut = db.SaveChanges();

            //    Group g1 = db.Group.Include(i => i.Items).FirstOrDefault(c => c.Id == 1);
            //}
            //System.Console.WriteLine("Forma salvos {0} itens", cOut);
            //System.Console.ReadKey();


            //Group group = new Group();

            //Group group = new Group();
            //int b = new int();


            List<int> inteiros = new List<int>();
            string c = Console.ReadLine();
            int n = 0;
            while (c != "s" && int.TryParse(c, out n))
            {
                inteiros.Add(n);
                c = Console.ReadLine();
            }

            foreach(var d in inteiros.OrderBy(a => a).ToList())
            {
                System.Console.Write("{0} ", d);
            }


            System.Console.ReadKey();


        }
    }
}
