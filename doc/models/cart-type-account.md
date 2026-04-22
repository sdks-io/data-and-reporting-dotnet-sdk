
# Cart Type Account

## Structure

`CartTypeAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `int?` | Optional | Account Id of the customer. |
| `AccountNumber` | `string` | Optional | Account Number of the customer. |
| `IsDefault` | `bool?` | Optional | Whether card type is default or not. |
| `CustomerCardTypeId` | `int?` | Optional | Customer Card Type Id in Cards Platform. |
| `IsVisibleToCustomers` | `bool?` | Optional | True/False – Whether the card type can be used for card ordering. <br><br> Note - IsVisibleToCustomers will be set as ‘false’ when the card type is not active or. configured in MS to be not visible. |
| `EmbossAccountName` | `string` | Optional | Default Name to be embossed on the card. |
| `DefaultPurchaseCategoryId` | `int?` | Optional | Default Purchase category of the card type. |
| `UsageRestrictions` | [`CardUsageRestrictions`](../../doc/models/card-usage-restrictions.md) | Optional | - |
| `DayTimeRestrictions` | [`CardDayTimeRestrictions`](../../doc/models/card-day-time-restrictions.md) | Optional | - |

## Example (as JSON)

```json
{
  "AccountId": 1234,
  "AccountNumber": "GB000000123",
  "IsDefault": true,
  "CustomerCardTypeId": 1,
  "IsVisibleToCustomers": true,
  "EmbossAccountName": "abcd1234",
  "DefaultPurchaseCategoryId": 34
}
```

