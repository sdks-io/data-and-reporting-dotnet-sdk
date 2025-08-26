
# Transaction Exceptions

## Structure

`TransactionExceptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SalesItemId` | `double?` | Optional | Unique Sales Item Identifier |
| `CardId` | `int?` | Optional | Unique Card Identifier |
| `ProductId` | `int?` | Optional | Product Id |
| `TransactionGUID` | `string` | Optional | Transaction Unique Identifier |
| `TransactionDate` | `string` | Optional | Local Transaction Date  of where the transaction took place<br>Format: yyyyMMdd |
| `CustomerInvoiceValueTotalGross` | `double?` | Optional | Total Gross Amount for the Invoice Customer |
| `CardPAN` | `string` | Optional | Card PAN number<br>Returns masked PAN number when masking is enabled at the Microservices configuration (Mask all digits except the last 6 digits of the PAN) |
| `CardExpiry` | `string` | Optional | Card Expiry Date<br>Format: yyyyMMdd |
| `TransactionTime` | `string` | Optional | Local Transaction Time of where the transaction took place<br>Format: HH:mm:ss (24 hours format) |
| `UTCOffset` | `string` | Optional | UTC Offset extracted from GFN Sales Date time. Note: This may not be accurate for all TPN transactions<br>Format: +/-HH:mm:ss (24 hours format) |
| `FleetIdInput` | `string` | Optional | Fleet Id Input as entered by the drivers at the time of transaction |
| `OdometerInput` | `int?` | Optional | Odometer Input as entered by the drivers at the time of transaction |
| `DriverName` | `string` | Optional | Driver Name embossed on the card |
| `VehicleRegistration` | `string` | Optional | Vehicle Registration Number embossed on the card |
| `InvoiceCurrencyCode` | `string` | Optional | ISO currency code (Example: GBP) |
| `InvoiceCurrencySymbol` | `string` | Optional | Currency symbol of the Invoice Currency Code (i.e. £, $, etc.,) |
| `TransactionCurrencyCode` | `string` | Optional | ISO currency code |
| `TransactionCurrencySymbol` | `string` | Optional | Currency symbol of the Transaction Currency Code (i.e. £, $, etc.,) |
| `TransactionNetAmount` | `double?` | Optional | Net Amount |
| `TransactionTax` | `double?` | Optional | Tax Amount |
| `TransactionGrossAmount` | `double?` | Optional | Gross Amount |
| `InvoiceNetAmount` | `double?` | Optional | Invoiced Net Amount |
| `InvoiceTax` | `double?` | Optional | Invoiced Tax Amount |
| `InvoiceGrossAmount` | `double?` | Optional | Invoice Gross Amount |
| `PurchasedInCountry` | `string` | Optional | Country of Purchase (Ex: France, Germany, etc.,) |
| `AccountId` | `int?` | Optional | Account Id |
| `AccountNumber` | `string` | Optional | Account Number |
| `AccountName` | `string` | Optional | Account Name |
| `AccountShortName` | `string` | Optional | Account Short Name |
| `Quantity` | `double?` | Optional | Quantity/Volume |
| `FuelProduct` | `bool?` | Optional | True if the product on transaction is listed as a fuel product else return false |
| `UnitPriceInTransactionCurrency` | `double?` | Optional | Product Unit Price in transaction currency |
| `UnitPriceInInvoiceCurrency` | `double?` | Optional | Product Unit Price in invoice currency |
| `UnitDiscountTransactionCurrency` | `double?` | Optional | Unit Discount in transaction currency |
| `UnitDiscountInvoiceCurrency` | `double?` | Optional | Unit Discount in invoice currency |
| `IsInvoiced` | `bool?` | Optional | True when the transaction is already invoice, else return False |
| `InvoiceNumber` | `string` | Optional | Invoice Number if invoiced |
| `InvoiceDate` | `string` | Optional | Invoice Date<br>Format: yyyyMMdd HH:mm:ss |
| `SiteCode` | `string` | Optional | Site Code |
| `SiteName` | `string` | Optional | Site Name |
| `SiteCountry` | `string` | Optional | Site Country |
| `Location` | [`Location`](../../doc/models/location.md) | Optional | - |
| `CardGroupName` | `string` | Optional | Card Group Name |
| `ReceiptNumber` | `string` | Optional | Receipt Number |
| `ProductCode` | `string` | Optional | Product Code |
| `ProductName` | `string` | Optional | Product Name |
| `ProductGroupId` | `int?` | Optional | Product Group Id |
| `ProductGroupName` | `string` | Optional | Product Group Name |
| `DelCoExchangeRate` | `double?` | Optional | DelCo Exchange Rate (Site exchange rate) |
| `ColCoExchangeRate` | `double?` | Optional | ColCo Exchange Rate (Customer exchange rate) |
| `IsShellSite` | `bool?` | Optional | True when transaction occurred at a Shell site else return False |
| `Network` | `string` | Optional | Network as configured |
| `SiteGroupId` | `int?` | Optional | Site Group Id |
| `SiteGroupName` | `string` | Optional | Site GroupName |
| `PostingDate` | `string` | Optional | Site GroupName |
| `IssuerCode` | `string` | Optional | First digits of the Card PAN<br>7002 = Fleet  <br>7077 = CRT |
| `PurchasedInCountryCode` | `string` | Optional | ISO code of the country where the transaction took place |
| `CustomerCountryCode` | `string` | Optional | ISO code of the  Customer Country |
| `CustomerCountry` | `string` | Optional | Name of the Customer Country |
| `ReleaseCode` | `string` | Optional | Release code, 7th Digit of the Card PAN |
| `CardGroupId` | `string` | Optional | Card group ID |
| `CardSequenceNumber` | `string` | Optional | 3 digits, Card sequence number and Check digit  (Digit 16,17 and 18 on the card pan) |
| `CheckDigit` | `string` | Optional | Check digit, Last number of the card pan |
| `FleetIDDescription` | `string` | Optional | FleetId/CRN description in Card Platform configured at the account level |
| `VATRate` | `double?` | Optional | VAT Percentage |
| `VATCategory` | `string` | Optional | VAT Category Id-Description<br>1-Zero Rated<br>2-A1 PH-O 12% Sales Domestic<br>3-VAT exempt |
| `EffectiveDiscountInTrxCurrency` | `string` | Optional | Effective Discount (excluding VAT, in transaction currency)  4 digits |
| `TransactionType` | `string` | Optional | Transaction Type |
| `PINIndicator` | `string` | Optional | Pin Indicator (Indicates whether PIN used or not used at the time of transaction) |
| `VATApplicable` | `string` | Optional | Is VAT Applicable for this transaction<br>“Y” or “N” |
| `NetInvoiceIndicator` | `string` | Optional | Net Invoice Indicator, Will the customer receive an invoice without VAT?<br>Example: “Y” or “N” |
| `CustomerCurrencyCode` | `string` | Optional | Customer currency code |
| `CustomerCurrencySymbol` | `string` | Optional | Customer currency Symbol |
| `EffectiveUnitDiscountInCustomerCurrency` | `double?` | Optional | Effective Unit Discount |
| `EffectiveDiscountInCustomerCurrency` | `double?` | Optional | Effective Discount |
| `VATonNetAmountInCustomerCurrency` | `double?` | Optional | VAT on Net Amount |
| `DiscountType` | `string` | Optional | Discount Type<br>Example: 1-None<br>2-Pence per unit<br>3-Percentage |
| `TransactionStatus` | `string` | Optional | Transaction status  "U" or "I"<br>“U” stands for Uninvoiced<br>“I” stands for Invoiced |
| `PayerGroup` | `string` | Optional | Payer Group applicable for the Large Customer NL+8 digit code |
| `RefundFlag` | `string` | Optional | Refund Flag “N” for Not Refunded and “Y” for Refunded. |
| `OriginalSalesItemId` | `double?` | Optional | Shows Sales Item Id of the original item that was refunded |
| `DelcoName` | `string` | Optional | Delco Name |
| `DelcoCode` | `string` | Optional | Delco Code |
| `PayerNumber` | `string` | Optional | Payer number |
| `PayerName` | `string` | Optional | Payer name |
| `CardExpiryPeriod` | `string` | Optional | Year/Month of the Card Expiry captured on the transaction |
| `AuthorisationCode` | `string` | Optional | Authorisation code of the transaction |
| `TransactionId` | `string` | Optional | Unique id of the transaction that may include one or more salesitems |
| `TransactionLine` | `string` | Optional | Transaction line item number |
| `AllowClearing` | `string` | Optional | Is the Sales Item allowed for clearing? i.e. not written off<br>Example: “Y” or “N” |
| `CRMNumber` | `string` | Optional | CRM Case number if the sales item is in dispute |
| `DisputeStatus` | `string` | Optional | Sales Item Dispute Status if disputed<br>0    No Dispute<br>1    In Dispute<br>2    Re-Instated<br>3    Adjusted<br>4    Written Off by Colco<br>5    Written Off by Delco<br>6    Charged Back to Site |
| `RebateRate` | `double?` | Optional | Unit discount in customer currency |
| `DelCoToColCoExchangeRate` | `double?` | Optional | Exchange rate from transaction currency to customer currency. |
| `NetEuroAmount` | `double?` | Optional | Net euro amount. |
| `EuroRebateAmount` | `double?` | Optional | Euro rebate amount. |
| `EuroVATAmount` | `double?` | Optional | Euro VAT amount. |
| `ParentCustomerNumber` | `string` | Optional | Parent customer number |
| `VATonNetAmount` | `double?` | Optional | VAT on Net Amount (in transaction currency) 2 decimals |
| `VATCountry` | `string` | Optional | VAT Country |

## Example (as JSON)

```json
{
  "SalesItemId": 113.2,
  "CardId": 104,
  "ProductId": 220,
  "TransactionGUID": "TransactionGUID2",
  "TransactionDate": "TransactionDate6"
}
```

