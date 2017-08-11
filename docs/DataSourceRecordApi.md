# TweakApi.Api.DataSourceRecordApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataSourceRecordsChangeStreamGet**](DataSourceRecordApi.md#datasourcerecordschangestreamget) | **GET** /DataSourceRecords/change-stream | Create a change stream.
[**DataSourceRecordsChangeStreamPost**](DataSourceRecordApi.md#datasourcerecordschangestreampost) | **POST** /DataSourceRecords/change-stream | Create a change stream.
[**DataSourceRecordsCountGet**](DataSourceRecordApi.md#datasourcerecordscountget) | **GET** /DataSourceRecords/count | Count instances of the model matched by where from the data source.
[**DataSourceRecordsFindOneGet**](DataSourceRecordApi.md#datasourcerecordsfindoneget) | **GET** /DataSourceRecords/findOne | Find first instance of the model matched by filter from the data source.
[**DataSourceRecordsGet**](DataSourceRecordApi.md#datasourcerecordsget) | **GET** /DataSourceRecords | Find all instances of the model matched by filter from the data source.
[**DataSourceRecordsIdDataSourceGet**](DataSourceRecordApi.md#datasourcerecordsiddatasourceget) | **GET** /DataSourceRecords/{id}/dataSource | Fetches belongsTo relation dataSource.
[**DataSourceRecordsIdDelete**](DataSourceRecordApi.md#datasourcerecordsiddelete) | **DELETE** /DataSourceRecords/{id} | Delete a model instance by {{id}} from the data source.
[**DataSourceRecordsIdExistsGet**](DataSourceRecordApi.md#datasourcerecordsidexistsget) | **GET** /DataSourceRecords/{id}/exists | Check whether a model instance exists in the data source.
[**DataSourceRecordsIdGet**](DataSourceRecordApi.md#datasourcerecordsidget) | **GET** /DataSourceRecords/{id} | Find a model instance by {{id}} from the data source.
[**DataSourceRecordsIdHead**](DataSourceRecordApi.md#datasourcerecordsidhead) | **HEAD** /DataSourceRecords/{id} | Check whether a model instance exists in the data source.
[**DataSourceRecordsIdPatch**](DataSourceRecordApi.md#datasourcerecordsidpatch) | **PATCH** /DataSourceRecords/{id} | Patch attributes for a model instance and persist it into the data source.
[**DataSourceRecordsIdPut**](DataSourceRecordApi.md#datasourcerecordsidput) | **PUT** /DataSourceRecords/{id} | Replace attributes for a model instance and persist it into the data source.
[**DataSourceRecordsIdReplacePost**](DataSourceRecordApi.md#datasourcerecordsidreplacepost) | **POST** /DataSourceRecords/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DataSourceRecordsIdTeamGet**](DataSourceRecordApi.md#datasourcerecordsidteamget) | **GET** /DataSourceRecords/{id}/team | Fetches belongsTo relation team.
[**DataSourceRecordsIdValuesCountGet**](DataSourceRecordApi.md#datasourcerecordsidvaluescountget) | **GET** /DataSourceRecords/{id}/values/count | Counts values of DataSourceRecord.
[**DataSourceRecordsIdValuesDelete**](DataSourceRecordApi.md#datasourcerecordsidvaluesdelete) | **DELETE** /DataSourceRecords/{id}/values | Deletes all values of this model.
[**DataSourceRecordsIdValuesFkDelete**](DataSourceRecordApi.md#datasourcerecordsidvaluesfkdelete) | **DELETE** /DataSourceRecords/{id}/values/{fk} | Delete a related item by id for values.
[**DataSourceRecordsIdValuesFkGet**](DataSourceRecordApi.md#datasourcerecordsidvaluesfkget) | **GET** /DataSourceRecords/{id}/values/{fk} | Find a related item by id for values.
[**DataSourceRecordsIdValuesFkPut**](DataSourceRecordApi.md#datasourcerecordsidvaluesfkput) | **PUT** /DataSourceRecords/{id}/values/{fk} | Update a related item by id for values.
[**DataSourceRecordsIdValuesGet**](DataSourceRecordApi.md#datasourcerecordsidvaluesget) | **GET** /DataSourceRecords/{id}/values | Queries values of DataSourceRecord.
[**DataSourceRecordsIdValuesPost**](DataSourceRecordApi.md#datasourcerecordsidvaluespost) | **POST** /DataSourceRecords/{id}/values | Creates a new instance in values of this model.
[**DataSourceRecordsPatch**](DataSourceRecordApi.md#datasourcerecordspatch) | **PATCH** /DataSourceRecords | Patch an existing model instance or insert a new one into the data source.
[**DataSourceRecordsPost**](DataSourceRecordApi.md#datasourcerecordspost) | **POST** /DataSourceRecords | Create a new instance of the model and persist it into the data source.
[**DataSourceRecordsPut**](DataSourceRecordApi.md#datasourcerecordsput) | **PUT** /DataSourceRecords | Replace an existing model instance or insert a new one into the data source.
[**DataSourceRecordsReplaceOrCreatePost**](DataSourceRecordApi.md#datasourcerecordsreplaceorcreatepost) | **POST** /DataSourceRecords/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**DataSourceRecordsUpdatePost**](DataSourceRecordApi.md#datasourcerecordsupdatepost) | **POST** /DataSourceRecords/update | Update instances of the model matched by {{where}} from the data source.
[**DataSourceRecordsUpsertWithWherePost**](DataSourceRecordApi.md#datasourcerecordsupsertwithwherepost) | **POST** /DataSourceRecords/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="datasourcerecordschangestreamget"></a>
# **DataSourceRecordsChangeStreamGet**
> System.IO.Stream DataSourceRecordsChangeStreamGet (string options = null)

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
    public class DataSourceRecordsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceRecordsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsChangeStreamGet: " + e.Message );
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

<a name="datasourcerecordschangestreampost"></a>
# **DataSourceRecordsChangeStreamPost**
> System.IO.Stream DataSourceRecordsChangeStreamPost (string options = null)

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
    public class DataSourceRecordsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceRecordsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsChangeStreamPost: " + e.Message );
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

<a name="datasourcerecordscountget"></a>
# **DataSourceRecordsCountGet**
> InlineResponse200 DataSourceRecordsCountGet (string where = null)

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
    public class DataSourceRecordsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.DataSourceRecordsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsCountGet: " + e.Message );
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

<a name="datasourcerecordsfindoneget"></a>
# **DataSourceRecordsFindOneGet**
> DataSourceRecord DataSourceRecordsFindOneGet (string filter = null)

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
    public class DataSourceRecordsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsFindOneGet: " + e.Message );
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

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsget"></a>
# **DataSourceRecordsGet**
> List<DataSourceRecord> DataSourceRecordsGet (string filter = null)

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
    public class DataSourceRecordsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DataSourceRecord&gt; result = apiInstance.DataSourceRecordsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsGet: " + e.Message );
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

[**List<DataSourceRecord>**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsiddatasourceget"></a>
# **DataSourceRecordsIdDataSourceGet**
> DataSource DataSourceRecordsIdDataSourceGet (string id, bool? refresh = null)

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
    public class DataSourceRecordsIdDataSourceGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSource.
                DataSource result = apiInstance.DataSourceRecordsIdDataSourceGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdDataSourceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSource**](DataSource.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsiddelete"></a>
# **DataSourceRecordsIdDelete**
> Object DataSourceRecordsIdDelete (string id)

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
    public class DataSourceRecordsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DataSourceRecordsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdDelete: " + e.Message );
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

<a name="datasourcerecordsidexistsget"></a>
# **DataSourceRecordsIdExistsGet**
> InlineResponse2001 DataSourceRecordsIdExistsGet (string id)

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
    public class DataSourceRecordsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.DataSourceRecordsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdExistsGet: " + e.Message );
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

<a name="datasourcerecordsidget"></a>
# **DataSourceRecordsIdGet**
> DataSourceRecord DataSourceRecordsIdGet (string id, string filter = null)

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
    public class DataSourceRecordsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdGet: " + e.Message );
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

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidhead"></a>
# **DataSourceRecordsIdHead**
> InlineResponse2001 DataSourceRecordsIdHead (string id)

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
    public class DataSourceRecordsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.DataSourceRecordsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdHead: " + e.Message );
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

<a name="datasourcerecordsidpatch"></a>
# **DataSourceRecordsIdPatch**
> DataSourceRecord DataSourceRecordsIdPatch (string id, DataSourceRecord data = null)

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
    public class DataSourceRecordsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var data = new DataSourceRecord(); // DataSourceRecord | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidput"></a>
# **DataSourceRecordsIdPut**
> DataSourceRecord DataSourceRecordsIdPut (string id, DataSourceRecord data = null)

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
    public class DataSourceRecordsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceRecord(); // DataSourceRecord | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidreplacepost"></a>
# **DataSourceRecordsIdReplacePost**
> DataSourceRecord DataSourceRecordsIdReplacePost (string id, DataSourceRecord data = null)

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
    public class DataSourceRecordsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceRecord(); // DataSourceRecord | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidteamget"></a>
# **DataSourceRecordsIdTeamGet**
> Team DataSourceRecordsIdTeamGet (string id, bool? refresh = null)

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
    public class DataSourceRecordsIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.DataSourceRecordsIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidvaluescountget"></a>
# **DataSourceRecordsIdValuesCountGet**
> InlineResponse200 DataSourceRecordsIdValuesCountGet (string id, string where = null)

Counts values of DataSourceRecord.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordsIdValuesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts values of DataSourceRecord.
                InlineResponse200 result = apiInstance.DataSourceRecordsIdValuesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdValuesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidvaluesdelete"></a>
# **DataSourceRecordsIdValuesDelete**
> void DataSourceRecordsIdValuesDelete (string id)

Deletes all values of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordsIdValuesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id

            try
            {
                // Deletes all values of this model.
                apiInstance.DataSourceRecordsIdValuesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdValuesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidvaluesfkdelete"></a>
# **DataSourceRecordsIdValuesFkDelete**
> void DataSourceRecordsIdValuesFkDelete (string id, string fk)

Delete a related item by id for values.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordsIdValuesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var fk = fk_example;  // string | Foreign key for values

            try
            {
                // Delete a related item by id for values.
                apiInstance.DataSourceRecordsIdValuesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdValuesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **fk** | **string**| Foreign key for values | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidvaluesfkget"></a>
# **DataSourceRecordsIdValuesFkGet**
> DataSourceRecordValue DataSourceRecordsIdValuesFkGet (string id, string fk)

Find a related item by id for values.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordsIdValuesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var fk = fk_example;  // string | Foreign key for values

            try
            {
                // Find a related item by id for values.
                DataSourceRecordValue result = apiInstance.DataSourceRecordsIdValuesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdValuesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **fk** | **string**| Foreign key for values | 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidvaluesfkput"></a>
# **DataSourceRecordsIdValuesFkPut**
> DataSourceRecordValue DataSourceRecordsIdValuesFkPut (string id, string fk, DataSourceRecordValue data = null)

Update a related item by id for values.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordsIdValuesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var fk = fk_example;  // string | Foreign key for values
            var data = new DataSourceRecordValue(); // DataSourceRecordValue |  (optional) 

            try
            {
                // Update a related item by id for values.
                DataSourceRecordValue result = apiInstance.DataSourceRecordsIdValuesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdValuesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **fk** | **string**| Foreign key for values | 
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)|  | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidvaluesget"></a>
# **DataSourceRecordsIdValuesGet**
> List<DataSourceRecordValue> DataSourceRecordsIdValuesGet (string id, string filter = null)

Queries values of DataSourceRecord.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordsIdValuesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries values of DataSourceRecord.
                List&lt;DataSourceRecordValue&gt; result = apiInstance.DataSourceRecordsIdValuesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdValuesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DataSourceRecordValue>**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsidvaluespost"></a>
# **DataSourceRecordsIdValuesPost**
> DataSourceRecordValue DataSourceRecordsIdValuesPost (string id, DataSourceRecordValue data = null)

Creates a new instance in values of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceRecordsIdValuesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var id = id_example;  // string | DataSourceRecord id
            var data = new DataSourceRecordValue(); // DataSourceRecordValue |  (optional) 

            try
            {
                // Creates a new instance in values of this model.
                DataSourceRecordValue result = apiInstance.DataSourceRecordsIdValuesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsIdValuesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceRecord id | 
 **data** | [**DataSourceRecordValue**](DataSourceRecordValue.md)|  | [optional] 

### Return type

[**DataSourceRecordValue**](DataSourceRecordValue.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordspatch"></a>
# **DataSourceRecordsPatch**
> DataSourceRecord DataSourceRecordsPatch (DataSourceRecord data = null)

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
    public class DataSourceRecordsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var data = new DataSourceRecord(); // DataSourceRecord | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordspost"></a>
# **DataSourceRecordsPost**
> DataSourceRecord DataSourceRecordsPost (DataSourceRecord data = null)

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
    public class DataSourceRecordsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var data = new DataSourceRecord(); // DataSourceRecord | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsput"></a>
# **DataSourceRecordsPut**
> DataSourceRecord DataSourceRecordsPut (DataSourceRecord data = null)

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
    public class DataSourceRecordsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var data = new DataSourceRecord(); // DataSourceRecord | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsreplaceorcreatepost"></a>
# **DataSourceRecordsReplaceOrCreatePost**
> DataSourceRecord DataSourceRecordsReplaceOrCreatePost (DataSourceRecord data = null)

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
    public class DataSourceRecordsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var data = new DataSourceRecord(); // DataSourceRecord | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DataSourceRecord result = apiInstance.DataSourceRecordsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| Model instance data | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsupdatepost"></a>
# **DataSourceRecordsUpdatePost**
> InlineResponse2002 DataSourceRecordsUpdatePost (string where = null, DataSourceRecord data = null)

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
    public class DataSourceRecordsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DataSourceRecord(); // DataSourceRecord | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.DataSourceRecordsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcerecordsupsertwithwherepost"></a>
# **DataSourceRecordsUpsertWithWherePost**
> DataSourceRecord DataSourceRecordsUpsertWithWherePost (string where = null, DataSourceRecord data = null)

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
    public class DataSourceRecordsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceRecordApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DataSourceRecord(); // DataSourceRecord | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                DataSourceRecord result = apiInstance.DataSourceRecordsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceRecordApi.DataSourceRecordsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DataSourceRecord**](DataSourceRecord.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DataSourceRecord**](DataSourceRecord.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

