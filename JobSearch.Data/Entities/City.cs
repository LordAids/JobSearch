using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.Data.Entities
{
    public class City
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int SuperJobId { get; set; }
    }
}
