using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using dbsamicro.Models;
namespace dbsamicro.srpDjihad
{
    public class Info
    {
        Context context = new Context();
        public Micro Informirovanie(int? id)
        {
            var micros=context.micros.FirstOrDefault(d => d.Id == id);
            return micros;
        }
            
               
        

    }
}