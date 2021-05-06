# C# Azure SDK Clients that Contain Protocol Methods

## Introduction

Some SDK Clients expose methods which often take `RequestContent` parameters and return `Response` instead of the usual generated models.

For example:

```
        async Task<Response> GetDogAsync(RequestContent requestBody, CancellationToken cancellationToken = default)
        async Task<Response> SetDogAsync(RequestContent requestBody, CancellationToken cancellationToken = default)
```

instead of:
```
        async Task<Response<Pet>> GetDogAsync(string dogName, CancellationToken cancellationToken = default)
        async Task<Response> SetDogAsync(Pet dog, CancellationToken cancellationToken = default)
```

Those methods are called '**protocol methods**'. 

This quickstart is designed to review their use and configuring autorest.csharp to generate clients with them.

## Usage

The basic structure of calls with clients remain the same if they use protocol methods or methods with models:

1. [Initialize your client](#1-initialize-your-client "Initialize Your Client")
2. [Create a request](#2-create-a-request "Create a Request")
3. [Send the request](#3-send-the-request "Send the Request")
4. [Handle the response](#4-handle-the-response "Handle the Response")

## 1. Initialize Your Client

As [documented][initializing] the first step in interacting with a service is to create a client instance. 

The only difference is that sometimes these clients will be more specific in the credential required ('AzureKeyCredential' or 'TokenCredential' for example).

## 2. Create and Send a Request

Protocol methods need a JSON object of the shape required by the service in question.

See the specific service documentation for details, but as a example:

```
        var data = new JsonData(
            new Dictionary<string, object> {
                ["name"] = "Buddy",
                ["id"] = 2,
                ["color"] = "Brown"
            });
        await client.SetDogAsync(RequestContent.Create(data));
```

## 3. Handle the Response

Protocol methods all return a `Response` object which contains information returned from the service request. 

The most important field on Response indicates the status code returned:

```
        Response response = await client.GetDogAsync(RequestContent.Create(new Dictionary<string, object> {
                ["name"] = "Buddy"
        }));
        int code = response.Status;
```

By default protocol methods match the behavior of methods that return models by throwing a C# exception when an error code is returned.

This can be controlled by use of the `RequestOptions` parameter:

```
        RequestOptions options = new RequestOptions (ResponseStatusOption.NoThrow);
        Response response = await client.GetDogAsync(RequestContent.Create(new Dictionary<string, object> {
                ["name"] = "Buddy"
        }), options);
        int code = response.Status;
```

Some service methods return detailed information within the response. The easiest way to access that is to convert it to `JsonData`.

See the service documentation for details, but as a example:

```
        Response response = await client.GetDogAsync(RequestContent.Create(new Dictionary<string, object> {
                ["name"] = "Buddy"
        }));
        var responseBody = JsonData.FromBytes(response.Content.ToMemory());
        string name = (string)responseBody["name"];
```

## Per Call Callbacks

Protocol methods that take the `RequestOptions` type also allows easy access to callbacks when a response arrives:

```
        RequestOptions options = new RequestOptions (message => Console.WriteLine ("Dog Received: " + message)));
        return client.GetDogAsync(RequestContent.Create(new Dictionary<string, object> {
                ["name"] = "Buddy"
        }), options);
```

## Creating Clients that use Protocol Methods

Within the standard readme.md or autorest.md configuration file, set the following key:

```
low-level-client: true
```

Today autorest.csharp also requires a defined credential type [limitation issue](https://github.com/Azure/autorest.csharp/issues/1221):

```
credential-types: AzureKeyCredential
credential-header-name: Ocp-Apim-Subscription-Key
```
and\or
```
credential-types: TokenCredential
credential-scopes: https://example.azure.com/.default
```

<!-- LINKS -->
[initializing]: ./client/initializing.md
