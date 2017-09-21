/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.1-beta.1
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
    ///  Class for testing DesignTagApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DesignTagApiTests
    {
        private DesignTagApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DesignTagApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DesignTagApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DesignTagApi
            //Assert.IsInstanceOfType(typeof(DesignTagApi), instance, "instance is a DesignTagApi");
        }

        
        /// <summary>
        /// Test DesignTagsChangeStreamGet
        /// </summary>
        [Test]
        public void DesignTagsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignTagsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignTagsChangeStreamPost
        /// </summary>
        [Test]
        public void DesignTagsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignTagsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignTagsCountGet
        /// </summary>
        [Test]
        public void DesignTagsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DesignTagsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignTagsFindOneGet
        /// </summary>
        [Test]
        public void DesignTagsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignTagsFindOneGet(filter);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsGet
        /// </summary>
        [Test]
        public void DesignTagsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignTagsGet(filter);
            //Assert.IsInstanceOf<List<DesignTag>> (response, "response is List<DesignTag>");
        }
        
        /// <summary>
        /// Test DesignTagsIdDelete
        /// </summary>
        [Test]
        public void DesignTagsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignTagsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DesignTagsIdDesignGet
        /// </summary>
        [Test]
        public void DesignTagsIdDesignGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignTagsIdDesignGet(id, refresh);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignTagsIdExistsGet
        /// </summary>
        [Test]
        public void DesignTagsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignTagsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignTagsIdGet
        /// </summary>
        [Test]
        public void DesignTagsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignTagsIdGet(id, filter);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsIdHead
        /// </summary>
        [Test]
        public void DesignTagsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignTagsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignTagsIdPatch
        /// </summary>
        [Test]
        public void DesignTagsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignTag data = null;
            //var response = instance.DesignTagsIdPatch(id, data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsIdPut
        /// </summary>
        [Test]
        public void DesignTagsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignTag data = null;
            //var response = instance.DesignTagsIdPut(id, data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsIdReplacePost
        /// </summary>
        [Test]
        public void DesignTagsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignTag data = null;
            //var response = instance.DesignTagsIdReplacePost(id, data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsIdTagGet
        /// </summary>
        [Test]
        public void DesignTagsIdTagGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignTagsIdTagGet(id, refresh);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test DesignTagsPatch
        /// </summary>
        [Test]
        public void DesignTagsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignTag data = null;
            //var response = instance.DesignTagsPatch(data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsPost
        /// </summary>
        [Test]
        public void DesignTagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignTag data = null;
            //var response = instance.DesignTagsPost(data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsPut
        /// </summary>
        [Test]
        public void DesignTagsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignTag data = null;
            //var response = instance.DesignTagsPut(data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DesignTagsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignTag data = null;
            //var response = instance.DesignTagsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignTagsUpdatePost
        /// </summary>
        [Test]
        public void DesignTagsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignTag data = null;
            //var response = instance.DesignTagsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DesignTagsUpsertWithWherePost
        /// </summary>
        [Test]
        public void DesignTagsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignTag data = null;
            //var response = instance.DesignTagsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
    }

}
