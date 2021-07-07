namespace BuilderPattern.Models
{
    // abstract builder
    abstract class ActorBuilder
    {
        protected Actor actor = new Actor();

        public abstract void BuildType();
        public abstract void BuildTSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairStyle();

        public Actor CreateActor()
        {
            return actor;
        }

    }
}
