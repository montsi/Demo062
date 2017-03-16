using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LotteryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {      
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(arvoTextBox.Text);

            for (int j = 0; j <= value; j++)
            {
                Random rand = new Random();
                int number = rand.Next(1, 39 + 1);
                tulosTextBlock.Text = number.ToString();

                for (int i = 0; i <= 7; i++)
                {

                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            tulosTextBlock.Text = "";
        }
    }
}
