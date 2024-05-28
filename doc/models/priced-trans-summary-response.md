
# Priced Trans Summary Response

## Structure

`PricedTransSummaryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionsSummary` | [`List<PricedTransSummaryResponseTransactionsSummaryItems>`](../../doc/models/priced-trans-summary-response-transactions-summary-items.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request Id |

## Example (as JSON)

```json
{
  "TransactionsSummary": [
    {
      "ProductId": 184,
      "ProductCode": "ProductCode8",
      "ProductName": "ProductName8",
      "ProductGroupId": 112,
      "ProductGroupName": "ProductGroupName0"
    },
    {
      "ProductId": 184,
      "ProductCode": "ProductCode8",
      "ProductName": "ProductName8",
      "ProductGroupId": 112,
      "ProductGroupName": "ProductGroupName0"
    },
    {
      "ProductId": 184,
      "ProductCode": "ProductCode8",
      "ProductName": "ProductName8",
      "ProductGroupId": 112,
      "ProductGroupName": "ProductGroupName0"
    }
  ],
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  },
  "RequestId": "RequestId2"
}
```

