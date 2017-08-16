# TweakApi.Api.DesignApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DesignsChangeStreamGet**](DesignApi.md#designschangestreamget) | **GET** /Designs/change-stream | Create a change stream.
[**DesignsChangeStreamPost**](DesignApi.md#designschangestreampost) | **POST** /Designs/change-stream | Create a change stream.
[**DesignsCountGet**](DesignApi.md#designscountget) | **GET** /Designs/count | Count instances of the model matched by where from the data source.
[**DesignsFindOneGet**](DesignApi.md#designsfindoneget) | **GET** /Designs/findOne | Find first instance of the model matched by filter from the data source.
[**DesignsGet**](DesignApi.md#designsget) | **GET** /Designs | Find all instances of the model matched by filter from the data source.
[**DesignsIdApprovePost**](DesignApi.md#designsidapprovepost) | **POST** /Designs/{id}/approve | Approve design
[**DesignsIdAssigneeGet**](DesignApi.md#designsidassigneeget) | **GET** /Designs/{id}/assignee | Fetches belongsTo relation assignee.
[**DesignsIdCommentersCountGet**](DesignApi.md#designsidcommenterscountget) | **GET** /Designs/{id}/commenters/count | Counts commenters of Design.
[**DesignsIdCommentersDelete**](DesignApi.md#designsidcommentersdelete) | **DELETE** /Designs/{id}/commenters | Deletes all commenters of this model.
[**DesignsIdCommentersFkDelete**](DesignApi.md#designsidcommentersfkdelete) | **DELETE** /Designs/{id}/commenters/{fk} | Delete a related item by id for commenters.
[**DesignsIdCommentersFkGet**](DesignApi.md#designsidcommentersfkget) | **GET** /Designs/{id}/commenters/{fk} | Find a related item by id for commenters.
[**DesignsIdCommentersFkPut**](DesignApi.md#designsidcommentersfkput) | **PUT** /Designs/{id}/commenters/{fk} | Update a related item by id for commenters.
[**DesignsIdCommentersGet**](DesignApi.md#designsidcommentersget) | **GET** /Designs/{id}/commenters | Queries commenters of Design.
[**DesignsIdCommentersPost**](DesignApi.md#designsidcommenterspost) | **POST** /Designs/{id}/commenters | Creates a new instance in commenters of this model.
[**DesignsIdCommentersRelFkDelete**](DesignApi.md#designsidcommentersrelfkdelete) | **DELETE** /Designs/{id}/commenters/rel/{fk} | Remove the commenters relation to an item by id.
[**DesignsIdCommentersRelFkHead**](DesignApi.md#designsidcommentersrelfkhead) | **HEAD** /Designs/{id}/commenters/rel/{fk} | Check the existence of commenters relation to an item by id.
[**DesignsIdCommentersRelFkPut**](DesignApi.md#designsidcommentersrelfkput) | **PUT** /Designs/{id}/commenters/rel/{fk} | Add a related item by id for commenters.
[**DesignsIdCommentsCountGet**](DesignApi.md#designsidcommentscountget) | **GET** /Designs/{id}/comments/count | Counts comments of Design.
[**DesignsIdCommentsDelete**](DesignApi.md#designsidcommentsdelete) | **DELETE** /Designs/{id}/comments | Deletes all comments of this model.
[**DesignsIdCommentsFkDelete**](DesignApi.md#designsidcommentsfkdelete) | **DELETE** /Designs/{id}/comments/{fk} | Delete a related item by id for comments.
[**DesignsIdCommentsFkGet**](DesignApi.md#designsidcommentsfkget) | **GET** /Designs/{id}/comments/{fk} | Find a related item by id for comments.
[**DesignsIdCommentsFkPut**](DesignApi.md#designsidcommentsfkput) | **PUT** /Designs/{id}/comments/{fk} | Update a related item by id for comments.
[**DesignsIdCommentsGet**](DesignApi.md#designsidcommentsget) | **GET** /Designs/{id}/comments | Queries comments of Design.
[**DesignsIdCommentsNkCommenterGet**](DesignApi.md#designsidcommentsnkcommenterget) | **GET** /Designs/{id}/comments/{nk}/commenter | Fetches belongsTo relation commenter.
[**DesignsIdCommentsNkDesignGet**](DesignApi.md#designsidcommentsnkdesignget) | **GET** /Designs/{id}/comments/{nk}/design | Fetches belongsTo relation design.
[**DesignsIdCommentsNkRepliesCountGet**](DesignApi.md#designsidcommentsnkrepliescountget) | **GET** /Designs/{id}/comments/{nk}/replies/count | Counts replies of DesignComment.
[**DesignsIdCommentsNkRepliesDelete**](DesignApi.md#designsidcommentsnkrepliesdelete) | **DELETE** /Designs/{id}/comments/{nk}/replies | Deletes all replies of this model.
[**DesignsIdCommentsNkRepliesFkDelete**](DesignApi.md#designsidcommentsnkrepliesfkdelete) | **DELETE** /Designs/{id}/comments/{nk}/replies/{fk} | Delete a related item by id for replies.
[**DesignsIdCommentsNkRepliesFkGet**](DesignApi.md#designsidcommentsnkrepliesfkget) | **GET** /Designs/{id}/comments/{nk}/replies/{fk} | Find a related item by id for replies.
[**DesignsIdCommentsNkRepliesFkPut**](DesignApi.md#designsidcommentsnkrepliesfkput) | **PUT** /Designs/{id}/comments/{nk}/replies/{fk} | Update a related item by id for replies.
[**DesignsIdCommentsNkRepliesGet**](DesignApi.md#designsidcommentsnkrepliesget) | **GET** /Designs/{id}/comments/{nk}/replies | Queries replies of DesignComment.
[**DesignsIdCommentsNkRepliesPost**](DesignApi.md#designsidcommentsnkrepliespost) | **POST** /Designs/{id}/comments/{nk}/replies | Creates a new instance in replies of this model.
[**DesignsIdCommentsNkReplyOfGet**](DesignApi.md#designsidcommentsnkreplyofget) | **GET** /Designs/{id}/comments/{nk}/replyOf | Fetches belongsTo relation replyOf.
[**DesignsIdCommentsPost**](DesignApi.md#designsidcommentspost) | **POST** /Designs/{id}/comments | Creates a new instance in comments of this model.
[**DesignsIdCustomerGet**](DesignApi.md#designsidcustomerget) | **GET** /Designs/{id}/customer | Fetches belongsTo relation customer.
[**DesignsIdDelete**](DesignApi.md#designsiddelete) | **DELETE** /Designs/{id} | Delete a model instance by {{id}} from the data source.
[**DesignsIdExistsGet**](DesignApi.md#designsidexistsget) | **GET** /Designs/{id}/exists | Check whether a model instance exists in the data source.
[**DesignsIdExportsCountGet**](DesignApi.md#designsidexportscountget) | **GET** /Designs/{id}/exports/count | Counts exports of Design.
[**DesignsIdExportsDelete**](DesignApi.md#designsidexportsdelete) | **DELETE** /Designs/{id}/exports | Deletes all exports of this model.
[**DesignsIdExportsFkDelete**](DesignApi.md#designsidexportsfkdelete) | **DELETE** /Designs/{id}/exports/{fk} | Delete a related item by id for exports.
[**DesignsIdExportsFkGet**](DesignApi.md#designsidexportsfkget) | **GET** /Designs/{id}/exports/{fk} | Find a related item by id for exports.
[**DesignsIdExportsFkPut**](DesignApi.md#designsidexportsfkput) | **PUT** /Designs/{id}/exports/{fk} | Update a related item by id for exports.
[**DesignsIdExportsGet**](DesignApi.md#designsidexportsget) | **GET** /Designs/{id}/exports | Queries exports of Design.
[**DesignsIdExportsPost**](DesignApi.md#designsidexportspost) | **POST** /Designs/{id}/exports | Creates a new instance in exports of this model.
[**DesignsIdFolderGet**](DesignApi.md#designsidfolderget) | **GET** /Designs/{id}/folder | Fetches belongsTo relation folder.
[**DesignsIdGet**](DesignApi.md#designsidget) | **GET** /Designs/{id} | Find a model instance by {{id}} from the data source.
[**DesignsIdHead**](DesignApi.md#designsidhead) | **HEAD** /Designs/{id} | Check whether a model instance exists in the data source.
[**DesignsIdPatch**](DesignApi.md#designsidpatch) | **PATCH** /Designs/{id} | Patch attributes for a model instance and persist it into the data source.
[**DesignsIdPermissionDelete**](DesignApi.md#designsidpermissiondelete) | **DELETE** /Designs/{id}/permission | Deletes permission of this model.
[**DesignsIdPermissionGet**](DesignApi.md#designsidpermissionget) | **GET** /Designs/{id}/permission | Fetches hasOne relation permission.
[**DesignsIdPermissionPost**](DesignApi.md#designsidpermissionpost) | **POST** /Designs/{id}/permission | Creates a new instance in permission of this model.
[**DesignsIdPermissionPut**](DesignApi.md#designsidpermissionput) | **PUT** /Designs/{id}/permission | Update permission of this model.
[**DesignsIdPortalGet**](DesignApi.md#designsidportalget) | **GET** /Designs/{id}/portal | Fetches belongsTo relation portal.
[**DesignsIdPut**](DesignApi.md#designsidput) | **PUT** /Designs/{id} | Replace attributes for a model instance and persist it into the data source.
[**DesignsIdRejectPost**](DesignApi.md#designsidrejectpost) | **POST** /Designs/{id}/reject | Reject design
[**DesignsIdRejectionCommentGet**](DesignApi.md#designsidrejectioncommentget) | **GET** /Designs/{id}/rejectionComment | Fetches belongsTo relation rejectionComment.
[**DesignsIdReplacePost**](DesignApi.md#designsidreplacepost) | **POST** /Designs/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**DesignsIdRequesterGet**](DesignApi.md#designsidrequesterget) | **GET** /Designs/{id}/requester | Fetches belongsTo relation requester.
[**DesignsIdReviewerGet**](DesignApi.md#designsidreviewerget) | **GET** /Designs/{id}/reviewer | Fetches belongsTo relation reviewer.
[**DesignsIdSubmitPost**](DesignApi.md#designsidsubmitpost) | **POST** /Designs/{id}/submit | Submit design for approval
[**DesignsIdTagsCountGet**](DesignApi.md#designsidtagscountget) | **GET** /Designs/{id}/tags/count | Counts tags of Design.
[**DesignsIdTagsDelete**](DesignApi.md#designsidtagsdelete) | **DELETE** /Designs/{id}/tags | Deletes all tags of this model.
[**DesignsIdTagsFkDelete**](DesignApi.md#designsidtagsfkdelete) | **DELETE** /Designs/{id}/tags/{fk} | Delete a related item by id for tags.
[**DesignsIdTagsFkGet**](DesignApi.md#designsidtagsfkget) | **GET** /Designs/{id}/tags/{fk} | Find a related item by id for tags.
[**DesignsIdTagsFkPut**](DesignApi.md#designsidtagsfkput) | **PUT** /Designs/{id}/tags/{fk} | Update a related item by id for tags.
[**DesignsIdTagsGet**](DesignApi.md#designsidtagsget) | **GET** /Designs/{id}/tags | Queries tags of Design.
[**DesignsIdTagsPost**](DesignApi.md#designsidtagspost) | **POST** /Designs/{id}/tags | Creates a new instance in tags of this model.
[**DesignsIdTagsRelFkDelete**](DesignApi.md#designsidtagsrelfkdelete) | **DELETE** /Designs/{id}/tags/rel/{fk} | Remove the tags relation to an item by id.
[**DesignsIdTagsRelFkHead**](DesignApi.md#designsidtagsrelfkhead) | **HEAD** /Designs/{id}/tags/rel/{fk} | Check the existence of tags relation to an item by id.
[**DesignsIdTagsRelFkPut**](DesignApi.md#designsidtagsrelfkput) | **PUT** /Designs/{id}/tags/rel/{fk} | Add a related item by id for tags.
[**DesignsIdTemplateGet**](DesignApi.md#designsidtemplateget) | **GET** /Designs/{id}/template | Fetches belongsTo relation template.
[**DesignsPatch**](DesignApi.md#designspatch) | **PATCH** /Designs | Patch an existing model instance or insert a new one into the data source.
[**DesignsPost**](DesignApi.md#designspost) | **POST** /Designs | Create a new instance of the model and persist it into the data source.
[**DesignsPut**](DesignApi.md#designsput) | **PUT** /Designs | Replace an existing model instance or insert a new one into the data source.
[**DesignsReplaceOrCreatePost**](DesignApi.md#designsreplaceorcreatepost) | **POST** /Designs/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**DesignsUpdatePost**](DesignApi.md#designsupdatepost) | **POST** /Designs/update | Update instances of the model matched by {{where}} from the data source.
[**DesignsUpsertWithWherePost**](DesignApi.md#designsupsertwithwherepost) | **POST** /Designs/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="designschangestreamget"></a>
# **DesignsChangeStreamGet**
> System.IO.Stream DesignsChangeStreamGet (string options = null)

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
    public class DesignsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DesignsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsChangeStreamGet: " + e.Message );
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

<a name="designschangestreampost"></a>
# **DesignsChangeStreamPost**
> System.IO.Stream DesignsChangeStreamPost (string options = null)

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
    public class DesignsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.DesignsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsChangeStreamPost: " + e.Message );
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

<a name="designscountget"></a>
# **DesignsCountGet**
> InlineResponse200 DesignsCountGet (string where = null)

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
    public class DesignsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.DesignsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsCountGet: " + e.Message );
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

<a name="designsfindoneget"></a>
# **DesignsFindOneGet**
> Design DesignsFindOneGet (string filter = null)

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
    public class DesignsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                Design result = apiInstance.DesignsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsFindOneGet: " + e.Message );
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

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsget"></a>
# **DesignsGet**
> List<Design> DesignsGet (string filter = null)

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
    public class DesignsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;Design&gt; result = apiInstance.DesignsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsGet: " + e.Message );
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

[**List<Design>**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidapprovepost"></a>
# **DesignsIdApprovePost**
> Design DesignsIdApprovePost (string id, string id2)

Approve design

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdApprovePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var id2 = id_example;  // string | Customer id

            try
            {
                // Approve design
                Design result = apiInstance.DesignsIdApprovePost(id, id2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdApprovePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **id2** | **string**| Customer id | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidassigneeget"></a>
# **DesignsIdAssigneeGet**
> TeamMember DesignsIdAssigneeGet (string id, bool? refresh = null)

Fetches belongsTo relation assignee.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdAssigneeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation assignee.
                TeamMember result = apiInstance.DesignsIdAssigneeGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdAssigneeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommenterscountget"></a>
# **DesignsIdCommentersCountGet**
> InlineResponse200 DesignsIdCommentersCountGet (string id, string where = null)

Counts commenters of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts commenters of Design.
                InlineResponse200 result = apiInstance.DesignsIdCommentersCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentersdelete"></a>
# **DesignsIdCommentersDelete**
> void DesignsIdCommentersDelete (string id)

Deletes all commenters of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id

            try
            {
                // Deletes all commenters of this model.
                apiInstance.DesignsIdCommentersDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentersfkdelete"></a>
# **DesignsIdCommentersFkDelete**
> void DesignsIdCommentersFkDelete (string id, string fk)

Delete a related item by id for commenters.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for commenters

            try
            {
                // Delete a related item by id for commenters.
                apiInstance.DesignsIdCommentersFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for commenters | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentersfkget"></a>
# **DesignsIdCommentersFkGet**
> TeamMember DesignsIdCommentersFkGet (string id, string fk)

Find a related item by id for commenters.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for commenters

            try
            {
                // Find a related item by id for commenters.
                TeamMember result = apiInstance.DesignsIdCommentersFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for commenters | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentersfkput"></a>
# **DesignsIdCommentersFkPut**
> TeamMember DesignsIdCommentersFkPut (string id, string fk, TeamMember data = null)

Update a related item by id for commenters.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for commenters
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Update a related item by id for commenters.
                TeamMember result = apiInstance.DesignsIdCommentersFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for commenters | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentersget"></a>
# **DesignsIdCommentersGet**
> List<TeamMember> DesignsIdCommentersGet (string id, string filter = null)

Queries commenters of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries commenters of Design.
                List&lt;TeamMember&gt; result = apiInstance.DesignsIdCommentersGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<TeamMember>**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommenterspost"></a>
# **DesignsIdCommentersPost**
> TeamMember DesignsIdCommentersPost (string id, TeamMember data = null)

Creates a new instance in commenters of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var data = new TeamMember(); // TeamMember |  (optional) 

            try
            {
                // Creates a new instance in commenters of this model.
                TeamMember result = apiInstance.DesignsIdCommentersPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **data** | [**TeamMember**](TeamMember.md)|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentersrelfkdelete"></a>
# **DesignsIdCommentersRelFkDelete**
> void DesignsIdCommentersRelFkDelete (string id, string fk)

Remove the commenters relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for commenters

            try
            {
                // Remove the commenters relation to an item by id.
                apiInstance.DesignsIdCommentersRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for commenters | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentersrelfkhead"></a>
# **DesignsIdCommentersRelFkHead**
> bool? DesignsIdCommentersRelFkHead (string id, string fk)

Check the existence of commenters relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for commenters

            try
            {
                // Check the existence of commenters relation to an item by id.
                bool? result = apiInstance.DesignsIdCommentersRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for commenters | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentersrelfkput"></a>
# **DesignsIdCommentersRelFkPut**
> DesignComment DesignsIdCommentersRelFkPut (string id, string fk, DesignComment data = null)

Add a related item by id for commenters.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentersRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for commenters
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Add a related item by id for commenters.
                DesignComment result = apiInstance.DesignsIdCommentersRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentersRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for commenters | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentscountget"></a>
# **DesignsIdCommentsCountGet**
> InlineResponse200 DesignsIdCommentsCountGet (string id, string where = null)

Counts comments of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts comments of Design.
                InlineResponse200 result = apiInstance.DesignsIdCommentsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsdelete"></a>
# **DesignsIdCommentsDelete**
> void DesignsIdCommentsDelete (string id)

Deletes all comments of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id

            try
            {
                // Deletes all comments of this model.
                apiInstance.DesignsIdCommentsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsfkdelete"></a>
# **DesignsIdCommentsFkDelete**
> void DesignsIdCommentsFkDelete (string id, string fk)

Delete a related item by id for comments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for comments

            try
            {
                // Delete a related item by id for comments.
                apiInstance.DesignsIdCommentsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for comments | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsfkget"></a>
# **DesignsIdCommentsFkGet**
> DesignComment DesignsIdCommentsFkGet (string id, string fk)

Find a related item by id for comments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for comments

            try
            {
                // Find a related item by id for comments.
                DesignComment result = apiInstance.DesignsIdCommentsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for comments | 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsfkput"></a>
# **DesignsIdCommentsFkPut**
> DesignComment DesignsIdCommentsFkPut (string id, string fk, DesignComment data = null)

Update a related item by id for comments.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for comments
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Update a related item by id for comments.
                DesignComment result = apiInstance.DesignsIdCommentsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for comments | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsget"></a>
# **DesignsIdCommentsGet**
> List<DesignComment> DesignsIdCommentsGet (string id, string filter = null)

Queries comments of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries comments of Design.
                List&lt;DesignComment&gt; result = apiInstance.DesignsIdCommentsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignComment>**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkcommenterget"></a>
# **DesignsIdCommentsNkCommenterGet**
> TeamMember DesignsIdCommentsNkCommenterGet (string id, string nk, bool? refresh = null)

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
    public class DesignsIdCommentsNkCommenterGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation commenter.
                TeamMember result = apiInstance.DesignsIdCommentsNkCommenterGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkCommenterGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkdesignget"></a>
# **DesignsIdCommentsNkDesignGet**
> Design DesignsIdCommentsNkDesignGet (string id, string nk, bool? refresh = null)

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
    public class DesignsIdCommentsNkDesignGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation design.
                Design result = apiInstance.DesignsIdCommentsNkDesignGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkDesignGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkrepliescountget"></a>
# **DesignsIdCommentsNkRepliesCountGet**
> InlineResponse200 DesignsIdCommentsNkRepliesCountGet (string id, string nk, string where = null)

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
    public class DesignsIdCommentsNkRepliesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts replies of DesignComment.
                InlineResponse200 result = apiInstance.DesignsIdCommentsNkRepliesCountGet(id, nk, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkRepliesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkrepliesdelete"></a>
# **DesignsIdCommentsNkRepliesDelete**
> void DesignsIdCommentsNkRepliesDelete (string id, string nk)

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
    public class DesignsIdCommentsNkRepliesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.

            try
            {
                // Deletes all replies of this model.
                apiInstance.DesignsIdCommentsNkRepliesDelete(id, nk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkRepliesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkrepliesfkdelete"></a>
# **DesignsIdCommentsNkRepliesFkDelete**
> void DesignsIdCommentsNkRepliesFkDelete (string id, string nk, string fk)

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
    public class DesignsIdCommentsNkRepliesFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var fk = fk_example;  // string | Foreign key for replies

            try
            {
                // Delete a related item by id for replies.
                apiInstance.DesignsIdCommentsNkRepliesFkDelete(id, nk, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkRepliesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
 **fk** | **string**| Foreign key for replies | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkrepliesfkget"></a>
# **DesignsIdCommentsNkRepliesFkGet**
> DesignComment DesignsIdCommentsNkRepliesFkGet (string id, string nk, string fk)

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
    public class DesignsIdCommentsNkRepliesFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var fk = fk_example;  // string | Foreign key for replies

            try
            {
                // Find a related item by id for replies.
                DesignComment result = apiInstance.DesignsIdCommentsNkRepliesFkGet(id, nk, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkRepliesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
 **fk** | **string**| Foreign key for replies | 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkrepliesfkput"></a>
# **DesignsIdCommentsNkRepliesFkPut**
> DesignComment DesignsIdCommentsNkRepliesFkPut (string id, string nk, string fk, DesignComment data = null)

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
    public class DesignsIdCommentsNkRepliesFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var fk = fk_example;  // string | Foreign key for replies
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Update a related item by id for replies.
                DesignComment result = apiInstance.DesignsIdCommentsNkRepliesFkPut(id, nk, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkRepliesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
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

<a name="designsidcommentsnkrepliesget"></a>
# **DesignsIdCommentsNkRepliesGet**
> List<DesignComment> DesignsIdCommentsNkRepliesGet (string id, string nk, string filter = null)

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
    public class DesignsIdCommentsNkRepliesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries replies of DesignComment.
                List&lt;DesignComment&gt; result = apiInstance.DesignsIdCommentsNkRepliesGet(id, nk, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkRepliesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignComment>**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkrepliespost"></a>
# **DesignsIdCommentsNkRepliesPost**
> DesignComment DesignsIdCommentsNkRepliesPost (string id, string nk, DesignComment data = null)

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
    public class DesignsIdCommentsNkRepliesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Creates a new instance in replies of this model.
                DesignComment result = apiInstance.DesignsIdCommentsNkRepliesPost(id, nk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkRepliesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentsnkreplyofget"></a>
# **DesignsIdCommentsNkReplyOfGet**
> DesignComment DesignsIdCommentsNkReplyOfGet (string id, string nk, bool? refresh = null)

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
    public class DesignsIdCommentsNkReplyOfGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var nk = nk_example;  // string | Foreign key for comments.
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation replyOf.
                DesignComment result = apiInstance.DesignsIdCommentsNkReplyOfGet(id, nk, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsNkReplyOfGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **nk** | **string**| Foreign key for comments. | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcommentspost"></a>
# **DesignsIdCommentsPost**
> DesignComment DesignsIdCommentsPost (string id, DesignComment data = null)

Creates a new instance in comments of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCommentsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var data = new DesignComment(); // DesignComment |  (optional) 

            try
            {
                // Creates a new instance in comments of this model.
                DesignComment result = apiInstance.DesignsIdCommentsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCommentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **data** | [**DesignComment**](DesignComment.md)|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidcustomerget"></a>
# **DesignsIdCustomerGet**
> Customer DesignsIdCustomerGet (string id, bool? refresh = null)

Fetches belongsTo relation customer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdCustomerGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation customer.
                Customer result = apiInstance.DesignsIdCustomerGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdCustomerGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsiddelete"></a>
# **DesignsIdDelete**
> Object DesignsIdDelete (string id)

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
    public class DesignsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.DesignsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdDelete: " + e.Message );
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

<a name="designsidexistsget"></a>
# **DesignsIdExistsGet**
> InlineResponse2001 DesignsIdExistsGet (string id)

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
    public class DesignsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.DesignsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdExistsGet: " + e.Message );
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

<a name="designsidexportscountget"></a>
# **DesignsIdExportsCountGet**
> InlineResponse200 DesignsIdExportsCountGet (string id, string where = null)

Counts exports of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdExportsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts exports of Design.
                InlineResponse200 result = apiInstance.DesignsIdExportsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdExportsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidexportsdelete"></a>
# **DesignsIdExportsDelete**
> void DesignsIdExportsDelete (string id)

Deletes all exports of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdExportsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id

            try
            {
                // Deletes all exports of this model.
                apiInstance.DesignsIdExportsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdExportsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidexportsfkdelete"></a>
# **DesignsIdExportsFkDelete**
> void DesignsIdExportsFkDelete (string id, string fk)

Delete a related item by id for exports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdExportsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for exports

            try
            {
                // Delete a related item by id for exports.
                apiInstance.DesignsIdExportsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdExportsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for exports | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidexportsfkget"></a>
# **DesignsIdExportsFkGet**
> DesignExport DesignsIdExportsFkGet (string id, string fk)

Find a related item by id for exports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdExportsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for exports

            try
            {
                // Find a related item by id for exports.
                DesignExport result = apiInstance.DesignsIdExportsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdExportsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for exports | 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidexportsfkput"></a>
# **DesignsIdExportsFkPut**
> DesignExport DesignsIdExportsFkPut (string id, string fk, DesignExport data = null)

Update a related item by id for exports.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdExportsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for exports
            var data = new DesignExport(); // DesignExport |  (optional) 

            try
            {
                // Update a related item by id for exports.
                DesignExport result = apiInstance.DesignsIdExportsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdExportsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for exports | 
 **data** | [**DesignExport**](DesignExport.md)|  | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidexportsget"></a>
# **DesignsIdExportsGet**
> List<DesignExport> DesignsIdExportsGet (string id, string filter = null)

Queries exports of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdExportsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries exports of Design.
                List&lt;DesignExport&gt; result = apiInstance.DesignsIdExportsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdExportsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<DesignExport>**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidexportspost"></a>
# **DesignsIdExportsPost**
> DesignExport DesignsIdExportsPost (string id, DesignExport data = null)

Creates a new instance in exports of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdExportsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var data = new DesignExport(); // DesignExport |  (optional) 

            try
            {
                // Creates a new instance in exports of this model.
                DesignExport result = apiInstance.DesignsIdExportsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdExportsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **data** | [**DesignExport**](DesignExport.md)|  | [optional] 

### Return type

[**DesignExport**](DesignExport.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidfolderget"></a>
# **DesignsIdFolderGet**
> DesignFolder DesignsIdFolderGet (string id, bool? refresh = null)

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
    public class DesignsIdFolderGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation folder.
                DesignFolder result = apiInstance.DesignsIdFolderGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdFolderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DesignFolder**](DesignFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidget"></a>
# **DesignsIdGet**
> Design DesignsIdGet (string id, string filter = null)

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
    public class DesignsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                Design result = apiInstance.DesignsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdGet: " + e.Message );
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

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidhead"></a>
# **DesignsIdHead**
> InlineResponse2001 DesignsIdHead (string id)

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
    public class DesignsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.DesignsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdHead: " + e.Message );
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

<a name="designsidpatch"></a>
# **DesignsIdPatch**
> Design DesignsIdPatch (string id, Design data = null)

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
    public class DesignsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var data = new Design(); // Design | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                Design result = apiInstance.DesignsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **data** | [**Design**](Design.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidpermissiondelete"></a>
# **DesignsIdPermissionDelete**
> void DesignsIdPermissionDelete (string id)

Deletes permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdPermissionDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id

            try
            {
                // Deletes permission of this model.
                apiInstance.DesignsIdPermissionDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdPermissionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidpermissionget"></a>
# **DesignsIdPermissionGet**
> DesignPermissionSet DesignsIdPermissionGet (string id, bool? refresh = null)

Fetches hasOne relation permission.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdPermissionGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches hasOne relation permission.
                DesignPermissionSet result = apiInstance.DesignsIdPermissionGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdPermissionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidpermissionpost"></a>
# **DesignsIdPermissionPost**
> DesignPermissionSet DesignsIdPermissionPost (string id, DesignPermissionSet data = null)

Creates a new instance in permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdPermissionPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var data = new DesignPermissionSet(); // DesignPermissionSet |  (optional) 

            try
            {
                // Creates a new instance in permission of this model.
                DesignPermissionSet result = apiInstance.DesignsIdPermissionPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdPermissionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)|  | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidpermissionput"></a>
# **DesignsIdPermissionPut**
> DesignPermissionSet DesignsIdPermissionPut (string id, DesignPermissionSet data = null)

Update permission of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdPermissionPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var data = new DesignPermissionSet(); // DesignPermissionSet |  (optional) 

            try
            {
                // Update permission of this model.
                DesignPermissionSet result = apiInstance.DesignsIdPermissionPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdPermissionPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **data** | [**DesignPermissionSet**](DesignPermissionSet.md)|  | [optional] 

### Return type

[**DesignPermissionSet**](DesignPermissionSet.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidportalget"></a>
# **DesignsIdPortalGet**
> Portal DesignsIdPortalGet (string id, bool? refresh = null)

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
    public class DesignsIdPortalGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation portal.
                Portal result = apiInstance.DesignsIdPortalGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdPortalGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidput"></a>
# **DesignsIdPut**
> Design DesignsIdPut (string id, Design data = null)

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
    public class DesignsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Model id
            var data = new Design(); // Design | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Design result = apiInstance.DesignsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Design**](Design.md)| Model instance data | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidrejectpost"></a>
# **DesignsIdRejectPost**
> Design DesignsIdRejectPost (string id, string id2, Design data = null)

Reject design

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdRejectPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var id2 = id_example;  // string | Customer id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Reject design
                Design result = apiInstance.DesignsIdRejectPost(id, id2, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdRejectPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **id2** | **string**| Customer id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidrejectioncommentget"></a>
# **DesignsIdRejectionCommentGet**
> DesignComment DesignsIdRejectionCommentGet (string id, bool? refresh = null)

Fetches belongsTo relation rejectionComment.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdRejectionCommentGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation rejectionComment.
                DesignComment result = apiInstance.DesignsIdRejectionCommentGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdRejectionCommentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**DesignComment**](DesignComment.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidreplacepost"></a>
# **DesignsIdReplacePost**
> Design DesignsIdReplacePost (string id, Design data = null)

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
    public class DesignsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Model id
            var data = new Design(); // Design | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Design result = apiInstance.DesignsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Design**](Design.md)| Model instance data | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidrequesterget"></a>
# **DesignsIdRequesterGet**
> TeamMember DesignsIdRequesterGet (string id, bool? refresh = null)

Fetches belongsTo relation requester.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdRequesterGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation requester.
                TeamMember result = apiInstance.DesignsIdRequesterGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdRequesterGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidreviewerget"></a>
# **DesignsIdReviewerGet**
> TeamMember DesignsIdReviewerGet (string id, bool? refresh = null)

Fetches belongsTo relation reviewer.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdReviewerGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation reviewer.
                TeamMember result = apiInstance.DesignsIdReviewerGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdReviewerGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidsubmitpost"></a>
# **DesignsIdSubmitPost**
> Design DesignsIdSubmitPost (string id, string id2)

Submit design for approval

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdSubmitPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var id2 = id_example;  // string | Customer id

            try
            {
                // Submit design for approval
                Design result = apiInstance.DesignsIdSubmitPost(id, id2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdSubmitPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **id2** | **string**| Customer id | 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagscountget"></a>
# **DesignsIdTagsCountGet**
> InlineResponse200 DesignsIdTagsCountGet (string id, string where = null)

Counts tags of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts tags of Design.
                InlineResponse200 result = apiInstance.DesignsIdTagsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagsdelete"></a>
# **DesignsIdTagsDelete**
> void DesignsIdTagsDelete (string id)

Deletes all tags of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id

            try
            {
                // Deletes all tags of this model.
                apiInstance.DesignsIdTagsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagsfkdelete"></a>
# **DesignsIdTagsFkDelete**
> void DesignsIdTagsFkDelete (string id, string fk)

Delete a related item by id for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Delete a related item by id for tags.
                apiInstance.DesignsIdTagsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for tags | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagsfkget"></a>
# **DesignsIdTagsFkGet**
> Tag DesignsIdTagsFkGet (string id, string fk)

Find a related item by id for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Find a related item by id for tags.
                Tag result = apiInstance.DesignsIdTagsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for tags | 

### Return type

[**Tag**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagsfkput"></a>
# **DesignsIdTagsFkPut**
> Tag DesignsIdTagsFkPut (string id, string fk, Tag data = null)

Update a related item by id for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for tags
            var data = new Tag(); // Tag |  (optional) 

            try
            {
                // Update a related item by id for tags.
                Tag result = apiInstance.DesignsIdTagsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for tags | 
 **data** | [**Tag**](Tag.md)|  | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagsget"></a>
# **DesignsIdTagsGet**
> List<Tag> DesignsIdTagsGet (string id, string filter = null)

Queries tags of Design.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries tags of Design.
                List&lt;Tag&gt; result = apiInstance.DesignsIdTagsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Tag>**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagspost"></a>
# **DesignsIdTagsPost**
> Tag DesignsIdTagsPost (string id, Tag data = null)

Creates a new instance in tags of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var data = new Tag(); // Tag |  (optional) 

            try
            {
                // Creates a new instance in tags of this model.
                Tag result = apiInstance.DesignsIdTagsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **data** | [**Tag**](Tag.md)|  | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagsrelfkdelete"></a>
# **DesignsIdTagsRelFkDelete**
> void DesignsIdTagsRelFkDelete (string id, string fk)

Remove the tags relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Remove the tags relation to an item by id.
                apiInstance.DesignsIdTagsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for tags | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagsrelfkhead"></a>
# **DesignsIdTagsRelFkHead**
> bool? DesignsIdTagsRelFkHead (string id, string fk)

Check the existence of tags relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for tags

            try
            {
                // Check the existence of tags relation to an item by id.
                bool? result = apiInstance.DesignsIdTagsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for tags | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtagsrelfkput"></a>
# **DesignsIdTagsRelFkPut**
> DesignTag DesignsIdTagsRelFkPut (string id, string fk, DesignTag data = null)

Add a related item by id for tags.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTagsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var fk = fk_example;  // string | Foreign key for tags
            var data = new DesignTag(); // DesignTag |  (optional) 

            try
            {
                // Add a related item by id for tags.
                DesignTag result = apiInstance.DesignsIdTagsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTagsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **fk** | **string**| Foreign key for tags | 
 **data** | [**DesignTag**](DesignTag.md)|  | [optional] 

### Return type

[**DesignTag**](DesignTag.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsidtemplateget"></a>
# **DesignsIdTemplateGet**
> Template DesignsIdTemplateGet (string id, bool? refresh = null)

Fetches belongsTo relation template.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class DesignsIdTemplateGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var id = id_example;  // string | Design id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation template.
                Template result = apiInstance.DesignsIdTemplateGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsIdTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Design id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designspatch"></a>
# **DesignsPatch**
> Design DesignsPatch (Design data = null)

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
    public class DesignsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var data = new Design(); // Design | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                Design result = apiInstance.DesignsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Design**](Design.md)| Model instance data | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designspost"></a>
# **DesignsPost**
> Design DesignsPost (Design data = null)

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
    public class DesignsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var data = new Design(); // Design | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                Design result = apiInstance.DesignsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Design**](Design.md)| Model instance data | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsput"></a>
# **DesignsPut**
> Design DesignsPut (Design data = null)

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
    public class DesignsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var data = new Design(); // Design | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Design result = apiInstance.DesignsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Design**](Design.md)| Model instance data | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsreplaceorcreatepost"></a>
# **DesignsReplaceOrCreatePost**
> Design DesignsReplaceOrCreatePost (Design data = null)

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
    public class DesignsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var data = new Design(); // Design | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Design result = apiInstance.DesignsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Design**](Design.md)| Model instance data | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsupdatepost"></a>
# **DesignsUpdatePost**
> InlineResponse2002 DesignsUpdatePost (string where = null, Design data = null)

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
    public class DesignsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Design(); // Design | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.DesignsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Design**](Design.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="designsupsertwithwherepost"></a>
# **DesignsUpsertWithWherePost**
> Design DesignsUpsertWithWherePost (string where = null, Design data = null)

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
    public class DesignsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new DesignApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Design(); // Design | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                Design result = apiInstance.DesignsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DesignApi.DesignsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Design**](Design.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

