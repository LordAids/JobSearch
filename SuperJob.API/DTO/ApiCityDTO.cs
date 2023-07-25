using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperJob.API.DTO
{
    public class ApiCityDTO
    {
       public int id { get; set; }
       public int id_region { get; set; }
       public int id_country { get; set; }
       public string title { get;set; }
       public string title_eng { get; set; }
    }
}
