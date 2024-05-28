
# Update Odometer

## Structure

`UpdateOdometer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SalesItemId` | `string` | Required | Unique SalesItemId (Either Billed on Unbilled)<br>Mandatory |
| `NewOdometerValue` | `int?` | Required | NewOdometerValue that needs to be updated |

## Example (as JSON)

```json
{
  "SalesItemId": "SalesItemId2",
  "NewOdometerValue": 158
}
```

