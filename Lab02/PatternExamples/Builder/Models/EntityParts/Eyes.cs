using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models.EntityParts
{
    public enum EyeType
    {
        Round=0,
        Asian=1,
        Hunter=2
    }

    public class Eyes
    {
        public Color Color { get; set; }

        public EyeType Type { get; set; }

        public Eyes():this(new Color()) { }

        public Eyes(Color color) : this(color, EyeType.Round) { }

        public Eyes(Color color,  EyeType type)
        {
            Color = color;
            Type = type;
        }

        public string GetInfo()
        {
            return $"Eyes color - {Color}, Eyes type - {Type}";
        }
    }
}
