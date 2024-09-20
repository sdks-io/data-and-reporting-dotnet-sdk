
# Filters

## Structure

`Filters`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ColCoCode` | `string` | Required | Collecting Company Code (Shell Code) of the selected payer. |
| `InvoiceStatus` | `object` | Required | - |
| `PayerNumber` | `string` | Required | Payer Number of the selected payer.<br>**Constraints**: *Minimum Length*: `1` |
| `AccountId` | `int?` | Optional | Account Id (GFN customer id) |
| `AccountNumber` | `string` | Optional | Account Number of the selected account. |
| `DriverName` | `string` | Optional | Driver Name (of Card record)<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `40` |
| `CardGroupId` | `int?` | Optional | Card Group Id in GFN |
| `CardPAN` | `string` | Optional | Full Card PAN |
| `ProductCode` | `string` | Optional | Product Code – Global as per GFN configuration<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `8` |
| `ProductName` | `string` | Optional | Product Name – Global as per GFN configuration<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `128` |
| `SiteCode` | `string` | Optional | Site Code in GFN<br>**Constraints**: *Minimum Length*: `8`, *Maximum Length*: `87` |
| `IncomingSiteNumber` | `string` | Optional | Site Code as configured in GFN<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `10` |
| `InvoiceDate` | `string` | Optional | Returns the billed transaction for the given invoice date |
| `InvoiceNumber` | `string` | Optional | Returns the billed transaction for the given invoice number<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `10` |
| `PurchasedInCountryCode` | `string` | Optional | Purchased InCountryCode<br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `2` |
| `PurchasedInCountry` | `string` | Optional | Network Delco PurchasedCountryName |
| `SiteGroupId` | `int?` | Optional | Site Group Id in GFN |
| `VehicleRegistrationNumber` | `string` | Optional | Vehicle Registration (of Card record)<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `128` |
| `FeeTypeId` | `int?` | Optional | Card Id (i.e. Unique Card Id in GFN) |
| `LineItemDescription` | `string` | Optional | Item identifier in the transaction.<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `128` |
| `Cards` | `List<int>` | Optional | This entity accepts the list of CardId to filter in the response.<br>Note: The number of cardId allowed to be passed in the request is configurable to a maximum of 500 cards.<br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `500` |
| `SortOrder` | [`PricedTransactionReqV2SortOrderEnum?`](../../doc/models/priced-transaction-req-v2-sort-order-enum.md) | Optional | **Constraints**: *Minimum Length*: `1`, *Maximum Length*: `1` |
| `FromDate` | `string` | Optional | From transaction delivery date<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `19` |
| `ToDate` | `string` | Optional | To transaction delivery date<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `19` |
| `Period` | [`PricedTransactionReqV2PeriodEnum?`](../../doc/models/priced-transaction-req-v2-period-enum.md) | Optional | - |
| `PostingDateFrom` | `string` | Optional | Transaction posting start date and time<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `19` |
| `PostingDateTo` | `string` | Optional | Transaction posting end date and time<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `19` |
| `TransactionItemId` | `string` | Optional | Unique id of the transaction that may include one or more salesitems |
| `FuelOnly` | `bool?` | Optional | Is FuelOnly indicator<br>**Default**: `false` |
| `IncludeFees` | `bool?` | Optional | When passed as ‘true’ then all sales items along with fees will be included in the response and the follwoing filteres will be ignored<br><br>* InvoiceNumber<br>* InvoiceDate<br>* PostingDateFrom<br>* PostingDateTo |
| `IsMultipayer` | `bool?` | Optional | If true then returns all the data linked tothe payer group of the provided PayerNumberin the request |
| `ValidInvoiceDateOnly` | `bool?` | Optional | When passed as ‘True’ the transactions records with report date not equal to 9999-12-30 will be returned. When passed as ‘False’ the above condition will not be checked.<br>**Default**: `false` |
| `InvoiceFromDate` | `string` | Optional | Invoice From Date, this is a search criterion to filter invoiced transactions with invoice date from this date.<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `19` |
| `InvoiceToDate` | `string` | Optional | Invoice To Date, this is a search criterion to filter invoiced transactions with invoice date until this date.<br>**Constraints**: *Minimum Length*: `10`, *Maximum Length*: `19` |
| `HostingCollectingCompanyNumber` | `string` | Optional | Hosting Collecting Company Number of the selected payer. |
| `Search` | `string` | Optional | Search based on DriverName or VRN |
| `TransactionId` | `string` | Optional | Unique id of the transaction that may include one or more salesitems |

## Example (as JSON)

```json
{
  "ColCoCode": "032",
  "InvoiceStatus": {
    "key1": "val1",
    "key2": "val2"
  },
  "PayerNumber": "DE26685263",
  "AccountId": 29484,
  "AccountNumber": "DE26667080",
  "DriverName": "HH NX 508",
  "CardGroupId": 40000,
  "CardPAN": "7002051006629890645",
  "ProductCode": "10",
  "ProductName": "Diesel AGO",
  "SiteCode": "05000100",
  "IncomingSiteNumber": "100021",
  "InvoiceDate": "2022-01-01 00:00:00",
  "InvoiceNumber": "3201016193",
  "PurchasedInCountryCode": "GB",
  "PurchasedInCountry": "United Kingdom",
  "SiteGroupId": 202,
  "FeeTypeId": 275549,
  "LineItemDescription": "ABC3",
  "FromDate": "2022-01-01 00:00:00",
  "ToDate": "2022-01-01 00:00:00",
  "PostingDateFrom": "2022-01-01 00:00:00",
  "PostingDateTo": "2022-01-01 00:00:00",
  "TransactionItemId": "io9KVXk1UkW57XWKyeaHHg",
  "FuelOnly": false,
  "ValidInvoiceDateOnly": false,
  "InvoiceFromDate": "2022-01-01 00:00:00",
  "InvoiceToDate": "2022-01-01 00:00:00",
  "HostingCollectingCompanyNumber": "032",
  "Search": "2K89909",
  "TransactionId": "io9KVXk1UkW57XWKyeaHHg"
}
```

