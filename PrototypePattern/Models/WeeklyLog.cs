namespace PrototypePattern.Models
{
    using Newtonsoft.Json;
    class WeeklyLog
    {
        public Attachment Attachment { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }

        public WeeklyLog ShollowClone()
        {
            return this.MemberwiseClone() as WeeklyLog;
        }

        public WeeklyLog DeepClone()
        {
            var json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<WeeklyLog>(json);
        }

    }
}
