namespace BuilderPattern.Models
{
    class AngelBuilder:ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "skirt";
        }

        public override void BuildFace()
        {
            actor.Face = "beautiful";
        }

        public override void BuildTSex()
        {
            actor.Sex = "female";
        }

        public override void BuildType()
        {
            actor.Type = "angel";
        }

        public override void BuildHairStyle()
        {
            actor.Hairstyle = "long hair";
        }
    }
}
