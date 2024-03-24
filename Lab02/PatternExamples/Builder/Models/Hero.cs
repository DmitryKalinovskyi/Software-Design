using System.Text;

namespace Builder.Models
{
    public class Hero : HumanoidEntity
    {
        public List<string> ListOfGoodThingsDone { get; set; }

        public Hero()
        {
            ListOfGoodThingsDone = new();
        }

        public override string GetInfo()
        {
            var info = base.GetInfo();

            var builder = new StringBuilder(info);
            builder.AppendLine("List of good things done by hero: ");

            foreach (var goodThing in ListOfGoodThingsDone)
            {
                builder.AppendLine(goodThing);
            }

            return builder.ToString();
        }
    }
}
