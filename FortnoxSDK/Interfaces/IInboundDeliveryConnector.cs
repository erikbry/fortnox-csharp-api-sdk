using Fortnox.SDK.Entities;
using Fortnox.SDK.Requests;
using Fortnox.SDK.Search;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global
namespace Fortnox.SDK.Interfaces;

/// <remarks/>
public interface IInboundDeliveryConnector : IEntityConnector
{
    Task<InboundDelivery> GetAsync(long id);
    Task<InboundDelivery> CreateAsync(InboundDelivery inboundDelivery);
    Task<InboundDelivery> UpdateAsync(InboundDelivery inboundDelivery);
    Task DeleteAsync(long id);

}
