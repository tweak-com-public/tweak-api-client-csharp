# TweakApi.Api.PublicVBuilderAssetApi

All URIs are relative to *https://apicdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1BuilderAssetBackgroundsFoldersFolderPathGet**](PublicVBuilderAssetApi.md#v1builderassetbackgroundsfoldersfolderpathget) | **GET** /v1/BuilderAsset/backgrounds/folders/{folderPath} | Get Builder Asset Backgrounds on a folders
[**V1BuilderAssetBackgroundsFoldersGet**](PublicVBuilderAssetApi.md#v1builderassetbackgroundsfoldersget) | **GET** /v1/BuilderAsset/backgrounds/folders | Get folders for Builder Asset Backgrounds
[**V1BuilderAssetBackgroundsGet**](PublicVBuilderAssetApi.md#v1builderassetbackgroundsget) | **GET** /v1/BuilderAsset/backgrounds | Get all Builder Asset Backgrounds


<a name="v1builderassetbackgroundsfoldersfolderpathget"></a>
# **V1BuilderAssetBackgroundsFoldersFolderPathGet**
> List<CloudinaryImage> V1BuilderAssetBackgroundsFoldersFolderPathGet (string folderPath, string filter = null)

Get Builder Asset Backgrounds on a folders

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1BuilderAssetBackgroundsFoldersFolderPathGetExample
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

            var apiInstance = new PublicVBuilderAssetApi();
            var folderPath = folderPath_example;  // string | Folder path for backgrounds
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Get Builder Asset Backgrounds on a folders
                List&lt;CloudinaryImage&gt; result = apiInstance.V1BuilderAssetBackgroundsFoldersFolderPathGet(folderPath, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVBuilderAssetApi.V1BuilderAssetBackgroundsFoldersFolderPathGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderPath** | **string**| Folder path for backgrounds | 
 **filter** | **string**| Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<CloudinaryImage>**](CloudinaryImage.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1builderassetbackgroundsfoldersget"></a>
# **V1BuilderAssetBackgroundsFoldersGet**
> List<BuilderAssetBackgroundFolder> V1BuilderAssetBackgroundsFoldersGet ()

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
    public class V1BuilderAssetBackgroundsFoldersGetExample
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

            var apiInstance = new PublicVBuilderAssetApi();

            try
            {
                // Get folders for Builder Asset Backgrounds
                List&lt;BuilderAssetBackgroundFolder&gt; result = apiInstance.V1BuilderAssetBackgroundsFoldersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVBuilderAssetApi.V1BuilderAssetBackgroundsFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<BuilderAssetBackgroundFolder>**](BuilderAssetBackgroundFolder.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1builderassetbackgroundsget"></a>
# **V1BuilderAssetBackgroundsGet**
> List<CloudinaryImage> V1BuilderAssetBackgroundsGet (string filter = null)

Get all Builder Asset Backgrounds

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1BuilderAssetBackgroundsGetExample
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

            var apiInstance = new PublicVBuilderAssetApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Get all Builder Asset Backgrounds
                List&lt;CloudinaryImage&gt; result = apiInstance.V1BuilderAssetBackgroundsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVBuilderAssetApi.V1BuilderAssetBackgroundsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**List<CloudinaryImage>**](CloudinaryImage.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

