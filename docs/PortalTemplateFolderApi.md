# TweakApi.Api.PortalTemplateFolderApi

All URIs are relative to *https://apicdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PortalTemplateFoldersChangeStreamGet**](PortalTemplateFolderApi.md#portaltemplatefolderschangestreamget) | **GET** /PortalTemplateFolders/change-stream | Create a change stream.
[**PortalTemplateFoldersChangeStreamPost**](PortalTemplateFolderApi.md#portaltemplatefolderschangestreampost) | **POST** /PortalTemplateFolders/change-stream | Create a change stream.
[**PortalTemplateFoldersCountGet**](PortalTemplateFolderApi.md#portaltemplatefolderscountget) | **GET** /PortalTemplateFolders/count | Count instances of the model matched by where from the data source.
[**PortalTemplateFoldersFindOneGet**](PortalTemplateFolderApi.md#portaltemplatefoldersfindoneget) | **GET** /PortalTemplateFolders/findOne | Find first instance of the model matched by filter from the data source.
[**PortalTemplateFoldersGet**](PortalTemplateFolderApi.md#portaltemplatefoldersget) | **GET** /PortalTemplateFolders | Find all instances of the model matched by filter from the data source.
[**PortalTemplateFoldersIdChildrenCountGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidchildrencountget) | **GET** /PortalTemplateFolders/{id}/children/count | Counts children of PortalTemplateFolder.
[**PortalTemplateFoldersIdChildrenDelete**](PortalTemplateFolderApi.md#portaltemplatefoldersidchildrendelete) | **DELETE** /PortalTemplateFolders/{id}/children | Deletes all children of this model.
[**PortalTemplateFoldersIdChildrenFkDelete**](PortalTemplateFolderApi.md#portaltemplatefoldersidchildrenfkdelete) | **DELETE** /PortalTemplateFolders/{id}/children/{fk} | Delete a related item by id for children.
[**PortalTemplateFoldersIdChildrenFkGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidchildrenfkget) | **GET** /PortalTemplateFolders/{id}/children/{fk} | Find a related item by id for children.
[**PortalTemplateFoldersIdChildrenFkPut**](PortalTemplateFolderApi.md#portaltemplatefoldersidchildrenfkput) | **PUT** /PortalTemplateFolders/{id}/children/{fk} | Update a related item by id for children.
[**PortalTemplateFoldersIdChildrenGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidchildrenget) | **GET** /PortalTemplateFolders/{id}/children | Queries children of PortalTemplateFolder.
[**PortalTemplateFoldersIdChildrenPost**](PortalTemplateFolderApi.md#portaltemplatefoldersidchildrenpost) | **POST** /PortalTemplateFolders/{id}/children | Creates a new instance in children of this model.
[**PortalTemplateFoldersIdDelete**](PortalTemplateFolderApi.md#portaltemplatefoldersiddelete) | **DELETE** /PortalTemplateFolders/{id} | Delete a model instance by {{id}} from the data source.
[**PortalTemplateFoldersIdExistsGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidexistsget) | **GET** /PortalTemplateFolders/{id}/exists | Check whether a model instance exists in the data source.
[**PortalTemplateFoldersIdGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidget) | **GET** /PortalTemplateFolders/{id} | Find a model instance by {{id}} from the data source.
[**PortalTemplateFoldersIdHead**](PortalTemplateFolderApi.md#portaltemplatefoldersidhead) | **HEAD** /PortalTemplateFolders/{id} | Check whether a model instance exists in the data source.
[**PortalTemplateFoldersIdParentGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidparentget) | **GET** /PortalTemplateFolders/{id}/parent | Fetches belongsTo relation parent.
[**PortalTemplateFoldersIdPatch**](PortalTemplateFolderApi.md#portaltemplatefoldersidpatch) | **PATCH** /PortalTemplateFolders/{id} | Patch attributes for a model instance and persist it into the data source.
[**PortalTemplateFoldersIdPortalGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidportalget) | **GET** /PortalTemplateFolders/{id}/portal | Fetches belongsTo relation portal.
[**PortalTemplateFoldersIdPut**](PortalTemplateFolderApi.md#portaltemplatefoldersidput) | **PUT** /PortalTemplateFolders/{id} | Replace attributes for a model instance and persist it into the data source.
[**PortalTemplateFoldersIdReplacePost**](PortalTemplateFolderApi.md#portaltemplatefoldersidreplacepost) | **POST** /PortalTemplateFolders/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**PortalTemplateFoldersIdTemplatesCountGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatescountget) | **GET** /PortalTemplateFolders/{id}/templates/count | Counts templates of PortalTemplateFolder.
[**PortalTemplateFoldersIdTemplatesDelete**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatesdelete) | **DELETE** /PortalTemplateFolders/{id}/templates | Deletes all templates of this model.
[**PortalTemplateFoldersIdTemplatesFkDelete**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatesfkdelete) | **DELETE** /PortalTemplateFolders/{id}/templates/{fk} | Delete a related item by id for templates.
[**PortalTemplateFoldersIdTemplatesFkGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatesfkget) | **GET** /PortalTemplateFolders/{id}/templates/{fk} | Find a related item by id for templates.
[**PortalTemplateFoldersIdTemplatesFkPut**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatesfkput) | **PUT** /PortalTemplateFolders/{id}/templates/{fk} | Update a related item by id for templates.
[**PortalTemplateFoldersIdTemplatesGet**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatesget) | **GET** /PortalTemplateFolders/{id}/templates | Queries templates of PortalTemplateFolder.
[**PortalTemplateFoldersIdTemplatesPost**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatespost) | **POST** /PortalTemplateFolders/{id}/templates | Creates a new instance in templates of this model.
[**PortalTemplateFoldersIdTemplatesRelFkDelete**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatesrelfkdelete) | **DELETE** /PortalTemplateFolders/{id}/templates/rel/{fk} | Remove the templates relation to an item by id.
[**PortalTemplateFoldersIdTemplatesRelFkHead**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatesrelfkhead) | **HEAD** /PortalTemplateFolders/{id}/templates/rel/{fk} | Check the existence of templates relation to an item by id.
[**PortalTemplateFoldersIdTemplatesRelFkPut**](PortalTemplateFolderApi.md#portaltemplatefoldersidtemplatesrelfkput) | **PUT** /PortalTemplateFolders/{id}/templates/rel/{fk} | Add a related item by id for templates.
[**PortalTemplateFoldersPatch**](PortalTemplateFolderApi.md#portaltemplatefolderspatch) | **PATCH** /PortalTemplateFolders | Patch an existing model instance or insert a new one into the data source.
[**PortalTemplateFoldersPost**](PortalTemplateFolderApi.md#portaltemplatefolderspost) | **POST** /PortalTemplateFolders | Create a new instance of the model and persist it into the data source.
[**PortalTemplateFoldersPut**](PortalTemplateFolderApi.md#portaltemplatefoldersput) | **PUT** /PortalTemplateFolders | Replace an existing model instance or insert a new one into the data source.
[**PortalTemplateFoldersReplaceOrCreatePost**](PortalTemplateFolderApi.md#portaltemplatefoldersreplaceorcreatepost) | **POST** /PortalTemplateFolders/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**PortalTemplateFoldersUpdatePost**](PortalTemplateFolderApi.md#portaltemplatefoldersupdatepost) | **POST** /PortalTemplateFolders/update | Update instances of the model matched by {{where}} from the data source.
[**PortalTemplateFoldersUpsertWithWherePost**](PortalTemplateFolderApi.md#portaltemplatefoldersupsertwithwherepost) | **POST** /PortalTemplateFolders/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="portaltemplatefolderschangestreamget"></a>
# **PortalTemplateFoldersChangeStreamGet**
> System.IO.Stream PortalTemplateFoldersChangeStreamGet (string options = null)

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
    public class PortalTemplateFoldersChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.PortalTemplateFoldersChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersChangeStreamGet: " + e.Message );
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

<a name="portaltemplatefolderschangestreampost"></a>
# **PortalTemplateFoldersChangeStreamPost**
> System.IO.Stream PortalTemplateFoldersChangeStreamPost (string options = null)

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
    public class PortalTemplateFoldersChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.PortalTemplateFoldersChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersChangeStreamPost: " + e.Message );
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

<a name="portaltemplatefolderscountget"></a>
# **PortalTemplateFoldersCountGet**
> InlineResponse2001 PortalTemplateFoldersCountGet (string where = null)

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
    public class PortalTemplateFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.PortalTemplateFoldersCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersCountGet: " + e.Message );
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

<a name="portaltemplatefoldersfindoneget"></a>
# **PortalTemplateFoldersFindOneGet**
> PortalTemplateFolder PortalTemplateFoldersFindOneGet (string filter = null)

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
    public class PortalTemplateFoldersFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersFindOneGet: " + e.Message );
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

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersget"></a>
# **PortalTemplateFoldersGet**
> List<PortalTemplateFolder> PortalTemplateFoldersGet (string filter = null)

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
    public class PortalTemplateFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;PortalTemplateFolder&gt; result = apiInstance.PortalTemplateFoldersGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersGet: " + e.Message );
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

[**List<PortalTemplateFolder>**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidchildrencountget"></a>
# **PortalTemplateFoldersIdChildrenCountGet**
> InlineResponse2001 PortalTemplateFoldersIdChildrenCountGet (string id, string where = null)

Counts children of PortalTemplateFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdChildrenCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts children of PortalTemplateFolder.
                InlineResponse2001 result = apiInstance.PortalTemplateFoldersIdChildrenCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdChildrenCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidchildrendelete"></a>
# **PortalTemplateFoldersIdChildrenDelete**
> void PortalTemplateFoldersIdChildrenDelete (string id)

Deletes all children of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdChildrenDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id

            try
            {
                // Deletes all children of this model.
                apiInstance.PortalTemplateFoldersIdChildrenDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdChildrenDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidchildrenfkdelete"></a>
# **PortalTemplateFoldersIdChildrenFkDelete**
> void PortalTemplateFoldersIdChildrenFkDelete (string id, string fk)

Delete a related item by id for children.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdChildrenFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for children

            try
            {
                // Delete a related item by id for children.
                apiInstance.PortalTemplateFoldersIdChildrenFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdChildrenFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for children | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidchildrenfkget"></a>
# **PortalTemplateFoldersIdChildrenFkGet**
> PortalTemplateFolder PortalTemplateFoldersIdChildrenFkGet (string id, string fk)

Find a related item by id for children.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdChildrenFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for children

            try
            {
                // Find a related item by id for children.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersIdChildrenFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdChildrenFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for children | 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidchildrenfkput"></a>
# **PortalTemplateFoldersIdChildrenFkPut**
> PortalTemplateFolder PortalTemplateFoldersIdChildrenFkPut (string id, string fk, PortalTemplateFolder data = null)

Update a related item by id for children.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdChildrenFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for children
            var data = new PortalTemplateFolder(); // PortalTemplateFolder |  (optional) 

            try
            {
                // Update a related item by id for children.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersIdChildrenFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdChildrenFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for children | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)|  | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidchildrenget"></a>
# **PortalTemplateFoldersIdChildrenGet**
> List<PortalTemplateFolder> PortalTemplateFoldersIdChildrenGet (string id, string filter = null)

Queries children of PortalTemplateFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdChildrenGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries children of PortalTemplateFolder.
                List&lt;PortalTemplateFolder&gt; result = apiInstance.PortalTemplateFoldersIdChildrenGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdChildrenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<PortalTemplateFolder>**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidchildrenpost"></a>
# **PortalTemplateFoldersIdChildrenPost**
> PortalTemplateFolder PortalTemplateFoldersIdChildrenPost (string id, PortalTemplateFolder data = null)

Creates a new instance in children of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdChildrenPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var data = new PortalTemplateFolder(); // PortalTemplateFolder |  (optional) 

            try
            {
                // Creates a new instance in children of this model.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersIdChildrenPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdChildrenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)|  | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersiddelete"></a>
# **PortalTemplateFoldersIdDelete**
> Object PortalTemplateFoldersIdDelete (string id)

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
    public class PortalTemplateFoldersIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.PortalTemplateFoldersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdDelete: " + e.Message );
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

<a name="portaltemplatefoldersidexistsget"></a>
# **PortalTemplateFoldersIdExistsGet**
> InlineResponse2002 PortalTemplateFoldersIdExistsGet (string id)

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
    public class PortalTemplateFoldersIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.PortalTemplateFoldersIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdExistsGet: " + e.Message );
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

<a name="portaltemplatefoldersidget"></a>
# **PortalTemplateFoldersIdGet**
> PortalTemplateFolder PortalTemplateFoldersIdGet (string id, string filter = null)

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
    public class PortalTemplateFoldersIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdGet: " + e.Message );
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

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidhead"></a>
# **PortalTemplateFoldersIdHead**
> InlineResponse2002 PortalTemplateFoldersIdHead (string id)

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
    public class PortalTemplateFoldersIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.PortalTemplateFoldersIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdHead: " + e.Message );
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

<a name="portaltemplatefoldersidparentget"></a>
# **PortalTemplateFoldersIdParentGet**
> PortalTemplateFolder PortalTemplateFoldersIdParentGet (string id, bool? refresh = null)

Fetches belongsTo relation parent.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdParentGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation parent.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersIdParentGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdParentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidpatch"></a>
# **PortalTemplateFoldersIdPatch**
> PortalTemplateFolder PortalTemplateFoldersIdPatch (string id, PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| An object of model property name/value pairs | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidportalget"></a>
# **PortalTemplateFoldersIdPortalGet**
> Portal PortalTemplateFoldersIdPortalGet (string id, bool? refresh = null)

Fetches belongsTo relation portal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdPortalGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation portal.
                Portal result = apiInstance.PortalTemplateFoldersIdPortalGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdPortalGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidput"></a>
# **PortalTemplateFoldersIdPut**
> PortalTemplateFolder PortalTemplateFoldersIdPut (string id, PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | Model id
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidreplacepost"></a>
# **PortalTemplateFoldersIdReplacePost**
> PortalTemplateFolder PortalTemplateFoldersIdReplacePost (string id, PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | Model id
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatescountget"></a>
# **PortalTemplateFoldersIdTemplatesCountGet**
> InlineResponse2001 PortalTemplateFoldersIdTemplatesCountGet (string id, string where = null)

Counts templates of PortalTemplateFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of PortalTemplateFolder.
                InlineResponse2001 result = apiInstance.PortalTemplateFoldersIdTemplatesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatesdelete"></a>
# **PortalTemplateFoldersIdTemplatesDelete**
> void PortalTemplateFoldersIdTemplatesDelete (string id)

Deletes all templates of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id

            try
            {
                // Deletes all templates of this model.
                apiInstance.PortalTemplateFoldersIdTemplatesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatesfkdelete"></a>
# **PortalTemplateFoldersIdTemplatesFkDelete**
> void PortalTemplateFoldersIdTemplatesFkDelete (string id, string fk)

Delete a related item by id for templates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.PortalTemplateFoldersIdTemplatesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatesfkget"></a>
# **PortalTemplateFoldersIdTemplatesFkGet**
> Template PortalTemplateFoldersIdTemplatesFkGet (string id, string fk)

Find a related item by id for templates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.PortalTemplateFoldersIdTemplatesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatesfkput"></a>
# **PortalTemplateFoldersIdTemplatesFkPut**
> Template PortalTemplateFoldersIdTemplatesFkPut (string id, string fk, Template data = null)

Update a related item by id for templates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.PortalTemplateFoldersIdTemplatesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for templates | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatesget"></a>
# **PortalTemplateFoldersIdTemplatesGet**
> List<Template> PortalTemplateFoldersIdTemplatesGet (string id, string filter = null)

Queries templates of PortalTemplateFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of PortalTemplateFolder.
                List&lt;Template&gt; result = apiInstance.PortalTemplateFoldersIdTemplatesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatespost"></a>
# **PortalTemplateFoldersIdTemplatesPost**
> Template PortalTemplateFoldersIdTemplatesPost (string id, Template data = null)

Creates a new instance in templates of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.PortalTemplateFoldersIdTemplatesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatesrelfkdelete"></a>
# **PortalTemplateFoldersIdTemplatesRelFkDelete**
> void PortalTemplateFoldersIdTemplatesRelFkDelete (string id, string fk)

Remove the templates relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Remove the templates relation to an item by id.
                apiInstance.PortalTemplateFoldersIdTemplatesRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatesrelfkhead"></a>
# **PortalTemplateFoldersIdTemplatesRelFkHead**
> bool? PortalTemplateFoldersIdTemplatesRelFkHead (string id, string fk)

Check the existence of templates relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Check the existence of templates relation to an item by id.
                bool? result = apiInstance.PortalTemplateFoldersIdTemplatesRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersidtemplatesrelfkput"></a>
# **PortalTemplateFoldersIdTemplatesRelFkPut**
> PortalTemplate PortalTemplateFoldersIdTemplatesRelFkPut (string id, string fk, PortalTemplate data = null)

Add a related item by id for templates.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class PortalTemplateFoldersIdTemplatesRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var id = id_example;  // string | PortalTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new PortalTemplate(); // PortalTemplate |  (optional) 

            try
            {
                // Add a related item by id for templates.
                PortalTemplate result = apiInstance.PortalTemplateFoldersIdTemplatesRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersIdTemplatesRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| PortalTemplateFolder id | 
 **fk** | **string**| Foreign key for templates | 
 **data** | [**PortalTemplate**](PortalTemplate.md)|  | [optional] 

### Return type

[**PortalTemplate**](PortalTemplate.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefolderspatch"></a>
# **PortalTemplateFoldersPatch**
> PortalTemplateFolder PortalTemplateFoldersPatch (PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefolderspost"></a>
# **PortalTemplateFoldersPost**
> PortalTemplateFolder PortalTemplateFoldersPost (PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersput"></a>
# **PortalTemplateFoldersPut**
> PortalTemplateFolder PortalTemplateFoldersPut (PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersreplaceorcreatepost"></a>
# **PortalTemplateFoldersReplaceOrCreatePost**
> PortalTemplateFolder PortalTemplateFoldersReplaceOrCreatePost (PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersupdatepost"></a>
# **PortalTemplateFoldersUpdatePost**
> InlineResponse2003 PortalTemplateFoldersUpdatePost (string where = null, PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2003 result = apiInstance.PortalTemplateFoldersUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="portaltemplatefoldersupsertwithwherepost"></a>
# **PortalTemplateFoldersUpsertWithWherePost**
> PortalTemplateFolder PortalTemplateFoldersUpsertWithWherePost (string where = null, PortalTemplateFolder data = null)

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
    public class PortalTemplateFoldersUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new PortalTemplateFolderApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new PortalTemplateFolder(); // PortalTemplateFolder | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                PortalTemplateFolder result = apiInstance.PortalTemplateFoldersUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortalTemplateFolderApi.PortalTemplateFoldersUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**PortalTemplateFolder**](PortalTemplateFolder.md)| An object of model property name/value pairs | [optional] 

### Return type

[**PortalTemplateFolder**](PortalTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

