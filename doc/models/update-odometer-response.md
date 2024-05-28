
# Update Odometer Response

## Structure

`UpdateOdometerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServiceReference` | `int?` | Optional | Main reference number for tracking. |
| `UpdateOdometerReferences` | [`List<UpdateOdometerReference>`](../../doc/models/update-odometer-reference.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request Id |

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
  ],
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  },
  "RequestId": "RequestId4"
}
```

