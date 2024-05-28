
# Fee Item

## Structure

`FeeItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FeeItemId` | `int?` | Optional | Fee Item unique identifier in the H3 Cards Platform |
| `AccountId` | `int?` | Optional | Account Id |
| `AccountNumber` | `string` | Optional | Account Number |
| `AccountShortName` | `string` | Optional | Account short Number |
| `InvoiceAccountId` | `int?` | Optional | Invoice Account Id |
| `InvoiceAccountNumber` | `string` | Optional | Invoice Account Number |
| `InvoiceAccountShortName` | `string` | Optional | Invoice Account short Name |
| `PayerId` | `int?` | Optional | Payer Id |
| `PayerNumber` | `string` | Optional | Payer Number |
| `PayerShortName` | `string` | Optional | Payer short Name |
| `CardId` | `int?` | Optional | Unique Card Id |
| `PAN` | `string` | Optional | Card PAN |
| `CardGroupId` | `int?` | Optional | Card Group Id |
| `CardGroupName` | `string` | Optional | Card Group Name |
| `FeeTypeId` | `int?` | Optional | Fee type identifier. |
| `FeeType` | `string` | Optional | Fee type description |
| `FeeTypeGroup` | `string` | Optional | Fee type group in under which the Fee item is generated.<br>Example:<br>Account<br>Card<br>Others |
| `FeeRuleId` | `int?` | Optional | Fee rule identifier |
| `FeeRuleDescription` | `string` | Optional | Fee rule description |
| `FeeRuleTiers` | [`List<FeesFeeRuleTiers>`](../../doc/models/fees-fee-rule-tiers.md) | Optional | - |
| `FeeItemDate` | `string` | Optional | Local Fee Item Date of when the transaction took place<br>Format: yyyyMMdd |
| `FeeItemTime` | `string` | Optional | Local Fee Item Time of where the transaction took place<br>Format: HH:mm:ss (24 hours format) |
| `IsManual` | `bool?` | Optional | True/False.<br>Is manual |
| `IsCancelled` | `bool?` | Optional | True/False.<br>Is cancelled |
| `CustomerCurrencyCode` | `string` | Optional | ISO currency code<br>Example: GBP |
| `CustomerCurrencySymbol` | `string` | Optional | Currency symbol of the Currency Code<br>Example: £, $ |
| `ProductId` | `int?` | Optional | Product Id<br>Example: Sample list of product ids and description.<br>100 Service fee<br>102 Invoice production fee<br>103 Account fee<br>104 Transaction fee<br>105 Card membership fee |
| `ProductCode` | `string` | Optional | Product Code – Global as per GFN configuration<br>Example:<br>2 Service fee<br>4 Invoice production fee<br>5 Account fee<br>6 Transaction fee<br>7 Card membership fee |
| `ProductName` | `string` | Optional | Product Name<br>Example: Sample list of product ids and description.<br>Service fee<br>Invoice production fee |
| `ProductGroupId` | `int?` | Optional | Product Group Id<br>Example: Sample list<br>22	Card related fees<br>23	Monetary Adjustment |
| `ProductGroupName` | `string` | Optional | Product Group Name<br>Example: Sample list<br>22	Card related fees<br>23	Monetary Adjustment |
| `LineItemDescription` | `string` | Optional | Line Item Description generally the quantity as printed on Invoice or the manually keyed in description for manual fees |
| `Quantity` | `int?` | Optional | Quantity |
| `IsInvoiced` | `bool?` | Optional | True/False.<br>Is fee item invoiced |
| `VATCountryCode` | `string` | Optional | VAT country ISO code |
| `VATCountryName` | `string` | Optional | VAT country name |
| `VATPercentage` | `double?` | Optional | VAT percentage |
| `VATCategoryID` | `int?` | Optional | VAT Category identifier |
| `VATCategoryDescription` | `string` | Optional | VAT Category description |
| `LegislativeRegionId` | `int?` | Optional | Legislative region id |
| `LegislativeRegionName` | `string` | Optional | Legislative region name |
| `SystemEntryDate` | `string` | Optional | System entry date |
| `SystemEntryTime` | `string` | Optional | System entry time |
| `ColCoNetAmount` | `double?` | Optional | ColCo net amount |
| `ColCoVATAmount` | `double?` | Optional | ColCoVAT amount |
| `ColCoGrossAmount` | `double?` | Optional | ColCo gross amount |
| `InterimInvoiceId` | `int?` | Optional | Interim invoice id |
| `InterimInvoiceNumber` | `string` | Optional | Interim invoice number |
| `InvoiceId` | `int?` | Optional | Invoice id |
| `InvoiceNumber` | `string` | Optional | Invoice number |
| `InvoiceDate` | `string` | Optional | Invoice date<br>Format: yyyyMMdd |
| `CustomerExchangeRate` | `double?` | Optional | Customer exchange rate |
| `InvoiceNetAmount` | `double?` | Optional | Invoice net amount |
| `InvoiceGrossAmount` | `double?` | Optional | Invoice gross amount |
| `InvoiceVATAmount` | `double?` | Optional | Invoice VAT amount |
| `ReverseCharge` | `bool?` | Optional | True/False.<br>Reverse charge. |
| `OriginalFeeItemId` | `int?` | Optional | Original Fee Item id. |
| `OriginalCurrencyCode` | `string` | Optional | Original FeeItem Currency ISO code. |
| `OriginalCurrencySymbol` | `string` | Optional | Original FeeItem currency symbol |
| `OriginalUnitPrice` | `double?` | Optional | Original FeeItem unit price |
| `OriginalNetAmount` | `double?` | Optional | Original FeeItem net amount |
| `OriginalVATAmount` | `double?` | Optional | Original FeeItem VAT amount |
| `OriginalGrossAmount` | `double?` | Optional | Original FeeItem gross amount |
| `OriginalExchangeRate` | `double?` | Optional | Original FeeItem exchange rate |
| `OriginalLegislativeRegionId` | `int?` | Optional | Original legislative region id |
| `OriginalLegislativeRegionName` | `string` | Optional | Original legislative region name |
| `Frequency` | `string` | Optional | Fee frequency derived from Fee rules if applicable<br>Returns ID-Description in one field<br>Example:<br>1- Daily (all days)<br>2-Daily (only working days)<br>3-Weekly – Monday<br>4-Weekly - Tuesday |
| `FeeItemCardLevelBreakup` | `string` | Optional | Fee breakup at card level for Fee Items where applicable. |
| `OriginalFeeItemInvoiceId` | `int?` | Optional | Invoice Id/ Billing Document Id of the original fee item (when not null).<br>Applicable only for fee items that are refund to an original fee item that is already invoiced. |
| `OriginalFeeItemInvoiceNumber` | `string` | Optional | Invoice Number of the original fee item (when not null).<br>Applicable only for fee items that are refund to an original fee item that is already invoiced. |
| `OriginalFeeItemInvoiceDate` | `string` | Optional | Invoice Date of the original fee item (when not null).<br>Applicable only for fee items that are refund to an original fee item that is already invoiced.<br>Format: yyyyMMdd |
| `DriverName` | `string` | Optional | Driver name embossed on the Card |
| `EmbossText` | `string` | Optional | Text embossed on the Card |
| `VRN` | `string` | Optional | Reg. Number embossed on the Card |

## Example (as JSON)

```json
{
  "FeeItemId": 156,
  "AccountId": 244,
  "AccountNumber": "AccountNumber6",
  "AccountShortName": "AccountShortName8",
  "InvoiceAccountId": 204
}
```

