# TweakApi.Api.PublicVTeamMemberApi

All URIs are relative to *https://apicdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1TeamMembersLoginPost**](PublicVTeamMemberApi.md#v1teammembersloginpost) | **POST** /v1/TeamMembers/login | Change portal
[**V1TeamMembersLogoutPost**](PublicVTeamMemberApi.md#v1teammemberslogoutpost) | **POST** /v1/TeamMembers/logout | Logout a TeamMember
[**V1TeamMembersPost**](PublicVTeamMemberApi.md#v1teammemberspost) | **POST** /v1/TeamMembers | Create a Member


<a name="v1teammembersloginpost"></a>
# **V1TeamMembersLoginPost**
> TeamMemberAccessToken V1TeamMembersLoginPost (string id, string portalId)

Change portal

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1TeamMembersLoginPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");
            // Configure API key authorization: teamKey
            Configuration.Default.ApiKey.Add("teamKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("teamKey", "Bearer");

            var apiInstance = new PublicVTeamMemberApi();
            var id = id_example;  // string | TeamMember id
            var portalId = portalId_example;  // string | Portal id

            try
            {
                // Change portal
                TeamMemberAccessToken result = apiInstance.V1TeamMembersLoginPost(id, portalId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVTeamMemberApi.V1TeamMembersLoginPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| TeamMember id | 
 **portalId** | **string**| Portal id | 

### Return type

[**TeamMemberAccessToken**](TeamMemberAccessToken.md)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1teammemberslogoutpost"></a>
# **V1TeamMembersLogoutPost**
> void V1TeamMembersLogoutPost ()

Logout a TeamMember

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1TeamMembersLogoutPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");
            // Configure API key authorization: teamKey
            Configuration.Default.ApiKey.Add("teamKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("teamKey", "Bearer");

            var apiInstance = new PublicVTeamMemberApi();

            try
            {
                // Logout a TeamMember
                apiInstance.V1TeamMembersLogoutPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVTeamMemberApi.V1TeamMembersLogoutPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1teammemberspost"></a>
# **V1TeamMembersPost**
> Object V1TeamMembersPost (PublicV1TeamMember data)

Create a Member

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1TeamMembersPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");
            // Configure API key authorization: teamKey
            Configuration.Default.ApiKey.Add("teamKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("teamKey", "Bearer");

            var apiInstance = new PublicVTeamMemberApi();
            var data = new PublicV1TeamMember(); // PublicV1TeamMember | Data to create Member

            try
            {
                // Create a Member
                Object result = apiInstance.V1TeamMembersPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVTeamMemberApi.V1TeamMembersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**PublicV1TeamMember**](PublicV1TeamMember.md)| Data to create Member | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

