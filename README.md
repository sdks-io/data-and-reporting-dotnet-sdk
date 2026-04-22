
# Getting Started with Shell Data & Reporting APIs

## Introduction

The Shell Card Transaction and Invoice API is part of the Data and Reporting product suite, designed to provide secure and flexible access to transaction and invoice data related to Shell Cards.

### Authentication

- OAuth 2.0 Authentication.

### Architecture

- RESTful API design.
- All endpoints use the `POST` HTTP method for all operations including retrieval, creation, update, and deletion of resources.
- Requests and responses are encoded in JSON format.
- Standard HTTP status codes are used for response handling.

### Platform

- All resources are managed within the **Shell Card Platform**, which integrates multiple internal Shell systems for resource management.

### Features

- Flexible search parameters supported in the request body for data retrieval.
- Designed for integration with enterprise systems requiring Shell Card transaction and invoice data.

### Use Cases

- Retrieve detailed transaction history for Shell Cards.
- Access invoice summaries and line-item details.
- Integrate Shell Card financial data into internal reporting tools.

Go to the Shell Developer Portal: [https://developer.shell.com](https://developer.shell.com)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.DataAndReportingSDK --version 3.0.0
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.DataAndReportingSDK/3.0.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Environment | [`Environment`](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/README.md#environments) | The API environment. <br> **Default: `Environment.SIT`** |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| ClientCredentialsAuth | [`ClientCredentialsAuth`](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using ShellDataReportingAPIs.Standard;
using ShellDataReportingAPIs.Standard.Authentication;

namespace ConsoleApp;

ShellDataReportingAPIsClient client = new ShellDataReportingAPIsClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .Environment(ShellDataReportingAPIs.Standard.Environment.SIT)
    .Build();
```

### Configuration-Based Initialization

```csharp
using ShellDataReportingAPIs.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = ShellDataReportingAPIsClient
    .FromConfiguration(configuration.GetSection("ShellDataReportingAPIs"));
```

See the [Configuration-Based Initialization](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/configuration-based-initialization.md) section for details.

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| SIT | **Default** |
| Production | - |

## Authorization

This API uses the following authentication schemes.

* [`BearerToken (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/auth/oauth-2-client-credentials-grant.md)

## List of APIs

* [Customer](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/controllers/customer.md)
* [Transaction](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/controllers/transaction.md)
* [Invoice](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/controllers/invoice.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/http-client-configuration-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/http-callback.md)
* [HttpContext](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/http-context.md)
* [HttpRequest](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/api-exception.md)
* [ApiHelper](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/3.0.0/doc/unix-date-time-converter.md)

