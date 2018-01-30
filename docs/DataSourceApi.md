# TweakApi.Api.DataSourceApi

All URIs are relative to *https://apicdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataSourcesIdKeysCountGet**](DataSourceApi.md#datasourcesidkeyscountget) | **GET** /DataSources/{id}/keys/count | Counts keys of DataSource.
[**DataSourcesIdKeysDelete**](DataSourceApi.md#datasourcesidkeysdelete) | **DELETE** /DataSources/{id}/keys | Deletes all keys of this model.
[**DataSourcesIdKeysFkDelete**](DataSourceApi.md#datasourcesidkeysfkdelete) | **DELETE** /DataSources/{id}/keys/{fk} | Delete a related item by id for keys.
[**DataSourcesIdKeysFkGet**](DataSourceApi.md#datasourcesidkeysfkget) | **GET** /DataSources/{id}/keys/{fk} | Find a related item by id for keys.
[**DataSourcesIdKeysFkPut**](DataSourceApi.md#datasourcesidkeysfkput) | **PUT** /DataSources/{id}/keys/{fk} | Update a related item by id for keys.
[**DataSourcesIdKeysGet**](DataSourceApi.md#datasourcesidkeysget) | **GET** /DataSources/{id}/keys | Queries keys of DataSource.
[**DataSourcesIdKeysPost**](DataSourceApi.md#datasourcesidkeyspost) | **POST** /DataSources/{id}/keys | Creates a new instance in keys of this model.


<a name="datasourcesidkeyscountget"></a>
# **DataSourcesIdKeysCountGet**
> InlineResponse2001 DataSourcesIdKeysCountGet (string id, string where = null)

Counts keys of DataSource.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourcesIdKeysCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceApi();
            var id = id_example;  // string | DataSource id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts keys of DataSource.
                InlineResponse2001 result = apiInstance.DataSourcesIdKeysCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceApi.DataSourcesIdKeysCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSource id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcesidkeysdelete"></a>
# **DataSourcesIdKeysDelete**
> void DataSourcesIdKeysDelete (string id)

Deletes all keys of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourcesIdKeysDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceApi();
            var id = id_example;  // string | DataSource id

            try
            {
                // Deletes all keys of this model.
                apiInstance.DataSourcesIdKeysDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceApi.DataSourcesIdKeysDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSource id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcesidkeysfkdelete"></a>
# **DataSourcesIdKeysFkDelete**
> void DataSourcesIdKeysFkDelete (string id, string fk)

Delete a related item by id for keys.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourcesIdKeysFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceApi();
            var id = id_example;  // string | DataSource id
            var fk = fk_example;  // string | Foreign key for keys

            try
            {
                // Delete a related item by id for keys.
                apiInstance.DataSourcesIdKeysFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceApi.DataSourcesIdKeysFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSource id | 
 **fk** | **string**| Foreign key for keys | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcesidkeysfkget"></a>
# **DataSourcesIdKeysFkGet**
> DataSourceKey DataSourcesIdKeysFkGet (string id, string fk)

Find a related item by id for keys.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourcesIdKeysFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceApi();
            var id = id_example;  // string | DataSource id
            var fk = fk_example;  // string | Foreign key for keys

            try
            {
                // Find a related item by id for keys.
                DataSourceKey result = apiInstance.DataSourcesIdKeysFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceApi.DataSourcesIdKeysFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSource id | 
 **fk** | **string**| Foreign key for keys | 

### Return type

[**DataSourceKey**](DataSourceKey.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcesidkeysfkput"></a>
# **DataSourcesIdKeysFkPut**
> DataSourceKey DataSourcesIdKeysFkPut (string id, string fk, DataSourceKey data = null)

Update a related item by id for keys.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourcesIdKeysFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceApi();
            var id = id_example;  // string | DataSource id
            var fk = fk_example;  // string | Foreign key for keys
            var data = new DataSourceKey(); // DataSourceKey |  (optional) 

            try
            {
                // Update a related item by id for keys.
                DataSourceKey result = apiInstance.DataSourcesIdKeysFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceApi.DataSourcesIdKeysFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSource id | 
 **fk** | **string**| Foreign key for keys | 
 **data** | [**DataSourceKey**](DataSourceKey.md)|  | [optional] 

### Return type

[**DataSourceKey**](DataSourceKey.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcesidkeysget"></a>
# **DataSourcesIdKeysGet**
> List<DataSourceKey> DataSourcesIdKeysGet (string id, string filter = null)

Queries keys of DataSource.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourcesIdKeysGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceApi();
            var id = id_example;  // string | DataSource id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries keys of DataSource.
                List&lt;DataSourceKey&gt; result = apiInstance.DataSourcesIdKeysGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceApi.DataSourcesIdKeysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSource id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DataSourceKey>**](DataSourceKey.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datasourcesidkeyspost"></a>
# **DataSourcesIdKeysPost**
> DataSourceKey DataSourcesIdKeysPost (string id, DataSourceKey data = null)

Creates a new instance in keys of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DataSourcesIdKeysPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DataSourceApi();
            var id = id_example;  // string | DataSource id
            var data = new DataSourceKey(); // DataSourceKey |  (optional) 

            try
            {
                // Creates a new instance in keys of this model.
                DataSourceKey result = apiInstance.DataSourcesIdKeysPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourceApi.DataSourcesIdKeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DataSource id | 
 **data** | [**DataSourceKey**](DataSourceKey.md)|  | [optional] 

### Return type

[**DataSourceKey**](DataSourceKey.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

