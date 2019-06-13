using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nevia.Models
{
    public class ViewModelHome
    {
        public Setting Setting { get; set; }
        public List<Service> Services { get; set; }
        public List<SliderWork> Slider { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}