namespace BridgePattern.Models
{
    using Interfaces;
    abstract class Image
    {
        protected IImageImp imp;

        public void SetImageImp(IImageImp imp)
        {
            this.imp = imp;
        }

        public abstract void ParseFile(string Filename);

    }
}
