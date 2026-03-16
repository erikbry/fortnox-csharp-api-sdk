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
public interface IOutboundDeliveryConnector : IEntityConnector
{
    Task<OutboundDelivery> GetAsync(long id);
    Task<OutboundDelivery> CreateAsync(OutboundDelivery outboundDelivery);
    Task<OutboundDelivery> UpdateAsync(OutboundDelivery outboundDelivery);
    Task DeleteAsync(long id);
}
