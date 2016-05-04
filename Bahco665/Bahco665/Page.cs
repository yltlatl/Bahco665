using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Bahco665
{
    internal class Page
    {
        #region Constructors

        public Page(Link link)
        {
            //Create an HTML Agility Pack document for this link
            var hapDocument = new HtmlDocument();
            hapDocument.LoadHtml(new WebClient().DownloadString(link.LinkValue));
            Content = hapDocument;

            //populate the other properties
            PageLink = link;
        }
        
        #endregion

        #region Properties
        public HtmlDocument Content { get; set; }

        public Link PageLink { get; private set; }

        #endregion

        #region Public Methods

        public List<Link> GetLinks()
        {
            throw new NotImplementedException();
        }



        #endregion

    }
}
