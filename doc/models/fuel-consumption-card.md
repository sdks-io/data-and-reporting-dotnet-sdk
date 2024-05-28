
# Fuel Consumption Card

## Structure

`FuelConsumptionCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardId` | `int?` | Optional | Card Id<br>Optional, when PAN is provided else mandatory. |
| `PAN` | `string` | Optional | Full Card PAN<br>Optional, when CardId is provided else mandatory. |
| `ExpiryDate` | `string` | Optional | Card Expiry Date<br>Format: yyyyMMdd |

## Example (as JSON)

```json
{
  "CardId": 54,
  "PAN": "PAN4",
  "ExpiryDate": "ExpiryDate4"
}
```

