# TweakApi.Api.DesignExportApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DesignExportsChangeStreamGet**](DesignExportApi.md#designexportschangestreamget) | **GET** /DesignExports/change-stream | Create a change stream.
[**DesignExportsChangeStreamPost**](DesignExportApi.md#designexportschangestreampost) | **POST** /DesignExports/change-stream | Create a change stream.
[**DesignExportsCountGet**](DesignExportApi.md#designexportscountget) | **GET** /DesignExports/count | Count instances of the model matched by where from the data source.
[**DesignExportsFindOneGet**](DesignExportApi.md#designexportsfindoneget) | **GET** /DesignExports/findOne | Find first instance of the model matched by filter from the data source.
[**DesignExportsGet**](DesignExportApi.md#designexportsget) | **GET** /DesignExports | Find all instances of the model matched by filter from the data source.
[**DesignExportsIdDelete**](DesignExportApi.md#designexportsiddelete) | **DELETE** /DesignExports/{id} | Delete a model instance by {{id}} from the data source.
[**DesignExportsIdDesignsGet**](DesignExportApi.md#designexportsiddesignsget) | **GET** /DesignExports/{id}/designs | Fetches belongsTo relation designs.
[**DesignExportsIdExistsGet**](DesignExportApi.md#designexportsidexistsget) | **GET** /DesignExports/{id}/exists | Check whether a model instance exists in the data source.
[**DesignExportsIdGet**](DesignExportApi.md#designexportsidget) | **GET** /DesignExports/{id} | Find a model instance by {{id}} from the data source.
[**DesignExportsIdHead**](DesignExportApi.md#designexportsidhead) | **HEAD** /DesignExports/{id} | Check whether a model instance exists in the data source.
[**DesignExportsIdPatch**](DesignExportApi.md#designexportsidpatch) | **PATCH** /DesignExports/{id} | Patch attributes for a model instance and persist it into the data source.
[**DesignExportsIdPut**](DesignExportApi.md#designexportsidput) | **PUT** /DesignExports/{id} | Replace attributes for a model instance and persist it into the data source.
[**DesignExportsIdReplacePost**](DesignExportApi.md#designexportsidreplacepost) | **POST** /DesignExports/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DesignExportsIdRequesterGet**](DesignExportApi.md#designexportsidrequesterget) | **GET** /DesignExports/{id}/requester | Fetches belongsTo relation requester.
[**DesignExportsPatch**](DesignExportApi.md#designexportspatch) | **PATCH** /DesignExports | Patch an existing model instance or insert a new one into the data source.
[**DesignExportsPost**](DesignExportApi.md#designexportspost) | **POST** /DesignExports | Create a new instance of the model and persist it into the data source.
[**DesignExportsPut**](DesignExportApi.md#designexportsput) | **PUT** /DesignExports | Replace an existing model instance or insert a new one into the data source.
[**DesignExportsReplaceOrCreatePost**](DesignExportApi.md#designexportsreplaceorcreatepost) | **POST** /DesignExports/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**DesignExportsUpdatePost**](DesignExportApi.md#designexportsupdatepost) | **POST** /DesignExports/update | Update instances of the model matched by {{where}} from the data source.
[**DesignExportsUpsertWithWherePost**](DesignExportApi.md#designexportsupsertwithwherepost) | **POST** /DesignExports/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="designexportschangestreamget"></a>
# **DesignExportsChangeStreamGet**
> System.IO.Stream DesignExportsChangeStreamGet (string options = null)

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
    public class DesignExportsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DesignExportsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsChangeStreamGet: " + e.Message );
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

<a name="designexportschangestreampost"></a>
# **DesignExportsChangeStreamPost**
> System.IO.Stream DesignExportsChangeStreamPost (string options = null)

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
    public class DesignExportsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DesignExportsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsChangeStreamPost: " + e.Message );
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

<a name="designexportscountget"></a>
# **DesignExportsCountGet**
> InlineResponse200 DesignExportsCountGet (string where = null)

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
    public class DesignExportsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.DesignExportsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsCountGet: " + e.Message );
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

<a name="designexportsfindoneget"></a>
# **DesignExportsFindOneGet**
> DesignExport DesignExportsFindOneGet (string filter = null)

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
    public class DesignExportsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DesignExport result = apiInstance.DesignExportsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsFindOneGet: " + e.Message );
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

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsget"></a>
# **DesignExportsGet**
> List<DesignExport> DesignExportsGet (string filter = null)

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
    public class DesignExportsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DesignExport&gt; result = apiInstance.DesignExportsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsGet: " + e.Message );
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

[**List<DesignExport>**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsiddelete"></a>
# **DesignExportsIdDelete**
> Object DesignExportsIdDelete (string id)

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
    public class DesignExportsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DesignExportsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdDelete: " + e.Message );
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

<a name="designexportsiddesignsget"></a>
# **DesignExportsIdDesignsGet**
> Design DesignExportsIdDesignsGet (string id, bool? refresh = null)

Fetches belongsTo relation designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignExportsIdDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | DesignExport id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation designs.
                Design result = apiInstance.DesignExportsIdDesignsGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignExport id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsidexistsget"></a>
# **DesignExportsIdExistsGet**
> InlineResponse2002 DesignExportsIdExistsGet (string id)

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
    public class DesignExportsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DesignExportsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdExistsGet: " + e.Message );
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

<a name="designexportsidget"></a>
# **DesignExportsIdGet**
> DesignExport DesignExportsIdGet (string id, string filter = null)

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
    public class DesignExportsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DesignExport result = apiInstance.DesignExportsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdGet: " + e.Message );
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

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsidhead"></a>
# **DesignExportsIdHead**
> InlineResponse2002 DesignExportsIdHead (string id)

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
    public class DesignExportsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DesignExportsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdHead: " + e.Message );
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

<a name="designexportsidpatch"></a>
# **DesignExportsIdPatch**
> DesignExport DesignExportsIdPatch (string id, DesignExport data = null)

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
    public class DesignExportsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | DesignExport id
            var data = new DesignExport(); // DesignExport | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DesignExport result = apiInstance.DesignExportsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignExport id | 
 **data** | [**DesignExport**](DesignExport.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsidput"></a>
# **DesignExportsIdPut**
> DesignExport DesignExportsIdPut (string id, DesignExport data = null)

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
    public class DesignExportsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | Model id
            var data = new DesignExport(); // DesignExport | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DesignExport result = apiInstance.DesignExportsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DesignExport**](DesignExport.md)| Model instance data | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsidreplacepost"></a>
# **DesignExportsIdReplacePost**
> DesignExport DesignExportsIdReplacePost (string id, DesignExport data = null)

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
    public class DesignExportsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | Model id
            var data = new DesignExport(); // DesignExport | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DesignExport result = apiInstance.DesignExportsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DesignExport**](DesignExport.md)| Model instance data | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsidrequesterget"></a>
# **DesignExportsIdRequesterGet**
> TeamMember DesignExportsIdRequesterGet (string id, bool? refresh = null)

Fetches belongsTo relation requester.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignExportsIdRequesterGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var id = id_example;  // string | DesignExport id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation requester.
                TeamMember result = apiInstance.DesignExportsIdRequesterGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsIdRequesterGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignExport id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportspatch"></a>
# **DesignExportsPatch**
> DesignExport DesignExportsPatch (DesignExport data = null)

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
    public class DesignExportsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var data = new DesignExport(); // DesignExport | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                DesignExport result = apiInstance.DesignExportsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignExport**](DesignExport.md)| Model instance data | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportspost"></a>
# **DesignExportsPost**
> DesignExport DesignExportsPost (DesignExport data = null)

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
    public class DesignExportsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var data = new DesignExport(); // DesignExport | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DesignExport result = apiInstance.DesignExportsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignExport**](DesignExport.md)| Model instance data | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsput"></a>
# **DesignExportsPut**
> DesignExport DesignExportsPut (DesignExport data = null)

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
    public class DesignExportsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var data = new DesignExport(); // DesignExport | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DesignExport result = apiInstance.DesignExportsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignExport**](DesignExport.md)| Model instance data | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsreplaceorcreatepost"></a>
# **DesignExportsReplaceOrCreatePost**
> DesignExport DesignExportsReplaceOrCreatePost (DesignExport data = null)

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
    public class DesignExportsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var data = new DesignExport(); // DesignExport | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DesignExport result = apiInstance.DesignExportsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignExport**](DesignExport.md)| Model instance data | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsupdatepost"></a>
# **DesignExportsUpdatePost**
> InlineResponse2001 DesignExportsUpdatePost (string where = null, DesignExport data = null)

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
    public class DesignExportsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DesignExport(); // DesignExport | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2001 result = apiInstance.DesignExportsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DesignExport**](DesignExport.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designexportsupsertwithwherepost"></a>
# **DesignExportsUpsertWithWherePost**
> DesignExport DesignExportsUpsertWithWherePost (string where = null, DesignExport data = null)

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
    public class DesignExportsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignExportApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DesignExport(); // DesignExport | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                DesignExport result = apiInstance.DesignExportsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignExportApi.DesignExportsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DesignExport**](DesignExport.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

