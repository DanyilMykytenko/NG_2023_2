using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class LegendService : IStoryService
{
    public void AddLegend(Legend legend)
    {
        if (string.IsNullOrEmpty(legend.StoryCode))
        {
            legend.StoryCode = CreateCode(legend.Name);
        }
        
        Storage.Legends.Add(legend);
    }

    public Story? GetLegendByCode(string code)
    {
        return Storage.Legends.FirstOrDefault(x => x.StoryCode.Equals(code));
    }
    
    public void AddMyth(Myth myth)
    {
    }

    public Story? GetMythByCode(string code)
    {
        return null;
    }

    private string CreateCode(string name)
    {
        var code = $"{name.First()}{name.Last()}-{name.Length}";

        return code;
    }
}