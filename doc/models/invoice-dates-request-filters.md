
# Invoice Dates Request Filters

## Structure

`InvoiceDatesRequestFilters`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Optional | Collecting Company Code of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86-Philippines<br>5-UK |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1-Philippines<br>5-UK |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Optional if PayerNumber is passed else Mandatory |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Optional if PayerId is passed else Mandatory |
| `FromDate` | `string` | Optional | Invoice date searched from this date.<br>Optional.<br>This input is a search criterion, if given.<br>Date format: yyyyMMdd |
| `ToDate` | `string` | Optional | Invoice date searched until this date.<br>Optional.<br>This input is a search criterion, if given.<br>Date format: yyyyMMdd |
| `Accounts` | [`List<Accounts>`](../../doc/models/accounts.md) | Optional | - |

## Example (as JSON)

```json
{
  "ColCoCode": 184,
  "ColCoId": 170,
  "PayerId": 218,
  "PayerNumber": "PayerNumber4",
  "FromDate": "FromDate0"
}
```

