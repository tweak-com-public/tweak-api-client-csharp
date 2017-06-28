# TweakApi.Api.DesignCommentApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DesignCommentsChangeStreamGet**](DesignCommentApi.md#designcommentschangestreamget) | **GET** /DesignComments/change-stream | Create a change stream.
[**DesignCommentsChangeStreamPost**](DesignCommentApi.md#designcommentschangestreampost) | **POST** /DesignComments/change-stream | Create a change stream.
[**DesignCommentsCountGet**](DesignCommentApi.md#designcommentscountget) | **GET** /DesignComments/count | Count instances of the model matched by where from the data source.
[**DesignCommentsFindOneGet**](DesignCommentApi.md#designcommentsfindoneget) | **GET** /DesignComments/findOne | Find first instance of the model matched by filter from the data source.
[**DesignCommentsGet**](DesignCommentApi.md#designcommentsget) | **GET** /DesignComments | Find all instances of the model matched by filter from the data source.
[**DesignCommentsIdCommenterGet**](DesignCommentApi.md#designcommentsidcommenterget) | **GET** /DesignComments/{id}/commenter | Fetches belongsTo relation commenter.
[**DesignCommentsIdDelete**](DesignCommentApi.md#designcommentsiddelete) | **DELETE** /DesignComments/{id} | Delete a model instance by {{id}} from the data source.
[**DesignCommentsIdDesignGet**](DesignCommentApi.md#designcommentsiddesignget) | **GET** /DesignComments/{id}/design | Fetches belongsTo relation design.
[**DesignCommentsIdExistsGet**](DesignCommentApi.md#designcommentsidexistsget) | **GET** /DesignComments/{id}/exists | Check whether a model instance exists in the data source.
[**DesignCommentsIdGet**](DesignCommentApi.md#designcommentsidget) | **GET** /DesignComments/{id} | Find a model instance by {{id}} from the data source.
[**DesignCommentsIdHead**](DesignCommentApi.md#designcommentsidhead) | **HEAD** /DesignComments/{id} | Check whether a model instance exists in the data source.
[**DesignCommentsIdPatch**](DesignCommentApi.md#designcommentsidpatch) | **PATCH** /DesignComments/{id} | Patch attributes for a model instance and persist it into the data source.
[**DesignCommentsIdPut**](DesignCommentApi.md#designcommentsidput) | **PUT** /DesignComments/{id} | Replace attributes for a model instance and persist it into the data source.
[**DesignCommentsIdReplacePost**](DesignCommentApi.md#designcommentsidreplacepost) | **POST** /DesignComments/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DesignCommentsIdRepliesCountGet**](DesignCommentApi.md#designcommentsidrepliescountget) | **GET** /DesignComments/{id}/replies/count | Counts replies of DesignComment.
[**DesignCommentsIdRepliesDelete**](DesignCommentApi.md#designcommentsidrepliesdelete) | **DELETE** /DesignComments/{id}/replies | Deletes all replies of this model.
[**DesignCommentsIdRepliesFkDelete**](DesignCommentApi.md#designcommentsidrepliesfkdelete) | **DELETE** /DesignComments/{id}/replies/{fk} | Delete a related item by id for replies.
[**DesignCommentsIdRepliesFkGet**](DesignCommentApi.md#designcommentsidrepliesfkget) | **GET** /DesignComments/{id}/replies/{fk} | Find a related item by id for replies.
[**DesignCommentsIdRepliesFkPut**](DesignCommentApi.md#designcommentsidrepliesfkput) | **PUT** /DesignComments/{id}/replies/{fk} | Update a related item by id for replies.
[**DesignCommentsIdRepliesGet**](DesignCommentApi.md#designcommentsidrepliesget) | **GET** /DesignComments/{id}/replies | Queries replies of DesignComment.
[**DesignCommentsIdRepliesPost**](DesignCommentApi.md#designcommentsidrepliespost) | **POST** /DesignComments/{id}/replies | Creates a new instance in replies of this model.
[**DesignCommentsIdReplyOfGet**](DesignCommentApi.md#designcommentsidreplyofget) | **GET** /DesignComments/{id}/replyOf | Fetches belongsTo relation replyOf.
[**DesignCommentsPatch**](DesignCommentApi.md#designcommentspatch) | **PATCH** /DesignComments | Patch an existing model instance or insert a new one into the data source.
[**DesignCommentsPost**](DesignCommentApi.md#designcommentspost) | **POST** /DesignComments | Create a new instance of the model and persist it into the data source.
[**DesignCommentsPut**](DesignCommentApi.md#designcommentsput) | **PUT** /DesignComments | Replace an existing model instance or insert a new one into the data source.
[**DesignCommentsReplaceOrCreatePost**](DesignCommentApi.md#designcommentsreplaceorcreatepost) | **POST** /DesignComments/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**DesignCommentsUpdatePost**](DesignCommentApi.md#designcommentsupdatepost) | **POST** /DesignComments/update | Update instances of the model matched by {{where}} from the data source.
[**DesignCommentsUpsertWithWherePost**](DesignCommentApi.md#designcommentsupsertwithwherepost) | **POST** /DesignComments/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="designcommentschangestreamget"></a>
# **DesignCommentsChangeStreamGet**
> System.IO.Stream DesignCommentsChangeStreamGet (string options = null)

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
    public class DesignCommentsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DesignCommentsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsChangeStreamGet: " + e.Message );
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

<a name="designcommentschangestreampost"></a>
# **DesignCommentsChangeStreamPost**
> System.IO.Stream DesignCommentsChangeStreamPost (string options = null)

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
    public class DesignCommentsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DesignCommentsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsChangeStreamPost: " + e.Message );
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

<a name="designcommentscountget"></a>
# **DesignCommentsCountGet**
> InlineResponse200 DesignCommentsCountGet (string where = null)

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
    public class DesignCommentsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.DesignCommentsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsCountGet: " + e.Message );
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

<a name="designcommentsfindoneget"></a>
# **DesignCommentsFindOneGet**
> DesignComment DesignCommentsFindOneGet (string filter = null)

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
    public class DesignCommentsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                DesignComment result = apiInstance.DesignCommentsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsFindOneGet: " + e.Message );
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

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsget"></a>
# **DesignCommentsGet**
> List<DesignComment> DesignCommentsGet (string filter = null)

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
    public class DesignCommentsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;DesignComment&gt; result = apiInstance.DesignCommentsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsGet: " + e.Message );
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

[**List<DesignComment>**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidcommenterget"></a>
# **DesignCommentsIdCommenterGet**
> TeamMember DesignCommentsIdCommenterGet (string id, bool? refresh = null)

Fetches belongsTo relation commenter.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdCommenterGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation commenter.
                TeamMember result = apiInstance.DesignCommentsIdCommenterGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdCommenterGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsiddelete"></a>
# **DesignCommentsIdDelete**
> Object DesignCommentsIdDelete (string id)

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
    public class DesignCommentsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DesignCommentsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdDelete: " + e.Message );
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

<a name="designcommentsiddesignget"></a>
# **DesignCommentsIdDesignGet**
> Design DesignCommentsIdDesignGet (string id, bool? refresh = null)

Fetches belongsTo relation design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdDesignGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation design.
                Design result = apiInstance.DesignCommentsIdDesignGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdDesignGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidexistsget"></a>
# **DesignCommentsIdExistsGet**
> InlineResponse2002 DesignCommentsIdExistsGet (string id)

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
    public class DesignCommentsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DesignCommentsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdExistsGet: " + e.Message );
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

<a name="designcommentsidget"></a>
# **DesignCommentsIdGet**
> DesignComment DesignCommentsIdGet (string id, string filter = null)

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
    public class DesignCommentsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                DesignComment result = apiInstance.DesignCommentsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdGet: " + e.Message );
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

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidhead"></a>
# **DesignCommentsIdHead**
> InlineResponse2002 DesignCommentsIdHead (string id)

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
    public class DesignCommentsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.DesignCommentsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdHead: " + e.Message );
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

<a name="designcommentsidpatch"></a>
# **DesignCommentsIdPatch**
> DesignComment DesignCommentsIdPatch (string id, DesignComment data = null)

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
    public class DesignCommentsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var data = new DesignComment(); // DesignComment | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                DesignComment result = apiInstance.DesignCommentsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **data** | [**DesignComment**](DesignComment.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidput"></a>
# **DesignCommentsIdPut**
> DesignComment DesignCommentsIdPut (string id, DesignComment data = null)

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
    public class DesignCommentsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | Model id
            var data = new DesignComment(); // DesignComment | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DesignComment result = apiInstance.DesignCommentsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DesignComment**](DesignComment.md)| Model instance data | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidreplacepost"></a>
# **DesignCommentsIdReplacePost**
> DesignComment DesignCommentsIdReplacePost (string id, DesignComment data = null)

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
    public class DesignCommentsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | Model id
            var data = new DesignComment(); // DesignComment | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                DesignComment result = apiInstance.DesignCommentsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**DesignComment**](DesignComment.md)| Model instance data | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidrepliescountget"></a>
# **DesignCommentsIdRepliesCountGet**
> InlineResponse200 DesignCommentsIdRepliesCountGet (string id, string where = null)

Counts replies of DesignComment.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdRepliesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts replies of DesignComment.
                InlineResponse200 result = apiInstance.DesignCommentsIdRepliesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdRepliesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidrepliesdelete"></a>
# **DesignCommentsIdRepliesDelete**
> void DesignCommentsIdRepliesDelete (string id)

Deletes all replies of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdRepliesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id

            try
            {
                // Deletes all replies of this model.
                apiInstance.DesignCommentsIdRepliesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdRepliesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidrepliesfkdelete"></a>
# **DesignCommentsIdRepliesFkDelete**
> void DesignCommentsIdRepliesFkDelete (string id, string fk)

Delete a related item by id for replies.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdRepliesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var fk = fk_example;  // string | Foreign key for replies

            try
            {
                // Delete a related item by id for replies.
                apiInstance.DesignCommentsIdRepliesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdRepliesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **fk** | **string**| Foreign key for replies | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidrepliesfkget"></a>
# **DesignCommentsIdRepliesFkGet**
> DesignComment DesignCommentsIdRepliesFkGet (string id, string fk)

Find a related item by id for replies.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdRepliesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var fk = fk_example;  // string | Foreign key for replies

            try
            {
                // Find a related item by id for replies.
                DesignComment result = apiInstance.DesignCommentsIdRepliesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdRepliesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **fk** | **string**| Foreign key for replies | 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidrepliesfkput"></a>
# **DesignCommentsIdRepliesFkPut**
> DesignComment DesignCommentsIdRepliesFkPut (string id, string fk, DesignComment data = null)

Update a related item by id for replies.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdRepliesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var fk = fk_example;  // string | Foreign key for replies
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Update a related item by id for replies.
                DesignComment result = apiInstance.DesignCommentsIdRepliesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdRepliesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **fk** | **string**| Foreign key for replies | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidrepliesget"></a>
# **DesignCommentsIdRepliesGet**
> List<DesignComment> DesignCommentsIdRepliesGet (string id, string filter = null)

Queries replies of DesignComment.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdRepliesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries replies of DesignComment.
                List&lt;DesignComment&gt; result = apiInstance.DesignCommentsIdRepliesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdRepliesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignComment>**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidrepliespost"></a>
# **DesignCommentsIdRepliesPost**
> DesignComment DesignCommentsIdRepliesPost (string id, DesignComment data = null)

Creates a new instance in replies of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdRepliesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Creates a new instance in replies of this model.
                DesignComment result = apiInstance.DesignCommentsIdRepliesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdRepliesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsidreplyofget"></a>
# **DesignCommentsIdReplyOfGet**
> DesignComment DesignCommentsIdReplyOfGet (string id, bool? refresh = null)

Fetches belongsTo relation replyOf.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignCommentsIdReplyOfGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var id = id_example;  // string | DesignComment id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation replyOf.
                DesignComment result = apiInstance.DesignCommentsIdReplyOfGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsIdReplyOfGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| DesignComment id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentspatch"></a>
# **DesignCommentsPatch**
> DesignComment DesignCommentsPatch (DesignComment data = null)

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
    public class DesignCommentsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var data = new DesignComment(); // DesignComment | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                DesignComment result = apiInstance.DesignCommentsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignComment**](DesignComment.md)| Model instance data | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentspost"></a>
# **DesignCommentsPost**
> DesignComment DesignCommentsPost (DesignComment data = null)

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
    public class DesignCommentsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var data = new DesignComment(); // DesignComment | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                DesignComment result = apiInstance.DesignCommentsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignComment**](DesignComment.md)| Model instance data | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsput"></a>
# **DesignCommentsPut**
> DesignComment DesignCommentsPut (DesignComment data = null)

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
    public class DesignCommentsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var data = new DesignComment(); // DesignComment | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DesignComment result = apiInstance.DesignCommentsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignComment**](DesignComment.md)| Model instance data | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsreplaceorcreatepost"></a>
# **DesignCommentsReplaceOrCreatePost**
> DesignComment DesignCommentsReplaceOrCreatePost (DesignComment data = null)

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
    public class DesignCommentsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var data = new DesignComment(); // DesignComment | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                DesignComment result = apiInstance.DesignCommentsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DesignComment**](DesignComment.md)| Model instance data | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsupdatepost"></a>
# **DesignCommentsUpdatePost**
> InlineResponse2001 DesignCommentsUpdatePost (string where = null, DesignComment data = null)

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
    public class DesignCommentsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DesignComment(); // DesignComment | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2001 result = apiInstance.DesignCommentsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DesignComment**](DesignComment.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designcommentsupsertwithwherepost"></a>
# **DesignCommentsUpsertWithWherePost**
> DesignComment DesignCommentsUpsertWithWherePost (string where = null, DesignComment data = null)

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
    public class DesignCommentsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignCommentApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new DesignComment(); // DesignComment | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                DesignComment result = apiInstance.DesignCommentsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignCommentApi.DesignCommentsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**DesignComment**](DesignComment.md)| An object of model property name/value pairs | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

