# TweakApi.Api.DynamicDataApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DynamicDataChangeStreamGet**](DynamicDataApi.md#dynamicdatachangestreamget) | **GET** /DynamicData/change-stream | Create a change stream.
[**DynamicDataChangeStreamPost**](DynamicDataApi.md#dynamicdatachangestreampost) | **POST** /DynamicData/change-stream | Create a change stream.
[**DynamicDataCountGet**](DynamicDataApi.md#dynamicdatacountget) | **GET** /DynamicData/count | Count instances of the model matched by where from the data source.
[**DynamicDataFindOneGet**](DynamicDataApi.md#dynamicdatafindoneget) | **GET** /DynamicData/findOne | Find first instance of the model matched by filter from the data source.
[**DynamicDataGet**](DynamicDataApi.md#dynamicdataget) | **GET** /DynamicData | Find all instances of the model matched by filter from the data source.
[**DynamicDataIdDataSourceMongoGet**](DynamicDataApi.md#dynamicdataiddatasourcemongoget) | **GET** /DynamicData/{id}/dataSourceMongo | Fetches belongsTo relation dataSourceMongo.
[**DynamicDataIdDataSourceMsSqlGet**](DynamicDataApi.md#dynamicdataiddatasourcemssqlget) | **GET** /DynamicData/{id}/dataSourceMsSql | Fetches belongsTo relation dataSourceMsSql.
[**DynamicDataIdDataSourceMySqlGet**](DynamicDataApi.md#dynamicdataiddatasourcemysqlget) | **GET** /DynamicData/{id}/dataSourceMySql | Fetches belongsTo relation dataSourceMySql.
[**DynamicDataIdDataSourceOracleGet**](DynamicDataApi.md#dynamicdataiddatasourceoracleget) | **GET** /DynamicData/{id}/dataSourceOracle | Fetches belongsTo relation dataSourceOracle.
[**DynamicDataIdDataSourcePostgreSqlGet**](DynamicDataApi.md#dynamicdataiddatasourcepostgresqlget) | **GET** /DynamicData/{id}/dataSourcePostgreSql | Fetches belongsTo relation dataSourcePostgreSql.
[**DynamicDataIdDataSourceRestGet**](DynamicDataApi.md#dynamicdataiddatasourcerestget) | **GET** /DynamicData/{id}/dataSourceRest | Fetches belongsTo relation dataSourceRest.
[**DynamicDataIdDataSourceSoapGet**](DynamicDataApi.md#dynamicdataiddatasourcesoapget) | **GET** /DynamicData/{id}/dataSourceSoap | Fetches belongsTo relation dataSourceSoap.
[**DynamicDataIdDelete**](DynamicDataApi.md#dynamicdataiddelete) | **DELETE** /DynamicData/{id} | Delete a model instance by {{id}} from the data source.
[**DynamicDataIdDesignsCountGet**](DynamicDataApi.md#dynamicdataiddesignscountget) | **GET** /DynamicData/{id}/designs/count | Counts designs of DynamicData.
[**DynamicDataIdDesignsFkDelete**](DynamicDataApi.md#dynamicdataiddesignsfkdelete) | **DELETE** /DynamicData/{id}/designs/{fk} | Delete a related item by id for designs.
[**DynamicDataIdDesignsFkGet**](DynamicDataApi.md#dynamicdataiddesignsfkget) | **GET** /DynamicData/{id}/designs/{fk} | Find a related item by id for designs.
[**DynamicDataIdDesignsFkPut**](DynamicDataApi.md#dynamicdataiddesignsfkput) | **PUT** /DynamicData/{id}/designs/{fk} | Update a related item by id for designs.
[**DynamicDataIdDesignsGet**](DynamicDataApi.md#dynamicdataiddesignsget) | **GET** /DynamicData/{id}/designs | Queries designs of DynamicData.
[**DynamicDataIdDesignsPost**](DynamicDataApi.md#dynamicdataiddesignspost) | **POST** /DynamicData/{id}/designs | Creates a new instance in designs of this model.
[**DynamicDataIdExistsGet**](DynamicDataApi.md#dynamicdataidexistsget) | **GET** /DynamicData/{id}/exists | Check whether a model instance exists in the data source.
[**DynamicDataIdFetchRawGet**](DynamicDataApi.md#dynamicdataidfetchrawget) | **GET** /DynamicData/{id}/fetch/raw | Fetch raw datas from external servers.
[**DynamicDataIdGet**](DynamicDataApi.md#dynamicdataidget) | **GET** /DynamicData/{id} | Find a model instance by {{id}} from the data source.
[**DynamicDataIdHead**](DynamicDataApi.md#dynamicdataidhead) | **HEAD** /DynamicData/{id} | Check whether a model instance exists in the data source.
[**DynamicDataIdPatch**](DynamicDataApi.md#dynamicdataidpatch) | **PATCH** /DynamicData/{id} | Patch attributes for a model instance and persist it into the data source.
[**DynamicDataIdPut**](DynamicDataApi.md#dynamicdataidput) | **PUT** /DynamicData/{id} | Replace attributes for a model instance and persist it into the data source.
[**DynamicDataIdRecordsCountGet**](DynamicDataApi.md#dynamicdataidrecordscountget) | **GET** /DynamicData/{id}/records/count | Count Dynamic Data records
[**DynamicDataIdRecordsDelete**](DynamicDataApi.md#dynamicdataidrecordsdelete) | **DELETE** /DynamicData/{id}/records | Delete all matching records.
[**DynamicDataIdRecordsFkDelete**](DynamicDataApi.md#dynamicdataidrecordsfkdelete) | **DELETE** /DynamicData/{id}/records/{fk} | Delete a model instance by {{fk}} from the data source.
[**DynamicDataIdRecordsFkGet**](DynamicDataApi.md#dynamicdataidrecordsfkget) | **GET** /DynamicData/{id}/records/{fk} | Find a model instance by {{fk}} from the data source.
[**DynamicDataIdRecordsFkPropertyNameUploadPut**](DynamicDataApi.md#dynamicdataidrecordsfkpropertynameuploadput) | **PUT** /DynamicData/{id}/records/{fk}/{propertyName}/upload | Replace attributes for a model instance and persist it into the data source.
[**DynamicDataIdRecordsFkPut**](DynamicDataApi.md#dynamicdataidrecordsfkput) | **PUT** /DynamicData/{id}/records/{fk} | Replace attributes for a model instance and persist it into the data source.
[**DynamicDataIdRecordsGet**](DynamicDataApi.md#dynamicdataidrecordsget) | **GET** /DynamicData/{id}/records | Find all instances of the model matched by filter from the data source.
[**DynamicDataIdRecordsMigratePost**](DynamicDataApi.md#dynamicdataidrecordsmigratepost) | **POST** /DynamicData/{id}/records/migrate | Request migration for Dynamic Data records
[**DynamicDataIdRecordsPost**](DynamicDataApi.md#dynamicdataidrecordspost) | **POST** /DynamicData/{id}/records | Create a new instance of the model and persist it into the data source.
[**DynamicDataIdRecordsUploadCsvPost**](DynamicDataApi.md#dynamicdataidrecordsuploadcsvpost) | **POST** /DynamicData/{id}/records/upload/csv | Upload CSV for this Dynamic Data
[**DynamicDataIdReplacePost**](DynamicDataApi.md#dynamicdataidreplacepost) | **POST** /DynamicData/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DynamicDataIdTeamGet**](DynamicDataApi.md#dynamicdataidteamget) | **GET** /DynamicData/{id}/team | Fetches belongsTo relation team.
[**DynamicDataPost**](DynamicDataApi.md#dynamicdatapost) | **POST** /DynamicData | Create a new instance of the model and persist it into the data source.


<a name="dynamicdatachangestreamget"></a>
# **DynamicDataChangeStreamGet**
> System.IO.Stream DynamicDataChangeStreamGet (string options = null)

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
    public class DynamicDataChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DynamicDataChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataChangeStreamGet: " + e.Message );
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

<a name="dynamicdatachangestreampost"></a>
# **DynamicDataChangeStreamPost**
> System.IO.Stream DynamicDataChangeStreamPost (string options = null)

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
    public class DynamicDataChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DynamicDataChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataChangeStreamPost: " + e.Message );
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

<a name="dynamicdatacountget"></a>
# **DynamicDataCountGet**
> InlineResponse2001 DynamicDataCountGet (string where = null)

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
    public class DynamicDataCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.DynamicDataCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataCountGet: " + e.Message );
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

<a name="dynamicdatafindoneget"></a>
# **DynamicDataFindOneGet**
> DynamicData DynamicDataFindOneGet (string filter = null)

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
    public class DynamicDataFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DynamicData result = apiInstance.DynamicDataFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataFindOneGet: " + e.Message );
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

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataget"></a>
# **DynamicDataGet**
> List<DynamicData> DynamicDataGet (string filter = null)

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
    public class DynamicDataGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DynamicData&gt; result = apiInstance.DynamicDataGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataGet: " + e.Message );
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

[**List<DynamicData>**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddatasourcemongoget"></a>
# **DynamicDataIdDataSourceMongoGet**
> DataSourceMongo DynamicDataIdDataSourceMongoGet (string id, bool? refresh = null)

Fetches belongsTo relation dataSourceMongo.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDataSourceMongoGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSourceMongo.
                DataSourceMongo result = apiInstance.DynamicDataIdDataSourceMongoGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDataSourceMongoGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourceMongo**](DataSourceMongo.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddatasourcemssqlget"></a>
# **DynamicDataIdDataSourceMsSqlGet**
> DataSourceMsSql DynamicDataIdDataSourceMsSqlGet (string id, bool? refresh = null)

Fetches belongsTo relation dataSourceMsSql.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDataSourceMsSqlGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSourceMsSql.
                DataSourceMsSql result = apiInstance.DynamicDataIdDataSourceMsSqlGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDataSourceMsSqlGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourceMsSql**](DataSourceMsSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddatasourcemysqlget"></a>
# **DynamicDataIdDataSourceMySqlGet**
> DataSourceMySql DynamicDataIdDataSourceMySqlGet (string id, bool? refresh = null)

Fetches belongsTo relation dataSourceMySql.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDataSourceMySqlGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSourceMySql.
                DataSourceMySql result = apiInstance.DynamicDataIdDataSourceMySqlGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDataSourceMySqlGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourceMySql**](DataSourceMySql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddatasourceoracleget"></a>
# **DynamicDataIdDataSourceOracleGet**
> DataSourceOracle DynamicDataIdDataSourceOracleGet (string id, bool? refresh = null)

Fetches belongsTo relation dataSourceOracle.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDataSourceOracleGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSourceOracle.
                DataSourceOracle result = apiInstance.DynamicDataIdDataSourceOracleGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDataSourceOracleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourceOracle**](DataSourceOracle.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddatasourcepostgresqlget"></a>
# **DynamicDataIdDataSourcePostgreSqlGet**
> DataSourcePostgreSql DynamicDataIdDataSourcePostgreSqlGet (string id, bool? refresh = null)

Fetches belongsTo relation dataSourcePostgreSql.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDataSourcePostgreSqlGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSourcePostgreSql.
                DataSourcePostgreSql result = apiInstance.DynamicDataIdDataSourcePostgreSqlGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDataSourcePostgreSqlGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourcePostgreSql**](DataSourcePostgreSql.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddatasourcerestget"></a>
# **DynamicDataIdDataSourceRestGet**
> DataSourceRest DynamicDataIdDataSourceRestGet (string id, bool? refresh = null)

Fetches belongsTo relation dataSourceRest.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDataSourceRestGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSourceRest.
                DataSourceRest result = apiInstance.DynamicDataIdDataSourceRestGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDataSourceRestGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourceRest**](DataSourceRest.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddatasourcesoapget"></a>
# **DynamicDataIdDataSourceSoapGet**
> DataSourceSoap DynamicDataIdDataSourceSoapGet (string id, bool? refresh = null)

Fetches belongsTo relation dataSourceSoap.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDataSourceSoapGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation dataSourceSoap.
                DataSourceSoap result = apiInstance.DynamicDataIdDataSourceSoapGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDataSourceSoapGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DataSourceSoap**](DataSourceSoap.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddelete"></a>
# **DynamicDataIdDelete**
> Object DynamicDataIdDelete (string id)

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
    public class DynamicDataIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DynamicDataIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDelete: " + e.Message );
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

<a name="dynamicdataiddesignscountget"></a>
# **DynamicDataIdDesignsCountGet**
> InlineResponse2001 DynamicDataIdDesignsCountGet (string id, string where = null)

Counts designs of DynamicData.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designs of DynamicData.
                InlineResponse2001 result = apiInstance.DynamicDataIdDesignsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddesignsfkdelete"></a>
# **DynamicDataIdDesignsFkDelete**
> void DynamicDataIdDesignsFkDelete (string id, string fk)

Delete a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDesignsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Delete a related item by id for designs.
                apiInstance.DynamicDataIdDesignsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **fk** | **string**| Foreign key for designs | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddesignsfkget"></a>
# **DynamicDataIdDesignsFkGet**
> Design DynamicDataIdDesignsFkGet (string id, string fk)

Find a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDesignsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Find a related item by id for designs.
                Design result = apiInstance.DynamicDataIdDesignsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **fk** | **string**| Foreign key for designs | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddesignsfkput"></a>
# **DynamicDataIdDesignsFkPut**
> Design DynamicDataIdDesignsFkPut (string id, string fk, Design data = null)

Update a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDesignsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var fk = fk_example;  // string | Foreign key for designs
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for designs.
                Design result = apiInstance.DynamicDataIdDesignsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **fk** | **string**| Foreign key for designs | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddesignsget"></a>
# **DynamicDataIdDesignsGet**
> List<Design> DynamicDataIdDesignsGet (string id, string filter = null)

Queries designs of DynamicData.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designs of DynamicData.
                List&lt;Design&gt; result = apiInstance.DynamicDataIdDesignsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataiddesignspost"></a>
# **DynamicDataIdDesignsPost**
> Design DynamicDataIdDesignsPost (string id, Design data = null)

Creates a new instance in designs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdDesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in designs of this model.
                Design result = apiInstance.DynamicDataIdDesignsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidexistsget"></a>
# **DynamicDataIdExistsGet**
> InlineResponse2002 DynamicDataIdExistsGet (string id)

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
    public class DynamicDataIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DynamicDataIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdExistsGet: " + e.Message );
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

<a name="dynamicdataidfetchrawget"></a>
# **DynamicDataIdFetchRawGet**
> XAny DynamicDataIdFetchRawGet (string id, string _params = null)

Fetch raw datas from external servers.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdFetchRawGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var _params = _params_example;  // string | Request parameters (optional) 

            try
            {
                // Fetch raw datas from external servers.
                XAny result = apiInstance.DynamicDataIdFetchRawGet(id, _params);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdFetchRawGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **_params** | **string**| Request parameters | [optional] 

### Return type

[**XAny**](XAny.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidget"></a>
# **DynamicDataIdGet**
> DynamicData DynamicDataIdGet (string id, string filter = null)

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
    public class DynamicDataIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DynamicData result = apiInstance.DynamicDataIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdGet: " + e.Message );
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

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidhead"></a>
# **DynamicDataIdHead**
> InlineResponse2002 DynamicDataIdHead (string id)

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
    public class DynamicDataIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DynamicDataIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdHead: " + e.Message );
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

<a name="dynamicdataidpatch"></a>
# **DynamicDataIdPatch**
> DynamicData DynamicDataIdPatch (string id, DynamicData data = null)

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
    public class DynamicDataIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var data = new DynamicData(); // DynamicData | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DynamicData result = apiInstance.DynamicDataIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **data** | [**DynamicData**](DynamicData.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidput"></a>
# **DynamicDataIdPut**
> DynamicData DynamicDataIdPut (string id, DynamicData data = null)

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
    public class DynamicDataIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | Model id
            var data = new DynamicData(); // DynamicData | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DynamicData result = apiInstance.DynamicDataIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DynamicData**](DynamicData.md)| Model instance data | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordscountget"></a>
# **DynamicDataIdRecordsCountGet**
> InlineResponse2001 DynamicDataIdRecordsCountGet (string id, string where = null)

Count Dynamic Data records

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdRecordsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count Dynamic Data records
                InlineResponse2001 result = apiInstance.DynamicDataIdRecordsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordsdelete"></a>
# **DynamicDataIdRecordsDelete**
> Object DynamicDataIdRecordsDelete (string id, string where = null)

Delete all matching records.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdRecordsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var where = where_example;  // string | filter.where object (optional) 

            try
            {
                // Delete all matching records.
                Object result = apiInstance.DynamicDataIdRecordsDelete(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **where** | **string**| filter.where object | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordsfkdelete"></a>
# **DynamicDataIdRecordsFkDelete**
> Object DynamicDataIdRecordsFkDelete (string id, string fk)

Delete a model instance by {{fk}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdRecordsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var fk = fk_example;  // string | Model id

            try
            {
                // Delete a model instance by {{fk}} from the data source.
                Object result = apiInstance.DynamicDataIdRecordsFkDelete(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **fk** | **string**| Model id | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordsfkget"></a>
# **DynamicDataIdRecordsFkGet**
> Object DynamicDataIdRecordsFkGet (string id, string fk, string filter = null)

Find a model instance by {{fk}} from the data source.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdRecordsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var fk = fk_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{fk}} from the data source.
                Object result = apiInstance.DynamicDataIdRecordsFkGet(id, fk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **fk** | **string**| Model id | 
 **filter** | **string**| Filter defining fields and include - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordsfkpropertynameuploadput"></a>
# **DynamicDataIdRecordsFkPropertyNameUploadPut**
> Object DynamicDataIdRecordsFkPropertyNameUploadPut (string id, string fk, string propertyName, DynamicData data = null)

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
    public class DynamicDataIdRecordsFkPropertyNameUploadPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var fk = fk_example;  // string | Model id
            var propertyName = propertyName_example;  // string | Model property name
            var data = new DynamicData(); // DynamicData | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Object result = apiInstance.DynamicDataIdRecordsFkPropertyNameUploadPut(id, fk, propertyName, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsFkPropertyNameUploadPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **fk** | **string**| Model id | 
 **propertyName** | **string**| Model property name | 
 **data** | [**DynamicData**](DynamicData.md)| Model instance data | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordsfkput"></a>
# **DynamicDataIdRecordsFkPut**
> Object DynamicDataIdRecordsFkPut (string id, string fk, DynamicData data = null)

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
    public class DynamicDataIdRecordsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var fk = fk_example;  // string | Model id
            var data = new DynamicData(); // DynamicData | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Object result = apiInstance.DynamicDataIdRecordsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **fk** | **string**| Model id | 
 **data** | [**DynamicData**](DynamicData.md)| Model instance data | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordsget"></a>
# **DynamicDataIdRecordsGet**
> List<Object> DynamicDataIdRecordsGet (string id, string filter = null)

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
    public class DynamicDataIdRecordsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;Object&gt; result = apiInstance.DynamicDataIdRecordsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **filter** | **string**| Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) | [optional] 

### Return type

**List<Object>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordsmigratepost"></a>
# **DynamicDataIdRecordsMigratePost**
> Object DynamicDataIdRecordsMigratePost (string id, DynamicData data = null)

Request migration for Dynamic Data records

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdRecordsMigratePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var data = new DynamicData(); // DynamicData |  (optional) 

            try
            {
                // Request migration for Dynamic Data records
                Object result = apiInstance.DynamicDataIdRecordsMigratePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsMigratePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **data** | [**DynamicData**](DynamicData.md)|  | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordspost"></a>
# **DynamicDataIdRecordsPost**
> Object DynamicDataIdRecordsPost (string id, DynamicData data = null)

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
    public class DynamicDataIdRecordsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var data = new DynamicData(); // DynamicData | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                Object result = apiInstance.DynamicDataIdRecordsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **data** | [**DynamicData**](DynamicData.md)| Model instance data | [optional] 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidrecordsuploadcsvpost"></a>
# **DynamicDataIdRecordsUploadCsvPost**
> Object DynamicDataIdRecordsUploadCsvPost (string id)

Upload CSV for this Dynamic Data

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DynamicDataIdRecordsUploadCsvPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id

            try
            {
                // Upload CSV for this Dynamic Data
                Object result = apiInstance.DynamicDataIdRecordsUploadCsvPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdRecordsUploadCsvPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidreplacepost"></a>
# **DynamicDataIdReplacePost**
> DynamicData DynamicDataIdReplacePost (string id, DynamicData data = null)

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
    public class DynamicDataIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | Model id
            var data = new DynamicData(); // DynamicData | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DynamicData result = apiInstance.DynamicDataIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DynamicData**](DynamicData.md)| Model instance data | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdataidteamget"></a>
# **DynamicDataIdTeamGet**
> Team DynamicDataIdTeamGet (string id, bool? refresh = null)

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
    public class DynamicDataIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var id = id_example;  // string | DynamicData id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.DynamicDataIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DynamicData id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dynamicdatapost"></a>
# **DynamicDataPost**
> DynamicData DynamicDataPost (DynamicData data = null)

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
    public class DynamicDataPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DynamicDataApi();
            var data = new DynamicData(); // DynamicData | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DynamicData result = apiInstance.DynamicDataPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DynamicDataApi.DynamicDataPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DynamicData**](DynamicData.md)| Model instance data | [optional] 

### Return type

[**DynamicData**](DynamicData.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

