using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class Food
    {
        public int FoodId { get; set; }

        [Column(TypeName="character varying(100)")]
        public string Name { get; set; }

        [Column(TypeName = "double precision")]
        public double Price { get; set; }

    }
}
