using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_API.Models.ViewModel
{
    public class RequestOrderItems
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        //[Required]
        //public string ContactNo { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
