using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment()
    {
        _title = "Unknown";
    }

    public WritingAssignment(string name, string topic, string title)
        : base(name,topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {base.GetStudentName()}";
    }
}