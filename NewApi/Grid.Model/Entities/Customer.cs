using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid.Model.Entities
{

    [Table("customers")]
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }
        public String Name { get; set; }

    }
}
