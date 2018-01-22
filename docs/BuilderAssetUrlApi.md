# TweakApi.Api.BuilderAssetUrlApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuilderAssetUrlsDesignsIdGet**](BuilderAssetUrlApi.md#builderasseturlsdesignsidget) | **GET** /BuilderAsset/urls/designs/{id} | Get folders for Builder Asset Backgrounds
[**BuilderAssetUrlsTemplatesIdGet**](BuilderAssetUrlApi.md#builderasseturlstemplatesidget) | **GET** /BuilderAsset/urls/templates/{id} | Get folders for Builder Asset Backgrounds
[**BuilderAssetUrlsTweakTemplatesIdGet**](BuilderAssetUrlApi.md#builderasseturlstweaktemplatesidget) | **GET** /BuilderAsset/urls/tweakTemplates/{id} | Get folders for Builder Asset Backgrounds


<a name="builderasseturlsdesignsidget"></a>
# **BuilderAssetUrlsDesignsIdGet**
> InlineResponse200 BuilderAssetUrlsDesignsIdGet (string id)

Get folders for Builder Asset Backgrounds

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class BuilderAssetUrlsDesignsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BuilderAssetUrlApi();
            var id = id_example;  // string | Design Id

            try
            {
                // Get folders for Builder Asset Backgrounds
                InlineResponse200 result = apiInstance.BuilderAssetUrlsDesignsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuilderAssetUrlApi.BuilderAssetUrlsDesignsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design Id | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="builderasseturlstemplatesidget"></a>
# **BuilderAssetUrlsTemplatesIdGet**
> InlineResponse200 BuilderAssetUrlsTemplatesIdGet (string id)

Get folders for Builder Asset Backgrounds

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class BuilderAssetUrlsTemplatesIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BuilderAssetUrlApi();
            var id = id_example;  // string | Template Id

            try
            {
                // Get folders for Builder Asset Backgrounds
                InlineResponse200 result = apiInstance.BuilderAssetUrlsTemplatesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuilderAssetUrlApi.BuilderAssetUrlsTemplatesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Template Id | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="builderasseturlstweaktemplatesidget"></a>
# **BuilderAssetUrlsTweakTemplatesIdGet**
> InlineResponse200 BuilderAssetUrlsTweakTemplatesIdGet (string id)

Get folders for Builder Asset Backgrounds

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class BuilderAssetUrlsTweakTemplatesIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BuilderAssetUrlApi();
            var id = id_example;  // string | Tweak Template Id

            try
            {
                // Get folders for Builder Asset Backgrounds
                InlineResponse200 result = apiInstance.BuilderAssetUrlsTweakTemplatesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuilderAssetUrlApi.BuilderAssetUrlsTweakTemplatesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tweak Template Id | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

