﻿using System.Collections.Generic;
using Umbraco.Core.Models;

namespace AnneVibekeRejser.Web.Models.ComponentModels
{
    public class BreadcrumbViewModel
    {
        public IPublishedContent CurrentPage { get; set; }

        public bool ShowCurrentPage { get; set; }

        public BreadcrumbViewModel()
        {
            this.ShowCurrentPage = true;
        }
    }
}
