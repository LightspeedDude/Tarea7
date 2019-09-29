using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea7.ViewModels
{
    public class HomePageViewModel
    {
        public string Name { get; set; } = "Username";
        public DateTime Day { get; set; }

        public bool IsAdmin { get; set; }
    }
}
