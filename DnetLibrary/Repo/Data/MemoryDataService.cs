using DnetLibrary.Domain;

namespace DnetLibrary.Repo.Data;

public class MemoryDataService
{
    public Task<IEnumerable<EntityBase>> GetData(CommonTypes.EntityToken token)
    {
        IEnumerable<EntityBase> data = token switch
        {
            CommonTypes.EntityToken.Mountains => _mountainsOfNepal,
            CommonTypes.EntityToken.Temples => _templesOfNepal,
            _ => []
        };

        return Task.FromResult(data);
    }

    private IEnumerable<EntityBase> _mountainsOfNepal { get; } =
        new[]
        {
            new Mountain { Name = "Pumori", Region = CommonTypes.Region.Himal },
            new Mountain { Name = "Nilgiri", Region = CommonTypes.Region.Himal },
            new Mountain { Name = "Pumori", Region = CommonTypes.Region.Himal },
            new Mountain { Name = "Nilgiri", Region = CommonTypes.Region.Himal },
            new Mountain { Name = "Makalu", Region = CommonTypes.Region.Himal },
            new Mountain { Name = "Dhaulagiri", Region = CommonTypes.Region.Himal },
            new Mountain { Name = "Kanchenjunga", Region = CommonTypes.Region.Himal },
            new Mountain { Name = "Gaurishanker", Region = CommonTypes.Region.Himal }
        };

    private IEnumerable<EntityBase> _templesOfNepal { get; } =
        new[]{
        new Temple { Name = "Bangalamukhi", Region = CommonTypes.Region.Pahad },
        new Temple { Name = "Gadhimai", Region = CommonTypes.Region.Terai },
        new Temple {Name = "Muktinath", Region = CommonTypes.Region.Himal }
        };
    
        
        
        

}