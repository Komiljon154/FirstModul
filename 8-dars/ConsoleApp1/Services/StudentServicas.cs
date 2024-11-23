using System.Collections.Generic;
using System;


internal class StudentServices
{
    private List<Student> students;

    public StudentServices()
    {
        students = new List<Student>();
        DataSeed();
    }

    public Student AddStudent(Student student)
    {
        student.StudentId = Guid.NewGuid();
        students.Add(student);

        return student;
    }

    public bool DeleteStudent(Guid studentId)
    {
        var exists = false;
        foreach (var student in students)
        {
            if (student.StudentId == studentId)
            {
                students.Remove(student);
                exists = true;
                break;
            }
        }

        return exists;
    }

    public bool UpdateStudent(Student updateStudent)
    {
        for (var i = 0; i < students.Count; i++)
        {
            if (students[i].StudentId == updateStudent.StudentId)
            {
                students[i] = updateStudent;
                return true;
            }
        }

        return false;
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }

    public Student GetById(Guid studentId)
    {
        foreach (var student in students)
        {
            if (student.StudentId == studentId)
            {
                return student;
            }
        }

        return null;
    }

    private void DataSeed()
    {
        var firstStudent = new Student()
        {
            StudentId = Guid.NewGuid(),
            StudentName = "Komil",
            StudentAge = 20,
            StudentPhoneNumber = "+998576412859",
        };
        var secondStudent = new Student()
        {
            StudentId = Guid.NewGuid(),
            StudentName = "Umid",
            StudentAge = 30,
            StudentPhoneNumber = "+998944895876",
        };
        var thirdStudent = new Student()
        {
            StudentId = Guid.NewGuid(),
            StudentName = "Amin",
            StudentAge = 25,
            StudentPhoneNumber = "+998524865971",
        };

        students.Add(firstStudent);
        students.Add(secondStudent);
        students.Add(thirdStudent);
    }
}
