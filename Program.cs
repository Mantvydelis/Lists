using Listai.Models;
using System.Collections.Generic;
using System.Drawing;

namespace ManoPrograma
{
    public class ListuUzduotys
    {
        //1 uzduotis
        //public static void Main()
        //{
        //    Studentas stud1 = new Studentas("Petras", 11);
        //    Studentas stud2 = new Studentas("Antanas", 19);
        //    Studentas stud3 = new Studentas("Aloyzas", 55);
        //    Studentas stud4 = new Studentas("Martynas", 80);
        //    Studentas stud5 = new Studentas("Kestas", 100);

        //    List<Studentas> StudentuSarasas = new List<Studentas> {stud1, stud2, stud3, stud4, stud5};

        //    foreach (Studentas stud in StudentuSarasas)
        //    {
        //        if (stud.Ivertinimas < 50)
        //        {
        //            Console.WriteLine(stud.Vardas + " " + "Neislaike");
        //        }
        //    }


        //}


        //2 uzduotis

        //public static void Main()
        //{
        //    //Knyga knyga1 = new Knyga("Biblija", false);
        //    //Knyga knyga2 = new Knyga("Koranas", false);
        //    //Knyga knyga3 = new Knyga("Vedos", false);
        //    //Knyga knyga4 = new Knyga("Tora", false);
        //    //Knyga knyga5 = new Knyga("Ateizmo vadovelis", true);

        //    //List<Knyga> KnyguSarasas = new List<Knyga>();
        //    //KnyguSarasas.Add(knyga1);
        //    //KnyguSarasas.Add(knyga2);
        //    //KnyguSarasas.Add(knyga3);
        //    //KnyguSarasas.Add(knyga4);
        //    //KnyguSarasas.Add(knyga5);

        //    //foreach (Knyga knyg in KnyguSarasas)
        //    //{
        //    //    if (knyg.Isnuomota == true)
        //    //    {
        //    //        Console.WriteLine("Si knyga (" + knyg.Pavadinimas + ") yra isnuomota");
        //    //    }
        //    //}
        //}

        //3 uzduotis

        //public static void Main()
        //{
        //    Produktas prod1 = new Produktas("Kiausiniai", 3.99);
        //    Produktas prod2 = new Produktas("Duona", 1.50);
        //    Produktas prod3 = new Produktas("Mesa", 5.39);
        //    Produktas prod4 = new Produktas("Saldainiai", 3.69);
        //    Produktas prod5 = new Produktas("Woop", 7.00);

        //    List<Produktas> ProduktuSarasas = new List<Produktas> { prod1, prod2, prod3, prod3, prod4, prod5 };

        //    double BendraKaina = 0;

        //    foreach (Produktas produkt in ProduktuSarasas)
        //    {
        //        BendraKaina += produkt.Kaina;
        //    }
        //    Console.WriteLine("Bendra produktu kaina: " + BendraKaina);


        //}

        //4 uzduotis

        public static void Main()
        {
            Customer cust1 = new Customer("Mantvydas");
            Customer cust2 = new Customer("Aurimas");
            Customer cust3 = new Customer("Kestas");

            Product prod1 = new Product("Suris", 5.66);
            Product prod2 = new Product("Desra", 9.56);
            Product prod3 = new Product("Alus", 8.46);
            Product prod4 = new Product("Vista", 6.89);
            Product prod5 = new Product("Kiauliena", 1.66);
            Product prod6 = new Product("Vynas", 2.69);
            Product prod7 = new Product("Cigaretes", 3.79);
            Product prod8 = new Product("Kiausiniai", 3.66);
            Product prod9 = new Product("Degtine", 9.58);

            List<Product> ProductList1 = new List<Product> { prod1, prod2, prod3 };
            List<Product> ProductList2 = new List<Product> { prod4, prod5, prod6 };
            List<Product> ProductList3 = new List<Product> { prod7, prod8, prod9 };

            Order order1 = new Order(cust1, ProductList1);
            Order order2 = new Order(cust2, ProductList2);
            Order order3 = new Order(cust3, ProductList3);

            List<Order> AllOrders = new List<Order> { order1, order2, order3};

            double total = 0;
            foreach(var order in AllOrders)
            {
                total += order.GetTotalPrice();
                Console.WriteLine(order.Customer.Name + " uzsisake uz: " + Math.Round(order.GetTotalPrice(), 2));
            }
            Console.WriteLine("Bendra visu suma: " + total);



        }


    }
}
