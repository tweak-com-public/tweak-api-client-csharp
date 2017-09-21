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
    ///  Class for testing TemplatePermissionSetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TemplatePermissionSetApiTests
    {
        private TemplatePermissionSetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TemplatePermissionSetApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TemplatePermissionSetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TemplatePermissionSetApi
            //Assert.IsInstanceOfType(typeof(TemplatePermissionSetApi), instance, "instance is a TemplatePermissionSetApi");
        }

        
        /// <summary>
        /// Test TemplatePermissionSetsChangeStreamGet
        /// </summary>
        [Test]
        public void TemplatePermissionSetsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TemplatePermissionSetsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsChangeStreamPost
        /// </summary>
        [Test]
        public void TemplatePermissionSetsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TemplatePermissionSetsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsCountGet
        /// </summary>
        [Test]
        public void TemplatePermissionSetsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TemplatePermissionSetsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsFindOneGet
        /// </summary>
        [Test]
        public void TemplatePermissionSetsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TemplatePermissionSetsFindOneGet(filter);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsGet
        /// </summary>
        [Test]
        public void TemplatePermissionSetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TemplatePermissionSetsGet(filter);
            //Assert.IsInstanceOf<List<TemplatePermissionSet>> (response, "response is List<TemplatePermissionSet>");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsIdDelete
        /// </summary>
        [Test]
        public void TemplatePermissionSetsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplatePermissionSetsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsIdExistsGet
        /// </summary>
        [Test]
        public void TemplatePermissionSetsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplatePermissionSetsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsIdGet
        /// </summary>
        [Test]
        public void TemplatePermissionSetsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TemplatePermissionSetsIdGet(id, filter);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsIdHead
        /// </summary>
        [Test]
        public void TemplatePermissionSetsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TemplatePermissionSetsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsIdPatch
        /// </summary>
        [Test]
        public void TemplatePermissionSetsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsIdPatch(id, data);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsIdPut
        /// </summary>
        [Test]
        public void TemplatePermissionSetsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsIdPut(id, data);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsIdReplacePost
        /// </summary>
        [Test]
        public void TemplatePermissionSetsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsIdReplacePost(id, data);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsIdTemplateGet
        /// </summary>
        [Test]
        public void TemplatePermissionSetsIdTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TemplatePermissionSetsIdTemplateGet(id, refresh);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsPatch
        /// </summary>
        [Test]
        public void TemplatePermissionSetsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsPatch(data);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsPost
        /// </summary>
        [Test]
        public void TemplatePermissionSetsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsPost(data);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsPut
        /// </summary>
        [Test]
        public void TemplatePermissionSetsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsPut(data);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void TemplatePermissionSetsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsUpdatePost
        /// </summary>
        [Test]
        public void TemplatePermissionSetsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TemplatePermissionSetsUpsertWithWherePost
        /// </summary>
        [Test]
        public void TemplatePermissionSetsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TemplatePermissionSet data = null;
            //var response = instance.TemplatePermissionSetsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<TemplatePermissionSet> (response, "response is TemplatePermissionSet");
        }
        
    }

}
