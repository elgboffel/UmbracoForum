using Our.Umbraco.LinksPicker.Models;
using System.Collections.Generic;
using Umbraco.Core.Models;

namespace AnneVibekeRejser.Web.Models.ComponentModels
{
    public class HeroViewModel : MediaViewModel
    {
        public bool FluidHero { get; set; }

        public string Heading { get; set; }

        public string Trompet { get; set; }

        public HeroViewModel()
        {
            this.FluidHero = false;
        }
    }
}
