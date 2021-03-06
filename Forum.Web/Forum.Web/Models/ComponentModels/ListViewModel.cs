﻿using System.Collections.Generic;
using Umbraco.Core.Models;

namespace AnneVibekeRejser.Web.Models.ComponentModels
{
    public class ListViewModel
    {
        public string Headline { get; set; }

        public string Lead { get; set; }

        public bool  ShowLead { get; set; }

        public IEnumerable<IPublishedContent> List { get; set; }

        public bool ShowBreadcrumb { get; set; }

        public ListViewModel()
        {
            this.ShowBreadcrumb = false;
            this.ShowLead = false;
        }

    }
}
