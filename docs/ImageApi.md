# TweakApi.Api.ImageApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImagesChangeStreamGet**](ImageApi.md#imageschangestreamget) | **GET** /Images/change-stream | Create a change stream.
[**ImagesChangeStreamPost**](ImageApi.md#imageschangestreampost) | **POST** /Images/change-stream | Create a change stream.
[**ImagesCountGet**](ImageApi.md#imagescountget) | **GET** /Images/count | Count instances of the model matched by where from the data source.
[**ImagesFindOneGet**](ImageApi.md#imagesfindoneget) | **GET** /Images/findOne | Find first instance of the model matched by filter from the data source.
[**ImagesGet**](ImageApi.md#imagesget) | **GET** /Images | Find all instances of the model matched by filter from the data source.
[**ImagesIdDelete**](ImageApi.md#imagesiddelete) | **DELETE** /Images/{id} | Delete a model instance by {{id}} from the data source.
[**ImagesIdExistsGet**](ImageApi.md#imagesidexistsget) | **GET** /Images/{id}/exists | Check whether a model instance exists in the data source.
[**ImagesIdFolderGet**](ImageApi.md#imagesidfolderget) | **GET** /Images/{id}/folder | Fetches belongsTo relation folder.
[**ImagesIdGet**](ImageApi.md#imagesidget) | **GET** /Images/{id} | Find a model instance by {{id}} from the data source.
[**ImagesIdHead**](ImageApi.md#imagesidhead) | **HEAD** /Images/{id} | Check whether a model instance exists in the data source.
[**ImagesIdPatch**](ImageApi.md#imagesidpatch) | **PATCH** /Images/{id} | Patch attributes for a model instance and persist it into the data source.
[**ImagesIdPut**](ImageApi.md#imagesidput) | **PUT** /Images/{id} | Replace attributes for a model instance and persist it into the data source.
[**ImagesIdReplacePost**](ImageApi.md#imagesidreplacepost) | **POST** /Images/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**ImagesIdTeamGet**](ImageApi.md#imagesidteamget) | **GET** /Images/{id}/team | Fetches belongsTo relation team.
[**ImagesPatch**](ImageApi.md#imagespatch) | **PATCH** /Images | Patch an existing model instance or insert a new one into the data source.
[**ImagesPost**](ImageApi.md#imagespost) | **POST** /Images | Create a new instance of the model and persist it into the data source.
[**ImagesPut**](ImageApi.md#imagesput) | **PUT** /Images | Replace an existing model instance or insert a new one into the data source.
[**ImagesReplaceOrCreatePost**](ImageApi.md#imagesreplaceorcreatepost) | **POST** /Images/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**ImagesUpdatePost**](ImageApi.md#imagesupdatepost) | **POST** /Images/update | Update instances of the model matched by {{where}} from the data source.
[**ImagesUpsertWithWherePost**](ImageApi.md#imagesupsertwithwherepost) | **POST** /Images/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="imageschangestreamget"></a>
# **ImagesChangeStreamGet**
> System.IO.Stream ImagesChangeStreamGet (string options = null)

Create a change stream.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.ImagesChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesChangeStreamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **options** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imageschangestreampost"></a>
# **ImagesChangeStreamPost**
> System.IO.Stream ImagesChangeStreamPost (string options = null)

Create a change stream.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.ImagesChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesChangeStreamPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **options** | **string**|  | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagescountget"></a>
# **ImagesCountGet**
> InlineResponse200 ImagesCountGet (string where = null)

Count instances of the model matched by where from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.ImagesCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesfindoneget"></a>
# **ImagesFindOneGet**
> Image ImagesFindOneGet (string filter = null)

Find first instance of the model matched by filter from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                Image result = apiInstance.ImagesFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesFindOneGet: " + e.Message );
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

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesget"></a>
# **ImagesGet**
> List<Image> ImagesGet (string filter = null)

Find all instances of the model matched by filter from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;Image&gt; result = apiInstance.ImagesGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesGet: " + e.Message );
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

[**List<Image>**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesiddelete"></a>
# **ImagesIdDelete**
> Object ImagesIdDelete (string id)

Delete a model instance by {{id}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.ImagesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesidexistsget"></a>
# **ImagesIdExistsGet**
> InlineResponse2002 ImagesIdExistsGet (string id)

Check whether a model instance exists in the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.ImagesIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdExistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesidfolderget"></a>
# **ImagesIdFolderGet**
> ImageFolder ImagesIdFolderGet (string id, bool? refresh = null)

Fetches belongsTo relation folder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdFolderGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Image id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation folder.
                ImageFolder result = apiInstance.ImagesIdFolderGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdFolderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Image id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesidget"></a>
# **ImagesIdGet**
> Image ImagesIdGet (string id, string filter = null)

Find a model instance by {{id}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                Image result = apiInstance.ImagesIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesidhead"></a>
# **ImagesIdHead**
> InlineResponse2002 ImagesIdHead (string id)

Check whether a model instance exists in the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.ImagesIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesidpatch"></a>
# **ImagesIdPatch**
> Image ImagesIdPatch (string id, Image data = null)

Patch attributes for a model instance and persist it into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Image id
            var data = new Image(); // Image | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                Image result = apiInstance.ImagesIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Image id | 
 **data** | [**Image**](Image.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesidput"></a>
# **ImagesIdPut**
> Image ImagesIdPut (string id, Image data = null)

Replace attributes for a model instance and persist it into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Model id
            var data = new Image(); // Image | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Image result = apiInstance.ImagesIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Image**](Image.md)| Model instance data | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesidreplacepost"></a>
# **ImagesIdReplacePost**
> Image ImagesIdReplacePost (string id, Image data = null)

Replace attributes for a model instance and persist it into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Model id
            var data = new Image(); // Image | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Image result = apiInstance.ImagesIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Image**](Image.md)| Model instance data | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesidteamget"></a>
# **ImagesIdTeamGet**
> Team ImagesIdTeamGet (string id, bool? refresh = null)

Fetches belongsTo relation team.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var id = id_example;  // string | Image id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.ImagesIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Image id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagespatch"></a>
# **ImagesPatch**
> Image ImagesPatch (Image data = null)

Patch an existing model instance or insert a new one into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var data = new Image(); // Image | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                Image result = apiInstance.ImagesPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Image**](Image.md)| Model instance data | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagespost"></a>
# **ImagesPost**
> Image ImagesPost (Image data = null)

Create a new instance of the model and persist it into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var data = new Image(); // Image | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                Image result = apiInstance.ImagesPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Image**](Image.md)| Model instance data | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesput"></a>
# **ImagesPut**
> Image ImagesPut (Image data = null)

Replace an existing model instance or insert a new one into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var data = new Image(); // Image | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Image result = apiInstance.ImagesPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Image**](Image.md)| Model instance data | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesreplaceorcreatepost"></a>
# **ImagesReplaceOrCreatePost**
> Image ImagesReplaceOrCreatePost (Image data = null)

Replace an existing model instance or insert a new one into the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var data = new Image(); // Image | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Image result = apiInstance.ImagesReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Image**](Image.md)| Model instance data | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesupdatepost"></a>
# **ImagesUpdatePost**
> InlineResponse2001 ImagesUpdatePost (string where = null, Image data = null)

Update instances of the model matched by {{where}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Image(); // Image | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2001 result = apiInstance.ImagesUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Image**](Image.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagesupsertwithwherepost"></a>
# **ImagesUpsertWithWherePost**
> Image ImagesUpsertWithWherePost (string where = null, Image data = null)

Update an existing model instance or insert a new one into the data source based on the where criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImagesUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Image(); // Image | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                Image result = apiInstance.ImagesUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageApi.ImagesUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Image**](Image.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Image**](Image.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

