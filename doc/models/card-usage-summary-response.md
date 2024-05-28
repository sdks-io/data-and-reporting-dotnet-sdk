
# Card Usage Summary Response

## Structure

`CardUsageSummaryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UsageSummary` | [`List<UsageSummary>`](../../doc/models/usage-summary.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request Id |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |

## Example (as JSON)

```json
{
  "UsageSummary": [
    {
      "Date": "Date0",
      "ProductId": 198,
      "ProductCode": "ProductCode6",
      "ProductName": "ProductName6",
      "IsFuelProduct": false
    },
    {
      "Date": "Date0",
      "ProductId": 198,
      "ProductCode": "ProductCode6",
      "ProductName": "ProductName6",
      "IsFuelProduct": false
    },
    {
      "Date": "Date0",
      "ProductId": 198,
      "ProductCode": "ProductCode6",
      "ProductName": "ProductName6",
      "IsFuelProduct": false
    }
  ],
  "RequestId": "RequestId2",
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  }
}
```

