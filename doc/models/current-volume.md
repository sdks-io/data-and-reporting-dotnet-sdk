
# Current Volume

## Structure

`CurrentVolume`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FeeRuleId` | `int?` | Optional | Bonus or association bonus configuration identifier that is associated to the payer |
| `FeeRuleDescription` | `string` | Optional | Bonus or association bonus configuration description that is associated to the payer. |
| `Month` | `int?` | Optional | Consumption(Volume) of the month. |
| `Year` | `string` | Optional | Consumption (Volume) of the year. |
| `TotalVolume` | `double?` | Optional | Total volume consumption for the month/year above. |

## Example (as JSON)

```json
{
  "FeeRuleId": 74,
  "FeeRuleDescription": "FeeRuleDescription8",
  "Month": 138,
  "Year": "Year2",
  "TotalVolume": 115.68
}
```

