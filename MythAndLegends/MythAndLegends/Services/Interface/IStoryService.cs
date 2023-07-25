using MythAndLegends.Data.Entity;

namespace MythAndLegends.Services.Interface;

public interface IStoryService
{
    public void AddLegend(Legend legend);
    public void AddMyth(Myth myth);

    public Story? GetMythByCode(string code);
    public Story? GetLegendByCode(string code);
}