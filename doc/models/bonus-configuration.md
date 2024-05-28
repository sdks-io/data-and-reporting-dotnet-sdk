
# Bonus Configuration

## Structure

`BonusConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PricingAccountId` | `int?` | Optional | Account identifier of the Pricing Account associated with the Payer. |
| `PricingAccountNumber` | `string` | Optional | Account number of the Pricing Account associated with the Payer. |
| `PricingAccountShortName` | `string` | Optional | Short name of the Pricing Account associated with the Payer. |
| `PricingAccountFullName` | `string` | Optional | Full name of the Pricing Account associated with the Payer. |
| `FeeRuleId` | `int?` | Optional | Bonus or association bonus configuration identifier that is associated to the payer. |
| `FeeRuleDescription` | `string` | Optional | Bonus or association bonus configuration description that is associated to the payer. |
| `FeeRuleDateEffective` | `string` | Optional | The bonus or association bonus configuration becomes effective on the payer from this date.<br>Format: YYYYMMDD |
| `FeeRuleDateTerminated` | `string` | Optional | The bonus or association bonus configuration is terminated for the payer on this date.<br>Format: YYYYMMDD |
| `BonusPaidTo` | `string` | Optional | Configuration to specify how the bonus is paid.<br>Format: ID-Description<br>Example:<br>1-Pay to Payer<br>2-Pay to invoice levels before the payer<br>3-Pay to specific customer<br>4-Pay to Association Customer<br>5-Pay to Associated Customers |
| `BonusPaidToAccountId` | `int?` | Optional | Account identifier of the specific account to which the bonus is paid back |
| `BonusPaidToAccountNumber` | `string` | Optional | Account number of the specific account to which the bonus is paid back |
| `BonusPaidToAccountShortName` | `string` | Optional | Short name of the specific account to which the bonus is paid back |
| `BonusPaidToAccountFullName` | `string` | Optional | Full name of the specific account to which the bonus is paid back |
| `Frequency` | `string` | Optional | Frequency of the configuration.<br>Format: ID-Description<br>Examples:<br>1-Daily (all days)<br>2-Daily (only working days)<br>3-Weekly – Monday |
| `NextCalculationDate` | `string` | Optional | The next bonus is calculated for the payer on this date.<br>Format: YYYYMMDD |
| `PreviousCalculatedDate` | `string` | Optional | The previous bonus was calculated for the payer on this date.<br>Format: YYYYMMDD |
| `FeeRuleBasis` | `string` | Optional | Fee Rule Basis configured.<br>Format: ID-Description<br>Example:<br>1-Currency Per Unit<br>2-Percentage of Uplift<br>3-Lump Sum |
| `FeeRuleCurrencyCode` | `string` | Optional | ISO currency code of the currency configured in the Bonus Configuration, if any. |
| `FeeRuleCurrencySymbol` | `string` | Optional | Currency symbol of the currency configured in the Bonus Configuration, if any. |
| `FeeRuleAvailableFrom` | `string` | Optional | This bonus or association bonus is available from this date.<br>Format: YYYYMMDD |
| `FeeRuleAvailableTo` | `string` | Optional | This bonus or association bonus configuration will not be available from this date.<br>Format: YYYYMMDD |
| `FeeRuleLocations` | [`List<FeeRuleLocation>`](../../doc/models/fee-rule-location.md) | Optional | - |
| `FeeRuleTiers` | [`List<FeeRuleTier>`](../../doc/models/fee-rule-tier.md) | Optional | - |
| `AssociatedAccounts` | [`List<AssociatedAccount>`](../../doc/models/associated-account.md) | Optional | - |
| `FeeRuleProducts` | [`List<FeeRuleProduct>`](../../doc/models/fee-rule-product.md) | Optional | - |

## Example (as JSON)

```json
{
  "PricingAccountId": 80,
  "PricingAccountNumber": "PricingAccountNumber0",
  "PricingAccountShortName": "PricingAccountShortName2",
  "PricingAccountFullName": "PricingAccountFullName8",
  "FeeRuleId": 12
}
```

