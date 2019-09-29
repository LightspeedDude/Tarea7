using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Tarea7.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public string Givename { get; set; } = "Julio";
        public string Name { get; set; }

        DateTime time;

        public event PropertyChangedEventHandler PropertyChanged;

        public HomePageViewModel()
        {
            this.Givetime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.Givetime = DateTime.Now;
                return true;
            });
        }

        public DateTime Givetime
        {
            set
            {
                if (time != value)
                {
                    time = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Givetime"));
                    }
                }
            }
            get
            {
                return time;
            }
        }

        public bool Lucky { get; set; } = true;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
