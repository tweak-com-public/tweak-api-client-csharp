/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3
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
    ///  Class for testing PortalMemberApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PortalMemberApiTests
    {
        private PortalMemberApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PortalMemberApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PortalMemberApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PortalMemberApi
            //Assert.IsInstanceOfType(typeof(PortalMemberApi), instance, "instance is a PortalMemberApi");
        }

        
        /// <summary>
        /// Test PortalMembersChangeStreamGet
        /// </summary>
        [Test]
        public void PortalMembersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalMembersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalMembersChangeStreamPost
        /// </summary>
        [Test]
        public void PortalMembersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalMembersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalMembersCountGet
        /// </summary>
        [Test]
        public void PortalMembersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.PortalMembersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test PortalMembersFindOneGet
        /// </summary>
        [Test]
        public void PortalMembersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalMembersFindOneGet(filter);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersGet
        /// </summary>
        [Test]
        public void PortalMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalMembersGet(filter);
            //Assert.IsInstanceOf<List<PortalMember>> (response, "response is List<PortalMember>");
        }
        
        /// <summary>
        /// Test PortalMembersIdDelete
        /// </summary>
        [Test]
        public void PortalMembersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalMembersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test PortalMembersIdExistsGet
        /// </summary>
        [Test]
        public void PortalMembersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalMembersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalMembersIdGet
        /// </summary>
        [Test]
        public void PortalMembersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.PortalMembersIdGet(id, filter);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersIdHead
        /// </summary>
        [Test]
        public void PortalMembersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalMembersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalMembersIdMemberGet
        /// </summary>
        [Test]
        public void PortalMembersIdMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalMembersIdMemberGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test PortalMembersIdPatch
        /// </summary>
        [Test]
        public void PortalMembersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalMember data = null;
            //var response = instance.PortalMembersIdPatch(id, data);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersIdPortalGet
        /// </summary>
        [Test]
        public void PortalMembersIdPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalMembersIdPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test PortalMembersIdPut
        /// </summary>
        [Test]
        public void PortalMembersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalMember data = null;
            //var response = instance.PortalMembersIdPut(id, data);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersIdReplacePost
        /// </summary>
        [Test]
        public void PortalMembersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalMember data = null;
            //var response = instance.PortalMembersIdReplacePost(id, data);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersPatch
        /// </summary>
        [Test]
        public void PortalMembersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalMember data = null;
            //var response = instance.PortalMembersPatch(data);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersPost
        /// </summary>
        [Test]
        public void PortalMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalMember data = null;
            //var response = instance.PortalMembersPost(data);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersPut
        /// </summary>
        [Test]
        public void PortalMembersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalMember data = null;
            //var response = instance.PortalMembersPut(data);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersReplaceOrCreatePost
        /// </summary>
        [Test]
        public void PortalMembersReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalMember data = null;
            //var response = instance.PortalMembersReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test PortalMembersUpdatePost
        /// </summary>
        [Test]
        public void PortalMembersUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //PortalMember data = null;
            //var response = instance.PortalMembersUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test PortalMembersUpsertWithWherePost
        /// </summary>
        [Test]
        public void PortalMembersUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //PortalMember data = null;
            //var response = instance.PortalMembersUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
    }

}
