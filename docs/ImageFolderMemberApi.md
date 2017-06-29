# TweakApi.Api.ImageFolderMemberApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ImageFolderMembersChangeStreamGet**](ImageFolderMemberApi.md#imagefoldermemberschangestreamget) | **GET** /ImageFolderMembers/change-stream | Create a change stream.
[**ImageFolderMembersChangeStreamPost**](ImageFolderMemberApi.md#imagefoldermemberschangestreampost) | **POST** /ImageFolderMembers/change-stream | Create a change stream.
[**ImageFolderMembersCountGet**](ImageFolderMemberApi.md#imagefoldermemberscountget) | **GET** /ImageFolderMembers/count | Count instances of the model matched by where from the data source.
[**ImageFolderMembersFindOneGet**](ImageFolderMemberApi.md#imagefoldermembersfindoneget) | **GET** /ImageFolderMembers/findOne | Find first instance of the model matched by filter from the data source.
[**ImageFolderMembersGet**](ImageFolderMemberApi.md#imagefoldermembersget) | **GET** /ImageFolderMembers | Find all instances of the model matched by filter from the data source.
[**ImageFolderMembersIdDelete**](ImageFolderMemberApi.md#imagefoldermembersiddelete) | **DELETE** /ImageFolderMembers/{id} | Delete a model instance by {{id}} from the data source.
[**ImageFolderMembersIdExistsGet**](ImageFolderMemberApi.md#imagefoldermembersidexistsget) | **GET** /ImageFolderMembers/{id}/exists | Check whether a model instance exists in the data source.
[**ImageFolderMembersIdFolderGet**](ImageFolderMemberApi.md#imagefoldermembersidfolderget) | **GET** /ImageFolderMembers/{id}/folder | Fetches belongsTo relation folder.
[**ImageFolderMembersIdGet**](ImageFolderMemberApi.md#imagefoldermembersidget) | **GET** /ImageFolderMembers/{id} | Find a model instance by {{id}} from the data source.
[**ImageFolderMembersIdHead**](ImageFolderMemberApi.md#imagefoldermembersidhead) | **HEAD** /ImageFolderMembers/{id} | Check whether a model instance exists in the data source.
[**ImageFolderMembersIdMemberGet**](ImageFolderMemberApi.md#imagefoldermembersidmemberget) | **GET** /ImageFolderMembers/{id}/member | Fetches belongsTo relation member.
[**ImageFolderMembersIdPatch**](ImageFolderMemberApi.md#imagefoldermembersidpatch) | **PATCH** /ImageFolderMembers/{id} | Patch attributes for a model instance and persist it into the data source.
[**ImageFolderMembersIdPut**](ImageFolderMemberApi.md#imagefoldermembersidput) | **PUT** /ImageFolderMembers/{id} | Replace attributes for a model instance and persist it into the data source.
[**ImageFolderMembersIdReplacePost**](ImageFolderMemberApi.md#imagefoldermembersidreplacepost) | **POST** /ImageFolderMembers/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**ImageFolderMembersPatch**](ImageFolderMemberApi.md#imagefoldermemberspatch) | **PATCH** /ImageFolderMembers | Patch an existing model instance or insert a new one into the data source.
[**ImageFolderMembersPost**](ImageFolderMemberApi.md#imagefoldermemberspost) | **POST** /ImageFolderMembers | Create a new instance of the model and persist it into the data source.
[**ImageFolderMembersPut**](ImageFolderMemberApi.md#imagefoldermembersput) | **PUT** /ImageFolderMembers | Replace an existing model instance or insert a new one into the data source.
[**ImageFolderMembersReplaceOrCreatePost**](ImageFolderMemberApi.md#imagefoldermembersreplaceorcreatepost) | **POST** /ImageFolderMembers/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**ImageFolderMembersUpdatePost**](ImageFolderMemberApi.md#imagefoldermembersupdatepost) | **POST** /ImageFolderMembers/update | Update instances of the model matched by {{where}} from the data source.
[**ImageFolderMembersUpsertWithWherePost**](ImageFolderMemberApi.md#imagefoldermembersupsertwithwherepost) | **POST** /ImageFolderMembers/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="imagefoldermemberschangestreamget"></a>
# **ImageFolderMembersChangeStreamGet**
> System.IO.Stream ImageFolderMembersChangeStreamGet (string options = null)

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
    public class ImageFolderMembersChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.ImageFolderMembersChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersChangeStreamGet: " + e.Message );
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

<a name="imagefoldermemberschangestreampost"></a>
# **ImageFolderMembersChangeStreamPost**
> System.IO.Stream ImageFolderMembersChangeStreamPost (string options = null)

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
    public class ImageFolderMembersChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.ImageFolderMembersChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersChangeStreamPost: " + e.Message );
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

<a name="imagefoldermemberscountget"></a>
# **ImageFolderMembersCountGet**
> InlineResponse200 ImageFolderMembersCountGet (string where = null)

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
    public class ImageFolderMembersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.ImageFolderMembersCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersCountGet: " + e.Message );
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

<a name="imagefoldermembersfindoneget"></a>
# **ImageFolderMembersFindOneGet**
> ImageFolderMember ImageFolderMembersFindOneGet (string filter = null)

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
    public class ImageFolderMembersFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersFindOneGet: " + e.Message );
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

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersget"></a>
# **ImageFolderMembersGet**
> List<ImageFolderMember> ImageFolderMembersGet (string filter = null)

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
    public class ImageFolderMembersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;ImageFolderMember&gt; result = apiInstance.ImageFolderMembersGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersGet: " + e.Message );
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

[**List<ImageFolderMember>**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersiddelete"></a>
# **ImageFolderMembersIdDelete**
> Object ImageFolderMembersIdDelete (string id)

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
    public class ImageFolderMembersIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.ImageFolderMembersIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdDelete: " + e.Message );
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

<a name="imagefoldermembersidexistsget"></a>
# **ImageFolderMembersIdExistsGet**
> InlineResponse2002 ImageFolderMembersIdExistsGet (string id)

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
    public class ImageFolderMembersIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.ImageFolderMembersIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdExistsGet: " + e.Message );
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

<a name="imagefoldermembersidfolderget"></a>
# **ImageFolderMembersIdFolderGet**
> ImageFolder ImageFolderMembersIdFolderGet (string id, bool? refresh = null)

Fetches belongsTo relation folder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImageFolderMembersIdFolderGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | ImageFolderMember id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation folder.
                ImageFolder result = apiInstance.ImageFolderMembersIdFolderGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdFolderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ImageFolderMember id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersidget"></a>
# **ImageFolderMembersIdGet**
> ImageFolderMember ImageFolderMembersIdGet (string id, string filter = null)

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
    public class ImageFolderMembersIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdGet: " + e.Message );
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

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersidhead"></a>
# **ImageFolderMembersIdHead**
> InlineResponse2002 ImageFolderMembersIdHead (string id)

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
    public class ImageFolderMembersIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.ImageFolderMembersIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdHead: " + e.Message );
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

<a name="imagefoldermembersidmemberget"></a>
# **ImageFolderMembersIdMemberGet**
> TeamMember ImageFolderMembersIdMemberGet (string id, bool? refresh = null)

Fetches belongsTo relation member.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ImageFolderMembersIdMemberGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | ImageFolderMember id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation member.
                TeamMember result = apiInstance.ImageFolderMembersIdMemberGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdMemberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ImageFolderMember id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersidpatch"></a>
# **ImageFolderMembersIdPatch**
> ImageFolderMember ImageFolderMembersIdPatch (string id, ImageFolderMember data = null)

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
    public class ImageFolderMembersIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | ImageFolderMember id
            var data = new ImageFolderMember(); // ImageFolderMember | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ImageFolderMember id | 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| An object of model property name/value pairs | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersidput"></a>
# **ImageFolderMembersIdPut**
> ImageFolderMember ImageFolderMembersIdPut (string id, ImageFolderMember data = null)

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
    public class ImageFolderMembersIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | Model id
            var data = new ImageFolderMember(); // ImageFolderMember | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| Model instance data | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersidreplacepost"></a>
# **ImageFolderMembersIdReplacePost**
> ImageFolderMember ImageFolderMembersIdReplacePost (string id, ImageFolderMember data = null)

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
    public class ImageFolderMembersIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var id = id_example;  // string | Model id
            var data = new ImageFolderMember(); // ImageFolderMember | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| Model instance data | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermemberspatch"></a>
# **ImageFolderMembersPatch**
> ImageFolderMember ImageFolderMembersPatch (ImageFolderMember data = null)

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
    public class ImageFolderMembersPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var data = new ImageFolderMember(); // ImageFolderMember | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| Model instance data | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermemberspost"></a>
# **ImageFolderMembersPost**
> ImageFolderMember ImageFolderMembersPost (ImageFolderMember data = null)

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
    public class ImageFolderMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var data = new ImageFolderMember(); // ImageFolderMember | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| Model instance data | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersput"></a>
# **ImageFolderMembersPut**
> ImageFolderMember ImageFolderMembersPut (ImageFolderMember data = null)

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
    public class ImageFolderMembersPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var data = new ImageFolderMember(); // ImageFolderMember | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| Model instance data | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersreplaceorcreatepost"></a>
# **ImageFolderMembersReplaceOrCreatePost**
> ImageFolderMember ImageFolderMembersReplaceOrCreatePost (ImageFolderMember data = null)

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
    public class ImageFolderMembersReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var data = new ImageFolderMember(); // ImageFolderMember | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                ImageFolderMember result = apiInstance.ImageFolderMembersReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| Model instance data | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersupdatepost"></a>
# **ImageFolderMembersUpdatePost**
> InlineResponse2001 ImageFolderMembersUpdatePost (string where = null, ImageFolderMember data = null)

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
    public class ImageFolderMembersUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new ImageFolderMember(); // ImageFolderMember | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2001 result = apiInstance.ImageFolderMembersUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imagefoldermembersupsertwithwherepost"></a>
# **ImageFolderMembersUpsertWithWherePost**
> ImageFolderMember ImageFolderMembersUpsertWithWherePost (string where = null, ImageFolderMember data = null)

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
    public class ImageFolderMembersUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ImageFolderMemberApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new ImageFolderMember(); // ImageFolderMember | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                ImageFolderMember result = apiInstance.ImageFolderMembersUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImageFolderMemberApi.ImageFolderMembersUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**ImageFolderMember**](ImageFolderMember.md)| An object of model property name/value pairs | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

