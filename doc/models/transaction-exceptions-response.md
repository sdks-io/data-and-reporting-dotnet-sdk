
# Transaction Exceptions Response

## Structure

`TransactionExceptionsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardExceptions` | [`List<CardExceptions>`](../../doc/models/card-exceptions.md) | Optional | - |
| `TransactionExceptions` | [`List<TransactionExceptions>`](../../doc/models/transaction-exceptions.md) | Optional | - |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request Id |

## Example (as JSON)

```json
{
  "CardExceptions": [
    {
      "AccountId": 224,
      "AccountNumber": "AccountNumber4",
      "AccountShortName": "AccountShortName6",
      "CardId": 130,
      "CurrencyCode": "CurrencyCode2"
    }
  ],
  "TransactionExceptions": [
    {
      "SalesItemId": 113.2,
      "CardId": 104,
      "ProductId": 220,
      "TransactionGUID": "TransactionGUID2",
      "TransactionDate": "TransactionDate6"
    },
    {
      "SalesItemId": 113.2,
      "CardId": 104,
      "ProductId": 220,
      "TransactionGUID": "TransactionGUID2",
      "TransactionDate": "TransactionDate6"
    }
  ],
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  },
  "RequestId": "RequestId8"
}
```

