using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Fortnox.SDK.Connectors.Base;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Interfaces;
using Fortnox.SDK.Requests;
using Fortnox.SDK.Utility;
using Fortnox.SDK.Search;

namespace Fortnox.SDK.Connectors;

internal class StockPointConnector : SearchableWarehouseEntityConnector<StockPoint, StockPoint, StockPointSearch>, IStockPointConnector
{
    public StockPointConnector()
    {
        Endpoint = Endpoints.StockPoints;
    }

    public async Task<EntityCollection<StockPoint>> FindAsync(StockPointSearch searchSettings)
    {
        return await BaseFind(searchSettings).ConfigureAwait(false);
    }

    public Task<IList<StockPoint>> QueryAsync(string codeOrName = null, StockPointState state = StockPointState.All)
    {
        var queryParameters = new Dictionary<string, string>
        {
            ["state"] = state.GetStringValue()
        };
        if (codeOrName != null)
            queryParameters.Add("q", codeOrName);
        return BaseQuery(queryParameters);
    }

    public Task<StockPoint> GetAsync(string id)
    {
        return BaseGet(id);
    }

    public async Task<StockPoint> UpdateAsync(StockPoint stockPoint)
    {
        var request = new EntityRequest<StockPoint>
        {
            Entity = stockPoint,
            Indices = new List<string> { stockPoint.Id },
            Endpoint = Endpoint,
            Method = HttpMethod.Put,
            UseEntityWrapper = false
        };
        
        return await SendAsync(request).ConfigureAwait(false);
    }
    
    public async Task<StockPoint> CreateAsync(StockPoint stockPoint)
    {
        var request = new EntityRequest<StockPoint>
        {
            Entity = stockPoint,
            Endpoint = Endpoint,
            Method = HttpMethod.Post,
            UseEntityWrapper = false
        };
        return await SendAsync(request).ConfigureAwait(false);
    }

    public Task DeleteAsync(string id)
    {
        return BaseDelete(id);
    }
}