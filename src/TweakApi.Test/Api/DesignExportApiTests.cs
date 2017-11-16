/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.3
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
    ///  Class for testing DesignExportApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DesignExportApiTests
    {
        private DesignExportApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DesignExportApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DesignExportApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DesignExportApi
            //Assert.IsInstanceOfType(typeof(DesignExportApi), instance, "instance is a DesignExportApi");
        }

        
        /// <summary>
        /// Test DesignExportsChangeStreamGet
        /// </summary>
        [Test]
        public void DesignExportsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignExportsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignExportsChangeStreamPost
        /// </summary>
        [Test]
        public void DesignExportsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignExportsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignExportsCountGet
        /// </summary>
        [Test]
        public void DesignExportsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DesignExportsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignExportsFindOneGet
        /// </summary>
        [Test]
        public void DesignExportsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignExportsFindOneGet(filter);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsGet
        /// </summary>
        [Test]
        public void DesignExportsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignExportsGet(filter);
            //Assert.IsInstanceOf<List<DesignExport>> (response, "response is List<DesignExport>");
        }
        
        /// <summary>
        /// Test DesignExportsIdDelete
        /// </summary>
        [Test]
        public void DesignExportsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignExportsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DesignExportsIdDesignsGet
        /// </summary>
        [Test]
        public void DesignExportsIdDesignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignExportsIdDesignsGet(id, refresh);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignExportsIdExistsGet
        /// </summary>
        [Test]
        public void DesignExportsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignExportsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignExportsIdGet
        /// </summary>
        [Test]
        public void DesignExportsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignExportsIdGet(id, filter);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsIdHead
        /// </summary>
        [Test]
        public void DesignExportsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignExportsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignExportsIdPatch
        /// </summary>
        [Test]
        public void DesignExportsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignExport data = null;
            //var response = instance.DesignExportsIdPatch(id, data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsIdPut
        /// </summary>
        [Test]
        public void DesignExportsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignExport data = null;
            //var response = instance.DesignExportsIdPut(id, data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsIdReplacePost
        /// </summary>
        [Test]
        public void DesignExportsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignExport data = null;
            //var response = instance.DesignExportsIdReplacePost(id, data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsIdRequesterGet
        /// </summary>
        [Test]
        public void DesignExportsIdRequesterGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignExportsIdRequesterGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignExportsPatch
        /// </summary>
        [Test]
        public void DesignExportsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignExport data = null;
            //var response = instance.DesignExportsPatch(data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsPost
        /// </summary>
        [Test]
        public void DesignExportsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignExport data = null;
            //var response = instance.DesignExportsPost(data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsPut
        /// </summary>
        [Test]
        public void DesignExportsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignExport data = null;
            //var response = instance.DesignExportsPut(data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DesignExportsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignExport data = null;
            //var response = instance.DesignExportsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignExportsUpdatePost
        /// </summary>
        [Test]
        public void DesignExportsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignExport data = null;
            //var response = instance.DesignExportsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DesignExportsUpsertWithWherePost
        /// </summary>
        [Test]
        public void DesignExportsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignExport data = null;
            //var response = instance.DesignExportsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
    }

}
