using Fortnox.SDK.Entities;
using Fortnox.SDK.Search;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fortnox.SDK.Interfaces;

/// <remarks/>
public interface IStockBalanceConnector : IEntityConnector
{
    Task<EntityCollection<StockBalance>> FindAsync(StockBalanceSearch searchSettings);

    Task<IList<StockBalance>> QueryAsync(string[] itemIds = null, string[] stockPointCodes = null);    
}