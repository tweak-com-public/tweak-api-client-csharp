# TweakApi.Api.TeamBuilderConfigProductGroupApi

All URIs are relative to *https://apicdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamBuilderConfigProductGroupsChangeStreamGet**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupschangestreamget) | **GET** /TeamBuilderConfigProductGroups/change-stream | Create a change stream.
[**TeamBuilderConfigProductGroupsChangeStreamPost**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupschangestreampost) | **POST** /TeamBuilderConfigProductGroups/change-stream | Create a change stream.
[**TeamBuilderConfigProductGroupsCountGet**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupscountget) | **GET** /TeamBuilderConfigProductGroups/count | Count instances of the model matched by where from the data source.
[**TeamBuilderConfigProductGroupsFindOneGet**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsfindoneget) | **GET** /TeamBuilderConfigProductGroups/findOne | Find first instance of the model matched by filter from the data source.
[**TeamBuilderConfigProductGroupsGet**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsget) | **GET** /TeamBuilderConfigProductGroups | Find all instances of the model matched by filter from the data source.
[**TeamBuilderConfigProductGroupsIdBuilderConfigGet**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsidbuilderconfigget) | **GET** /TeamBuilderConfigProductGroups/{id}/builderConfig | Fetches belongsTo relation builderConfig.
[**TeamBuilderConfigProductGroupsIdDelete**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsiddelete) | **DELETE** /TeamBuilderConfigProductGroups/{id} | Delete a model instance by {{id}} from the data source.
[**TeamBuilderConfigProductGroupsIdExistsGet**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsidexistsget) | **GET** /TeamBuilderConfigProductGroups/{id}/exists | Check whether a model instance exists in the data source.
[**TeamBuilderConfigProductGroupsIdGet**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsidget) | **GET** /TeamBuilderConfigProductGroups/{id} | Find a model instance by {{id}} from the data source.
[**TeamBuilderConfigProductGroupsIdHead**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsidhead) | **HEAD** /TeamBuilderConfigProductGroups/{id} | Check whether a model instance exists in the data source.
[**TeamBuilderConfigProductGroupsIdPatch**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsidpatch) | **PATCH** /TeamBuilderConfigProductGroups/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductGroupsIdProductGroupGet**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsidproductgroupget) | **GET** /TeamBuilderConfigProductGroups/{id}/productGroup | Fetches belongsTo relation productGroup.
[**TeamBuilderConfigProductGroupsIdPut**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsidput) | **PUT** /TeamBuilderConfigProductGroups/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductGroupsIdReplacePost**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsidreplacepost) | **POST** /TeamBuilderConfigProductGroups/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigProductGroupsPatch**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupspatch) | **PATCH** /TeamBuilderConfigProductGroups | Patch an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductGroupsPost**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupspost) | **POST** /TeamBuilderConfigProductGroups | Create a new instance of the model and persist it into the data source.
[**TeamBuilderConfigProductGroupsPut**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsput) | **PUT** /TeamBuilderConfigProductGroups | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductGroupsReplaceOrCreatePost**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsreplaceorcreatepost) | **POST** /TeamBuilderConfigProductGroups/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigProductGroupsUpdatePost**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsupdatepost) | **POST** /TeamBuilderConfigProductGroups/update | Update instances of the model matched by {{where}} from the data source.
[**TeamBuilderConfigProductGroupsUpsertWithWherePost**](TeamBuilderConfigProductGroupApi.md#teambuilderconfigproductgroupsupsertwithwherepost) | **POST** /TeamBuilderConfigProductGroups/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teambuilderconfigproductgroupschangestreamget"></a>
# **TeamBuilderConfigProductGroupsChangeStreamGet**
> System.IO.Stream TeamBuilderConfigProductGroupsChangeStreamGet (string options = null)

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
    public class TeamBuilderConfigProductGroupsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigProductGroupsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsChangeStreamGet: " + e.Message );
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

<a name="teambuilderconfigproductgroupschangestreampost"></a>
# **TeamBuilderConfigProductGroupsChangeStreamPost**
> System.IO.Stream TeamBuilderConfigProductGroupsChangeStreamPost (string options = null)

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
    public class TeamBuilderConfigProductGroupsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigProductGroupsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsChangeStreamPost: " + e.Message );
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

<a name="teambuilderconfigproductgroupscountget"></a>
# **TeamBuilderConfigProductGroupsCountGet**
> InlineResponse2001 TeamBuilderConfigProductGroupsCountGet (string where = null)

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
    public class TeamBuilderConfigProductGroupsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigProductGroupsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsCountGet: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsfindoneget"></a>
# **TeamBuilderConfigProductGroupsFindOneGet**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsFindOneGet (string filter = null)

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
    public class TeamBuilderConfigProductGroupsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsFindOneGet: " + e.Message );
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

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsget"></a>
# **TeamBuilderConfigProductGroupsGet**
> List<TeamBuilderConfigProductGroup> TeamBuilderConfigProductGroupsGet (string filter = null)

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
    public class TeamBuilderConfigProductGroupsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TeamBuilderConfigProductGroup&gt; result = apiInstance.TeamBuilderConfigProductGroupsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsGet: " + e.Message );
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

[**List<TeamBuilderConfigProductGroup>**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsidbuilderconfigget"></a>
# **TeamBuilderConfigProductGroupsIdBuilderConfigGet**
> TeamBuilderConfig TeamBuilderConfigProductGroupsIdBuilderConfigGet (string id, bool? refresh = null)

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
    public class TeamBuilderConfigProductGroupsIdBuilderConfigGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | TeamBuilderConfigProductGroup id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation builderConfig.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigProductGroupsIdBuilderConfigGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdBuilderConfigGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductGroup id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsiddelete"></a>
# **TeamBuilderConfigProductGroupsIdDelete**
> Object TeamBuilderConfigProductGroupsIdDelete (string id)

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
    public class TeamBuilderConfigProductGroupsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamBuilderConfigProductGroupsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdDelete: " + e.Message );
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

<a name="teambuilderconfigproductgroupsidexistsget"></a>
# **TeamBuilderConfigProductGroupsIdExistsGet**
> InlineResponse2002 TeamBuilderConfigProductGroupsIdExistsGet (string id)

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
    public class TeamBuilderConfigProductGroupsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamBuilderConfigProductGroupsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdExistsGet: " + e.Message );
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

<a name="teambuilderconfigproductgroupsidget"></a>
# **TeamBuilderConfigProductGroupsIdGet**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsIdGet (string id, string filter = null)

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
    public class TeamBuilderConfigProductGroupsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdGet: " + e.Message );
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

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsidhead"></a>
# **TeamBuilderConfigProductGroupsIdHead**
> InlineResponse2002 TeamBuilderConfigProductGroupsIdHead (string id)

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
    public class TeamBuilderConfigProductGroupsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamBuilderConfigProductGroupsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdHead: " + e.Message );
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

<a name="teambuilderconfigproductgroupsidpatch"></a>
# **TeamBuilderConfigProductGroupsIdPatch**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsIdPatch (string id, TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | TeamBuilderConfigProductGroup id
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductGroup id | 
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsidproductgroupget"></a>
# **TeamBuilderConfigProductGroupsIdProductGroupGet**
> ProductGroup TeamBuilderConfigProductGroupsIdProductGroupGet (string id, bool? refresh = null)

Fetches belongsTo relation productGroup.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamBuilderConfigProductGroupsIdProductGroupGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | TeamBuilderConfigProductGroup id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation productGroup.
                ProductGroup result = apiInstance.TeamBuilderConfigProductGroupsIdProductGroupGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdProductGroupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfigProductGroup id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductGroup**](ProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsidput"></a>
# **TeamBuilderConfigProductGroupsIdPut**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsIdPut (string id, TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsidreplacepost"></a>
# **TeamBuilderConfigProductGroupsIdReplacePost**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsIdReplacePost (string id, TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupspatch"></a>
# **TeamBuilderConfigProductGroupsPatch**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsPatch (TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupspost"></a>
# **TeamBuilderConfigProductGroupsPost**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsPost (TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsput"></a>
# **TeamBuilderConfigProductGroupsPut**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsPut (TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsreplaceorcreatepost"></a>
# **TeamBuilderConfigProductGroupsReplaceOrCreatePost**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsReplaceOrCreatePost (TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsupdatepost"></a>
# **TeamBuilderConfigProductGroupsUpdatePost**
> InlineResponse2003 TeamBuilderConfigProductGroupsUpdatePost (string where = null, TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2003 result = apiInstance.TeamBuilderConfigProductGroupsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigproductgroupsupsertwithwherepost"></a>
# **TeamBuilderConfigProductGroupsUpsertWithWherePost**
> TeamBuilderConfigProductGroup TeamBuilderConfigProductGroupsUpsertWithWherePost (string where = null, TeamBuilderConfigProductGroup data = null)

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
    public class TeamBuilderConfigProductGroupsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigProductGroupApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfigProductGroup(); // TeamBuilderConfigProductGroup | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TeamBuilderConfigProductGroup result = apiInstance.TeamBuilderConfigProductGroupsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigProductGroupApi.TeamBuilderConfigProductGroupsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfigProductGroup**](TeamBuilderConfigProductGroup.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

