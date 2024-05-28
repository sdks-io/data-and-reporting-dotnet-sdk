
# Fuel Consumption Data

## Structure

`FuelConsumptionData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account Name |
| `AccountNumber` | `string` | Optional | Account Number |
| `PayerName` | `string` | Optional | Payment customer Name |
| `PayerNumber` | `string` | Optional | Payment customer number |
| `CardNumber` | `string` | Optional | Card PAN |
| `CardGroupId` | `int?` | Optional | Card group ID |
| `CardGroupName` | `string` | Optional | Card group name |
| `DriverName` | `string` | Optional | Driver name |
| `LicenseNumber` | `string` | Optional | Vehicle registration number |
| `InitialOdometer` | `double?` | Optional | First transaction odometer reading |
| `LastOdometer` | `double?` | Optional | Last transaction odometer reading |
| `Distance` | `double?` | Optional | Distance in  KM or Miles based on Customer and Colco Settings |
| `FuelConsumption` | `double?` | Optional | Total Fuel Consumption. |
| `FuelNetAmount` | `double?` | Optional | Net Fuel Amount |
| `Discount` | `double?` | Optional | Total Discount |
| `FuelTax` | `double?` | Optional | Fuel Tax Amount |
| `FuelVolume` | `double?` | Optional | Total Fuel Volume in Litres |
| `GrossNonFuelExpenses` | `double?` | Optional | Gross Nonfuel Amount |
| `CO2Produced` | `double?` | Optional | Total Co2 produced |
| `TransactionCount` | `double?` | Optional | Total Transaction Count |

## Example (as JSON)

```json
{
  "AccountName": "AccountName0",
  "AccountNumber": "AccountNumber4",
  "PayerName": "PayerName8",
  "PayerNumber": "PayerNumber2",
  "CardNumber": "CardNumber2"
}
```

