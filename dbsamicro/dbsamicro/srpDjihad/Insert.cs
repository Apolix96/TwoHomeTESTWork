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
    public class Insert
    {
        //контекс для доступа
        Context context = new Context();
        public void InsertSet( Micro micro)
        {
            context.micros.Add(micro);
            context.SaveChangesAsync();
        }

    }
            
}


