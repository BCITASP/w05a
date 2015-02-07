using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDevLab.Models
{
    public class Province
    {
        public virtual int ProvinceId { get; set; }
        public virtual string ProvinceCode { get; set; }
        public virtual string ProvinceName { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}