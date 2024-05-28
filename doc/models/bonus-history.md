
# Bonus History

## Structure

`BonusHistory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayerId` | `int?` | Optional | Payer Id |
| `PayerNumber` | `string` | Optional | Payer Number of the selected payer |
| `PayerShortName` | `string` | Optional | Payer short name. |
| `PayerFullName` | `string` | Optional | Payer full name. |
| `AccountId` | `int?` | Optional | Account Id |
| `AccountNumber` | `string` | Optional | Account Number of the selected payer. |
| `AccountShortName` | `string` | Optional | Account short name. |
| `AccountFullName` | `string` | Optional | Account full name. |
| `InvoiceAccountId` | `int?` | Optional | Invoice Account Id |
| `InvoiceAccountNumber` | `string` | Optional | Invoice Account Number of the selected payer. |
| `InvoiceAccountShortName` | `string` | Optional | Invoice Account short name. |
| `InvoiceAccountFullName` | `string` | Optional | Invoice Account full name. |
| `FeeRuleId` | `string` | Optional | Bonus or association bonus configuration identifier |
| `FeeRuleDescription` | `string` | Optional | Bonus or association bonus configuration description that is associated to the bonus fee item |
| `FromDate` | `string` | Optional | Bonus was calculated from this date.<br>Format: YYYYMMDD |
| `ToDate` | `string` | Optional | Bonus was calculated till this date.<br>Format: YYYYMMDD |
| `BonusPaidTo` | `string` | Optional | Specifies how the bonus was paid back.<br>Format: ID-Description<br>Example:<br>1-Pay to Payer<br>2-Pay to invoice levels before the payer<br>3-Pay to specific customer<br>4-Pay to Association Customer<br>5-Pay to Associated Customers |
| `FeeItemId` | `int?` | Optional | Bonus fee item identifier. |
| `FeeRuleBasis` | `string` | Optional | Fee Rule Basis of the bonus fee item.<br>Format: ID-Description<br>Example:<br>1-Currency Per Unit<br>2-Percentage of Uplift<br>3-Lump Sum |
| `FeeItemCurrencyCode` | `string` | Optional | ISO currency code of the currency in which Bonus is paid.<br>Example: GBP |
| `FeeItemCurrencySymbol` | `string` | Optional | Currency symbol of the currency in which Bonus is paid. |
| `ProratedVolume` | `double?` | Optional | Prorated volume considered under the account as  configured for the bonus association. |
| `TotalVolume` | `double?` | Optional | Total volume considered for calculating the bonus. |
| `FeeProduct` | `string` | Optional | Product as shown in the invoice for the bonus paid.<br>Format: ID-Description<br>Example: 1562-Bonus diesel Shell Netherlands on agreed site(s) |
| `InvoiceGrossAmount` | `double?` | Optional | Gross Amount – Bonus Paid including VAT as shown on the Invoice |
| `InvoiceNetAmount` | `double?` | Optional | Net Amount – Bonus Paid excluding VAT as shown on the Invoice |
| `InvoiceVATAmount` | `double?` | Optional | VAT calculated for the bonus paid as shown on the Invoice |
| `IsFeeCancelled` | `bool?` | Optional | True/False<br>True if bonus is generated but cancelled. When true, consider this as not paid. |
| `FeeItemTierProratedVolume` | `double?` | Optional | Prorated volume in the bonus fee item tier. |
| `FeeItemTierTotalVolume` | `double?` | Optional | Total volume in the bonus fee item tier. |
| `TierMinimum` | `int?` | Optional | Tier minimum value considered for calculation |
| `TierRate` | `double?` | Optional | Tier rate considered for calculation |

## Example (as JSON)

```json
{
  "PayerId": 240,
  "PayerNumber": "PayerNumber0",
  "PayerShortName": "PayerShortName4",
  "PayerFullName": "PayerFullName0",
  "AccountId": 44
}
```

