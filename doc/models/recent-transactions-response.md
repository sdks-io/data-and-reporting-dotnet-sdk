
# Recent Transactions Response

## Structure

`RecentTransactionsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | RequestID is unique identifier value that is attached to requests and messages that allow reference to a particular transaction or event chain. |
| `Status` | `string` | Optional | status of the API call |
| `Page` | `int?` | Optional | CurrentPage |
| `RowCount` | `int?` | Optional | RowCount |
| `TotalPages` | `int?` | Optional | TotalPages |
| `Data` | [`List<RecentTransactions>`](../../doc/models/recent-transactions.md) | Optional | API Response |

## Example (as JSON)

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "SUCCESS",
  "Page": 1,
  "RowCount": 2,
  "TotalPages": 1
}
```

