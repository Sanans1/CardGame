using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Card
    {
        public string DescriptiveText { get; set; }

        /// <summary>
        /// Constructs DescriptiveText from given value and suit on construction.
        /// </summary>
        public Card(string value, string suit)
        {
            DescriptiveText = value + " of " + suit;
        }
    }
}
