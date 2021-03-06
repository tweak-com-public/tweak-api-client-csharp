/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-beta.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using TweakApi.Client;
using TweakApi.Model;

namespace TweakApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBuilderAssetUrlApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Design Id</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 BuilderAssetUrlsDesignsIdGet (string id);

        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Design Id</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> BuilderAssetUrlsDesignsIdGetWithHttpInfo (string id);
        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Template Id</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 BuilderAssetUrlsTemplatesIdGet (string id);

        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Template Id</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> BuilderAssetUrlsTemplatesIdGetWithHttpInfo (string id);
        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Tweak Template Id</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 BuilderAssetUrlsTweakTemplatesIdGet (string id);

        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Tweak Template Id</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> BuilderAssetUrlsTweakTemplatesIdGetWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Design Id</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> BuilderAssetUrlsDesignsIdGetAsync (string id);

        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Design Id</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> BuilderAssetUrlsDesignsIdGetAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Template Id</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> BuilderAssetUrlsTemplatesIdGetAsync (string id);

        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Template Id</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> BuilderAssetUrlsTemplatesIdGetAsyncWithHttpInfo (string id);
        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Tweak Template Id</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> BuilderAssetUrlsTweakTemplatesIdGetAsync (string id);

        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Tweak Template Id</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> BuilderAssetUrlsTweakTemplatesIdGetAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BuilderAssetUrlApi : IBuilderAssetUrlApi
    {
        private TweakApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderAssetUrlApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BuilderAssetUrlApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = TweakApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderAssetUrlApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BuilderAssetUrlApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = TweakApi.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TweakApi.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Design Id</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 BuilderAssetUrlsDesignsIdGet (string id)
        {
             ApiResponse<InlineResponse200> localVarResponse = BuilderAssetUrlsDesignsIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Design Id</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > BuilderAssetUrlsDesignsIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BuilderAssetUrlApi->BuilderAssetUrlsDesignsIdGet");

            var localVarPath = "/BuilderAsset/urls/designs/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml", 
                "text/xml", 
                "application/javascript", 
                "text/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuilderAssetUrlsDesignsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Design Id</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> BuilderAssetUrlsDesignsIdGetAsync (string id)
        {
             ApiResponse<InlineResponse200> localVarResponse = await BuilderAssetUrlsDesignsIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Design Id</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> BuilderAssetUrlsDesignsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BuilderAssetUrlApi->BuilderAssetUrlsDesignsIdGet");

            var localVarPath = "/BuilderAsset/urls/designs/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml", 
                "text/xml", 
                "application/javascript", 
                "text/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuilderAssetUrlsDesignsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Template Id</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 BuilderAssetUrlsTemplatesIdGet (string id)
        {
             ApiResponse<InlineResponse200> localVarResponse = BuilderAssetUrlsTemplatesIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Template Id</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > BuilderAssetUrlsTemplatesIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BuilderAssetUrlApi->BuilderAssetUrlsTemplatesIdGet");

            var localVarPath = "/BuilderAsset/urls/templates/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml", 
                "text/xml", 
                "application/javascript", 
                "text/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuilderAssetUrlsTemplatesIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Template Id</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> BuilderAssetUrlsTemplatesIdGetAsync (string id)
        {
             ApiResponse<InlineResponse200> localVarResponse = await BuilderAssetUrlsTemplatesIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Template Id</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> BuilderAssetUrlsTemplatesIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BuilderAssetUrlApi->BuilderAssetUrlsTemplatesIdGet");

            var localVarPath = "/BuilderAsset/urls/templates/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml", 
                "text/xml", 
                "application/javascript", 
                "text/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuilderAssetUrlsTemplatesIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Tweak Template Id</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 BuilderAssetUrlsTweakTemplatesIdGet (string id)
        {
             ApiResponse<InlineResponse200> localVarResponse = BuilderAssetUrlsTweakTemplatesIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Tweak Template Id</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > BuilderAssetUrlsTweakTemplatesIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BuilderAssetUrlApi->BuilderAssetUrlsTweakTemplatesIdGet");

            var localVarPath = "/BuilderAsset/urls/tweakTemplates/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml", 
                "text/xml", 
                "application/javascript", 
                "text/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuilderAssetUrlsTweakTemplatesIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Tweak Template Id</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> BuilderAssetUrlsTweakTemplatesIdGetAsync (string id)
        {
             ApiResponse<InlineResponse200> localVarResponse = await BuilderAssetUrlsTweakTemplatesIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Tweak Template Id</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> BuilderAssetUrlsTweakTemplatesIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling BuilderAssetUrlApi->BuilderAssetUrlsTweakTemplatesIdGet");

            var localVarPath = "/BuilderAsset/urls/tweakTemplates/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml", 
                "text/xml", 
                "application/javascript", 
                "text/javascript"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BuilderAssetUrlsTweakTemplatesIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse200) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
            
        }

    }
}
