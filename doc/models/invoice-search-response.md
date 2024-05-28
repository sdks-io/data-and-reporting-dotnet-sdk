
# Invoice Search Response

## Structure

`InvoiceSearchResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | API Request Id |
| `Status` | `string` | Optional | Indicates overall status of the request. Allowed values: SUCCES, FAILED |
| `Data` | [`List<InvoiceSearchDetails>`](../../doc/models/invoice-search-details.md) | Optional | - |
| `Page` | `int?` | Optional | Specifies the returned page of the results |
| `PageSize` | `int?` | Optional | Specifies the number of records to be returned which could be less than the PageSize in the request |
| `TotalRecords` | `int?` | Optional | Specifies the total records available in the result |
| `TotalPages` | `int?` | Optional | Specifies the total pages available in the result |

## Example (as JSON)

```json
{
  "RequestId": "RequestId0",
  "Status": "Status6",
  "Data": [
    {
      "AccountFullName": "AccountFullName6",
      "AccountId": 62,
      "AccountNumber": "AccountNumber8",
      "AccountShortName": "AccountShortName0",
      "ColCoId": 210
    },
    {
      "AccountFullName": "AccountFullName6",
      "AccountId": 62,
      "AccountNumber": "AccountNumber8",
      "AccountShortName": "AccountShortName0",
      "ColCoId": 210
    },
    {
      "AccountFullName": "AccountFullName6",
      "AccountId": 62,
      "AccountNumber": "AccountNumber8",
      "AccountShortName": "AccountShortName0",
      "ColCoId": 210
    }
  ],
  "Page": 226,
  "PageSize": 206
}
```

