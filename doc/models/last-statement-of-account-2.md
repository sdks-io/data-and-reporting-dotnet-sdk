
# Last Statement of Account 2

## Structure

`LastStatementOfAccount2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmountDue` | `double?` | Optional | Invoiced amount and due for payment. |
| `AmountNotOverdue` | `double?` | Optional | Invoiced amount and not overdue for payment. |
| `AmountOverdue` | `double?` | Optional | Invoiced amount and overdue for payment. |
| `CreditLimit` | `int?` | Optional | Credit limit. |
| `CreditLimitCurrencyCode` | `string` | Optional | ISO code of the credit limit’s currency.<br>Example: EUR |
| `CreditLimitCurrencySymbol` | `string` | Optional | Symbol of the credit limit’s currency.<br>Example: € |
| `CreditLimitInCustomerCurrency` | `double?` | Optional | Credit limit in Customer currency.<br>**Note**: For currency details refer the parameters CurrencyCode & CurrencySymbol in the StatementOfAccount response. |
| `CurrencyCode` | `string` | Optional | ISO code of SOA currency.<br>Example: EUR |
| `CurrencySymbol` | `string` | Optional | Symbol of SOA currency.<br>Example: € |
| `LastPaymentCurrencyCode` | `string` | Optional | ISO code of Last Payment currency.<br>Example: EUR |
| `LastPaymentCurrencySymbol` | `string` | Optional | Symbol of Last Payment currency.<br>Example: € |
| `LastPaymentDate` | `string` | Optional | Last payment date. Format: yyyyMMdd |
| `LastPaymentValue` | `double?` | Optional | Last payment value. |
| `OutstandingBalance` | `double?` | Optional | Current outstanding balance amount. |
| `PayerId` | `int?` | Optional | Payment customer id of the customer. |
| `PayerNumber` | `string` | Optional | Payment customer number. |
| `PaymentDueDate` | `string` | Optional | Due date for payment. Format: yyyyMMdd |
| `PaymentMethod` | `string` | Optional | Payment method description of the Payer.<br>Example: Id & Description<br>•    Incoming - Direct Debit<br>•    Incoming - Cheque<br>•    Incoming - Direct Debit A<br>•    Incoming - Bank Transfer<br>•    Incoming - Cash |
| `PaymentMethodId` | `int?` | Optional | Payment method Id of the Payer.<br>Example: Id & Description<br>•    Incoming - Direct Debit<br>•    Incoming - Cheque<br>•    Incoming - Direct Debit A<br>•    Incoming - Bank Transfer<br>•    Incoming - Cash |
| `PaymentTerms` | `string` | Optional | Payment terms description of the Payer.<br>Example: Id & Description<br>•    14 days after Invoice<br>•    15 days after Invoice<br>•    21 days after Invoice<br>•    30 days after Invoice<br>•    45 days after Invoice<br>•    0 days after invoice<br>•    days after invoice<br>•    days after invoice<br>•    7 days after invoice<br>•    10th of the following month |
| `PaymentTermsId` | `int?` | Optional | Payment terms Id of the Payer.<br>Example: Id & Description<br>•    14 days after Invoice<br>•    15 days after Invoice<br>•    21 days after Invoice<br>•    30 days after Invoice<br>•    45 days after Invoice<br>•    0 days after invoice<br>•    days after invoice<br>•    days after invoice<br>•    7 days after invoice<br>•    10th of the following month |
| `SoAReferenceNumber` | `string` | Optional | Statement of account reference number |
| `StatementDate` | `string` | Optional | Date on which the SOA was generated.<br>Format: yyyyMMdd |
| `StatementOfAccountId` | `int?` | Optional | Statement of account identifier,<br>Example: 1 |
| `TotalBillingDocuments` | `int?` | Optional | Total number of billing documents for this Statement of Account |
| `TotalSummaryBillingDocuments` | `int?` | Optional | Total number of summary billing documents for this Statement of Account |
| `UnallocatedPayment` | `int?` | Optional | Unallocated payment.<br>When negative, indicates overdue amount. |

## Example (as JSON)

```json
{
  "AmountDue": 213.62,
  "AmountNotOverdue": 49.64,
  "AmountOverdue": 64.72,
  "CreditLimit": 6,
  "CreditLimitCurrencyCode": "CreditLimitCurrencyCode6"
}
```

