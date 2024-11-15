using Kreta.Shared.Models.Datas.Enums;

public class ParentDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;
    public bool IsWoman { get; set; }
}