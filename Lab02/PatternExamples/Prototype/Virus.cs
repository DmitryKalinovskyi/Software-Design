using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Virus : ICloneable
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public DateTime OrientedBirthTime { get; set; }

        public List<Virus> Children { get; set; }

        public VirusType? VirusType { get; set; }

        public Virus() : this(string.Empty, 0, DateTime.MinValue) { }

        public Virus(string name, double weight, DateTime orientedBirthTime) : this(name, weight, orientedBirthTime, null) { }

        public Virus(string name, double weight, DateTime orientedBirthTime, VirusType? virusType) : this(name, weight, orientedBirthTime, new(), virusType) { }

        public Virus(string name, double weight, DateTime orientedBirthTime, List<Virus> children, VirusType? virusType)
        {
            Name = name;
            Weight = weight;
            OrientedBirthTime = orientedBirthTime;
            Children = children;
            VirusType = virusType;
        }

        public object Clone()
        {
            var clone = new Virus
            {
                Name = Name + "-Clone",
                Weight = Weight,
                OrientedBirthTime = OrientedBirthTime
            };

            foreach (var child in Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }

            return clone;
        }

        public int GetAge()
        {
            return GetAge(DateTime.Now);
        }

        public int GetAge(DateTime toDate)
        {
            return (int)Math.Floor((toDate - OrientedBirthTime).TotalDays / 365.25);
        }

        // can be speeduped, O(VirusCount^2), due to GetChildrenCount function.  (imagine verticle stick case)
        public string GetInfo(int depth = int.MaxValue, int tabs = 0)
        {
            if (depth <= 0) return string.Empty;

            var builder = new StringBuilder();

            var tabsString = new string('\t', tabs); 

            builder.Append(tabsString).AppendLine($"Name: {Name}");
            builder.Append(tabsString).AppendLine($"Weight: {Weight}");
            builder.Append(tabsString).AppendLine($"Age: {GetAge()}");
            builder.Append(tabsString).AppendLine($"Children count: {GetChildrenCount()}");

            foreach(var child in Children)
            {
                builder.AppendLine(child.GetInfo(depth - 1, tabs + 1));
            }

            return builder.ToString();
        }

        public int GetChildrenCount()
        {
            int children = 0;

            foreach(var child in Children)
            {
                // Add this child.
                children++;

                // Add their children.
                children += child.GetChildrenCount();
            }

            return children;
        }
    }
}
