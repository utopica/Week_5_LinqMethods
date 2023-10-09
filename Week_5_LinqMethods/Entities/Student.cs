using System;

public class Student
{
   

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Class { get; set; }
    public decimal ScholarshipAmount { get; set; }

    public Student(string firstName, string lastName, string @class, decimal scholarshipAmount)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Class = @class;
        ScholarshipAmount = scholarshipAmount;
    }

    public Student()
    {
    }
}
