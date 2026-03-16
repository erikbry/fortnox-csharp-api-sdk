using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Fortnox.SDK.Connectors.Base;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Interfaces;
using Fortnox.SDK.Requests;
using Fortnox.SDK.Utility;

namespace Fortnox.SDK.Connectors;

internal class InboundDeliveryConnector : EntityConnector<InboundDelivery>, IInboundDeliveryConnector
{
    public InboundDeliveryConnector()
    {
        Endpoint = Endpoints.InboundDelivery;
    }

    public async Task<InboundDelivery> GetAsync(long id)
    {
        var request = new EntityRequest<InboundDelivery>
        {
            Entity = null,
            Indices = new List<string> { id.ToString() },
            Endpoint = Endpoint,
            Method = HttpMethod.Get,
            UseEntityWrapper = false
        };

        return await SendAsync(request).ConfigureAwait(false);
    }

    public async Task<InboundDelivery> UpdateAsync(InboundDelivery inboundDelivery)
    {
        var request = new EntityRequest<InboundDelivery>
        {
            Entity = inboundDelivery,
            Indices = new List<string> { inboundDelivery.Id.ToString() },
            Endpoint = Endpoint,
            Method = HttpMethod.Put,
            UseEntityWrapper = false
        };

        return await SendAsync(request).ConfigureAwait(false);
    }

    public async Task<InboundDelivery> CreateAsync(InboundDelivery inboundDelivery)
    {
        var request = new EntityRequest<InboundDelivery>
        {
            Entity = inboundDelivery,
            Endpoint = Endpoint,
            Method = HttpMethod.Post,
            UseEntityWrapper = false
        };
        return await SendAsync(request).ConfigureAwait(false);
    }

    public Task DeleteAsync(long id)
    {
        return BaseDelete(id.ToString());
    }
}