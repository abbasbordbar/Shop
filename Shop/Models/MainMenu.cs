using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class MainMenu
    {
        [Key]
        public int MenuId { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string MenuTitle { get; set; }
        [Display(Name = "اسم عکس")]
        [MaxLength(150, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        
        public string ImageName { get; set; }
        [Display(Name ="لینک")]
        [MaxLength(250,ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string Link { get; set; }
        [Display(Name = "ترتیب")]
        public int Sort { get; set; }
        
        [Display(Name ="نوع منو")]
       
        public byte Type { get; set; }
       
        
        public int? ParentId { get; set; }
        
        
        [ForeinKey("ParentId")]
         public List<MainMenu> MainMenus { get; set; }
       
    }
}
