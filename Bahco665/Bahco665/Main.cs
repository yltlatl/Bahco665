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

        public Main(IEnumerable<string> sitesList, IEnumerable<string> downloadFilesList, TargetParameters downloadFilesTargetParameters)
        {

            //Get the pages we are explicitly processing
            PageList = new List<Page>();
            foreach (var currentPage in sitesList.Select(url => new Link(url)).Select(currentLink => new Page(currentLink)))
            {
                PageList.Add(currentPage);
            }

            //create the targets we need
            TargetList = new List<Target>();
            if (downloadFilesList != null) TargetList.AddRange(GenerateFileDownloadTargets(downloadFilesList));

            //get all results (will probably update this later to get results for each layer of pages)
            ResultList = new List<Result>(GetResults(PageList, TargetList));

        }

        #endregion


        #region Properties

        public List<Page> PageList { get; private set; }

        public List<Target> TargetList { get; private set; }

        public List<Result> ResultList { get; private set; } 

        #endregion

        #region Methods

        private IEnumerable<Target> GenerateFileDownloadTargets(IEnumerable<string> fileDownloadPatterns)
        {
            var retVal =
                fileDownloadPatterns.Select(
                    pattern => new FileTarget(globalTestingStorageTarget, linkDepth, constrainToSite))
                    .Cast<Target>()
                    .ToList();
            return retVal;
        }

        private static IEnumerable<Result> GetResults(IEnumerable<Page> pages, IEnumerable<Target> targets)
        {
            if (pages == null) throw new ArgumentNullException();
            if (targets == null) throw new ArgumentNullException();

            var retVal = new List<Result>();
            var pageList = pages as List<Page>;
            if (pageList == null) return retVal;

            foreach (var target in targets)
            {
                foreach (var page in pageList)
                {
                    retVal.AddRange(target.GetResults(page));
                }
            }
            return retVal;
        }


        #endregion
    }
}
