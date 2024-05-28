
# Invoice Summary Request Filters

## Structure

`InvoiceSummaryRequestFilters`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id of the selected payer.<br>Optional.<br>Example:<br>1-Philippines<br>5-UK |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Optional if PayerNumber is passed else Mandatory<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer.<br>Optional if PayerId is passed else Mandatory<br>Example: GB000000123 |
| `InvoiceId` | `int?` | Optional | Invoice id.<br>Optional.<br>This input is a search criterion, if given.<br>Example: 1 |
| `InvoiceNumber` | `string` | Optional | Invoice number.<br>Optional.<br>This input is a search criterion, if given.<br>Example: 0123456789 |
| `FromDate` | `string` | Optional | Invoice date searched from this date.<br>Optional.<br>This input is a search criterion, if given.<br>Date format: yyyyMMdd<br>Example: 20170830<br>Note: This criterion is ignored if ‘Period’ is given.<br>Also, this criterion is ignored if ‘ToDate’ is not provided. |
| `ToDate` | `string` | Optional | Invoice date searched until this date.<br>Optional.<br>This input is a search criterion, if given.<br>Date format: yyyyMMdd<br>Example: 20170830<br>Note: This criterion is ignored if ‘Period’ is given.<br>Also, this criterion is ignored if ‘FromDate’ is not provided. |
| `InvoiceDate` | `string` | Optional | Date of invoicing.<br>Optional.<br>This input is a search criterion, if given.<br>Date format: yyyyMMdd<br>Example: 20170830 |
| `SummaryDocumentId` | `int?` | Optional | Summary document id<br>Optional.<br>This input is a search criterion, if given.<br>Example: 1 |
| `SummaryDocumentNumber` | `string` | Optional | Summary document number<br>Optional.<br>This input is a search criterion, if given.<br>Example: ‘0/CZ0000000123456/2017’ |
| `StatementOfAccountId` | `string` | Optional | Statement of Account Id of the payment customer.<br>Optional.<br>This input is a search criterion, if given.<br>Example: 1 |
| `SoAReferenceNumber` | `string` | Optional | Statement of Account reference number of the payment customer.<br>Optional.<br>This input is a search criterion, if given.<br>Example: 123 |
| `Period` | `int?` | Optional | Invoice date search period. Valid values –<br><br>1. Last 7 days – Issued in last 7 days.<br>2. Last 30 days – Issued in last 30 days.<br>3. Last 90 days – Issued in last 90 days.<br>   Optional.<br>   This input is a search criterion, if given.<br>   Example: 1 |
| `InvoiceStatus` | `string` | Optional | Status of the invoice. Valid values –<br>•	Due – Invoices due for payment and is within the due date.<br>•	Paid – Fully paid Invoices.<br>•	Overdue – Invoices due of payment and has crossed the due date.<br>•	CreditNote – Credit notes<br>•	CreditStatement<br>Optional.<br>This input is a search criterion, if given. |
| `InvoicedOnBehalfOf` | `string` | Optional | ISO code of the country i.e., UK, DE, MY, etc.<br>Optional |
| `IncludeEInvoiceDetails` | `bool?` | Optional | Whether to include the additional invoice details in the API response.<br>Optional. Default value “False”.<br>The parameters that are populated<br>•	DocumentReference<br>•	AdditionalDocuments<br>The above fields will not be present in the response when the respective data is not available in the source system. |
| `ColCoCode` | `int?` | Optional | Collecting Company Code of the selected payer.<br>Mandatory - It is mandatory field to external source ATOS for E-invoicing.<br>Example:<br>86-Philippines<br>5-UK |
| `Accounts` | [`List<Accounts>`](../../doc/models/accounts.md) | Optional | - |
| `Type` | `string` | Optional | Invoice type. Allowed values –<br>•	Original – Original document.<br>•	Reversal – Reversed document.<br>•	Replacement – Replaced document.<br>Optional. (When not passed all invoice, types are considered for search)<br>This input is a search criterion, if given.<br>Example: Original |

## Example (as JSON)

```json
{
  "ColCoId": 176,
  "PayerId": 224,
  "PayerNumber": "PayerNumber6",
  "InvoiceId": 108,
  "InvoiceNumber": "InvoiceNumber6"
}
```

