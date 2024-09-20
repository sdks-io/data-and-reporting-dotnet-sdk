
# Invoice Management V1 Summary 401 Error Exception

## Structure

`InvoiceManagementV1Summary401ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | Unique request identifier passed from end user. This identifier helps in tracing a transaction |
| `Status` | `string` | Optional | Indicates overall status of the request. Allowed values: SUCCES, FAILED, PARTIAL_SUCCESS |
| `Errors` | [`List<ErrorDetails>`](../../doc/models/error-details.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "RequestId6",
  "Status": "Status2",
  "Errors": [
    {
      "Code": "Code4",
      "Title": "Title6",
      "Detail": "Detail6",
      "AdditionalInfo": {
        "key0": "AdditionalInfo0",
        "key1": "AdditionalInfo1",
        "key2": "AdditionalInfo2"
      }
    }
  ]
}
```

