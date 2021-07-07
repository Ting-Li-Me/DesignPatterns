namespace BuilderPattern.Models
{
    class DeviBuilder:ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "black coat";
        }

        public override void BuildFace()
        {
            actor.Face = "ugly";
        }

        public override void BuildTSex()
        {
            actor.Sex = "male";
        }

        public override void BuildType()
        {
            actor.Type = "evil";
        }

        public override void BuildHairStyle()
        {
            actor.Hairstyle = "no hair";
        }
    }
}
