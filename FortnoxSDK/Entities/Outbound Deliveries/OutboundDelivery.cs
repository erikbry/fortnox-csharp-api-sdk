using Fortnox.SDK.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Fortnox.SDK.Entities;

[Entity(SingularName = "OutboundDelivery", PluralName = "OutboundDeliveries")]
public class OutboundDelivery
{
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

    ///<summary> The properties for the object in this array is listed in the table "Outbound Delivery Rows". </summary>
    [JsonProperty("rows")]
    public IList<OutboundDeliveryRow> Rows { get; set; }

    ///<summary> Stock point code. </summary>
    [JsonProperty("stockPointCode")]
    public string StockPointCode { get; set; }

    ///<summary> Stock point id. </summary>
    [JsonProperty("stockPointId")]
    public string StockPointId { get; set; }

    ///<summary> Stock point name. </summary>
    [JsonProperty("stockPointName")]
    public string StockPointName { get; set; }

    //<summary> If the delivery has been voided. </summary>    
    [JsonProperty("voided")]
    public bool? Voided { get; set; }
}
