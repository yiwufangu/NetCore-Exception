using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Exception.Models
{
    public class Apple
    {
        [Required(ErrorMessage = "苹果名称Name不能为空")]
        public string Name { get; set; }

        [Range(1, 5, ErrorMessage = "别贪吃，只有1-5个")]
        public int Quantity { get; set; }
    }
}
