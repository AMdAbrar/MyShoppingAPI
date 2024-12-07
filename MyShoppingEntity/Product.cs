using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShoppingEntity
{
    public class Product
    {
        [Key]//its from data annotation it is used to primary key attribute
        public int Id { get; set; }
        //[Required] //its for validation //data annotation configure model
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
