/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.6-alpha.0
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
    ///  Class for testing DesignCommentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DesignCommentApiTests
    {
        private DesignCommentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DesignCommentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DesignCommentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DesignCommentApi
            //Assert.IsInstanceOfType(typeof(DesignCommentApi), instance, "instance is a DesignCommentApi");
        }

        
        /// <summary>
        /// Test DesignCommentsChangeStreamGet
        /// </summary>
        [Test]
        public void DesignCommentsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignCommentsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignCommentsChangeStreamPost
        /// </summary>
        [Test]
        public void DesignCommentsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignCommentsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignCommentsCountGet
        /// </summary>
        [Test]
        public void DesignCommentsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DesignCommentsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignCommentsFindOneGet
        /// </summary>
        [Test]
        public void DesignCommentsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignCommentsFindOneGet(filter);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsGet
        /// </summary>
        [Test]
        public void DesignCommentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignCommentsGet(filter);
            //Assert.IsInstanceOf<List<DesignComment>> (response, "response is List<DesignComment>");
        }
        
        /// <summary>
        /// Test DesignCommentsIdCommenterGet
        /// </summary>
        [Test]
        public void DesignCommentsIdCommenterGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignCommentsIdCommenterGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignCommentsIdDelete
        /// </summary>
        [Test]
        public void DesignCommentsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignCommentsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DesignCommentsIdDesignGet
        /// </summary>
        [Test]
        public void DesignCommentsIdDesignGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignCommentsIdDesignGet(id, refresh);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignCommentsIdExistsGet
        /// </summary>
        [Test]
        public void DesignCommentsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignCommentsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignCommentsIdGet
        /// </summary>
        [Test]
        public void DesignCommentsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignCommentsIdGet(id, filter);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsIdHead
        /// </summary>
        [Test]
        public void DesignCommentsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignCommentsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignCommentsIdPatch
        /// </summary>
        [Test]
        public void DesignCommentsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignComment data = null;
            //var response = instance.DesignCommentsIdPatch(id, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsIdPut
        /// </summary>
        [Test]
        public void DesignCommentsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignComment data = null;
            //var response = instance.DesignCommentsIdPut(id, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsIdReplacePost
        /// </summary>
        [Test]
        public void DesignCommentsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignComment data = null;
            //var response = instance.DesignCommentsIdReplacePost(id, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsIdRepliesCountGet
        /// </summary>
        [Test]
        public void DesignCommentsIdRepliesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DesignCommentsIdRepliesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignCommentsIdRepliesDelete
        /// </summary>
        [Test]
        public void DesignCommentsIdRepliesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DesignCommentsIdRepliesDelete(id);
            
        }
        
        /// <summary>
        /// Test DesignCommentsIdRepliesFkDelete
        /// </summary>
        [Test]
        public void DesignCommentsIdRepliesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignCommentsIdRepliesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignCommentsIdRepliesFkGet
        /// </summary>
        [Test]
        public void DesignCommentsIdRepliesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignCommentsIdRepliesFkGet(id, fk);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsIdRepliesFkPut
        /// </summary>
        [Test]
        public void DesignCommentsIdRepliesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DesignComment data = null;
            //var response = instance.DesignCommentsIdRepliesFkPut(id, fk, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsIdRepliesGet
        /// </summary>
        [Test]
        public void DesignCommentsIdRepliesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignCommentsIdRepliesGet(id, filter);
            //Assert.IsInstanceOf<List<DesignComment>> (response, "response is List<DesignComment>");
        }
        
        /// <summary>
        /// Test DesignCommentsIdRepliesPost
        /// </summary>
        [Test]
        public void DesignCommentsIdRepliesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignComment data = null;
            //var response = instance.DesignCommentsIdRepliesPost(id, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsIdReplyOfGet
        /// </summary>
        [Test]
        public void DesignCommentsIdReplyOfGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignCommentsIdReplyOfGet(id, refresh);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsPatch
        /// </summary>
        [Test]
        public void DesignCommentsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignComment data = null;
            //var response = instance.DesignCommentsPatch(data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsPost
        /// </summary>
        [Test]
        public void DesignCommentsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignComment data = null;
            //var response = instance.DesignCommentsPost(data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsPut
        /// </summary>
        [Test]
        public void DesignCommentsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignComment data = null;
            //var response = instance.DesignCommentsPut(data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DesignCommentsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignComment data = null;
            //var response = instance.DesignCommentsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignCommentsUpdatePost
        /// </summary>
        [Test]
        public void DesignCommentsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignComment data = null;
            //var response = instance.DesignCommentsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DesignCommentsUpsertWithWherePost
        /// </summary>
        [Test]
        public void DesignCommentsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignComment data = null;
            //var response = instance.DesignCommentsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
    }

}
