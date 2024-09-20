
# Invoice Search Details

## Structure

`InvoiceSearchDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountFullName` | `string` | Optional | Account Full Name<br>Example: AT_reversal customer_FN |
| `AccountId` | `int?` | Optional | Account ID<br>Example: 29484 |
| `AccountNumber` | `string` | Optional | Account Number<br>Example: GB99215176 |
| `AccountShortName` | `string` | Optional | Account Short Name<br>Example: AT Earth Movers-SN |
| `ColCoId` | `int?` | Optional | ColCo Id.<br>Example: 18 |
| `ColCoOpCoId` | `string` | Optional | ColCo’s OpCo Id.<br>Example: 018 |
| `CurrentBillingFrequency` | `string` | Optional | Current billing frequency of the account.<br>A few of the possible IDs and Description are below:<br>1    Daily (all days)<br>2    Daily (only working days)<br>3    Weekly - Monday<br>4    Weekly - Tuesday<br>5    Weekly - Wednesday<br>6    Weekly - Thursday<br>7    Weekly - Friday<br>8    Weekly - Saturday<br>9    Weekly - Sunday<br>10    Monthly - 1st<br>Example: Weekly – Wednesday |
| `CurrentBillingFrequencyId` | `int?` | Optional | Current billing frequency id of the account.<br>A few of the possible IDs and Description are below:<br>1    Daily (all days)<br>2    Daily (only working days)<br>3    Weekly - Monday<br>4    Weekly - Tuesday<br>5    Weekly - Wednesday<br>6    Weekly - Thursday<br>7    Weekly - Friday<br>8    Weekly - Saturday<br>9    Weekly - Sunday<br>10    Monthly - 1st<br>Example: 5 |
| `CurrentDistributionMethod` | `string` | Optional | Current distribution method name of the account.<br>Example : Id & Description<br>1    e-mail<br>2    Fax<br>3    Courier to Customer<br>4    Courier to Client<br>5    Print<br>6    FTP<br>7    SMS |
| `CurrentDistributionMethodId` | `int?` | Optional | Current distribution method id of the account.<br>Example : Id & Description<br>1    e-mail<br>2    Fax<br>3    Courier to Customer<br>4    Courier to Client<br>5    Print<br>6    FTP<br>7    SMS |
| `CustomerCurrencyCode` | `string` | Optional | Customer currency ISO code.<br>Example: EUR |
| `CustomerCurrencySymbol` | `string` | Optional | Customer currency code.<br>Example: € |
| `DelCoClientNumber` | `string` | Optional | DelCo’s client company number.<br>Example: 132 |
| `DelCoId` | `int?` | Optional | DelCo Id.<br>Example: 132 |
| `DelCoOpCoId` | `string` | Optional | DelCo’s OpCo Id.<br>Example: 032 |
| `DocumentType` | `string` | Optional | Document type Id description. |
| `DocumentTypeId` | `int?` | Optional | Document type Id. |
| `DueDate` | `string` | Optional | Due date. Format: yyyyMMdd.<br>Example: 20170115 |
| `GrossAmountCustomerCurrency` | `double?` | Optional | Gross amount in customer currency in the document. |
| `GrossAmountTransactionCurrency` | `double?` | Optional | Gross amount in transaction currency in the document |
| `InvoiceDate` | `string` | Optional | Invoicing date. Format: yyyyMMdd<br>Example: 20170101 |
| `InvoicedBy` | `string` | Optional | Company name. |
| `InvoicedOnBehalfOf` | `string` | Optional | Country Name.<br>Example: Czech Republic |
| `InvoiceId` | `int?` | Optional | Invoice id.<br>Example: 1 |
| `InvoiceNumber` | `string` | Optional | Invoice number.<br>Example: 0123456789 |
| `IsInternational` | `bool?` | Optional | True/False.<br>True if this is an International invoice, else false. |
| `IsNational` | `bool?` | Optional | True/False.<br>True if this is a National invoice, else false. |
| `NetAmountCustomerCurrency` | `double?` | Optional | Net amount in customer currency in the document. |
| `NetAmountTransactionCurrency` | `double?` | Optional | Net amount in transaction currency in the document. |
| `PayerId` | `int?` | Optional | Payment customer id of the customer.<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payment customer number.<br>Example: GB000000123 |
| `PaymentTerms` | `string` | Optional | A few of the possible IDs and Descriptions are below:<br>1    14 days after Invoice<br>2    15 days after Invoice<br>3    21 days after Invoice<br>4    30 days after Invoice<br>5    45 days after Invoice |
| `PaymentTermsId` | `int?` | Optional | Payment terms id of the payment customer.<br>A few of the possible IDs and Descriptions are below:<br>1    14 days after Invoice<br>2    15 days after Invoice<br>3    21 days after Invoice<br>4    30 days after Invoice<br>5    45 days after Invoice |
| `ReplacementInvoiceId` | `int?` | Optional | Replaced document id.<br>Example: 2 |
| `ReversalInvoiceId` | `int?` | Optional | Reversed document id.<br>Example: 3 |
| `Status` | `string` | Optional | Status of the document. Valid values –<br>•    [Empty] – For all document types except for Invoice and Statement.<br>•    Due – Invoices/Statements due for payment and is within the due date.<br>•    Paid – Fully paid Invoices/Statements.<br>Overdue – Invoices/Statements due of payment and has crossed the due date. |
| `SummaryDocumentBillingType` | `string` | Optional | Billing type description.<br>Example: Id & Description<br>-3    Guarantee History<br>-1    Initial Balance<br>0    Standard Invoice<br>1    Immediate Invoice<br>2    Guarantee<br>4    Advanced DD Invoice |
| `SummaryDocumentBillingTypeId` | `int?` | Optional | Billing type id.<br>Example: Id & Description<br>-3    Guarantee History<br>-1    Initial Balance<br>0    Standard Invoice<br>1    Immediate Invoice<br>2    Guarantee<br>4    Advanced DD Invoice |
| `SummaryDocumentDate` | `string` | Optional | Document generated date. Format: yyyyMMdd<br>Example: 20170101 |
| `SummaryDocumentDDAmount` | `double?` | Optional | DD amount. |
| `SummaryDocumentDueDate` | `string` | Optional | Due date for document. Format: yyyyMMdd<br>Example: 20170115 |
| `SummaryDocumentId` | `int?` | Optional | Summary document identifier<br>Example: 1 |
| `SummaryDocumentIsFullyPaid` | `bool?` | Optional | True/False<br>True if invoice amount is fully paid, else false |
| `SummaryDocumentNumber` | `string` | Optional | Summary document number<br>Example: ‘0/CZ0000000123456/2017’ |
| `SummaryDocumentPaidAmount` | `double?` | Optional | Total amount paid. |
| `SummaryDocumentSoAReferenceNumber` | `string` | Optional | Statement of Account reference number of the payment customer. |
| `SummaryDocumentStatementOfAccountId` | `int?` | Optional | Statement of Account Id of the payment customer. |
| `TransactionCurrencyCode` | `string` | Optional | Transaction currency ISO code.<br>Example: EUR |
| `TransactionCurrencySymbol` | `string` | Optional | Transaction currency symbol.<br>Example: € |
| `Type` | `string` | Optional | Invoice type description.<br>A few of the possible IDs and Description are below:<br>1    Original<br>2    Reversal<br>3    Replacement<br>Example: Original |
| `TypeId` | `int?` | Optional | Invoice type id.<br>A few of the possible IDs and Descriptions are below:<br>1    Original<br>2    Reversal<br>3    Replacement<br>Example: 1 |
| `VATAmountCustomerCurrency` | `double?` | Optional | VAT amount in customer currency in the document |
| `VATAmountTransactionCurrency` | `double?` | Optional | VAT amount in transaction currency in the document |
| `VATCountry` | `string` | Optional | Country name of the VAT country.<br>Example: France, Germany |
| `VATCountryId` | `int?` | Optional | Country Id of the VAT country.<br>Example: 1,2 |
| `VATCountryISOCode` | `string` | Optional | Country ISO code of the VAT country.<br>Example : CZ, SK, UK, etc., |
| `VATCountryOpCoId` | `string` | Optional | VAT country’s OpCo Id.<br>Example: 032 |
| `DocumentReference` | `string` | Optional | document reference number of the Invoice file |
| `AdditionalDocuments` | [`List<InvoiceSearchAdditionalDocument>`](../../doc/models/invoice-search-additional-document.md) | Optional | - |

## Example (as JSON)

```json
{
  "AccountFullName": "AccountFullName4",
  "AccountId": 252,
  "AccountNumber": "AccountNumber6",
  "AccountShortName": "AccountShortName8",
  "ColCoId": 144
}
```

