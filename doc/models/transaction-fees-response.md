
# Transaction Fees Response

## Structure

`TransactionFeesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FeeItems` | [`List<FeeItem>`](../../doc/models/fee-item.md) | Optional | - |
| `CurrentPage` | `int?` | Optional | Current Page |
| `RowCount` | `int?` | Optional | Total row count matched for the given input criteria |
| `TotalPages` | `int?` | Optional | Calculated page count based on page size from the incoming API request and total number of rows matched for the given input criteria |
| `Error` | [`ErrorStatus`](../../doc/models/error-status.md) | Optional | - |
| `RequestId` | `string` | Optional | API Request Id |

## Example (as JSON)

```json
{
  "FeeItems": [
    {
      "FeeItemId": 18,
      "AccountId": 106,
      "AccountNumber": "AccountNumber0",
      "AccountShortName": "AccountShortName2",
      "InvoiceAccountId": 66
    },
    {
      "FeeItemId": 18,
      "AccountId": 106,
      "AccountNumber": "AccountNumber0",
      "AccountShortName": "AccountShortName2",
      "InvoiceAccountId": 66
    }
  ],
  "CurrentPage": 222,
  "RowCount": 120,
  "TotalPages": 32,
  "Error": {
    "Code": "Code4",
    "Description": "Description2"
  }
}
```

