
# Update Odometer Response

## Structure

`UpdateOdometerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServiceReference` | `int?` | Optional | Main reference number for tracking. |
| `UpdateOdometerReferences` | [`List<UpdateOdometerReference>`](../../doc/models/update-odometer-reference.md) | Optional | - |

## Example (as JSON)

```json
{
  "ServiceReference": 140,
  "UpdateOdometerReferences": [
    {
      "SalesItemId": 206,
      "UpdateOdometerReferenceId": 242
    },
    {
      "SalesItemId": 206,
      "UpdateOdometerReferenceId": 242
    },
    {
      "SalesItemId": 206,
      "UpdateOdometerReferenceId": 242
    }
  ]
}
```

