# TweakApi.Api.ProductSizeApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductSizesChangeStreamGet**](ProductSizeApi.md#productsizeschangestreamget) | **GET** /ProductSizes/change-stream | Create a change stream.
[**ProductSizesChangeStreamPost**](ProductSizeApi.md#productsizeschangestreampost) | **POST** /ProductSizes/change-stream | Create a change stream.
[**ProductSizesCountGet**](ProductSizeApi.md#productsizescountget) | **GET** /ProductSizes/count | Count instances of the model matched by where from the data source.
[**ProductSizesFindOneGet**](ProductSizeApi.md#productsizesfindoneget) | **GET** /ProductSizes/findOne | Find first instance of the model matched by filter from the data source.
[**ProductSizesGet**](ProductSizeApi.md#productsizesget) | **GET** /ProductSizes | Find all instances of the model matched by filter from the data source.
[**ProductSizesIdDelete**](ProductSizeApi.md#productsizesiddelete) | **DELETE** /ProductSizes/{id} | Delete a model instance by {{id}} from the data source.
[**ProductSizesIdExistsGet**](ProductSizeApi.md#productsizesidexistsget) | **GET** /ProductSizes/{id}/exists | Check whether a model instance exists in the data source.
[**ProductSizesIdGet**](ProductSizeApi.md#productsizesidget) | **GET** /ProductSizes/{id} | Find a model instance by {{id}} from the data source.
[**ProductSizesIdHead**](ProductSizeApi.md#productsizesidhead) | **HEAD** /ProductSizes/{id} | Check whether a model instance exists in the data source.
[**ProductSizesIdMaterialsCountGet**](ProductSizeApi.md#productsizesidmaterialscountget) | **GET** /ProductSizes/{id}/materials/count | Counts materials of ProductSize.
[**ProductSizesIdMaterialsDelete**](ProductSizeApi.md#productsizesidmaterialsdelete) | **DELETE** /ProductSizes/{id}/materials | Deletes all materials of this model.
[**ProductSizesIdMaterialsFkDelete**](ProductSizeApi.md#productsizesidmaterialsfkdelete) | **DELETE** /ProductSizes/{id}/materials/{fk} | Delete a related item by id for materials.
[**ProductSizesIdMaterialsFkGet**](ProductSizeApi.md#productsizesidmaterialsfkget) | **GET** /ProductSizes/{id}/materials/{fk} | Find a related item by id for materials.
[**ProductSizesIdMaterialsFkPut**](ProductSizeApi.md#productsizesidmaterialsfkput) | **PUT** /ProductSizes/{id}/materials/{fk} | Update a related item by id for materials.
[**ProductSizesIdMaterialsGet**](ProductSizeApi.md#productsizesidmaterialsget) | **GET** /ProductSizes/{id}/materials | Queries materials of ProductSize.
[**ProductSizesIdMaterialsPost**](ProductSizeApi.md#productsizesidmaterialspost) | **POST** /ProductSizes/{id}/materials | Creates a new instance in materials of this model.
[**ProductSizesIdMaterialsRelFkDelete**](ProductSizeApi.md#productsizesidmaterialsrelfkdelete) | **DELETE** /ProductSizes/{id}/materials/rel/{fk} | Remove the materials relation to an item by id.
[**ProductSizesIdMaterialsRelFkHead**](ProductSizeApi.md#productsizesidmaterialsrelfkhead) | **HEAD** /ProductSizes/{id}/materials/rel/{fk} | Check the existence of materials relation to an item by id.
[**ProductSizesIdMaterialsRelFkPut**](ProductSizeApi.md#productsizesidmaterialsrelfkput) | **PUT** /ProductSizes/{id}/materials/rel/{fk} | Add a related item by id for materials.
[**ProductSizesIdPatch**](ProductSizeApi.md#productsizesidpatch) | **PATCH** /ProductSizes/{id} | Patch attributes for a model instance and persist it into the data source.
[**ProductSizesIdPdfColorProfileGet**](ProductSizeApi.md#productsizesidpdfcolorprofileget) | **GET** /ProductSizes/{id}/pdfColorProfile | Fetches belongsTo relation pdfColorProfile.
[**ProductSizesIdProductsCountGet**](ProductSizeApi.md#productsizesidproductscountget) | **GET** /ProductSizes/{id}/products/count | Counts products of ProductSize.
[**ProductSizesIdProductsDelete**](ProductSizeApi.md#productsizesidproductsdelete) | **DELETE** /ProductSizes/{id}/products | Deletes all products of this model.
[**ProductSizesIdProductsFkDelete**](ProductSizeApi.md#productsizesidproductsfkdelete) | **DELETE** /ProductSizes/{id}/products/{fk} | Delete a related item by id for products.
[**ProductSizesIdProductsFkGet**](ProductSizeApi.md#productsizesidproductsfkget) | **GET** /ProductSizes/{id}/products/{fk} | Find a related item by id for products.
[**ProductSizesIdProductsFkPut**](ProductSizeApi.md#productsizesidproductsfkput) | **PUT** /ProductSizes/{id}/products/{fk} | Update a related item by id for products.
[**ProductSizesIdProductsGet**](ProductSizeApi.md#productsizesidproductsget) | **GET** /ProductSizes/{id}/products | Queries products of ProductSize.
[**ProductSizesIdProductsPost**](ProductSizeApi.md#productsizesidproductspost) | **POST** /ProductSizes/{id}/products | Creates a new instance in products of this model.
[**ProductSizesIdPut**](ProductSizeApi.md#productsizesidput) | **PUT** /ProductSizes/{id} | Replace attributes for a model instance and persist it into the data source.
[**ProductSizesIdReplacePost**](ProductSizeApi.md#productsizesidreplacepost) | **POST** /ProductSizes/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**ProductSizesIdSizeMaterialsCountGet**](ProductSizeApi.md#productsizesidsizematerialscountget) | **GET** /ProductSizes/{id}/sizeMaterials/count | Counts sizeMaterials of ProductSize.
[**ProductSizesIdSizeMaterialsDelete**](ProductSizeApi.md#productsizesidsizematerialsdelete) | **DELETE** /ProductSizes/{id}/sizeMaterials | Deletes all sizeMaterials of this model.
[**ProductSizesIdSizeMaterialsFkDelete**](ProductSizeApi.md#productsizesidsizematerialsfkdelete) | **DELETE** /ProductSizes/{id}/sizeMaterials/{fk} | Delete a related item by id for sizeMaterials.
[**ProductSizesIdSizeMaterialsFkGet**](ProductSizeApi.md#productsizesidsizematerialsfkget) | **GET** /ProductSizes/{id}/sizeMaterials/{fk} | Find a related item by id for sizeMaterials.
[**ProductSizesIdSizeMaterialsFkPut**](ProductSizeApi.md#productsizesidsizematerialsfkput) | **PUT** /ProductSizes/{id}/sizeMaterials/{fk} | Update a related item by id for sizeMaterials.
[**ProductSizesIdSizeMaterialsGet**](ProductSizeApi.md#productsizesidsizematerialsget) | **GET** /ProductSizes/{id}/sizeMaterials | Queries sizeMaterials of ProductSize.
[**ProductSizesIdSizeMaterialsPost**](ProductSizeApi.md#productsizesidsizematerialspost) | **POST** /ProductSizes/{id}/sizeMaterials | Creates a new instance in sizeMaterials of this model.
[**ProductSizesIdTypeGet**](ProductSizeApi.md#productsizesidtypeget) | **GET** /ProductSizes/{id}/type | Fetches belongsTo relation type.
[**ProductSizesPatch**](ProductSizeApi.md#productsizespatch) | **PATCH** /ProductSizes | Patch an existing model instance or insert a new one into the data source.
[**ProductSizesPost**](ProductSizeApi.md#productsizespost) | **POST** /ProductSizes | Create a new instance of the model and persist it into the data source.
[**ProductSizesPut**](ProductSizeApi.md#productsizesput) | **PUT** /ProductSizes | Replace an existing model instance or insert a new one into the data source.
[**ProductSizesReplaceOrCreatePost**](ProductSizeApi.md#productsizesreplaceorcreatepost) | **POST** /ProductSizes/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**ProductSizesUpdatePost**](ProductSizeApi.md#productsizesupdatepost) | **POST** /ProductSizes/update | Update instances of the model matched by {{where}} from the data source.
[**ProductSizesUpsertWithWherePost**](ProductSizeApi.md#productsizesupsertwithwherepost) | **POST** /ProductSizes/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="productsizeschangestreamget"></a>
# **ProductSizesChangeStreamGet**
> System.IO.Stream ProductSizesChangeStreamGet (string options = null)

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
    public class ProductSizesChangeStreamGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.ProductSizesChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesChangeStreamGet: " + e.Message );
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

<a name="productsizeschangestreampost"></a>
# **ProductSizesChangeStreamPost**
> System.IO.Stream ProductSizesChangeStreamPost (string options = null)

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
    public class ProductSizesChangeStreamPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.ProductSizesChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesChangeStreamPost: " + e.Message );
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

<a name="productsizescountget"></a>
# **ProductSizesCountGet**
> InlineResponse2001 ProductSizesCountGet (string where = null)

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
    public class ProductSizesCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse2001 result = apiInstance.ProductSizesCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesCountGet: " + e.Message );
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

<a name="productsizesfindoneget"></a>
# **ProductSizesFindOneGet**
> ProductSize ProductSizesFindOneGet (string filter = null)

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
    public class ProductSizesFindOneGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                ProductSize result = apiInstance.ProductSizesFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesFindOneGet: " + e.Message );
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

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesget"></a>
# **ProductSizesGet**
> List<ProductSize> ProductSizesGet (string filter = null)

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
    public class ProductSizesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;ProductSize&gt; result = apiInstance.ProductSizesGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesGet: " + e.Message );
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

[**List<ProductSize>**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesiddelete"></a>
# **ProductSizesIdDelete**
> Object ProductSizesIdDelete (string id)

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
    public class ProductSizesIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.ProductSizesIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdDelete: " + e.Message );
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

<a name="productsizesidexistsget"></a>
# **ProductSizesIdExistsGet**
> InlineResponse2002 ProductSizesIdExistsGet (string id)

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
    public class ProductSizesIdExistsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.ProductSizesIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdExistsGet: " + e.Message );
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

<a name="productsizesidget"></a>
# **ProductSizesIdGet**
> ProductSize ProductSizesIdGet (string id, string filter = null)

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
    public class ProductSizesIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                ProductSize result = apiInstance.ProductSizesIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdGet: " + e.Message );
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

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidhead"></a>
# **ProductSizesIdHead**
> InlineResponse2002 ProductSizesIdHead (string id)

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
    public class ProductSizesIdHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.ProductSizesIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdHead: " + e.Message );
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

<a name="productsizesidmaterialscountget"></a>
# **ProductSizesIdMaterialsCountGet**
> InlineResponse2001 ProductSizesIdMaterialsCountGet (string id, string where = null)

Counts materials of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts materials of ProductSize.
                InlineResponse2001 result = apiInstance.ProductSizesIdMaterialsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialsdelete"></a>
# **ProductSizesIdMaterialsDelete**
> void ProductSizesIdMaterialsDelete (string id)

Deletes all materials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id

            try
            {
                // Deletes all materials of this model.
                apiInstance.ProductSizesIdMaterialsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialsfkdelete"></a>
# **ProductSizesIdMaterialsFkDelete**
> void ProductSizesIdMaterialsFkDelete (string id, string fk)

Delete a related item by id for materials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for materials

            try
            {
                // Delete a related item by id for materials.
                apiInstance.ProductSizesIdMaterialsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for materials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialsfkget"></a>
# **ProductSizesIdMaterialsFkGet**
> ProductMaterial ProductSizesIdMaterialsFkGet (string id, string fk)

Find a related item by id for materials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for materials

            try
            {
                // Find a related item by id for materials.
                ProductMaterial result = apiInstance.ProductSizesIdMaterialsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for materials | 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialsfkput"></a>
# **ProductSizesIdMaterialsFkPut**
> ProductMaterial ProductSizesIdMaterialsFkPut (string id, string fk, ProductMaterial data = null)

Update a related item by id for materials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for materials
            var data = new ProductMaterial(); // ProductMaterial |  (optional) 

            try
            {
                // Update a related item by id for materials.
                ProductMaterial result = apiInstance.ProductSizesIdMaterialsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for materials | 
 **data** | [**ProductMaterial**](ProductMaterial.md)|  | [optional] 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialsget"></a>
# **ProductSizesIdMaterialsGet**
> List<ProductMaterial> ProductSizesIdMaterialsGet (string id, string filter = null)

Queries materials of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries materials of ProductSize.
                List&lt;ProductMaterial&gt; result = apiInstance.ProductSizesIdMaterialsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductMaterial>**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialspost"></a>
# **ProductSizesIdMaterialsPost**
> ProductMaterial ProductSizesIdMaterialsPost (string id, ProductMaterial data = null)

Creates a new instance in materials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var data = new ProductMaterial(); // ProductMaterial |  (optional) 

            try
            {
                // Creates a new instance in materials of this model.
                ProductMaterial result = apiInstance.ProductSizesIdMaterialsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **data** | [**ProductMaterial**](ProductMaterial.md)|  | [optional] 

### Return type

[**ProductMaterial**](ProductMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialsrelfkdelete"></a>
# **ProductSizesIdMaterialsRelFkDelete**
> void ProductSizesIdMaterialsRelFkDelete (string id, string fk)

Remove the materials relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsRelFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for materials

            try
            {
                // Remove the materials relation to an item by id.
                apiInstance.ProductSizesIdMaterialsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for materials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialsrelfkhead"></a>
# **ProductSizesIdMaterialsRelFkHead**
> bool? ProductSizesIdMaterialsRelFkHead (string id, string fk)

Check the existence of materials relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsRelFkHeadExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for materials

            try
            {
                // Check the existence of materials relation to an item by id.
                bool? result = apiInstance.ProductSizesIdMaterialsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for materials | 

### Return type

**bool?**

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidmaterialsrelfkput"></a>
# **ProductSizesIdMaterialsRelFkPut**
> ProductSizeMaterial ProductSizesIdMaterialsRelFkPut (string id, string fk, ProductSizeMaterial data = null)

Add a related item by id for materials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdMaterialsRelFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for materials
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Add a related item by id for materials.
                ProductSizeMaterial result = apiInstance.ProductSizesIdMaterialsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdMaterialsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for materials | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidpatch"></a>
# **ProductSizesIdPatch**
> ProductSize ProductSizesIdPatch (string id, ProductSize data = null)

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
    public class ProductSizesIdPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var data = new ProductSize(); // ProductSize | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                ProductSize result = apiInstance.ProductSizesIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **data** | [**ProductSize**](ProductSize.md)| An object of model property name/value pairs | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidpdfcolorprofileget"></a>
# **ProductSizesIdPdfColorProfileGet**
> ProductPdfColorProfile ProductSizesIdPdfColorProfileGet (string id, bool? refresh = null)

Fetches belongsTo relation pdfColorProfile.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdPdfColorProfileGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation pdfColorProfile.
                ProductPdfColorProfile result = apiInstance.ProductSizesIdPdfColorProfileGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdPdfColorProfileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductPdfColorProfile**](ProductPdfColorProfile.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidproductscountget"></a>
# **ProductSizesIdProductsCountGet**
> InlineResponse2001 ProductSizesIdProductsCountGet (string id, string where = null)

Counts products of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdProductsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts products of ProductSize.
                InlineResponse2001 result = apiInstance.ProductSizesIdProductsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdProductsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidproductsdelete"></a>
# **ProductSizesIdProductsDelete**
> void ProductSizesIdProductsDelete (string id)

Deletes all products of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdProductsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id

            try
            {
                // Deletes all products of this model.
                apiInstance.ProductSizesIdProductsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdProductsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidproductsfkdelete"></a>
# **ProductSizesIdProductsFkDelete**
> void ProductSizesIdProductsFkDelete (string id, string fk)

Delete a related item by id for products.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdProductsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for products

            try
            {
                // Delete a related item by id for products.
                apiInstance.ProductSizesIdProductsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdProductsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for products | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidproductsfkget"></a>
# **ProductSizesIdProductsFkGet**
> Product ProductSizesIdProductsFkGet (string id, string fk)

Find a related item by id for products.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdProductsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for products

            try
            {
                // Find a related item by id for products.
                Product result = apiInstance.ProductSizesIdProductsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdProductsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for products | 

### Return type

[**Product**](Product.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidproductsfkput"></a>
# **ProductSizesIdProductsFkPut**
> Product ProductSizesIdProductsFkPut (string id, string fk, Product data = null)

Update a related item by id for products.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdProductsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for products
            var data = new Product(); // Product |  (optional) 

            try
            {
                // Update a related item by id for products.
                Product result = apiInstance.ProductSizesIdProductsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdProductsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for products | 
 **data** | [**Product**](Product.md)|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidproductsget"></a>
# **ProductSizesIdProductsGet**
> List<Product> ProductSizesIdProductsGet (string id, string filter = null)

Queries products of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdProductsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries products of ProductSize.
                List&lt;Product&gt; result = apiInstance.ProductSizesIdProductsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdProductsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Product>**](Product.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidproductspost"></a>
# **ProductSizesIdProductsPost**
> Product ProductSizesIdProductsPost (string id, Product data = null)

Creates a new instance in products of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdProductsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var data = new Product(); // Product |  (optional) 

            try
            {
                // Creates a new instance in products of this model.
                Product result = apiInstance.ProductSizesIdProductsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdProductsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **data** | [**Product**](Product.md)|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidput"></a>
# **ProductSizesIdPut**
> ProductSize ProductSizesIdPut (string id, ProductSize data = null)

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
    public class ProductSizesIdPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | Model id
            var data = new ProductSize(); // ProductSize | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                ProductSize result = apiInstance.ProductSizesIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**ProductSize**](ProductSize.md)| Model instance data | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidreplacepost"></a>
# **ProductSizesIdReplacePost**
> ProductSize ProductSizesIdReplacePost (string id, ProductSize data = null)

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
    public class ProductSizesIdReplacePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | Model id
            var data = new ProductSize(); // ProductSize | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                ProductSize result = apiInstance.ProductSizesIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**ProductSize**](ProductSize.md)| Model instance data | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidsizematerialscountget"></a>
# **ProductSizesIdSizeMaterialsCountGet**
> InlineResponse2001 ProductSizesIdSizeMaterialsCountGet (string id, string where = null)

Counts sizeMaterials of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdSizeMaterialsCountGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts sizeMaterials of ProductSize.
                InlineResponse2001 result = apiInstance.ProductSizesIdSizeMaterialsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdSizeMaterialsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidsizematerialsdelete"></a>
# **ProductSizesIdSizeMaterialsDelete**
> void ProductSizesIdSizeMaterialsDelete (string id)

Deletes all sizeMaterials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdSizeMaterialsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id

            try
            {
                // Deletes all sizeMaterials of this model.
                apiInstance.ProductSizesIdSizeMaterialsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdSizeMaterialsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidsizematerialsfkdelete"></a>
# **ProductSizesIdSizeMaterialsFkDelete**
> void ProductSizesIdSizeMaterialsFkDelete (string id, string fk)

Delete a related item by id for sizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdSizeMaterialsFkDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for sizeMaterials

            try
            {
                // Delete a related item by id for sizeMaterials.
                apiInstance.ProductSizesIdSizeMaterialsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdSizeMaterialsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for sizeMaterials | 

### Return type

void (empty response body)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidsizematerialsfkget"></a>
# **ProductSizesIdSizeMaterialsFkGet**
> ProductSizeMaterial ProductSizesIdSizeMaterialsFkGet (string id, string fk)

Find a related item by id for sizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdSizeMaterialsFkGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for sizeMaterials

            try
            {
                // Find a related item by id for sizeMaterials.
                ProductSizeMaterial result = apiInstance.ProductSizesIdSizeMaterialsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdSizeMaterialsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for sizeMaterials | 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidsizematerialsfkput"></a>
# **ProductSizesIdSizeMaterialsFkPut**
> ProductSizeMaterial ProductSizesIdSizeMaterialsFkPut (string id, string fk, ProductSizeMaterial data = null)

Update a related item by id for sizeMaterials.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdSizeMaterialsFkPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var fk = fk_example;  // string | Foreign key for sizeMaterials
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Update a related item by id for sizeMaterials.
                ProductSizeMaterial result = apiInstance.ProductSizesIdSizeMaterialsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdSizeMaterialsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **fk** | **string**| Foreign key for sizeMaterials | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidsizematerialsget"></a>
# **ProductSizesIdSizeMaterialsGet**
> List<ProductSizeMaterial> ProductSizesIdSizeMaterialsGet (string id, string filter = null)

Queries sizeMaterials of ProductSize.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdSizeMaterialsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries sizeMaterials of ProductSize.
                List&lt;ProductSizeMaterial&gt; result = apiInstance.ProductSizesIdSizeMaterialsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdSizeMaterialsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<ProductSizeMaterial>**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidsizematerialspost"></a>
# **ProductSizesIdSizeMaterialsPost**
> ProductSizeMaterial ProductSizesIdSizeMaterialsPost (string id, ProductSizeMaterial data = null)

Creates a new instance in sizeMaterials of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdSizeMaterialsPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var data = new ProductSizeMaterial(); // ProductSizeMaterial |  (optional) 

            try
            {
                // Creates a new instance in sizeMaterials of this model.
                ProductSizeMaterial result = apiInstance.ProductSizesIdSizeMaterialsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdSizeMaterialsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **data** | [**ProductSizeMaterial**](ProductSizeMaterial.md)|  | [optional] 

### Return type

[**ProductSizeMaterial**](ProductSizeMaterial.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesidtypeget"></a>
# **ProductSizesIdTypeGet**
> ProductType ProductSizesIdTypeGet (string id, bool? refresh = null)

Fetches belongsTo relation type.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class ProductSizesIdTypeGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var id = id_example;  // string | ProductSize id
            var refresh = true;  // bool? |  (optional) 

            try
            {
                // Fetches belongsTo relation type.
                ProductType result = apiInstance.ProductSizesIdTypeGet(id, refresh);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesIdTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ProductSize id | 
 **refresh** | **bool?**|  | [optional] 

### Return type

[**ProductType**](ProductType.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizespatch"></a>
# **ProductSizesPatch**
> ProductSize ProductSizesPatch (ProductSize data = null)

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
    public class ProductSizesPatchExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var data = new ProductSize(); // ProductSize | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                ProductSize result = apiInstance.ProductSizesPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ProductSize**](ProductSize.md)| Model instance data | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizespost"></a>
# **ProductSizesPost**
> ProductSize ProductSizesPost (ProductSize data = null)

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
    public class ProductSizesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var data = new ProductSize(); // ProductSize | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                ProductSize result = apiInstance.ProductSizesPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ProductSize**](ProductSize.md)| Model instance data | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesput"></a>
# **ProductSizesPut**
> ProductSize ProductSizesPut (ProductSize data = null)

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
    public class ProductSizesPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var data = new ProductSize(); // ProductSize | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                ProductSize result = apiInstance.ProductSizesPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ProductSize**](ProductSize.md)| Model instance data | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesreplaceorcreatepost"></a>
# **ProductSizesReplaceOrCreatePost**
> ProductSize ProductSizesReplaceOrCreatePost (ProductSize data = null)

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
    public class ProductSizesReplaceOrCreatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var data = new ProductSize(); // ProductSize | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                ProductSize result = apiInstance.ProductSizesReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**ProductSize**](ProductSize.md)| Model instance data | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesupdatepost"></a>
# **ProductSizesUpdatePost**
> InlineResponse2003 ProductSizesUpdatePost (string where = null, ProductSize data = null)

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
    public class ProductSizesUpdatePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new ProductSize(); // ProductSize | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2003 result = apiInstance.ProductSizesUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**ProductSize**](ProductSize.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsizesupsertwithwherepost"></a>
# **ProductSizesUpsertWithWherePost**
> ProductSize ProductSizesUpsertWithWherePost (string where = null, ProductSize data = null)

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
    public class ProductSizesUpsertWithWherePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new ProductSizeApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new ProductSize(); // ProductSize | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                ProductSize result = apiInstance.ProductSizesUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductSizeApi.ProductSizesUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**ProductSize**](ProductSize.md)| An object of model property name/value pairs | [optional] 

### Return type

[**ProductSize**](ProductSize.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

