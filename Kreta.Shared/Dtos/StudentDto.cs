﻿using Kreta.Shared.Models.Datas.Enums;

public class StudentDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthsDay { get; set; }
    public int SchoolYear { get; set; }
    public SchoolClassType SchoolClass { get; set; }
    public string EducationLevel { get; set; }
    public bool IsWoomen { get; set; }
}