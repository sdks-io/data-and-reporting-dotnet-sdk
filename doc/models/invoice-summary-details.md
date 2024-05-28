
# Invoice Summary Details

## Structure

`InvoiceSummaryDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalInvoices` | `int?` | Optional | Total number of invoices matching with the given search criteria. |
| `TotalGrossAmountCustomerCurrency` | `double?` | Optional | Total gross amount in customer currency combined from all the invoices matching with the given search criteria. |
| `TotalNetAmountCustomerCurrency` | `double?` | Optional | Total net amount in customer currency combined from all the invoices matching with the given search criteria. |
| `TotalVATAmountCustomerCurrency` | `double?` | Optional | Total VAT amount in customer currency combined from all the invoices matching with the given search criteria. |
| `CustomerCurrencyCode` | `string` | Optional | Customer currency ISO code.<br>Example: EUR |
| `CustomerCurrencySymbol` | `string` | Optional | Customer currency code.<br>Example: € |

## Example (as JSON)

```json
{
  "TotalInvoices": 122,
  "TotalGrossAmountCustomerCurrency": 134.06,
  "TotalNetAmountCustomerCurrency": 45.3,
  "TotalVATAmountCustomerCurrency": 48.56,
  "CustomerCurrencyCode": "CustomerCurrencyCode2"
}
```

