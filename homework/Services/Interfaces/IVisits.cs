using System;

namespace homework.Services.Interfaces;

public interface IVisits
{
    List<string> ViewingVisits(StreamReader reader);
}
