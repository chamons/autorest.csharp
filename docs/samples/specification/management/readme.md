# Sample Management Generation

To generate a [management plane][mgmt] client library sample run:

`npx autorest --csharp --azure-arm --require=readme.md --output-folder=.\Generated`

For more information, see our [flag index][flag_index]

### Settings

``` yaml
input-file: ../../../../node_modules/@microsoft.azure/autorest.testserver/swagger/head.json
namespace: Azure.Mgmt.Sample
license-header: MICROSOFT_MIT_NO_VERSION
azure-arm: true
clear-output-folder: true
```

<!-- LINKS -->
[mgmt]: https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/control-plane-and-data-plane#control-plane
[flag_index]: https://github.com/Azure/autorest/tree/master/docs/generate/flags.md