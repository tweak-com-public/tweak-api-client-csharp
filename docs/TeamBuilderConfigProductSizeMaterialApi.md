# TweakApi.Api.TeamBuilderConfigProductSizeMaterialApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamBuilderConfigProductSizeMaterialsChangeStreamGet**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialschangestreamget) | **GET** /TeamBuilderConfigProductSizeMaterials/change-stream | Create a change stream.
[**TeamBuilderConfigProductSizeMaterialsChangeStreamPost**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialschangestreampost) | **POST** /TeamBuilderConfigProductSizeMaterials/change-stream | Create a change stream.
[**TeamBuilderConfigProductSizeMaterialsCountGet**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialscountget) | **GET** /TeamBuilderConfigProductSizeMaterials/count | Count instances of the model matched by where from the data source.
[**TeamBuilderConfigProductSizeMaterialsFindOneGet**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsfindoneget) | **GET** /TeamBuilderConfigProductSizeMaterials/findOne | Find first instance of the model matched by filter from the data source.
[**TeamBuilderConfigProductSizeMaterialsGet**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsget) | **GET** /TeamBuilderConfigProductSizeMaterials | Find all instances of the model matched by filter from the data source.
[**TeamBuilderConfigProductSizeMaterialsIdBuilderConfigGet**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsidbuilderconfigget) | **GET** /TeamBuilderConfigProductSizeMaterials/{id}/builderConfig | Fetches belongsTo relation builderConfig.
[**TeamBuilderConfigProductSizeMaterialsIdDelete**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsiddelete) | **DELETE** /TeamBuilderConfigProductSizeMaterials/{id} | Delete a model instance by {{id}} from the data source.
[**TeamBuilderConfigProductSizeMaterialsIdExistsGet**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsidexistsget) | **GET** /TeamBuilderConfigProductSizeMaterials/{id}/exists | Check whether a model instance exists in the data source.
[**TeamBuilderConfigProductSizeMaterialsIdGet**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsidget) | **GET** /TeamBuilderConfigProductSizeMaterials/{id} | Find a model instance by {{id}} from the data source.
[**TeamBuilderConfigProductSizeMaterialsIdHead**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsidhead) | **HEAD** /TeamBuilderConfigProductSizeMaterials/{id} | Check whether a model instance exists in the data source.
[**TeamBuilderConfigProductSizeMaterialsIdPatch**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsidpatch) | **PATCH** /TeamBuilderConfigProductSizeMaterials/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductSizeMaterialsIdProductSizeMaterialGet**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsidproductsizematerialget) | **GET** /TeamBuilderConfigProductSizeMaterials/{id}/productSizeMaterial | Fetches belongsTo relation productSizeMaterial.
[**TeamBuilderConfigProductSizeMaterialsIdPut**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsidput) | **PUT** /TeamBuilderConfigProductSizeMaterials/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductSizeMaterialsIdReplacePost**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsidreplacepost) | **POST** /TeamBuilderConfigProductSizeMaterials/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductSizeMaterialsPatch**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialspatch) | **PATCH** /TeamBuilderConfigProductSizeMaterials | Patch an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductSizeMaterialsPost**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialspost) | **POST** /TeamBuilderConfigProductSizeMaterials | Create a new instance of the model and persist it into the data source.
[**TeamBuilderConfigProductSizeMaterialsPut**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsput) | **PUT** /TeamBuilderConfigProductSizeMaterials | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductSizeMaterialsReplaceOrCreatePost**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsreplaceorcreatepost) | **POST** /TeamBuilderConfigProductSizeMaterials/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductSizeMaterialsUpdatePost**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsupdatepost) | **POST** /TeamBuilderConfigProductSizeMaterials/update | Update instances of the model matched by {{where}} from the data source.
[**TeamBuilderConfigProductSizeMaterialsUpsertWithWherePost**](TeamBuilderConfigProductSizeMaterialApi.md#teambuilderconfigproductsizematerialsupsertwithwherepost) | **POST** /TeamBuilderConfigProductSizeMaterials/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teambuilderconfigproductsizematerialschangestreamget"></a>
# **TeamBuilderConfigProductSizeMaterialsChangeStreamGet**
> System.IO.Stream TeamBuilderConfigProductSizeMaterialsChangeStreamGet (string options = null)

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
    public class TeamBuilderConfigProductSizeMaterialsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigProductSizeMaterialsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsChangeStreamGet: " + e.Message );
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

<a name="teambuilderconfigproductsizematerialschangestreampost"></a>
# **TeamBuilderConfigProductSizeMaterialsChangeStreamPost**
> System.IO.Stream TeamBuilderConfigProductSizeMaterialsChangeStreamPost (string options = null)

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
    public class TeamBuilderConfigProductSizeMaterialsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigProductSizeMaterialsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsChangeStreamPost: " + e.Message );
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

<a name="teambuilderconfigproductsizematerialscountget"></a>
# **TeamBuilderConfigProductSizeMaterialsCountGet**
> InlineResponse200 TeamBuilderConfigProductSizeMaterialsCountGet (string where = null)

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
    public class TeamBuilderConfigProductSizeMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.TeamBuilderConfigProductSizeMaterialsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsCountGet: " + e.Message );
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

<a name="teambuilderconfigproductsizematerialsfindoneget"></a>
# **TeamBuilderConfigProductSizeMaterialsFindOneGet**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsFindOneGet (string filter = null)

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
    public class TeamBuilderConfigProductSizeMaterialsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsFindOneGet: " + e.Message );
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

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsget"></a>
# **TeamBuilderConfigProductSizeMaterialsGet**
> List<TeamBuilderConfigProductSizeMaterial> TeamBuilderConfigProductSizeMaterialsGet (string filter = null)

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
    public class TeamBuilderConfigProductSizeMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TeamBuilderConfigProductSizeMaterial&gt; result = apiInstance.TeamBuilderConfigProductSizeMaterialsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsGet: " + e.Message );
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

[**List<TeamBuilderConfigProductSizeMaterial>**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsidbuilderconfigget"></a>
# **TeamBuilderConfigProductSizeMaterialsIdBuilderConfigGet**
> TeamBuilderConfig TeamBuilderConfigProductSizeMaterialsIdBuilderConfigGet (string id, bool? refresh = null)

Fetches belongsTo relation builderConfig.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigProductSizeMaterialsIdBuilderConfigGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | TeamBuilderConfigProductSizeMaterial id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation builderConfig.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdBuilderConfigGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdBuilderConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductSizeMaterial id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsiddelete"></a>
# **TeamBuilderConfigProductSizeMaterialsIdDelete**
> Object TeamBuilderConfigProductSizeMaterialsIdDelete (string id)

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
    public class TeamBuilderConfigProductSizeMaterialsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdDelete: " + e.Message );
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

<a name="teambuilderconfigproductsizematerialsidexistsget"></a>
# **TeamBuilderConfigProductSizeMaterialsIdExistsGet**
> InlineResponse2001 TeamBuilderConfigProductSizeMaterialsIdExistsGet (string id)

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
    public class TeamBuilderConfigProductSizeMaterialsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdExistsGet: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsidget"></a>
# **TeamBuilderConfigProductSizeMaterialsIdGet**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsIdGet (string id, string filter = null)

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
    public class TeamBuilderConfigProductSizeMaterialsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdGet: " + e.Message );
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

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsidhead"></a>
# **TeamBuilderConfigProductSizeMaterialsIdHead**
> InlineResponse2001 TeamBuilderConfigProductSizeMaterialsIdHead (string id)

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
    public class TeamBuilderConfigProductSizeMaterialsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdHead: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsidpatch"></a>
# **TeamBuilderConfigProductSizeMaterialsIdPatch**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsIdPatch (string id, TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | TeamBuilderConfigProductSizeMaterial id
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductSizeMaterial id | 
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsidproductsizematerialget"></a>
# **TeamBuilderConfigProductSizeMaterialsIdProductSizeMaterialGet**
> ProductSizeMaterial TeamBuilderConfigProductSizeMaterialsIdProductSizeMaterialGet (string id, bool? refresh = null)

Fetches belongsTo relation productSizeMaterial.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigProductSizeMaterialsIdProductSizeMaterialGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | TeamBuilderConfigProductSizeMaterial id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation productSizeMaterial.
                ProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdProductSizeMaterialGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdProductSizeMaterialGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductSizeMaterial id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsidput"></a>
# **TeamBuilderConfigProductSizeMaterialsIdPut**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsIdPut (string id, TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsidreplacepost"></a>
# **TeamBuilderConfigProductSizeMaterialsIdReplacePost**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsIdReplacePost (string id, TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialspatch"></a>
# **TeamBuilderConfigProductSizeMaterialsPatch**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsPatch (TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialspost"></a>
# **TeamBuilderConfigProductSizeMaterialsPost**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsPost (TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsput"></a>
# **TeamBuilderConfigProductSizeMaterialsPut**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsPut (TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsreplaceorcreatepost"></a>
# **TeamBuilderConfigProductSizeMaterialsReplaceOrCreatePost**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsReplaceOrCreatePost (TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsupdatepost"></a>
# **TeamBuilderConfigProductSizeMaterialsUpdatePost**
> InlineResponse2002 TeamBuilderConfigProductSizeMaterialsUpdatePost (string where = null, TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.TeamBuilderConfigProductSizeMaterialsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductsizematerialsupsertwithwherepost"></a>
# **TeamBuilderConfigProductSizeMaterialsUpsertWithWherePost**
> TeamBuilderConfigProductSizeMaterial TeamBuilderConfigProductSizeMaterialsUpsertWithWherePost (string where = null, TeamBuilderConfigProductSizeMaterial data = null)

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
    public class TeamBuilderConfigProductSizeMaterialsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductSizeMaterialApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfigProductSizeMaterial(); // TeamBuilderConfigProductSizeMaterial | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TeamBuilderConfigProductSizeMaterial result = apiInstance.TeamBuilderConfigProductSizeMaterialsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductSizeMaterialApi.TeamBuilderConfigProductSizeMaterialsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfigProductSizeMaterial**](TeamBuilderConfigProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

