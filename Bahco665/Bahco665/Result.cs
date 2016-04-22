using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahco665
{
    internal abstract class Result
    {
        #region Properties

        public string SourceUrl { get; private set; }

        public string ResultContent { get; private set; }

        #endregion

        #region Methods

        public abstract bool StoreResult();

        #endregion
    }

    internal class FileResult : Result
    {
        #region Constructors
        public FileResult()
        { }

        #endregion 

        #region Methods

        public override bool StoreResult()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    internal class BooleanResult : Result
    {
        #region Constructors
        public BooleanResult()
        { }

        #endregion

        #region Methods

        public override bool StoreResult()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    internal class RegexResult : Result
    {
        #region Constructors
        public RegexResult()
        { }

        #endregion

        #region Methods

        public override bool StoreResult()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    internal class ImageResult : Result
    {
        #region Constructors
        public ImageResult()
        { }

        #endregion

        #region Methods

        public override bool StoreResult()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    internal class TableResult : Result
    {
        #region Constructors
        public TableResult()
        { }

        #endregion

        #region Methods

        public override bool StoreResult()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
