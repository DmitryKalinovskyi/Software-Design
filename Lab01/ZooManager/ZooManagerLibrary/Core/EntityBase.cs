namespace ZooManagerLibrary.Core
{
    public class EntityBase
    {
        public Guid Id { get; set; }

        public EntityBase()
        {
            Id = new Guid();
        }
    }
}
