
# Monthly Invoice Trend

## Structure

`MonthlyInvoiceTrend`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrencyCode` | `string` | Optional | ISO code of invoice currency.<br>Example: EUR |
| `CurrencySymbol` | `string` | Optional | Symbol of invoice currency.<br>Example: € |
| `Month` | `int?` | Optional | Month. |
| `TotalNetAmount` | `double?` | Optional | Total net amount invoiced in this month. |
| `TotalVATAmount` | `double?` | Optional | Total VAT amount invoiced in this month. |
| `Year` | `int?` | Optional | Year. |

## Example (as JSON)

```json
{
  "CurrencyCode": "CurrencyCode8",
  "CurrencySymbol": "CurrencySymbol4",
  "Month": 36,
  "TotalNetAmount": 98.02,
  "TotalVATAmount": 158.14
}
```

