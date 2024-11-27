namespace Domain.Entities;

public class Water : BaseEntity
{
    public double SpendAmount { get; init; }
    public DateTime CheckDate { get; init; }
    public int PeopleAmount { get; set; }
    
    public Water(
        Guid id,
        double spendAmount,
        DateTime checkDate,
        int peopleAmount)
    {
        SetId(id);
        SpendAmount = spendAmount;
        CheckDate = checkDate;
        PeopleAmount = peopleAmount;
    }

    public Water()
    {
    }
}