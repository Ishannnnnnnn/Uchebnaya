namespace Domain.Entities;

public class Electricity : BaseEntity
{
    public double SpendAmount { get; set; }
    public DateTime CheckDate { get; set; }
    public int PeopleAmount { get; set; }

    public Electricity(
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

    public Electricity()
    {
    }
}