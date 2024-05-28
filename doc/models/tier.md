
# Tier

## Structure

`Tier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TierPriceListId` | `int?` | Optional | The price list if reference price is list price.<br>Only used when the Price Rule category is set to.<br>‘Tiered Pricing’. |
| `PriceListDescription` | `string` | Optional | Price list description of the tier. |
| `TierMin` | `int?` | Optional | Minimum tier volume<br>E.g., 500 |
| `TierMax` | `int?` | Optional | Maximum tier volume<br>E.g., 1000 |
| `TieredPricingGroupName` | `string` | Optional | Pricing group name of tier |
| `TieredPricingGroupPeriod` | `string` | Optional | Tiered pricing group period.<br>Possible Values<br><br>1. Monthly<br>2. Quarterly<br>3. Semi Annually<br>4. Annual |
| `DiscountValue` | `double?` | Optional | Discount value to be applied to the List price or pump price. |
| `PricePerUnit` | `double?` | Optional | Price per unit after discount<br>Note: This field will not contain any value for discounts on retail prices. |
| `PricePerUnitAfterDiscount` | `double?` | Optional | Price per unit (List Price)<br>Note: This field will not contain any value for discounts on retail prices. |

## Example (as JSON)

```json
{
  "TierPriceListId": 46,
  "PriceListDescription": "PriceListDescription4",
  "TierMin": 186,
  "TierMax": 250,
  "TieredPricingGroupName": "TieredPricingGroupName2"
}
```

