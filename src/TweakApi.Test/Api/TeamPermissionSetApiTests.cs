/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.1
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
    ///  Class for testing TeamPermissionSetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamPermissionSetApiTests
    {
        private TeamPermissionSetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamPermissionSetApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamPermissionSetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamPermissionSetApi
            //Assert.IsInstanceOfType(typeof(TeamPermissionSetApi), instance, "instance is a TeamPermissionSetApi");
        }

        
        /// <summary>
        /// Test TeamPermissionSetsChangeStreamGet
        /// </summary>
        [Test]
        public void TeamPermissionSetsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TeamPermissionSetsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsChangeStreamPost
        /// </summary>
        [Test]
        public void TeamPermissionSetsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TeamPermissionSetsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsCountGet
        /// </summary>
        [Test]
        public void TeamPermissionSetsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TeamPermissionSetsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsFindOneGet
        /// </summary>
        [Test]
        public void TeamPermissionSetsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TeamPermissionSetsFindOneGet(filter);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsGet
        /// </summary>
        [Test]
        public void TeamPermissionSetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TeamPermissionSetsGet(filter);
            //Assert.IsInstanceOf<List<TeamPermissionSet>> (response, "response is List<TeamPermissionSet>");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsIdDelete
        /// </summary>
        [Test]
        public void TeamPermissionSetsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamPermissionSetsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsIdExistsGet
        /// </summary>
        [Test]
        public void TeamPermissionSetsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamPermissionSetsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsIdGet
        /// </summary>
        [Test]
        public void TeamPermissionSetsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TeamPermissionSetsIdGet(id, filter);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsIdHead
        /// </summary>
        [Test]
        public void TeamPermissionSetsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamPermissionSetsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsIdPatch
        /// </summary>
        [Test]
        public void TeamPermissionSetsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsIdPatch(id, data);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsIdPut
        /// </summary>
        [Test]
        public void TeamPermissionSetsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsIdPut(id, data);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsIdReplacePost
        /// </summary>
        [Test]
        public void TeamPermissionSetsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsIdReplacePost(id, data);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsIdTeamGet
        /// </summary>
        [Test]
        public void TeamPermissionSetsIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TeamPermissionSetsIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsPatch
        /// </summary>
        [Test]
        public void TeamPermissionSetsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsPatch(data);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsPost
        /// </summary>
        [Test]
        public void TeamPermissionSetsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsPost(data);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsPut
        /// </summary>
        [Test]
        public void TeamPermissionSetsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsPut(data);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void TeamPermissionSetsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsUpdatePost
        /// </summary>
        [Test]
        public void TeamPermissionSetsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TeamPermissionSetsUpsertWithWherePost
        /// </summary>
        [Test]
        public void TeamPermissionSetsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TeamPermissionSet data = null;
            //var response = instance.TeamPermissionSetsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<TeamPermissionSet> (response, "response is TeamPermissionSet");
        }
        
    }

}
