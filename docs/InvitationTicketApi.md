# TweakApi.Api.InvitationTicketApi

All URIs are relative to *https://apicdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvitationTicketsChangeStreamGet**](InvitationTicketApi.md#invitationticketschangestreamget) | **GET** /InvitationTickets/change-stream | Create a change stream.
[**InvitationTicketsChangeStreamPost**](InvitationTicketApi.md#invitationticketschangestreampost) | **POST** /InvitationTickets/change-stream | Create a change stream.
[**InvitationTicketsCountGet**](InvitationTicketApi.md#invitationticketscountget) | **GET** /InvitationTickets/count | Count instances of the model matched by where from the data source.
[**InvitationTicketsFindOneGet**](InvitationTicketApi.md#invitationticketsfindoneget) | **GET** /InvitationTickets/findOne | Find first instance of the model matched by filter from the data source.
[**InvitationTicketsGet**](InvitationTicketApi.md#invitationticketsget) | **GET** /InvitationTickets | Find all instances of the model matched by filter from the data source.
[**InvitationTicketsIdDelete**](InvitationTicketApi.md#invitationticketsiddelete) | **DELETE** /InvitationTickets/{id} | Delete a model instance by {{id}} from the data source.
[**InvitationTicketsIdExistsGet**](InvitationTicketApi.md#invitationticketsidexistsget) | **GET** /InvitationTickets/{id}/exists | Check whether a model instance exists in the data source.
[**InvitationTicketsIdGet**](InvitationTicketApi.md#invitationticketsidget) | **GET** /InvitationTickets/{id} | Find a model instance by {{id}} from the data source.
[**InvitationTicketsIdHead**](InvitationTicketApi.md#invitationticketsidhead) | **HEAD** /InvitationTickets/{id} | Check whether a model instance exists in the data source.
[**InvitationTicketsIdInviteeGet**](InvitationTicketApi.md#invitationticketsidinviteeget) | **GET** /InvitationTickets/{id}/invitee | Fetches belongsTo relation invitee.
[**InvitationTicketsIdInviterGet**](InvitationTicketApi.md#invitationticketsidinviterget) | **GET** /InvitationTickets/{id}/inviter | Fetches belongsTo relation inviter.
[**InvitationTicketsIdPatch**](InvitationTicketApi.md#invitationticketsidpatch) | **PATCH** /InvitationTickets/{id} | Patch attributes for a model instance and persist it into the data source.
[**InvitationTicketsIdPut**](InvitationTicketApi.md#invitationticketsidput) | **PUT** /InvitationTickets/{id} | Replace attributes for a model instance and persist it into the data source.
[**InvitationTicketsIdReplacePost**](InvitationTicketApi.md#invitationticketsidreplacepost) | **POST** /InvitationTickets/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**InvitationTicketsIdTargetImageFolderGet**](InvitationTicketApi.md#invitationticketsidtargetimagefolderget) | **GET** /InvitationTickets/{id}/targetImageFolder | Fetches belongsTo relation targetImageFolder.
[**InvitationTicketsIdTargetImageFolderMemberGet**](InvitationTicketApi.md#invitationticketsidtargetimagefoldermemberget) | **GET** /InvitationTickets/{id}/targetImageFolderMember | Fetches belongsTo relation targetImageFolderMember.
[**InvitationTicketsIdTargetPortalGet**](InvitationTicketApi.md#invitationticketsidtargetportalget) | **GET** /InvitationTickets/{id}/targetPortal | Fetches belongsTo relation targetPortal.
[**InvitationTicketsIdTargetPortalMemberGet**](InvitationTicketApi.md#invitationticketsidtargetportalmemberget) | **GET** /InvitationTickets/{id}/targetPortalMember | Fetches belongsTo relation targetPortalMember.
[**InvitationTicketsIdTargetTeamGet**](InvitationTicketApi.md#invitationticketsidtargetteamget) | **GET** /InvitationTickets/{id}/targetTeam | Fetches belongsTo relation targetTeam.
[**InvitationTicketsIdTargetTeamMemberGet**](InvitationTicketApi.md#invitationticketsidtargetteammemberget) | **GET** /InvitationTickets/{id}/targetTeamMember | Fetches belongsTo relation targetTeamMember.
[**InvitationTicketsIdTargetTemplateGet**](InvitationTicketApi.md#invitationticketsidtargettemplateget) | **GET** /InvitationTickets/{id}/targetTemplate | Fetches belongsTo relation targetTemplate.
[**InvitationTicketsIdTargetTemplateMemberGet**](InvitationTicketApi.md#invitationticketsidtargettemplatememberget) | **GET** /InvitationTickets/{id}/targetTemplateMember | Fetches belongsTo relation targetTemplateMember.
[**InvitationTicketsPatch**](InvitationTicketApi.md#invitationticketspatch) | **PATCH** /InvitationTickets | Patch an existing model instance or insert a new one into the data source.
[**InvitationTicketsPost**](InvitationTicketApi.md#invitationticketspost) | **POST** /InvitationTickets | Create a new instance of the model and persist it into the data source.
[**InvitationTicketsPut**](InvitationTicketApi.md#invitationticketsput) | **PUT** /InvitationTickets | Replace an existing model instance or insert a new one into the data source.
[**InvitationTicketsReplaceOrCreatePost**](InvitationTicketApi.md#invitationticketsreplaceorcreatepost) | **POST** /InvitationTickets/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**InvitationTicketsUpdatePost**](InvitationTicketApi.md#invitationticketsupdatepost) | **POST** /InvitationTickets/update | Update instances of the model matched by {{where}} from the data source.
[**InvitationTicketsUpsertWithWherePost**](InvitationTicketApi.md#invitationticketsupsertwithwherepost) | **POST** /InvitationTickets/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="invitationticketschangestreamget"></a>
# **InvitationTicketsChangeStreamGet**
> System.IO.Stream InvitationTicketsChangeStreamGet (string options = null)

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
    public class InvitationTicketsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.InvitationTicketsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsChangeStreamGet: " + e.Message );
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

<a name="invitationticketschangestreampost"></a>
# **InvitationTicketsChangeStreamPost**
> System.IO.Stream InvitationTicketsChangeStreamPost (string options = null)

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
    public class InvitationTicketsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.InvitationTicketsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsChangeStreamPost: " + e.Message );
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

<a name="invitationticketscountget"></a>
# **InvitationTicketsCountGet**
> InlineResponse200 InvitationTicketsCountGet (string where = null)

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
    public class InvitationTicketsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.InvitationTicketsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsCountGet: " + e.Message );
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

<a name="invitationticketsfindoneget"></a>
# **InvitationTicketsFindOneGet**
> InvitationTicket InvitationTicketsFindOneGet (string filter = null)

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
    public class InvitationTicketsFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                InvitationTicket result = apiInstance.InvitationTicketsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsFindOneGet: " + e.Message );
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

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsget"></a>
# **InvitationTicketsGet**
> List<InvitationTicket> InvitationTicketsGet (string filter = null)

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
    public class InvitationTicketsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;InvitationTicket&gt; result = apiInstance.InvitationTicketsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsGet: " + e.Message );
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

[**List<InvitationTicket>**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsiddelete"></a>
# **InvitationTicketsIdDelete**
> Object InvitationTicketsIdDelete (string id)

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
    public class InvitationTicketsIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.InvitationTicketsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdDelete: " + e.Message );
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

<a name="invitationticketsidexistsget"></a>
# **InvitationTicketsIdExistsGet**
> InlineResponse2001 InvitationTicketsIdExistsGet (string id)

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
    public class InvitationTicketsIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.InvitationTicketsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdExistsGet: " + e.Message );
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

<a name="invitationticketsidget"></a>
# **InvitationTicketsIdGet**
> InvitationTicket InvitationTicketsIdGet (string id, string filter = null)

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
    public class InvitationTicketsIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                InvitationTicket result = apiInstance.InvitationTicketsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdGet: " + e.Message );
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

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidhead"></a>
# **InvitationTicketsIdHead**
> InlineResponse2001 InvitationTicketsIdHead (string id)

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
    public class InvitationTicketsIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2001 result = apiInstance.InvitationTicketsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdHead: " + e.Message );
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

<a name="invitationticketsidinviteeget"></a>
# **InvitationTicketsIdInviteeGet**
> Customer InvitationTicketsIdInviteeGet (string id, bool? refresh = null)

Fetches belongsTo relation invitee.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdInviteeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation invitee.
                Customer result = apiInstance.InvitationTicketsIdInviteeGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdInviteeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Customer**](Customer.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidinviterget"></a>
# **InvitationTicketsIdInviterGet**
> TeamMember InvitationTicketsIdInviterGet (string id, bool? refresh = null)

Fetches belongsTo relation inviter.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdInviterGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation inviter.
                TeamMember result = apiInstance.InvitationTicketsIdInviterGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdInviterGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidpatch"></a>
# **InvitationTicketsIdPatch**
> InvitationTicket InvitationTicketsIdPatch (string id, InvitationTicket data = null)

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
    public class InvitationTicketsIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var data = new InvitationTicket(); // InvitationTicket | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                InvitationTicket result = apiInstance.InvitationTicketsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **data** | [**InvitationTicket**](InvitationTicket.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidput"></a>
# **InvitationTicketsIdPut**
> InvitationTicket InvitationTicketsIdPut (string id, InvitationTicket data = null)

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
    public class InvitationTicketsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | Model id
            var data = new InvitationTicket(); // InvitationTicket | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                InvitationTicket result = apiInstance.InvitationTicketsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**InvitationTicket**](InvitationTicket.md)| Model instance data | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidreplacepost"></a>
# **InvitationTicketsIdReplacePost**
> InvitationTicket InvitationTicketsIdReplacePost (string id, InvitationTicket data = null)

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
    public class InvitationTicketsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | Model id
            var data = new InvitationTicket(); // InvitationTicket | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                InvitationTicket result = apiInstance.InvitationTicketsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**InvitationTicket**](InvitationTicket.md)| Model instance data | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidtargetimagefolderget"></a>
# **InvitationTicketsIdTargetImageFolderGet**
> ImageFolder InvitationTicketsIdTargetImageFolderGet (string id, bool? refresh = null)

Fetches belongsTo relation targetImageFolder.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdTargetImageFolderGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation targetImageFolder.
                ImageFolder result = apiInstance.InvitationTicketsIdTargetImageFolderGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdTargetImageFolderGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ImageFolder**](ImageFolder.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidtargetimagefoldermemberget"></a>
# **InvitationTicketsIdTargetImageFolderMemberGet**
> ImageFolderMember InvitationTicketsIdTargetImageFolderMemberGet (string id, bool? refresh = null)

Fetches belongsTo relation targetImageFolderMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdTargetImageFolderMemberGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation targetImageFolderMember.
                ImageFolderMember result = apiInstance.InvitationTicketsIdTargetImageFolderMemberGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdTargetImageFolderMemberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ImageFolderMember**](ImageFolderMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidtargetportalget"></a>
# **InvitationTicketsIdTargetPortalGet**
> Portal InvitationTicketsIdTargetPortalGet (string id, bool? refresh = null)

Fetches belongsTo relation targetPortal.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdTargetPortalGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation targetPortal.
                Portal result = apiInstance.InvitationTicketsIdTargetPortalGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdTargetPortalGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Portal**](Portal.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidtargetportalmemberget"></a>
# **InvitationTicketsIdTargetPortalMemberGet**
> PortalMember InvitationTicketsIdTargetPortalMemberGet (string id, bool? refresh = null)

Fetches belongsTo relation targetPortalMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdTargetPortalMemberGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation targetPortalMember.
                PortalMember result = apiInstance.InvitationTicketsIdTargetPortalMemberGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdTargetPortalMemberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**PortalMember**](PortalMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidtargetteamget"></a>
# **InvitationTicketsIdTargetTeamGet**
> Team InvitationTicketsIdTargetTeamGet (string id, bool? refresh = null)

Fetches belongsTo relation targetTeam.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdTargetTeamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation targetTeam.
                Team result = apiInstance.InvitationTicketsIdTargetTeamGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdTargetTeamGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Team**](Team.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidtargetteammemberget"></a>
# **InvitationTicketsIdTargetTeamMemberGet**
> TeamMember InvitationTicketsIdTargetTeamMemberGet (string id, bool? refresh = null)

Fetches belongsTo relation targetTeamMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdTargetTeamMemberGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation targetTeamMember.
                TeamMember result = apiInstance.InvitationTicketsIdTargetTeamMemberGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdTargetTeamMemberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidtargettemplateget"></a>
# **InvitationTicketsIdTargetTemplateGet**
> Template InvitationTicketsIdTargetTemplateGet (string id, bool? refresh = null)

Fetches belongsTo relation targetTemplate.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdTargetTemplateGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation targetTemplate.
                Template result = apiInstance.InvitationTicketsIdTargetTemplateGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdTargetTemplateGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsidtargettemplatememberget"></a>
# **InvitationTicketsIdTargetTemplateMemberGet**
> TemplateMember InvitationTicketsIdTargetTemplateMemberGet (string id, bool? refresh = null)

Fetches belongsTo relation targetTemplateMember.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class InvitationTicketsIdTargetTemplateMemberGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var id = id_example;  // string | InvitationTicket id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation targetTemplateMember.
                TemplateMember result = apiInstance.InvitationTicketsIdTargetTemplateMemberGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsIdTargetTemplateMemberGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| InvitationTicket id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**TemplateMember**](TemplateMember.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketspatch"></a>
# **InvitationTicketsPatch**
> InvitationTicket InvitationTicketsPatch (InvitationTicket data = null)

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
    public class InvitationTicketsPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var data = new InvitationTicket(); // InvitationTicket | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                InvitationTicket result = apiInstance.InvitationTicketsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**InvitationTicket**](InvitationTicket.md)| Model instance data | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketspost"></a>
# **InvitationTicketsPost**
> InvitationTicket InvitationTicketsPost (InvitationTicket data = null)

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
    public class InvitationTicketsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var data = new InvitationTicket(); // InvitationTicket | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                InvitationTicket result = apiInstance.InvitationTicketsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**InvitationTicket**](InvitationTicket.md)| Model instance data | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsput"></a>
# **InvitationTicketsPut**
> InvitationTicket InvitationTicketsPut (InvitationTicket data = null)

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
    public class InvitationTicketsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var data = new InvitationTicket(); // InvitationTicket | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                InvitationTicket result = apiInstance.InvitationTicketsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**InvitationTicket**](InvitationTicket.md)| Model instance data | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsreplaceorcreatepost"></a>
# **InvitationTicketsReplaceOrCreatePost**
> InvitationTicket InvitationTicketsReplaceOrCreatePost (InvitationTicket data = null)

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
    public class InvitationTicketsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var data = new InvitationTicket(); // InvitationTicket | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                InvitationTicket result = apiInstance.InvitationTicketsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**InvitationTicket**](InvitationTicket.md)| Model instance data | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsupdatepost"></a>
# **InvitationTicketsUpdatePost**
> InlineResponse2002 InvitationTicketsUpdatePost (string where = null, InvitationTicket data = null)

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
    public class InvitationTicketsUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new InvitationTicket(); // InvitationTicket | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2002 result = apiInstance.InvitationTicketsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**InvitationTicket**](InvitationTicket.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationticketsupsertwithwherepost"></a>
# **InvitationTicketsUpsertWithWherePost**
> InvitationTicket InvitationTicketsUpsertWithWherePost (string where = null, InvitationTicket data = null)

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
    public class InvitationTicketsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new InvitationTicketApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new InvitationTicket(); // InvitationTicket | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                InvitationTicket result = apiInstance.InvitationTicketsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationTicketApi.InvitationTicketsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**InvitationTicket**](InvitationTicket.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InvitationTicket**](InvitationTicket.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

