
# EID Search Req

## Structure

`EIDSearchReq`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Required | Collecting Company Code of the selected payer.<br>Mandatory |
| `AccountGroupCountry` | `int?` | Required | Country code (colco code) of the account group.<br>Mandatory |
| `AccountGroupId` | `List<string>` | Required | List of IDs of the account groups that user has access to.<br>Mandatory |
| `AccountGroupName` | `string` | Optional | Account group name<br>Optional.<br>This input is a search criterion, if given. |
| `FromDate` | `string` | Optional | EID date searched from this date.<br>Optional. |
| `ToDate` | `string` | Optional | Invoice date searched until this date.<br>Optional. |
| `InvoiceType` | `string` | Optional | Invoice type.<br>Optional.<br>Possible values:<br>•	NAT (National)<br>•	INT (International) |
| `InvoiceStatus` | `string` | Optional | Status of the document.<br>Optional.<br>Possible values:<br>•	NEW<br>•	VIEWED<br>•	DOWNLOADED<br>•	RESTORED |
| `SortBy` | `List<string>` | Optional | Sort option –<br>•    InvoiceNumber ASC<br>•    InvoiceDate ASC<br>•    InvoiceNumber DESC<br>•    InvoiceDate DESC<br>Optional |

## Example (as JSON)

```json
{
  "ColCoCode": 222,
  "AccountGroupCountry": 138,
  "AccountGroupId": [
    "AccountGroupId7",
    "AccountGroupId8"
  ],
  "AccountGroupName": "AccountGroupName8",
  "FromDate": "FromDate4",
  "ToDate": "ToDate4",
  "InvoiceType": "InvoiceType6",
  "InvoiceStatus": "InvoiceStatus2"
}
```

