using Fortnox.SDK.Serialization;
using Newtonsoft.Json;

namespace Fortnox.SDK.Entities;

[Entity(SingularName = "InboundDeliveryRow", PluralName = "InboundDeliveryRows")]
public class InboundDeliveryRow
{
    ///<summary> Batch code for the item. </summary>
    [JsonProperty]
    public string Batch { get; set; }

    ///<summary> Code of the cost center for the row. </summary>
    [JsonProperty]
    public string CostCenterCode { get; set; }

    ///<summary> Direct cost for the row. </summary>
    [JsonProperty]
    public decimal DirectCost { get; set; }

    ///<summary> Freight cost for the row. </summary>
    [JsonProperty]
    public decimal FreightCost { get; set; }

    ///<summary> Item description. </summary>
    [JsonProperty]
    public string ItemDescription { get; set; }

    ///<summary> Item ID. </summary>
    [JsonProperty]
    public string ItemId { get; set; }

    ///<summary> Item unit. </summary>
    [JsonProperty]
    public string ItemUnit { get; set; }

    ///<summary> Other cost for the row. </summary>
    [JsonProperty]
    public decimal OtherCost { get; set; }

    ///<summary> Code of the project for the row. </summary>
    [JsonProperty]
    public string ProjectId { get; set; }

    ///<summary> Quantity of the item. </summary>
    [JsonProperty]
    public decimal Quantity { get; set; }

    ///<summary> Row ID for updating specific row. </summary>
    [JsonProperty]
    public long RowId { get; set; }

    ///<summary> Stock location code. </summary>
    [JsonProperty]
    public string StockLocationCode { get; set; }

    ///<summary> Stock location ID. </summary>
    [JsonProperty]
    public string StockLocationId { get; set; }

    ///<summary> Stock location name. </summary>
    [JsonProperty]
    public string StockLocationName { get; set; }

    ///<summary> Stock point code. </summary>
    [JsonProperty]
    public string StockPointCode { get; set; }

    ///<summary> Stock point ID. </summary>
    [JsonProperty]
    public string StockPointId { get; set; }

    ///<summary> Stock point name. </summary>
    [JsonProperty]
    public string StockPointName { get; set; }
}
