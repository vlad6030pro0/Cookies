using System;
using System.Text;
using homework.Services.Interfaces;

namespace homework.Services;

public class Visits : IVisits
{
    public List<string> ViewingVisits(StreamReader reader)
    {
        var text = reader.ReadToEnd();
        var results = new List<string>();
        foreach(var line in text.Split("\n"))
        {
            results.Add(line);
        } 
        reader.Close();
        return results;
    }
}
