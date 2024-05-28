# Invoice

API's for Retrieve and download Invoice details

```csharp
InvoiceController invoiceController = client.InvoiceController;
```

## Class Name

`InvoiceController`

## Methods

* [Invoice Search](../../doc/controllers/invoice.md#invoice-search)
* [Invoice Summary](../../doc/controllers/invoice.md#invoice-summary)
* [Statement of Account](../../doc/controllers/invoice.md#statement-of-account)
* [Dates](../../doc/controllers/invoice.md#dates)
* [Search Statement of Account](../../doc/controllers/invoice.md#search-statement-of-account)
* [Search Documents](../../doc/controllers/invoice.md#search-documents)
* [Eid Search](../../doc/controllers/invoice.md#eid-search)
* [Download](../../doc/controllers/invoice.md#download)
* [Eid Download](../../doc/controllers/invoice.md#eid-download)


# Invoice Search

This API allows to search invoice data in the Shell Card Platform. It provides flexible search criteria in the request body and supports paging.

This API will also query the relevant invoice documents list and return a reference number that can be used to download invoice documents (PDF and Proofing elements in a zip file).

#### Supported operations

* Search invoices by account
* Search invoices by invoice type or invoice status
* Search invoices by invoice id or number
* Search invoices by invoiced country
* Search invoices including einvoices
* Search invoices by summary document
* Search invoices by statement of account
* Search invoices by fixed and custom date periods

```csharp
InvoiceSearchAsync(
    string requestId,
    Models.InvoiceSearchRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`InvoiceSearchRequest`](../../doc/models/invoice-search-request.md) | Body, Optional | Invoice Search RequestBody |

## Response Type

[`Task<Models.InvoiceSearchResponse>`](../../doc/models/invoice-search-response.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
InvoiceSearchRequest body = new InvoiceSearchRequest
{
    Filters = new InvoiceSearchRequestFilters
    {
        ColCoId = 14,
        PayerId = 78,
        PayerNumber = "DE26688478",
        InvoiceId = 4013059,
        InvoiceNumber = "0123456789",
        FromDate = "20170830",
        ToDate = "20171031",
        InvoiceDate = "20171031",
        SummaryDocumentId = 1616729,
        SummaryDocumentNumber = "1283899/289261063/2019",
        StatementOfAccountId = "DE26702892",
        SoAReferenceNumber = "1283899",
        Period = 1,
        InvoiceStatus = "Due",
        InvoicedOnBehalfOf = "DE",
        IncludeEInvoiceDetails = false,
        Type = "Original",
    },
    PageSize = 50,
    Page = 1,
};

try
{
    InvoiceSearchResponse result = await invoiceController.InvoiceSearchAsync(
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
  "RequestId": "18c955d1-b3ec-4dc0-95da-76e67afb891a",
  "Status": "SUCCESS",
  "Data": [
    {
      "AccountFullName": "powder ambition ERF  ",
      "AccountId": 179827,
      "AccountNumber": "DE26702892",
      "AccountShortName": "soft grocery Argyle  ",
      "ColCoId": 14,
      "ColCoOpCoId": "014",
      "CurrentBillingFrequency": "Last day of month",
      "CurrentBillingFrequencyId": 40,
      "CurrentDistributionMethod": "e-mail",
      "CurrentDistributionMethodId": 1,
      "CustomerCurrencyCode": "EUR",
      "CustomerCurrencySymbol": "€",
      "DelCoClientNumber": "014",
      "DelCoId": 14,
      "DelCoOpCoId": "014",
      "DocumentType": "Invoice",
      "DocumentTypeId": 1,
      "DueDate": "20190707",
      "GrossAmountCustomerCurrency": 22.85,
      "GrossAmountTransactionCurrency": 22.85,
      "InvoiceDate": "20190630",
      "InvoicedBy": "euroShell Deutschland GmbH & Co. KG",
      "InvoicedOnBehalfOf": "Germany",
      "InvoiceId": 4013059,
      "InvoiceNumber": "6402009004",
      "IsInternational": false,
      "IsNational": true,
      "NetAmountCustomerCurrency": 19.2,
      "NetAmountTransactionCurrency": 19.2,
      "PayerId": 164825,
      "PayerNumber": "DE26688478",
      "PaymentTerms": "7 days after invoice",
      "PaymentTermsId": 9,
      "ReplacementInvoiceId": null,
      "ReversalInvoiceId": null,
      "Status": "Paid",
      "SummaryDocumentBillingType": "Standard Invoice",
      "SummaryDocumentBillingTypeId": 0,
      "SummaryDocumentDate": "20190630",
      "SummaryDocumentDDAmount": 22.85,
      "SummaryDocumentDueDate": "20190707",
      "SummaryDocumentId": 1616729,
      "SummaryDocumentIsFullyPaid": true,
      "SummaryDocumentNumber": "1283899/289261063/2019",
      "SummaryDocumentPaidAmount": 22.85,
      "SummaryDocumentSoAReferenceNumber": "2000745709",
      "SummaryDocumentStatementOfAccountId": 2000745709,
      "TransactionCurrencyCode": "EUR",
      "TransactionCurrencySymbol": "€",
      "Type": "Original",
      "TypeId": 1,
      "VATAmountCustomerCurrency": 3.65,
      "VATAmountTransactionCurrency": 3.65,
      "VATCountry": "Germany",
      "VATCountryId": 9,
      "VATCountryISOCode": "DE",
      "VATCountryOpCoId": "014"
    }
  ],
  "Page": 1,
  "PageSize": 50,
  "TotalRecords": 1,
  "TotalPages": 1
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Invoice Summary

This API returns the high level summary of invoices that match the  given search criteria. The same search criteria as the endpoint `/v1/invoice/search` is supported with the exception of paging related parameters.

#### Supported operations

* Search invoices by account
* Search invoices by invoice type or invoice status
* Search invoices by invoice id or number
* Search invoices by invoiced country
* Search invoices including einvoices
* Search invoices by summary document
* Search invoices by statement of account
* Search invoices by fixed and custom date periods

```csharp
InvoiceSummaryAsync(
    string requestId,
    Models.InvoiceSummaryRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`InvoiceSummaryRequest`](../../doc/models/invoice-summary-request.md) | Body, Optional | Invoice Search RequestBody |

## Response Type

[`Task<Models.InvoiceSummaryResponse>`](../../doc/models/invoice-summary-response.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
InvoiceSummaryRequest body = new InvoiceSummaryRequest
{
    Filters = new InvoiceSummaryRequestFilters
    {
        ColCoId = 14,
        PayerId = 78,
        PayerNumber = "DE26688478",
        InvoiceId = 4013059,
        InvoiceNumber = "0123456789",
        FromDate = "20170830",
        ToDate = "20171031",
        InvoiceDate = "20171031",
        SummaryDocumentId = 1616729,
        SummaryDocumentNumber = "1283899/289261063/2019",
        StatementOfAccountId = "DE26702892",
        SoAReferenceNumber = "1283899",
        Period = 1,
        InvoiceStatus = "Due",
        InvoicedOnBehalfOf = "DE",
        IncludeEInvoiceDetails = false,
        Type = "Original",
    },
};

try
{
    InvoiceSummaryResponse result = await invoiceController.InvoiceSummaryAsync(
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
  "RequestId": "a0a1596f-b242-4672-b513-66c5e5554195",
  "Status": "SUCCESS",
  "Data": [
    {
      "TotalInvoices": 1,
      "TotalGrossAmountCustomerCurrency": 22.85,
      "TotalNetAmountCustomerCurrency": 19.2,
      "TotalVATAmountCustomerCurrency": 3.65,
      "CustomerCurrencyCode": "EUR",
      "CustomerCurrencySymbol": "€"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Statement of Account

This API allows querying the details of the latest statement of account (SOA) generated for a given Payer.

The endpoint supports querying SOA documents by various input parameters specified in the request body.

#### Supported operations

* Search invoice SOA by payer and account
* Search invoice SOA including monthly trend (last 13 months invocie trend summary)
* Search invoice SOA including past SOAs
* Search invoice SOA including due/overdue documents
* Search invoice SOA including invoice summary

```csharp
StatementOfAccountAsync(
    string requestId,
    Models.StatementOfAccountRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`StatementOfAccountRequest`](../../doc/models/statement-of-account-request.md) | Body, Optional | StatementOfAccount RequestBody |

## Response Type

[`Task<Models.StatementOfAccountResponse>`](../../doc/models/statement-of-account-response.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
StatementOfAccountRequest body = new StatementOfAccountRequest
{
    Filters = new StatementOfAccountRequestFilters
    {
        ColCoCode = 32,
        PayerId = 308,
        PayerNumber = "CZ56891709",
        IncludeMonthlyInvoiceTrend = true,
        IncludePastStatementOfAccounts = true,
        DueOrOverDueSOADocumentsOnly = false,
        NumberOfSOADocuments = 10,
        IncludeAccountInvoicesSummary = true,
    },
};

try
{
    StatementOfAccountResponse result = await invoiceController.StatementOfAccountAsync(
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
  "RequestId": "5acba53b-3ce7-4f4b-ab59-1db09399aa6a",
  "Status": "SUCCESS",
  "Data": [
    {
      "LastStatementOfAccount": {
        "AmountDue": 123699.71,
        "AmountNotOverdue": 136604.83,
        "AmountOverdue": 926469.11,
        "CreditLimit": 7000000,
        "CreditLimitCurrencyCode": "CZK",
        "CreditLimitCurrencySymbol": "Kč",
        "CreditLimitInCustomerCurrency": 286826.469986,
        "CurrencyCode": "EUR",
        "CurrencySymbol": "€",
        "LastPaymentCurrencyCode": "EUR",
        "LastPaymentCurrencySymbol": "€",
        "LastPaymentDate": "20220209",
        "LastPaymentValue": 17918.98,
        "OutstandingBalance": 1186773.65,
        "PayerId": 308,
        "PayerNumber": "CZ56891709",
        "PaymentDueDate": "20230608",
        "PaymentMethod": "Incoming - Bank Transfer",
        "PaymentMethodId": 4,
        "PaymentTerms": "30 days after Invoice",
        "PaymentTermsId": 4,
        "SoAReferenceNumber": "2003923319",
        "StatementDate": "20230509",
        "StatementOfAccountId": 2003923319,
        "TotalBillingDocuments": 6,
        "TotalSummaryBillingDocuments": 1,
        "UnallocatedPayment": 0
      },
      "MonthlyInvoiceTrend": null,
      "PastStatementOfAccounts": [
        {
          "AmountDue": 136604.83,
          "AmountNotOverdue": 130344.09,
          "AmountOverdue": 796109.41,
          "AmountOverdueFromUnallocated": 0,
          "AmountPaid": 0,
          "BalanceOnThisStatement": 5866.1,
          "BillingCurrencyCode": "EUR",
          "BillingCurrencySymbol": "€",
          "CreditLimit": 7000000,
          "CreditLimitCurrencyCode": "CZK",
          "CreditLimitCurrencySymbol": "Kč",
          "CreditLimitInCustomerCurrency": 286826.4699857,
          "CurrencyCode": "EUR",
          "CurrencySymbol": "€",
          "FullyPaid": false,
          "LastPaymentCurrencyCode": "EUR",
          "LastPaymentCurrencySymbol": "€",
          "LastPaymentDate": "20220209",
          "LastPaymentValue": 17918.98,
          "OutstandingBalance": 1063058.33,
          "PayerId": 308,
          "PayerNumber": "CZ56891709",
          "PaymentDueDate": "20230511",
          "SoAReferenceNumber": "2003920583",
          "StatementDate": "20230411",
          "StatementOfAccountId": 2003920583,
          "TotalBillingDocuments": 3,
          "TotalNetAmountBillingCurrency": 4847.94,
          "TotalSummaryBillingDocuments": 1,
          "TotalVATAmountBillingCurrency": 1018.16,
          "UnallocatedPayment": 0,
          "LocalCurrencyCode": "EUR",
          "LocalCurrencySymbol": "€",
          "LocalCurrencyExchangeRate": 24.405
        }
      ],
      "PaymentsSinceLastSOA": null,
      "InvoicesSummaries": null
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Dates

- This API will return the list of Invoice Dates and Numbers for the given date range. If the dates are not provided then it will fetch the data for past 13 months.

```csharp
DatesAsync(
    string requestId,
    Models.InvoiceDatesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`InvoiceDatesRequest`](../../doc/models/invoice-dates-request.md) | Body, Optional | StatementOfAccount RequestBody |

## Response Type

[`Task<Models.InvoiceDatesResponseData>`](../../doc/models/invoice-dates-response-data.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
InvoiceDatesRequest body = new InvoiceDatesRequest
{
    Filters = new InvoiceDatesRequestFilters
    {
        ColCoCode = 0,
        ColCoId = 0,
        PayerId = 0,
        PayerNumber = "string",
        Accounts = new List<Models.Accounts>
        {
            new Accounts
            {
                AccountId = 3453,
                AccountNumber = "GB000000124",
            },
        },
    },
};

try
{
    InvoiceDatesResponseData result = await invoiceController.DatesAsync(
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
  "RequestId": "a0a1596f-b242-4672-b513-66c5e5554195",
  "Status": "SUCCESS",
  "Data": [
    {
      "InvoiceNumbers": [
        "6402009004"
      ],
      "InvoiceDates": [
        "20170101"
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Search Statement of Account

- This API will allow querying of SOA from different systems

```csharp
SearchStatementOfAccountAsync(
    string requestId,
    Models.SearchStatementOfAccountRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`SearchStatementOfAccountRequest`](../../doc/models/search-statement-of-account-request.md) | Body, Optional | searchstatementofaccount RequestBody |

## Response Type

[`Task<Models.SearchStatementOfAccountResponse>`](../../doc/models/search-statement-of-account-response.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
SearchStatementOfAccountRequest body = new SearchStatementOfAccountRequest
{
    Filters = new SearchSOAReq
    {
        ColCoCode = 18,
        PayerNumber = "NL99781417",
        InvoiceNumber = "0123456789",
        FromDate = "2022/05/04",
        ToDate = "2022/05/10",
        Period = 1,
        InvoiceDate = "20170830",
        InvoiceStatus = new List<string>
        {
            "Due",
        },
        SortBy = new List<int>
        {
            1,
        },
    },
    Page = 1,
    PageSize = 10,
};

try
{
    SearchStatementOfAccountResponse result = await invoiceController.SearchStatementOfAccountAsync(
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
  "RequestId": "a0a1596f-b242-4672-b513-66c5e5554195",
  "Status": "SUCCESS",
  "Data": [
    {
      "StatementOfAccountId": 2001581712,
      "SoAReferenceNumber": "2001581712",
      "DocumentReferenceNumber": null,
      "StatementDate": "20220505",
      "PayerId": 17150,
      "PayerNumber": "NL99781417",
      "AmountDue": 0,
      "AmountOverdue": 197046.47,
      "CurrencyCode": "EUR",
      "CurrencySymbol": "€",
      "DueDate": "20220604",
      "InvoicedOnBehalfOf": "Netherlands",
      "Status": "OverDue",
      "GrossAmountCustomerCurrency": 0
    }
  ],
  "Page": 1,
  "TotalRecords": 62,
  "TotalPages": 7,
  "PageSize": 10
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Search Documents

- This API allows querying the details of all invoices successfully uploaded to the Worldline invoice repository and file reference numbers for downloading.

```csharp
SearchDocumentsAsync(
    string requestId,
    Models.SearchDocumentsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`SearchDocumentsRequest`](../../doc/models/search-documents-request.md) | Body, Optional | SearchDocuments RequestBody |

## Response Type

[`Task<Models.SearchDocumentsResponse>`](../../doc/models/search-documents-response.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
SearchDocumentsRequest body = new SearchDocumentsRequest
{
    Filters = new SearchDocReq
    {
        PayerNumber = "DE00000096",
        ColCoCode = 14,
        AccountNumber = "DE00000096",
        AccountNumberList = new List<string>
        {
            "DE00000123",
            "DE00000225",
        },
        InvoiceNumber = "1234567",
        InvoiceNumberList = new List<string>
        {
            "6400013693",
            "9421000010",
        },
        InvoiceStatus = "NEW",
        IssuingDateFrom = "2023/05/01",
        IssuingDateTo = "2023/06/30",
        DueDateFrom = "2023/05/04",
        DueDateTo = "2023/06/30",
        GrossAmount = "1000",
        GrossAmountOperator = "LT",
        DocumentType = "SOA",
        VATIssuerCountry = "DE",
        SortyBy = new List<string>
        {
            "InvoiceNumber ASC",
            "InvoiceDate DESC",
        },
    },
    Page = "1",
    PageSize = "50",
};

try
{
    SearchDocumentsResponse result = await invoiceController.SearchDocumentsAsync(
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
  "RequestId": "a8b81c1d-f44a-4365-8113-8958061c0b7e",
  "Status": "SUCCESS",
  "Data": [
    {
      "DocumentReference": 311161,
      "InvoiceNumber": "6400013693",
      "PayerName": "DE00000096",
      "AccountNumber": "DE00000096",
      "AccountName": "DE00000096",
      "DocumentType": "NAT",
      "GrossAmount": -3141.93,
      "NetAmount": 0,
      "TaxAmount": 0,
      "CurrencyCode": "EUR",
      "InvoiceStatus": "NEW",
      "InvoiceDate": "2023/01/31",
      "DueDate": "2023/02/07",
      "VATCountryISOCode": "DE"
    }
  ],
  "TotalRecords": 2,
  "TotalRecordsOnPage": 2,
  "IsFirstPage": true,
  "IsLastPage": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Eid Search

- This API provides the functionality needed for the screen “EID FILES” in the web interface. It allows retrieving a list of EIDs based on search criteria.

```csharp
EidSearchAsync(
    string requestId,
    Models.EIDSearchRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`EIDSearchRequest`](../../doc/models/eid-search-request.md) | Body, Optional | EIDSearch RequestBody |

## Response Type

[`Task<Models.EIDDocumentResponse>`](../../doc/models/eid-document-response.md)

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
EIDSearchRequest body = new EIDSearchRequest
{
    Filters = new EIDSearchReq
    {
        ColCoCode = 32,
        AccountGroupCountry = 32,
        AccountGroupId = new List<string>
        {
            "122",
        },
        FromDate = "2017/08/30",
        ToDate = "2017/10/31",
        InvoiceType = "NAT",
        InvoiceStatus = "NEW",
        SortBy = new List<string>
        {
            "DocumentDate ASC",
        },
    },
    Page = 1,
    PageSize = 10,
};

try
{
    EIDDocumentResponse result = await invoiceController.EidSearchAsync(
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
  "RequestId": "a0a1596f-b242-4672-b513-66c5e5554195",
  "Status": "SUCCESS",
  "Data": [
    {
      "DocumentId": 15029,
      "AccountGroupId": "122",
      "AccountGroupName": "EID-122",
      "DocumentType": "INT",
      "DocumentFormat": "FLAT",
      "DocumentDate": "2022/12/28",
      "NumberOfInvoices": 1,
      "FileSize": 1624,
      "DocumentStatus": "DOWNLOADED",
      "DocumentName": "032_122_INT_28122022.TXT"
    }
  ],
  "PageSize": 1,
  "Page": 1,
  "TotalPages": 12,
  "TotalRecords": 120,
  "IsFirstPage": true,
  "IsLastPage": false
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Download

- This API downloads Invoice Documents i.e., ZIP file with Invoice PDF file and Proofing Elements in XML format from invoice repository.

```csharp
DownloadAsync(
    string requestId,
    Models.InvoiceDownloadRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`InvoiceDownloadRequest`](../../doc/models/invoice-download-request.md) | Body, Optional | Invoice Download RequestBody |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
InvoiceDownloadRequest body = new InvoiceDownloadRequest
{
    Filters = new InvoiceDownloadReq
    {
        ColCoCode = 18,
        PayerNumber = "NL99781417",
        AccountNumber = new List<string>
        {
            "NL99781420",
        },
        DocumentReference = new List<int>
        {
            1234567890,
        },
        InvoiceOrSOANumber = "2234556",
    },
};

try
{
    Stream result = await invoiceController.DownloadAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |


# Eid Download

- This service allows downloading one or more EID documents and the corresponding signature material (where applicable) in one single request
- The number of EID that can be downloaded at once is limited to 100 documents.

```csharp
EidDownloadAsync(
    string requestId,
    Models.EIDDownloadRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `requestId` | `string` | Header, Required | Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request. |
| `body` | [`EIDDownloadRequest`](../../doc/models/eid-download-request.md) | Body, Optional | EIDInvoice Download RequestBody |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
EIDDownloadRequest body = new EIDDownloadRequest
{
    Filters = new EIDDownloadReq
    {
        ColCoCode = 18,
        EIDList = new List<string>
        {
            "1710187",
            "1734566",
        },
        AccountGroupCountry = 18,
        AccountGroupIdList = new List<string>
        {
            "26685402",
        },
    },
};

try
{
    Stream result = await invoiceController.EidDownloadAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing). | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 401 | The request has not been applied because it lacks valid  authentication credentials for the target resource. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 403 | Forbidden | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 404 | The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |
| 500 | The server encountered an unexpected condition that  prevented it from fulfilling the request. | [`ErrorObjectException`](../../doc/models/error-object-exception.md) |

