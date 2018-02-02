# TweakApi.Api.PublicVBuilderConfigApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1BuilderConfigDefaultGet**](PublicVBuilderConfigApi.md#v1builderconfigdefaultget) | **GET** /v1/BuilderConfig/default | Get default BuilderConfig
[**V1BuilderConfigDefaultProductSizeMaterialsGet**](PublicVBuilderConfigApi.md#v1builderconfigdefaultproductsizematerialsget) | **GET** /v1/BuilderConfig/default/productSizeMaterials | Get default BuilderConfig ProductSizeMaterial


<a name="v1builderconfigdefaultget"></a>
# **V1BuilderConfigDefaultGet**
> TeamBuilderConfig V1BuilderConfigDefaultGet ()

Get default BuilderConfig

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1BuilderConfigDefaultGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");
            // Configure API key authorization: teamKey
            Configuration.Default.ApiKey.Add("teamKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("teamKey", "Bearer");

            var apiInstance = new PublicVBuilderConfigApi();

            try
            {
                // Get default BuilderConfig
                TeamBuilderConfig result = apiInstance.V1BuilderConfigDefaultGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVBuilderConfigApi.V1BuilderConfigDefaultGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1builderconfigdefaultproductsizematerialsget"></a>
# **V1BuilderConfigDefaultProductSizeMaterialsGet**
> List<ProductSizeMaterial> V1BuilderConfigDefaultProductSizeMaterialsGet ()

Get default BuilderConfig ProductSizeMaterial

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1BuilderConfigDefaultProductSizeMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");
            // Configure API key authorization: teamKey
            Configuration.Default.ApiKey.Add("teamKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("teamKey", "Bearer");

            var apiInstance = new PublicVBuilderConfigApi();

            try
            {
                // Get default BuilderConfig ProductSizeMaterial
                List&lt;ProductSizeMaterial&gt; result = apiInstance.V1BuilderConfigDefaultProductSizeMaterialsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVBuilderConfigApi.V1BuilderConfigDefaultProductSizeMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ProductSizeMaterial>**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

