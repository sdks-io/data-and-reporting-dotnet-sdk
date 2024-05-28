
# Multi Priced Transaction Response Transactions Items

## Structure

`MultiPricedTransactionResponseTransactionsItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Optional | TransactionType is the type of transaction.<br>Example: SalesItem /FeeItem |
| `CardId` | `int?` | Optional | Unique Card Id in GFN<br>Example: 275549 |
| `CardPAN` | `string` | Optional | Card PAN<br>Mask PAN if enabled at Microservices configuration (Mask all digits except the Last 6 digits of the PAN)<br>Example: 7002051006629890645 |
| `CardExpiry` | `string` | Optional | Card Expiry Date<br>Format: yyyyMMdd |
| `TransactionDate` | `string` | Optional | Local Transaction Date of where the transaction took place<br>Format: yyyyMMdd<br><br>Note: For a fee item, this parameter will be populated with fee date. |
| `TransactionTime` | `string` | Optional | Local Transaction Time of where the transaction took place<br>Format: HH:mm:ss (24 hours format)<br><br>Note: For a fee item, this parameter will be populated with fee date. |
| `UTCOffset` | `string` | Optional | UTC Offset extracted from Sales Date time.<br>Note: This may not be accurate for all TPN transactions<br>Format: +/-HH:mm:ss (24 hours format) |
| `FleetIdInput` | `string` | Optional | Fleet Id Input as entered by the drivers at the time of transaction<br>Example: XYZ1234<br>Note: - The value could be null/blank for fees item. |
| `OdometerInput` | `int?` | Optional | Odometer Input as entered by the drivers at the time of transaction<br>Example: 12345<br>Note: - The value could be null/blank for fees item. |
| `DriverName` | `string` | Optional | Driver Name embossed on the card<br>Example:  ANDREW GILBERRY |
| `VehicleRegistration` | `string` | Optional | Vehicle Registration Number embossed on the card |
| `InvoiceCurrencyCode` | `string` | Optional | ISO currency code |
| `InvoiceCurrencySymbol` | `string` | Optional | Currency symbol of the Invoice Currency Code<br>Example: £, $ |
| `TransactionCurrencyCode` | `string` | Optional | ISO currency code<br>Example: GBP |
| `TransactionCurrencySymbol` | `string` | Optional | Currency symbol of the Transaction Currency Code<br>Example: £, $ |
| `TransactionNetAmount` | `int?` | Optional | Net Amount |
| `TransactionTax` | `int?` | Optional | Tax Amount |
| `TransactionGrossAmount` | `int?` | Optional | Gross Amount |
| `InvoiceNetAmount` | `int?` | Optional | Invoiced Net Amount<br>Note: For a fee item, this parameter will be populated with fee InvoiceNetAmount. |
| `InvoiceTax` | `int?` | Optional | Invoiced Tax Amount |
| `InvoiceGrossAmount` | `int?` | Optional | Invoice Gross Amount<br>Note: For a fee item, this parameter will be populated with fee InvoiceGrossAmount. |
| `PurchasedInCountry` | `string` | Optional | Country of Purchase<br>Example: France, Germany<br>Note: - The value could be null/blank for fees item. |
| `AccountId` | `int?` | Optional | Account Id |
| `AccountNumber` | `string` | Optional | Account Number |
| `AccountName` | `string` | Optional | Account Name |
| `AccountShortName` | `string` | Optional | Account Short Name |
| `Quantity` | `int?` | Optional | Quantity/Volume |
| `FuelProduct` | `bool?` | Optional | True if the product on transaction is listed as a fuel product else return false |
| `UnitPriceInTransactionCurrency` | `int?` | Optional | Product Unit Price in transaction currency<br>Note: - The value could be null/blank for fees item |
| `UnitPriceInInvoiceCurrency` | `int?` | Optional | Product Unit Price in invoice currency<br>Note: - The value could be null/blank for fees item |
| `UnitDiscountTransactionCurrency` | `int?` | Optional | Unit Discount in transaction currency<br>Note: - The value could be null/blank for fees item |
| `UnitDiscountInvoiceCurrency` | `int?` | Optional | Unit Discount in invoice currency<br>Note: - The value could be null/blank for fees item. |
| `IsInvoiced` | `bool?` | Optional | True when the transaction is already invoice, else return False |
| `InvoiceNumber` | `string` | Optional | Invoice Number if invoiced<br>Example:<br>S04500493<br>S04478304<br>S04490319 |
| `InvoiceDate` | `string` | Optional | Invoice Date<br>Format: yyyyMMdd HH:mm:ss |
| `SiteCode` | `string` | Optional | Site Code<br>Example:<br>050001 -	CHARNOCK RICHARD NTHBOUND MWSA 0755 |
| `SiteName` | `string` | Optional | Site Name<br>Example:<br>050001 -	CHARNOCK RICHARD NTHBOUND MWSA 0755 |
| `SiteCountry` | `string` | Optional | Site Country<br>Example: France, Germany |
| `Location` | [`List<SiteLocation>`](../../doc/models/site-location.md) | Optional | - |
| `CardGroupName` | `string` | Optional | Card Group Name |
| `ReceiptNumber` | `string` | Optional | ReceiptNumber |
| `ProductCode` | `string` | Optional | Product Code<br>10	TMF Charges<br>11	Tunnel/Bridges<br>12	Motorway toll |
| `ProductName` | `string` | Optional | Product Name<br>Example:<br><br>Unleaded - High octane<br>Unleaded - Medium octane<br>Unleaded - Low octane<br>Unleaded Environmental |
| `ProductGroupId` | `int?` | Optional | Product Group Id<br>Example:<br>1	Parent Product Group<br>2	All Fuels<br>3	Motor gasoline<br>4	2 stroke<br>5	Autogas |
| `ProductGroupName` | `string` | Optional | Product Group Name<br>Example:<br>1	Parent Product Group<br>2	All Fuels<br>3	Motor gasoline<br>4	2 stroke<br>5	Autogas |
| `DelCoExchangeRate` | `double?` | Optional | DelCo Exchange Rate (Site exchange rate)<br>Note: - The value could be null/blank for fees item. |
| `ColCoExchangeRate` | `int?` | Optional | ColCo Exchange Rate (Customer exchange rate) |
| `IsShellSite` | `bool?` | Optional | True when transaction occurred at a Shell site else return False<br>Note: - The value could be null/blank for fees item. |
| `Network` | `string` | Optional | Network  (Shell PH, ESSO, etc.,)<br>100013	STEINDORFER<br>100015	S.A. BELGIAN SHELL N.V.<br>100016	ESSO BE<br>Note: - The value could be null/blank for fees item. |
| `SiteGroupId` | `int?` | Optional | Site Group Id<br>Example: 202<br>Note: - The value could be null/blank for fees item. |
| `SiteGroupName` | `string` | Optional | Site GroupName<br>Example: CZ 9100 ECONOMY NETWORK<br>Note: - The value could be null/blank for fees item. |
| `PostingDate` | `string` | Optional | Transaction Posting Date<br>Format: yyyyMMdd HHmmss |
| `IssuerCode` | `string` | Optional | First digits of the Card PAN<br>7002 = Fleet |
| `PurchasedInCountryCode` | `string` | Optional | ISO code of the country where the transaction took place<br>Example: “NL”<br>Note: - The value could be null/blank for fees item. |
| `CustomerCountryCode` | `string` | Optional | ISO code of the Customer Country<br>Example: NL |
| `CustomerCountry` | `string` | Optional | Name of the Customer Country<br>Example: Netherlands |
| `ReleaseCode` | `string` | Optional | Release code, 7th Digit of the Card PAN<br>Example: 8 for 7021882 |
| `CardGroupId` | `string` | Optional | Card group ID |
| `CardSequenceNumber` | `string` | Optional | 3 digits, Card sequence number and Check digit (Digit 16,17 and 18 on the card pan) |
| `CheckDigit` | `string` | Optional | Check digit, Last number of the card pan |
| `FleetIDDescription` | `string` | Optional | FleetId/CRN description in Card Platform configured at the account level |
| `VATRate` | `double?` | Optional | VAT Percentage<br>0.20 for 20%<br>Note: This parameter will be populated in the response for both SalesItem and FeeItem |
| `VATCategory` | `string` | Optional | VAT Category Id-Description<br>1-Zero Rated |
| `VATCountry` | `string` | Optional | VAT Country<br>Example: Netherlands |
| `EffectiveDiscountInTrxCurrency` | `double?` | Optional | Effective Discount (excluding VAT, in transaction currency) 4 digits<br>Example: 0.0000 |
| `TransactionType` | `string` | Optional | Transaction Type<br>Example: Purchase when Card is Present else Blank<br>Note: - The value could be null/blank for fees item. |
| `PINIndicator` | `string` | Optional | Pin Indicator (Indicates whether PIN used or not used at the time of transaction)<br>Example: “PIN Used'” or “No PIN” or “Unknown”<br>Note: - The value could be null/blank for fees item |
| `VATApplicable` | `string` | Optional | Is VAT Applicable for this transaction<br>Example: “Y” or “N” |
| `NetInvoiceIndicator` | `string` | Optional | Net Invoice Indicator, Will the customer receive an invoice without VAT?<br>Example: “Y” or “N”<br>Note: - The value could be null/blank for fees item. |
| `CustomerCurrencyCode` | `string` | Optional | Customer currency code<br>Example: GBP |
| `CustomerCurrencySymbol` | `string` | Optional | Customer currency Symbol |
| `EffectiveUnitDiscountInCustomerCurrency` | `int?` | Optional | Effective Unit Discount (excluding VAT in Customer currency)<br>Note: - The value could be null/blank for fees item. |
| `EffectiveDiscountInCustomerCurrency` | `int?` | Optional | Effective Discount (excluding VAT in Customer currency)<br>Note: - The value could be null/blank for fees item. |
| `VATonNetAmountInCustomerCurrency` | `int?` | Optional | VAT on Net Amount (in Customer currency) |
| `DiscountType` | `string` | Optional | Discount Type<br>Example: 1-None<br>2-Pence per unit |
| `TransactionStatus` | `string` | Optional | Transaction status "U" or "I"<br>“U” stands for Uninvoiced<br>“I” stands for Invoiced |
| `SalesItemId` | `int?` | Optional | Unique Sales Item Identifier<br>Example: 18315958002<br>Note: For a fee item, this parameter will be populated with SalesItemId. |
| `PayerGroup` | `string` | Optional | Payer Group applicable for the Large Customer NL+8 digit code |
| `PayerGroupName` | `string` | Optional | Payer Group Name |
| `RefundFlag` | `string` | Optional | Refund Flag “N” for Not Refunded and “Y” for Refunded.<br>Note: - The value could be null/blank for fees item. |
| `OriginalSalesItemId` | `string` | Optional | Shows Sales Item Id of the original item that was refunded |
| `DelcoName` | `string` | Optional | Delco Name<br>Example: SHELL NEDERLAND VERKOOPMAATSCHAPPIJ BV |
| `DelcoCode` | `string` | Optional | Delco Code<br>014, 018, etc., |
| `PayerNumber` | `string` | Optional | Payer number (Country code+8 digits)<br>Example: NL10042616 |
| `PayerName` | `string` | Optional | Payer name<br>Example: V.M. LE COMTE |
| `CardExpiryPeriod` | `string` | Optional | Year/Month of the Card Expiry captured on the transaction<br>Example: 1901 |
| `AuthorisationCode` | `string` | Optional | Authorisation code of the transaction<br>Example: 011256<br>Note: - The value could be null/blank for fees item. |
| `TransactionId` | `string` | Optional | Unique id of the transaction that may include one or more salesitems<br>Example: io9KVXk1UkW57XWKyeaHHg<br>Note: - The value could be null/blank for fees item. |
| `TransactionLine` | `string` | Optional | Transaction line item number<br>Example: 1<br>Note: - The value could be null/blank for fees item. |
| `AllowClearing` | `string` | Optional | Is the Sales Item allowed for clearing? i.e. not written off<br>Example: “Y” or “N”<br>Note: - The value could be null/blank for fees item. |
| `CRMNumber` | `string` | Optional | CRM Case number if the sales item is in dispute.<br>Note: - The value could be null/blank for fees item. |
| `DisputeStatus` | `string` | Optional | Sales Item Dispute Status if disputed<br>0	No Dispute<br>1	In Dispute<br>2	Re-Instated<br>3	Adjusted<br>4	Written Off by Colco<br>5	Written Off by Delco<br>6	Charged Back to Site |
| `RebateRate` | `double?` | Optional | Unit discount in customer currency.<br>Example: 28.279000 |
| `DelCoToColCoExchangeRate` | `int?` | Optional | Exchange rate from transaction currency to customer currency.<br>Example: 1 |
| `NetEuroAmount` | `double?` | Optional | Net euro amount.<br>Example: 37.93<br>Note: - The value could be null/blank for fees item. |
| `EuroRebateAmount` | `int?` | Optional | Euro rebate amount.<br>Example: 0<br>Note: - The value could be null/blank for fees item. |
| `EuroVATAmount` | `double?` | Optional | Euro VAT amount.<br>Example: 7.96<br>Note: - The value could be null/blank for fees item. |
| `ParentCustomerNumber` | `string` | Optional | Parent customer number |
| `ParentCustomerName` | `string` | Optional | Parent customer name. |
| `ParentCustomerId` | `int?` | Optional | Parent customer id. |
| `IncomingSiteNumber` | `string` | Optional | Incoming Site Number<br>Example: 100021<br>Note: - The value could be null/blank for fees item. |
| `IncomingSiteDescription` | `string` | Optional | Incoming Site Description<br>Example: HN3 INTI_02-82.02<br>Note: - The value could be null/blank for fees item. |
| `IncomingCurrencyCode` | `string` | Optional | Incoming Currency Code<br>Example: GBP<br>Note: - The value could be null/blank for fees item. |
| `IncomingProductCode` | `string` | Optional | Incoming Product Code<br>Example: 30 |
| `CreditDebitCode` | `string` | Optional | Credit Debit Code<br>Example: “D” or “C”<br>The value could be null/blank for fees item. |
| `CorrectionFlag` | `string` | Optional | Correction Flag<br>Example: “Y” or “N”<br>Note: - The value could be null/blank for fees item. |
| `Additional1` | `string` | Optional | Additional details |
| `Additional2` | `string` | Optional | Additional details |
| `Additional3` | `string` | Optional | Additional details |
| `Additional4` | `string` | Optional | Additional details |
| `RebateonNetAmountInCustomerCurrency` | `double?` | Optional | Rebate on Net Amount in Customer Currency<br>Example: -0.735000000000<br>Note: - The value could be null/blank for fees item. |
| `RebateonNetAmountInTransactionCurrency` | `double?` | Optional | Rebate on Net Amount in Transaction Currency<br>Example: -0.735000000000<br>Note: - The value could be null/blank for fees item. |
| `NetworkCode` | `string` | Optional | Network Code<br>Example: AVEE PTUAZONW CUBFAO COSFS<br>Note: - The value could be null/blank for fees item. |
| `TrnIdentifier` | `string` | Optional | Transaction Identifier |
| `CardType` | `string` | Optional | Card Type |
| `DelcoListPriceUnitNet` | `double?` | Optional | Delco List Price Unit Net<br>Example: 30.500000<br>Note: - The value could be null/blank for fees item |
| `DelcoRetailPriceUnitNet` | `double?` | Optional | Retail Net Price (or pump net price) per Unit in transaction currency<br>Example: 1.921000<br>Note: - The value could be null/blank for fees item |
| `DelcoRetailPriceUnitGross` | `double?` | Optional | Retail gross price (or pump gross price) per unit in transaction currency<br>Note: - The value could be null/blank for fees item |
| `DelcoRetailValueTotalNet` | `double?` | Optional | Retail net price (or net pump price) in transaction currency<br>Note: - The value could be null/blank for fees item |
| `DelcoRetailValueTotalGross` | `double?` | Optional | Retail gross price (or gross pump price) in transaction currency<br>Note: - The value could be null/blank for fees item |
| `CustomerRetailPriceUnitGross` | `double?` | Optional | Retail gross price (or pump gross price) per unit in customer currency<br>Note: - The value could be null/blank for fees item |
| `CustomerRetailValueTotalGross` | `double?` | Optional | Retail gross price (or gross pump price) in customer currency<br>Note: - The value could be null/blank for fees item |
| `CustomerRetailValueTotalNet` | `double?` | Optional | Retail net price (or net pump price) in customer currency<br>Note: - The value could be null/blank for fees item |
| `TransactionTypeDescription` | `string` | Optional | Transaction Type Description<br>Note: - The value could be null/blank for fees item |

## Example (as JSON)

```json
{
  "Type": "Type8",
  "CardId": 146,
  "CardPAN": "CardPAN2",
  "CardExpiry": "CardExpiry6",
  "TransactionDate": "TransactionDate6"
}
```

