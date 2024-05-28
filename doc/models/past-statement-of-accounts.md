
# Past Statement of Accounts

## Structure

`PastStatementOfAccounts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmountDue` | `double?` | Optional | Invoiced amount under this statement of account and due for payment. |
| `AmountNotOverdue` | `double?` | Optional | Total Invoiced amount until this SOA and not overdue for payment. |
| `AmountOverdue` | `double?` | Optional | Overdue amount from the previously generated statement of accounts. |
| `AmountOverdueFromUnallocated` | `double?` | Optional | Overdue amount calculated from unallocated payment. |
| `AmountPaid` | `double?` | Optional | Amount settled for this Statement. |
| `BalanceOnThisStatement` | `double?` | Optional | Balance amount to be settled on this SOA. |
| `BillingCurrencyCode` | `string` | Optional | Billing currency ISO code.<br>Example: EUR |
| `BillingCurrencySymbol` | `string` | Optional | Billing currency symbol.<br>Example: € |
| `CreditLimit` | `double?` | Optional | Credit limit. |
| `CreditLimitCurrencyCode` | `string` | Optional | ISO code of the credit limit’s currency.<br>Example: EUR |
| `CreditLimitCurrencySymbol` | `string` | Optional | Symbol of the credit limit’s currency.<br>Example: € |
| `CreditLimitInCustomerCurrency` | `double?` | Optional | Credit limit in Customer currency.<br>Note: For currency details refer the parameters CurrencyCode & CurrencySymbol in the SOADetail response. |
| `CurrencyCode` | `string` | Optional | ISO code of SOA currency.<br>Example: EUR |
| `CurrencySymbol` | `string` | Optional | Symbol of SOA currency.<br>Example: € |
| `FullyPaid` | `bool?` | Optional | True If all summary billing documents under this SOA are fully paid (i.e., the fully paid flag is set to true for all documents or the amount allocated is greater than or equal to the amount due under this SOA. |
| `LastPaymentCurrencyCode` | `string` | Optional | ISO code of last payment currency.<br>Example: EUR |
| `LastPaymentCurrencySymbol` | `string` | Optional | Symbol of last payment currency.<br>Example: € |
| `LastPaymentDate` | `string` | Optional | Last payment date. Format: yyyyMMdd |
| `LastPaymentValue` | `double?` | Optional | Last payment value. |
| `OutstandingBalance` | `double?` | Optional | Total outstanding balance at the time of this SOA generation. |
| `PayerId` | `int?` | Optional | Payment customer id of the customer. |
| `PayerNumber` | `string` | Optional | Payment customer number. |
| `PaymentDueDate` | `string` | Optional | Due date for payment. Format: yyyyMMdd |
| `SoAReferenceNumber` | `string` | Optional | Statement of account reference number. |
| `StatementDate` | `string` | Optional | Date on which the SOA was generated.<br>Format: yyyyMMdd |
| `StatementOfAccountId` | `int?` | Optional | Statement of account identifier, |
| `TotalBillingDocuments` | `int?` | Optional | Total number of billing documents generated under this Statement of Account. |
| `TotalNetAmountBillingCurrency` | `double?` | Optional | Total NET amount from all billing documents in this SOA. |
| `TotalSummaryBillingDocuments` | `double?` | Optional | Total number of summary billing documents for this Statement of Account |
| `TotalVATAmountBillingCurrency` | `double?` | Optional | Total VAT amount from all billing documents in this SOA. |
| `UnallocatedPayment` | `double?` | Optional | Amount paid but not allocated to any invoices at the time of this SOA generation. |
| `LocalCurrencyCode` | `string` | Optional | Currency ISO code of the local country. It is derived based on CountryCode from microservice configuration. This field is expected to have different value than the previously mentioned field CurrencyCode, only in the case of serviced OUs.<br>Example: EUR |
| `LocalCurrencySymbol` | `string` | Optional | Currency Symbol of the local country. It is derived based on CountryCode from microservice configuration. This field is expected to have different value than the previously mentioned field CurrencySymbol, only in the case of serviced OUs.<br>Example: € |
| `LocalCurrencyExchangeRate` | `double?` | Optional | Exchange rate from Billing currency to local currency.<br>Example: 1.2 |

## Example (as JSON)

```json
{
  "AmountDue": 208.8,
  "AmountNotOverdue": 54.46,
  "AmountOverdue": 69.54,
  "AmountOverdueFromUnallocated": 130.1,
  "AmountPaid": 138.64
}
```

