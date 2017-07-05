# TweakApi.Api.TeamPermissionSetApi

All URIs are relative to *https://apicdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamPermissionSetsChangeStreamGet**](TeamPermissionSetApi.md#teampermissionsetschangestreamget) | **GET** /TeamPermissionSets/change-stream | Create a change stream.
[**TeamPermissionSetsChangeStreamPost**](TeamPermissionSetApi.md#teampermissionsetschangestreampost) | **POST** /TeamPermissionSets/change-stream | Create a change stream.
[**TeamPermissionSetsCountGet**](TeamPermissionSetApi.md#teampermissionsetscountget) | **GET** /TeamPermissionSets/count | Count instances of the model matched by where from the data source.
[**TeamPermissionSetsFindOneGet**](TeamPermissionSetApi.md#teampermissionsetsfindoneget) | **GET** /TeamPermissionSets/findOne | Find first instance of the model matched by filter from the data source.
[**TeamPermissionSetsGet**](TeamPermissionSetApi.md#teampermissionsetsget) | **GET** /TeamPermissionSets | Find all instances of the model matched by filter from the data source.
[**TeamPermissionSetsIdDelete**](TeamPermissionSetApi.md#teampermissionsetsiddelete) | **DELETE** /TeamPermissionSets/{id} | Delete a model instance by {{id}} from the data source.
[**TeamPermissionSetsIdExistsGet**](TeamPermissionSetApi.md#teampermissionsetsidexistsget) | **GET** /TeamPermissionSets/{id}/exists | Check whether a model instance exists in the data source.
[**TeamPermissionSetsIdGet**](TeamPermissionSetApi.md#teampermissionsetsidget) | **GET** /TeamPermissionSets/{id} | Find a model instance by {{id}} from the data source.
[**TeamPermissionSetsIdHead**](TeamPermissionSetApi.md#teampermissionsetsidhead) | **HEAD** /TeamPermissionSets/{id} | Check whether a model instance exists in the data source.
[**TeamPermissionSetsIdPatch**](TeamPermissionSetApi.md#teampermissionsetsidpatch) | **PATCH** /TeamPermissionSets/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamPermissionSetsIdPut**](TeamPermissionSetApi.md#teampermissionsetsidput) | **PUT** /TeamPermissionSets/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamPermissionSetsIdReplacePost**](TeamPermissionSetApi.md#teampermissionsetsidreplacepost) | **POST** /TeamPermissionSets/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamPermissionSetsIdTeamGet**](TeamPermissionSetApi.md#teampermissionsetsidteamget) | **GET** /TeamPermissionSets/{id}/team | Fetches belongsTo relation team.
[**TeamPermissionSetsPatch**](TeamPermissionSetApi.md#teampermissionsetspatch) | **PATCH** /TeamPermissionSets | Patch an existing model instance or insert a new one into the data source.
[**TeamPermissionSetsPost**](TeamPermissionSetApi.md#teampermissionsetspost) | **POST** /TeamPermissionSets | Create a new instance of the model and persist it into the data source.
[**TeamPermissionSetsPut**](TeamPermissionSetApi.md#teampermissionsetsput) | **PUT** /TeamPermissionSets | Replace an existing model instance or insert a new one into the data source.
[**TeamPermissionSetsReplaceOrCreatePost**](TeamPermissionSetApi.md#teampermissionsetsreplaceorcreatepost) | **POST** /TeamPermissionSets/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamPermissionSetsUpdatePost**](TeamPermissionSetApi.md#teampermissionsetsupdatepost) | **POST** /TeamPermissionSets/update | Update instances of the model matched by {{where}} from the data source.
[**TeamPermissionSetsUpsertWithWherePost**](TeamPermissionSetApi.md#teampermissionsetsupsertwithwherepost) | **POST** /TeamPermissionSets/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teampermissionsetschangestreamget"></a>
# **TeamPermissionSetsChangeStreamGet**
> System.IO.Stream TeamPermissionSetsChangeStreamGet (string options = null)

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
    public class TeamPermissionSetsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamPermissionSetsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsChangeStreamGet: " + e.Message );
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

<a name="teampermissionsetschangestreampost"></a>
# **TeamPermissionSetsChangeStreamPost**
> System.IO.Stream TeamPermissionSetsChangeStreamPost (string options = null)

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
    public class TeamPermissionSetsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamPermissionSetsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsChangeStreamPost: " + e.Message );
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

<a name="teampermissionsetscountget"></a>
# **TeamPermissionSetsCountGet**
> InlineResponse200 TeamPermissionSetsCountGet (string where = null)

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
    public class TeamPermissionSetsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.TeamPermissionSetsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsCountGet: " + e.Message );
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

<a name="teampermissionsetsfindoneget"></a>
# **TeamPermissionSetsFindOneGet**
> TeamPermissionSet TeamPermissionSetsFindOneGet (string filter = null)

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
    public class TeamPermissionSetsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsFindOneGet: " + e.Message );
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

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsget"></a>
# **TeamPermissionSetsGet**
> List<TeamPermissionSet> TeamPermissionSetsGet (string filter = null)

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
    public class TeamPermissionSetsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TeamPermissionSet&gt; result = apiInstance.TeamPermissionSetsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsGet: " + e.Message );
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

[**List<TeamPermissionSet>**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsiddelete"></a>
# **TeamPermissionSetsIdDelete**
> Object TeamPermissionSetsIdDelete (string id)

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
    public class TeamPermissionSetsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamPermissionSetsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsIdDelete: " + e.Message );
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

<a name="teampermissionsetsidexistsget"></a>
# **TeamPermissionSetsIdExistsGet**
> InlineResponse2002 TeamPermissionSetsIdExistsGet (string id)

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
    public class TeamPermissionSetsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamPermissionSetsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsIdExistsGet: " + e.Message );
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

<a name="teampermissionsetsidget"></a>
# **TeamPermissionSetsIdGet**
> TeamPermissionSet TeamPermissionSetsIdGet (string id, string filter = null)

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
    public class TeamPermissionSetsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsIdGet: " + e.Message );
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

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsidhead"></a>
# **TeamPermissionSetsIdHead**
> InlineResponse2002 TeamPermissionSetsIdHead (string id)

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
    public class TeamPermissionSetsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamPermissionSetsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsIdHead: " + e.Message );
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

<a name="teampermissionsetsidpatch"></a>
# **TeamPermissionSetsIdPatch**
> TeamPermissionSet TeamPermissionSetsIdPatch (string id, TeamPermissionSet data = null)

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
    public class TeamPermissionSetsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var id = id_example;  // string | TeamPermissionSet id
            var data = new TeamPermissionSet(); // TeamPermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamPermissionSet id | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsidput"></a>
# **TeamPermissionSetsIdPut**
> TeamPermissionSet TeamPermissionSetsIdPut (string id, TeamPermissionSet data = null)

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
    public class TeamPermissionSetsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var id = id_example;  // string | Model id
            var data = new TeamPermissionSet(); // TeamPermissionSet | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| Model instance data | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsidreplacepost"></a>
# **TeamPermissionSetsIdReplacePost**
> TeamPermissionSet TeamPermissionSetsIdReplacePost (string id, TeamPermissionSet data = null)

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
    public class TeamPermissionSetsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var id = id_example;  // string | Model id
            var data = new TeamPermissionSet(); // TeamPermissionSet | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| Model instance data | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsidteamget"></a>
# **TeamPermissionSetsIdTeamGet**
> Team TeamPermissionSetsIdTeamGet (string id, bool? refresh = null)

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
    public class TeamPermissionSetsIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var id = id_example;  // string | TeamPermissionSet id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamPermissionSetsIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamPermissionSet id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetspatch"></a>
# **TeamPermissionSetsPatch**
> TeamPermissionSet TeamPermissionSetsPatch (TeamPermissionSet data = null)

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
    public class TeamPermissionSetsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var data = new TeamPermissionSet(); // TeamPermissionSet | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| Model instance data | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetspost"></a>
# **TeamPermissionSetsPost**
> TeamPermissionSet TeamPermissionSetsPost (TeamPermissionSet data = null)

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
    public class TeamPermissionSetsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var data = new TeamPermissionSet(); // TeamPermissionSet | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| Model instance data | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsput"></a>
# **TeamPermissionSetsPut**
> TeamPermissionSet TeamPermissionSetsPut (TeamPermissionSet data = null)

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
    public class TeamPermissionSetsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var data = new TeamPermissionSet(); // TeamPermissionSet | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| Model instance data | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsreplaceorcreatepost"></a>
# **TeamPermissionSetsReplaceOrCreatePost**
> TeamPermissionSet TeamPermissionSetsReplaceOrCreatePost (TeamPermissionSet data = null)

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
    public class TeamPermissionSetsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var data = new TeamPermissionSet(); // TeamPermissionSet | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| Model instance data | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsupdatepost"></a>
# **TeamPermissionSetsUpdatePost**
> InlineResponse2001 TeamPermissionSetsUpdatePost (string where = null, TeamPermissionSet data = null)

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
    public class TeamPermissionSetsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamPermissionSet(); // TeamPermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2001 result = apiInstance.TeamPermissionSetsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teampermissionsetsupsertwithwherepost"></a>
# **TeamPermissionSetsUpsertWithWherePost**
> TeamPermissionSet TeamPermissionSetsUpsertWithWherePost (string where = null, TeamPermissionSet data = null)

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
    public class TeamPermissionSetsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamPermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamPermissionSet(); // TeamPermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TeamPermissionSet result = apiInstance.TeamPermissionSetsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamPermissionSetApi.TeamPermissionSetsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamPermissionSet**](TeamPermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamPermissionSet**](TeamPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

