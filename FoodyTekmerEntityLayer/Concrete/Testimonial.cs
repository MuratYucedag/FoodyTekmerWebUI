using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerEntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
