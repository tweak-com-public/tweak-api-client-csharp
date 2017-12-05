# TweakApi.Api.BuilderAssetBackgroundApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuilderAssetBackgroundsFoldersFolderPathGet**](BuilderAssetBackgroundApi.md#builderassetbackgroundsfoldersfolderpathget) | **GET** /BuilderAsset/backgrounds/folders/{folderPath} | Get Builder Asset Backgrounds on a folders
[**BuilderAssetBackgroundsFoldersGet**](BuilderAssetBackgroundApi.md#builderassetbackgroundsfoldersget) | **GET** /BuilderAsset/backgrounds/folders | Get folders for Builder Asset Backgrounds
[**BuilderAssetBackgroundsGet**](BuilderAssetBackgroundApi.md#builderassetbackgroundsget) | **GET** /BuilderAsset/backgrounds | Get all Builder Asset Backgrounds


<a name="builderassetbackgroundsfoldersfolderpathget"></a>
# **BuilderAssetBackgroundsFoldersFolderPathGet**
> List<CloudinaryImage> BuilderAssetBackgroundsFoldersFolderPathGet (string folderPath, string filter = null)

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
    public class BuilderAssetBackgroundsFoldersFolderPathGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BuilderAssetBackgroundApi();
            var folderPath = folderPath_example;  // string | Folder path for backgrounds
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Get Builder Asset Backgrounds on a folders
                List&lt;CloudinaryImage&gt; result = apiInstance.BuilderAssetBackgroundsFoldersFolderPathGet(folderPath, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuilderAssetBackgroundApi.BuilderAssetBackgroundsFoldersFolderPathGet: " + e.Message );
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

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="builderassetbackgroundsfoldersget"></a>
# **BuilderAssetBackgroundsFoldersGet**
> List<BuilderAssetBackgroundFolder> BuilderAssetBackgroundsFoldersGet ()

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
    public class BuilderAssetBackgroundsFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BuilderAssetBackgroundApi();

            try
            {
                // Get folders for Builder Asset Backgrounds
                List&lt;BuilderAssetBackgroundFolder&gt; result = apiInstance.BuilderAssetBackgroundsFoldersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuilderAssetBackgroundApi.BuilderAssetBackgroundsFoldersGet: " + e.Message );
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

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="builderassetbackgroundsget"></a>
# **BuilderAssetBackgroundsGet**
> List<CloudinaryImage> BuilderAssetBackgroundsGet (string filter = null)

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
    public class BuilderAssetBackgroundsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BuilderAssetBackgroundApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Get all Builder Asset Backgrounds
                List&lt;CloudinaryImage&gt; result = apiInstance.BuilderAssetBackgroundsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BuilderAssetBackgroundApi.BuilderAssetBackgroundsGet: " + e.Message );
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

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

