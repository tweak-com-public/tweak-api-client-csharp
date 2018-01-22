/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.6-alpha.2
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
    ///  Class for testing DesignMemberApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DesignMemberApiTests
    {
        private DesignMemberApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DesignMemberApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DesignMemberApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DesignMemberApi
            //Assert.IsInstanceOfType(typeof(DesignMemberApi), instance, "instance is a DesignMemberApi");
        }

        
        /// <summary>
        /// Test DesignMembersChangeStreamGet
        /// </summary>
        [Test]
        public void DesignMembersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignMembersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignMembersChangeStreamPost
        /// </summary>
        [Test]
        public void DesignMembersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignMembersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignMembersCountGet
        /// </summary>
        [Test]
        public void DesignMembersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DesignMembersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignMembersFindOneGet
        /// </summary>
        [Test]
        public void DesignMembersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignMembersFindOneGet(filter);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersGet
        /// </summary>
        [Test]
        public void DesignMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignMembersGet(filter);
            //Assert.IsInstanceOf<List<DesignMember>> (response, "response is List<DesignMember>");
        }
        
        /// <summary>
        /// Test DesignMembersIdDelete
        /// </summary>
        [Test]
        public void DesignMembersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignMembersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DesignMembersIdDesignGet
        /// </summary>
        [Test]
        public void DesignMembersIdDesignGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignMembersIdDesignGet(id, refresh);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignMembersIdExistsGet
        /// </summary>
        [Test]
        public void DesignMembersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignMembersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DesignMembersIdGet
        /// </summary>
        [Test]
        public void DesignMembersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignMembersIdGet(id, filter);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersIdHead
        /// </summary>
        [Test]
        public void DesignMembersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignMembersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DesignMembersIdMemberGet
        /// </summary>
        [Test]
        public void DesignMembersIdMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignMembersIdMemberGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignMembersIdPatch
        /// </summary>
        [Test]
        public void DesignMembersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignMember data = null;
            //var response = instance.DesignMembersIdPatch(id, data);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersIdPut
        /// </summary>
        [Test]
        public void DesignMembersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignMember data = null;
            //var response = instance.DesignMembersIdPut(id, data);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersIdReplacePost
        /// </summary>
        [Test]
        public void DesignMembersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignMember data = null;
            //var response = instance.DesignMembersIdReplacePost(id, data);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersPatch
        /// </summary>
        [Test]
        public void DesignMembersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignMember data = null;
            //var response = instance.DesignMembersPatch(data);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersPost
        /// </summary>
        [Test]
        public void DesignMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignMember data = null;
            //var response = instance.DesignMembersPost(data);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersPut
        /// </summary>
        [Test]
        public void DesignMembersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignMember data = null;
            //var response = instance.DesignMembersPut(data);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DesignMembersReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignMember data = null;
            //var response = instance.DesignMembersReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
        /// <summary>
        /// Test DesignMembersUpdatePost
        /// </summary>
        [Test]
        public void DesignMembersUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignMember data = null;
            //var response = instance.DesignMembersUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test DesignMembersUpsertWithWherePost
        /// </summary>
        [Test]
        public void DesignMembersUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignMember data = null;
            //var response = instance.DesignMembersUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DesignMember> (response, "response is DesignMember");
        }
        
    }

}
