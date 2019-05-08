using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;
using dbsamicro.Models;
namespace dbsamicro.srpDjihad
{
    public class Deletor
    {
        Context context = new Context();

            public void Delete(int id)
            {
                Micro micro = context.micros.Find(id);
                context.micros.Remove(micro);
                context.SaveChanges();
            }
        
    }
}