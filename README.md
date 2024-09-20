
# Getting Started with Shell Data & Reporting APIs

## Introduction

Data And Reporting product consists of API's which provides details of transaction and invoice informations about shell cards.
The Shell Card Transaction and Invoice API is REST-based and employs Basic authentication in Version 1 and Oauth authentication in Version 2 end points. The API endpoints accept JSON-encoded request bodies, return JSON-encoded responses and use standard HTTP response codes.
All resources are located in the Shell Card Platform.  The Shell Card Platform is the overall platform that encompasses all the internal Shell systems used to manage resources.
All endpoints use the `POST` verb for retrieving, updating, creating and deleting resources in the Shell Card Platform. The endpoints that retrieve resources from the Shell Card Platform allow flexible search parameters in the API request body.

Go to the Shell Developer Portal: [https://developer.shell.com](https://developer.shell.com)

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.DataAndReportingSDK --version 1.1.0
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.DataAndReportingSDK/1.1.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.SIT`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthCredentials` | [`BasicAuthCredentials`](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |
| `BearerTokenCredentials` | [`BearerTokenCredentials`](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/auth/oauth-2-client-credentials-grant.md) | The Credentials Setter for OAuth 2 Client Credentials Grant |

The API client can be initialized as follows:

```csharp
ShellDataReportingAPIsClient client = new ShellDataReportingAPIsClient.Builder()
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "Username",
            "Password"
        )
        .Build())
    .BearerTokenCredentials(
        new BearerTokenModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Environment(ShellDataReportingAPIs.Standard.Environment.SIT)
    .Build();
```

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| SIT | **Default** |
| Production | - |

## Authorization

This API uses the following authentication schemes.

* [`BasicAuth (Basic Authentication)`](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/auth/basic-authentication.md)
* [`BearerToken (OAuth 2 Client Credentials Grant)`](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/auth/oauth-2-client-credentials-grant.md)

## List of APIs

* [Customer](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/controllers/customer.md)
* [Transaction](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/controllers/transaction.md)
* [Invoice](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/controllers/invoice.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sdks-io/data-and-reporting-dotnet-sdk/tree/1.1.0/doc/api-exception.md)

