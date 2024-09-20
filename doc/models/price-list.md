
# Price List

## Structure

`PriceList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Date` | `string` | Optional | Date on which the price is applicable.<br>Format: yyyyMMdd<br>E.g.: 20180131 |
| `Day` | `string` | Optional | Day on which the price is applicable.<br>E.g.: Sunday, Monday etc. |
| `Type` | `string` | Optional | Price list type.<br>E.g., List, Shell Standard International List |
| `PriceListId` | `int?` | Optional | Price list ID |
| `PriceListDescription` | `string` | Optional | Price list description<br>E.g., UK Fuels CRT Reseller List Price |
| `PriceRuleId` | `int?` | Optional | Price Rule Id |
| `PriceRuleName` | `string` | Optional | Price Rule Name |
| `DelCoId` | `int?` | Optional | DelCo Id |
| `CountryCode` | `string` | Optional | Country ISO Code<br>E.g., UK, NL, etc., |
| `Country` | `string` | Optional | Country<br>E.g., United Kingdom, Netherlands etc |
| `ProductGroupId` | `int?` | Optional | Product Group Id |
| `ProductGroupName` | `string` | Optional | Product Group name |
| `ProductCode` | `string` | Optional | Client Product Code |
| `ProductId` | `int?` | Optional | Product Id |
| `ProductName` | `string` | Optional | Product name in English |
| `PricePerUnit` | `double?` | Optional | Price per unit |
| `CurrencyCode` | `string` | Optional | Currency Code.<br>Format : 3 digit ISO code |
| `CurrencySymbol` | `string` | Optional | Currency Symbol<br>Example: £ |
| `PriceType` | `string` | Optional | Price Type<br>Possible Values are:<br>•    Country– Price rule defined at country whereas Price Rule DelcoId same as ColcoId.<br>•    TPNDelcoPrice – Price rule defined in the TPN whereas Price Rule DelcoId is different from ColcoId.<br>•    NetworkPrice – Price rule defined at Fuel Network level.<br>•    Other – Price rule defined at either Site or SiteGroup level. |
| `SiteGroupId` | `int?` | Optional | Site-Group ID<br>E.g.: 100007 |
| `SiteGroupName` | `string` | Optional | Site-Group name |
| `SiteCode` | `int?` | Optional | Site Code |
| `SiteId` | `int?` | Optional | Site ID |
| `SiteName` | `string` | Optional | Site Name |
| `FuelNetworkId` | `int?` | Optional | Fuel Network ID |
| `NetworkName` | `string` | Optional | Network Name |
| `PriceRuleDelcoId` | `int?` | Optional | PriceRuleDelcoId |
| `PriceRuleDelcoName` | `string` | Optional | Company Name of the price rule DelCo.<br><br>E.g.:<br>•    Pilipinas Shell Petroleum Corp<br>•    Shell U.K. Oil Products Limited<br>•    G & V SERVICE STATIONS NV |
| `PriceRuleCountry` | `string` | Optional | PriceRuleCountry<br>E.g.: United Kingdom |
| `PriceRuleCountryCode` | `string` | Optional | ISO Code of PriceRuleCountry<br>E.g.: UK, NL, etc., |
| `PriceRuleBasisId` | `int?` | Optional | PriceRuleBasisId |
| `DiscountValue` | `double?` | Optional | Discount value |
| `PricePerUnitAfterDiscount` | `double?` | Optional | Price per unit after discount |
| `VATPercentage` | `double?` | Optional | VAT Percentage |
| `PriceRuleCategoryId` | `int?` | Optional | PriceRuleCategoryId |
| `Tiers` | [`List<Tier>`](../../doc/models/tier.md) | Optional | - |

## Example (as JSON)

```json
{
  "Date": "Date8",
  "Day": "Day4",
  "Type": "Type0",
  "PriceListId": 210,
  "PriceListDescription": "PriceListDescription0"
}
```

