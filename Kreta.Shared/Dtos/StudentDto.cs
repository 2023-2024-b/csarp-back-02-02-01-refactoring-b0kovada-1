using Kreta.Shared.Models.Datas.Enums;

public class StudentDto
{
    public StudentDto(Guid id, string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel, bool isWooman)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        BirthsDay = birthsDay;
        SchoolYear = schoolYear;
        SchoolClass = schoolClass;
        EducationLevel = educationLevel;
        IsWoomen = isWooman;
    }

    public StudentDto(string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel, bool isWooman)
    {
        Id = new Guid();
        FirstName = firstName;
        LastName = lastName;
        BirthsDay = birthsDay;
        SchoolYear = schoolYear;
        SchoolClass = schoolClass;
        EducationLevel = educationLevel;
        IsWoomen = isWooman;
    }

    public StudentDto()
    {
        Id = new Guid();
        FirstName = string.Empty;
        LastName = string.Empty;
        BirthsDay = new DateTime();
        SchoolYear = 9;
        SchoolClass = SchoolClassType.ClassA;
        EducationLevel = string.Empty;
        IsWoomen = false;
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthsDay { get; set; }
    public int SchoolYear { get; set; }
    public SchoolClassType SchoolClass { get; set; }
    public string EducationLevel { get; set; }
    public bool IsWoomen { get; set; }
}