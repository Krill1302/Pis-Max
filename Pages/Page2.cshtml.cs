using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cute_Dog.Pages
{
    public class AboutModel : PageModel
    {
        public List<PepsiHistory> History { get; set; }

        public void OnGet()
        {
            History = new List<PepsiHistory>
        {
            new PepsiHistory
            {
                ImagePath = "/images/Gammel.png",
                Year = "1993-1996",
                Title = "Det Klassiske Pepsi Max Logo",
                Description = "I starten af 90'erne blev Pepsi Max lanceret som en sukkerfri cola med en dristig smag. Logoet fra denne æra afspejler tidens stil med et dynamisk og kantet design. Flaskekapsel-motivet signalerede en frisk og ungdommelig tilgang, hvor Pepsi Max positionerede sig som det ideelle valg for dem, der ønskede den fulde colasmag uden sukker."
            },
            new PepsiHistory
            {
                ImagePath = "/images/2009.png",
                Year = "2009-2010",
                Title = "Det Moderne og Minimalistiske Look",
                Description = "I 2009 gennemgik Pepsi en større rebranding, og Pepsi Max fik et nyt logo. Det runde ikon med den røde, hvide og blå bue blev en del af det minimalistiske design, som gav et mere stilrent og moderne udtryk. Det markerede også en tid, hvor Pepsi Max blev endnu mere populær globalt som et alternativ til traditionel cola."
            },
            new PepsiHistory
            {
                ImagePath = "/images/2025.png",
                Year = "2023-Nu",
                Title = "Det Nuværende Pepsi Max Udtryk",
                Description = "Den nyeste version af Pepsi Max-logoet kombinerer retroelementer med et moderne touch. Det nye design har skarpere linjer, en stærkere typografi og et farveskema, der vækker minder om de klassiske Pepsi-logoer. Det viser, hvordan Pepsi Max fortsætter med at være en innovativ og elsket drik, der forener historie med nutidig appel."
            }
        };
        }
    }

    public class PepsiHistory
    {
        public string ImagePath { get; set; }
        public string Year { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
    
