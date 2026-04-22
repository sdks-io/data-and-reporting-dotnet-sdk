
# Card Type Response Customer Card Types Items

## Structure

`CardTypeResponseCustomerCardTypesItems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardTypeId` | `int?` | Optional | Card Type Id in Cards Platform. |
| `TokenTypeId` | `int?` | Optional | Token type identifier. |
| `CardTypeName` | `string` | Optional | Card Type Name. |
| `TokenTypeName` | `string` | Optional | Token Type Name. |
| `PANLength` | `int?` | Optional | PAN Length. |
| `ExpiryPeriod` | `int?` | Optional | Default Expiry period. |
| `IsNational` | `bool?` | Optional | True/False – Whether it is a National Card type or not. |
| `IsInternational` | `bool?` | Optional | True/False – Whether it is an International Card type or not. |
| `IsCRT` | `bool?` | Optional | True/False – Wether it is a CRT Card type or not. |
| `IsFleet` | `bool?` | Optional | True/False – Whether it is it a Fleet Card typeor not. |
| `IsShellSitesOnly` | `bool?` | Optional | True/False – Whether it is only allowed in Shell Stations or not. |
| `IsPartnerSitesIncluded` | `bool?` | Optional | True/False – Whether this card type is allowed in partner Stations. |
| `CanHavePIN` | `bool?` | Optional | True/False – Whether the cards of this card type can have PIN. |
| `IsVirtual` | `bool?` | Optional | True/False - Whether it is a Virtual Card type or not. |
| `IsActive` | `bool?` | Optional | Whether card type is active or not. |
| `IsCardAvailableForDownload` | `bool?` | Optional | Whether card type is available for download. |
| `ColCoCurrencyCode` | `string` | Optional | ISO currency code of the country. |
| `ColCoCurrencySymbol` | `string` | Optional | Currency symbol of the country. |
| `EMVContactless` | `bool?` | Optional | Is Europay, MasterCard, and Visa Contactless enabled or not. |
| `RFID` | `bool?` | Optional | Whether the card type is enabled for RFID (Radio Frequency Identification) |
| `PINChangeSupported` | `bool?` | Optional | PIN change supported or not. |
| `RequirePIN` | `bool?` | Optional | Whether a PIN is mandatory for the cards of this card type. |
| `OfflinePIN` | `bool?` | Optional | Whether offline PIN is enabled or not. |
| `MediumTypeID` | `int?` | Optional | Id of the medium type identifier. <br><br> Full list below - <br> 1 - Fuel Card <br> 2 - Fuel Card with EV <br> 3 - EV only  <br> 4 - Fuel Card and Key Fob <br> 5 - Key Fob <br> 6 - Virtual Card <br> 7 - NPII Token <br> 8 – Smartpay Token |
| `MediumType` | `string` | Optional | Name of the medium type identifier. <br><br> Full list below - <br> 1 - Fuel Card <br> 2 - Fuel Card with EV <br> 3 - EV only  <br> 4 - Fuel Card and Key Fob <br> 5 - Key Fob <br> 6 - Virtual Card <br> 7 - NPII Token <br> 8 – Smartpay Token |
| `CartTypeAccounts` | [`List<CartTypeAccount>`](../../doc/models/cart-type-account.md) | Optional | List of accounts. |
| `PurchaseCategories` | [`List<PurchaseCategories>`](../../doc/models/purchase-categories.md) | Optional | - |

## Example (as JSON)

```json
{
  "CardTypeId": 7077861,
  "TokenTypeId": 1234,
  "CardTypeName": "Philippines CRT",
  "TokenTypeName": "PH FLE NAT SIN R1",
  "PANLength": 12,
  "ExpiryPeriod": 30,
  "IsNational": true,
  "IsInternational": true,
  "IsCRT": true,
  "IsFleet": true,
  "IsShellSitesOnly": true,
  "IsPartnerSitesIncluded": true,
  "CanHavePIN": true,
  "IsVirtual": true,
  "IsActive": true,
  "IsCardAvailableForDownload": true,
  "ColCoCurrencyCode": "GBP",
  "ColCoCurrencySymbol": "£",
  "EMVContactless": true,
  "RFID": true,
  "PINChangeSupported": true,
  "RequirePIN": true,
  "OfflinePIN": true,
  "MediumTypeID": 8,
  "MediumType": "Smartpay Token"
}
```

