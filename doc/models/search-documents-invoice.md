
# Search Documents Invoice

## Structure

`SearchDocumentsInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DocumentReference` | `int?` | Optional | Unique Invoice Reference id of the invoice for downloading the zip file containing PDF and proofing elements.<br>Example: 123456 |
| `InvoiceNumber` | `string` | Optional | Payment customer number.<br>Example: GB000000123 |
| `PayerName` | `string` | Optional | Customer payer name |
| `AccountNumber` | `string` | Optional | Account Number<br>Example: GB99215176 |
| `AccountName` | `string` | Optional | Invoice account name |
| `DocumentType` | `string` | Optional | Document type<br>String containing one of the following values:<br>•	NAT (National)<br>•	INT (International)<br>•	SOA (Statement of Account) |
| `GrossAmount` | `double?` | Optional | Included tax amount in the invoice |
| `NetAmount` | `double?` | Optional | - |
| `TaxAmount` | `double?` | Optional | - |
| `CurrencyCode` | `string` | Optional | - |
| `InvoiceStatus` | `string` | Optional | - |
| `InvoiceDate` | `string` | Optional | - |
| `DueDate` | `string` | Optional | - |
| `VATCountryISOCode` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "DocumentReference": 10,
  "InvoiceNumber": "InvoiceNumber0",
  "PayerName": "PayerName0",
  "AccountNumber": "AccountNumber2",
  "AccountName": "AccountName8"
}
```

