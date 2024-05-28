
# EID Document

## Structure

`EIDDocument`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DocumentId` | `int?` | Optional | Technical identifier for the EID file. Should not be stored in database as it is not guaranteed to stay unchanged over time. |
| `AccountGroupId` | `string` | Optional | Account Group Id |
| `AccountGroupName` | `string` | Optional | Account group name |
| `DocumentType` | `string` | Optional | Document type.<br>Possible values:<br>•	NAT (National)<br>•	INT (International) |
| `DocumentFormat` | `string` | Optional | Document format (CHORUS, DIFI etc.) |
| `DocumentDate` | `string` | Optional | Document date.<br>Example: 20170101 |
| `NumberOfInvoices` | `int?` | Optional | Number of invoices |
| `FileSize` | `int?` | Optional | Document size |
| `DocumentStatus` | `string` | Optional | Document status.<br>Possible values:<br>•	NEW<br>•	VIEWED<br>•	DOWNLOADED<br>•	RESTORED |
| `DocumentName` | `string` | Optional | Document file name. |

## Example (as JSON)

```json
{
  "DocumentId": 250,
  "AccountGroupId": "AccountGroupId2",
  "AccountGroupName": "AccountGroupName0",
  "DocumentType": "DocumentType8",
  "DocumentFormat": "DocumentFormat4"
}
```

