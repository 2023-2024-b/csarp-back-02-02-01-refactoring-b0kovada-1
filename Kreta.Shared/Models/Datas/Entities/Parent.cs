namespace Kreta.Shared.Models.Datas.Entities;

public class Parent
{
    public Parent()
    {
        Id = Guid.NewGuid();
        FirstName = string.Empty;
        LastName = string.Empty;
        Address = string.Empty;
        IsWoman = false;
    }
    public Parent(string firstName, string lastName, string address, bool isWoman)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        IsWoman = isWoman;
    }
    public Parent(Guid id, string firstName, string lastName, string address, bool isWoman)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        IsWoman = isWoman;
    }
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public bool IsWoman { get; set; }
    public override string ToString()
    {
        return $"{LastName} {FirstName}";
    }
}
