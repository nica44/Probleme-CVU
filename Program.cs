using System;
using System.Collections.Generic;

namespace Problema4
{
    public enum Moneda { RON, EUR, USD}
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Producator> Producatori = new List<Producator>();
            var producator1 = new Producator { Nume = "prod1"};
            var producator2 = new Producator { Nume = "prod2" };
            var reducere1 = new Reducere { Nume = "reducere1", data = new DateTime(2018, 8, 18) };
            var reducere2 = new Reducere { Nume = "reducere2", data = new DateTime(2018, 8, 19) };
            var reducere3 = new Reducere { Nume = "reducere3", data = new DateTime(2018, 8, 20) };
            var reducere4 = new Reducere { Nume = "reducere4", data = new DateTime(2018, 8, 21) };
            reducere4.data.Add(new TimeSpan());
            producator1.Reduceri.Add(reducere1);
            producator1.Reduceri.Add(reducere2);
            producator2.Reduceri.Add(reducere3);
            producator2.Reduceri.Add(reducere4);
            Producatori.Add(producator1);
            Producatori.Add(producator2);
            Pret.Curs[Moneda.EUR] = (decimal)4.6572;
            Pret.Curs[Moneda.USD] = (decimal)4.0889;
            Pret.Curs[Moneda.RON] = 1;

            var produs1 = new Produs { Id = Guid.NewGuid(), Nume = "produs1", pret = new Pret { moneda = Moneda.RON, Val = 99 }, producator = producator1 };
            var produs2 = new Produs { Id = Guid.NewGuid(), Nume = "produs2", pret = new Pret { moneda = Moneda.RON, Val = 199 }, producator = producator1 };
            var produs3 = new Produs { Id = Guid.NewGuid(), Nume = "produs3", pret = new Pret { moneda = Moneda.RON, Val = 299 }, producator = producator1 };

            var client1 = new Client();

            produs1.StockChanged += client1.NotificaStoc;
            produs1.pret.PriceChanged += client1.Notifica;
            produs1.pret.Val = 100; //1
            produs1.pret.Val = 200;//2
            produs1.Stoc = 111;
            produs1.Stoc = 211;
            produs1.pret.Val = 1000;//10
            //produs1.pret.Val = 200;//11
            
            client1.ArataMesaje();
            

            

        }
    }
}
