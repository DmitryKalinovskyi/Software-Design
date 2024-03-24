using System.Text;

namespace Builder.Models
{
    public class Enemy: HumanoidEntity
    {
        public List<string> ListOfBadThingsDone { get; set; }

        public Enemy()
        {
            ListOfBadThingsDone = new List<string>();
        }

        public override string GetInfo()
        {
            var info = base.GetInfo();

            var builder = new StringBuilder(info);
            builder.AppendLine("List of bad things done by enemy: ");

            foreach (var goodThing in ListOfBadThingsDone)
            {
                builder.AppendLine(goodThing);
            }

            return builder.ToString();
        }
    }
}
