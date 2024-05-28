
# Payments Since Last SOA

List of payments made by the customer after the latest Statement of Account.
Note: All the payments made by the customer will be returned when there is no Statement of Account available for customer.

## Structure

`PaymentsSinceLastSOA`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Identifier for which payment is made.<br>Example: 12345 |
| `AccountNumber` | `string` | Optional | Account number for which payment is made.<br>Example: GB000000123 |
| `AccountShortName` | `string` | Optional | Account Short Name<br>Example: GB Earth Movers-SN |
| `SummaryDocumentId` | `int?` | Optional | Summary billing document reference id.<br>Example: 2 |
| `SummaryDocumentNumber` | `string` | Optional | Summary billing document reference number. |
| `SummaryDocumentDate` | `string` | Optional | Summary billing document date.<br>Format: YYYYMMDD |
| `SummaryDocumentPaymentDueDate` | `string` | Optional | Payment due date of the Summary billing document.<br>Format: YYYYMMDD |
| `SummaryDocumentTotalValue` | `double?` | Optional | Total value in the Summary billing document. |
| `SummaryDocumentTotalVAT` | `double?` | Optional | Total VAT in the Summary billing document. |
| `SummaryDocumentDDAmount` | `double?` | Optional | Total DD amount in the Summary billing document. |
| `PaymentDate` | `string` | Optional | Date of payment.<br>Format: YYYYMMDD |
| `PaymentReference` | `string` | Optional | Reference text of the payment. |
| `PaymentCurrencyCode` | `string` | Optional | ISO code of payment currency.<br>Example: EUR |
| `PaymentCurrencySymbol` | `string` | Optional | Symbol of payment currency.<br>Example: € |
| `AmountPaid` | `double?` | Optional | Amount paid. |
| `Balance` | `double?` | Optional | Balance amount to be settled for the Summary document. |
| `TruePayment` | `string` | Optional | True Payment. |
| `PrepaidBalance` | `double?` | Optional | Balance in the pre-paid amount. |
| `LocalCurrencyCode` | `string` | Optional | Currency ISO code of the local country. It is derived based on CountryCode from microservice configuration. This field is expected to have different value than the previously mentioned field CurrencyCode, only in the case of serviced OUs.<br>Example: EUR |
| `LocalCurrencySymbol` | `string` | Optional | Currency Symbol of the local country. It is derived based on CountryCode from microservice configuration. This field is expected to have different value than the previously mentioned field CurrencySymbol, only in the case of serviced OUs.<br>Example: € |
| `LocalCurrencyExchangeRate` | `string` | Optional | Exchange rate from Payment currency to local currency. |

## Example (as JSON)

```json
{
  "AccountId": 0,
  "AccountNumber": "AccountNumber4",
  "AccountShortName": "AccountShortName6",
  "SummaryDocumentId": 92,
  "SummaryDocumentNumber": "SummaryDocumentNumber8"
}
```

