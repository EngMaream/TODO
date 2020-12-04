using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace To_Do
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Bu_Clicked(object sender, EventArgs e)
        {
            entry.IsVisible = true;
            bu1.IsVisible = true;
            bu.IsVisible = false;
        }

        private void Bu1_Clicked(object sender, EventArgs e)
        {
            if(entry.Text!="")
            {
                entry.IsVisible =false;
                bu1.IsVisible = false;
                bu.IsVisible = true;
                stack.Children.Add(new Label
                {
                    Text = entry.Text,
                    FontSize = 20,
                    TextColor = Color.Blue,
                });
            }
            entry.Text = "";
        }
    }
}
