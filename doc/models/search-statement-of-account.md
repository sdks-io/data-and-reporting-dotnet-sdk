
# Search Statement of Account

## Structure

`SearchStatementOfAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StatementOfAccountId` | `int?` | Optional | Statement of account identifier |
| `SoAReferenceNumber` | `string` | Optional | Statement of account reference |
| `StatementDate` | `string` | Optional | Date on which the SOA was generated.<br>Format: yyyyMMdd |
| `PayerId` | `int?` | Optional | Payment customer id of the customer. |
| `PayerNumber` | `string` | Optional | Payment customer number. |
| `AmountDue` | `double?` | Optional | Invoiced amount and due for payment |
| `AmountOverdue` | `double?` | Optional | Invoiced amount and overdue for payment. |
| `CurrencyCode` | `string` | Optional | ISO code of SOA currency. |
| `CurrencySymbol` | `string` | Optional | Symbol of SOA currency.<br>Example: € |
| `DueDate` | `string` | Optional | Due date for payment. Format: yyyyMMdd<br>Note:<br>•	Clients to convert this to appropriate DateTime type.<br>•	SoA due date is considered as the latest due date of the invoices within the SoA |
| `InvoicedOnBehalfOf` | `string` | Optional | ISO code of the country i.e., UK, DE, MY, etc.<br>This is the value of the first invoice within the SoA. It may not be same for all the invoices within the SoA. |
| `Status` | `string` | Optional | Status of the document. Valid values –<br><br>1. Paid – Fully paid all Invoices with in the SOA.<br>2. Overdue – At least one invoice payment due date is less than current date with in the SOA.<br>3. Due – At least one invoice is due for payment and is within the due date. There is no invoice overdue for payment. |
| `GrossAmountCustomerCurrency` | `double?` | Optional | Total gross amount in customer currency. |
| `DocumentReferenceNumber` | `string` | Optional | Document reference number fetched |

## Example (as JSON)

```json
{
  "StatementOfAccountId": 120,
  "SoAReferenceNumber": "SoAReferenceNumber4",
  "StatementDate": "StatementDate2",
  "PayerId": 18,
  "PayerNumber": "PayerNumber6"
}
```

