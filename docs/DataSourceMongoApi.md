# TweakApi.Api.DataSourceMongoApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataSourceMongosChangeStreamGet**](DataSourceMongoApi.md#datasourcemongoschangestreamget) | **GET** /DataSourceMongos/change-stream | Create a change stream.
[**DataSourceMongosChangeStreamPost**](DataSourceMongoApi.md#datasourcemongoschangestreampost) | **POST** /DataSourceMongos/change-stream | Create a change stream.
[**DataSourceMongosCountGet**](DataSourceMongoApi.md#datasourcemongoscountget) | **GET** /DataSourceMongos/count | Count instances of the model matched by where from the data source.
[**DataSourceMongosFindOneGet**](DataSourceMongoApi.md#datasourcemongosfindoneget) | **GET** /DataSourceMongos/findOne | Find first instance of the model matched by filter from the data source.
[**DataSourceMongosGet**](DataSourceMongoApi.md#datasourcemongosget) | **GET** /DataSourceMongos | Find all instances of the model matched by filter from the data source.
[**DataSourceMongosIdDelete**](DataSourceMongoApi.md#datasourcemongosiddelete) | **DELETE** /DataSourceMongos/{id} | Delete a model instance by {{id}} from the data source.
[**DataSourceMongosIdDynamicDatasCountGet**](DataSourceMongoApi.md#datasourcemongosiddynamicdatascountget) | **GET** /DataSourceMongos/{id}/dynamicDatas/count | Counts dynamicDatas of DataSourceMongo.
[**DataSourceMongosIdDynamicDatasDelete**](DataSourceMongoApi.md#datasourcemongosiddynamicdatasdelete) | **DELETE** /DataSourceMongos/{id}/dynamicDatas | Deletes all dynamicDatas of this model.
[**DataSourceMongosIdDynamicDatasFkDelete**](DataSourceMongoApi.md#datasourcemongosiddynamicdatasfkdelete) | **DELETE** /DataSourceMongos/{id}/dynamicDatas/{fk} | Delete a related item by id for dynamicDatas.
[**DataSourceMongosIdDynamicDatasFkGet**](DataSourceMongoApi.md#datasourcemongosiddynamicdatasfkget) | **GET** /DataSourceMongos/{id}/dynamicDatas/{fk} | Find a related item by id for dynamicDatas.
[**DataSourceMongosIdDynamicDatasFkPut**](DataSourceMongoApi.md#datasourcemongosiddynamicdatasfkput) | **PUT** /DataSourceMongos/{id}/dynamicDatas/{fk} | Update a related item by id for dynamicDatas.
[**DataSourceMongosIdDynamicDatasGet**](DataSourceMongoApi.md#datasourcemongosiddynamicdatasget) | **GET** /DataSourceMongos/{id}/dynamicDatas | Queries dynamicDatas of DataSourceMongo.
[**DataSourceMongosIdDynamicDatasPost**](DataSourceMongoApi.md#datasourcemongosiddynamicdataspost) | **POST** /DataSourceMongos/{id}/dynamicDatas | Creates a new instance in dynamicDatas of this model.
[**DataSourceMongosIdExistsGet**](DataSourceMongoApi.md#datasourcemongosidexistsget) | **GET** /DataSourceMongos/{id}/exists | Check whether a model instance exists in the data source.
[**DataSourceMongosIdGet**](DataSourceMongoApi.md#datasourcemongosidget) | **GET** /DataSourceMongos/{id} | Find a model instance by {{id}} from the data source.
[**DataSourceMongosIdHead**](DataSourceMongoApi.md#datasourcemongosidhead) | **HEAD** /DataSourceMongos/{id} | Check whether a model instance exists in the data source.
[**DataSourceMongosIdPatch**](DataSourceMongoApi.md#datasourcemongosidpatch) | **PATCH** /DataSourceMongos/{id} | Patch attributes for a model instance and persist it into the data source.
[**DataSourceMongosIdPut**](DataSourceMongoApi.md#datasourcemongosidput) | **PUT** /DataSourceMongos/{id} | Replace attributes for a model instance and persist it into the data source.
[**DataSourceMongosIdReplacePost**](DataSourceMongoApi.md#datasourcemongosidreplacepost) | **POST** /DataSourceMongos/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DataSourceMongosIdTeamGet**](DataSourceMongoApi.md#datasourcemongosidteamget) | **GET** /DataSourceMongos/{id}/team | Fetches belongsTo relation team.
[**DataSourceMongosPost**](DataSourceMongoApi.md#datasourcemongospost) | **POST** /DataSourceMongos | Create a new instance of the model and persist it into the data source.


<a name="datasourcemongoschangestreamget"></a>
# **DataSourceMongosChangeStreamGet**
> System.IO.Stream DataSourceMongosChangeStreamGet (string options = null)

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
    public class DataSourceMongosChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceMongosChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosChangeStreamGet: " + e.Message );
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

<a name="datasourcemongoschangestreampost"></a>
# **DataSourceMongosChangeStreamPost**
> System.IO.Stream DataSourceMongosChangeStreamPost (string options = null)

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
    public class DataSourceMongosChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DataSourceMongosChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosChangeStreamPost: " + e.Message );
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

<a name="datasourcemongoscountget"></a>
# **DataSourceMongosCountGet**
> InlineResponse2001 DataSourceMongosCountGet (string where = null)

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
    public class DataSourceMongosCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.DataSourceMongosCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosCountGet: " + e.Message );
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

<a name="datasourcemongosfindoneget"></a>
# **DataSourceMongosFindOneGet**
> DataSourceMongo DataSourceMongosFindOneGet (string filter = null)

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
    public class DataSourceMongosFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DataSourceMongo result = apiInstance.DataSourceMongosFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosFindOneGet: " + e.Message );
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

[**DataSourceMongo**](DataSourceMongo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosget"></a>
# **DataSourceMongosGet**
> List<DataSourceMongo> DataSourceMongosGet (string filter = null)

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
    public class DataSourceMongosGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DataSourceMongo&gt; result = apiInstance.DataSourceMongosGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosGet: " + e.Message );
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

[**List<DataSourceMongo>**](DataSourceMongo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosiddelete"></a>
# **DataSourceMongosIdDelete**
> Object DataSourceMongosIdDelete (string id)

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
    public class DataSourceMongosIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DataSourceMongosIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdDelete: " + e.Message );
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

<a name="datasourcemongosiddynamicdatascountget"></a>
# **DataSourceMongosIdDynamicDatasCountGet**
> InlineResponse2001 DataSourceMongosIdDynamicDatasCountGet (string id, string where = null)

Counts dynamicDatas of DataSourceMongo.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMongosIdDynamicDatasCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts dynamicDatas of DataSourceMongo.
                InlineResponse2001 result = apiInstance.DataSourceMongosIdDynamicDatasCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdDynamicDatasCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosiddynamicdatasdelete"></a>
# **DataSourceMongosIdDynamicDatasDelete**
> void DataSourceMongosIdDynamicDatasDelete (string id)

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
    public class DataSourceMongosIdDynamicDatasDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id

            try
            {
                // Deletes all dynamicDatas of this model.
                apiInstance.DataSourceMongosIdDynamicDatasDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdDynamicDatasDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosiddynamicdatasfkdelete"></a>
# **DataSourceMongosIdDynamicDatasFkDelete**
> void DataSourceMongosIdDynamicDatasFkDelete (string id, string fk)

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
    public class DataSourceMongosIdDynamicDatasFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Delete a related item by id for dynamicDatas.
                apiInstance.DataSourceMongosIdDynamicDatasFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdDynamicDatasFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosiddynamicdatasfkget"></a>
# **DataSourceMongosIdDynamicDatasFkGet**
> DynamicData DataSourceMongosIdDynamicDatasFkGet (string id, string fk)

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
    public class DataSourceMongosIdDynamicDatasFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id
            var fk = fk_example;  // string | Foreign key for dynamicDatas

            try
            {
                // Find a related item by id for dynamicDatas.
                DynamicData result = apiInstance.DataSourceMongosIdDynamicDatasFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdDynamicDatasFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 
 **fk** | **string**| Foreign key for dynamicDatas | 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosiddynamicdatasfkput"></a>
# **DataSourceMongosIdDynamicDatasFkPut**
> DynamicData DataSourceMongosIdDynamicDatasFkPut (string id, string fk, DynamicData data = null)

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
    public class DataSourceMongosIdDynamicDatasFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id
            var fk = fk_example;  // string | Foreign key for dynamicDatas
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Update a related item by id for dynamicDatas.
                DynamicData result = apiInstance.DataSourceMongosIdDynamicDatasFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdDynamicDatasFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 
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

<a name="datasourcemongosiddynamicdatasget"></a>
# **DataSourceMongosIdDynamicDatasGet**
> List<DynamicData> DataSourceMongosIdDynamicDatasGet (string id, string filter = null)

Queries dynamicDatas of DataSourceMongo.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourceMongosIdDynamicDatasGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries dynamicDatas of DataSourceMongo.
                List&lt;DynamicData&gt; result = apiInstance.DataSourceMongosIdDynamicDatasGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdDynamicDatasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DynamicData>**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosiddynamicdataspost"></a>
# **DataSourceMongosIdDynamicDatasPost**
> DynamicData DataSourceMongosIdDynamicDatasPost (string id, DynamicData data = null)

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
    public class DataSourceMongosIdDynamicDatasPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Creates a new instance in dynamicDatas of this model.
                DynamicData result = apiInstance.DataSourceMongosIdDynamicDatasPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdDynamicDatasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 
 **data** | [**DynamicData**](DynamicData.md)|  | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosidexistsget"></a>
# **DataSourceMongosIdExistsGet**
> InlineResponse2002 DataSourceMongosIdExistsGet (string id)

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
    public class DataSourceMongosIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DataSourceMongosIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdExistsGet: " + e.Message );
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

<a name="datasourcemongosidget"></a>
# **DataSourceMongosIdGet**
> DataSourceMongo DataSourceMongosIdGet (string id, string filter = null)

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
    public class DataSourceMongosIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DataSourceMongo result = apiInstance.DataSourceMongosIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdGet: " + e.Message );
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

[**DataSourceMongo**](DataSourceMongo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosidhead"></a>
# **DataSourceMongosIdHead**
> InlineResponse2002 DataSourceMongosIdHead (string id)

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
    public class DataSourceMongosIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DataSourceMongosIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdHead: " + e.Message );
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

<a name="datasourcemongosidpatch"></a>
# **DataSourceMongosIdPatch**
> DataSourceMongo DataSourceMongosIdPatch (string id, DataSourceMongo data = null)

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
    public class DataSourceMongosIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id
            var data = new DataSourceMongo(); // DataSourceMongo | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DataSourceMongo result = apiInstance.DataSourceMongosIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 
 **data** | [**DataSourceMongo**](DataSourceMongo.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DataSourceMongo**](DataSourceMongo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosidput"></a>
# **DataSourceMongosIdPut**
> DataSourceMongo DataSourceMongosIdPut (string id, DataSourceMongo data = null)

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
    public class DataSourceMongosIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceMongo(); // DataSourceMongo | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceMongo result = apiInstance.DataSourceMongosIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceMongo**](DataSourceMongo.md)| Model instance data | [optional] 

### Return type

[**DataSourceMongo**](DataSourceMongo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosidreplacepost"></a>
# **DataSourceMongosIdReplacePost**
> DataSourceMongo DataSourceMongosIdReplacePost (string id, DataSourceMongo data = null)

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
    public class DataSourceMongosIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | Model id
            var data = new DataSourceMongo(); // DataSourceMongo | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DataSourceMongo result = apiInstance.DataSourceMongosIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DataSourceMongo**](DataSourceMongo.md)| Model instance data | [optional] 

### Return type

[**DataSourceMongo**](DataSourceMongo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongosidteamget"></a>
# **DataSourceMongosIdTeamGet**
> Team DataSourceMongosIdTeamGet (string id, bool? refresh = null)

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
    public class DataSourceMongosIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var id = id_example;  // string | DataSourceMongo id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.DataSourceMongosIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSourceMongo id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcemongospost"></a>
# **DataSourceMongosPost**
> DataSourceMongo DataSourceMongosPost (DataSourceMongo data = null)

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
    public class DataSourceMongosPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceMongoApi();
            var data = new DataSourceMongo(); // DataSourceMongo | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DataSourceMongo result = apiInstance.DataSourceMongosPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceMongoApi.DataSourceMongosPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DataSourceMongo**](DataSourceMongo.md)| Model instance data | [optional] 

### Return type

[**DataSourceMongo**](DataSourceMongo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

