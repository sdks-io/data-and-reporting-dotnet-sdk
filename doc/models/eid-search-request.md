
# EID Search Request

## Structure

`EIDSearchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`EIDSearchReq`](../../doc/models/eid-search-req.md) | Optional | - |
| `Page` | `int?` | Optional | Specify the page of results to be returned. |
| `PageSize` | `int?` | Optional | Specify the number of records to returned; Max 1000 |

## Example (as JSON)

```json
{
  "Filters": {
    "ColCoCode": 14,
    "AccountGroupCountry": 186,
    "AccountGroupId": [
      "AccountGroupId5"
    ],
    "AccountGroupName": "AccountGroupName0",
    "FromDate": "FromDate6",
    "ToDate": "ToDate4",
    "InvoiceType": "InvoiceType2",
    "InvoiceStatus": "InvoiceStatus4"
  },
  "Page": 74,
  "PageSize": 54
}
```

