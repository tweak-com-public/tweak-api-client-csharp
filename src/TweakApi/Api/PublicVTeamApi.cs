/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.6
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
    public interface IPublicVTeamApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get default Team&#39;s BuilderConfig
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TeamBuilderConfig</returns>
        TeamBuilderConfig V1TeamBuilderConfigsDefaultGet ();

        /// <summary>
        /// Get default Team&#39;s BuilderConfig
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TeamBuilderConfig</returns>
        ApiResponse<TeamBuilderConfig> V1TeamBuilderConfigsDefaultGetWithHttpInfo ();
        /// <summary>
        /// Get Team&#39;s BuilderConfig by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">BuilderConfig id</param>
        /// <returns>TeamBuilderConfig</returns>
        TeamBuilderConfig V1TeamBuilderConfigsIdGet (string id);

        /// <summary>
        /// Get Team&#39;s BuilderConfig by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">BuilderConfig id</param>
        /// <returns>ApiResponse of TeamBuilderConfig</returns>
        ApiResponse<TeamBuilderConfig> V1TeamBuilderConfigsIdGetWithHttpInfo (string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get default Team&#39;s BuilderConfig
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TeamBuilderConfig</returns>
        System.Threading.Tasks.Task<TeamBuilderConfig> V1TeamBuilderConfigsDefaultGetAsync ();

        /// <summary>
        /// Get default Team&#39;s BuilderConfig
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TeamBuilderConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamBuilderConfig>> V1TeamBuilderConfigsDefaultGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get Team&#39;s BuilderConfig by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">BuilderConfig id</param>
        /// <returns>Task of TeamBuilderConfig</returns>
        System.Threading.Tasks.Task<TeamBuilderConfig> V1TeamBuilderConfigsIdGetAsync (string id);

        /// <summary>
        /// Get Team&#39;s BuilderConfig by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">BuilderConfig id</param>
        /// <returns>Task of ApiResponse (TeamBuilderConfig)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamBuilderConfig>> V1TeamBuilderConfigsIdGetAsyncWithHttpInfo (string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicVTeamApi : IPublicVTeamApi
    {
        private TweakApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicVTeamApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicVTeamApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PublicVTeamApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicVTeamApi(Configuration configuration = null)
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
        /// Get default Team&#39;s BuilderConfig 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TeamBuilderConfig</returns>
        public TeamBuilderConfig V1TeamBuilderConfigsDefaultGet ()
        {
             ApiResponse<TeamBuilderConfig> localVarResponse = V1TeamBuilderConfigsDefaultGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get default Team&#39;s BuilderConfig 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TeamBuilderConfig</returns>
        public ApiResponse< TeamBuilderConfig > V1TeamBuilderConfigsDefaultGetWithHttpInfo ()
        {

            var localVarPath = "/v1/Team/builderConfigs/default";
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

            // authentication (teamKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("teamKey")))
            {
                localVarQueryParams["teamKey"] = Configuration.GetApiKeyWithPrefix("teamKey");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamBuilderConfigsDefaultGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TeamBuilderConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TeamBuilderConfig) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamBuilderConfig)));
            
        }

        /// <summary>
        /// Get default Team&#39;s BuilderConfig 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TeamBuilderConfig</returns>
        public async System.Threading.Tasks.Task<TeamBuilderConfig> V1TeamBuilderConfigsDefaultGetAsync ()
        {
             ApiResponse<TeamBuilderConfig> localVarResponse = await V1TeamBuilderConfigsDefaultGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get default Team&#39;s BuilderConfig 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TeamBuilderConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TeamBuilderConfig>> V1TeamBuilderConfigsDefaultGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/Team/builderConfigs/default";
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
            // authentication (teamKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("teamKey")))
            {
                localVarQueryParams["teamKey"] = Configuration.GetApiKeyWithPrefix("teamKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamBuilderConfigsDefaultGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TeamBuilderConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TeamBuilderConfig) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamBuilderConfig)));
            
        }

        /// <summary>
        /// Get Team&#39;s BuilderConfig by id 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">BuilderConfig id</param>
        /// <returns>TeamBuilderConfig</returns>
        public TeamBuilderConfig V1TeamBuilderConfigsIdGet (string id)
        {
             ApiResponse<TeamBuilderConfig> localVarResponse = V1TeamBuilderConfigsIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Team&#39;s BuilderConfig by id 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">BuilderConfig id</param>
        /// <returns>ApiResponse of TeamBuilderConfig</returns>
        public ApiResponse< TeamBuilderConfig > V1TeamBuilderConfigsIdGetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PublicVTeamApi->V1TeamBuilderConfigsIdGet");

            var localVarPath = "/v1/Team/builderConfigs/{id}";
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

            // authentication (teamKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("teamKey")))
            {
                localVarQueryParams["teamKey"] = Configuration.GetApiKeyWithPrefix("teamKey");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamBuilderConfigsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TeamBuilderConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TeamBuilderConfig) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamBuilderConfig)));
            
        }

        /// <summary>
        /// Get Team&#39;s BuilderConfig by id 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">BuilderConfig id</param>
        /// <returns>Task of TeamBuilderConfig</returns>
        public async System.Threading.Tasks.Task<TeamBuilderConfig> V1TeamBuilderConfigsIdGetAsync (string id)
        {
             ApiResponse<TeamBuilderConfig> localVarResponse = await V1TeamBuilderConfigsIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Team&#39;s BuilderConfig by id 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">BuilderConfig id</param>
        /// <returns>Task of ApiResponse (TeamBuilderConfig)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TeamBuilderConfig>> V1TeamBuilderConfigsIdGetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PublicVTeamApi->V1TeamBuilderConfigsIdGet");

            var localVarPath = "/v1/Team/builderConfigs/{id}";
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
            // authentication (teamKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("teamKey")))
            {
                localVarQueryParams["teamKey"] = Configuration.GetApiKeyWithPrefix("teamKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamBuilderConfigsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TeamBuilderConfig>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TeamBuilderConfig) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamBuilderConfig)));
            
        }

    }
}
