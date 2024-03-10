namespace ZooManagerLibrary.Core
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        public EntityBase()
        {
            Id = new Guid();
        }
    }
}
