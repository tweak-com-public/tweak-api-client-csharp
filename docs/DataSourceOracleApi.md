# TweakApi.Api.DataSourceOracleApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataSourceOraclesChangeStreamGet**](DataSourceOracleApi.md#datasourceoracleschangestreamget) | **GET** /DataSourceOracles/change-stream | Create a change stream.
[**DataSourceOraclesChangeStreamPost**](DataSourceOracleApi.md#datasourceoracleschangestreampost) | **POST** /DataSourceOracles/change-stream | Create a change stream.
[**DataSourceOraclesCountGet**](DataSourceOracleApi.md#datasourceoraclescountget) | **GET** /DataSourceOracles/count | Count instances of the model matched by where from the data source.
[**DataSourceOraclesFindOneGet**](DataSourceOracleApi.md#datasourceoraclesfindoneget) | **GET** /DataSourceOracles/findOne | Find first instance of the model matched by filter from the data source.
[**DataSourceOraclesGet**](DataSourceOracleApi.md#datasourceoraclesget) | **GET** /DataSourceOracles | Find all instances of the model matched by filter from the data source.
[**DataSourceOraclesIdDelete**](DataSourceOracleApi.md#datasourceoraclesiddelete) | **DELETE** /DataSourceOracles/{id} | Delete a model instance by {{id}} from the data source.
[**DataSourceOraclesIdDynamicDatasCountGet**](DataSourceOracleApi.md#datasourceoraclesiddynamicdatascountget) | **GET** /DataSourceOracles/{id}/dynamicDatas/count | Counts dynamicDatas of DataSourceOracle.
[**DataSourceOraclesIdDynamicDatasDelete**](DataSourceOracleApi.md#datasourceoraclesiddynamicdatasdelete) | **DELETE** /DataSourceOracles/{id}/dynamicDatas | Deletes all dynamicDatas of this model.
[**DataSourceOraclesIdDynamicDatasFkDelete**](DataSourceOracleApi.md#datasourceoraclesiddynamicdatasfkdelete) | **DELETE** /DataSourceOracles/{id}/dynamicDatas/{fk} | Delete a related item by id for dynamicDatas.
[**DataSourceOraclesIdDynamicDatasFkGet**](DataSourceOracleApi.md#datasourceoraclesiddynamicdatasfkget) | **GET** /DataSourceOracles/{id}/dynamicDatas/{fk} | Find a related item by id for dynamicDatas.
[**DataSourceOraclesIdDynamicDatasFkPut**](DataSourceOracleApi.md#datasourceoraclesiddynamicdatasfkput) | **PUT** /DataSourceOracles/{id}/dynamicDatas/{fk} | Update a related item by id for dynamicDatas.
[**DataSourceOraclesIdDynamicDatasGet**](DataSourceOracleApi.md#datasourceoraclesiddynamicdatasget) | **GET** /DataSourceOracles/{id}/dynamicDatas | Queries dynamicDatas of DataSourceOracle.
[**DataSourceOraclesIdDynamicDatasPost**](DataSourceOracleApi.md#datasourceoraclesiddynamicdataspost) | **POST** /DataSourceOracles/{id}/dynamicDatas | Creates a new instance in dynamicDatas of this model.
[**DataSourceOraclesIdExistsGet**](DataSourceOracleApi.md#datasourceoraclesidexistsget) | **GET** /DataSourceOracles/{id}/exists | Check whether a model instance exists in the data source.
[**DataSourceOraclesIdGet**](DataSourceOracleApi.md#datasourceoraclesidget) | **GET** /DataSourceOracles/{id} | Find a model instance by {{id}} from the data source.
[**DataSourceOraclesIdHead**](DataSourceOracleApi.md#datasourceoraclesidhead) | **HEAD** /DataSourceOracles/{id} | Check whether a model instance exists in the data source.
[**DataSourceOraclesIdPatch**](DataSourceOracleApi.md#datasourceoraclesidpatch) | **PATCH** /DataSourceOracles/{id} | Patch attributes for a model instance and persist it into the data source.
[**DataSourceOraclesIdPut**](DataSourceOracleApi.md#datasourceoraclesidput) | **PUT** /DataSourceOracles/{id} | Replace attributes for a model instance and persist it into the data source.
[**DataSourceOraclesIdReplacePost**](DataSourceOracleApi.md#datasourceoraclesidreplacepost) | **POST** /DataSourceOracles/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DataSourceOraclesIdTeamGet**](DataSourceOracleApi.md#datasourceoraclesidteamget) | **GET** /DataSourceOracles/{id}/team | Fetches belongsTo relation team.
[**DataSourceOraclesPost**](DataSourceOracleApi.md#datasourceoraclespost) | **POST** /DataSourceOracles | Create a new instance of the model and persist it into the data source.


<a name="datasourceoracleschangestreamget"></a>
# **DataSourceOraclesChangeStreamGet**
> System.IO.Stream DataSourceOraclesChangeStreamGet (string options = null)

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
    public class DataSourceOraclesChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceOraclesChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesChangeStreamGet: " + e.Message );
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

<a name="datasourceoracleschangestreampost"></a>
# **DataSourceOraclesChangeStreamPost**
> System.IO.Stream DataSourceOraclesChangeStreamPost (string options = null)

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
    public class DataSourceOraclesChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceOraclesChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesChangeStreamPost: " + e.Message );
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

<a name="datasourceoraclescountget"></a>
# **DataSourceOraclesCountGet**
> InlineResponse2001 DataSourceOraclesCountGet (string where = null)

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
    public class DataSourceOraclesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.DataSourceOraclesCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesCountGet: " + e.Message );
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

<a name="datasourceoraclesfindoneget"></a>
# **DataSourceOraclesFindOneGet**
> DataSourceOracle DataSourceOraclesFindOneGet (string filter = null)

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
    public class DataSourceOraclesFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DataSourceOracle result = apiInstance.DataSourceOraclesFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesFindOneGet: " + e.Message );
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

[**DataSourceOracle**](DataSourceOracle.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesget"></a>
# **DataSourceOraclesGet**
> List<DataSourceOracle> DataSourceOraclesGet (string filter = null)

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
    public class DataSourceOraclesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DataSourceOracle&gt; result = apiInstance.DataSourceOraclesGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesGet: " + e.Message );
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

[**List<DataSourceOracle>**](DataSourceOracle.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesiddelete"></a>
# **DataSourceOraclesIdDelete**
> Object DataSourceOraclesIdDelete (string id)

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
    public class DataSourceOraclesIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DataSourceOraclesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdDelete: " + e.Message );
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

<a name="datasourceoraclesiddynamicdatascountget"></a>
# **DataSourceOraclesIdDynamicDatasCountGet**
> InlineResponse2001 DataSourceOraclesIdDynamicDatasCountGet (string id, string where = null)

Counts dynamicDatas of DataSourceOracle.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceOraclesIdDynamicDatasCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts dynamicDatas of DataSourceOracle.
                InlineResponse2001 result = apiInstance.DataSourceOraclesIdDynamicDatasCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdDynamicDatasCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesiddynamicdatasdelete"></a>
# **DataSourceOraclesIdDynamicDatasDelete**
> void DataSourceOraclesIdDynamicDatasDelete (string id)

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
    public class DataSourceOraclesIdDynamicDatasDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id

            try
            {
                // Deletes all dynamicDatas of this model.
                apiInstance.DataSourceOraclesIdDynamicDatasDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdDynamicDatasDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesiddynamicdatasfkdelete"></a>
# **DataSourceOraclesIdDynamicDatasFkDelete**
> void DataSourceOraclesIdDynamicDatasFkDelete (string id, string fk)

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
    public class DataSourceOraclesIdDynamicDatasFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Delete a related item by id for dynamicDatas.
                apiInstance.DataSourceOraclesIdDynamicDatasFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdDynamicDatasFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesiddynamicdatasfkget"></a>
# **DataSourceOraclesIdDynamicDatasFkGet**
> DynamicData DataSourceOraclesIdDynamicDatasFkGet (string id, string fk)

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
    public class DataSourceOraclesIdDynamicDatasFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Find a related item by id for dynamicDatas.
                DynamicData result = apiInstance.DataSourceOraclesIdDynamicDatasFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdDynamicDatasFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesiddynamicdatasfkput"></a>
# **DataSourceOraclesIdDynamicDatasFkPut**
> DynamicData DataSourceOraclesIdDynamicDatasFkPut (string id, string fk, DynamicData data = null)

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
    public class DataSourceOraclesIdDynamicDatasFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id
            var fk = fk_example;  // string | Foreign key for dynamicDatas
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Update a related item by id for dynamicDatas.
                DynamicData result = apiInstance.DataSourceOraclesIdDynamicDatasFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdDynamicDatasFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 
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

<a name="datasourceoraclesiddynamicdatasget"></a>
# **DataSourceOraclesIdDynamicDatasGet**
> List<DynamicData> DataSourceOraclesIdDynamicDatasGet (string id, string filter = null)

Queries dynamicDatas of DataSourceOracle.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceOraclesIdDynamicDatasGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries dynamicDatas of DataSourceOracle.
                List&lt;DynamicData&gt; result = apiInstance.DataSourceOraclesIdDynamicDatasGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdDynamicDatasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DynamicData>**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesiddynamicdataspost"></a>
# **DataSourceOraclesIdDynamicDatasPost**
> DynamicData DataSourceOraclesIdDynamicDatasPost (string id, DynamicData data = null)

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
    public class DataSourceOraclesIdDynamicDatasPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Creates a new instance in dynamicDatas of this model.
                DynamicData result = apiInstance.DataSourceOraclesIdDynamicDatasPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdDynamicDatasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 
 **data** | [**DynamicData**](DynamicData.md)|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesidexistsget"></a>
# **DataSourceOraclesIdExistsGet**
> InlineResponse2002 DataSourceOraclesIdExistsGet (string id)

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
    public class DataSourceOraclesIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DataSourceOraclesIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdExistsGet: " + e.Message );
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

<a name="datasourceoraclesidget"></a>
# **DataSourceOraclesIdGet**
> DataSourceOracle DataSourceOraclesIdGet (string id, string filter = null)

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
    public class DataSourceOraclesIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DataSourceOracle result = apiInstance.DataSourceOraclesIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdGet: " + e.Message );
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

[**DataSourceOracle**](DataSourceOracle.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesidhead"></a>
# **DataSourceOraclesIdHead**
> InlineResponse2002 DataSourceOraclesIdHead (string id)

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
    public class DataSourceOraclesIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DataSourceOraclesIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdHead: " + e.Message );
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

<a name="datasourceoraclesidpatch"></a>
# **DataSourceOraclesIdPatch**
> DataSourceOracle DataSourceOraclesIdPatch (string id, DataSourceOracle data = null)

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
    public class DataSourceOraclesIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id
            var data = new DataSourceOracle(); // DataSourceOracle | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DataSourceOracle result = apiInstance.DataSourceOraclesIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 
 **data** | [**DataSourceOracle**](DataSourceOracle.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DataSourceOracle**](DataSourceOracle.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesidput"></a>
# **DataSourceOraclesIdPut**
> DataSourceOracle DataSourceOraclesIdPut (string id, DataSourceOracle data = null)

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
    public class DataSourceOraclesIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceOracle(); // DataSourceOracle | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceOracle result = apiInstance.DataSourceOraclesIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceOracle**](DataSourceOracle.md)| Model instance data | [optional] 

### Return type

[**DataSourceOracle**](DataSourceOracle.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesidreplacepost"></a>
# **DataSourceOraclesIdReplacePost**
> DataSourceOracle DataSourceOraclesIdReplacePost (string id, DataSourceOracle data = null)

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
    public class DataSourceOraclesIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceOracle(); // DataSourceOracle | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceOracle result = apiInstance.DataSourceOraclesIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceOracle**](DataSourceOracle.md)| Model instance data | [optional] 

### Return type

[**DataSourceOracle**](DataSourceOracle.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclesidteamget"></a>
# **DataSourceOraclesIdTeamGet**
> Team DataSourceOraclesIdTeamGet (string id, bool? refresh = null)

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
    public class DataSourceOraclesIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var id = id_example;  // string | DataSourceOracle id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.DataSourceOraclesIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceOracle id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourceoraclespost"></a>
# **DataSourceOraclesPost**
> DataSourceOracle DataSourceOraclesPost (DataSourceOracle data = null)

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
    public class DataSourceOraclesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceOracleApi();
            var data = new DataSourceOracle(); // DataSourceOracle | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DataSourceOracle result = apiInstance.DataSourceOraclesPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceOracleApi.DataSourceOraclesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceOracle**](DataSourceOracle.md)| Model instance data | [optional] 

### Return type

[**DataSourceOracle**](DataSourceOracle.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

