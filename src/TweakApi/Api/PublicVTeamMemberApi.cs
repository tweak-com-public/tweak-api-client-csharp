/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.10
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
    public interface IPublicVTeamMemberApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Change portal
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">TeamMember id</param>
        /// <param name="portalId">Portal id</param>
        /// <returns>TeamMemberAccessToken</returns>
        TeamMemberAccessToken V1TeamMembersLoginPost (string id, string portalId);

        /// <summary>
        /// Change portal
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">TeamMember id</param>
        /// <param name="portalId">Portal id</param>
        /// <returns>ApiResponse of TeamMemberAccessToken</returns>
        ApiResponse<TeamMemberAccessToken> V1TeamMembersLoginPostWithHttpInfo (string id, string portalId);
        /// <summary>
        /// Logout a TeamMember
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void V1TeamMembersLogoutPost ();

        /// <summary>
        /// Logout a TeamMember
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> V1TeamMembersLogoutPostWithHttpInfo ();
        /// <summary>
        /// Create a Member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data to create Member</param>
        /// <returns>Object</returns>
        Object V1TeamMembersPost (PublicV1TeamMember data);

        /// <summary>
        /// Create a Member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data to create Member</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> V1TeamMembersPostWithHttpInfo (PublicV1TeamMember data);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Change portal
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">TeamMember id</param>
        /// <param name="portalId">Portal id</param>
        /// <returns>Task of TeamMemberAccessToken</returns>
        System.Threading.Tasks.Task<TeamMemberAccessToken> V1TeamMembersLoginPostAsync (string id, string portalId);

        /// <summary>
        /// Change portal
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">TeamMember id</param>
        /// <param name="portalId">Portal id</param>
        /// <returns>Task of ApiResponse (TeamMemberAccessToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamMemberAccessToken>> V1TeamMembersLoginPostAsyncWithHttpInfo (string id, string portalId);
        /// <summary>
        /// Logout a TeamMember
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task V1TeamMembersLogoutPostAsync ();

        /// <summary>
        /// Logout a TeamMember
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1TeamMembersLogoutPostAsyncWithHttpInfo ();
        /// <summary>
        /// Create a Member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data to create Member</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> V1TeamMembersPostAsync (PublicV1TeamMember data);

        /// <summary>
        /// Create a Member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data to create Member</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> V1TeamMembersPostAsyncWithHttpInfo (PublicV1TeamMember data);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PublicVTeamMemberApi : IPublicVTeamMemberApi
    {
        private TweakApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicVTeamMemberApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PublicVTeamMemberApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PublicVTeamMemberApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PublicVTeamMemberApi(Configuration configuration = null)
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
        /// Change portal 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">TeamMember id</param>
        /// <param name="portalId">Portal id</param>
        /// <returns>TeamMemberAccessToken</returns>
        public TeamMemberAccessToken V1TeamMembersLoginPost (string id, string portalId)
        {
             ApiResponse<TeamMemberAccessToken> localVarResponse = V1TeamMembersLoginPostWithHttpInfo(id, portalId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Change portal 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">TeamMember id</param>
        /// <param name="portalId">Portal id</param>
        /// <returns>ApiResponse of TeamMemberAccessToken</returns>
        public ApiResponse< TeamMemberAccessToken > V1TeamMembersLoginPostWithHttpInfo (string id, string portalId)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PublicVTeamMemberApi->V1TeamMembersLoginPost");
            // verify the required parameter 'portalId' is set
            if (portalId == null)
                throw new ApiException(400, "Missing required parameter 'portalId' when calling PublicVTeamMemberApi->V1TeamMembersLoginPost");

            var localVarPath = "/v1/TeamMembers/login";
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
            if (portalId != null) localVarPathParams.Add("portalId", Configuration.ApiClient.ParameterToString(portalId)); // path parameter

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamMembersLoginPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TeamMemberAccessToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TeamMemberAccessToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamMemberAccessToken)));
            
        }

        /// <summary>
        /// Change portal 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">TeamMember id</param>
        /// <param name="portalId">Portal id</param>
        /// <returns>Task of TeamMemberAccessToken</returns>
        public async System.Threading.Tasks.Task<TeamMemberAccessToken> V1TeamMembersLoginPostAsync (string id, string portalId)
        {
             ApiResponse<TeamMemberAccessToken> localVarResponse = await V1TeamMembersLoginPostAsyncWithHttpInfo(id, portalId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Change portal 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">TeamMember id</param>
        /// <param name="portalId">Portal id</param>
        /// <returns>Task of ApiResponse (TeamMemberAccessToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TeamMemberAccessToken>> V1TeamMembersLoginPostAsyncWithHttpInfo (string id, string portalId)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PublicVTeamMemberApi->V1TeamMembersLoginPost");
            // verify the required parameter 'portalId' is set
            if (portalId == null)
                throw new ApiException(400, "Missing required parameter 'portalId' when calling PublicVTeamMemberApi->V1TeamMembersLoginPost");

            var localVarPath = "/v1/TeamMembers/login";
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
            if (portalId != null) localVarPathParams.Add("portalId", Configuration.ApiClient.ParameterToString(portalId)); // path parameter

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamMembersLoginPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TeamMemberAccessToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TeamMemberAccessToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamMemberAccessToken)));
            
        }

        /// <summary>
        /// Logout a TeamMember 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void V1TeamMembersLogoutPost ()
        {
             V1TeamMembersLogoutPostWithHttpInfo();
        }

        /// <summary>
        /// Logout a TeamMember 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> V1TeamMembersLogoutPostWithHttpInfo ()
        {

            var localVarPath = "/v1/TeamMembers/logout";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamMembersLogoutPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Logout a TeamMember 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task V1TeamMembersLogoutPostAsync ()
        {
             await V1TeamMembersLogoutPostAsyncWithHttpInfo();

        }

        /// <summary>
        /// Logout a TeamMember 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1TeamMembersLogoutPostAsyncWithHttpInfo ()
        {

            var localVarPath = "/v1/TeamMembers/logout";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamMembersLogoutPost", localVarResponse);
                if (exception != null) throw exception;
            }

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create a Member 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data to create Member</param>
        /// <returns>Object</returns>
        public Object V1TeamMembersPost (PublicV1TeamMember data)
        {
             ApiResponse<Object> localVarResponse = V1TeamMembersPostWithHttpInfo(data);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Member 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data to create Member</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > V1TeamMembersPostWithHttpInfo (PublicV1TeamMember data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling PublicVTeamMemberApi->V1TeamMembersPost");

            var localVarPath = "/v1/TeamMembers";
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
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamMembersPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Create a Member 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data to create Member</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> V1TeamMembersPostAsync (PublicV1TeamMember data)
        {
             ApiResponse<Object> localVarResponse = await V1TeamMembersPostAsyncWithHttpInfo(data);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Member 
        /// </summary>
        /// <exception cref="TweakApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data">Data to create Member</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> V1TeamMembersPostAsyncWithHttpInfo (PublicV1TeamMember data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling PublicVTeamMemberApi->V1TeamMembersPost");

            var localVarPath = "/v1/TeamMembers";
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
            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1TeamMembersPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

    }
}
