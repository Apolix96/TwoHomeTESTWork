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
    public class Editor
    {
        Context context = new Context();

        public void Edit(Micro micro)
        {
            context.Entry(micro).State = EntityState.Modified;
            context.SaveChangesAsync();
        }
    }
}