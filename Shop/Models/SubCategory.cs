using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public int ParentId { get; set; }
        public int SubId { get; set; }
        
        
        [InverseProperty("ParentCa")]
        [ForeinKey("CategoryId")]
        public Category ParentCategory { get; set; }

        
        [InverseProperty("SubCa")]
        [ForeinKey("SubId")]
        public Category SubCat { get; set; }






    }
}
