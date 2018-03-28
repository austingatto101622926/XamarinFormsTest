using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsWorldHello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotePage : ContentPage
	{
        String[] Quotes = new String[]
            {
                "I seem to have been only like a boy playing on the seashore, and diverting myself in now and then finding a smoother pebble or a prettier shell than ordinary, whilst the great ocean of truth lay all undiscovered before me. - Isaac Newton",
                "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe. - Albert Einstein",
                "Life cannot have had a random beginning ... The trouble is that there are about 2000 enzymes, and the chance of obtaining them all in a random trial is only one part in 10^40,000, an outrageously small probability that could not be faced even if the whole universe consisted of organic soup. - Fred Hoyle",
                "It is strange that only extraordinary men make the discoveries, which later appear so easy and simple. - Georg C. Lichtenberg",
                "There may be babblers, wholly ignorant of mathematics, who dare to condemn my hypothesis, upon the authority of some part of the Bible twisted to suit their purpose. I value them not, and scorn their unfounded judgment. - Nicolaus Copernicus"
            };
        int ActiveIndex = 0;

        public QuotePage()
        {

            InitializeComponent();
            Output.Text = Quotes[ActiveIndex];
        }

        public void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (ActiveIndex == 4)
            {
                ActiveIndex = 0;
            }
            else
            {
                ActiveIndex++;
            }
            Output.Text = Quotes[ActiveIndex];
        }
    }
}