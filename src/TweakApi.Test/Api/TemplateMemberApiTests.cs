/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.0
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
    ///  Class for testing TemplateMemberApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TemplateMemberApiTests
    {
        private TemplateMemberApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TemplateMemberApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TemplateMemberApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TemplateMemberApi
            //Assert.IsInstanceOfType(typeof(TemplateMemberApi), instance, "instance is a TemplateMemberApi");
        }

        
        /// <summary>
        /// Test TemplateMembersChangeStreamGet
        /// </summary>
        [Test]
        public void TemplateMembersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TemplateMembersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TemplateMembersChangeStreamPost
        /// </summary>
        [Test]
        public void TemplateMembersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TemplateMembersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TemplateMembersCountGet
        /// </summary>
        [Test]
        public void TemplateMembersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TemplateMembersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TemplateMembersFindOneGet
        /// </summary>
        [Test]
        public void TemplateMembersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TemplateMembersFindOneGet(filter);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersGet
        /// </summary>
        [Test]
        public void TemplateMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TemplateMembersGet(filter);
            //Assert.IsInstanceOf<List<TemplateMember>> (response, "response is List<TemplateMember>");
        }
        
        /// <summary>
        /// Test TemplateMembersIdDelete
        /// </summary>
        [Test]
        public void TemplateMembersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplateMembersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TemplateMembersIdExistsGet
        /// </summary>
        [Test]
        public void TemplateMembersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplateMembersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TemplateMembersIdGet
        /// </summary>
        [Test]
        public void TemplateMembersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TemplateMembersIdGet(id, filter);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersIdHead
        /// </summary>
        [Test]
        public void TemplateMembersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplateMembersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TemplateMembersIdMemberGet
        /// </summary>
        [Test]
        public void TemplateMembersIdMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TemplateMembersIdMemberGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test TemplateMembersIdPatch
        /// </summary>
        [Test]
        public void TemplateMembersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateMember data = null;
            //var response = instance.TemplateMembersIdPatch(id, data);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersIdPortalGet
        /// </summary>
        [Test]
        public void TemplateMembersIdPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TemplateMembersIdPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test TemplateMembersIdPut
        /// </summary>
        [Test]
        public void TemplateMembersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateMember data = null;
            //var response = instance.TemplateMembersIdPut(id, data);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersIdReplacePost
        /// </summary>
        [Test]
        public void TemplateMembersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateMember data = null;
            //var response = instance.TemplateMembersIdReplacePost(id, data);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersIdTemplateGet
        /// </summary>
        [Test]
        public void TemplateMembersIdTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TemplateMembersIdTemplateGet(id, refresh);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TemplateMembersPatch
        /// </summary>
        [Test]
        public void TemplateMembersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateMember data = null;
            //var response = instance.TemplateMembersPatch(data);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersPost
        /// </summary>
        [Test]
        public void TemplateMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateMember data = null;
            //var response = instance.TemplateMembersPost(data);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersPut
        /// </summary>
        [Test]
        public void TemplateMembersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateMember data = null;
            //var response = instance.TemplateMembersPut(data);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersReplaceOrCreatePost
        /// </summary>
        [Test]
        public void TemplateMembersReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateMember data = null;
            //var response = instance.TemplateMembersReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test TemplateMembersUpdatePost
        /// </summary>
        [Test]
        public void TemplateMembersUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TemplateMember data = null;
            //var response = instance.TemplateMembersUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TemplateMembersUpsertWithWherePost
        /// </summary>
        [Test]
        public void TemplateMembersUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TemplateMember data = null;
            //var response = instance.TemplateMembersUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
    }

}
