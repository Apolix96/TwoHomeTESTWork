using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace dbsamicro.Models
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context Inimicro)
        {
            Inimicro.micros.Add(new Micro { Id = 1, nameMicro = "djihad", priceMicro = 200, Seria = "321231", manufactrure="ARDUINO", Pamyat=2 });
            Inimicro.micros.Add(new Micro { Id = 2, nameMicro = "djihad", priceMicro = 220, Seria = "321231" , manufactrure = "ARDUINO", Pamyat = 2 });
            Inimicro.micros.Add(new Micro { Id = 3, nameMicro = "djihad", priceMicro = 250, Seria = "321231" , manufactrure = "ARDUINO", Pamyat = 2 });
            base.Seed(Inimicro);
        }
      
    }
}