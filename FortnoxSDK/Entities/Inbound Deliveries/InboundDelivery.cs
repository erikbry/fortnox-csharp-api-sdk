using Fortnox.SDK.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Fortnox.SDK.Entities;

[Entity(SingularName = "InboundDelivery", PluralName = "InboundDeliveries")]
public class InboundDelivery
{
    ///<summary> Code of the currency. The code must be of an existing currency. </summary>
    [JsonProperty("currency")]
    public string Currency { get; set; }

    ///<summary> Currency rate used. </summary>
    [JsonProperty("currencyRate")]
    public decimal CurrencyRate { get; set; }

    ///<summary> Currency unit used. </summary>
    [JsonProperty("currencyUnit")]
    public decimal? CurrencyUnit { get; set; } = 1;

    ///<summary> Delivery date. Must be a valid date according to our date format. </summary>
    [JsonProperty("date")]
    public DateTime Date { get; set; }

    ///<summary> The id number for the delivery. </summary>
    [JsonProperty("id")]
    public long? Id { get; set; }

    ///<summary> Note for the delivery. </summary>
    [JsonProperty("note")]
    public string Note { get; set; }

    ///<summary> If the delivery has been released, affecting the stock balance. </summary>    
    [JsonProperty("released")]
    public bool? Released { get; set; }

    ///<summary> The properties for the object in this array is listed in the table "Inbound Delivery Rows". </summary>
    [JsonProperty("rows")]
    public IList<InboundDeliveryRow> Rows { get; set; }

    ///<summary> Stock point code. </summary>
    [ReadOnly]
    [JsonProperty("stockPointCode")]
    public string StockPointCode { get; private set; }

    ///<summary> Stock point id. </summary>
    [JsonProperty("stockPointId")]
    public string StockPointId { get; set; }

    ///<summary> Stock point name. </summary>
    [ReadOnly]
    [JsonProperty("stockPointName")]
    public string StockPointName { get; private set; }

    //<summary> If the delivery has been voided. </summary>    
    [JsonProperty("voided")]
    public bool? Voided { get; set; }
}
