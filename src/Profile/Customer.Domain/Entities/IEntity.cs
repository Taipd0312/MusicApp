namespace Customer.Domain.Entities
{
    internal interface IEntity<Primarykey>
    {
        public Primarykey Id { get; set; }
    }

    public class Entity<Primarykey> : IEntity<Primarykey>
    {
        public Primarykey Id { get ; set ; }
    }
}
