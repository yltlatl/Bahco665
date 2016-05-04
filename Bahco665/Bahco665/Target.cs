using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahco665
{
    public enum StorageTarget
    {
        Disk,
        SqlLite
    }

    internal abstract class Target
    {
        #region Properties

        public StorageTarget StorageTarget { get; protected set; }

        public int LinkDepth { get; protected set; }

        public bool ConstrainToSite { get; protected set; }

        #endregion

        #region Methods

        public abstract List<Result> GetResults(Page page);

        #endregion
    }

    internal class FileTarget : Target
    {
        #region Constructors

        public FileTarget(StorageTarget storageTarget, int linkDepth, bool constrainToSite)
        {
            StorageTarget = storageTarget;
            LinkDepth = linkDepth;
            ConstrainToSite = constrainToSite;
        }

        #endregion

        #region Properties

        public List<string> FileTypeList { get; private set; } 

        #endregion

        #region Methods

        public override List<Result> GetResults(Page page)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    internal class BooleanTarget : Target
    {
        #region Constructors
        public BooleanTarget()
        { }

        #endregion

        #region Properties
        //text index - TBD no idea how to implement this yet

        public string QueryString { get; private set; }

        #endregion

        #region Methods

        public bool BuildIndex()
        {
            throw new NotImplementedException();
        }

        public override List<Result> GetResults(Page page)
        {
            throw new NotImplementedException();
        }

        #endregion 
    }

    internal class RegexTarget : Target
    {
        #region Constructors
        public RegexTarget()
        { }

        #endregion

        #region Properties

        public string Regex { get; private set; }

        #endregion

        #region Methods

        public override List<Result> GetResults(Page page)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    internal class ImageTarget : Target
    {
        #region Constructors
        public ImageTarget()
        { }

        #endregion

        #region Properties

        public List<string> ImageTypeList { get; private set; }

        #endregion

        #region Methods

        public override List<Result> GetResults(Page page)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    internal class TableTarget : Target
    {
        #region Constructors
        public TableTarget()
        { }

        #endregion

        #region Properties
        public List<string> ColumnsList { get; private set; } 

        #endregion

        #region Methods

        public override List<Result> GetResults(Page page)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
