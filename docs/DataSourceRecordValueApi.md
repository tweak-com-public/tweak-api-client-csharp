# TweakApi.Api.DataSourceRecordValueApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataSourceRecordValuesChangeStreamGet**](DataSourceRecordValueApi.md#datasourcerecordvalueschangestreamget) | **GET** /DataSourceRecordValues/change-stream | Create a change stream.
[**DataSourceRecordValuesChangeStreamPost**](DataSourceRecordValueApi.md#datasourcerecordvalueschangestreampost) | **POST** /DataSourceRecordValues/change-stream | Create a change stream.
[**DataSourceRecordValuesCountGet**](DataSourceRecordValueApi.md#datasourcerecordvaluescountget) | **GET** /DataSourceRecordValues/count | Count instances of the model matched by where from the data source.
[**DataSourceRecordValuesFindOneGet**](DataSourceRecordValueApi.md#datasourcerecordvaluesfindoneget) | **GET** /DataSourceRecordValues/findOne | Find first instance of the model matched by filter from the data source.
[**DataSourceRecordValuesGet**](DataSourceRecordValueApi.md#datasourcerecordvaluesget) | **GET** /DataSourceRecordValues | Find all instances of the model matched by filter from the data source.
[**DataSourceRecordValuesIdDataSourceGet**](DataSourceRecordValueApi.md#datasourcerecordvaluesiddatasourceget) | **GET** /DataSourceRecordValues/{id}/dataSource | Fetches belongsTo relation dataSource.
[**DataSourceRecordValuesIdDelete**](DataSourceRecordValueApi.md#datasourcerecordvaluesiddelete) | **DELETE** /DataSourceRecordValues/{id} | Delete a model instance by {{id}} from the data source.
[**DataSourceRecordValuesIdExistsGet**](DataSourceRecordValueApi.md#datasourcerecordvaluesidexistsget) | **GET** /DataSourceRecordValues/{id}/exists | Check whether a model instance exists in the data source.
[**DataSourceRecordValuesIdGet**](DataSourceRecordValueApi.md#datasourcerecordvaluesidget) | **GET** /DataSourceRecordValues/{id} | Find a model instance by {{id}} from the data source.
[**DataSourceRecordValuesIdHead**](DataSourceRecordValueApi.md#datasourcerecordvaluesidhead) | **HEAD** /DataSourceRecordValues/{id} | Check whether a model instance exists in the data source.
[**DataSourceRecordValuesIdKeyGet**](DataSourceRecordValueApi.md#datasourcerecordvaluesidkeyget) | **GET** /DataSourceRecordValues/{id}/key | Fetches belongsTo relation key.
[**DataSourceRecordValuesIdPatch**](DataSourceRecordValueApi.md#datasourcerecordvaluesidpatch) | **PATCH** /DataSourceRecordValues/{id} | Patch attributes for a model instance and persist it into the data source.
[**DataSourceRecordValuesIdPut**](DataSourceRecordValueApi.md#datasourcerecordvaluesidput) | **PUT** /DataSourceRecordValues/{id} | Replace attributes for a model instance and persist it into the data source.
[**DataSourceRecordValuesIdReplacePost**](DataSourceRecordValueApi.md#datasourcerecordvaluesidreplacepost) | **POST** /DataSourceRecordValues/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DataSourceRecordValuesIdTeamGet**](DataSourceRecordValueApi.md#datasourcerecordvaluesidteamget) | **GET** /DataSourceRecordValues/{id}/team | Fetches belongsTo relation team.
[**DataSourceRecordValuesIdValuesGet**](DataSourceRecordValueApi.md#datasourcerecordvaluesidvaluesget) | **GET** /DataSourceRecordValues/{id}/values | Fetches belongsTo relation values.
[**DataSourceRecordValuesPatch**](DataSourceRecordValueApi.md#datasourcerecordvaluespatch) | **PATCH** /DataSourceRecordValues | Patch an existing model instance or insert a new one into the data source.
[**DataSourceRecordValuesPost**](DataSourceRecordValueApi.md#datasourcerecordvaluespost) | **POST** /DataSourceRecordValues | Create a new instance of the model and persist it into the data source.
[**DataSourceRecordValuesPut**](DataSourceRecordValueApi.md#datasourcerecordvaluesput) | **PUT** /DataSourceRecordValues | Replace an existing model instance or insert a new one into the data source.
[**DataSourceRecordValuesReplaceOrCreatePost**](DataSourceRecordValueApi.md#datasourcerecordvaluesreplaceorcreatepost) | **POST** /DataSourceRecordValues/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**DataSourceRecordValuesUpdatePost**](DataSourceRecordValueApi.md#datasourcerecordvaluesupdatepost) | **POST** /DataSourceRecordValues/update | Update instances of the model matched by {{where}} from the data source.
[**DataSourceRecordValuesUpsertWithWherePost**](DataSourceRecordValueApi.md#datasourcerecordvaluesupsertwithwherepost) | **POST** /DataSourceRecordValues/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="datasourcerecordvalueschangestreamget"></a>
# **DataSourceRecordValuesChangeStreamGet**
> System.IO.Stream DataSourceRecordValuesChangeStreamGet (string options = null)

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
    public class DataSourceRecordValuesChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceRecordValuesChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesChangeStreamGet: " + e.Message );
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

<a name="datasourcerecordvalueschangestreampost"></a>
# **DataSourceRecordValuesChangeStreamPost**
> System.IO.Stream DataSourceRecordValuesChangeStreamPost (string options = null)

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
    public class DataSourceRecordValuesChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceRecordValuesChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesChangeStreamPost: " + e.Message );
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

<a name="datasourcerecordvaluescountget"></a>
# **DataSourceRecordValuesCountGet**
> InlineResponse200 DataSourceRecordValuesCountGet (string where = null)

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
    public class DataSourceRecordValuesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.DataSourceRecordValuesCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesCountGet: " + e.Message );
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

<a name="datasourcerecordvaluesfindoneget"></a>
# **DataSourceRecordValuesFindOneGet**
> DataSourceRecordValue DataSourceRecordValuesFindOneGet (string filter = null)

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
    public class DataSourceRecordValuesFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesFindOneGet: " + e.Message );
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

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesget"></a>
# **DataSourceRecordValuesGet**
> List<DataSourceRecordValue> DataSourceRecordValuesGet (string filter = null)

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
    public class DataSourceRecordValuesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DataSourceRecordValue&gt; result = apiInstance.DataSourceRecordValuesGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesGet: " + e.Message );
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

[**List<DataSourceRecordValue>**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesiddatasourceget"></a>
# **DataSourceRecordValuesIdDataSourceGet**
> DataSource DataSourceRecordValuesIdDataSourceGet (string id, bool? refresh = null)

Fetches belongsTo relation dataSource.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordValuesIdDataSourceGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | DataSourceRecordValue id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSource.
                DataSource result = apiInstance.DataSourceRecordValuesIdDataSourceGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdDataSourceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecordValue id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesiddelete"></a>
# **DataSourceRecordValuesIdDelete**
> Object DataSourceRecordValuesIdDelete (string id)

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
    public class DataSourceRecordValuesIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DataSourceRecordValuesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdDelete: " + e.Message );
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

<a name="datasourcerecordvaluesidexistsget"></a>
# **DataSourceRecordValuesIdExistsGet**
> InlineResponse2001 DataSourceRecordValuesIdExistsGet (string id)

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
    public class DataSourceRecordValuesIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.DataSourceRecordValuesIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdExistsGet: " + e.Message );
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

<a name="datasourcerecordvaluesidget"></a>
# **DataSourceRecordValuesIdGet**
> DataSourceRecordValue DataSourceRecordValuesIdGet (string id, string filter = null)

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
    public class DataSourceRecordValuesIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdGet: " + e.Message );
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

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesidhead"></a>
# **DataSourceRecordValuesIdHead**
> InlineResponse2001 DataSourceRecordValuesIdHead (string id)

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
    public class DataSourceRecordValuesIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.DataSourceRecordValuesIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdHead: " + e.Message );
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

<a name="datasourcerecordvaluesidkeyget"></a>
# **DataSourceRecordValuesIdKeyGet**
> DataSourceKey DataSourceRecordValuesIdKeyGet (string id, bool? refresh = null)

Fetches belongsTo relation key.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordValuesIdKeyGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | DataSourceRecordValue id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation key.
                DataSourceKey result = apiInstance.DataSourceRecordValuesIdKeyGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdKeyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecordValue id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourceKey**](DataSourceKey.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesidpatch"></a>
# **DataSourceRecordValuesIdPatch**
> DataSourceRecordValue DataSourceRecordValuesIdPatch (string id, DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | DataSourceRecordValue id
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecordValue id | 
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesidput"></a>
# **DataSourceRecordValuesIdPut**
> DataSourceRecordValue DataSourceRecordValuesIdPut (string id, DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesidreplacepost"></a>
# **DataSourceRecordValuesIdReplacePost**
> DataSourceRecordValue DataSourceRecordValuesIdReplacePost (string id, DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesidteamget"></a>
# **DataSourceRecordValuesIdTeamGet**
> Team DataSourceRecordValuesIdTeamGet (string id, bool? refresh = null)

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
    public class DataSourceRecordValuesIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | DataSourceRecordValue id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.DataSourceRecordValuesIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecordValue id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesidvaluesget"></a>
# **DataSourceRecordValuesIdValuesGet**
> DataSourceRecord DataSourceRecordValuesIdValuesGet (string id, bool? refresh = null)

Fetches belongsTo relation values.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordValuesIdValuesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var id = id_example;  // string | DataSourceRecordValue id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation values.
                DataSourceRecord result = apiInstance.DataSourceRecordValuesIdValuesGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesIdValuesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecordValue id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluespatch"></a>
# **DataSourceRecordValuesPatch**
> DataSourceRecordValue DataSourceRecordValuesPatch (DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluespost"></a>
# **DataSourceRecordValuesPost**
> DataSourceRecordValue DataSourceRecordValuesPost (DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesput"></a>
# **DataSourceRecordValuesPut**
> DataSourceRecordValue DataSourceRecordValuesPut (DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesreplaceorcreatepost"></a>
# **DataSourceRecordValuesReplaceOrCreatePost**
> DataSourceRecordValue DataSourceRecordValuesReplaceOrCreatePost (DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesupdatepost"></a>
# **DataSourceRecordValuesUpdatePost**
> InlineResponse2002 DataSourceRecordValuesUpdatePost (string where = null, DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.DataSourceRecordValuesUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordvaluesupsertwithwherepost"></a>
# **DataSourceRecordValuesUpsertWithWherePost**
> DataSourceRecordValue DataSourceRecordValuesUpsertWithWherePost (string where = null, DataSourceRecordValue data = null)

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
    public class DataSourceRecordValuesUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordValueApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DataSourceRecordValue(); // DataSourceRecordValue | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                DataSourceRecordValue result = apiInstance.DataSourceRecordValuesUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordValueApi.DataSourceRecordValuesUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

