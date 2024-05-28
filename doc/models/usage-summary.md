
# Usage Summary

## Structure

`UsageSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Date` | `string` | Optional | Transaction date.<br>The records will be sorted by this field in ascending order.<br><br>Format: yyyyMMdd |
| `ProductId` | `int?` | Optional | Product Id |
| `ProductCode` | `string` | Optional | Client Product code |
| `ProductName` | `string` | Optional | Product name in English |
| `IsFuelProduct` | `bool?` | Optional | Whether the product is fuel or non-fuel |
| `SiteGroupId` | `int?` | Optional | Site Group Id |
| `SiteGroupName` | `string` | Optional | Site Group Name |
| `TotalVolume` | `double?` | Optional | Total Volume |
| `TotalGross` | `double?` | Optional | Total Gross in Customer Currency |
| `TotalNet` | `double?` | Optional | Total Net in Customer Currency |
| `CurrencyCode` | `string` | Optional | Customer Currency Code |
| `CurrencySymbol` | `string` | Optional | Customer Currency Symbol |
| `ProductGroupID` | `int?` | Optional | Product group ID |
| `ProductGroupName` | `string` | Optional | Product group Name |

## Example (as JSON)

```json
{
  "Date": "Date0",
  "ProductId": 198,
  "ProductCode": "ProductCode6",
  "ProductName": "ProductName6",
  "IsFuelProduct": false
}
```

