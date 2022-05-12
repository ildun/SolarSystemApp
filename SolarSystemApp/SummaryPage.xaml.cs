using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystemApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class SummaryFact
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
    public partial class SummaryPage : ContentPage
    {
        public static SummaryFact[] SummaryList = new[]{
            new SummaryFact {Title="Age", Content="4.568 billion years" },
            new SummaryFact {Title="Location", Content="Local Interstellar Cloud, Local Bubble, Orion–Cygnus Arm, Milky Way" },
            new SummaryFact {Title="System mass	", Content="1.0014 Solar masses" },
            new SummaryFact {Title="Nearest star", Content="Proxima Centauri (4.25 ly)" },
            new SummaryFact {Title="Nearest known planetary system", Content="Proxima Centauri system (4.25 ly)" },
            new SummaryFact {Title="Stars", Content="1 (Sun)" },
            new SummaryFact {Title="Known planets", Content="8 declared by IAU: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune" },
            new SummaryFact {Title="Known natural satellites", Content="657 (206 planetary451 minor planetary)" },
            new SummaryFact {Title="Known minor planets", Content="1,199,224" },
            new SummaryFact {Title="Known comets", Content="4,402" },
            new SummaryFact {Title="Identified rounded satellites", Content="19" }
        };
        public SummaryPage()
        {
            InitializeComponent();
        }
    }
}