using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace To_Do.ViewModels
{
    public class textViewModel:BaseViewModel
    {
        private string height_Box;
        private string width_Box;

        public textViewModel(INavigation navigation) : base(navigation)
        {
            Height_Box = Width_Box;
        }

        public string Width_Box
        {
            get => width_Box;
            set => SetProperty(ref width_Box, value);
        }

        public string Height_Box
        {
            get => height_Box;
            set => SetProperty(ref height_Box, value);
        }

    }
}
