namespace BuilderPattern.Models
{
    class HeroBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "helmet";
        }

        public override void BuildFace()
        {
            actor.Face = "handsome";
        }

        public override void BuildTSex()
        {
            actor.Sex = "male";
        }

        public override void BuildType()
        {
            actor.Type = "Hero";
        }

        public override void BuildHairStyle()
        {
            actor.Hairstyle = "short hair";
        }
    }
}
