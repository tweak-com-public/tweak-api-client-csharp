# TweakApi.Api.PublicVApi

All URIs are relative to *https://apistagecdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1BaseLocaleCountryCodeGet**](PublicVApi.md#v1baselocalecountrycodeget) | **GET** /v1/Base/locale/country/code | Get locale from Country Code
[**V1BaseLocaleCountryNameGet**](PublicVApi.md#v1baselocalecountrynameget) | **GET** /v1/Base/locale/country/name | Get locale from Country Name
[**V1BaseLocaleGet**](PublicVApi.md#v1baselocaleget) | **GET** /v1/Base/locale | Get locale from client IP


<a name="v1baselocalecountrycodeget"></a>
# **V1BaseLocaleCountryCodeGet**
> Object V1BaseLocaleCountryCodeGet (string countryCode)

Get locale from Country Code

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1BaseLocaleCountryCodeGetExample
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

            var apiInstance = new PublicVApi();
            var countryCode = countryCode_example;  // string | Country code

            try
            {
                // Get locale from Country Code
                Object result = apiInstance.V1BaseLocaleCountryCodeGet(countryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVApi.V1BaseLocaleCountryCodeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryCode** | **string**| Country code | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1baselocalecountrynameget"></a>
# **V1BaseLocaleCountryNameGet**
> Object V1BaseLocaleCountryNameGet (string countryName)

Get locale from Country Name

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1BaseLocaleCountryNameGetExample
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

            var apiInstance = new PublicVApi();
            var countryName = countryName_example;  // string | Country name

            try
            {
                // Get locale from Country Name
                Object result = apiInstance.V1BaseLocaleCountryNameGet(countryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVApi.V1BaseLocaleCountryNameGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **countryName** | **string**| Country name | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1baselocaleget"></a>
# **V1BaseLocaleGet**
> Object V1BaseLocaleGet ()

Get locale from client IP

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class V1BaseLocaleGetExample
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

            var apiInstance = new PublicVApi();

            try
            {
                // Get locale from client IP
                Object result = apiInstance.V1BaseLocaleGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PublicVApi.V1BaseLocaleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token), [teamKey](../README.md#teamKey)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

