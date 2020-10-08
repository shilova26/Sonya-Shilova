using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Coffeehouse.Models
{
    public class CardDbInitializer : DropCreateDatabaseAlways<CardContext>
    {
        protected override void Seed(CardContext db)
        {
            db.Cards.Add(new Card { Name = "500 рублей", Description = "Дает возможность приобрести любую продукцию нашей кофейни на 500 рублей", Price = 500 });
            db.Cards.Add(new Card { Name = "1000 рублей", Description = "Дает возможность приобрести любую продукцию нашей кофейни на 1000 рублей", Price = 1000 });
            db.Cards.Add(new Card { Name = "Бонусная карта", Description = "Накопительная система бонусов, которые дают скидку на нашу продукцию", Price = 150 });
           
            base.Seed(db);
        }
    }
}