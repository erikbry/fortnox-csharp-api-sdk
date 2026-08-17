using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Requests;
using Fortnox.SDK.Search;
using Fortnox.SDK.Utility;

namespace Fortnox.SDK.Connectors.Base;

internal abstract class SearchableWarehouseEntityConnector<TEntity, TEntitySubset, TSearchSettings> : EntityConnector<TEntity>
    where TEntity : class
    where TSearchSettings : BaseSearch, new()
{
    protected async Task<EntityCollection<TEntitySubset>> BaseFind(BaseSearch searchSettings)
    {
        var request = new SearchRequest<TEntitySubset>()
        {
            Endpoint = Endpoint,
            SearchSettings = searchSettings
        };

        return await SendAsync(request).ConfigureAwait(false);
    }

    protected async Task<EntityCollection<T>> SendAsync<T>(SearchRequest<T> request)
    {
        if (request.SearchSettings != null && request.SearchSettings.Limit == ApiConstants.Unlimited)
            return await GetAllInOnePage(request).ConfigureAwait(false);
        else
            return await GetSinglePage(request).ConfigureAwait(false);
    }

    private async Task<EntityCollection<T>> GetAllInOnePage<T>(SearchRequest<T> request)
    {
        int offset = 0; // paging don't work for warehouse entities, but offset does
        var allEntities = new List<T>();
        while (true)
        {
            var singlePageRequest = Clone(request);
            singlePageRequest.SearchSettings.Offset = offset;
            singlePageRequest.SearchSettings.Limit = ApiConstants.MaxLimit;

            var result = await GetSinglePage(singlePageRequest).ConfigureAwait(false);
            allEntities.AddRange(result.Entities);

            if (result.Entities.Count < ApiConstants.MaxLimit)
                break;
            offset += ApiConstants.MaxLimit;
        }

        var collection = new EntityCollection<T>()
        {
            Entities = allEntities,
            MetaInformation = new MetaInformation()
            {
                TotalPages = allEntities.Count > 0 ? 1 : 0,
                CurrentPage = 1,
                TotalResources = allEntities.Count
            }
        };
        return collection;
    }

    private async Task<EntityCollection<T>> GetSinglePage<T>(SearchRequest<T> request)
    {
        request.Parameters.AddRange(request.SearchSettings?.GetSearchParameters());

        var responseData = await SendAsync((BaseRequest)request).ConfigureAwait(false);
        var responseJson = Encoding.UTF8.GetString(responseData);

        // Response is in the format [ {}, {} ], so we need to deserialize it as a list of T and then wrap it in an EntityCollection.
        var entityCollection = new EntityCollection<T>();
        entityCollection.Entities = Serializer.Deserialize<IList<T>>(responseJson);

        return entityCollection;
    }

    private static SearchRequest<T> Clone<T>(SearchRequest<T> request)
    {
        return new SearchRequest<T>()
        {
            BaseUrl = request.BaseUrl,
            Endpoint = request.Endpoint,
            Headers = request.Headers,
            Indices = request.Indices,
            Method = request.Method,
            Parameters = new Dictionary<string, string>(request.Parameters),
            SearchSettings = Clone(request.SearchSettings),
            Content = request.Content?.ToArray()
        };
    }

    private static T Clone<T>(T obj) where T : BaseSearch
    {
        var memberwiseClone = obj?.GetType().GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic);
        return (T)memberwiseClone?.Invoke(obj, null);
    }
}