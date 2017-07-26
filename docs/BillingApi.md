# TweakApi.Api.BillingApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingsChangeStreamGet**](BillingApi.md#billingschangestreamget) | **GET** /Billings/change-stream | Create a change stream.
[**BillingsChangeStreamPost**](BillingApi.md#billingschangestreampost) | **POST** /Billings/change-stream | Create a change stream.
[**BillingsCountriesGet**](BillingApi.md#billingscountriesget) | **GET** /Billings/countries | List available countries
[**BillingsIdPut**](BillingApi.md#billingsidput) | **PUT** /Billings/{id} | Replace attributes for a model instance and persist it into the data source.
[**BillingsIdReplacePost**](BillingApi.md#billingsidreplacepost) | **POST** /Billings/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**BillingsPut**](BillingApi.md#billingsput) | **PUT** /Billings | Replace an existing model instance or insert a new one into the data source.
[**BillingsReplaceOrCreatePost**](BillingApi.md#billingsreplaceorcreatepost) | **POST** /Billings/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**BillingsTaxEvidenceCountryVatGet**](BillingApi.md#billingstaxevidencecountryvatget) | **GET** /Billings/taxEvidence/{country}/{vat} | Get Tax Evidence by country and VAT
[**BillingsUpsertWithWherePost**](BillingApi.md#billingsupsertwithwherepost) | **POST** /Billings/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="billingschangestreamget"></a>
# **BillingsChangeStreamGet**
> System.IO.Stream BillingsChangeStreamGet (string options = null)

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
    public class BillingsChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.BillingsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsChangeStreamGet: " + e.Message );
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

<a name="billingschangestreampost"></a>
# **BillingsChangeStreamPost**
> System.IO.Stream BillingsChangeStreamPost (string options = null)

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
    public class BillingsChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.BillingsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsChangeStreamPost: " + e.Message );
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

<a name="billingscountriesget"></a>
# **BillingsCountriesGet**
> List<string> BillingsCountriesGet ()

List available countries

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class BillingsCountriesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();

            try
            {
                // List available countries
                List&lt;string&gt; result = apiInstance.BillingsCountriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsCountriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingsidput"></a>
# **BillingsIdPut**
> Billing BillingsIdPut (string id, Billing data = null)

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
    public class BillingsIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();
            var id = id_example;  // string | Model id
            var data = new Billing(); // Billing | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Billing result = apiInstance.BillingsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Billing**](Billing.md)| Model instance data | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingsidreplacepost"></a>
# **BillingsIdReplacePost**
> Billing BillingsIdReplacePost (string id, Billing data = null)

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
    public class BillingsIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();
            var id = id_example;  // string | Model id
            var data = new Billing(); // Billing | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Billing result = apiInstance.BillingsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Billing**](Billing.md)| Model instance data | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingsput"></a>
# **BillingsPut**
> Billing BillingsPut (Billing data = null)

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
    public class BillingsPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();
            var data = new Billing(); // Billing | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Billing result = apiInstance.BillingsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Billing**](Billing.md)| Model instance data | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingsreplaceorcreatepost"></a>
# **BillingsReplaceOrCreatePost**
> Billing BillingsReplaceOrCreatePost (Billing data = null)

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
    public class BillingsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();
            var data = new Billing(); // Billing | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Billing result = apiInstance.BillingsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Billing**](Billing.md)| Model instance data | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingstaxevidencecountryvatget"></a>
# **BillingsTaxEvidenceCountryVatGet**
> Object BillingsTaxEvidenceCountryVatGet (string country, string vat)

Get Tax Evidence by country and VAT

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class BillingsTaxEvidenceCountryVatGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();
            var country = country_example;  // string | 
            var vat = vat_example;  // string | 

            try
            {
                // Get Tax Evidence by country and VAT
                Object result = apiInstance.BillingsTaxEvidenceCountryVatGet(country, vat);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsTaxEvidenceCountryVatGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **country** | **string**|  | 
 **vat** | **string**|  | 

### Return type

**Object**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingsupsertwithwherepost"></a>
# **BillingsUpsertWithWherePost**
> Billing BillingsUpsertWithWherePost (string where = null, Billing data = null)

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
    public class BillingsUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new BillingApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Billing(); // Billing | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                Billing result = apiInstance.BillingsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Billing**](Billing.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Billing**](Billing.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

