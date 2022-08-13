using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic
{
    public class Category 
    {
        public int ID { get; set; }
        [DisplayName("الإسم")]
        [Required]
        public string Name { get; set; }
        [DisplayName("الوصف")]
        public string Description { get; set; }
        public ICollection<News> News { get; set; }
            = new List<News>();
    }
}
