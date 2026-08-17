using Fortnox.SDK.Serialization;
using Newtonsoft.Json;

namespace Fortnox.SDK.Entities;

[Entity(SingularName = "OutboundDeliveryRow", PluralName = "OutboundDeliveryRows")]
public class OutboundDeliveryRow
{
    ///<summary> Code of the cost center for the row. </summary>
    [JsonProperty("costCenterCode")]
    public string CostCenterCode { get; set; }

    ///<summary> Delivered quantity. </summary>
    [JsonProperty("deliveredQuantity")]
    public decimal DeliveredQuantity { get; set; }

    ///<summary> Forced quantity. </summary>
    [JsonProperty("forcedQuantity")]
    public decimal ForcedQuantity { get; set; }

    ///<summary> Item description. </summary>
    [JsonProperty("itemDescription")]
    public string ItemDescription { get; set; }

    ///<summary> Item ID. </summary>
    [JsonProperty("itemId")]
    public string ItemId { get; set; }

    ///<summary> Item unit. </summary>
    [JsonProperty("itemUnit")]
    public string ItemUnit { get; set; }

    ///<summary> Code of the project for the row. </summary>
    [JsonProperty("projectId")]
    public string ProjectId { get; set; }

    ///<summary> Quantity of the item. </summary>
    [JsonProperty("quantity")]
    public decimal Quantity { get; set; }

    ///<summary> Reserved quantity. </summary>
    [JsonProperty("reservedQuantity")]
    public decimal ReservedQuantity { get; set; }

    ///<summary> Row ID for updating specific row. </summary>
    [JsonProperty("rowId")]
    public long RowId { get; set; }

    ///<summary> Stock location code. </summary>
    [JsonProperty("stockLocationCode")]
    public string StockLocationCode { get; set; }

    ///<summary> Stock location ID. </summary>
    [JsonProperty("stockLocationId")]
    public string StockLocationId { get; set; }

    ///<summary> Stock location name. </summary>
    [JsonProperty("stockLocationName")]
    public string StockLocationName { get; set; }

    ///<summary> Stock point code. </summary>
    [ReadOnly]
    [JsonProperty("stockPointCode")]
    public string StockPointCode { get; private set; }

    ///<summary> Stock point ID. </summary>
    [JsonProperty("stockPointId")]
    public string StockPointId { get; set; }

    ///<summary> Stock point name. </summary>
    [ReadOnly]
    [JsonProperty("stockPointName")]
    public string StockPointName { get; private set; }
}
