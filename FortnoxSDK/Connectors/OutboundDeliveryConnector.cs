using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Fortnox.SDK.Connectors.Base;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Interfaces;
using Fortnox.SDK.Requests;
using Fortnox.SDK.Utility;

namespace Fortnox.SDK.Connectors;

internal class OutboundDeliveryConnector : EntityConnector<OutboundDelivery>, IOutboundDeliveryConnector
{
    public OutboundDeliveryConnector()
    {
        Endpoint = Endpoints.OutboundDelivery;
    }

    public async Task<OutboundDelivery> GetAsync(long id)
    {
        var request = new EntityRequest<OutboundDelivery>
        {
            Entity = null,
            Indices = new List<string> { id.ToString() },
            Endpoint = Endpoint,
            Method = HttpMethod.Get,
            UseEntityWrapper = false
        };

        return await SendAsync(request).ConfigureAwait(false);
    }

    public async Task<OutboundDelivery> UpdateAsync(OutboundDelivery outboundDelivery)
    {
        var request = new EntityRequest<OutboundDelivery>
        {
            Entity = outboundDelivery,
            Indices = new List<string> { outboundDelivery.Id.ToString() },
            Endpoint = Endpoint,
            Method = HttpMethod.Put,
            UseEntityWrapper = false
        };

        return await SendAsync(request).ConfigureAwait(false);
    }

    public async Task<OutboundDelivery> CreateAsync(OutboundDelivery outboundDelivery)
    {
        var request = new EntityRequest<OutboundDelivery>
        {
            Entity = outboundDelivery,
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
