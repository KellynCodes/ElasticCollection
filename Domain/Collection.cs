using ElasticCollection.Models;
using ElasticCollection.Utility;
using System;

namespace ElasticCollection.Domain
{
    public class Collection
    {
        //class
      private readonly static Database database = new Database();


        //digits
        public static decimal _emptyDecimal = 0;
        public static int _emptyInt = 0;
        public static long _emptyLong = 0;

        //strings
        public static string _name = string.Empty;
        public static string _category = string.Empty;

        public static void ViewAllProductSpecs()
        {
            foreach (var Specs in database.Products)
            {
                Console.WriteLine($"{Specs.ID} | {Specs.Name} | {Specs.Price} {Specs.Category} | {Specs.Quantity} | {Specs.OrderCount}");
                Console.WriteLine();
                Application.GetInfo();
            }
        }
        public static void SelectProductSpecsToView()
        {
            if (CheckUserChoice.IncludeSpecName())
            {
                database.TemporalProducts.Add(new ProductModels(ReturnSpecs.GetID(), ReturnSpecs.Name(), _emptyDecimal, _emptyInt, _emptyLong, _category));
            }
            if (CheckUserChoice.IncludeSpecPrice())
            {
                database.TemporalProducts.Add(new ProductModels(ReturnSpecs.GetID(), ReturnSpecs.Name(), ReturnSpecs.Price(), _emptyInt, _emptyLong, _category));

            }
            foreach(var Specs in database.TemporalProducts)
            {
                Console.WriteLine($"{Specs.ID} | {Specs.Name} | {Specs.Price} {Specs.Category} | {Specs.Quantity} | {Specs.OrderCount}");
                Console.WriteLine();
            }
        }
    }
}
