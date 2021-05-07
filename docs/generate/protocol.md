# Creating Clients that use Protocol Methods

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