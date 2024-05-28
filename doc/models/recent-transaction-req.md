
# Recent Transaction Req

## Structure

`RecentTransactionReq`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Required | Three character Collecting Company Code (Shell Code) of the selected payer |
| `PayerNumber` | `string` | Required | Unique Identifier for the customer at payment point.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `10` |
| `AccountNumber` | `string` | Optional | Customer account number. |
| `ProductCode` | `string` | Optional | Global product code |
| `PurchasedInCountry` | `string` | Optional | Delco country<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `CardPAN` | `string` | Optional | Card identifier number masked |
| `FromDateTime` | `string` | Optional | Start date and time of transactions |
| `ToDateTime` | `string` | Optional | End date and time of transactions. Mandatory if FromDateTime is provided. |
| `TransactionStatus` | `string` | Optional | Status of transaction. DO NOT pass the value if includeDeclines is passed |
| `FuelOnly` | `string` | Optional | When passed as ‘true’ Only returned records with Fuel transactions.(All Fuels).When passed as ‘false’ the above condition will not be checked. (Both All Fuels and Non-Fuel) |
| `ProductGroupName` | `string` | Optional | Product group name |
| `VehicleRegistrationNumber` | `string` | Optional | Vehicle registration number embossed on the card |
| `IncludeDeclines` | `bool?` | Optional | Flag to enable to get declined records |
| `CardIssuerName` | `string` | Optional | Card issuer name |
| `ColumnList` | `string` | Optional | Column list to be part of response, it can be 'All' to return all possible column. E.g. 'All'<br><br>To get specific columns pass multiple columns name separated by comma along with 'PayerNumber'. E.g. "PayerNumber,ProductCode" |

## Example (as JSON)

```json
{
  "ColCoCode": 14,
  "PayerNumber": "GB00001232",
  "AccountNumber": "GB00001233",
  "ProductCode": "22",
  "PurchasedInCountry": "GB",
  "CardPAN": "700205******890645",
  "FromDateTime": "2020-11-09 13:56:03.000",
  "ToDateTime": "2020-12-09 13:56:03.000",
  "TransactionStatus": "APPROVED",
  "FuelOnly": "False",
  "ProductGroupName": "Motor gasoline",
  "VehicleRegistrationNumber": "YG67OUM",
  "IncludeDeclines": true,
  "CardIssuerName": "Mathew",
  "ColumnList": "PayerNumber,AccountNumber,ProductName,FuelVolume,PAN"
}
```

