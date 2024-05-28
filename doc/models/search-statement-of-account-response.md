
# Search Statement of Account Response

## Structure

`SearchStatementOfAccountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the req |
| `Status` | `string` | Optional | Indicates overall status of the request |
| `Data` | [`List<SearchStatementOfAccount>`](../../doc/models/search-statement-of-account.md) | Optional | - |
| `Page` | `int?` | Optional | Current page |
| `TotalRecords` | `int?` | Optional | Total Number of records in response |
| `TotalPages` | `int?` | Optional | Total number of pages available for the requested data |
| `PageSize` | `int?` | Optional | Number of records returned in the response |

## Example (as JSON)

```json
{
  "RequestId": "RequestId6",
  "Status": "Status2",
  "Data": [
    {
      "StatementOfAccountId": 152,
      "SoAReferenceNumber": "SoAReferenceNumber6",
      "StatementDate": "StatementDate2",
      "PayerId": 2,
      "PayerNumber": "PayerNumber6"
    },
    {
      "StatementOfAccountId": 152,
      "SoAReferenceNumber": "SoAReferenceNumber6",
      "StatementDate": "StatementDate2",
      "PayerId": 2,
      "PayerNumber": "PayerNumber6"
    },
    {
      "StatementOfAccountId": 152,
      "SoAReferenceNumber": "SoAReferenceNumber6",
      "StatementDate": "StatementDate2",
      "PayerId": 2,
      "PayerNumber": "PayerNumber6"
    }
  ],
  "Page": 214,
  "TotalRecords": 118
}
```

