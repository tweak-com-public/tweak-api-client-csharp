# TweakApi.Api.DesignPermissionSetApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DesignPermissionSetsChangeStreamGet**](DesignPermissionSetApi.md#designpermissionsetschangestreamget) | **GET** /DesignPermissionSets/change-stream | Create a change stream.
[**DesignPermissionSetsChangeStreamPost**](DesignPermissionSetApi.md#designpermissionsetschangestreampost) | **POST** /DesignPermissionSets/change-stream | Create a change stream.
[**DesignPermissionSetsCountGet**](DesignPermissionSetApi.md#designpermissionsetscountget) | **GET** /DesignPermissionSets/count | Count instances of the model matched by where from the data source.
[**DesignPermissionSetsFindOneGet**](DesignPermissionSetApi.md#designpermissionsetsfindoneget) | **GET** /DesignPermissionSets/findOne | Find first instance of the model matched by filter from the data source.
[**DesignPermissionSetsGet**](DesignPermissionSetApi.md#designpermissionsetsget) | **GET** /DesignPermissionSets | Find all instances of the model matched by filter from the data source.
[**DesignPermissionSetsIdDelete**](DesignPermissionSetApi.md#designpermissionsetsiddelete) | **DELETE** /DesignPermissionSets/{id} | Delete a model instance by {{id}} from the data source.
[**DesignPermissionSetsIdDesignGet**](DesignPermissionSetApi.md#designpermissionsetsiddesignget) | **GET** /DesignPermissionSets/{id}/design | Fetches belongsTo relation design.
[**DesignPermissionSetsIdExistsGet**](DesignPermissionSetApi.md#designpermissionsetsidexistsget) | **GET** /DesignPermissionSets/{id}/exists | Check whether a model instance exists in the data source.
[**DesignPermissionSetsIdGet**](DesignPermissionSetApi.md#designpermissionsetsidget) | **GET** /DesignPermissionSets/{id} | Find a model instance by {{id}} from the data source.
[**DesignPermissionSetsIdHead**](DesignPermissionSetApi.md#designpermissionsetsidhead) | **HEAD** /DesignPermissionSets/{id} | Check whether a model instance exists in the data source.
[**DesignPermissionSetsIdPatch**](DesignPermissionSetApi.md#designpermissionsetsidpatch) | **PATCH** /DesignPermissionSets/{id} | Patch attributes for a model instance and persist it into the data source.
[**DesignPermissionSetsIdPut**](DesignPermissionSetApi.md#designpermissionsetsidput) | **PUT** /DesignPermissionSets/{id} | Replace attributes for a model instance and persist it into the data source.
[**DesignPermissionSetsIdReplacePost**](DesignPermissionSetApi.md#designpermissionsetsidreplacepost) | **POST** /DesignPermissionSets/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DesignPermissionSetsPatch**](DesignPermissionSetApi.md#designpermissionsetspatch) | **PATCH** /DesignPermissionSets | Patch an existing model instance or insert a new one into the data source.
[**DesignPermissionSetsPost**](DesignPermissionSetApi.md#designpermissionsetspost) | **POST** /DesignPermissionSets | Create a new instance of the model and persist it into the data source.
[**DesignPermissionSetsPut**](DesignPermissionSetApi.md#designpermissionsetsput) | **PUT** /DesignPermissionSets | Replace an existing model instance or insert a new one into the data source.
[**DesignPermissionSetsReplaceOrCreatePost**](DesignPermissionSetApi.md#designpermissionsetsreplaceorcreatepost) | **POST** /DesignPermissionSets/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**DesignPermissionSetsUpdatePost**](DesignPermissionSetApi.md#designpermissionsetsupdatepost) | **POST** /DesignPermissionSets/update | Update instances of the model matched by {{where}} from the data source.
[**DesignPermissionSetsUpsertWithWherePost**](DesignPermissionSetApi.md#designpermissionsetsupsertwithwherepost) | **POST** /DesignPermissionSets/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="designpermissionsetschangestreamget"></a>
# **DesignPermissionSetsChangeStreamGet**
> System.IO.Stream DesignPermissionSetsChangeStreamGet (string options = null)

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
    public class DesignPermissionSetsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DesignPermissionSetsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsChangeStreamGet: " + e.Message );
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

<a name="designpermissionsetschangestreampost"></a>
# **DesignPermissionSetsChangeStreamPost**
> System.IO.Stream DesignPermissionSetsChangeStreamPost (string options = null)

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
    public class DesignPermissionSetsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DesignPermissionSetsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsChangeStreamPost: " + e.Message );
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

<a name="designpermissionsetscountget"></a>
# **DesignPermissionSetsCountGet**
> InlineResponse2001 DesignPermissionSetsCountGet (string where = null)

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
    public class DesignPermissionSetsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.DesignPermissionSetsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsCountGet: " + e.Message );
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

<a name="designpermissionsetsfindoneget"></a>
# **DesignPermissionSetsFindOneGet**
> DesignPermissionSet DesignPermissionSetsFindOneGet (string filter = null)

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
    public class DesignPermissionSetsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsFindOneGet: " + e.Message );
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

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsget"></a>
# **DesignPermissionSetsGet**
> List<DesignPermissionSet> DesignPermissionSetsGet (string filter = null)

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
    public class DesignPermissionSetsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DesignPermissionSet&gt; result = apiInstance.DesignPermissionSetsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsGet: " + e.Message );
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

[**List<DesignPermissionSet>**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsiddelete"></a>
# **DesignPermissionSetsIdDelete**
> Object DesignPermissionSetsIdDelete (string id)

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
    public class DesignPermissionSetsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DesignPermissionSetsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsIdDelete: " + e.Message );
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

<a name="designpermissionsetsiddesignget"></a>
# **DesignPermissionSetsIdDesignGet**
> Design DesignPermissionSetsIdDesignGet (string id, bool? refresh = null)

Fetches belongsTo relation design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignPermissionSetsIdDesignGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var id = id_example;  // string | DesignPermissionSet id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation design.
                Design result = apiInstance.DesignPermissionSetsIdDesignGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsIdDesignGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignPermissionSet id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsidexistsget"></a>
# **DesignPermissionSetsIdExistsGet**
> InlineResponse2002 DesignPermissionSetsIdExistsGet (string id)

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
    public class DesignPermissionSetsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DesignPermissionSetsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsIdExistsGet: " + e.Message );
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

<a name="designpermissionsetsidget"></a>
# **DesignPermissionSetsIdGet**
> DesignPermissionSet DesignPermissionSetsIdGet (string id, string filter = null)

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
    public class DesignPermissionSetsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsIdGet: " + e.Message );
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

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsidhead"></a>
# **DesignPermissionSetsIdHead**
> InlineResponse2002 DesignPermissionSetsIdHead (string id)

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
    public class DesignPermissionSetsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DesignPermissionSetsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsIdHead: " + e.Message );
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

<a name="designpermissionsetsidpatch"></a>
# **DesignPermissionSetsIdPatch**
> DesignPermissionSet DesignPermissionSetsIdPatch (string id, DesignPermissionSet data = null)

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
    public class DesignPermissionSetsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var id = id_example;  // string | DesignPermissionSet id
            var data = new DesignPermissionSet(); // DesignPermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignPermissionSet id | 
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsidput"></a>
# **DesignPermissionSetsIdPut**
> DesignPermissionSet DesignPermissionSetsIdPut (string id, DesignPermissionSet data = null)

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
    public class DesignPermissionSetsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var id = id_example;  // string | Model id
            var data = new DesignPermissionSet(); // DesignPermissionSet | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| Model instance data | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsidreplacepost"></a>
# **DesignPermissionSetsIdReplacePost**
> DesignPermissionSet DesignPermissionSetsIdReplacePost (string id, DesignPermissionSet data = null)

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
    public class DesignPermissionSetsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var id = id_example;  // string | Model id
            var data = new DesignPermissionSet(); // DesignPermissionSet | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| Model instance data | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetspatch"></a>
# **DesignPermissionSetsPatch**
> DesignPermissionSet DesignPermissionSetsPatch (DesignPermissionSet data = null)

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
    public class DesignPermissionSetsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var data = new DesignPermissionSet(); // DesignPermissionSet | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| Model instance data | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetspost"></a>
# **DesignPermissionSetsPost**
> DesignPermissionSet DesignPermissionSetsPost (DesignPermissionSet data = null)

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
    public class DesignPermissionSetsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var data = new DesignPermissionSet(); // DesignPermissionSet | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| Model instance data | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsput"></a>
# **DesignPermissionSetsPut**
> DesignPermissionSet DesignPermissionSetsPut (DesignPermissionSet data = null)

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
    public class DesignPermissionSetsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var data = new DesignPermissionSet(); // DesignPermissionSet | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| Model instance data | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsreplaceorcreatepost"></a>
# **DesignPermissionSetsReplaceOrCreatePost**
> DesignPermissionSet DesignPermissionSetsReplaceOrCreatePost (DesignPermissionSet data = null)

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
    public class DesignPermissionSetsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var data = new DesignPermissionSet(); // DesignPermissionSet | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| Model instance data | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsupdatepost"></a>
# **DesignPermissionSetsUpdatePost**
> InlineResponse2003 DesignPermissionSetsUpdatePost (string where = null, DesignPermissionSet data = null)

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
    public class DesignPermissionSetsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DesignPermissionSet(); // DesignPermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2003 result = apiInstance.DesignPermissionSetsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designpermissionsetsupsertwithwherepost"></a>
# **DesignPermissionSetsUpsertWithWherePost**
> DesignPermissionSet DesignPermissionSetsUpsertWithWherePost (string where = null, DesignPermissionSet data = null)

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
    public class DesignPermissionSetsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignPermissionSetApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DesignPermissionSet(); // DesignPermissionSet | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                DesignPermissionSet result = apiInstance.DesignPermissionSetsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignPermissionSetApi.DesignPermissionSetsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

