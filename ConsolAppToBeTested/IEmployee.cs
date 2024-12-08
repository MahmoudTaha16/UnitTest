namespace ConsolAppToBeTested
{
    public interface IEmployee
    {
        string? Address { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        decimal Salary { get; set; }
    }
}