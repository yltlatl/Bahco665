using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bahco665
{
    //TODO: need to implement iEquatable (with reference equality?)
    internal class Link
    {
        #region Constructors
        public Link()
        { }

        public Link(string linkValue, string parentLinkValue, List<string> childLinkValues) : this(linkValue)
        {
            try
            {
                ValidateLink(parentLinkValue);
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("Error validating URL: {0}", e.Message), e);
            }

            ParentLinkValue = parentLinkValue;

            if (childLinkValues == null) throw new ArgumentException("childLinkValues must not be null.");

            foreach (var childLinkValue in childLinkValues)
            {
                try
                {
                    ValidateLink(childLinkValue);
                }
                catch (Exception e)
                {
                    throw new Exception(string.Format("Error validating child URL: {0}; {1}", e.Message, e.Source), e);
                }
            }

            ChildLinkValues = childLinkValues;

        }

        public Link(string linkValue)
        {
            try
            {
                ValidateLink(linkValue);
            }
            catch(Exception e)
            {
                throw new Exception(string.Format("Error validating URL: {0}", e.Message), e);
            }

            LinkValue = linkValue;
        }

        #endregion

        #region Properties

        public string LinkValue { get; private set; }

        public string ParentLinkValue { get; private set; }

        public List<string> ChildLinkValues { get; private set; }

        #endregion

        #region Methods

        private static void ValidateLink(string linkValue)
        {
            if (string.IsNullOrEmpty(linkValue))
                throw new ArgumentException(@"Link value cannot be null or empty.");

            var regex = new Regex(@"^https?:\/\/.*(\/|\.net|\.com|\.co.uk|\.int|\.edu|\.gov|\.mil)$");

            if (!regex.IsMatch(linkValue)) throw new ArgumentException(@"Not a valid URL.", "linkValue");
        }
        
        public Page GetPage(string url)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
