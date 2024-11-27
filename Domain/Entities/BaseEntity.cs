namespace Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }

    public void SetId(Guid id)
    {
        Id = id;
    }
}