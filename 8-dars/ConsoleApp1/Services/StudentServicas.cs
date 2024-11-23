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
            StudentName = "Suxrob",
            StudentAge = 19,
            StudentPhoneNumber = "+998971070052",
        };
        var secondStudent = new Student()
        {
            StudentId = Guid.NewGuid(),
            StudentName = "Davron",
            StudentAge = 20,
            StudentPhoneNumber = "+998950805001",
        };
        var thirdStudent = new Student()
        {
            StudentId = Guid.NewGuid(),
            StudentName = "Murod",
            StudentAge = 22,
            StudentPhoneNumber = "+998997210031",
        };

        students.Add(firstStudent);
        students.Add(secondStudent);
        students.Add(thirdStudent);
    }
}
