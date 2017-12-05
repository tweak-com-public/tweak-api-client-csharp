/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.11
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
    public interface IBuilderAssetBackgroundApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Builder Asset Backgrounds on a folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderPath">Folder path for backgrounds</param>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>List&lt;CloudinaryImage&gt;</returns>
        List<CloudinaryImage> BuilderAssetBackgroundsFoldersFolderPathGet (string folderPath, string filter = null);

        /// <summary>
        /// Get Builder Asset Backgrounds on a folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderPath">Folder path for backgrounds</param>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>ApiResponse of List&lt;CloudinaryImage&gt;</returns>
        ApiResponse<List<CloudinaryImage>> BuilderAssetBackgroundsFoldersFolderPathGetWithHttpInfo (string folderPath, string filter = null);
        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;BuilderAssetBackgroundFolder&gt;</returns>
        List<BuilderAssetBackgroundFolder> BuilderAssetBackgroundsFoldersGet ();

        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;BuilderAssetBackgroundFolder&gt;</returns>
        ApiResponse<List<BuilderAssetBackgroundFolder>> BuilderAssetBackgroundsFoldersGetWithHttpInfo ();
        /// <summary>
        /// Get all Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>List&lt;CloudinaryImage&gt;</returns>
        List<CloudinaryImage> BuilderAssetBackgroundsGet (string filter = null);

        /// <summary>
        /// Get all Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>ApiResponse of List&lt;CloudinaryImage&gt;</returns>
        ApiResponse<List<CloudinaryImage>> BuilderAssetBackgroundsGetWithHttpInfo (string filter = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Builder Asset Backgrounds on a folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderPath">Folder path for backgrounds</param>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>Task of List&lt;CloudinaryImage&gt;</returns>
        System.Threading.Tasks.Task<List<CloudinaryImage>> BuilderAssetBackgroundsFoldersFolderPathGetAsync (string folderPath, string filter = null);

        /// <summary>
        /// Get Builder Asset Backgrounds on a folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderPath">Folder path for backgrounds</param>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CloudinaryImage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CloudinaryImage>>> BuilderAssetBackgroundsFoldersFolderPathGetAsyncWithHttpInfo (string folderPath, string filter = null);
        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;BuilderAssetBackgroundFolder&gt;</returns>
        System.Threading.Tasks.Task<List<BuilderAssetBackgroundFolder>> BuilderAssetBackgroundsFoldersGetAsync ();

        /// <summary>
        /// Get folders for Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;BuilderAssetBackgroundFolder&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BuilderAssetBackgroundFolder>>> BuilderAssetBackgroundsFoldersGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get all Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>Task of List&lt;CloudinaryImage&gt;</returns>
        System.Threading.Tasks.Task<List<CloudinaryImage>> BuilderAssetBackgroundsGetAsync (string filter = null);

        /// <summary>
        /// Get all Builder Asset Backgrounds
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CloudinaryImage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CloudinaryImage>>> BuilderAssetBackgroundsGetAsyncWithHttpInfo (string filter = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BuilderAssetBackgroundApi : IBuilderAssetBackgroundApi
    {
        private TweakApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderAssetBackgroundApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BuilderAssetBackgroundApi(String basePath)
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
        /// Initializes a new instance of the <see cref="BuilderAssetBackgroundApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BuilderAssetBackgroundApi(Configuration configuration = null)
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
        /// Get Builder Asset Backgrounds on a folders 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderPath">Folder path for backgrounds</param>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>List&lt;CloudinaryImage&gt;</returns>
        public List<CloudinaryImage> BuilderAssetBackgroundsFoldersFolderPathGet (string folderPath, string filter = null)
        {
             ApiResponse<List<CloudinaryImage>> localVarResponse = BuilderAssetBackgroundsFoldersFolderPathGetWithHttpInfo(folderPath, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Builder Asset Backgrounds on a folders 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderPath">Folder path for backgrounds</param>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>ApiResponse of List&lt;CloudinaryImage&gt;</returns>
        public ApiResponse< List<CloudinaryImage> > BuilderAssetBackgroundsFoldersFolderPathGetWithHttpInfo (string folderPath, string filter = null)
        {
            // verify the required parameter 'folderPath' is set
            if (folderPath == null)
                throw new ApiException(400, "Missing required parameter 'folderPath' when calling BuilderAssetBackgroundApi->BuilderAssetBackgroundsFoldersFolderPathGet");

            var localVarPath = "/BuilderAsset/backgrounds/folders/{folderPath}";
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
            if (folderPath != null) localVarPathParams.Add("folderPath", Configuration.ApiClient.ParameterToString(folderPath)); // path parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("BuilderAssetBackgroundsFoldersFolderPathGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CloudinaryImage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CloudinaryImage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CloudinaryImage>)));
            
        }

        /// <summary>
        /// Get Builder Asset Backgrounds on a folders 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderPath">Folder path for backgrounds</param>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>Task of List&lt;CloudinaryImage&gt;</returns>
        public async System.Threading.Tasks.Task<List<CloudinaryImage>> BuilderAssetBackgroundsFoldersFolderPathGetAsync (string folderPath, string filter = null)
        {
             ApiResponse<List<CloudinaryImage>> localVarResponse = await BuilderAssetBackgroundsFoldersFolderPathGetAsyncWithHttpInfo(folderPath, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Builder Asset Backgrounds on a folders 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderPath">Folder path for backgrounds</param>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CloudinaryImage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CloudinaryImage>>> BuilderAssetBackgroundsFoldersFolderPathGetAsyncWithHttpInfo (string folderPath, string filter = null)
        {
            // verify the required parameter 'folderPath' is set
            if (folderPath == null)
                throw new ApiException(400, "Missing required parameter 'folderPath' when calling BuilderAssetBackgroundApi->BuilderAssetBackgroundsFoldersFolderPathGet");

            var localVarPath = "/BuilderAsset/backgrounds/folders/{folderPath}";
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
            if (folderPath != null) localVarPathParams.Add("folderPath", Configuration.ApiClient.ParameterToString(folderPath)); // path parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("BuilderAssetBackgroundsFoldersFolderPathGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CloudinaryImage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CloudinaryImage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CloudinaryImage>)));
            
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;BuilderAssetBackgroundFolder&gt;</returns>
        public List<BuilderAssetBackgroundFolder> BuilderAssetBackgroundsFoldersGet ()
        {
             ApiResponse<List<BuilderAssetBackgroundFolder>> localVarResponse = BuilderAssetBackgroundsFoldersGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;BuilderAssetBackgroundFolder&gt;</returns>
        public ApiResponse< List<BuilderAssetBackgroundFolder> > BuilderAssetBackgroundsFoldersGetWithHttpInfo ()
        {

            var localVarPath = "/BuilderAsset/backgrounds/folders";
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
                Exception exception = ExceptionFactory("BuilderAssetBackgroundsFoldersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BuilderAssetBackgroundFolder>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BuilderAssetBackgroundFolder>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BuilderAssetBackgroundFolder>)));
            
        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;BuilderAssetBackgroundFolder&gt;</returns>
        public async System.Threading.Tasks.Task<List<BuilderAssetBackgroundFolder>> BuilderAssetBackgroundsFoldersGetAsync ()
        {
             ApiResponse<List<BuilderAssetBackgroundFolder>> localVarResponse = await BuilderAssetBackgroundsFoldersGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get folders for Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;BuilderAssetBackgroundFolder&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BuilderAssetBackgroundFolder>>> BuilderAssetBackgroundsFoldersGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/BuilderAsset/backgrounds/folders";
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
                Exception exception = ExceptionFactory("BuilderAssetBackgroundsFoldersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<BuilderAssetBackgroundFolder>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BuilderAssetBackgroundFolder>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BuilderAssetBackgroundFolder>)));
            
        }

        /// <summary>
        /// Get all Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>List&lt;CloudinaryImage&gt;</returns>
        public List<CloudinaryImage> BuilderAssetBackgroundsGet (string filter = null)
        {
             ApiResponse<List<CloudinaryImage>> localVarResponse = BuilderAssetBackgroundsGetWithHttpInfo(filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>ApiResponse of List&lt;CloudinaryImage&gt;</returns>
        public ApiResponse< List<CloudinaryImage> > BuilderAssetBackgroundsGetWithHttpInfo (string filter = null)
        {

            var localVarPath = "/BuilderAsset/backgrounds";
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
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("BuilderAssetBackgroundsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CloudinaryImage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CloudinaryImage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CloudinaryImage>)));
            
        }

        /// <summary>
        /// Get all Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>Task of List&lt;CloudinaryImage&gt;</returns>
        public async System.Threading.Tasks.Task<List<CloudinaryImage>> BuilderAssetBackgroundsGetAsync (string filter = null)
        {
             ApiResponse<List<CloudinaryImage>> localVarResponse = await BuilderAssetBackgroundsGetAsyncWithHttpInfo(filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Builder Asset Backgrounds 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Filter defining fields, where, include, order, offset, and limit - must be a JSON-encoded string ({\&quot;something\&quot;:\&quot;value\&quot;}) (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CloudinaryImage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CloudinaryImage>>> BuilderAssetBackgroundsGetAsyncWithHttpInfo (string filter = null)
        {

            var localVarPath = "/BuilderAsset/backgrounds";
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
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("BuilderAssetBackgroundsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CloudinaryImage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CloudinaryImage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CloudinaryImage>)));
            
        }

    }
}
