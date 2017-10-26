# TweakApi.Api.TeamBuilderConfigApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamBuilderConfigsChangeStreamGet**](TeamBuilderConfigApi.md#teambuilderconfigschangestreamget) | **GET** /TeamBuilderConfigs/change-stream | Create a change stream.
[**TeamBuilderConfigsChangeStreamPost**](TeamBuilderConfigApi.md#teambuilderconfigschangestreampost) | **POST** /TeamBuilderConfigs/change-stream | Create a change stream.
[**TeamBuilderConfigsCountGet**](TeamBuilderConfigApi.md#teambuilderconfigscountget) | **GET** /TeamBuilderConfigs/count | Count instances of the model matched by where from the data source.
[**TeamBuilderConfigsFindOneGet**](TeamBuilderConfigApi.md#teambuilderconfigsfindoneget) | **GET** /TeamBuilderConfigs/findOne | Find first instance of the model matched by filter from the data source.
[**TeamBuilderConfigsGet**](TeamBuilderConfigApi.md#teambuilderconfigsget) | **GET** /TeamBuilderConfigs | Find all instances of the model matched by filter from the data source.
[**TeamBuilderConfigsIdDelete**](TeamBuilderConfigApi.md#teambuilderconfigsiddelete) | **DELETE** /TeamBuilderConfigs/{id} | Delete a model instance by {{id}} from the data source.
[**TeamBuilderConfigsIdExistsGet**](TeamBuilderConfigApi.md#teambuilderconfigsidexistsget) | **GET** /TeamBuilderConfigs/{id}/exists | Check whether a model instance exists in the data source.
[**TeamBuilderConfigsIdGet**](TeamBuilderConfigApi.md#teambuilderconfigsidget) | **GET** /TeamBuilderConfigs/{id} | Find a model instance by {{id}} from the data source.
[**TeamBuilderConfigsIdHead**](TeamBuilderConfigApi.md#teambuilderconfigsidhead) | **HEAD** /TeamBuilderConfigs/{id} | Check whether a model instance exists in the data source.
[**TeamBuilderConfigsIdPatch**](TeamBuilderConfigApi.md#teambuilderconfigsidpatch) | **PATCH** /TeamBuilderConfigs/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigsIdPut**](TeamBuilderConfigApi.md#teambuilderconfigsidput) | **PUT** /TeamBuilderConfigs/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigsIdReplacePost**](TeamBuilderConfigApi.md#teambuilderconfigsidreplacepost) | **POST** /TeamBuilderConfigs/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamBuilderConfigsIdTeamGet**](TeamBuilderConfigApi.md#teambuilderconfigsidteamget) | **GET** /TeamBuilderConfigs/{id}/team | Fetches belongsTo relation team.
[**TeamBuilderConfigsPatch**](TeamBuilderConfigApi.md#teambuilderconfigspatch) | **PATCH** /TeamBuilderConfigs | Patch an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigsPost**](TeamBuilderConfigApi.md#teambuilderconfigspost) | **POST** /TeamBuilderConfigs | Create a new instance of the model and persist it into the data source.
[**TeamBuilderConfigsPut**](TeamBuilderConfigApi.md#teambuilderconfigsput) | **PUT** /TeamBuilderConfigs | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigsReplaceOrCreatePost**](TeamBuilderConfigApi.md#teambuilderconfigsreplaceorcreatepost) | **POST** /TeamBuilderConfigs/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamBuilderConfigsUpdatePost**](TeamBuilderConfigApi.md#teambuilderconfigsupdatepost) | **POST** /TeamBuilderConfigs/update | Update instances of the model matched by {{where}} from the data source.
[**TeamBuilderConfigsUpsertWithWherePost**](TeamBuilderConfigApi.md#teambuilderconfigsupsertwithwherepost) | **POST** /TeamBuilderConfigs/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teambuilderconfigschangestreamget"></a>
# **TeamBuilderConfigsChangeStreamGet**
> System.IO.Stream TeamBuilderConfigsChangeStreamGet (string options = null)

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
    public class TeamBuilderConfigsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsChangeStreamGet: " + e.Message );
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

<a name="teambuilderconfigschangestreampost"></a>
# **TeamBuilderConfigsChangeStreamPost**
> System.IO.Stream TeamBuilderConfigsChangeStreamPost (string options = null)

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
    public class TeamBuilderConfigsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamBuilderConfigsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsChangeStreamPost: " + e.Message );
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

<a name="teambuilderconfigscountget"></a>
# **TeamBuilderConfigsCountGet**
> InlineResponse200 TeamBuilderConfigsCountGet (string where = null)

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
    public class TeamBuilderConfigsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.TeamBuilderConfigsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsCountGet: " + e.Message );
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

<a name="teambuilderconfigsfindoneget"></a>
# **TeamBuilderConfigsFindOneGet**
> TeamBuilderConfig TeamBuilderConfigsFindOneGet (string filter = null)

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
    public class TeamBuilderConfigsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsFindOneGet: " + e.Message );
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

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsget"></a>
# **TeamBuilderConfigsGet**
> List<TeamBuilderConfig> TeamBuilderConfigsGet (string filter = null)

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
    public class TeamBuilderConfigsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TeamBuilderConfig&gt; result = apiInstance.TeamBuilderConfigsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsGet: " + e.Message );
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

[**List<TeamBuilderConfig>**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsiddelete"></a>
# **TeamBuilderConfigsIdDelete**
> Object TeamBuilderConfigsIdDelete (string id)

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
    public class TeamBuilderConfigsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamBuilderConfigsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdDelete: " + e.Message );
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

<a name="teambuilderconfigsidexistsget"></a>
# **TeamBuilderConfigsIdExistsGet**
> InlineResponse2001 TeamBuilderConfigsIdExistsGet (string id)

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
    public class TeamBuilderConfigsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdExistsGet: " + e.Message );
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

<a name="teambuilderconfigsidget"></a>
# **TeamBuilderConfigsIdGet**
> TeamBuilderConfig TeamBuilderConfigsIdGet (string id, string filter = null)

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
    public class TeamBuilderConfigsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdGet: " + e.Message );
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

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidhead"></a>
# **TeamBuilderConfigsIdHead**
> InlineResponse2001 TeamBuilderConfigsIdHead (string id)

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
    public class TeamBuilderConfigsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.TeamBuilderConfigsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdHead: " + e.Message );
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

<a name="teambuilderconfigsidpatch"></a>
# **TeamBuilderConfigsIdPatch**
> TeamBuilderConfig TeamBuilderConfigsIdPatch (string id, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidput"></a>
# **TeamBuilderConfigsIdPut**
> TeamBuilderConfig TeamBuilderConfigsIdPut (string id, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidreplacepost"></a>
# **TeamBuilderConfigsIdReplacePost**
> TeamBuilderConfig TeamBuilderConfigsIdReplacePost (string id, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | Model id
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsidteamget"></a>
# **TeamBuilderConfigsIdTeamGet**
> Team TeamBuilderConfigsIdTeamGet (string id, bool? refresh = null)

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
    public class TeamBuilderConfigsIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var id = id_example;  // string | TeamBuilderConfig id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamBuilderConfigsIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamBuilderConfig id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigspatch"></a>
# **TeamBuilderConfigsPatch**
> TeamBuilderConfig TeamBuilderConfigsPatch (TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigspost"></a>
# **TeamBuilderConfigsPost**
> TeamBuilderConfig TeamBuilderConfigsPost (TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsput"></a>
# **TeamBuilderConfigsPut**
> TeamBuilderConfig TeamBuilderConfigsPut (TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsreplaceorcreatepost"></a>
# **TeamBuilderConfigsReplaceOrCreatePost**
> TeamBuilderConfig TeamBuilderConfigsReplaceOrCreatePost (TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| Model instance data | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsupdatepost"></a>
# **TeamBuilderConfigsUpdatePost**
> InlineResponse2002 TeamBuilderConfigsUpdatePost (string where = null, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.TeamBuilderConfigsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teambuilderconfigsupsertwithwherepost"></a>
# **TeamBuilderConfigsUpsertWithWherePost**
> TeamBuilderConfig TeamBuilderConfigsUpsertWithWherePost (string where = null, TeamBuilderConfig data = null)

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
    public class TeamBuilderConfigsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamBuilderConfigApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamBuilderConfig(); // TeamBuilderConfig | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TeamBuilderConfig result = apiInstance.TeamBuilderConfigsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBuilderConfigApi.TeamBuilderConfigsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamBuilderConfig**](TeamBuilderConfig.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamBuilderConfig**](TeamBuilderConfig.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

