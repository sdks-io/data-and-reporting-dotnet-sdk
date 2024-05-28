
# Fuel Consumption Request

## Structure

`FuelConsumptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id  of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1 for Philippines<br>5 for UK |
| `ColCoCode` | `int?` | Optional | Collecting Company Code  of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `PayerId` | `int?` | Optional | Payer Id  of the selected payer.<br>Optional if PayerNumber is passed else Mandatory |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Optional if PayerId is passed else Mandatory |
| `Accounts` | [`List<Accounts>`](../../doc/models/accounts.md) | Optional | - |
| `CardGroupId` | `int?` | Optional | Card Group Id in GFN<br>Optional<br>Example: 200 |
| `CardGroupName` | `string` | Optional | Card Group Name<br>Optional<br>This input is a search criterion, if given. |
| `Cards` | [`List<FuelConsumptionCard>`](../../doc/models/fuel-consumption-card.md) | Optional | - |
| `FromDate` | `string` | Optional | Transactions from Date<br>Optional – ‘Period’ will be considered when this field is not provided. |
| `ToDate` | `string` | Optional | Transactions to Date<br>Optional<br>Format: yyyyMMdd |
| `Period` | `int?` | Optional | Transactions Period. This is ignored when FromDate is supplied on the request<br>Allowed values :<br><br>1. Last 7 Days<br>2. Last 30 Days<br>3. Last 90 Days<br>   Optional - When FromDate/ToDate and Period are not provided, ‘Last 7 Days’ value is considered as default Period. |

## Example (as JSON)

```json
{
  "ColCoId": 148,
  "ColCoCode": 162,
  "PayerId": 196,
  "PayerNumber": "PayerNumber4",
  "Accounts": [
    {
      "AccountId": 28,
      "AccountNumber": "AccountNumber0"
    },
    {
      "AccountId": 28,
      "AccountNumber": "AccountNumber0"
    },
    {
      "AccountId": 28,
      "AccountNumber": "AccountNumber0"
    }
  ]
}
```

