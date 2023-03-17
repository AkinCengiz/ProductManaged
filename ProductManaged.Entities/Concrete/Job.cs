using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManaged.Entities.Abstract;

namespace ProductManaged.Entities.Concrete
{
    public class Job : IEntity
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
