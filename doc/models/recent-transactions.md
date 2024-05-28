
# Recent Transactions

## Structure

`RecentTransactions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `int?` | Optional | ColCoCode |
| `PayerNumber` | `string` | Optional | PayerNumber |
| `AccountNumber` | `string` | Optional | Account Number |
| `CardIssueNumber` | `string` | Optional | Card Issue Number |
| `CollectingCompanyCurrencyCode` | `string` | Optional | Collecting Company Currency IsoCode |
| `CustDataCustomerEntered` | `string` | Optional | Customer entered data for reference. |
| `CustDataDriverId` | `string` | Optional | Customer Data DriverId |
| `CustDataFleetDescription` | `string` | Optional | Cust Data Fleet Description |
| `FleetIdInput` | `string` | Optional | Fleet Id Input |
| `Amount` | `double?` | Optional | Amount |
| `EuroshellSiteNumber` | `string` | Optional | EuroshellSiteNumber |
| `IncomingProductCode` | `string` | Optional | IncomingProductCode |
| `ProductCode` | `string` | Optional | ProductCode |
| `ProductName` | `string` | Optional | ProductName |
| `SiteCode` | `int?` | Optional | SiteCode |
| `HostingCollectingCompanyName` | `string` | Optional | HostingCollectingCompanyName |
| `HostingCollectingCompanyNumber` | `string` | Optional | HostingCollectingCompanyNumber |
| `IccdataTranTypeCode` | `string` | Optional | Transaction type code |
| `TransactionType` | `string` | Optional | Transaction type description. |
| `Latitude` | `string` | Optional | Latitude of the Coordinate 3.11573 |
| `Longitude` | `string` | Optional | Longitude of the Coordinate |
| `MerchantCategory` | `string` | Optional | Merchant category |
| `MerchantCategoryDescription` | `string` | Optional | Merchant category description |
| `PurchasedInCountry` | `string` | Optional | Purchased in country |
| `MerchantId` | `string` | Optional | Merchant Id |
| `SiteName` | `string` | Optional | Site name |
| `Network` | `string` | Optional | Network |
| `DelcoCode` | `string` | Optional | Three character DelcoCode |
| `OdometerInput` | `string` | Optional | Odometer input |
| `OdometerReadingKm` | `string` | Optional | Odometer reading in Kms |
| `OdometerReadingMiles` | `string` | Optional | Odometer reading in miles |
| `CardPAN` | `string` | Optional | Masked Card PAN |
| `PINIndicator` | `string` | Optional | PIN indicator |
| `POIReceiptNumber` | `string` | Optional | POIReceiptNumber |
| `ProductsCodeAdditional` | `string` | Optional | Additinal Products Code |
| `ProductsTaxCode` | `string` | Optional | Products tax code |
| `FuelVolume` | `double?` | Optional | Fuel volume |
| `SfgwCardDateOfExpiry` | `string` | Optional | SfgwCard expiry date |
| `SiteCurrencyISOCode` | `string` | Optional | Three character Site currency ISO code |
| `CardId` | `string` | Optional | Card ID |
| `TransactionDate` | `DateTime?` | Optional | ISO8601-compliant UTC datetime of the last update of the EVSE |
| `TransactionDateTime` | `string` | Optional | ISO8601-compliant UTC datetime of the last update of the EVSE |
| `TransactionId` | `string` | Optional | TransactionId |
| `TransactionStatus` | `string` | Optional | Type of the connector in the EVSE unit. |
| `UnitOfMeasure` | `string` | Optional | Unit of measure |
| `VehicleRegistrationNumber` | `string` | Optional | VehicleRegistrationNumber |
| `NetworkDelcoName` | `string` | Optional | Network Delco name |
| `ProductGroupName` | `string` | Optional | ProductGroupName |
| `FuelProduct` | `string` | Optional | FuelProduct |
| `AccountCustomerName` | `string` | Optional | AccountCustomerName |
| `PayerName` | `string` | Optional | PayerName |
| `TransactionTime` | `string` | Optional | ISO8601-compliant UTC datetime of the last update of the EVSE |
| `TransactionCurrency` | `string` | Optional | TransactionCurrencySymbol |
| `UnitPrice` | `double?` | Optional | UnitPrice |
| `AuthorisedFlag` | `string` | Optional | AuthorisedFlag |
| `TransactionTimeGMT` | `string` | Optional | TransactionTimeGMT update of the EVSE |
| `ReasonCode` | `string` | Optional | ReasonCode |
| `IssuerActionCode` | `string` | Optional | IssuerActionCode |
| `IssuerActionCodeDescription` | `string` | Optional | IssuerActionCodeDescription. |
| `DeclinedReason` | `string` | Optional | DeclinedReason. |
| `CardStatusReasonDescription` | `string` | Optional | CardStatusReasonDescription. |
| `TransactionCountry` | `string` | Optional | TransactionCountry |
| `IssuingCollectingCompanyName` | `string` | Optional | IssuingCollectingCompanyName. |
| `CardIssuerName` | `string` | Optional | CardIssuerName. |
| `DriverName` | `string` | Optional | DriverName. |
| `BearerDescription` | `string` | Optional | BearerDescription. |
| `CardCategoryDescription` | `string` | Optional | CardCategoryDescription. |
| `CardTypeDescription` | `string` | Optional | CardTypeDescription. |
| `CardTokenTypeDescription` | `string` | Optional | CardTokenTypeDescription. |
| `EmbossType` | `string` | Optional | EmbossType. |
| `EVPrintedNumber` | `string` | Optional | The EVPrintedNumber which can be found on the Shell EV Card |
| `IsRFID` | `bool?` | Optional | Whether the card type is enabled for RFID (Radio Frequency Identification) |

## Example (as JSON)

```json
{
  "ColCoCode": 84,
  "PayerNumber": "MY00200653",
  "AccountNumber": "MY00200653",
  "CardIssueNumber": "1",
  "CollectingCompanyCurrencyCode": "MYR",
  "CustDataCustomerEntered": "PartnerId",
  "CustDataDriverId": "D123",
  "CustDataFleetDescription": "Fleet-Truck",
  "FleetIdInput": "AS2344",
  "Amount": 62.47,
  "EuroshellSiteNumber": "1231",
  "IncomingProductCode": "10",
  "ProductCode": "23",
  "ProductName": "Unleaded - Low octane",
  "SiteCode": 3350,
  "HostingCollectingCompanyName": "Shell Malaysia Trading Sdn Bhd",
  "HostingCollectingCompanyNumber": "84",
  "IccdataTranTypeCode": "1",
  "TransactionType": "Transaction Type description",
  "Latitude": "52.143814",
  "Longitude": "101.72869",
  "MerchantCategory": "5542",
  "MerchantCategoryDescription": "Description",
  "PurchasedInCountry": "MY",
  "MerchantId": "MY1737000000000",
  "SiteName": "ShellPT3895 BATU 4    KUALA LUMPUR MY",
  "Network": "458",
  "DelcoCode": "084",
  "OdometerInput": "201620",
  "OdometerReadingKm": "201620",
  "OdometerReadingMiles": "201620",
  "CardPAN": "700214*******780061",
  "PINIndicator": "Y",
  "POIReceiptNumber": "417662",
  "ProductsCodeAdditional": "Additional Code",
  "ProductsTaxCode": "0",
  "FuelVolume": 34.15,
  "SfgwCardDateOfExpiry": "2024-12",
  "SiteCurrencyISOCode": "MYR",
  "CardId": "330743",
  "TransactionDate": "2021-11-11",
  "TransactionDateTime": "2021-11-11 16:32:09.000",
  "TransactionId": "864220307",
  "TransactionStatus": "Approved",
  "UnitOfMeasure": "L",
  "VehicleRegistrationNumber": "WD33637",
  "NetworkDelcoName": "Shell Malaysia Trading Sdn Bhd",
  "ProductGroupName": "Motor gasoline",
  "FuelProduct": "All Fuels",
  "AccountCustomerName": "WCT BERHAD",
  "PayerName": "WCT BERHAD",
  "TransactionTime": "2021-11-11",
  "TransactionCurrency": "RM",
  "UnitPrice": 0.0205007320644217,
  "AuthorisedFlag": "Y",
  "TransactionTimeGMT": "08:41:02",
  "ReasonCode": "10",
  "IssuerActionCode": "2",
  "IssuerActionCodeDescription": "Approved, partial",
  "DeclinedReason": "partial",
  "CardStatusReasonDescription": "Approved, partial",
  "TransactionCountry": "458",
  "IssuingCollectingCompanyName": "Partner Name",
  "CardIssuerName": "John",
  "DriverName": "PAK PAK",
  "BearerDescription": "Description",
  "CardCategoryDescription": "Driver Card",
  "CardTypeDescription": "SHELL FLEET- HONG KONG 7002821",
  "CardTokenTypeDescription": "HK FLE NAT SIN R1 - CHIP",
  "EmbossType": "Driver",
  "EVPrintedNumber": "NL-TNM-C00122045-K",
  "IsRFID": false
}
```

