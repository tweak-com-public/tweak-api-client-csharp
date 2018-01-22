# TweakApi.Api.TeamTemplateFolderApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamTemplateFoldersChangeStreamGet**](TeamTemplateFolderApi.md#teamtemplatefolderschangestreamget) | **GET** /TeamTemplateFolders/change-stream | Create a change stream.
[**TeamTemplateFoldersChangeStreamPost**](TeamTemplateFolderApi.md#teamtemplatefolderschangestreampost) | **POST** /TeamTemplateFolders/change-stream | Create a change stream.
[**TeamTemplateFoldersCountGet**](TeamTemplateFolderApi.md#teamtemplatefolderscountget) | **GET** /TeamTemplateFolders/count | Count instances of the model matched by where from the data source.
[**TeamTemplateFoldersFindOneGet**](TeamTemplateFolderApi.md#teamtemplatefoldersfindoneget) | **GET** /TeamTemplateFolders/findOne | Find first instance of the model matched by filter from the data source.
[**TeamTemplateFoldersGet**](TeamTemplateFolderApi.md#teamtemplatefoldersget) | **GET** /TeamTemplateFolders | Find all instances of the model matched by filter from the data source.
[**TeamTemplateFoldersIdChildrenCountGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidchildrencountget) | **GET** /TeamTemplateFolders/{id}/children/count | Counts children of TeamTemplateFolder.
[**TeamTemplateFoldersIdChildrenDelete**](TeamTemplateFolderApi.md#teamtemplatefoldersidchildrendelete) | **DELETE** /TeamTemplateFolders/{id}/children | Deletes all children of this model.
[**TeamTemplateFoldersIdChildrenFkDelete**](TeamTemplateFolderApi.md#teamtemplatefoldersidchildrenfkdelete) | **DELETE** /TeamTemplateFolders/{id}/children/{fk} | Delete a related item by id for children.
[**TeamTemplateFoldersIdChildrenFkGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidchildrenfkget) | **GET** /TeamTemplateFolders/{id}/children/{fk} | Find a related item by id for children.
[**TeamTemplateFoldersIdChildrenFkPut**](TeamTemplateFolderApi.md#teamtemplatefoldersidchildrenfkput) | **PUT** /TeamTemplateFolders/{id}/children/{fk} | Update a related item by id for children.
[**TeamTemplateFoldersIdChildrenGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidchildrenget) | **GET** /TeamTemplateFolders/{id}/children | Queries children of TeamTemplateFolder.
[**TeamTemplateFoldersIdChildrenPost**](TeamTemplateFolderApi.md#teamtemplatefoldersidchildrenpost) | **POST** /TeamTemplateFolders/{id}/children | Creates a new instance in children of this model.
[**TeamTemplateFoldersIdDelete**](TeamTemplateFolderApi.md#teamtemplatefoldersiddelete) | **DELETE** /TeamTemplateFolders/{id} | Delete a model instance by {{id}} from the data source.
[**TeamTemplateFoldersIdExistsGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidexistsget) | **GET** /TeamTemplateFolders/{id}/exists | Check whether a model instance exists in the data source.
[**TeamTemplateFoldersIdGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidget) | **GET** /TeamTemplateFolders/{id} | Find a model instance by {{id}} from the data source.
[**TeamTemplateFoldersIdHead**](TeamTemplateFolderApi.md#teamtemplatefoldersidhead) | **HEAD** /TeamTemplateFolders/{id} | Check whether a model instance exists in the data source.
[**TeamTemplateFoldersIdParentGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidparentget) | **GET** /TeamTemplateFolders/{id}/parent | Fetches belongsTo relation parent.
[**TeamTemplateFoldersIdPatch**](TeamTemplateFolderApi.md#teamtemplatefoldersidpatch) | **PATCH** /TeamTemplateFolders/{id} | Patch attributes for a model instance and persist it into the data source.
[**TeamTemplateFoldersIdPut**](TeamTemplateFolderApi.md#teamtemplatefoldersidput) | **PUT** /TeamTemplateFolders/{id} | Replace attributes for a model instance and persist it into the data source.
[**TeamTemplateFoldersIdReplacePost**](TeamTemplateFolderApi.md#teamtemplatefoldersidreplacepost) | **POST** /TeamTemplateFolders/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TeamTemplateFoldersIdTeamGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidteamget) | **GET** /TeamTemplateFolders/{id}/team | Fetches belongsTo relation team.
[**TeamTemplateFoldersIdTemplatesCountGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidtemplatescountget) | **GET** /TeamTemplateFolders/{id}/templates/count | Counts templates of TeamTemplateFolder.
[**TeamTemplateFoldersIdTemplatesDelete**](TeamTemplateFolderApi.md#teamtemplatefoldersidtemplatesdelete) | **DELETE** /TeamTemplateFolders/{id}/templates | Deletes all templates of this model.
[**TeamTemplateFoldersIdTemplatesFkDelete**](TeamTemplateFolderApi.md#teamtemplatefoldersidtemplatesfkdelete) | **DELETE** /TeamTemplateFolders/{id}/templates/{fk} | Delete a related item by id for templates.
[**TeamTemplateFoldersIdTemplatesFkGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidtemplatesfkget) | **GET** /TeamTemplateFolders/{id}/templates/{fk} | Find a related item by id for templates.
[**TeamTemplateFoldersIdTemplatesFkPut**](TeamTemplateFolderApi.md#teamtemplatefoldersidtemplatesfkput) | **PUT** /TeamTemplateFolders/{id}/templates/{fk} | Update a related item by id for templates.
[**TeamTemplateFoldersIdTemplatesGet**](TeamTemplateFolderApi.md#teamtemplatefoldersidtemplatesget) | **GET** /TeamTemplateFolders/{id}/templates | Queries templates of TeamTemplateFolder.
[**TeamTemplateFoldersIdTemplatesPost**](TeamTemplateFolderApi.md#teamtemplatefoldersidtemplatespost) | **POST** /TeamTemplateFolders/{id}/templates | Creates a new instance in templates of this model.
[**TeamTemplateFoldersPatch**](TeamTemplateFolderApi.md#teamtemplatefolderspatch) | **PATCH** /TeamTemplateFolders | Patch an existing model instance or insert a new one into the data source.
[**TeamTemplateFoldersPost**](TeamTemplateFolderApi.md#teamtemplatefolderspost) | **POST** /TeamTemplateFolders | Create a new instance of the model and persist it into the data source.
[**TeamTemplateFoldersPut**](TeamTemplateFolderApi.md#teamtemplatefoldersput) | **PUT** /TeamTemplateFolders | Replace an existing model instance or insert a new one into the data source.
[**TeamTemplateFoldersReplaceOrCreatePost**](TeamTemplateFolderApi.md#teamtemplatefoldersreplaceorcreatepost) | **POST** /TeamTemplateFolders/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TeamTemplateFoldersUpdatePost**](TeamTemplateFolderApi.md#teamtemplatefoldersupdatepost) | **POST** /TeamTemplateFolders/update | Update instances of the model matched by {{where}} from the data source.
[**TeamTemplateFoldersUpsertWithWherePost**](TeamTemplateFolderApi.md#teamtemplatefoldersupsertwithwherepost) | **POST** /TeamTemplateFolders/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="teamtemplatefolderschangestreamget"></a>
# **TeamTemplateFoldersChangeStreamGet**
> System.IO.Stream TeamTemplateFoldersChangeStreamGet (string options = null)

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
    public class TeamTemplateFoldersChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamTemplateFoldersChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersChangeStreamGet: " + e.Message );
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

<a name="teamtemplatefolderschangestreampost"></a>
# **TeamTemplateFoldersChangeStreamPost**
> System.IO.Stream TeamTemplateFoldersChangeStreamPost (string options = null)

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
    public class TeamTemplateFoldersChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TeamTemplateFoldersChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersChangeStreamPost: " + e.Message );
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

<a name="teamtemplatefolderscountget"></a>
# **TeamTemplateFoldersCountGet**
> InlineResponse2001 TeamTemplateFoldersCountGet (string where = null)

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
    public class TeamTemplateFoldersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.TeamTemplateFoldersCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersCountGet: " + e.Message );
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

<a name="teamtemplatefoldersfindoneget"></a>
# **TeamTemplateFoldersFindOneGet**
> TeamTemplateFolder TeamTemplateFoldersFindOneGet (string filter = null)

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
    public class TeamTemplateFoldersFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersFindOneGet: " + e.Message );
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

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersget"></a>
# **TeamTemplateFoldersGet**
> List<TeamTemplateFolder> TeamTemplateFoldersGet (string filter = null)

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
    public class TeamTemplateFoldersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;TeamTemplateFolder&gt; result = apiInstance.TeamTemplateFoldersGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersGet: " + e.Message );
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

[**List<TeamTemplateFolder>**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidchildrencountget"></a>
# **TeamTemplateFoldersIdChildrenCountGet**
> InlineResponse2001 TeamTemplateFoldersIdChildrenCountGet (string id, string where = null)

Counts children of TeamTemplateFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamTemplateFoldersIdChildrenCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts children of TeamTemplateFolder.
                InlineResponse2001 result = apiInstance.TeamTemplateFoldersIdChildrenCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdChildrenCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidchildrendelete"></a>
# **TeamTemplateFoldersIdChildrenDelete**
> void TeamTemplateFoldersIdChildrenDelete (string id)

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
    public class TeamTemplateFoldersIdChildrenDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id

            try
            {
                // Deletes all children of this model.
                apiInstance.TeamTemplateFoldersIdChildrenDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdChildrenDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidchildrenfkdelete"></a>
# **TeamTemplateFoldersIdChildrenFkDelete**
> void TeamTemplateFoldersIdChildrenFkDelete (string id, string fk)

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
    public class TeamTemplateFoldersIdChildrenFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var fk = fk_example;  // string | Foreign key for children

            try
            {
                // Delete a related item by id for children.
                apiInstance.TeamTemplateFoldersIdChildrenFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdChildrenFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **fk** | **string**| Foreign key for children | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidchildrenfkget"></a>
# **TeamTemplateFoldersIdChildrenFkGet**
> TeamTemplateFolder TeamTemplateFoldersIdChildrenFkGet (string id, string fk)

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
    public class TeamTemplateFoldersIdChildrenFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var fk = fk_example;  // string | Foreign key for children

            try
            {
                // Find a related item by id for children.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersIdChildrenFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdChildrenFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **fk** | **string**| Foreign key for children | 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidchildrenfkput"></a>
# **TeamTemplateFoldersIdChildrenFkPut**
> TeamTemplateFolder TeamTemplateFoldersIdChildrenFkPut (string id, string fk, TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersIdChildrenFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var fk = fk_example;  // string | Foreign key for children
            var data = new TeamTemplateFolder(); // TeamTemplateFolder |  (optional) 

            try
            {
                // Update a related item by id for children.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersIdChildrenFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdChildrenFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **fk** | **string**| Foreign key for children | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)|  | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidchildrenget"></a>
# **TeamTemplateFoldersIdChildrenGet**
> List<TeamTemplateFolder> TeamTemplateFoldersIdChildrenGet (string id, string filter = null)

Queries children of TeamTemplateFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamTemplateFoldersIdChildrenGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries children of TeamTemplateFolder.
                List&lt;TeamTemplateFolder&gt; result = apiInstance.TeamTemplateFoldersIdChildrenGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdChildrenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamTemplateFolder>**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidchildrenpost"></a>
# **TeamTemplateFoldersIdChildrenPost**
> TeamTemplateFolder TeamTemplateFoldersIdChildrenPost (string id, TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersIdChildrenPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var data = new TeamTemplateFolder(); // TeamTemplateFolder |  (optional) 

            try
            {
                // Creates a new instance in children of this model.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersIdChildrenPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdChildrenPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)|  | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersiddelete"></a>
# **TeamTemplateFoldersIdDelete**
> Object TeamTemplateFoldersIdDelete (string id)

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
    public class TeamTemplateFoldersIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TeamTemplateFoldersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdDelete: " + e.Message );
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

<a name="teamtemplatefoldersidexistsget"></a>
# **TeamTemplateFoldersIdExistsGet**
> InlineResponse2002 TeamTemplateFoldersIdExistsGet (string id)

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
    public class TeamTemplateFoldersIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamTemplateFoldersIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdExistsGet: " + e.Message );
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

<a name="teamtemplatefoldersidget"></a>
# **TeamTemplateFoldersIdGet**
> TeamTemplateFolder TeamTemplateFoldersIdGet (string id, string filter = null)

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
    public class TeamTemplateFoldersIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdGet: " + e.Message );
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

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidhead"></a>
# **TeamTemplateFoldersIdHead**
> InlineResponse2002 TeamTemplateFoldersIdHead (string id)

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
    public class TeamTemplateFoldersIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TeamTemplateFoldersIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdHead: " + e.Message );
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

<a name="teamtemplatefoldersidparentget"></a>
# **TeamTemplateFoldersIdParentGet**
> TeamTemplateFolder TeamTemplateFoldersIdParentGet (string id, bool? refresh = null)

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
    public class TeamTemplateFoldersIdParentGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation parent.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersIdParentGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdParentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidpatch"></a>
# **TeamTemplateFoldersIdPatch**
> TeamTemplateFolder TeamTemplateFoldersIdPatch (string id, TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidput"></a>
# **TeamTemplateFoldersIdPut**
> TeamTemplateFolder TeamTemplateFoldersIdPut (string id, TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | Model id
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidreplacepost"></a>
# **TeamTemplateFoldersIdReplacePost**
> TeamTemplateFolder TeamTemplateFoldersIdReplacePost (string id, TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | Model id
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidteamget"></a>
# **TeamTemplateFoldersIdTeamGet**
> Team TeamTemplateFoldersIdTeamGet (string id, bool? refresh = null)

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
    public class TeamTemplateFoldersIdTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation team.
                Team result = apiInstance.TeamTemplateFoldersIdTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidtemplatescountget"></a>
# **TeamTemplateFoldersIdTemplatesCountGet**
> InlineResponse2001 TeamTemplateFoldersIdTemplatesCountGet (string id, string where = null)

Counts templates of TeamTemplateFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamTemplateFoldersIdTemplatesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of TeamTemplateFolder.
                InlineResponse2001 result = apiInstance.TeamTemplateFoldersIdTemplatesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidtemplatesdelete"></a>
# **TeamTemplateFoldersIdTemplatesDelete**
> void TeamTemplateFoldersIdTemplatesDelete (string id)

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
    public class TeamTemplateFoldersIdTemplatesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id

            try
            {
                // Deletes all templates of this model.
                apiInstance.TeamTemplateFoldersIdTemplatesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidtemplatesfkdelete"></a>
# **TeamTemplateFoldersIdTemplatesFkDelete**
> void TeamTemplateFoldersIdTemplatesFkDelete (string id, string fk)

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
    public class TeamTemplateFoldersIdTemplatesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.TeamTemplateFoldersIdTemplatesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidtemplatesfkget"></a>
# **TeamTemplateFoldersIdTemplatesFkGet**
> Template TeamTemplateFoldersIdTemplatesFkGet (string id, string fk)

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
    public class TeamTemplateFoldersIdTemplatesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.TeamTemplateFoldersIdTemplatesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidtemplatesfkput"></a>
# **TeamTemplateFoldersIdTemplatesFkPut**
> Template TeamTemplateFoldersIdTemplatesFkPut (string id, string fk, Template data = null)

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
    public class TeamTemplateFoldersIdTemplatesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.TeamTemplateFoldersIdTemplatesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
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

<a name="teamtemplatefoldersidtemplatesget"></a>
# **TeamTemplateFoldersIdTemplatesGet**
> List<Template> TeamTemplateFoldersIdTemplatesGet (string id, string filter = null)

Queries templates of TeamTemplateFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TeamTemplateFoldersIdTemplatesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of TeamTemplateFolder.
                List&lt;Template&gt; result = apiInstance.TeamTemplateFoldersIdTemplatesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersidtemplatespost"></a>
# **TeamTemplateFoldersIdTemplatesPost**
> Template TeamTemplateFoldersIdTemplatesPost (string id, Template data = null)

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
    public class TeamTemplateFoldersIdTemplatesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var id = id_example;  // string | TeamTemplateFolder id
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.TeamTemplateFoldersIdTemplatesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersIdTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamTemplateFolder id | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefolderspatch"></a>
# **TeamTemplateFoldersPatch**
> TeamTemplateFolder TeamTemplateFoldersPatch (TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefolderspost"></a>
# **TeamTemplateFoldersPost**
> TeamTemplateFolder TeamTemplateFoldersPost (TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersput"></a>
# **TeamTemplateFoldersPut**
> TeamTemplateFolder TeamTemplateFoldersPut (TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersreplaceorcreatepost"></a>
# **TeamTemplateFoldersReplaceOrCreatePost**
> TeamTemplateFolder TeamTemplateFoldersReplaceOrCreatePost (TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| Model instance data | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersupdatepost"></a>
# **TeamTemplateFoldersUpdatePost**
> InlineResponse2003 TeamTemplateFoldersUpdatePost (string where = null, TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2003 result = apiInstance.TeamTemplateFoldersUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamtemplatefoldersupsertwithwherepost"></a>
# **TeamTemplateFoldersUpsertWithWherePost**
> TeamTemplateFolder TeamTemplateFoldersUpsertWithWherePost (string where = null, TeamTemplateFolder data = null)

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
    public class TeamTemplateFoldersUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new TeamTemplateFolderApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new TeamTemplateFolder(); // TeamTemplateFolder | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                TeamTemplateFolder result = apiInstance.TeamTemplateFoldersUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamTemplateFolderApi.TeamTemplateFoldersUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**TeamTemplateFolder**](TeamTemplateFolder.md)| An object of model property name/value pairs | [optional] 

### Return type

[**TeamTemplateFolder**](TeamTemplateFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

