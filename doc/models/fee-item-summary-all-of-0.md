
# Fee Item Summary All of 0

## Structure

`FeeItemSummaryAllOf0`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FeeTypeGroup` | `string` | Optional | Fee type group in under which the Fee item is generated. |
| `FeeTypeId` | `string` | Optional | Fee Type Id ID  Description |
| `ProductId` | `int?` | Optional | Product Id |
| `ProductCode` | `string` | Optional | Product Code |
| `ProductName` | `string` | Optional | Product Name |
| `ProductGroupId` | `int?` | Optional | Product Group Id |
| `ProductGroupName` | `string` | Optional | Product Group Name |
| `TotalQuantity` | `double?` | Optional | Total Quantity |
| `TotalInvoiceNetAmount` | `double?` | Optional | Total Net amount in invoice currency |
| `TotalInvoiceGrossAmount` | `double?` | Optional | Total Gross amount in invoice currency |
| `TotalInvoiceVATAmount` | `double?` | Optional | Total VAT amount in invoice currency |
| `InvoiceCurrencyCode` | `string` | Optional | ISO 4217 currency code of the country |
| `InvoiceCurrencySymbol` | `string` | Optional | Currency symbol of the Invoice Currency Code |

## Example (as JSON)

```json
{
  "FeeTypeGroup": "Account",
  "FeeTypeId": "1",
  "ProductId": 102,
  "ProductCode": "Invoice production fee",
  "ProductName": "Invoice production fee",
  "ProductGroupId": 22,
  "ProductGroupName": "Card related fees",
  "TotalQuantity": 2,
  "TotalInvoiceNetAmount": 22.23,
  "TotalInvoiceGrossAmount": 28.92,
  "TotalInvoiceVATAmount": 10.02,
  "InvoiceCurrencyCode": "GBP",
  "InvoiceCurrencySymbol": "Ã‚Â£"
}
```

