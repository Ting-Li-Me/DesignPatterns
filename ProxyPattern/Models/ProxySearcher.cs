namespace ProxyPattern.Models
{
    using Interfaces;
    class ProxySearcher : ISearcher
    {
        private RealSearcher searcher = new RealSearcher();
        private AccessValidator validator;
        private Logger logger;

        public string DoSearch(string userId, string keyword)
        {

            if (this.Validate(userId))
            {
                string result = searcher.DoSearch(userId, keyword);

                this.Log(userId);

                return result;
            }
            else
            {
                return null;
            }
        }

        private bool Validate(string userId)
        {
            validator = new AccessValidator();
            return validator.Validate(userId);
        }

        private void Log(string userId)
        {
            logger = new Logger();
            logger.Log(userId);
        }

    }
}
