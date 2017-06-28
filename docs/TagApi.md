# TweakApi.Api.TagApi

All URIs are relative to *https://apidevcdn.tweak.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagsChangeStreamGet**](TagApi.md#tagschangestreamget) | **GET** /Tags/change-stream | Create a change stream.
[**TagsChangeStreamPost**](TagApi.md#tagschangestreampost) | **POST** /Tags/change-stream | Create a change stream.
[**TagsCountGet**](TagApi.md#tagscountget) | **GET** /Tags/count | Count instances of the model matched by where from the data source.
[**TagsFindOneGet**](TagApi.md#tagsfindoneget) | **GET** /Tags/findOne | Find first instance of the model matched by filter from the data source.
[**TagsGet**](TagApi.md#tagsget) | **GET** /Tags | Find all instances of the model matched by filter from the data source.
[**TagsIdDelete**](TagApi.md#tagsiddelete) | **DELETE** /Tags/{id} | Delete a model instance by {{id}} from the data source.
[**TagsIdDesignsCountGet**](TagApi.md#tagsiddesignscountget) | **GET** /Tags/{id}/designs/count | Counts designs of Tag.
[**TagsIdDesignsDelete**](TagApi.md#tagsiddesignsdelete) | **DELETE** /Tags/{id}/designs | Deletes all designs of this model.
[**TagsIdDesignsFkDelete**](TagApi.md#tagsiddesignsfkdelete) | **DELETE** /Tags/{id}/designs/{fk} | Delete a related item by id for designs.
[**TagsIdDesignsFkGet**](TagApi.md#tagsiddesignsfkget) | **GET** /Tags/{id}/designs/{fk} | Find a related item by id for designs.
[**TagsIdDesignsFkPut**](TagApi.md#tagsiddesignsfkput) | **PUT** /Tags/{id}/designs/{fk} | Update a related item by id for designs.
[**TagsIdDesignsGet**](TagApi.md#tagsiddesignsget) | **GET** /Tags/{id}/designs | Queries designs of Tag.
[**TagsIdDesignsPost**](TagApi.md#tagsiddesignspost) | **POST** /Tags/{id}/designs | Creates a new instance in designs of this model.
[**TagsIdDesignsRelFkDelete**](TagApi.md#tagsiddesignsrelfkdelete) | **DELETE** /Tags/{id}/designs/rel/{fk} | Remove the designs relation to an item by id.
[**TagsIdDesignsRelFkHead**](TagApi.md#tagsiddesignsrelfkhead) | **HEAD** /Tags/{id}/designs/rel/{fk} | Check the existence of designs relation to an item by id.
[**TagsIdDesignsRelFkPut**](TagApi.md#tagsiddesignsrelfkput) | **PUT** /Tags/{id}/designs/rel/{fk} | Add a related item by id for designs.
[**TagsIdExistsGet**](TagApi.md#tagsidexistsget) | **GET** /Tags/{id}/exists | Check whether a model instance exists in the data source.
[**TagsIdGet**](TagApi.md#tagsidget) | **GET** /Tags/{id} | Find a model instance by {{id}} from the data source.
[**TagsIdHead**](TagApi.md#tagsidhead) | **HEAD** /Tags/{id} | Check whether a model instance exists in the data source.
[**TagsIdPatch**](TagApi.md#tagsidpatch) | **PATCH** /Tags/{id} | Patch attributes for a model instance and persist it into the data source.
[**TagsIdPut**](TagApi.md#tagsidput) | **PUT** /Tags/{id} | Replace attributes for a model instance and persist it into the data source.
[**TagsIdReplacePost**](TagApi.md#tagsidreplacepost) | **POST** /Tags/{id}/replace | Replace attributes for a model instance and persist it into the data source.
[**TagsIdTemplatesCountGet**](TagApi.md#tagsidtemplatescountget) | **GET** /Tags/{id}/templates/count | Counts templates of Tag.
[**TagsIdTemplatesDelete**](TagApi.md#tagsidtemplatesdelete) | **DELETE** /Tags/{id}/templates | Deletes all templates of this model.
[**TagsIdTemplatesFkDelete**](TagApi.md#tagsidtemplatesfkdelete) | **DELETE** /Tags/{id}/templates/{fk} | Delete a related item by id for templates.
[**TagsIdTemplatesFkGet**](TagApi.md#tagsidtemplatesfkget) | **GET** /Tags/{id}/templates/{fk} | Find a related item by id for templates.
[**TagsIdTemplatesFkPut**](TagApi.md#tagsidtemplatesfkput) | **PUT** /Tags/{id}/templates/{fk} | Update a related item by id for templates.
[**TagsIdTemplatesGet**](TagApi.md#tagsidtemplatesget) | **GET** /Tags/{id}/templates | Queries templates of Tag.
[**TagsIdTemplatesPost**](TagApi.md#tagsidtemplatespost) | **POST** /Tags/{id}/templates | Creates a new instance in templates of this model.
[**TagsIdTemplatesRelFkDelete**](TagApi.md#tagsidtemplatesrelfkdelete) | **DELETE** /Tags/{id}/templates/rel/{fk} | Remove the templates relation to an item by id.
[**TagsIdTemplatesRelFkHead**](TagApi.md#tagsidtemplatesrelfkhead) | **HEAD** /Tags/{id}/templates/rel/{fk} | Check the existence of templates relation to an item by id.
[**TagsIdTemplatesRelFkPut**](TagApi.md#tagsidtemplatesrelfkput) | **PUT** /Tags/{id}/templates/rel/{fk} | Add a related item by id for templates.
[**TagsPatch**](TagApi.md#tagspatch) | **PATCH** /Tags | Patch an existing model instance or insert a new one into the data source.
[**TagsPost**](TagApi.md#tagspost) | **POST** /Tags | Create a new instance of the model and persist it into the data source.
[**TagsPut**](TagApi.md#tagsput) | **PUT** /Tags | Replace an existing model instance or insert a new one into the data source.
[**TagsReplaceOrCreatePost**](TagApi.md#tagsreplaceorcreatepost) | **POST** /Tags/replaceOrCreate | Replace an existing model instance or insert a new one into the data source.
[**TagsUpdatePost**](TagApi.md#tagsupdatepost) | **POST** /Tags/update | Update instances of the model matched by {{where}} from the data source.
[**TagsUpsertWithWherePost**](TagApi.md#tagsupsertwithwherepost) | **POST** /Tags/upsertWithWhere | Update an existing model instance or insert a new one into the data source based on the where criteria.


<a name="tagschangestreamget"></a>
# **TagsChangeStreamGet**
> System.IO.Stream TagsChangeStreamGet (string options = null)

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
    public class TagsChangeStreamGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TagsChangeStreamGet(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsChangeStreamGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagschangestreampost"></a>
# **TagsChangeStreamPost**
> System.IO.Stream TagsChangeStreamPost (string options = null)

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
    public class TagsChangeStreamPostExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var options = options_example;  // string |  (optional) 

            try
            {
                // Create a change stream.
                System.IO.Stream result = apiInstance.TagsChangeStreamPost(options);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsChangeStreamPost: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagscountget"></a>
# **TagsCountGet**
> InlineResponse200 TagsCountGet (string where = null)

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
    public class TagsCountGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Count instances of the model matched by where from the data source.
                InlineResponse200 result = apiInstance.TagsCountGet(where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsCountGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsfindoneget"></a>
# **TagsFindOneGet**
> Tag TagsFindOneGet (string filter = null)

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
    public class TagsFindOneGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find first instance of the model matched by filter from the data source.
                Tag result = apiInstance.TagsFindOneGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsFindOneGet: " + e.Message );
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

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsget"></a>
# **TagsGet**
> List<Tag> TagsGet (string filter = null)

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
    public class TagsGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var filter = filter_example;  // string | Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find all instances of the model matched by filter from the data source.
                List&lt;Tag&gt; result = apiInstance.TagsGet(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsGet: " + e.Message );
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

[**List<Tag>**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddelete"></a>
# **TagsIdDelete**
> Object TagsIdDelete (string id)

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
    public class TagsIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Model id

            try
            {
                // Delete a model instance by {{id}} from the data source.
                Object result = apiInstance.TagsIdDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDelete: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignscountget"></a>
# **TagsIdDesignsCountGet**
> InlineResponse200 TagsIdDesignsCountGet (string id, string where = null)

Counts designs of Tag.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsCountGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts designs of Tag.
                InlineResponse200 result = apiInstance.TagsIdDesignsCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignsdelete"></a>
# **TagsIdDesignsDelete**
> void TagsIdDesignsDelete (string id)

Deletes all designs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id

            try
            {
                // Deletes all designs of this model.
                apiInstance.TagsIdDesignsDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignsfkdelete"></a>
# **TagsIdDesignsFkDelete**
> void TagsIdDesignsFkDelete (string id, string fk)

Delete a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsFkDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Delete a related item by id for designs.
                apiInstance.TagsIdDesignsFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for designs | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignsfkget"></a>
# **TagsIdDesignsFkGet**
> Design TagsIdDesignsFkGet (string id, string fk)

Find a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsFkGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Find a related item by id for designs.
                Design result = apiInstance.TagsIdDesignsFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for designs | 

### Return type

[**Design**](Design.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignsfkput"></a>
# **TagsIdDesignsFkPut**
> Design TagsIdDesignsFkPut (string id, string fk, Design data = null)

Update a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsFkPutExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for designs
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Update a related item by id for designs.
                Design result = apiInstance.TagsIdDesignsFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for designs | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignsget"></a>
# **TagsIdDesignsGet**
> List<Design> TagsIdDesignsGet (string id, string filter = null)

Queries designs of Tag.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries designs of Tag.
                List&lt;Design&gt; result = apiInstance.TagsIdDesignsGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Design>**](Design.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignspost"></a>
# **TagsIdDesignsPost**
> Design TagsIdDesignsPost (string id, Design data = null)

Creates a new instance in designs of this model.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsPostExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var data = new Design(); // Design |  (optional) 

            try
            {
                // Creates a new instance in designs of this model.
                Design result = apiInstance.TagsIdDesignsPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **data** | [**Design**](Design.md)|  | [optional] 

### Return type

[**Design**](Design.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignsrelfkdelete"></a>
# **TagsIdDesignsRelFkDelete**
> void TagsIdDesignsRelFkDelete (string id, string fk)

Remove the designs relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsRelFkDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Remove the designs relation to an item by id.
                apiInstance.TagsIdDesignsRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for designs | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignsrelfkhead"></a>
# **TagsIdDesignsRelFkHead**
> bool? TagsIdDesignsRelFkHead (string id, string fk)

Check the existence of designs relation to an item by id.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsRelFkHeadExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for designs

            try
            {
                // Check the existence of designs relation to an item by id.
                bool? result = apiInstance.TagsIdDesignsRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for designs | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsiddesignsrelfkput"></a>
# **TagsIdDesignsRelFkPut**
> DesignTag TagsIdDesignsRelFkPut (string id, string fk, DesignTag data = null)

Add a related item by id for designs.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdDesignsRelFkPutExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for designs
            var data = new DesignTag(); // DesignTag |  (optional) 

            try
            {
                // Add a related item by id for designs.
                DesignTag result = apiInstance.TagsIdDesignsRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdDesignsRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for designs | 
 **data** | [**DesignTag**](DesignTag.md)|  | [optional] 

### Return type

[**DesignTag**](DesignTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidexistsget"></a>
# **TagsIdExistsGet**
> InlineResponse2002 TagsIdExistsGet (string id)

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
    public class TagsIdExistsGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TagsIdExistsGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdExistsGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidget"></a>
# **TagsIdGet**
> Tag TagsIdGet (string id, string filter = null)

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
    public class TagsIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Model id
            var filter = filter_example;  // string | Filter defining fields and include - must be a JSON-encoded string ({\"something\":\"value\"}) (optional) 

            try
            {
                // Find a model instance by {{id}} from the data source.
                Tag result = apiInstance.TagsIdGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdGet: " + e.Message );
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

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidhead"></a>
# **TagsIdHead**
> InlineResponse2002 TagsIdHead (string id)

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
    public class TagsIdHeadExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Model id

            try
            {
                // Check whether a model instance exists in the data source.
                InlineResponse2002 result = apiInstance.TagsIdHead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdHead: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidpatch"></a>
# **TagsIdPatch**
> Tag TagsIdPatch (string id, Tag data = null)

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
    public class TagsIdPatchExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var data = new Tag(); // Tag | An object of model property name/value pairs (optional) 

            try
            {
                // Patch attributes for a model instance and persist it into the data source.
                Tag result = apiInstance.TagsIdPatch(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **data** | [**Tag**](Tag.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidput"></a>
# **TagsIdPut**
> Tag TagsIdPut (string id, Tag data = null)

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
    public class TagsIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Model id
            var data = new Tag(); // Tag | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Tag result = apiInstance.TagsIdPut(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Tag**](Tag.md)| Model instance data | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidreplacepost"></a>
# **TagsIdReplacePost**
> Tag TagsIdReplacePost (string id, Tag data = null)

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
    public class TagsIdReplacePostExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Model id
            var data = new Tag(); // Tag | Model instance data (optional) 

            try
            {
                // Replace attributes for a model instance and persist it into the data source.
                Tag result = apiInstance.TagsIdReplacePost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdReplacePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Model id | 
 **data** | [**Tag**](Tag.md)| Model instance data | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatescountget"></a>
# **TagsIdTemplatesCountGet**
> InlineResponse200 TagsIdTemplatesCountGet (string id, string where = null)

Counts templates of Tag.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdTemplatesCountGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var where = where_example;  // string | Criteria to match model instances (optional) 

            try
            {
                // Counts templates of Tag.
                InlineResponse200 result = apiInstance.TagsIdTemplatesCountGet(id, where);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesCountGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **where** | **string**| Criteria to match model instances | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatesdelete"></a>
# **TagsIdTemplatesDelete**
> void TagsIdTemplatesDelete (string id)

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
    public class TagsIdTemplatesDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id

            try
            {
                // Deletes all templates of this model.
                apiInstance.TagsIdTemplatesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatesfkdelete"></a>
# **TagsIdTemplatesFkDelete**
> void TagsIdTemplatesFkDelete (string id, string fk)

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
    public class TagsIdTemplatesFkDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Delete a related item by id for templates.
                apiInstance.TagsIdTemplatesFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatesfkget"></a>
# **TagsIdTemplatesFkGet**
> Template TagsIdTemplatesFkGet (string id, string fk)

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
    public class TagsIdTemplatesFkGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Find a related item by id for templates.
                Template result = apiInstance.TagsIdTemplatesFkGet(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesFkGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

[**Template**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatesfkput"></a>
# **TagsIdTemplatesFkPut**
> Template TagsIdTemplatesFkPut (string id, string fk, Template data = null)

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
    public class TagsIdTemplatesFkPutExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Update a related item by id for templates.
                Template result = apiInstance.TagsIdTemplatesFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for templates | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatesget"></a>
# **TagsIdTemplatesGet**
> List<Template> TagsIdTemplatesGet (string id, string filter = null)

Queries templates of Tag.

### Example
```csharp
using System;
using System.Diagnostics;
using TweakApi.Api;
using TweakApi.Client;
using TweakApi.Model;

namespace Example
{
    public class TagsIdTemplatesGetExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var filter = filter_example;  // string |  (optional) 

            try
            {
                // Queries templates of Tag.
                List&lt;Template&gt; result = apiInstance.TagsIdTemplatesGet(id, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **filter** | **string**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatespost"></a>
# **TagsIdTemplatesPost**
> Template TagsIdTemplatesPost (string id, Template data = null)

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
    public class TagsIdTemplatesPostExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var data = new Template(); // Template |  (optional) 

            try
            {
                // Creates a new instance in templates of this model.
                Template result = apiInstance.TagsIdTemplatesPost(id, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **data** | [**Template**](Template.md)|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatesrelfkdelete"></a>
# **TagsIdTemplatesRelFkDelete**
> void TagsIdTemplatesRelFkDelete (string id, string fk)

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
    public class TagsIdTemplatesRelFkDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Remove the templates relation to an item by id.
                apiInstance.TagsIdTemplatesRelFkDelete(id, fk);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesRelFkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatesrelfkhead"></a>
# **TagsIdTemplatesRelFkHead**
> bool? TagsIdTemplatesRelFkHead (string id, string fk)

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
    public class TagsIdTemplatesRelFkHeadExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for templates

            try
            {
                // Check the existence of templates relation to an item by id.
                bool? result = apiInstance.TagsIdTemplatesRelFkHead(id, fk);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesRelFkHead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for templates | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsidtemplatesrelfkput"></a>
# **TagsIdTemplatesRelFkPut**
> TemplateTag TagsIdTemplatesRelFkPut (string id, string fk, TemplateTag data = null)

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
    public class TagsIdTemplatesRelFkPutExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var id = id_example;  // string | Tag id
            var fk = fk_example;  // string | Foreign key for templates
            var data = new TemplateTag(); // TemplateTag |  (optional) 

            try
            {
                // Add a related item by id for templates.
                TemplateTag result = apiInstance.TagsIdTemplatesRelFkPut(id, fk, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsIdTemplatesRelFkPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tag id | 
 **fk** | **string**| Foreign key for templates | 
 **data** | [**TemplateTag**](TemplateTag.md)|  | [optional] 

### Return type

[**TemplateTag**](TemplateTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagspatch"></a>
# **TagsPatch**
> Tag TagsPatch (Tag data = null)

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
    public class TagsPatchExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var data = new Tag(); // Tag | Model instance data (optional) 

            try
            {
                // Patch an existing model instance or insert a new one into the data source.
                Tag result = apiInstance.TagsPatch(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Tag**](Tag.md)| Model instance data | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagspost"></a>
# **TagsPost**
> Tag TagsPost (Tag data = null)

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
    public class TagsPostExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var data = new Tag(); // Tag | Model instance data (optional) 

            try
            {
                // Create a new instance of the model and persist it into the data source.
                Tag result = apiInstance.TagsPost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Tag**](Tag.md)| Model instance data | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsput"></a>
# **TagsPut**
> Tag TagsPut (Tag data = null)

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
    public class TagsPutExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var data = new Tag(); // Tag | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Tag result = apiInstance.TagsPut(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Tag**](Tag.md)| Model instance data | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsreplaceorcreatepost"></a>
# **TagsReplaceOrCreatePost**
> Tag TagsReplaceOrCreatePost (Tag data = null)

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
    public class TagsReplaceOrCreatePostExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var data = new Tag(); // Tag | Model instance data (optional) 

            try
            {
                // Replace an existing model instance or insert a new one into the data source.
                Tag result = apiInstance.TagsReplaceOrCreatePost(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsReplaceOrCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Tag**](Tag.md)| Model instance data | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsupdatepost"></a>
# **TagsUpdatePost**
> InlineResponse2001 TagsUpdatePost (string where = null, Tag data = null)

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
    public class TagsUpdatePostExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Tag(); // Tag | An object of model property name/value pairs (optional) 

            try
            {
                // Update instances of the model matched by {{where}} from the data source.
                InlineResponse2001 result = apiInstance.TagsUpdatePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsUpdatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Tag**](Tag.md)| An object of model property name/value pairs | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsupsertwithwherepost"></a>
# **TagsUpsertWithWherePost**
> Tag TagsUpsertWithWherePost (string where = null, Tag data = null)

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
    public class TagsUpsertWithWherePostExample
    {
        public void main()
        {
            
            var apiInstance = new TagApi();
            var where = where_example;  // string | Criteria to match model instances (optional) 
            var data = new Tag(); // Tag | An object of model property name/value pairs (optional) 

            try
            {
                // Update an existing model instance or insert a new one into the data source based on the where criteria.
                Tag result = apiInstance.TagsUpsertWithWherePost(where, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagApi.TagsUpsertWithWherePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **where** | **string**| Criteria to match model instances | [optional] 
 **data** | [**Tag**](Tag.md)| An object of model property name/value pairs | [optional] 

### Return type

[**Tag**](Tag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml, application/javascript, text/javascript

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

