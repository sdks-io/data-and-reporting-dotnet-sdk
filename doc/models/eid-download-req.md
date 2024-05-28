
# EID Download Req

## Structure

`EIDDownloadReq`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Required | Collecting Company Code of the selected payer.<br>Mandatory |
| `EIDList` | `List<string>` | Required | - |
| `AccountGroupCountry` | `int?` | Required | ColCo code associated with the Account Group IDs of the given EID/EDI files.<br>Mandatory |
| `AccountGroupIdList` | `List<string>` | Required | - |

## Example (as JSON)

```json
{
  "ColCoCode": 92,
  "EIDList": [
    "EIDList2",
    "EIDList3"
  ],
  "AccountGroupCountry": 8,
  "AccountGroupIdList": [
    "AccountGroupIdList5",
    "AccountGroupIdList4",
    "AccountGroupIdList3"
  ]
}
```

