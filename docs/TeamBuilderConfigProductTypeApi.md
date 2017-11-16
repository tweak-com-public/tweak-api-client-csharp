# TweakApi.Api.TeamBuilderConfigProductTypeApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamBuilderConfigProductTypesChangeStreamGet**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypeschangestreamget) | **GET** /TeamBuilderConfigProductTypes/change-stream | Create a change stream.
[**TeamBuilderConfigProductTypesChangeStreamPost**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypeschangestreampost) | **POST** /TeamBuilderConfigProductTypes/change-stream | Create a change stream.
[**TeamBuilderConfigProductTypesCountGet**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypescountget) | **GET** /TeamBuilderConfigProductTypes/count | Count instances of the model matched by where from the data source.
[**TeamBuilderConfigProductTypesFindOneGet**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesfindoneget) | **GET** /TeamBuilderConfigProductTypes/findOne | Find first instance of the model matched by filter from the data source.
[**TeamBuilderConfigProductTypesGet**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesget) | **GET** /TeamBuilderConfigProductTypes | Find all instances of the model matched by filter from the data source.
[**TeamBuilderConfigProductTypesIdBuilderConfigGet**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesidbuilderconfigget) | **GET** /TeamBuilderConfigProductTypes/{id}/builderConfig | Fetches belongsTo relation builderConfig.
[**TeamBuilderConfigProductTypesIdDelete**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesiddelete) | **DELETE** /TeamBuilderConfigProductTypes/{id} | Delete a model instance by {{id}} from the data source.
[**TeamBuilderConfigProductTypesIdExistsGet**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesidexistsget) | **GET** /TeamBuilderConfigProductTypes/{id}/exists | Check whether a model instance exists in the data source.
[**TeamBuilderConfigProductTypesIdGet**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesidget) | **GET** /TeamBuilderConfigProductTypes/{id} | Find a model instance by {{id}} from the data source.
[**TeamBuilderConfigProductTypesIdHead**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesidhead) | **HEAD** /TeamBuilderConfigProductTypes/{id} | Check whether a model instance exists in the data source.
[**TeamBuilderConfigProductTypesIdPatch**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesidpatch) | **PATCH** /TeamBuilderConfigProductTypes/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductTypesIdProductTypeGet**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesidproducttypeget) | **GET** /TeamBuilderConfigProductTypes/{id}/productType | Fetches belongsTo relation productType.
[**TeamBuilderConfigProductTypesIdPut**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesidput) | **PUT** /TeamBuilderConfigProductTypes/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductTypesIdReplacePost**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesidreplacepost) | **POST** /TeamBuilderConfigProductTypes/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductTypesPatch**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypespatch) | **PATCH** /TeamBuilderConfigProductTypes | Patch an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductTypesPost**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypespost) | **POST** /TeamBuilderConfigProductTypes | Create a new instance of the model and persist it into the data source.
[**TeamBuilderConfigProductTypesPut**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesput) | **PUT** /TeamBuilderConfigProductTypes | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductTypesReplaceOrCreatePost**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesreplaceorcreatepost) | **POST** /TeamBuilderConfigProductTypes/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductTypesUpdatePost**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesupdatepost) | **POST** /TeamBuilderConfigProductTypes/update | Update instances of the model matched by {{where}} from the data source.
[**TeamBuilderConfigProductTypesUpsertWithWherePost**](TeamBuilderConfigProductTypeApi.md#teambuilderconfigproducttypesupsertwithwherepost) | **POST** /TeamBuilderConfigProductTypes/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teambuilderconfigproducttypeschangestreamget"></a>
# **TeamBuilderConfigProductTypesChangeStreamGet**
> System.IO.Stream TeamBuilderConfigProductTypesChangeStreamGet (string options = null)

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
    public class TeamBuilderConfigProductTypesChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigProductTypesChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesChangeStreamGet: " + e.Message );
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

<a name="teambuilderconfigproducttypeschangestreampost"></a>
# **TeamBuilderConfigProductTypesChangeStreamPost**
> System.IO.Stream TeamBuilderConfigProductTypesChangeStreamPost (string options = null)

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
    public class TeamBuilderConfigProductTypesChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigProductTypesChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesChangeStreamPost: " + e.Message );
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

<a name="teambuilderconfigproducttypescountget"></a>
# **TeamBuilderConfigProductTypesCountGet**
> InlineResponse200 TeamBuilderConfigProductTypesCountGet (string where = null)

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
    public class TeamBuilderConfigProductTypesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.TeamBuilderConfigProductTypesCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesCountGet: " + e.Message );
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

<a name="teambuilderconfigproducttypesfindoneget"></a>
# **TeamBuilderConfigProductTypesFindOneGet**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesFindOneGet (string filter = null)

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
    public class TeamBuilderConfigProductTypesFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesFindOneGet: " + e.Message );
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

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesget"></a>
# **TeamBuilderConfigProductTypesGet**
> List<TeamBuilderConfigProductType> TeamBuilderConfigProductTypesGet (string filter = null)

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
    public class TeamBuilderConfigProductTypesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TeamBuilderConfigProductType&gt; result = apiInstance.TeamBuilderConfigProductTypesGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesGet: " + e.Message );
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

[**List<TeamBuilderConfigProductType>**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesidbuilderconfigget"></a>
# **TeamBuilderConfigProductTypesIdBuilderConfigGet**
> TeamBuilderConfig TeamBuilderConfigProductTypesIdBuilderConfigGet (string id, bool? refresh = null)

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
    public class TeamBuilderConfigProductTypesIdBuilderConfigGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | TeamBuilderConfigProductType id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation builderConfig.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigProductTypesIdBuilderConfigGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdBuilderConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductType id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesiddelete"></a>
# **TeamBuilderConfigProductTypesIdDelete**
> Object TeamBuilderConfigProductTypesIdDelete (string id)

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
    public class TeamBuilderConfigProductTypesIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamBuilderConfigProductTypesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdDelete: " + e.Message );
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

<a name="teambuilderconfigproducttypesidexistsget"></a>
# **TeamBuilderConfigProductTypesIdExistsGet**
> InlineResponse2001 TeamBuilderConfigProductTypesIdExistsGet (string id)

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
    public class TeamBuilderConfigProductTypesIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigProductTypesIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdExistsGet: " + e.Message );
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

<a name="teambuilderconfigproducttypesidget"></a>
# **TeamBuilderConfigProductTypesIdGet**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesIdGet (string id, string filter = null)

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
    public class TeamBuilderConfigProductTypesIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdGet: " + e.Message );
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

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesidhead"></a>
# **TeamBuilderConfigProductTypesIdHead**
> InlineResponse2001 TeamBuilderConfigProductTypesIdHead (string id)

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
    public class TeamBuilderConfigProductTypesIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigProductTypesIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdHead: " + e.Message );
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

<a name="teambuilderconfigproducttypesidpatch"></a>
# **TeamBuilderConfigProductTypesIdPatch**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesIdPatch (string id, TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | TeamBuilderConfigProductType id
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductType id | 
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesidproducttypeget"></a>
# **TeamBuilderConfigProductTypesIdProductTypeGet**
> ProductType TeamBuilderConfigProductTypesIdProductTypeGet (string id, bool? refresh = null)

Fetches belongsTo relation productType.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigProductTypesIdProductTypeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | TeamBuilderConfigProductType id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation productType.
                ProductType result = apiInstance.TeamBuilderConfigProductTypesIdProductTypeGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdProductTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductType id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesidput"></a>
# **TeamBuilderConfigProductTypesIdPut**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesIdPut (string id, TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesidreplacepost"></a>
# **TeamBuilderConfigProductTypesIdReplacePost**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesIdReplacePost (string id, TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypespatch"></a>
# **TeamBuilderConfigProductTypesPatch**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesPatch (TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypespost"></a>
# **TeamBuilderConfigProductTypesPost**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesPost (TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesput"></a>
# **TeamBuilderConfigProductTypesPut**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesPut (TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesreplaceorcreatepost"></a>
# **TeamBuilderConfigProductTypesReplaceOrCreatePost**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesReplaceOrCreatePost (TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesupdatepost"></a>
# **TeamBuilderConfigProductTypesUpdatePost**
> InlineResponse2002 TeamBuilderConfigProductTypesUpdatePost (string where = null, TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.TeamBuilderConfigProductTypesUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproducttypesupsertwithwherepost"></a>
# **TeamBuilderConfigProductTypesUpsertWithWherePost**
> TeamBuilderConfigProductType TeamBuilderConfigProductTypesUpsertWithWherePost (string where = null, TeamBuilderConfigProductType data = null)

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
    public class TeamBuilderConfigProductTypesUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductTypeApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfigProductType(); // TeamBuilderConfigProductType | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TeamBuilderConfigProductType result = apiInstance.TeamBuilderConfigProductTypesUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductTypeApi.TeamBuilderConfigProductTypesUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfigProductType**](TeamBuilderConfigProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

