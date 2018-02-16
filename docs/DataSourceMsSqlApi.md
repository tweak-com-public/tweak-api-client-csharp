# TweakApi.Api.DataSourceMsSqlApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataSourceMsSqlsChangeStreamGet**](DataSourceMsSqlApi.md#datasourcemssqlschangestreamget) | **GET** /DataSourceMsSqls/change-stream | Create a change stream.
[**DataSourceMsSqlsChangeStreamPost**](DataSourceMsSqlApi.md#datasourcemssqlschangestreampost) | **POST** /DataSourceMsSqls/change-stream | Create a change stream.
[**DataSourceMsSqlsCountGet**](DataSourceMsSqlApi.md#datasourcemssqlscountget) | **GET** /DataSourceMsSqls/count | Count instances of the model matched by where from the data source.
[**DataSourceMsSqlsFindOneGet**](DataSourceMsSqlApi.md#datasourcemssqlsfindoneget) | **GET** /DataSourceMsSqls/findOne | Find first instance of the model matched by filter from the data source.
[**DataSourceMsSqlsGet**](DataSourceMsSqlApi.md#datasourcemssqlsget) | **GET** /DataSourceMsSqls | Find all instances of the model matched by filter from the data source.
[**DataSourceMsSqlsIdDelete**](DataSourceMsSqlApi.md#datasourcemssqlsiddelete) | **DELETE** /DataSourceMsSqls/{id} | Delete a model instance by {{id}} from the data source.
[**DataSourceMsSqlsIdDynamicDatasCountGet**](DataSourceMsSqlApi.md#datasourcemssqlsiddynamicdatascountget) | **GET** /DataSourceMsSqls/{id}/dynamicDatas/count | Counts dynamicDatas of DataSourceMsSql.
[**DataSourceMsSqlsIdDynamicDatasDelete**](DataSourceMsSqlApi.md#datasourcemssqlsiddynamicdatasdelete) | **DELETE** /DataSourceMsSqls/{id}/dynamicDatas | Deletes all dynamicDatas of this model.
[**DataSourceMsSqlsIdDynamicDatasFkDelete**](DataSourceMsSqlApi.md#datasourcemssqlsiddynamicdatasfkdelete) | **DELETE** /DataSourceMsSqls/{id}/dynamicDatas/{fk} | Delete a related item by id for dynamicDatas.
[**DataSourceMsSqlsIdDynamicDatasFkGet**](DataSourceMsSqlApi.md#datasourcemssqlsiddynamicdatasfkget) | **GET** /DataSourceMsSqls/{id}/dynamicDatas/{fk} | Find a related item by id for dynamicDatas.
[**DataSourceMsSqlsIdDynamicDatasFkPut**](DataSourceMsSqlApi.md#datasourcemssqlsiddynamicdatasfkput) | **PUT** /DataSourceMsSqls/{id}/dynamicDatas/{fk} | Update a related item by id for dynamicDatas.
[**DataSourceMsSqlsIdDynamicDatasGet**](DataSourceMsSqlApi.md#datasourcemssqlsiddynamicdatasget) | **GET** /DataSourceMsSqls/{id}/dynamicDatas | Queries dynamicDatas of DataSourceMsSql.
[**DataSourceMsSqlsIdDynamicDatasPost**](DataSourceMsSqlApi.md#datasourcemssqlsiddynamicdataspost) | **POST** /DataSourceMsSqls/{id}/dynamicDatas | Creates a new instance in dynamicDatas of this model.
[**DataSourceMsSqlsIdExistsGet**](DataSourceMsSqlApi.md#datasourcemssqlsidexistsget) | **GET** /DataSourceMsSqls/{id}/exists | Check whether a model instance exists in the data source.
[**DataSourceMsSqlsIdGet**](DataSourceMsSqlApi.md#datasourcemssqlsidget) | **GET** /DataSourceMsSqls/{id} | Find a model instance by {{id}} from the data source.
[**DataSourceMsSqlsIdHead**](DataSourceMsSqlApi.md#datasourcemssqlsidhead) | **HEAD** /DataSourceMsSqls/{id} | Check whether a model instance exists in the data source.
[**DataSourceMsSqlsIdPatch**](DataSourceMsSqlApi.md#datasourcemssqlsidpatch) | **PATCH** /DataSourceMsSqls/{id} | Patch attributes for a model instance and persist it into the data source.
[**DataSourceMsSqlsIdPut**](DataSourceMsSqlApi.md#datasourcemssqlsidput) | **PUT** /DataSourceMsSqls/{id} | Replace attributes for a model instance and persist it into the data source.
[**DataSourceMsSqlsIdReplacePost**](DataSourceMsSqlApi.md#datasourcemssqlsidreplacepost) | **POST** /DataSourceMsSqls/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DataSourceMsSqlsIdTeamGet**](DataSourceMsSqlApi.md#datasourcemssqlsidteamget) | **GET** /DataSourceMsSqls/{id}/team | Fetches belongsTo relation team.
[**DataSourceMsSqlsPatch**](DataSourceMsSqlApi.md#datasourcemssqlspatch) | **PATCH** /DataSourceMsSqls | Patch an existing model instance or insert a new one into the data source.
[**DataSourceMsSqlsPost**](DataSourceMsSqlApi.md#datasourcemssqlspost) | **POST** /DataSourceMsSqls | Create a new instance of the model and persist it into the data source.
[**DataSourceMsSqlsPut**](DataSourceMsSqlApi.md#datasourcemssqlsput) | **PUT** /DataSourceMsSqls | Replace an existing model instance or insert a new one into the data source.
[**DataSourceMsSqlsReplaceOrCreatePost**](DataSourceMsSqlApi.md#datasourcemssqlsreplaceorcreatepost) | **POST** /DataSourceMsSqls/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**DataSourceMsSqlsUpdatePost**](DataSourceMsSqlApi.md#datasourcemssqlsupdatepost) | **POST** /DataSourceMsSqls/update | Update instances of the model matched by {{where}} from the data source.
[**DataSourceMsSqlsUpsertWithWherePost**](DataSourceMsSqlApi.md#datasourcemssqlsupsertwithwherepost) | **POST** /DataSourceMsSqls/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="datasourcemssqlschangestreamget"></a>
# **DataSourceMsSqlsChangeStreamGet**
> System.IO.Stream DataSourceMsSqlsChangeStreamGet (string options = null)

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
    public class DataSourceMsSqlsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceMsSqlsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsChangeStreamGet: " + e.Message );
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

<a name="datasourcemssqlschangestreampost"></a>
# **DataSourceMsSqlsChangeStreamPost**
> System.IO.Stream DataSourceMsSqlsChangeStreamPost (string options = null)

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
    public class DataSourceMsSqlsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceMsSqlsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsChangeStreamPost: " + e.Message );
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

<a name="datasourcemssqlscountget"></a>
# **DataSourceMsSqlsCountGet**
> InlineResponse2001 DataSourceMsSqlsCountGet (string where = null)

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
    public class DataSourceMsSqlsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.DataSourceMsSqlsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsCountGet: " + e.Message );
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

<a name="datasourcemssqlsfindoneget"></a>
# **DataSourceMsSqlsFindOneGet**
> DataSourceMsSql DataSourceMsSqlsFindOneGet (string filter = null)

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
    public class DataSourceMsSqlsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsFindOneGet: " + e.Message );
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

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsget"></a>
# **DataSourceMsSqlsGet**
> List<DataSourceMsSql> DataSourceMsSqlsGet (string filter = null)

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
    public class DataSourceMsSqlsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DataSourceMsSql&gt; result = apiInstance.DataSourceMsSqlsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsGet: " + e.Message );
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

[**List<DataSourceMsSql>**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsiddelete"></a>
# **DataSourceMsSqlsIdDelete**
> Object DataSourceMsSqlsIdDelete (string id)

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
    public class DataSourceMsSqlsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DataSourceMsSqlsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdDelete: " + e.Message );
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

<a name="datasourcemssqlsiddynamicdatascountget"></a>
# **DataSourceMsSqlsIdDynamicDatasCountGet**
> InlineResponse2001 DataSourceMsSqlsIdDynamicDatasCountGet (string id, string where = null)

Counts dynamicDatas of DataSourceMsSql.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMsSqlsIdDynamicDatasCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts dynamicDatas of DataSourceMsSql.
                InlineResponse2001 result = apiInstance.DataSourceMsSqlsIdDynamicDatasCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdDynamicDatasCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsiddynamicdatasdelete"></a>
# **DataSourceMsSqlsIdDynamicDatasDelete**
> void DataSourceMsSqlsIdDynamicDatasDelete (string id)

Deletes all dynamicDatas of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMsSqlsIdDynamicDatasDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id

            try
            {
                // Deletes all dynamicDatas of this model.
                apiInstance.DataSourceMsSqlsIdDynamicDatasDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdDynamicDatasDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsiddynamicdatasfkdelete"></a>
# **DataSourceMsSqlsIdDynamicDatasFkDelete**
> void DataSourceMsSqlsIdDynamicDatasFkDelete (string id, string fk)

Delete a related item by id for dynamicDatas.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMsSqlsIdDynamicDatasFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Delete a related item by id for dynamicDatas.
                apiInstance.DataSourceMsSqlsIdDynamicDatasFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdDynamicDatasFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsiddynamicdatasfkget"></a>
# **DataSourceMsSqlsIdDynamicDatasFkGet**
> DynamicData DataSourceMsSqlsIdDynamicDatasFkGet (string id, string fk)

Find a related item by id for dynamicDatas.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMsSqlsIdDynamicDatasFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Find a related item by id for dynamicDatas.
                DynamicData result = apiInstance.DataSourceMsSqlsIdDynamicDatasFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdDynamicDatasFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsiddynamicdatasfkput"></a>
# **DataSourceMsSqlsIdDynamicDatasFkPut**
> DynamicData DataSourceMsSqlsIdDynamicDatasFkPut (string id, string fk, DynamicData data = null)

Update a related item by id for dynamicDatas.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMsSqlsIdDynamicDatasFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id
            var fk = fk_example;  // string | Foreign key for dynamicDatas
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Update a related item by id for dynamicDatas.
                DynamicData result = apiInstance.DataSourceMsSqlsIdDynamicDatasFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdDynamicDatasFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 
 **fk** | **string**| Foreign key for dynamicDatas | 
 **data** | [**DynamicData**](DynamicData.md)|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsiddynamicdatasget"></a>
# **DataSourceMsSqlsIdDynamicDatasGet**
> List<DynamicData> DataSourceMsSqlsIdDynamicDatasGet (string id, string filter = null)

Queries dynamicDatas of DataSourceMsSql.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMsSqlsIdDynamicDatasGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries dynamicDatas of DataSourceMsSql.
                List&lt;DynamicData&gt; result = apiInstance.DataSourceMsSqlsIdDynamicDatasGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdDynamicDatasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DynamicData>**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsiddynamicdataspost"></a>
# **DataSourceMsSqlsIdDynamicDatasPost**
> DynamicData DataSourceMsSqlsIdDynamicDatasPost (string id, DynamicData data = null)

Creates a new instance in dynamicDatas of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMsSqlsIdDynamicDatasPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Creates a new instance in dynamicDatas of this model.
                DynamicData result = apiInstance.DataSourceMsSqlsIdDynamicDatasPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdDynamicDatasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 
 **data** | [**DynamicData**](DynamicData.md)|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsidexistsget"></a>
# **DataSourceMsSqlsIdExistsGet**
> InlineResponse2002 DataSourceMsSqlsIdExistsGet (string id)

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
    public class DataSourceMsSqlsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DataSourceMsSqlsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdExistsGet: " + e.Message );
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

<a name="datasourcemssqlsidget"></a>
# **DataSourceMsSqlsIdGet**
> DataSourceMsSql DataSourceMsSqlsIdGet (string id, string filter = null)

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
    public class DataSourceMsSqlsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdGet: " + e.Message );
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

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsidhead"></a>
# **DataSourceMsSqlsIdHead**
> InlineResponse2002 DataSourceMsSqlsIdHead (string id)

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
    public class DataSourceMsSqlsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DataSourceMsSqlsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdHead: " + e.Message );
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

<a name="datasourcemssqlsidpatch"></a>
# **DataSourceMsSqlsIdPatch**
> DataSourceMsSql DataSourceMsSqlsIdPatch (string id, DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id
            var data = new DataSourceMsSql(); // DataSourceMsSql | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsidput"></a>
# **DataSourceMsSqlsIdPut**
> DataSourceMsSql DataSourceMsSqlsIdPut (string id, DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceMsSql(); // DataSourceMsSql | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| Model instance data | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsidreplacepost"></a>
# **DataSourceMsSqlsIdReplacePost**
> DataSourceMsSql DataSourceMsSqlsIdReplacePost (string id, DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceMsSql(); // DataSourceMsSql | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| Model instance data | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsidteamget"></a>
# **DataSourceMsSqlsIdTeamGet**
> Team DataSourceMsSqlsIdTeamGet (string id, bool? refresh = null)

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
    public class DataSourceMsSqlsIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var id = id_example;  // string | DataSourceMsSql id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.DataSourceMsSqlsIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMsSql id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlspatch"></a>
# **DataSourceMsSqlsPatch**
> DataSourceMsSql DataSourceMsSqlsPatch (DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var data = new DataSourceMsSql(); // DataSourceMsSql | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| Model instance data | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlspost"></a>
# **DataSourceMsSqlsPost**
> DataSourceMsSql DataSourceMsSqlsPost (DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var data = new DataSourceMsSql(); // DataSourceMsSql | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| Model instance data | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsput"></a>
# **DataSourceMsSqlsPut**
> DataSourceMsSql DataSourceMsSqlsPut (DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var data = new DataSourceMsSql(); // DataSourceMsSql | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| Model instance data | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsreplaceorcreatepost"></a>
# **DataSourceMsSqlsReplaceOrCreatePost**
> DataSourceMsSql DataSourceMsSqlsReplaceOrCreatePost (DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var data = new DataSourceMsSql(); // DataSourceMsSql | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| Model instance data | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsupdatepost"></a>
# **DataSourceMsSqlsUpdatePost**
> InlineResponse2003 DataSourceMsSqlsUpdatePost (string where = null, DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DataSourceMsSql(); // DataSourceMsSql | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2003 result = apiInstance.DataSourceMsSqlsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemssqlsupsertwithwherepost"></a>
# **DataSourceMsSqlsUpsertWithWherePost**
> DataSourceMsSql DataSourceMsSqlsUpsertWithWherePost (string where = null, DataSourceMsSql data = null)

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
    public class DataSourceMsSqlsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMsSqlApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DataSourceMsSql(); // DataSourceMsSql | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                DataSourceMsSql result = apiInstance.DataSourceMsSqlsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMsSqlApi.DataSourceMsSqlsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DataSourceMsSql**](DataSourceMsSql.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

