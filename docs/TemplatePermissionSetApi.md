# TweakApi.Api.TemplatePermissionSetApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TemplatePermissionSetsChangeStreamGet**](TemplatePermissionSetApi.md#templatepermissionsetschangestreamget) | **GET** /TemplatePermissionSets/change-stream | Create a change stream.
[**TemplatePermissionSetsChangeStreamPost**](TemplatePermissionSetApi.md#templatepermissionsetschangestreampost) | **POST** /TemplatePermissionSets/change-stream | Create a change stream.
[**TemplatePermissionSetsCountGet**](TemplatePermissionSetApi.md#templatepermissionsetscountget) | **GET** /TemplatePermissionSets/count | Count instances of the model matched by where from the data source.
[**TemplatePermissionSetsFindOneGet**](TemplatePermissionSetApi.md#templatepermissionsetsfindoneget) | **GET** /TemplatePermissionSets/findOne | Find first instance of the model matched by filter from the data source.
[**TemplatePermissionSetsGet**](TemplatePermissionSetApi.md#templatepermissionsetsget) | **GET** /TemplatePermissionSets | Find all instances of the model matched by filter from the data source.
[**TemplatePermissionSetsIdDelete**](TemplatePermissionSetApi.md#templatepermissionsetsiddelete) | **DELETE** /TemplatePermissionSets/{id} | Delete a model instance by {{id}} from the data source.
[**TemplatePermissionSetsIdExistsGet**](TemplatePermissionSetApi.md#templatepermissionsetsidexistsget) | **GET** /TemplatePermissionSets/{id}/exists | Check whether a model instance exists in the data source.
[**TemplatePermissionSetsIdGet**](TemplatePermissionSetApi.md#templatepermissionsetsidget) | **GET** /TemplatePermissionSets/{id} | Find a model instance by {{id}} from the data source.
[**TemplatePermissionSetsIdHead**](TemplatePermissionSetApi.md#templatepermissionsetsidhead) | **HEAD** /TemplatePermissionSets/{id} | Check whether a model instance exists in the data source.
[**TemplatePermissionSetsIdPatch**](TemplatePermissionSetApi.md#templatepermissionsetsidpatch) | **PATCH** /TemplatePermissionSets/{id} | Patch attributes for a model instance and persist it into the data source.
[**TemplatePermissionSetsIdPut**](TemplatePermissionSetApi.md#templatepermissionsetsidput) | **PUT** /TemplatePermissionSets/{id} | Replace attributes for a model instance and persist it into the data source.
[**TemplatePermissionSetsIdReplacePost**](TemplatePermissionSetApi.md#templatepermissionsetsidreplacepost) | **POST** /TemplatePermissionSets/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TemplatePermissionSetsIdTemplateGet**](TemplatePermissionSetApi.md#templatepermissionsetsidtemplateget) | **GET** /TemplatePermissionSets/{id}/template | Fetches belongsTo relation template.
[**TemplatePermissionSetsPatch**](TemplatePermissionSetApi.md#templatepermissionsetspatch) | **PATCH** /TemplatePermissionSets | Patch an existing model instance or insert a new one into the data source.
[**TemplatePermissionSetsPost**](TemplatePermissionSetApi.md#templatepermissionsetspost) | **POST** /TemplatePermissionSets | Create a new instance of the model and persist it into the data source.
[**TemplatePermissionSetsPut**](TemplatePermissionSetApi.md#templatepermissionsetsput) | **PUT** /TemplatePermissionSets | Replace an existing model instance or insert a new one into the data source.
[**TemplatePermissionSetsReplaceOrCreatePost**](TemplatePermissionSetApi.md#templatepermissionsetsreplaceorcreatepost) | **POST** /TemplatePermissionSets/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TemplatePermissionSetsUpdatePost**](TemplatePermissionSetApi.md#templatepermissionsetsupdatepost) | **POST** /TemplatePermissionSets/update | Update instances of the model matched by {{where}} from the data source.
[**TemplatePermissionSetsUpsertWithWherePost**](TemplatePermissionSetApi.md#templatepermissionsetsupsertwithwherepost) | **POST** /TemplatePermissionSets/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="templatepermissionsetschangestreamget"></a>
# **TemplatePermissionSetsChangeStreamGet**
> System.IO.Stream TemplatePermissionSetsChangeStreamGet (string options = null)

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
    public class TemplatePermissionSetsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TemplatePermissionSetsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsChangeStreamGet: " + e.Message );
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

<a name="templatepermissionsetschangestreampost"></a>
# **TemplatePermissionSetsChangeStreamPost**
> System.IO.Stream TemplatePermissionSetsChangeStreamPost (string options = null)

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
    public class TemplatePermissionSetsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TemplatePermissionSetsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsChangeStreamPost: " + e.Message );
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

<a name="templatepermissionsetscountget"></a>
# **TemplatePermissionSetsCountGet**
> InlineResponse200 TemplatePermissionSetsCountGet (string where = null)

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
    public class TemplatePermissionSetsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.TemplatePermissionSetsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsCountGet: " + e.Message );
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

<a name="templatepermissionsetsfindoneget"></a>
# **TemplatePermissionSetsFindOneGet**
> TemplatePermissionSet TemplatePermissionSetsFindOneGet (string filter = null)

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
    public class TemplatePermissionSetsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsFindOneGet: " + e.Message );
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

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsget"></a>
# **TemplatePermissionSetsGet**
> List<TemplatePermissionSet> TemplatePermissionSetsGet (string filter = null)

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
    public class TemplatePermissionSetsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TemplatePermissionSet&gt; result = apiInstance.TemplatePermissionSetsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsGet: " + e.Message );
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

[**List<TemplatePermissionSet>**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsiddelete"></a>
# **TemplatePermissionSetsIdDelete**
> Object TemplatePermissionSetsIdDelete (string id)

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
    public class TemplatePermissionSetsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TemplatePermissionSetsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsIdDelete: " + e.Message );
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

<a name="templatepermissionsetsidexistsget"></a>
# **TemplatePermissionSetsIdExistsGet**
> InlineResponse2002 TemplatePermissionSetsIdExistsGet (string id)

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
    public class TemplatePermissionSetsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TemplatePermissionSetsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsIdExistsGet: " + e.Message );
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

<a name="templatepermissionsetsidget"></a>
# **TemplatePermissionSetsIdGet**
> TemplatePermissionSet TemplatePermissionSetsIdGet (string id, string filter = null)

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
    public class TemplatePermissionSetsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsIdGet: " + e.Message );
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

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsidhead"></a>
# **TemplatePermissionSetsIdHead**
> InlineResponse2002 TemplatePermissionSetsIdHead (string id)

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
    public class TemplatePermissionSetsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TemplatePermissionSetsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsIdHead: " + e.Message );
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

<a name="templatepermissionsetsidpatch"></a>
# **TemplatePermissionSetsIdPatch**
> TemplatePermissionSet TemplatePermissionSetsIdPatch (string id, TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var id = id_example;  // string | TemplatePermissionSet id
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TemplatePermissionSet id | 
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsidput"></a>
# **TemplatePermissionSetsIdPut**
> TemplatePermissionSet TemplatePermissionSetsIdPut (string id, TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var id = id_example;  // string | Model id
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| Model instance data | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsidreplacepost"></a>
# **TemplatePermissionSetsIdReplacePost**
> TemplatePermissionSet TemplatePermissionSetsIdReplacePost (string id, TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var id = id_example;  // string | Model id
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| Model instance data | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsidtemplateget"></a>
# **TemplatePermissionSetsIdTemplateGet**
> Template TemplatePermissionSetsIdTemplateGet (string id, bool? refresh = null)

Fetches belongsTo relation template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TemplatePermissionSetsIdTemplateGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var id = id_example;  // string | TemplatePermissionSet id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation template.
                Template result = apiInstance.TemplatePermissionSetsIdTemplateGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsIdTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TemplatePermissionSet id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetspatch"></a>
# **TemplatePermissionSetsPatch**
> TemplatePermissionSet TemplatePermissionSetsPatch (TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| Model instance data | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetspost"></a>
# **TemplatePermissionSetsPost**
> TemplatePermissionSet TemplatePermissionSetsPost (TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| Model instance data | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsput"></a>
# **TemplatePermissionSetsPut**
> TemplatePermissionSet TemplatePermissionSetsPut (TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| Model instance data | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsreplaceorcreatepost"></a>
# **TemplatePermissionSetsReplaceOrCreatePost**
> TemplatePermissionSet TemplatePermissionSetsReplaceOrCreatePost (TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| Model instance data | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsupdatepost"></a>
# **TemplatePermissionSetsUpdatePost**
> InlineResponse2001 TemplatePermissionSetsUpdatePost (string where = null, TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2001 result = apiInstance.TemplatePermissionSetsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatepermissionsetsupsertwithwherepost"></a>
# **TemplatePermissionSetsUpsertWithWherePost**
> TemplatePermissionSet TemplatePermissionSetsUpsertWithWherePost (string where = null, TemplatePermissionSet data = null)

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
    public class TemplatePermissionSetsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TemplatePermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TemplatePermissionSet(); // TemplatePermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TemplatePermissionSet result = apiInstance.TemplatePermissionSetsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatePermissionSetApi.TemplatePermissionSetsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TemplatePermissionSet**](TemplatePermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TemplatePermissionSet**](TemplatePermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

