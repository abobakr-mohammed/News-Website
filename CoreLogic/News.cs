using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic
{
    public class News 
    {
        public int ID { get; set; }
        [DisplayName("العنوان")]
        [Required]
        public string Title { get; set; }
        [DisplayName("التاريخ")]
        [Required]
        public DateTime Date { get; set; }
        [DisplayName("الصورة")]
        public string Image { get; set; }
        [DisplayName("الموضوع")]
        public string Topic { get; set; }
        [ForeignKey("Category")]
        [DisplayName("الفئه")]
        [Required]
        public int CategoryID { get; set; }
        
        public Category Category { get; set; }

    }
}
