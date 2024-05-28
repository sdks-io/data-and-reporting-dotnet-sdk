
# Pricing Current Volume

## Structure

`PricingCurrentVolume`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FeeRuleId` | `int?` | Optional | Bonus or association bonus configuration identifier  that is associated to the payer. |
| `FeeRuleDescription` | `string` | Optional | Bonus or association bonus configuration description that is associated to the payer |
| `PriceRuleID` | `int?` | Optional | Pricing current period Pricing Price Rule ID that is associated to the payer. |
| `PriceRuleDescription` | `string` | Optional | Pricing current period pricing rule description that is associated to the payer |
| `TotalVolume` | `double?` | Optional | Total volume consumption for the current period. |
| `NextFeeCreationDate` | `string` | Optional | Next Fee Rule Creation Date for that is associated to the payer.<br>Format: YYYYMMDD |

## Example (as JSON)

```json
{
  "FeeRuleId": 134,
  "FeeRuleDescription": "FeeRuleDescription4",
  "PriceRuleID": 96,
  "PriceRuleDescription": "PriceRuleDescription6",
  "TotalVolume": 64.96
}
```

