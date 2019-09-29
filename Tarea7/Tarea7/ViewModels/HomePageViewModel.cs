using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea7.ViewModels
{
    public class HomePageViewModel
    {
        public string Givename { get; set; }
        public string Name { get; set; } = Givename;
        public bool Lucky { get; set; }
    }


}
