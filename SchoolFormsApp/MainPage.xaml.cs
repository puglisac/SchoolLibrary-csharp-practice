using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SchoolFormsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("Clicked");
            ((Button)sender).Text = $"You Clicked {count} times";
        }
    }
}
