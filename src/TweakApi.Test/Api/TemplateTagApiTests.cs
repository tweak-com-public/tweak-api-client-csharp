/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.7-beta.3
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
    ///  Class for testing TemplateTagApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TemplateTagApiTests
    {
        private TemplateTagApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TemplateTagApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TemplateTagApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TemplateTagApi
            //Assert.IsInstanceOfType(typeof(TemplateTagApi), instance, "instance is a TemplateTagApi");
        }

        
        /// <summary>
        /// Test TemplateTagsChangeStreamGet
        /// </summary>
        [Test]
        public void TemplateTagsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TemplateTagsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TemplateTagsChangeStreamPost
        /// </summary>
        [Test]
        public void TemplateTagsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TemplateTagsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TemplateTagsCountGet
        /// </summary>
        [Test]
        public void TemplateTagsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TemplateTagsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TemplateTagsFindOneGet
        /// </summary>
        [Test]
        public void TemplateTagsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TemplateTagsFindOneGet(filter);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsGet
        /// </summary>
        [Test]
        public void TemplateTagsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TemplateTagsGet(filter);
            //Assert.IsInstanceOf<List<TemplateTag>> (response, "response is List<TemplateTag>");
        }
        
        /// <summary>
        /// Test TemplateTagsIdDelete
        /// </summary>
        [Test]
        public void TemplateTagsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplateTagsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TemplateTagsIdExistsGet
        /// </summary>
        [Test]
        public void TemplateTagsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplateTagsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TemplateTagsIdGet
        /// </summary>
        [Test]
        public void TemplateTagsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TemplateTagsIdGet(id, filter);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsIdHead
        /// </summary>
        [Test]
        public void TemplateTagsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplateTagsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TemplateTagsIdPatch
        /// </summary>
        [Test]
        public void TemplateTagsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateTag data = null;
            //var response = instance.TemplateTagsIdPatch(id, data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsIdPut
        /// </summary>
        [Test]
        public void TemplateTagsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateTag data = null;
            //var response = instance.TemplateTagsIdPut(id, data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsIdReplacePost
        /// </summary>
        [Test]
        public void TemplateTagsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplateTag data = null;
            //var response = instance.TemplateTagsIdReplacePost(id, data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsIdTagGet
        /// </summary>
        [Test]
        public void TemplateTagsIdTagGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TemplateTagsIdTagGet(id, refresh);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TemplateTagsIdTemplateGet
        /// </summary>
        [Test]
        public void TemplateTagsIdTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TemplateTagsIdTemplateGet(id, refresh);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TemplateTagsPatch
        /// </summary>
        [Test]
        public void TemplateTagsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateTag data = null;
            //var response = instance.TemplateTagsPatch(data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsPost
        /// </summary>
        [Test]
        public void TemplateTagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateTag data = null;
            //var response = instance.TemplateTagsPost(data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsPut
        /// </summary>
        [Test]
        public void TemplateTagsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateTag data = null;
            //var response = instance.TemplateTagsPut(data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void TemplateTagsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplateTag data = null;
            //var response = instance.TemplateTagsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TemplateTagsUpdatePost
        /// </summary>
        [Test]
        public void TemplateTagsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TemplateTag data = null;
            //var response = instance.TemplateTagsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test TemplateTagsUpsertWithWherePost
        /// </summary>
        [Test]
        public void TemplateTagsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TemplateTag data = null;
            //var response = instance.TemplateTagsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
    }

}
