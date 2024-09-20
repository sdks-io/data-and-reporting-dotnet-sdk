
# Priced Trans Summary Response Transactions Summary Items

## Structure

`PricedTransSummaryResponseTransactionsSummaryItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductId` | `int?` | Optional | Product Id |
| `ProductCode` | `string` | Optional | Product Code<br>Examples:<br>10    TMF Charges<br>11    Tunnel/Bridges<br>12    Motorway toll<br>13    Ferries |
| `ProductName` | `string` | Optional | Product Name<br>Examples:<br>Unleaded - High octane<br>Unleaded - Medium octane<br>Unleaded - Low octane<br>Unleaded Environmental |
| `ProductGroupId` | `int?` | Optional | Product Group Id<br>Example:<br>1    Parent Product Group<br>2    All Fuels<br>3    Motor gasoline<br>4    2 stroke<br>5    Autogas<br>6    CNG |
| `ProductGroupName` | `string` | Optional | Product Group Name<br>Example:<br>1    Parent Product Group<br>2    All Fuels<br>3    Motor gasoline<br>4    2 stroke<br>5    Autogas<br>6    CNG<br>7    Automotive Gas Oil |
| `SiteGroupId` | `int?` | Optional | Site Group Id<br>Example: 202 |
| `SiteGroupName` | `string` | Optional | Site Group Name<br>Example: CZ 9100 ECONOMY NETWORK |
| `TotalFuelQuantity` | `int?` | Optional | Total Fuel Quantity |
| `TotalNetAmount` | `int?` | Optional | Total Net amount in invoice currency |
| `TotalGrossAmount` | `int?` | Optional | Total Gross amount in invoice currency |
| `InvoiceCurrencyCode` | `string` | Optional | ISO currency code<br>Example: GBP |
| `InvoiceCurrencySymbol` | `string` | Optional | Currency symbol of the Invoice Currency Code<br>Example: £, $ |
| `CustomerRetailValueTotalNet` | `double?` | Optional | Sum of the retail net price |
| `CustomerRetailValueTotalGross` | `double?` | Optional | Sum of the retail gross price |

## Example (as JSON)

```json
{
  "ProductId": 164,
  "ProductCode": "ProductCode2",
  "ProductName": "ProductName8",
  "ProductGroupId": 92,
  "ProductGroupName": "ProductGroupName4"
}
```

