namespace BuilderPattern.Models
{
    class ActorController
    {
        public Actor Construct(ActorBuilder ab)
        {
            Actor actor;
            ab.BuildType();
            ab.BuildTSex();
            ab.BuildFace();
            ab.BuildCostume();
            ab.BuildHairStyle();

            actor = ab.CreateActor();
            return actor;
        }
    }
}
