# Transaction

APIs for Retrieve Transaction details about the shell cards

```csharp
TransactionController transactionController = client.TransactionController;
```

## Class Name

`TransactionController`

## Methods

* [Priced Transactions](../../doc/controllers/transaction.md#priced-transactions)
* [Priced Transactions Summary](../../doc/controllers/transaction.md#priced-transactions-summary)
* [Multipriced Transactions](../../doc/controllers/transaction.md#multipriced-transactions)
* [Card Usage Summary](../../doc/controllers/transaction.md#card-usage-summary)
* [Volume Based Bonus](../../doc/controllers/transaction.md#volume-based-bonus)
* [Volume Based Pricing](../../doc/controllers/transaction.md#volume-based-pricing)
* [Fees](../../doc/controllers/transaction.md#fees)
* [Fee Summary Response](../../doc/controllers/transaction.md#fee-summary-response)
* [Fuel Consumption](../../doc/controllers/transaction.md#fuel-consumption)
* [Update Odometer](../../doc/controllers/transaction.md#update-odometer)
* [Transaction Exceptions](../../doc/controllers/transaction.md#transaction-exceptions)
* [Recent Transactions New](../../doc/controllers/transaction.md#recent-transactions-new)
* [Priced Transactions V2](../../doc/controllers/transaction.md#priced-transactions-v2)


# Priced Transactions

This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria and supports paging.

Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.

#### Supported operations

* Get sales items and fee transactions
  * Search by invoice status
  * Search by fixed date period
  * Search by date range
  * Search by account
  * Search by card
* Get sales items only
  * Search by transaction Id or location
  * Search by transaction posting date
  * Search by invoice number or date
  * Search by driver name or vehicle registration number
  * Search by card group
  * Search by fuel only transactions
  * Search by product

This API fetches transactions for a period based on the below parameters and priority order:

1. InvoiceNumber
2. InvoiceDate
3. FromDate, ToDate
4. PostingFromDate, PostingToDate (Can be used only when IncludeFees = false)
5. InvoiceDateFrom, InvoiceDateTo
6. Period

This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.

If none of the above parameters are provided then last 7 days transactions will be fetched.

This operation can fetch transactions that are old up to 24 (configurable) months. However, the date range between any of the ‘From’ and ‘To’ dates in the above combination cannot be more than 210 (configurable) days.

```csharp
PricedTransactionsAsync(
    string apikey,
    string requestId,
    Models.PriceTransactionRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`PriceTransactionRequest`](../../doc/models/price-transaction-request.md) | Body, Optional | Priced Transaction Request Body |

## Response Type

[`Task<Models.PricedTransactionResponse>`](../../doc/models/priced-transaction-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
PriceTransactionRequest body = new PriceTransactionRequest
{
    ColCoCode = 5,
    PayerNumber = "GB00000001",
    InvoiceStatus = "A",
    FromDate = "20230703",
    ToDate = "20231002",
    IncludeFees = true,
    CurrentPage = 1,
    PageSize = 2000,
};

try
{
    PricedTransactionResponse result = await transactionController.PricedTransactionsAsync(
        apikey,
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "Transactions": [
    {
      "AccountId": 2,
      "AccountName": "API Transaction Customer Testing ",
      "AccountNumber": "GB00000001",
      "AccountShortName": "API Transaction Customer Testing ",
      "Additional1": "",
      "Additional2": "",
      "Additional3": "",
      "Additional4": "",
      "AllowClearing": "",
      "AuthorisationCode": "",
      "CardExpiry": null,
      "CardExpiryPeriod": "",
      "CardGroupId": "",
      "CardGroupName": "",
      "CardId": null,
      "CardPAN": "",
      "CardSequenceNumber": "",
      "CardType": "",
      "CheckDigit": "",
      "ColCoExchangeRate": 0.840303,
      "CorrectionFlag": "N",
      "CreditDebitCode": "C",
      "CRMNumber": "",
      "CustomerCountry": "United Kingdom",
      "CustomerCountryCode": "GB",
      "CustomerCurrencyCode": "GBP",
      "CustomerCurrencySymbol": "£",
      "CustomerRetailPriceUnitGross": null,
      "CustomerRetailValueTotalGross": null,
      "CustomerRetailValueTotalNet": null,
      "DelcoCode": "005",
      "DelCoExchangeRate": null,
      "DelcoListPriceUnitNet": null,
      "DelcoName": "Shell U.K. Oil Products Limited",
      "DelcoRetailPriceUnitNet": null,
      "DelCoToColCoExchangeRate": null,
      "DelcoRetailPriceUnitGross": null,
      "DelcoRetailValueTotalNet": null,
      "DelcoRetailValueTotalGross": null,
      "DiscountType": "",
      "DisputeStatus": "",
      "DriverName": "",
      "EffectiveDiscountInCustomerCurrency": null,
      "EffectiveDiscountInTrxCurrency": null,
      "EffectiveUnitDiscountInCustomerCurrency": null,
      "EuroRebateAmount": null,
      "EuroVATAmount": null,
      "FleetIDDescription": "",
      "FleetIdInput": "",
      "FuelProduct": false,
      "IncomingCurrencyCode": "",
      "IncomingProductCode": "1",
      "IncomingSiteDescription": "",
      "IncomingSiteNumber": "",
      "InvoiceCurrencyCode": "GBP",
      "InvoiceCurrencySymbol": "£",
      "InvoiceDate": "20230720 00:00:00",
      "InvoiceGrossAmount": -150,
      "InvoiceNetAmount": -150,
      "InvoiceNumber": "3200009606",
      "InvoiceTax": 0,
      "IsInvoiced": true,
      "IsShellSite": null,
      "IssuerCode": "",
      "Location": [
        {
          "Latitude": "",
          "Longitude": ""
        }
      ],
      "NetEuroAmount": null,
      "NetInvoiceIndicator": "",
      "Network": "",
      "NetworkCode": "",
      "OdometerInput": null,
      "OriginalSalesItemId": "",
      "ParentCustomerId": null,
      "ParentCustomerName": "",
      "ParentCustomerNumber": "",
      "PayerGroup": "25",
      "PayerGroupName": "11607315 - EAST CITY TRADING",
      "PayerName": "API Transaction Customer Testing ",
      "PayerNumber": "GB00000001",
      "PINIndicator": "",
      "PostingDate": "20230720 10:31:14",
      "ProductCode": "1",
      "ProductGroupId": 23,
      "ProductGroupName": "Monetary Adjustment",
      "ProductName": "Bonus National",
      "PurchasedInCountry": "",
      "PurchasedInCountryCode": "",
      "Quantity": -3,
      "RebateonNetAmountInCustomerCurrency": null,
      "RebateonNetAmountInTransactionCurrency": null,
      "RebateRate": null,
      "ReceiptNumber": "31455",
      "RefundFlag": "",
      "ReleaseCode": "",
      "SalesItemId": 31455,
      "SiteCode": "",
      "SiteCountry": "",
      "SiteGroupId": null,
      "SiteGroupName": "",
      "SiteName": "",
      "TransactionCurrencyCode": "GBP",
      "TransactionCurrencySymbol": "£",
      "TransactionDate": "20230720",
      "TransactionGrossAmount": -150,
      "TransactionId": "",
      "TransactionLine": "",
      "TransactionNetAmount": -150,
      "TransactionStatus": "I",
      "TransactionTax": 0,
      "TransactionTime": "00:00:00",
      "TransactionType": "",
      "TransactionTypeDescription": "",
      "TrnIdentifier": "0531455",
      "Type": "FeeItem",
      "UnitDiscountInvoiceCurrency": null,
      "UnitDiscountTransactionCurrency": null,
      "UnitPriceInInvoiceCurrency": null,
      "UnitPriceInTransactionCurrency": null,
      "UTCOffset": "",
      "VATApplicable": "N",
      "VATCategory": "89",
      "VATCountry": "United Kingdom",
      "VATonNetAmount": 0,
      "VATonNetAmountInCustomerCurrency": 0,
      "VATRate": 0,
      "VehicleRegistration": ""
    }
  ],
  "CurrentPage": 1,
  "RowCount": 3515,
  "TotalPages": 3515,
  "Error": {
    "Code": "0000",
    "Description": "Success"
  },
  "RequestId": "9c22ffa0-81aa-4e04-c90d-81f1e6a48e9c"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionPricedtransactions400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactions-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionPricedtransactions401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactions-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionPricedtransactions403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactions-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionPricedtransactions404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactions-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionPricedtransactions500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactions-500-error-exception.md) |


# Priced Transactions Summary

This API returns the transaction summary data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria.
The API also supports returning Fee Items. Transactions posted for fee items that are in error are not included in the summary.

The endpoint supports the exact same search criteria as the endpoint *transaction/prciedtransactions*.

#### Supported operations

* Get sales items and fee transactions
  * Search by invoice status
  * Search by fixed date period
  * Search by date range
  * Search by account
  * Search by card
* Get sales items only
  * Search by transaction Id or location
  * Search by transaction posting date
  * Search by invoice number or date
  * Search by driver name or vehicle registration number
  * Search by card group
  * Search by fuel only transactions
  * Search by product

This API fetches transactions for a period based on the below parameters and priority order:

1. InvoiceNumber
2. InvoiceDate
3. FromDate, ToDate
4. PostingFromDate, PostingToDate (Can be used only when IncludeFees = false)
5. InvoiceDateFrom, InvoiceDateTo
6. Period

This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.

If none of the above parameters are provided then last 7 days transactions will be fetched.

```csharp
PricedTransactionsSummaryAsync(
    string apikey,
    string requestId,
    Models.PriceTransSummaryRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`PriceTransSummaryRequest`](../../doc/models/price-trans-summary-request.md) | Body, Optional | PricedSummary RequestBody |

## Response Type

[`Task<Models.PricedTransSummaryResponse>`](../../doc/models/priced-trans-summary-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
PriceTransSummaryRequest body = new PriceTransSummaryRequest
{
    ColCoId = 1,
    ColCoCode = 86,
    PayerId = 123456,
    PayerNumber = "GB000000123",
    CardId = 275549,
    CardPAN = "7002051006629890645",
    DriverName = "MICHAEL",
    VehicleRegistrationNumber = "A144",
    InvoiceStatus = "I",
    ProductId = 21,
    ProductCode = "10",
    PurchasedInCountry = "UK",
    CardGroupId = 5,
    FromDate = "20210718",
    ToDate = "20210818",
    Period = 1,
    SiteCode = "050001",
    SiteGroupId = 202,
    PostingDateFrom = "20210820 13:23:55",
    PostingDateTo = "20210821 13:23:55",
    SalesItemId = "18315958002",
    TransactionId = "XXyUwr03Ek20s3LD_890UY",
    InvoiceDate = "20210821",
    InvoiceNumber = "AT5456",
    ValidInvoiceDateOnly = true,
    InvoiceFromDate = "20210821",
    InvoiceToDate = "20210921",
    FuelOnly = true,
    IncludeFees = true,
};

try
{
    PricedTransSummaryResponse result = await transactionController.PricedTransactionsSummaryAsync(
        apikey,
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "TransactionsSummary": [
    {
      "ProductId": 0,
      "ProductCode": "10",
      "ProductName": "Unleaded - High octane",
      "ProductGroupId": 2,
      "ProductGroupName": "All Fuels",
      "SiteGroupId": 202,
      "SiteGroupName": "CZ 9100 ECONOMY NETWORK",
      "TotalFuelQuantity": 0,
      "TotalNetAmount": 0,
      "TotalGrossAmount": 0,
      "InvoiceCurrencyCode": "GBP",
      "InvoiceCurrencySymbol": "$",
      "CustomerRetailValueTotalNet": 21.9,
      "CustomerRetailValueTotalGross": 23.5
    }
  ],
  "Error": {
    "Description": "Success",
    "Code": "0000"
  },
  "RequestId": "ed557f02-c7d7-4c01-b3e5-11bf3239c8ed"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionPricedtransactionssummary400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactionssummary-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionPricedtransactionssummary401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactionssummary-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionPricedtransactionssummary403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactionssummary-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionPricedtransactionssummary404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactionssummary-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionPricedtransactionssummary500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-pricedtransactionssummary-500-error-exception.md) |


# Multipriced Transactions

This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items) for multiple payers. It provides a flexible search criteria and supports paging.

Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.

At least one payer should be provided. Multiple payers must belong to the same payer group.

#### Supported operations

* Get sales items and fee transactions for multiple payers
  * Search by invoice status
  * Search by fixed date period
  * Search by date range
* Get sales items only for multiple payers
  * Search by transaction location
  * Search by transaction posting date
  * Search by invoice number or date
  * Search by fuel only transactions

This API fetches transactions for a period based on the below parameters and priority order:

1. InvoiceNumber
2. InvoiceDate
3. FromDate, ToDate
4. PostingFromDate, PostingToDate (Can be used only when IncludeFees = false)
5. InvoiceDateFrom, InvoiceDateTo
6. Period

This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.

If none of the above parameters are provided then last 7 days transactions will be fetched.

```csharp
MultipricedTransactionsAsync(
    string apikey,
    string requestId,
    Models.MultiPricedTransactionRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`MultiPricedTransactionRequest`](../../doc/models/multi-priced-transaction-request.md) | Body, Optional | MultiPayer RequestBody |

## Response Type

[`Task<Models.MultiPricedTransactionResponse>`](../../doc/models/multi-priced-transaction-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
MultiPricedTransactionRequest body = new MultiPricedTransactionRequest
{
    ColCoCode = 86,
    Accounts = new List<MultiPricedTransactionRequestAccountsItems>
    {
        new MultiPricedTransactionRequestAccountsItems
        {
            PayerId = 123456,
            PayerNumber = "GB000000123",
            AccountId = 123456,
            AccountNumber = "GB000000123",
        },
    },
    ColCoId = 1,
    InvoiceStatus = "I",
    PurchasedInCountry = "UK",
    FromDate = "20210814",
    ToDate = "20210814",
    Period = 1,
    PostingDateFrom = "20210325 06:46:07",
    PostingDateTo = "20210325 06:46:07",
    InvoiceDate = "20210325",
    InvoiceNumber = "8716711",
    ValidInvoiceDateOnly = true,
    InvoiceFromDate = "20210325",
    InvoiceToDate = "20210325",
    FuelOnly = true,
    IncludeFees = true,
    SortOrder = "1,3,6",
    CurrentPage = 1,
    PageSize = 50,
};

try
{
    MultiPricedTransactionResponse result = await transactionController.MultipricedTransactionsAsync(
        apikey,
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "Transactions": [
    {
      "Type": "SalesItem",
      "CardId": 275549,
      "CardPAN": "7002051006629890645",
      "CardExpiry": "20210921",
      "TransactionDate": "20210921",
      "TransactionTime": "04:26:34",
      "UTCOffset": "+08:00:00",
      "FleetIdInput": "XYZ1234",
      "OdometerInput": 12345,
      "DriverName": "ANDREW GILBERRY",
      "VehicleRegistration": "MV65YLH",
      "InvoiceCurrencyCode": "GBP",
      "InvoiceCurrencySymbol": "Ã‚Â£",
      "TransactionCurrencyCode": "GBP",
      "TransactionCurrencySymbol": "Ã‚Â£",
      "TransactionNetAmount": 674,
      "TransactionTax": 0,
      "TransactionGrossAmount": 0,
      "InvoiceNetAmount": 0,
      "InvoiceTax": 0,
      "InvoiceGrossAmount": 0,
      "PurchasedInCountry": "France, Germany",
      "AccountId": 29484,
      "AccountNumber": "GB99215176",
      "AccountName": "MA LIMITED",
      "AccountShortName": "MAL",
      "Quantity": 1,
      "FuelProduct": true,
      "UnitPriceInTransactionCurrency": 12,
      "UnitPriceInInvoiceCurrency": 13,
      "UnitDiscountTransactionCurrency": 1,
      "UnitDiscountInvoiceCurrency": 2,
      "IsInvoiced": true,
      "InvoiceNumber": "S04500493",
      "InvoiceDate": "20211001 13:23:55",
      "SiteCode": "050001",
      "SiteName": "CHARNOCK RICHARD NTHBOUND MWSA 0755",
      "SiteCountry": "France",
      "Location": [
        {
          "Latitude": "37.4224764",
          "Longitude": "-122.0842499"
        }
      ],
      "CardGroupName": "006240 FIRE BRIGHT SOLUTIONS",
      "ReceiptNumber": "01234",
      "ProductCode": "10",
      "ProductName": "TMF Charges",
      "ProductGroupId": 2,
      "ProductGroupName": "All Fuels",
      "DelCoExchangeRate": 2.23,
      "ColCoExchangeRate": 2,
      "IsShellSite": true,
      "Network": "100016  ESSO BE",
      "SiteGroupId": 202,
      "SiteGroupName": "CZ 9100 ECONOMY NETWORK",
      "PostingDate": "20181001 13:23:55",
      "IssuerCode": "7002",
      "PurchasedInCountryCode": "NL",
      "CustomerCountryCode": "NL",
      "CustomerCountry": "Netherlands",
      "ReleaseCode": "8",
      "CardGroupId": "A12",
      "CardSequenceNumber": "002",
      "CheckDigit": "2",
      "FleetIDDescription": "A51617HAGH",
      "VATRate": 0.2,
      "VATCategory": "1",
      "VATCountry": "Netherlands",
      "EffectiveDiscountInTrxCurrency": 0.2,
      "TransactionType": "ODP",
      "PINIndicator": "Y",
      "VATApplicable": "Y",
      "NetInvoiceIndicator": "N",
      "CustomerCurrencyCode": "GBP",
      "CustomerCurrencySymbol": "$",
      "EffectiveUnitDiscountInCustomerCurrency": 23,
      "EffectiveDiscountInCustomerCurrency": 32,
      "VATonNetAmountInCustomerCurrency": 12,
      "DiscountType": "1",
      "TransactionStatus": "U",
      "SalesItemId": 18315958002,
      "PayerGroup": "12119008",
      "PayerGroupName": "SHELL GROUP OF COMPANIES",
      "RefundFlag": "N",
      "OriginalSalesItemId": "A1256",
      "DelcoName": "SHELL NEDERLAND VERKOOPMAATSCHAPPIJ BV",
      "DelcoCode": "014",
      "PayerNumber": "PH50000843",
      "PayerName": "PARKLEY & CO",
      "CardExpiryPeriod": "1901",
      "AuthorisationCode": "011256",
      "TransactionId": "io9KVXk1UkW57XWKyeaHHg",
      "TransactionLine": "1",
      "AllowClearing": "Y",
      "CRMNumber": "CR1234",
      "DisputeStatus": "4",
      "RebateRate": 28.279,
      "DelCoToColCoExchangeRate": 1,
      "NetEuroAmount": 37.93,
      "EuroRebateAmount": 0,
      "EuroVATAmount": 7.96,
      "ParentCustomerNumber": "12121",
      "ParentCustomerName": "MICHAEL",
      "ParentCustomerId": 7121121,
      "IncomingSiteNumber": "100021",
      "IncomingSiteDescription": "HN3 INTI_02-82.02",
      "IncomingCurrencyCode": "GBP",
      "IncomingProductCode": "30",
      "CreditDebitCode": "D",
      "CorrectionFlag": "N",
      "Additional1": "Additional Data",
      "Additional2": "Additional Data",
      "Additional3": "Additional Data",
      "Additional4": "Additional Data",
      "RebateonNetAmountInCustomerCurrency": 0.735,
      "RebateonNetAmountInTransactionCurrency": 0.735,
      "NetworkCode": "AVEE PTUAZONW CUBFAO COSFS",
      "TrnIdentifier": "A1234",
      "CardType": "A1234",
      "DelcoListPriceUnitNet": 30.5,
      "DelcoRetailPriceUnitNet": 1.921,
      "DelcoRetailPriceUnitGross": 1.921,
      "DelcoRetailValueTotalNet": 1.921,
      "DelcoRetailValueTotalGross": 1.921,
      "CustomerRetailPriceUnitGross": 1.921,
      "CustomerRetailValueTotalGross": 1.921,
      "CustomerRetailValueTotalNet": 1.921,
      "TransactionTypeDescription": "A12"
    }
  ],
  "Error": {
    "Description": "Success",
    "Code": "0000"
  },
  "RequestId": "ed557f02-c7d7-4c01-b3e5-11bf3239c8ed",
  "CurrentPage": 10,
  "RowCount": 100,
  "TotalPages": 10
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionMultipayerspricedtransactions400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-multipayerspricedtransactions-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionMultipayerspricedtransactions401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-multipayerspricedtransactions-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionMultipayerspricedtransactions403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-multipayerspricedtransactions-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionMultipayerspricedtransactions404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-multipayerspricedtransactions-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionMultipayerspricedtransactions500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-multipayerspricedtransactions-500-error-exception.md) |


# Card Usage Summary

This operation is to provide the expenditure analysis for a card for the past 7 months.
The response contains a daily summary of the transactions (billed & unbilled) from 1st of the last 7 months for the requested card grouped by card, site-group and product.

```csharp
CardUsageSummaryAsync(
    string apikey,
    string requestId,
    Models.CardUsageSummaryRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`CardUsageSummaryRequest`](../../doc/models/card-usage-summary-request.md) | Body, Optional | Card Usage Summary RequestBody |

## Response Type

[`Task<Models.CardUsageSummaryResponse>`](../../doc/models/card-usage-summary-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
try
{
    CardUsageSummaryResponse result = await transactionController.CardUsageSummaryAsync(
        apikey,
        requestId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionCardusagesummary400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-cardusagesummary-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionCardusagesummary401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-cardusagesummary-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionCardusagesummary403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-cardusagesummary-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionCardusagesummary404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-cardusagesummary-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionCardusagesummary500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-cardusagesummary-500-error-exception.md) |


# Volume Based Bonus

- This API provides the details of the bonus and/or association bonus rules setup for the given payer and that are active on the current date.
- This API also returns the details of the monthly breakup of current period consumption as well as the details of the previously calculated bonus and consumption of the applicable payers.

```csharp
VolumeBasedBonusAsync(
    string apikey,
    string requestId,
    Models.VolumeBasedBonusRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`VolumeBasedBonusRequest`](../../doc/models/volume-based-bonus-request.md) | Body, Optional | VolumeBasedBonus RequestBody |

## Response Type

[`Task<Models.VolumeBasedBonusResponse>`](../../doc/models/volume-based-bonus-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
try
{
    VolumeBasedBonusResponse result = await transactionController.VolumeBasedBonusAsync(
        apikey,
        requestId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionVolumebasedbonus400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedbonus-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionVolumebasedbonus401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedbonus-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionVolumebasedbonus403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedbonus-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionVolumebasedbonus404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedbonus-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionVolumebasedbonus500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedbonus-500-error-exception.md) |


# Volume Based Pricing

- This API will return the details of the in arrear fee rule applied to the payer along with details of locations, products, tiers as applied.
- It will also show historical and current volume consumption and related tier applied for the following month.

```csharp
VolumeBasedPricingAsync(
    string apikey,
    string requestId,
    Models.VolumeBasedPricingRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`VolumeBasedPricingRequest`](../../doc/models/volume-based-pricing-request.md) | Body, Optional | VolumeBasedPricing RequestBody |

## Response Type

[`Task<Models.VolumeBasedPricingResponse>`](../../doc/models/volume-based-pricing-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
try
{
    VolumeBasedPricingResponse result = await transactionController.VolumeBasedPricingAsync(
        apikey,
        requestId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionVolumebasedpricing400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedpricing-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionVolumebasedpricing401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedpricing-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionVolumebasedpricing403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedpricing-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionVolumebasedpricing404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedpricing-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionVolumebasedpricing500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-volumebasedpricing-500-error-exception.md) |


# Fees

This API returns the fee/charges levied from a  customer's account in a billing period or date range. The API returns both billed and unbilled fee items.

To get the summary of charges, the endpoint *transaction/feessummary* should be called with the same input criteria.

#### Supported operations

* Get fees by invoice status
* Get fees by date period
* Get fees by account
* Get fees by card Id or PAN
* Get fees by fee type charges
* Get fees including cancelled items
* Get fees by line item description
* Get fees by product

```csharp
FeesAsync(
    string apikey,
    string requestId,
    Models.TransactionFeesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`TransactionFeesRequest`](../../doc/models/transaction-fees-request.md) | Body, Optional | Transaction Fees RequestBody |

## Response Type

[`Task<Models.TransactionFeesResponse>`](../../doc/models/transaction-fees-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
TransactionFeesRequest body = new TransactionFeesRequest
{
    ColCoId = 1,
    ColCoCode = 86,
    PayerId = 123456,
    PayerNumber = "GB000000123",
    CardId = 275549,
    CardPAN = "7002051006629890645",
    InvoiceStatus = "I",
    FeeTypeGroup = "Account Charges",
    FeeTypeId = 1,
    FromDate = "20210823",
    ToDate = "20210823",
    Period = 1,
    IncludeCancelledItems = true,
    ProductId = 100,
    ProductCode = "102",
    LineItemDescription = "string",
    SortOrder = "1",
    CurrentPage = 1,
    PageSize = 50,
};

try
{
    TransactionFeesResponse result = await transactionController.FeesAsync(
        apikey,
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "FeeItems": [
    {
      "FeeItemId": 1234,
      "AccountId": 29484,
      "AccountNumber": "GB99215176",
      "AccountShortName": "GB123",
      "InvoiceAccountId": 123456,
      "InvoiceAccountNumber": "GB0000013",
      "InvoiceAccountShortName": "GB123",
      "PayerId": 29484,
      "PayerNumber": "GB99215176",
      "PayerShortName": "PARKLEY",
      "CardId": 275549,
      "CardPAN": "7002051006629890645",
      "CardGroupId": 5,
      "CardGroupName": "006240 FIRE BRIGHT SOLUTIONS",
      "FeeTypeId": 3,
      "FeeType": "89",
      "FeeTypeGroup": "Account",
      "FeeRuleId": 12345,
      "FeeRuleDescription": "NL/GAGO/D018",
      "FeeRuleTiers": [
        {
          "TierMin": 123,
          "TierMax": 321,
          "DateEffective": "20180131",
          "DateTerminated": "20180907",
          "TierValue": 12.23,
          "FeeRuleBasisID": 1,
          "FeeRuleBasisDescription": "Currency Per Unit"
        }
      ],
      "FeeItemDate": "20180604",
      "FeeItemTime": "121018",
      "IsManual": true,
      "IsCancelled": true,
      "CustomerCurrencyCode": "GBP",
      "CustomerCurrencySymbol": "$",
      "ProductId": 102,
      "ProductCode": "2",
      "ProductName": "Service fee",
      "ProductGroupId": 22,
      "ProductGroupName": "Card related fees",
      "LineItemDescription": "charge",
      "Quantity": 1,
      "IsInvoiced": true,
      "VATCountryCode": "QWER",
      "VATCountryName": "QWER",
      "VATPercentage": 0.1,
      "VATCategoryID": 1,
      "VATCategoryDescription": "QWER",
      "LegislativeRegionId": 2,
      "LegislativeRegionName": "qwert",
      "SystemEntryDate": "20170912",
      "SystemEntryTime": "10:20",
      "ColCoNetAmount": 100.9,
      "ColCoVATAmount": 104.5,
      "ColCoGrossAmount": 101.7,
      "InterimInvoiceId": 1010191,
      "InterimInvoiceNumber": "G1010191",
      "InvoiceId": 10101,
      "InvoiceNumber": "10209",
      "InvoiceDate": "20180807",
      "CustomerExchangeRate": 10.34,
      "InvoiceNetAmount": 19.34,
      "InvoiceGrossAmount": 50.23,
      "InvoiceVATAmount": 10.2,
      "ReverseCharge": true,
      "OriginalFeeItemId": 12345,
      "OriginalCurrencyCode": "GBP",
      "OriginalCurrencySymbol": "$",
      "OriginalUnitPrice": 1.2,
      "OriginalNetAmount": 13.8,
      "OriginalVATAmount": 17.23,
      "OriginalGrossAmount": 18.9,
      "OriginalExchangeRate": 156.2,
      "OriginalLegislativeRegionId": 1234,
      "OriginalLegislativeRegionName": "190",
      "Frequency": "1- Daily (all days)",
      "FeeItemCardLevelBreakup": "PAN|CardId",
      "OriginalFeeItemInvoiceId": 1,
      "OriginalFeeItemInvoiceNumber": "QW1",
      "OriginalFeeItemInvoiceDate": "101219",
      "DriverName": "ANDREW GILBERRY",
      "EmbossText": "ANDREW",
      "VRN": "MV65YLH"
    }
  ],
  "Error": {
    "Description": "Success",
    "Code": "0000"
  },
  "RequestId": "ed557f02-c7d7-4c01-b3e5-11bf3239c8ed",
  "CurrentPage": 10,
  "RowCount": 100,
  "TotalPages": 10
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionFees400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fees-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionFees401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fees-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionFees403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fees-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionFees404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fees-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionFees500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fees-500-error-exception.md) |


# Fee Summary Response

This API returns the summary data of the fee/charges levied from a customer's account in a billing period or date range. The API returns both billed and unbilled fee items.

The endpoint supports the exact same search criteria as the endpoint *transaction/feessummary*.

#### Supported operations

* Get fees by invoice status
* Get fees by date period
* Get fees by account
* Get fees by card Id or PAN
* Get fees by fee type charges
* Get fees including cancelled items
* Get fees by line item description
* Get fees by product

```csharp
FeeSummaryResponseAsync(
    string apikey,
    string requestId,
    Models.TransactionFeesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`TransactionFeesRequest`](../../doc/models/transaction-fees-request.md) | Body, Optional | FeeSummary RequestBody |

## Response Type

[`Task<Models.FeeSummaryResponse>`](../../doc/models/fee-summary-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
TransactionFeesRequest body = new TransactionFeesRequest
{
    ColCoId = 1,
    ColCoCode = 86,
    PayerId = 123456,
    PayerNumber = "GB000000123",
    CardId = 275549,
    CardPAN = "7002051006629890645",
    InvoiceStatus = "I",
    FeeTypeGroup = "Account Charges",
    FeeTypeId = 1,
    FromDate = "20210823",
    ToDate = "20210823",
    Period = 1,
    IncludeCancelledItems = true,
    ProductId = 100,
    ProductCode = "102",
    LineItemDescription = "string",
    SortOrder = "1",
};

try
{
    FeeSummaryResponse result = await transactionController.FeeSummaryResponseAsync(
        apikey,
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "FeeItemsSummary": [
    {
      "FeeTypeGroup": "Account",
      "FeeTypeId": "1",
      "ProductId": 102,
      "ProductCode": "Invoice production fee",
      "ProductName": "Invoice production fee",
      "ProductGroupId": 22,
      "ProductGroupName": "Card related fees",
      "TotalQuantity": 2,
      "TotalInvoiceNetAmount": 22.23,
      "TotalInvoiceGrossAmount": 28.92,
      "TotalInvoiceVATAmount": 10.02,
      "InvoiceCurrencyCode": "GBP",
      "InvoiceCurrencySymbol": "Ã‚Â£"
    }
  ],
  "RequestId": "ed557f02-c7d7-4c01-b3e5-11bf3239c8ed"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionFeessummary400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-feessummary-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionFeessummary401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-feessummary-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionFeessummary403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-feessummary-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionFeessummary404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-feessummary-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionFeessummary500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-feessummary-500-error-exception.md) |


# Fuel Consumption

- This API returns the customer an overview of how many transactions, how much fuel volume used over a given period and the total volume used by a card
- This operation response will contains card & transaction details for given period aggregated by payer, account, cardGroup, PAN, DriverName and VRN

```csharp
FuelConsumptionAsync(
    string apikey,
    string requestId,
    Models.FuelConsumptionRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`FuelConsumptionRequest`](../../doc/models/fuel-consumption-request.md) | Body, Optional | FuelConsumption RequestBody |

## Response Type

[`Task<Models.FuelConsumptionResponse>`](../../doc/models/fuel-consumption-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
FuelConsumptionRequest body = new FuelConsumptionRequest
{
    ColCoId = 14,
    PayerId = 10,
};

try
{
    FuelConsumptionResponse result = await transactionController.FuelConsumptionAsync(
        apikey,
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "FuelConsumption": [
    {
      "AccountName": "Pink Fox Television",
      "AccountNumber": "DE00000009",
      "PayerName": "Pink Fox Television",
      "PayerNumber": "DE00000009",
      "CardNumber": "7002141005592540015",
      "CardGroupId": null,
      "CardGroupName": null,
      "DriverName": "CSSTEST B",
      "LicenseNumber": "123456",
      "InitialOdometer": 123456,
      "LastOdometer": 0,
      "Distance": 0,
      "FuelConsumptions": 0,
      "FuelNetAmount": 17650.57,
      "Discount": -11.49,
      "FuelTax": 7023.08,
      "FuelVolume": 7097,
      "GrossNonFuelExpenses": 26754.49,
      "CO2Produced": 14.23803,
      "TransactionCount": 307
    }
  ],
  "Error": {
    "Code": "0000",
    "Description": "Success"
  },
  "RequestId": "7e9ed35c-11b7-4b57-fe5b-ba6c39479d37"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionFuelconsumption400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fuelconsumption-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionFuelconsumption401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fuelconsumption-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionFuelconsumption403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fuelconsumption-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionFuelconsumption404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fuelconsumption-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionFuelconsumption500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-fuelconsumption-500-error-exception.md) |


# Update Odometer

- This API allows the users to update the odometer readings on the sales items (transaction data)
- This is an asynchronous operation. If opted, the user will be notified on completion of processing.

```csharp
UpdateOdometerAsync(
    string apikey,
    string requestId,
    Models.UpdateOdometerRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`UpdateOdometerRequest`](../../doc/models/update-odometer-request.md) | Body, Optional | updateOdometer RequestBody |

## Response Type

[`Task<Models.UpdateOdometerResponse>`](../../doc/models/update-odometer-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
UpdateOdometerRequest body = new UpdateOdometerRequest
{
    ColCoId = 0,
    ColCoCode = 0,
    PayerId = 0,
    AccountId = 0,
    AccountNumber = "string",
    UpdateOdometers = new List<UpdateOdometer>
    {
        new UpdateOdometer
        {
            SalesItemId = "string",
            NewOdometerValue = 0,
        },
    },
    NotifyCaller = true,
};

try
{
    UpdateOdometerResponse result = await transactionController.UpdateOdometerAsync(
        apikey,
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "ServiceReference": 0,
  "UpdateOdometerReferences": [
    {
      "SalesItemId": 0,
      "UpdateOdometerReferenceId": 0
    }
  ],
  "Error": {
    "Code": "0000",
    "Description": "Success"
  },
  "RequestId": "string"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionUpdateodometer400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-updateodometer-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionUpdateodometer401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-updateodometer-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionUpdateodometer403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-updateodometer-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionUpdateodometer404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-updateodometer-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionUpdateodometer500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-updateodometer-500-error-exception.md) |


# Transaction Exceptions

- This API provides the details of the Cards or Transaction related exceptions based on the given conditions for the Requested period.
- This API will return the Transactions related exceptions when the OutputType input parameter is passed as ‘Transaction’ else will return the Cards related exceptions.

```csharp
TransactionExceptionsAsync(
    string apikey,
    string requestId,
    Models.TransactionExceptionsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikey` | `string` | Header, Required | This is the API key of the specific environment which needs to be passed by the client. |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`TransactionExceptionsRequest`](../../doc/models/transaction-exceptions-request.md) | Body, Optional | Transaction Exceptions RequestBody |

## Response Type

[`Task<Models.TransactionExceptionsResponse>`](../../doc/models/transaction-exceptions-response.md)

## Example Usage

```csharp
string apikey = "apikey6";
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
TransactionExceptionsRequest body = new TransactionExceptionsRequest
{
    TransactionsFromDate = "2023-01-01",
    TransactionsToDate = "2023-05-30",
    Condition = 1,
    OutputType = 2,
    ColCoId = 14,
    PayerId = 10,
    MValue = 10,
    ExceptionPeriod = 1,
};

try
{
    TransactionExceptionsResponse result = await transactionController.TransactionExceptionsAsync(
        apikey,
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "CardExceptions": [
    {
      "AccountId": 10,
      "AccountNumber": "DE00000009",
      "AccountShortName": "Pink Fox Television",
      "CardId": 575646,
      "CurrencyCode": "EUR",
      "CurrencySymbol": "€",
      "Day": null,
      "DriverName": "CSSTEST B",
      "Month": 5,
      "PAN": "7002141005592540015",
      "PayerId": 10,
      "PayerNumber": "DE00000009",
      "PayerShortName": "Pink Fox Television",
      "TotalAmount": 4290.29,
      "TotalQuantity": 851,
      "TotalSalesItems": 29,
      "TotalTransactions": 29,
      "VRN": "123456",
      "Week": null,
      "Year": 2023
    }
  ],
  "TransactionExceptions": null,
  "Error": {
    "Code": "0000",
    "Description": "Success"
  },
  "RequestId": "a5665b0b-1843-4a8f-daa3-1f3256db7758"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request  due to something that is perceived to be a client<br>error (e.g., malformed request syntax, invalid<br>request message framing, or deceptive request routing). | [`FleetmanagementV1TransactionExceptions400ErrorException`](../../doc/models/fleetmanagement-v1-transaction-exceptions-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`FleetmanagementV1TransactionExceptions401ErrorException`](../../doc/models/fleetmanagement-v1-transaction-exceptions-401-error-exception.md) |
| 403 | The server understood the request but refuses to authorize it. | [`FleetmanagementV1TransactionExceptions403ErrorException`](../../doc/models/fleetmanagement-v1-transaction-exceptions-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`FleetmanagementV1TransactionExceptions404ErrorException`](../../doc/models/fleetmanagement-v1-transaction-exceptions-404-error-exception.md) |
| 500 | The server encountered an unexpected condition the prevented it from fulfilling the request. | [`FleetmanagementV1TransactionExceptions500ErrorException`](../../doc/models/fleetmanagement-v1-transaction-exceptions-500-error-exception.md) |


# Recent Transactions New

This endpoint allows querying last 48 hours of transaction data of Shell Card (i.e. Priced, Billed, Unbilled etc. sales items). It provides a flexible search criteria and supports pagination. E.g., if the request is made at 08:30 AM on 18 Aug 2022 then transactions until 16 Aug 2022 08:30 AM (including) can be retrieved.

#### Supported operations

    * Search by Date and Time range (within the last 48 hours only)
    
    * Search by Payer and/or Account number
    
    * Search by Card
    
    * Search by Purchased Country
    
    * Search by Transaction posting date
    
    * Search by Driver Name or Vehicle registration number
    
    * Search by Fuel only transactions
    
    * Search by Product and/or Product group

```csharp
RecentTransactionsNewAsync(
    string requestId,
    Models.RecentTransactionRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`RecentTransactionRequest`](../../doc/models/recent-transaction-request.md) | Body, Optional | New Recent Transaction RequestBody |

## Response Type

[`Task<Models.RecentTransactionsResponse>`](../../doc/models/recent-transactions-response.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
RecentTransactionRequest body = new RecentTransactionRequest
{
    PageSize = 1,
    Page = 1,
    Filters = new RecentTransactionReq
    {
        ColCoCode = 14,
        PayerNumber = "GB00001232",
        AccountNumber = "GB00001233",
        ProductCode = "22",
        PurchasedInCountry = "GB",
        CardPAN = "700205******890645",
        FromDateTime = "2020-11-09 13:56:03.000",
        ToDateTime = "2020-12-09 13:56:03.000",
        TransactionStatus = "APPROVED",
        FuelOnly = "False",
        ProductGroupName = "Motor gasoline",
        VehicleRegistrationNumber = "YG67OUM",
        IncludeDeclines = true,
        CardIssuerName = "Mathew",
        ColumnList = "PayerNumber,AccountNumber,ProductName,FuelVolume,PAN",
    },
};

try
{
    RecentTransactionsResponse result = await transactionController.RecentTransactionsNewAsync(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "SUCCESS",
  "Page": 1,
  "RowCount": 2,
  "TotalPages": 1,
  "Data": [
    {
      "ColCoCode": 84,
      "PayerNumber": "MY00200653",
      "AccountNumber": "MY00200653",
      "CardIssueNumber": "1",
      "CollectingCompanyCurrencyCode": "MYR",
      "CustDataCustomerEntered": "PartnerId",
      "CustDataDriverId": "D123",
      "CustDataFleetDescription": "Fleet-Truck",
      "FleetIdInput": "AS2344",
      "Amount": 62.47,
      "EuroshellSiteNumber": "1231",
      "IncomingProductCode": "10",
      "ProductCode": "23",
      "ProductName": "Unleaded - Low octane",
      "SiteCode": 3350,
      "HostingCollectingCompanyName": "Shell Malaysia Trading Sdn Bhd",
      "HostingCollectingCompanyNumber": "84",
      "IccdataTranTypeCode": "1",
      "TransactionType": "Transaction Type description",
      "Latitude": "52.143814",
      "Longitude": "101.72869",
      "MerchantCategory": "5542",
      "MerchantCategoryDescription": "Description",
      "PurchasedInCountry": "MY",
      "MerchantId": "MY1737000000000",
      "SiteName": "ShellPT3895 BATU 4    KUALA LUMPUR MY",
      "Network": "458",
      "DelcoCode": "084",
      "OdometerInput": "201620",
      "OdometerReadingKm": "201620",
      "OdometerReadingMiles": "201620",
      "CardPAN": "700214*******780061",
      "PINIndicator": "Y",
      "POIReceiptNumber": "417662",
      "ProductsCodeAdditional": "Additional Code",
      "ProductsTaxCode": "0",
      "FuelVolume": 34.15,
      "SfgwCardDateOfExpiry": "2024-12",
      "SiteCurrencyISOCode": "MYR",
      "CardId": "330743",
      "TransactionDate": "2021-11-11",
      "TransactionDateTime": "2021-11-11 16:32:09.000",
      "TransactionId": "864220307",
      "TransactionStatus": "Approved",
      "UnitOfMeasure": "L",
      "VehicleRegistrationNumber": "WD33637",
      "NetworkDelcoName": "Shell Malaysia Trading Sdn Bhd",
      "ProductGroupName": "Motor gasoline",
      "FuelProduct": "All Fuels",
      "AccountCustomerName": "WCT BERHAD",
      "PayerName": "WCT BERHAD",
      "TransactionTime": "2021-11-11",
      "TransactionCurrency": "RM",
      "UnitPrice": 0.02050073206442167,
      "AuthorisedFlag": "Y",
      "TransactionTimeGMT": "08:41:02",
      "ReasonCode": "10",
      "IssuerActionCode": "2",
      "IssuerActionCodeDescription": "Approved, partial",
      "DeclinedReason": "partial",
      "CardStatusReasonDescription": "Approved, partial",
      "TransactionCountry": "458",
      "IssuingCollectingCompanyName": "Partner Name",
      "CardIssuerName": "John",
      "DriverName": "PAK PAK",
      "BearerDescription": "Description",
      "CardCategoryDescription": "Driver Card",
      "CardTypeDescription": "SHELL FLEET- HONG KONG 7002821",
      "CardTokenTypeDescription": "HK FLE NAT SIN R1 - CHIP",
      "EmbossType": "Driver",
      "EVPrintedNumber": "NL-TNM-C00122045-K",
      "IsRFID": false
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`TransactionDataV1Recent400ErrorException`](../../doc/models/transaction-data-v1-recent-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`TransactionDataV1Recent401ErrorException`](../../doc/models/transaction-data-v1-recent-401-error-exception.md) |
| 403 | Forbidden | [`TransactionDataV1Recent403ErrorException`](../../doc/models/transaction-data-v1-recent-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`TransactionDataV1Recent404ErrorException`](../../doc/models/transaction-data-v1-recent-404-error-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`TransactionDataV1Recent500ErrorException`](../../doc/models/transaction-data-v1-recent-500-error-exception.md) |


# Priced Transactions V2

This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria and supports paging.
The version 2 is an enhancement to the version 1 where EV transactions and their details are added in the response.

Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.

#### Supported operations

* Get sales items and fee transactions
  * Search by invoice status
  * Search by fixed date period
  * Search by date range
  * Search by account
  * Search by card
* Get sales items only
  * Search by transaction Id or location
  * Search by transaction posting date
  * Search by invoice number or date
  * Search by driver name or vehicle registration number
  * Search by card group
  * Search by fuel only transactions
  * Search by product
* EV transaction details - Below are EV specific parameters
  * EVOperator
  * EVSerialId
  * EVChargePointSerial
  * EVChargePointConnectorType
  * EVChargePointConnectorTypeDescription
  * EVChargeDuration
  * EVChargeStartDate
  * EVChargeStartTime
  * EVChargeEndDate
  * EVChargeEndTime

```csharp
PricedTransactionsV2Async(
    string requestId,
    Models.PricedTransactionRequestV2 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.<br>**Constraints**: *Minimum Length*: `36`, *Maximum Length*: `36`, *Pattern*: `^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$` |
| `body` | [`PricedTransactionRequestV2`](../../doc/models/priced-transaction-request-v2.md) | Body, Optional | Priced TransactionV2 RequestBody |

## Response Type

[`Task<Models.PricedTransactionResponseV2>`](../../doc/models/priced-transaction-response-v2.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
PricedTransactionRequestV2 body = new PricedTransactionRequestV2
{
    Filters = new Filters
    {
        ColCoCode = "032",
        InvoiceStatus = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        PayerNumber = "DE26685263",
        AccountId = 29484,
        AccountNumber = "DE26667080",
        DriverName = "HH NX 508",
        CardGroupId = 40000,
        CardPAN = "7002051006629890645",
        ProductCode = "10",
        ProductName = "Diesel AGO",
        SiteCode = "05000100",
        IncomingSiteNumber = "100021",
        InvoiceDate = "2021-01-01",
        InvoiceNumber = "3201016193",
        PurchasedInCountryCode = "GB",
        PurchasedInCountry = "United Kingdom",
        SiteGroupId = 202,
        VehicleRegistrationNumber = "4K46801",
        FeeTypeId = 275549,
        LineItemDescription = "ABC3",
        Cards = new List<int>
        {
            0,
        },
        SortOrder = PricedTransactionReqV2SortOrderEnum.Enum5,
        FromDate = "2022-01-01 00:00:00",
        ToDate = "2022-01-01 00:00:00",
        Period = PricedTransactionReqV2PeriodEnum.Enum3,
        PostingDateFrom = "2022-01-01 00:00:00",
        PostingDateTo = "2022-01-01 00:00:00",
        TransactionItemId = "1208176398",
        FuelOnly = false,
        IncludeFees = true,
        IsMultipayer = true,
        ValidInvoiceDateOnly = false,
        InvoiceFromDate = "2022-01-01 00:00:00",
        InvoiceToDate = "2022-01-01 00:00:00",
        HostingCollectingCompanyNumber = "032",
        Search = "2K89909",
        TransactionId = "io9KVXk1UkW57XWKyeaHHg",
    },
    Page = 1,
    PageSize = 1,
};

try
{
    PricedTransactionResponseV2 result = await transactionController.PricedTransactionsV2Async(
        requestId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "RequestId": "9d2dee33-7803-485a-a2b1-2c7538e597ee",
  "Status": "SUCCESS",
  "Data": [
    {
      "AccountName": "Blue Colour Ltd",
      "AccountId": 29484,
      "AccountNumber": "DE26667080",
      "AccountShortName": "Mathew",
      "Additional1": "GBALLEGO0002452",
      "Additional2": "GBALLEGO0002452",
      "Additional3": "GBALLEGO0002452",
      "Additional4": "GBALLEGO0002452",
      "AllowClearing": "Null",
      "AuthorisationCode": 300796,
      "TransactionStatus": "Y",
      "DriverName": "SATTY BHAMRA",
      "CardExpiryPeriod": 2204,
      "CardExpiry": "20220101",
      "CardGroupId": 40000,
      "CardGroupName": "006240 FIRE BRIGHT SOLUTIONS",
      "IssuerCode": 7002,
      "CardPAN": "7002053465789891000",
      "ReleaseCode": 9,
      "CardSequenceNumber": 617,
      "CardType": "GB STD FLT NAT SINGLE R9",
      "ColCoCode": "014",
      "UnitDiscountInvoiceCurrency": -0.0051,
      "ColCoExchangeRate": 0.851858,
      "InvoiceCurrencySymbol": "GBP",
      "CorrectionFlag": true,
      "CRMNumber": 10,
      "CustomerCountry": "United Kingdom",
      "CustomerCurrencyCode": "GBP",
      "CustomerCurrencySymbol": "£",
      "RebateonNetAmountInCustomerCurrency": 0,
      "EffectiveDiscountInCustomerCurrency": -0.22,
      "EffectiveUnitDiscountInCustomerCurrency": -0.0051,
      "UnitPriceInInvoiceCurrency": 1.1024,
      "InvoiceTax": 0,
      "InvoiceGrossAmount": 57.25,
      "InvoiceNetAmount": 47.71,
      "VATonNetAmountInCustomerCurrency": 9.54,
      "CustomerRetailPriceUnitGross": 0,
      "CustomerRetailValueTotalGross": 57.52,
      "CustomerRetailValueTotalNet": 47.93,
      "TransactionTypeDescription": 9.59,
      "RebateonNetAmountInTransactionCurrency": -0.22,
      "EffectiveDiscountInTrxCurrency": -0.22,
      "DelCoToColCoExchangeRate": 0,
      "Cards": [
        275549
      ],
      "UnitDiscountTransactionCurrency": -0.005,
      "TransactionGrossAmount": 57.25,
      "TransactionNetAmount": 47.71,
      "TransactionTax": 9.54,
      "VATonNetAmount": 9.54,
      "DelcoListPriceUnitNet": 0,
      "DelcoRetailPriceUnitGross": 1.32888,
      "UnitPriceInTransactionCurrency": 1.1074,
      "DelcoRetailPriceUnitNet": 1.1074,
      "DelcoRetailValueTotalGross": 57.52,
      "DelcoRetailValueTotalNet": 47.93,
      "TransactionCurrencySymbol": "$",
      "DiscountType": "Retail",
      "DisputeStatus": false,
      "IsShellSite": false,
      "FleetIdInput": "YG67OUM",
      "IncomingProductCode": 23,
      "PostingDate": "20210802",
      "PostingTime": "14:15:22",
      "ProductCode": 30,
      "ProductName": "Unleaded - Medium octane",
      "ProductGroupId": 22,
      "IncomingCurrencyCode": "GBP",
      "IncomingSiteDescription": "Shell Broadway Ring",
      "Location": "Shell Broadway Ring",
      "SiteName": "Shell Broadway Ring",
      "SiteCode": 32,
      "IncomingSiteNumber": 15,
      "InvoiceCurrencyCode": "GBP",
      "InvoiceDate": "20210802",
      "InvoiceNumber": 3201016193,
      "FuelProduct": true,
      "VATApplicable": "Y",
      "PayerName": "Colours Services Ltd",
      "PayerNumber": "GB12121212",
      "ParentCustomerNumber": "GB12121212",
      "PayerGroup": "H312066",
      "PayerGroupName": "12162566 - FUEL CARD SERVICE",
      "CheckDigit": 6,
      "NetInvoiceIndicator": "Y",
      "DelcoCode": 5,
      "NetworkCode": 3,
      "PurchasedInCountry": "United Kingdom",
      "SiteCountry": "United Kingdom",
      "VATCountry": "United Kingdom",
      "DelcoName": "Shell U.K. Oil Products Limited",
      "Network": "Shell",
      "OdometerInput": 0,
      "OriginalSalesItemId": "Null",
      "FleetIDDescription": "YG67OUM",
      "ParentCustomerId": 6494,
      "PINIndicator": "Y, N",
      "ProductGroupName": "Fees",
      "PurchasedInCountryCode": "GB",
      "Quantity": 43.28,
      "RebateRate": 0.0022,
      "ReceiptNumber": 6803,
      "RefundFlag": "Y",
      "SiteGroupId": 202,
      "SiteGroupName": "CZ 9100 ECONOMY NETWORK",
      "Latitude": 53.83606,
      "Longitude": -1.61854,
      "DelCoExchangeRate": 0.851858,
      "EuroRebateAmount": -0.258259,
      "NetEuroAmount": 56.01,
      "EuroVATAmount": 11.2,
      "ParentCustomerName": "FUEL CARD SERVICES LTD",
      "IsInvoiced": false,
      "TransactionCurrencyCode": "GBP",
      "CreditDebitCode": "D or C",
      "TransactionDate": "20210801",
      "TransactionTime": "12:16:58",
      "TransactionItemId": "H305908971030",
      "TrnIdentifier": "H305908971030",
      "Type": "SALE",
      "TransactionLine": 1,
      "TransactionType": "Purchase",
      "UTCOffset": "Europe/London",
      "VATCategory": "United Kingdom Standard VAT Rate",
      "VATRate": 0.2,
      "VehicleRegistration": "YG67OUM",
      "IsCancelled": "Y",
      "ColCoGrossAmount": 57.25,
      "ColCoNetAmount": 47.71,
      "ColCoVATAmount": 9.54,
      "OriginalCurrencySymbol": "$",
      "OriginalCurrencyCode": "$",
      "OriginalVATAmount": 0,
      "EmbossText": "PARKLANE PROPERTIES LTD",
      "OriginalExchangeRate": 0,
      "OriginalTransactionItemInvoiceDate": "20220202",
      "FeeTypeId": 1,
      "LineItemDescription": true,
      "FeeRuleDescription": "Simple Fee",
      "Frequency": 1,
      "FeeRuleId": 1,
      "SystemEntryDate": "20210828",
      "SystemEntryTime": "20:21:08",
      "IsManual": "Y",
      "OriginalTransactionItemId": "Y",
      "OriginalTransactionItemInvoiceNumber": 6750802,
      "OriginalTransactionItemInvoiceId": 234,
      "PayerShortName": "FUEL CARD SERVICES LTD",
      "ReverseCharge": "Y",
      "OriginalGrossAmount": 57.25,
      "OriginalNetAmount": 57.25,
      "UnitOfMeasure": "L",
      "RoadType": "National Road",
      "CustomerCountryIsoCode": "DE",
      "EVOperator": "Shell Recharge",
      "EVSerialId": "GBALLEGO0002452",
      "EVChargePointSerial": "GBALLEGO0002452",
      "EVChargePointConnectorType": 5,
      "EVChargePointConnectorTypeDescription": "DC 50 kW",
      "EVChargeDuration": "PT3205S",
      "EVChargeStartDate": "2021-08-01",
      "EVChargeStartTime": "20:08:01",
      "EVChargeEndDate": "2022-08-01",
      "EVChargeEndTime": "20:08:01",
      "HostingCollectingCompanyNumber": 0,
      "TransactionId": 0,
      "FuelOnly": true
    }
  ],
  "Page": 3,
  "PageSize": 30,
  "TotalPages": 5
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`TransactionDataV1Priced400ErrorException`](../../doc/models/transaction-data-v1-priced-400-error-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`TransactionDataV1Priced401ErrorException`](../../doc/models/transaction-data-v1-priced-401-error-exception.md) |
| 403 | Forbidden | [`TransactionDataV1Priced403ErrorException`](../../doc/models/transaction-data-v1-priced-403-error-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`TransactionDataV1Priced404ErrorException`](../../doc/models/transaction-data-v1-priced-404-error-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`TransactionDataV1Priced500ErrorException`](../../doc/models/transaction-data-v1-priced-500-error-exception.md) |

