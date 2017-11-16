/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.4
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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TweakApi.Client;
using TweakApi.Api;
using TweakApi.Model;

namespace TweakApi.Test
{
    /// <summary>
    ///  Class for testing TeamBuilderConfigProductTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamBuilderConfigProductTypeApiTests
    {
        private TeamBuilderConfigProductTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamBuilderConfigProductTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamBuilderConfigProductTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamBuilderConfigProductTypeApi
            //Assert.IsInstanceOfType(typeof(TeamBuilderConfigProductTypeApi), instance, "instance is a TeamBuilderConfigProductTypeApi");
        }

        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesChangeStreamGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TeamBuilderConfigProductTypesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesChangeStreamPost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TeamBuilderConfigProductTypesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesCountGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TeamBuilderConfigProductTypesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesFindOneGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TeamBuilderConfigProductTypesFindOneGet(filter);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TeamBuilderConfigProductTypesGet(filter);
            //Assert.IsInstanceOf<List<TeamBuilderConfigProductType>> (response, "response is List<TeamBuilderConfigProductType>");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdBuilderConfigGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdBuilderConfigGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TeamBuilderConfigProductTypesIdBuilderConfigGet(id, refresh);
            //Assert.IsInstanceOf<TeamBuilderConfig> (response, "response is TeamBuilderConfig");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdDelete
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamBuilderConfigProductTypesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdExistsGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamBuilderConfigProductTypesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TeamBuilderConfigProductTypesIdGet(id, filter);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdHead
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamBuilderConfigProductTypesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdPatch
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesIdPatch(id, data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdProductTypeGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdProductTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TeamBuilderConfigProductTypesIdProductTypeGet(id, refresh);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdPut
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesIdPut(id, data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesIdReplacePost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesIdReplacePost(id, data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesPatch
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesPatch(data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesPost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesPost(data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesPut
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesPut(data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesReplaceOrCreatePost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesUpdatePost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductTypesUpsertWithWherePost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductTypesUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TeamBuilderConfigProductType data = null;
            //var response = instance.TeamBuilderConfigProductTypesUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductType> (response, "response is TeamBuilderConfigProductType");
        }
        
    }

}
