using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Data.Models
{
    public class PageHrefService
    {
        private NavigationManager navigationManager;

        public PageHrefService(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        public string GetHref(string baseUri, params object[] attributes)
        {
            string resultHref = baseUri + string.Join("/", attributes);
            return resultHref;
        }

        public void NavigateTo(string baseUri)
        {
            navigationManager.NavigateTo(baseUri);
        }

        public void NavigateTo(string baseUrl, params object[] attributes)
        {
            var resultHref = GetHref(baseUrl, attributes);
            navigationManager.NavigateTo(resultHref);
        }
    }
}
