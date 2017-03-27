using System;
using System.Collections.Generic;

public class School
{
    Dictionary<string, int> students = new Dictionary<string, int>();
    public void Add(string student, int grade)
    {
        students.Add(student, grade);
    }

    public IEnumerable<string> Roster(int grade)
    {
        List<string> students = new List<string>();
        foreach (var i in this.students)
        {
            if (i.Value == grade)
            {
                students.Add(i.Key);
            }
        }
        students.Sort();
        return students;
    }

    public IEnumerable<string> Grade(int grade)
    {
        return Roster(grade);
    }
}