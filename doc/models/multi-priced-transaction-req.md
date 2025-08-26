
# Multi Priced Transaction Req

## Structure

`MultiPricedTransactionReq`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`MultiPricedTransactionRequest`](../../doc/models/multi-priced-transaction-request.md) | Optional | - |
| `Page` | `int?` | Optional | Page Number (as shown to the users)<br><br>**Default**: `1` |
| `PageSize` | `int?` | Optional | Page Size – Number of records to show on a page.<br><br>**Default**: `50` |

## Example (as JSON)

```json
{
  "Page": 1,
  "PageSize": 100,
  "Filters": {
    "ColCoId": 0,
    "ColCoCode": 14,
    "Accounts": [
      {
        "PayerId": 224,
        "PayerNumber": "PayerNumber8",
        "AccountId": 28,
        "AccountNumber": "AccountNumber0"
      },
      {
        "PayerId": 224,
        "PayerNumber": "PayerNumber8",
        "AccountId": 28,
        "AccountNumber": "AccountNumber0"
      },
      {
        "PayerId": 224,
        "PayerNumber": "PayerNumber8",
        "AccountId": 28,
        "AccountNumber": "AccountNumber0"
      }
    ],
    "InvoiceStatus": "InvoiceStatus4",
    "PurchasedInCountry": "PurchasedInCountry8",
    "FromDate": "FromDate6",
    "ToDate": "ToDate4"
  }
}
```

