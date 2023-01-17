using ElasticCollection.Models;
using ElasticCollection.Utility;
using System.Collections.Generic;

namespace ElasticCollection.Domain
{
    public class Database
    {
        public IList<ProductModels> Products { get; } = new List<ProductModels>() 
        { new ProductModels
            (
          iD:  ReturnSpecs.GetID(),
           name: "Laptop",
           price:  200_000,
           quantity:  1,
           orderCount: 5,
           category: "Fairly used"
            )
        };

        public List<ProductModels> TemporalProducts = new List<ProductModels>();

    }
}
