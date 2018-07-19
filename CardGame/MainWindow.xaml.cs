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
using Classes;

namespace CardGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deck deckToUse = new Deck();
        TextBlock txt;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the text of the TextBlock from the returned value of the deck when called.
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = deckToUse.cardPicker();
        }

        /// <summary>
        /// Sets the TextBlock to a variable to be used elsewhere and sets the text of the TextBlock for when it first loads.
        /// </summary>
        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            txt = sender as TextBlock;
            txt.Text = "Waiting for a card!";
        }
    }
}
