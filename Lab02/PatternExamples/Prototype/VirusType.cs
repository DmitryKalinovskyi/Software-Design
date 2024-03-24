namespace Prototype
{
    public class VirusType
    {
        public string TypeName { get; set; }

        // here you can write weakness of current virus

        public VirusType(string typeName)
        {
            TypeName = typeName;
        }

    }
}
