using Fortnox.SDK.Connectors.Base;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Interfaces;
using Fortnox.SDK.Search;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Fortnox.SDK.Connectors;

internal class StockBalanceConnector : SearchableWarehouseEntityConnector<StockBalance, StockBalance, StockBalanceSearch>, IStockBalanceConnector
{
    public StockBalanceConnector()
    {
        Endpoint = Endpoints.StockBalance;
    }

    public async Task<EntityCollection<StockBalance>> FindAsync(StockBalanceSearch searchSettings)
    {
        return await BaseFind(searchSettings).ConfigureAwait(false);
    }

    public Task<IList<StockBalance>> QueryAsync(string[] itemIds = null, string[] stockPointCodes = null)
    {
        var queryParameters = new Dictionary<string, string>();
        
        if (itemIds is { Length: > 0 })
            queryParameters.Add("itemIds", string.Join(",", itemIds));

        if (stockPointCodes is { Length: > 0 })
            queryParameters.Add("stockPointCodes", string.Join(",", stockPointCodes));
        
        return BaseQuery(queryParameters);
    }
}


    