/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.6-alpha.6
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
    ///  Class for testing TeamBuilderConfigProductGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamBuilderConfigProductGroupApiTests
    {
        private TeamBuilderConfigProductGroupApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamBuilderConfigProductGroupApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamBuilderConfigProductGroupApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamBuilderConfigProductGroupApi
            //Assert.IsInstanceOfType(typeof(TeamBuilderConfigProductGroupApi), instance, "instance is a TeamBuilderConfigProductGroupApi");
        }

        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsChangeStreamGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TeamBuilderConfigProductGroupsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsChangeStreamPost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TeamBuilderConfigProductGroupsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsCountGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TeamBuilderConfigProductGroupsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsFindOneGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TeamBuilderConfigProductGroupsFindOneGet(filter);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TeamBuilderConfigProductGroupsGet(filter);
            //Assert.IsInstanceOf<List<TeamBuilderConfigProductGroup>> (response, "response is List<TeamBuilderConfigProductGroup>");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdBuilderConfigGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdBuilderConfigGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdBuilderConfigGet(id, refresh);
            //Assert.IsInstanceOf<TeamBuilderConfig> (response, "response is TeamBuilderConfig");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdDelete
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdExistsGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdGet(id, filter);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdHead
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdPatch
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdPatch(id, data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdProductGroupGet
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdProductGroupGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdProductGroupGet(id, refresh);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdPut
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdPut(id, data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsIdReplacePost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsIdReplacePost(id, data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsPatch
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsPatch(data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsPost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsPost(data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsPut
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsPut(data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsUpdatePost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test TeamBuilderConfigProductGroupsUpsertWithWherePost
        /// </summary>
        [Test]
        public void TeamBuilderConfigProductGroupsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TeamBuilderConfigProductGroup data = null;
            //var response = instance.TeamBuilderConfigProductGroupsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<TeamBuilderConfigProductGroup> (response, "response is TeamBuilderConfigProductGroup");
        }
        
    }

}
