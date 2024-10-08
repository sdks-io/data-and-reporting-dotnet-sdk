
# Transaction Fees Request

## Structure

`TransactionFeesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoId` | `int?` | Optional | Collecting Company Id  of the selected payer.<br>Optional if ColCoCode is passed else Mandatory.<br>Example:<br>1 for Philippines<br>5 for UK |
| `ColCoCode` | `int?` | Optional | Collecting Company Code (Shell Code) of the selected payer.<br>Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.<br>Example:<br>86 for Philippines<br>5 for UK |
| `PayerId` | `int?` | Optional | Payer Id of the selected payer.<br>Optional if PayerNumber is passed else Mandatory<br>Example: 123456 |
| `PayerNumber` | `string` | Optional | Payer Number (Ex: GB000000123) of the selected payer.<br>Optional if PayerId is passed else Mandatory |
| `Accounts` | [`List<Accounts>`](../../doc/models/accounts.md) | Optional | - |
| `CardId` | `int?` | Optional | Card Id<br>Optional<br>When both Card Id and Card PAN are not present on request, the response will have all the fee items under the selected payer or account.<br>Example: 275549 |
| `CardPAN` | `string` | Optional | Full Card PAN<br>Optional<br>When both Card Id and Card PAN are not present on request, the response will have all the fee items under the selected payer or account or card group. |
| `InvoiceStatus` | `string` | Optional | Invoice status of the fee items<br>Mandatory<br>Possible options:<br>I - Invoiced<br>U – Un-Invoiced<br>A – All |
| `FeeTypeGroup` | `string` | Optional | Fee type group in under which the Fee item is generated.<br>Optional.<br>Allowed values:<br><br>- Account Charges<br>- Card Charges<br>- Others Charges |
| `FeeTypeId` | `int?` | Optional | Fee Type Id.<br>Optional.<br>Example:<br><br>1. Simple Fee<br>2. Card Event Fee<br>3. Customer Event Fee |
| `FromDate` | `string` | Optional | Fee Item FromDate/Time<br>Should be with in last 24 months<br>Optional<br>Maximum of 210 days duration allowed per search, its configurable.<br>Format: yyyyMMdd |
| `ToDate` | `string` | Optional | Fee Item To Date/Time<br>Optional<br>When blank and FromDate is provided on the input, all fee items took place after the given from date/time should be returned. Note that the search is allowed for the maximum of 60 days. Hence if the FromDate is older than 60 days from current date then the fee items for 60 days from FromDate will be returned.<br>Format: yyyyMMdd |
| `Period` | `int?` | Optional | Fee items Period. This is ignored when FromDate/Todate is supplied on the request.<br><br>1. Last 7 Days<br>2. Last 30 Days<br>3. Last 90 Days<br>4. Last 180 Days<br>   Example : Pass 1 for Last 7 days fee items |
| `IncludeCancelledItems` | `bool?` | Optional | True or False. When True, cancelled fee items are included on API response |
| `ProductId` | `int?` | Optional | Product Id<br>Optional<br>Example: Sample list of product ids and description.<br>100    Service fee<br>102    Invoice production fee<br>103    Account fee<br>104    Transaction fee<br>105    Card membership fee |
| `ProductCode` | `string` | Optional | Product Code<br>Optional<br>Example:<br><br>1. Service fee<br>2. Invoice production fee<br>3. Account fee<br>4. Transaction fee<br>5. Card membership fee |
| `LineItemDescription` | `string` | Optional | Line item description.<br>Optional<br>Minimum of 4 characters should be provided else not considered<br>Those fee items that have the entered value at any part of the line item description will be returned. |
| `SortOrder` | `string` | Optional | Allowed Sorting Options:<br>•    FeeDateAscending<br>•    FeeDateDescending<br>•    NetAmountAscending<br>•    NetAmountDescending<br>Optional.<br>Default: 1 |
| `CurrentPage` | `int?` | Optional | Page Number |
| `PageSize` | `int?` | Optional | Page Size – Number of records to show on a page |

## Example (as JSON)

```json
{
  "ColCoId": 154,
  "ColCoCode": 168,
  "PayerId": 202,
  "PayerNumber": "PayerNumber6",
  "Accounts": [
    {
      "AccountId": 28,
      "AccountNumber": "AccountNumber0"
    }
  ]
}
```

