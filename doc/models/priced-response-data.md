
# Priced Response Data

## Structure

`PricedResponseData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Name of the account<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `36` |
| `AccountId` | `int?` | Optional | Account Id (i.e. Customer Id of the Sub Account in GFN) of the selected account. |
| `AccountNumber` | `string` | Optional | AccountNumber of the selected account. |
| `AccountShortName` | `string` | Optional | Nick name of the account<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `25` |
| `Additional1` | `string` | Optional | Addtional SerialId or endpoint Id<br>**Constraints**: *Minimum Length*: `14`, *Maximum Length*: `20` |
| `Additional2` | `string` | Optional | Addtional SerialId or endpoint Id<br>**Constraints**: *Minimum Length*: `14`, *Maximum Length*: `20` |
| `Additional3` | `string` | Optional | Addtional SerialId or endpoint Id<br>**Constraints**: *Minimum Length*: `14`, *Maximum Length*: `20` |
| `Additional4` | `string` | Optional | Addtional SerialId or endpoint Id<br>**Constraints**: *Minimum Length*: `14`, *Maximum Length*: `20` |
| `AllowClearing` | `string` | Optional | Allow clearings<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `25` |
| `AuthorisationCode` | `int?` | Optional | Autorization code<br>**Constraints**: `>= 1`, `<= 999999` |
| `TransactionStatus` | `string` | Optional | Status of the transaction<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `DriverName` | `string` | Optional | Driver Name of Card record<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `25` |
| `CardExpiryPeriod` | `int?` | Optional | Expiry period of the card<br>**Constraints**: `>= 1`, `<= 9999` |
| `CardExpiry` | `string` | Optional | Card Expiry Date |
| `CardGroupId` | `int?` | Optional | Card Group Code<br>**Constraints**: `>= 1`, `<= 99999` |
| `CardGroupName` | `string` | Optional | Group nmae of the card |
| `IssuerCode` | `int?` | Optional | Issuer code<br>**Constraints**: `>= 1`, `<= 9999` |
| `CardPAN` | `string` | Optional | Full Card PAN<br>**Constraints**: *Minimum Length*: `19`, *Maximum Length*: `19` |
| `ReleaseCode` | `int?` | Optional | Release code<br>**Constraints**: `>= 1`, `<= 10` |
| `CardSequenceNumber` | `int?` | Optional | Sequesnce number of the card<br>**Constraints**: `>= 1`, `<= 999` |
| `CardType` | `string` | Optional | Type of card<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `ColCoCode` | `string` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `UnitDiscountInvoiceCurrency` | `double?` | Optional | Unit discount Invoice currency |
| `ColCoExchangeRate` | `double?` | Optional | Colco exchange rate |
| `InvoiceCurrencySymbol` | `string` | Optional | Currency symbol on which the invoice was raised<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `CorrectionFlag` | `bool?` | Optional | Is there any correction |
| `CRMNumber` | `double?` | Optional | CRM number<br>**Constraints**: `>= 10`, `<= 10` |
| `CustomerCountry` | `string` | Optional | Customer country<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `30` |
| `CustomerCurrencyCode` | `string` | Optional | Curreny which customer uses to transact.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `CustomerCurrencySymbol` | `string` | Optional | Custome currency symbol<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `RebateonNetAmountInCustomerCurrency` | `double?` | Optional | Rebate on net amount in customer currency |
| `EffectiveDiscountInCustomerCurrency` | `double?` | Optional | Effective discount in customers currency |
| `EffectiveUnitDiscountInCustomerCurrency` | `double?` | Optional | effectiive unit discount in customers currency |
| `UnitPriceInInvoiceCurrency` | `double?` | Optional | Unitpricing in invoice currency |
| `InvoiceTax` | `double?` | Optional | Invoice tax |
| `InvoiceGrossAmount` | `double?` | Optional | Invoice amount befor tax |
| `InvoiceNetAmount` | `double?` | Optional | Invoice amount after tax |
| `VATonNetAmountInCustomerCurrency` | `double?` | Optional | Vat on net amount in customer currency |
| `CustomerRetailPriceUnitGross` | `double?` | Optional | Customer retail unit price before tax |
| `CustomerRetailValueTotalGross` | `double?` | Optional | Total Customer retail value before tax |
| `CustomerRetailValueTotalNet` | `double?` | Optional | Total customer retail value after tax |
| `TransactionTypeDescription` | `double?` | Optional | Trasaction type description |
| `RebateonNetAmountInTransactionCurrency` | `double?` | Optional | Rebate give to net amountin transaction currency that is used |
| `EffectiveDiscountInTrxCurrency` | `double?` | Optional | Currency used to giveEffective discount on transactions |
| `DelCoToColCoExchangeRate` | `int?` | Optional | Exchange rate between Delco and Colco |
| `Cards` | `List<int>` | Optional | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `500` |
| `UnitDiscountTransactionCurrency` | `double?` | Optional | Currency used forto provide unit Transaction discount |
| `TransactionGrossAmount` | `double?` | Optional | Transactional amount before tax |
| `TransactionNetAmount` | `double?` | Optional | Transaction net amount after tax |
| `TransactionTax` | `double?` | Optional | Transaction tax |
| `VATonNetAmount` | `double?` | Optional | Transactinal tax rates |
| `DelcoListPriceUnitNet` | `double?` | Optional | Priv |
| `DelcoRetailPriceUnitGross` | `double?` | Optional | Delco retail price per unit before tax |
| `UnitPriceInTransactionCurrency` | `double?` | Optional | Delco retail price per unit after tax |
| `DelcoRetailPriceUnitNet` | `double?` | Optional | Delco retail price per unit |
| `DelcoRetailValueTotalGross` | `double?` | Optional | Delco retail price before tax |
| `DelcoRetailValueTotalNet` | `double?` | Optional | Delco per unit price after tax |
| `TransactionCurrencySymbol` | `string` | Optional | Currency used for transaction. |
| `DiscountType` | `string` | Optional | Type of discount available |
| `DisputeStatus` | `bool?` | Optional | Is there any dispute status?True or False<br>**Default**: `false` |
| `IsShellSite` | `bool?` | Optional | Is it a shell sites?True or False<br>**Default**: `false` |
| `FleetIdInput` | `string` | Optional | Fleet identifier |
| `IncomingProductCode` | `int?` | Optional | In coming product code |
| `PostingDate` | `string` | Optional | Date of Posting |
| `PostingTime` | `string` | Optional | Time whern posting happened |
| `ProductCode` | `int?` | Optional | Product Code - 21 Unleaded - High octane,22 Unleaded - Medium octane,23 Unleaded - Low octane,24 Unleaded Environmental |
| `ProductName` | `string` | Optional | Name of the product<br>**Constraints**: *Minimum Length*: `8`, *Maximum Length*: `30` |
| `ProductGroupId` | `int?` | Optional | Id of the product to which group it belongs |
| `IncomingCurrencyCode` | `string` | Optional | In coming currecncy code<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `IncomingSiteDescription` | `string` | Optional | In coming Site description |
| `Location` | `string` | Optional | Location of the Shell site<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `SiteName` | `string` | Optional | Shell site name<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `SiteCode` | `int?` | Optional | Shell site code |
| `IncomingSiteNumber` | `int?` | Optional | In coming site number |
| `InvoiceCurrencyCode` | `string` | Optional | Currency code on which the invoice is raised<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `InvoiceDate` | `string` | Optional | Date on which the invoice was raised |
| `InvoiceNumber` | `double?` | Optional | Invoice number |
| `FuelProduct` | `bool?` | Optional | Is it a fuel product? True or False |
| `VATApplicable` | `string` | Optional | Is VAT applicable?Y or N<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `PayerName` | `string` | Optional | Name of the payer<br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `50` |
| `PayerNumber` | `string` | Optional | Payer account number<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `15` |
| `ParentCustomerNumber` | `string` | Optional | Parent account number of the payer<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `15` |
| `PayerGroup` | `string` | Optional | The group which the payer belongs to |
| `PayerGroupName` | `string` | Optional | Name of the group to which the payer belongs to.<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `CheckDigit` | `int?` | Optional | Check digit |
| `NetInvoiceIndicator` | `string` | Optional | After tax net invoice number |
| `DelcoCode` | `int?` | Optional | Delco code |
| `NetworkCode` | `int?` | Optional | Network  code of the payer<br>**Constraints**: `>= 3`, `<= 3` |
| `PurchasedInCountry` | `string` | Optional | Country of purchase<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `SiteCountry` | `string` | Optional | Country where the site exists<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `VATCountry` | `string` | Optional | Country where VAT is applicable<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `DelcoName` | `string` | Optional | Name of the delivery company<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `Network` | `string` | Optional | Network of the Delivery company<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `25` |
| `OdometerInput` | `int?` | Optional | Odometet input |
| `OriginalSalesItemId` | `string` | Optional | Original item identifier for sales<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `25` |
| `FleetIDDescription` | `string` | Optional | Fleet identifier description |
| `ParentCustomerId` | `int?` | Optional | Identifier of parent customer |
| `PINIndicator` | `string` | Optional | PIN indicator |
| `ProductGroupName` | `string` | Optional | Name og the group the product belongs to |
| `PurchasedInCountryCode` | `string` | Optional | The countroy code where the purchase was made |
| `Quantity` | `double?` | Optional | Quantity of the product |
| `RebateRate` | `double?` | Optional | Rebate rate if any |
| `ReceiptNumber` | `int?` | Optional | Reciept number |
| `RefundFlag` | [`PricedTransactionRespV2RefundFlagEnum?`](../../doc/models/priced-transaction-resp-v2-refund-flag-enum.md) | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `SiteGroupId` | `int?` | Optional | Group identifier for the site |
| `SiteGroupName` | `string` | Optional | Name of the Site group |
| `Latitude` | `double?` | Optional | Latitude of the site |
| `Longitude` | `double?` | Optional | Longitude of the site |
| `DelCoExchangeRate` | `double?` | Optional | Delivery company exchange rate |
| `EuroRebateAmount` | `double?` | Optional | Rebate amount in Euros |
| `NetEuroAmount` | `double?` | Optional | Net amount in Euros |
| `EuroVATAmount` | `double?` | Optional | Vat amount in Euros |
| `ParentCustomerName` | `string` | Optional | Customers parent name<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `IsInvoiced` | `bool?` | Optional | Is invoice raised<br>**Default**: `false` |
| `TransactionCurrencyCode` | `string` | Optional | Transaction currency code |
| `CreditDebitCode` | `string` | Optional | Is it Credit or debit C for credit D for Debit |
| `TransactionDate` | `string` | Optional | Date of transaction |
| `TransactionTime` | `string` | Optional | Time of transaction |
| `TransactionItemId` | `string` | Optional | Identifier of the Iem in transaction |
| `TrnIdentifier` | `string` | Optional | Transaction identifier |
| `Type` | `string` | Optional | Transaction type for Delco |
| `TransactionLine` | `int?` | Optional | - |
| `TransactionType` | `string` | Optional | Transaction type Colco |
| `UTCOffset` | `string` | Optional | Leaving country |
| `VATCategory` | `string` | Optional | To which category and counry does the  VAT come under |
| `VATRate` | `double?` | Optional | VAT rate |
| `VehicleRegistration` | `string` | Optional | Vehicle registration number |
| `IsCancelled` | `string` | Optional | Check if the pruchase is cancelled<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `ColCoGrossAmount` | `double?` | Optional | Gross amount from Colco |
| `ColCoNetAmount` | `double?` | Optional | Net amount from Colco |
| `ColCoVATAmount` | `double?` | Optional | Colco VAT amount |
| `OriginalCurrencySymbol` | `string` | Optional | Original currency code<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `OriginalCurrencyCode` | `string` | Optional | Original currency code<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `OriginalVATAmount` | `double?` | Optional | Original VAT amount |
| `EmbossText` | `string` | Optional | Comapany name embosses in text<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `OriginalExchangeRate` | `double?` | Optional | Orginal exchange rate |
| `OriginalTransactionItemInvoiceDate` | `string` | Optional | Original treansaction date |
| `FeeTypeId` | `int?` | Optional | Fee type identifier<br>**Constraints**: `>= 1`, `<= 1` |
| `LineItemDescription` | `bool?` | Optional | Line item identifier of the product<br>**Default**: `false` |
| `FeeRuleDescription` | `string` | Optional | Fee rule description<br>**Constraints**: *Minimum Length*: `8`, *Maximum Length*: `25` |
| `Frequency` | `int?` | Optional | Frequency of transaction<br>**Constraints**: `>= 1`, `<= 1` |
| `FeeRuleId` | `int?` | Optional | Fee rule identifier<br>**Constraints**: `>= 1`, `<= 1` |
| `SystemEntryDate` | `string` | Optional | Entry date in the system |
| `SystemEntryTime` | `string` | Optional | Entry time in the system |
| `IsManual` | `string` | Optional | Checking if its manual<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `OriginalTransactionItemId` | `string` | Optional | Is it manual<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `OriginalTransactionItemInvoiceNumber` | `int?` | Optional | Original invoice transaction number |
| `OriginalTransactionItemInvoiceId` | `int?` | Optional | Original Invoice transaction Identifier |
| `PayerShortName` | `string` | Optional | Payers short name<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `ReverseCharge` | `string` | Optional | Is reverse charge?<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `OriginalGrossAmount` | `double?` | Optional | Original gross amount |
| `OriginalNetAmount` | `double?` | Optional | Original Net amount |
| `UnitOfMeasure` | `string` | Optional | Unit of measure<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `RoadType` | `string` | Optional | Type of road<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `CustomerCountryIsoCode` | `string` | Optional | Customer country ISO Code<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `EVOperator` | `string` | Optional | EvOperator Name<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `20` |
| `EVSerialId` | `string` | Optional | Ev Operator identifier<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `EVChargePointSerial` | `string` | Optional | EV Charging point iserial identifier<br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `50` |
| `EVChargePointConnectorType` | `int?` | Optional | Ev chariging connector type |
| `EVChargePointConnectorTypeDescription` | `string` | Optional | EV charging point connector type description |
| `EVChargeDuration` | `string` | Optional | Ev charging Duration |
| `EVChargeStartDate` | `string` | Optional | EvCharging start Date |
| `EVChargeStartTime` | `string` | Optional | EvCharging start time |
| `EVChargeEndDate` | `string` | Optional | EvCharging End Date |
| `EVChargeEndTime` | `string` | Optional | EvCharging End time |
| `HostingCollectingCompanyNumber` | `int?` | Optional | - |
| `TransactionId` | `double?` | Optional | - |
| `FuelOnly` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "AccountName": "Blue Colour Ltd",
  "AccountId": 29484,
  "AccountNumber": "DE26667080",
  "AccountShortName": "Mathew",
  "Additional1": "GBALLEGO0002452",
  "Additional2": "GBALLEGO0002452",
  "Additional3": "GBALLEGO0002452",
  "Additional4": "GBALLEGO0002452",
  "AllowClearing": "Null",
  "AuthorisationCode": 300796,
  "TransactionStatus": "Y",
  "DriverName": "SATTY BHAMRA",
  "CardExpiryPeriod": 2204,
  "CardExpiry": "2022-01-01",
  "CardGroupId": 40000,
  "CardGroupName": "006240 FIRE BRIGHT SOLUTIONS",
  "IssuerCode": 7002,
  "CardPAN": "7002053465789891000",
  "ReleaseCode": 9,
  "CardSequenceNumber": 617,
  "CardType": "GB STD FLT NAT SINGLE R9",
  "ColCoCode": "014",
  "UnitDiscountInvoiceCurrency": -0.0051,
  "ColCoExchangeRate": 0.851858,
  "InvoiceCurrencySymbol": "GBP",
  "CustomerCountry": "United Kingdom",
  "CustomerCurrencyCode": "GBP",
  "CustomerCurrencySymbol": "£",
  "EffectiveDiscountInCustomerCurrency": -0.22,
  "EffectiveUnitDiscountInCustomerCurrency": -0.0051,
  "UnitPriceInInvoiceCurrency": 1.1024,
  "InvoiceTax": 0,
  "InvoiceGrossAmount": 57.25,
  "InvoiceNetAmount": 47.71,
  "VATonNetAmountInCustomerCurrency": 9.54,
  "CustomerRetailPriceUnitGross": 0,
  "CustomerRetailValueTotalGross": 57.52,
  "CustomerRetailValueTotalNet": 47.93,
  "TransactionTypeDescription": 9.59,
  "RebateonNetAmountInTransactionCurrency": -0.22,
  "EffectiveDiscountInTrxCurrency": -0.22,
  "UnitDiscountTransactionCurrency": -0.005,
  "TransactionGrossAmount": 57.25,
  "TransactionNetAmount": 47.71,
  "TransactionTax": 9.54,
  "VATonNetAmount": 9.54,
  "DelcoListPriceUnitNet": 0,
  "DelcoRetailPriceUnitGross": 1.32888,
  "UnitPriceInTransactionCurrency": 1.1074,
  "DelcoRetailPriceUnitNet": 1.1074,
  "DelcoRetailValueTotalGross": 57.52,
  "DelcoRetailValueTotalNet": 47.93,
  "TransactionCurrencySymbol": "$",
  "DiscountType": "Retail",
  "DisputeStatus": false,
  "IsShellSite": false,
  "FleetIdInput": "YG67OUM",
  "IncomingProductCode": 23,
  "PostingDate": "2021-08-02",
  "ProductCode": 30,
  "ProductName": "Unleaded - Medium octane",
  "ProductGroupId": 22,
  "IncomingCurrencyCode": "GBP",
  "IncomingSiteDescription": "Shell Broadway Ring",
  "Location": "Shell Broadway Ring",
  "SiteName": "Shell Broadway Ring",
  "SiteCode": 32,
  "IncomingSiteNumber": 15,
  "InvoiceCurrencyCode": "GBP",
  "InvoiceDate": "2021-08-02",
  "InvoiceNumber": 3201016193,
  "VATApplicable": "Y",
  "PayerName": "Colours Services Ltd",
  "PayerNumber": "GB12121212",
  "ParentCustomerNumber": "GB12121212",
  "PayerGroup": "H312066",
  "PayerGroupName": "12162566 - FUEL CARD SERVICE",
  "CheckDigit": 6,
  "NetInvoiceIndicator": "Y",
  "DelcoCode": 5,
  "NetworkCode": 3,
  "PurchasedInCountry": "United Kingdom",
  "SiteCountry": "United Kingdom",
  "VATCountry": "United Kingdom",
  "DelcoName": "Shell U.K. Oil Products Limited",
  "Network": "Shell",
  "OdometerInput": 0,
  "OriginalSalesItemId": "Null",
  "FleetIDDescription": "YG67OUM",
  "ParentCustomerId": 6494,
  "PINIndicator": "Y, N",
  "ProductGroupName": "Fees",
  "PurchasedInCountryCode": "GB",
  "Quantity": 43.28,
  "RebateRate": 0.0022,
  "ReceiptNumber": 6803,
  "SiteGroupId": 202,
  "SiteGroupName": "CZ 9100 ECONOMY NETWORK",
  "Latitude": 53.83606,
  "Longitude": -1.61854,
  "DelCoExchangeRate": 0.851858,
  "EuroRebateAmount": -0.258259,
  "NetEuroAmount": 56.01,
  "EuroVATAmount": 11.2,
  "ParentCustomerName": "FUEL CARD SERVICES LTD",
  "IsInvoiced": false,
  "TransactionCurrencyCode": "GBP",
  "CreditDebitCode": "D or C",
  "TransactionDate": "2021-08-01",
  "TransactionTime": "01/01/0001 12:16:58",
  "TransactionItemId": "H305908971030",
  "TrnIdentifier": "H305908971030",
  "Type": "SALE",
  "TransactionLine": 1,
  "TransactionType": "Purchase",
  "UTCOffset": "Europe/London",
  "VATCategory": "United Kingdom Standard VAT Rate",
  "VATRate": 0.2,
  "VehicleRegistration": "YG67OUM",
  "IsCancelled": "Y",
  "ColCoGrossAmount": 57.25,
  "ColCoNetAmount": 47.71,
  "ColCoVATAmount": 9.54,
  "OriginalCurrencySymbol": "$",
  "OriginalCurrencyCode": "$",
  "OriginalVATAmount": 0,
  "EmbossText": "PARKLANE PROPERTIES LTD",
  "OriginalExchangeRate": 0,
  "OriginalTransactionItemInvoiceDate": "2022-02-02",
  "FeeTypeId": 1,
  "LineItemDescription": true,
  "FeeRuleDescription": "Simple Fee",
  "Frequency": 1,
  "FeeRuleId": 1,
  "SystemEntryDate": "2021-08-28",
  "SystemEntryTime": "01/01/0001 20:21:08",
  "IsManual": "Y",
  "OriginalTransactionItemId": "Y",
  "OriginalTransactionItemInvoiceNumber": 6750802,
  "OriginalTransactionItemInvoiceId": 234,
  "PayerShortName": "FUEL CARD SERVICES LTD",
  "ReverseCharge": "Y",
  "OriginalGrossAmount": 57.25,
  "OriginalNetAmount": 57.25,
  "UnitOfMeasure": "L",
  "RoadType": "National Road",
  "CustomerCountryIsoCode": "DE",
  "EVOperator": "Shell Recharge",
  "EVSerialId": "GBALLEGO0002452",
  "EVChargePointSerial": "GBALLEGO0002452",
  "EVChargePointConnectorType": 5,
  "EVChargePointConnectorTypeDescription": "DC 50 kW",
  "EVChargeDuration": "PT3205S",
  "EVChargeStartDate": "2021-08-01",
  "EVChargeStartTime": "01/01/0001 20:08:01",
  "EVChargeEndDate": "2022-08-01",
  "EVChargeEndTime": "01/01/0001 20:08:01"
}
```

