using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PickACardUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Læs positionen af skyderen numberOfCards og omsæt denne til et heltal
            int antalKort = (int)numberOfCards.Value;

            // Træk det ønskede antal kort, og gem dem i tabbellen mineKort
            string[] mineKort = CardPicker.PickSomeCards(antalKort);
            
            // Listboxen i vores GUI skal renses for tidligere værdier
            listOfCards.Items.Clear();  

            // Fyld de trukne kort over i listboxen i vores GUI
            foreach(string kort in mineKort)
            {
                listOfCards.Items.Add(kort);
            }
        }
    }
}
