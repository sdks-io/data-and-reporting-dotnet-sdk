
# Search Statement of Account Request

## Structure

`SearchStatementOfAccountRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`SearchSOAReq`](../../doc/models/search-soa-req.md) | Optional | - |
| `Page` | `int?` | Optional | Page number |
| `PageSize` | `int?` | Optional | Number of records in page |

## Example (as JSON)

```json
{
  "Filters": {
    "ColCoCode": 14,
    "PayerNumber": "PayerNumber0",
    "InvoiceNumber": "InvoiceNumber0",
    "FromDate": "FromDate6",
    "ToDate": "ToDate4"
  },
  "Page": 114,
  "PageSize": 94
}
```

