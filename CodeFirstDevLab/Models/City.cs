using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDevLab.Models
{
    public class City
    {
        public virtual int CityId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Population { get; set; }
        public virtual int ProvinceId { get; set; }

        public virtual Province Province { get; set; }
    }
}