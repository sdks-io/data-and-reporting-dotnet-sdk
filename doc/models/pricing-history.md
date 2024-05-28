
# Pricing History

## Structure

`PricingHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FromDate` | `string` | Optional | Pricing History Period Start date and should be the first date of the month.<br>Format: YYYYMMDD |
| `ToDate` | `string` | Optional | Pricing History Period end date and should be the last date of the period month.<br>Format: YYYYMMDD |
| `FeesRuleID` | `int?` | Optional | Pricing History Period Fees Rule ID that is associated to the period of that associated payer.  <br>Example: 8101 |
| `FeesRuleDescription` | `string` | Optional | Pricing History Period Fees Rule Description that is associated to the period of that associated payer. |
| `TotalVolume` | `double?` | Optional | Total Quantity for the Pricing History Period that is associated to that payer. |

## Example (as JSON)

```json
{
  "FromDate": "FromDate0",
  "ToDate": "ToDate0",
  "FeesRuleID": 44,
  "FeesRuleDescription": "FeesRuleDescription4",
  "TotalVolume": 153.82
}
```

