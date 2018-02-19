/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-beta.0
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
    ///  Class for testing PortalTemplateApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PortalTemplateApiTests
    {
        private PortalTemplateApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PortalTemplateApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PortalTemplateApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PortalTemplateApi
            //Assert.IsInstanceOfType(typeof(PortalTemplateApi), instance, "instance is a PortalTemplateApi");
        }

        
        /// <summary>
        /// Test PortalTemplatesChangeStreamGet
        /// </summary>
        [Test]
        public void PortalTemplatesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalTemplatesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalTemplatesChangeStreamPost
        /// </summary>
        [Test]
        public void PortalTemplatesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalTemplatesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalTemplatesCountGet
        /// </summary>
        [Test]
        public void PortalTemplatesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.PortalTemplatesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalTemplatesFindOneGet
        /// </summary>
        [Test]
        public void PortalTemplatesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalTemplatesFindOneGet(filter);
            //Assert.IsInstanceOf<PortalTemplate> (response, "response is PortalTemplate");
        }
        
        /// <summary>
        /// Test PortalTemplatesGet
        /// </summary>
        [Test]
        public void PortalTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalTemplatesGet(filter);
            //Assert.IsInstanceOf<List<PortalTemplate>> (response, "response is List<PortalTemplate>");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdDelete
        /// </summary>
        [Test]
        public void PortalTemplatesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalTemplatesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdExistsGet
        /// </summary>
        [Test]
        public void PortalTemplatesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalTemplatesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdFolderGet
        /// </summary>
        [Test]
        public void PortalTemplatesIdFolderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalTemplatesIdFolderGet(id, refresh);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdGet
        /// </summary>
        [Test]
        public void PortalTemplatesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.PortalTemplatesIdGet(id, filter);
            //Assert.IsInstanceOf<PortalTemplate> (response, "response is PortalTemplate");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdHead
        /// </summary>
        [Test]
        public void PortalTemplatesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalTemplatesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdPatch
        /// </summary>
        [Test]
        public void PortalTemplatesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalTemplate data = null;
            //var response = instance.PortalTemplatesIdPatch(id, data);
            //Assert.IsInstanceOf<PortalTemplate> (response, "response is PortalTemplate");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdPortalGet
        /// </summary>
        [Test]
        public void PortalTemplatesIdPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalTemplatesIdPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdPut
        /// </summary>
        [Test]
        public void PortalTemplatesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalTemplate data = null;
            //var response = instance.PortalTemplatesIdPut(id, data);
            //Assert.IsInstanceOf<PortalTemplate> (response, "response is PortalTemplate");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdReplacePost
        /// </summary>
        [Test]
        public void PortalTemplatesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalTemplate data = null;
            //var response = instance.PortalTemplatesIdReplacePost(id, data);
            //Assert.IsInstanceOf<PortalTemplate> (response, "response is PortalTemplate");
        }
        
        /// <summary>
        /// Test PortalTemplatesIdTemplateGet
        /// </summary>
        [Test]
        public void PortalTemplatesIdTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalTemplatesIdTemplateGet(id, refresh);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test PortalTemplatesPost
        /// </summary>
        [Test]
        public void PortalTemplatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalTemplate data = null;
            //var response = instance.PortalTemplatesPost(data);
            //Assert.IsInstanceOf<PortalTemplate> (response, "response is PortalTemplate");
        }
        
    }

}
