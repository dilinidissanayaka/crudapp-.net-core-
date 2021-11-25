using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crudf.Models
{
    public class Customer
    {

        //connect with db ..logic..fetch db
        [Key]
        public int CustomerId { get; set; }


        public string FullName { get; set; }


        public string CusCode { get; set; }

        public string Location { get; set; }
    }


}

