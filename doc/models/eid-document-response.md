
# EID Document Response

## Structure

`EIDDocumentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `Status` | `string` | Optional | Indicates overall status of the request. Allowed values: SUCCESS, FAILED |
| `Data` | [`List<EIDDocument>`](../../doc/models/eid-document.md) | Optional | - |
| `PageSize` | `int?` | Optional | Number of records returned in the response |
| `Page` | `int?` | Optional | Current page |
| `TotalPages` | `int?` | Optional | Total number of pages available for the requested data |
| `TotalRecords` | `int?` | Optional | Total number of elements corresponding to the request |
| `IsFirstPage` | `bool?` | Optional | True if it is the first page, false otherwise |
| `IsLastPage` | `bool?` | Optional | True if it is the last page, false, otherwise. |

## Example (as JSON)

```json
{
  "RequestId": "RequestId8",
  "Status": "Status4",
  "Data": [
    {
      "DocumentId": 28,
      "AccountGroupId": "AccountGroupId2",
      "AccountGroupName": "AccountGroupName6",
      "DocumentType": "DocumentType6",
      "DocumentFormat": "DocumentFormat0"
    }
  ],
  "PageSize": 188,
  "Page": 208
}
```

