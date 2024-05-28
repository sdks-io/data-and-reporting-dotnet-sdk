
# Invoices Summaries

## Structure

`InvoicesSummaries`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmountDue` | `double?` | Optional | Amount due from last summary document date. |
| `AmountNotOverdue` | `double?` | Optional | Amount that are due from past summary documents. |
| `AmountOverdue` | `double?` | Optional | Amount that are overdue from past summary documents. |
| `AmountPaid` | `double?` | Optional | Total amount paid in billing currency. |
| `BillingCurrencyCode` | `string` | Optional | Billing currency ISO code. |
| `BillingCurrencySymbol` | `string` | Optional | Billing currency symbol.<br>Example: € |
| `OutstandingBalance` | `double?` | Optional | Current outstanding balance amount |
| `PaymentDueDate` | `string` | Optional | Payment due date.<br>Format: YYYYMMDD |
| `SummaryDocumentDate` | `string` | Optional | Summary document date.<br>Format: YYYYMMDD |
| `TotalBillingDocuments` | `int?` | Optional | Total number of invoices generated on this date. |
| `TotalGrossAmountBillingCurrency` | `double?` | Optional | Total gross amount in billing currency. |
| `TotalNetAmountBillingCurrency` | `double?` | Optional | Total net amount in billing currency. |
| `TotalSummaryDocuments` | `int?` | Optional | Total number of summary documents generated on this date. |
| `TotalVATAmountBillingCurrency` | `double?` | Optional | Total VAT amount in billing currency. |

## Example (as JSON)

```json
{
  "AmountDue": 132.62,
  "AmountNotOverdue": 125.36,
  "AmountOverdue": 110.28,
  "AmountPaid": 62.46,
  "BillingCurrencyCode": "BillingCurrencyCode0"
}
```

