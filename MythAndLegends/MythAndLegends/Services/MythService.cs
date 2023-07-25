using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class MythService : IStoryService
{
    public void AddMyth(Myth myth)
    {
        if (string.IsNullOrEmpty(myth.StoryCode))
        {
            myth.StoryCode = CreateCode(myth.Name);
        }

        Storage.Myths.Add(myth);
    }

    public Story? GetMythByCode(string code)
    {
        return Storage.Myths.FirstOrDefault(x => x.StoryCode.Equals(code));
    }

    public void AddLegend(Legend legend)
    {
    }
    
    public Story? GetLegendByCode(string code)
    {
        return null;
    }
    
    private string CreateCode(string name)
    {
        var code = $"{name.First()}{name.Last()}-{name.Length}";

        return code;
    }
}