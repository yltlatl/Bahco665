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
            var hapDocument = new HtmlDocument();
            hapDocument.LoadHtml(new WebClient().DownloadString(link.LinkValue));
            Content = hapDocument;
        }
        
        #endregion

        #region Properties
        public HtmlDocument Content { get; set; }

        public string Url { get; private set; }

        public string ParentUrl { get; private set; }

        #endregion

        #region Public Methods

        public List<Link> GetLinks()
        {
            throw new NotImplementedException();
        }



        #endregion

    }
}
