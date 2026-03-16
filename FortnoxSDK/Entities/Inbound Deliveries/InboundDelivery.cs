using Fortnox.SDK.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Fortnox.SDK.Entities;

[Entity(SingularName = "InboundDelivery", PluralName = "InboundDeliveries")]
public class InboundDelivery
{
    ///<summary> Code of the currency. The code must be of an existing currency. </summary>
    [JsonProperty]
    public string Currency { get; set; }

    ///<summary> Currency rate used. </summary>
    [JsonProperty]
    public decimal CurrencyRate { get; set; }

    ///<summary> Currency unit used. </summary>
    [JsonProperty]
    public decimal? CurrencyUnit { get; set; }

    ///<summary> Delivery date. Must be a valid date according to our date format. </summary>
    [JsonProperty]
    public DateTime Date { get; set; }

    ///<summary> The id number for the delivery. </summary>
    [JsonProperty]
    public long? Id { get; set; }

    ///<summary> Note for the delivery. </summary>
    [JsonProperty]
    public string Note { get; set; }

    ///<summary> If the delivery has been released, affecting the stock balance. </summary>    
    [JsonProperty]
    public bool? Released { get; set; }

    ///<summary> The properties for the object in this array is listed in the table "Inbound Delivery Rows". </summary>
    [JsonProperty]
    public IList<InboundDeliveryRow> Rows { get; set; }

    ///<summary> Stock point code. </summary>
    [JsonProperty]
    public string StockPointCode { get; set; }

    ///<summary> Stock point id. </summary>
    [JsonProperty]
    public string StockPointId { get; set; }

    ///<summary> Stock point name. </summary>
    [JsonProperty]
    public string StockPointName { get; set; }

    //<summary> If the delivery has been voided. </summary>    
    [JsonProperty]
    public bool? Voided { get; set; }
}
