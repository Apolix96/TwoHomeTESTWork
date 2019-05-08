
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

    public class Ienumerable
    {
        //контекс для доступа
        Context context = new Context();
        // перебираем элементы
        public IEnumerable<Micro> DataUse()
        {
            IEnumerable<Micro> ien = context.micros;
            // возращаевм в viewbag
            return ien;
        }

       
    }

    
}