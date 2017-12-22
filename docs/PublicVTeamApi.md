# TweakApi.Api.PublicVTeamApi

All URIs are relative to *https://apicdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1TeamBuilderConfigsDefaultGet**](PublicVTeamApi.md#v1teambuilderconfigsdefaultget) | **GET** /v1/Team/builderConfigs/default | Get default Team&#39;s BuilderConfig
[**V1TeamBuilderConfigsDefaultProductSizeMaterialsGet**](PublicVTeamApi.md#v1teambuilderconfigsdefaultproductsizematerialsget) | **GET** /v1/Team/builderConfigs/default/productSizeMaterials | Get default Team&#39;s BuilderConfig ProductSizeMaterial
[**V1TeamBuilderConfigsIdGet**](PublicVTeamApi.md#v1teambuilderconfigsidget) | **GET** /v1/Team/builderConfigs/{id} | Get Team&#39;s BuilderConfig by id
[**V1TeamBuilderConfigsIdProductSizeMaterialsGet**](PublicVTeamApi.md#v1teambuilderconfigsidproductsizematerialsget) | **GET** /v1/Team/builderConfigs/{id}/productSizeMaterials | Get Team&#39;s BuilderConfig ProductSizeMaterial by BuilderConfig id


<a name="v1teambuilderconfigsdefaultget"></a>
# **V1TeamBuilderConfigsDefaultGet**
> TeamBuilderConfig V1TeamBuilderConfigsDefaultGet ()

Get default Team's BuilderConfig

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1TeamBuilderConfigsDefaultGetExample
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

            var apiInstance = new PublicVTeamApi();

            try
            {
                // Get default Team's BuilderConfig
                TeamBuilderConfig result = apiInstance.V1TeamBuilderConfigsDefaultGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVTeamApi.V1TeamBuilderConfigsDefaultGet: " + e.Message );
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

<a name="v1teambuilderconfigsdefaultproductsizematerialsget"></a>
# **V1TeamBuilderConfigsDefaultProductSizeMaterialsGet**
> ProductSizeMaterial V1TeamBuilderConfigsDefaultProductSizeMaterialsGet ()

Get default Team's BuilderConfig ProductSizeMaterial

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1TeamBuilderConfigsDefaultProductSizeMaterialsGetExample
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

            var apiInstance = new PublicVTeamApi();

            try
            {
                // Get default Team's BuilderConfig ProductSizeMaterial
                ProductSizeMaterial result = apiInstance.V1TeamBuilderConfigsDefaultProductSizeMaterialsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVTeamApi.V1TeamBuilderConfigsDefaultProductSizeMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1teambuilderconfigsidget"></a>
# **V1TeamBuilderConfigsIdGet**
> TeamBuilderConfig V1TeamBuilderConfigsIdGet (string id)

Get Team's BuilderConfig by id

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1TeamBuilderConfigsIdGetExample
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

            var apiInstance = new PublicVTeamApi();
            var id = id_example;  // string | BuilderConfig id

            try
            {
                // Get Team's BuilderConfig by id
                TeamBuilderConfig result = apiInstance.V1TeamBuilderConfigsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVTeamApi.V1TeamBuilderConfigsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| BuilderConfig id | 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1teambuilderconfigsidproductsizematerialsget"></a>
# **V1TeamBuilderConfigsIdProductSizeMaterialsGet**
> TeamBuilderConfigProductSizeMaterial V1TeamBuilderConfigsIdProductSizeMaterialsGet (string id)

Get Team's BuilderConfig ProductSizeMaterial by BuilderConfig id

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1TeamBuilderConfigsIdProductSizeMaterialsGetExample
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

            var apiInstance = new PublicVTeamApi();
            var id = id_example;  // string | BuilderConfig id

            try
            {
                // Get Team's BuilderConfig ProductSizeMaterial by BuilderConfig id
                TeamBuilderConfigProductSizeMaterial result = apiInstance.V1TeamBuilderConfigsIdProductSizeMaterialsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVTeamApi.V1TeamBuilderConfigsIdProductSizeMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| BuilderConfig id | 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

