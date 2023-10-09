using System;

Console.WriteLine("Linq Methods");



#region Concat

Student student1 = new Student("Dilara", "Kurtuluş", "A101", 50000);
Student student2 = new Student("Elif", "Başaran", "B202",100000);
Student student3 = new Student("Eren", "Özgür", "B202",150000);
Student student4 = new Student("Ayşe", "Şen", "A101",25000);
Student student5 = new Student("Mehmet", "Çınar", "B202",75000);
Student student6 = new Student("Fatma", "Güney", "F606",100000);

List<Student> Lab1 = new List<Student> { student1, student2, student3 };
List<Student> Lab2 = new List<Student> { student4, student5, student6 };

var TotalLabStudents = Lab1.Concat(Lab2).ToList();



#endregion

#region Average

decimal averageScholarship = TotalLabStudents.Average(x => x.ScholarshipAmount);



Console.WriteLine($"Average Scholorship Amount: {averageScholarship} ");

Console.WriteLine();

#endregion

#region Distinct

var UniqueClasses = TotalLabStudents.Select(student => student.Class).Distinct();

Console.WriteLine("Unique Classes:");
foreach (var uniqueClass in UniqueClasses)
{
    Console.WriteLine(uniqueClass);
}
Console.WriteLine();
#endregion


#region Skip

//var remainingStudents = TotalLabStudents.Skip(2);
var remainingStudents = TotalLabStudents.Where(x => x.Class != "A101").Skip(2);

Console.WriteLine("Remaining Students in Lab:");

foreach (var student in remainingStudents)
{
    Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}, Class: {student.Class}");
}
Console.WriteLine();

#endregion

#region Take

var selectedStudents = TotalLabStudents.Where(x => x.ScholarshipAmount >= 100000).Take(2);

Console.WriteLine("Selected Students For a Raise:");
foreach (var student in selectedStudents)
{
    Console.WriteLine($"ID: {student.Id}");
    Console.WriteLine($"First Name & Last Name: {student.FirstName} {student.LastName}");
    Console.WriteLine($"Class: {student.Class}");
    Console.WriteLine($"Scholarship Amount: {student.ScholarshipAmount}");
    Console.WriteLine("--------------");
}

#endregion

#region  Select

var studentNames = TotalLabStudents.Select(x => x.FirstName);

Console.WriteLine("Selected Studens' Names : ");
foreach (var name in studentNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();
#endregion

#region OrderBy

var sortedStudents = TotalLabStudents.OrderBy(x => x.ScholarshipAmount);

#endregion

#region GroupBy
var groupedStudents = TotalLabStudents.GroupBy(x => x.Class);

Console.WriteLine("Grouping Students According to Classes :");
foreach (var group in groupedStudents)
{
    Console.WriteLine($"Sınıf: {group.Key}");
    foreach (var student in group)
    {
        Console.WriteLine($"ID: {student.Id}, Ad: {student.FirstName} {student.LastName}, Burs: {student.ScholarshipAmount:C}");
    }
    Console.WriteLine();
}



#endregion

#region Max & Sum

var maxScholarshipStudent = TotalLabStudents.OrderByDescending(x => x.ScholarshipAmount).First();
decimal totalScholarships = TotalLabStudents.Sum(student => student.ScholarshipAmount);

Console.WriteLine($"Total Scholarship Amount: {totalScholarships}");
Console.WriteLine();

Console.WriteLine($"The Student with the Highest Scholarship : ");
Console.WriteLine($"ID: {maxScholarshipStudent.Id}");
Console.WriteLine($"First Name & Last Name: {maxScholarshipStudent.FirstName} {maxScholarshipStudent.LastName}");
Console.WriteLine($"Class: {maxScholarshipStudent.Class}");
Console.WriteLine($"Scholarship Amount: {maxScholarshipStudent.ScholarshipAmount}");
#endregion

