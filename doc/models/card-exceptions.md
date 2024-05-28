
# Card Exceptions

## Structure

`CardExceptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Id |
| `AccountNumber` | `string` | Optional | Account Number |
| `AccountShortName` | `string` | Optional | Account Short Name |
| `CardId` | `int?` | Optional | Unique Card Id |
| `CurrencyCode` | `string` | Optional | ISO currency code |
| `CurrencySymbol` | `string` | Optional | Currency symbol of the Invoice Currency Code |
| `Day` | `int?` | Optional | Summary Day: Populated when the Period is passed as ‘Day’. |
| `DriverName` | `string` | Optional | Driver name |
| `Month` | `int?` | Optional | Summary Month: Populated when the Value of Period is Passed as ‘Month’. |
| `PAN` | `string` | Optional | Card PAN |
| `PayerId` | `int?` | Optional | Payment customer id of the customer |
| `PayerNumber` | `string` | Optional | Payment customer number |
| `PayerShortName` | `string` | Optional | Payer Short Name |
| `TotalAmount` | `double?` | Optional | Total Amount (In Customer Currency) of Transactions met with the given exceptions criteria. |
| `TotalQuantity` | `int?` | Optional | Total Quantity of Transactions met with the given exceptions criteria. |
| `TotalSalesItems` | `int?` | Optional | Total number of Sales Items met with the given exception criteria. |
| `TotalTransactions` | `int?` | Optional | Total number of Transactions met with the given exception criteria. |
| `VRN` | `string` | Optional | Vehicle Registration Number |
| `Week` | `int?` | Optional | Summary Week Number with in the given date range. Populated when the Value of Period is Passed as ‘Week’. |
| `Year` | `int?` | Optional | Summary Year: Populated when the Value of Period is Passed as ‘Month’. |

## Example (as JSON)

```json
{
  "AccountId": 224,
  "AccountNumber": "AccountNumber4",
  "AccountShortName": "AccountShortName6",
  "CardId": 130,
  "CurrencyCode": "CurrencyCode2"
}
```

