
# Invoice Summary Response

## Structure

`InvoiceSummaryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | API Request Id |
| `Status` | `string` | Optional | Indicates overall status of the request. Allowed values: SUCCES, FAILED |
| `Data` | [`List<InvoiceSummaryDetails>`](../../doc/models/invoice-summary-details.md) | Optional | - |

## Example (as JSON)

```json
{
  "RequestId": "RequestId6",
  "Status": "Status2",
  "Data": [
    {
      "TotalInvoices": 230,
      "TotalGrossAmountCustomerCurrency": 149.02,
      "TotalNetAmountCustomerCurrency": 18.22,
      "TotalVATAmountCustomerCurrency": 21.48,
      "CustomerCurrencyCode": "CustomerCurrencyCode4"
    },
    {
      "TotalInvoices": 230,
      "TotalGrossAmountCustomerCurrency": 149.02,
      "TotalNetAmountCustomerCurrency": 18.22,
      "TotalVATAmountCustomerCurrency": 21.48,
      "CustomerCurrencyCode": "CustomerCurrencyCode4"
    }
  ]
}
```

