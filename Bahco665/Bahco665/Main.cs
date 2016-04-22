using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bahco665
{
    internal class Main
    {
        #region Constructors

        public Main()
        {
            var initialLink = new Link(@"http://www.aarongardner.net");
            InitialLinkList = new List<Link> { initialLink };
            PageList = new List<Page>();
            foreach (var link in InitialLinkList)
            {
                PageList.Add(new Page(link));
            }

            foreach (var page in PageList)
            {
                MessageBox.Show(page.Content.DocumentNode.InnerText);
            }
        }

        #endregion


        #region Properties

        public List<Page> PageList { get; set; }

        public List<Link> InitialLinkList { get; private set; } 

        #endregion
    }
}
