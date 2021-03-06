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
    ///  Class for testing PortalPermissionSetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PortalPermissionSetApiTests
    {
        private PortalPermissionSetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PortalPermissionSetApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PortalPermissionSetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PortalPermissionSetApi
            //Assert.IsInstanceOfType(typeof(PortalPermissionSetApi), instance, "instance is a PortalPermissionSetApi");
        }

        
        /// <summary>
        /// Test PortalPermissionSetsChangeStreamGet
        /// </summary>
        [Test]
        public void PortalPermissionSetsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalPermissionSetsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsChangeStreamPost
        /// </summary>
        [Test]
        public void PortalPermissionSetsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalPermissionSetsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsCountGet
        /// </summary>
        [Test]
        public void PortalPermissionSetsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.PortalPermissionSetsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsFindOneGet
        /// </summary>
        [Test]
        public void PortalPermissionSetsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalPermissionSetsFindOneGet(filter);
            //Assert.IsInstanceOf<PortalPermissionSet> (response, "response is PortalPermissionSet");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsGet
        /// </summary>
        [Test]
        public void PortalPermissionSetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalPermissionSetsGet(filter);
            //Assert.IsInstanceOf<List<PortalPermissionSet>> (response, "response is List<PortalPermissionSet>");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsIdDelete
        /// </summary>
        [Test]
        public void PortalPermissionSetsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalPermissionSetsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsIdExistsGet
        /// </summary>
        [Test]
        public void PortalPermissionSetsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalPermissionSetsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsIdGet
        /// </summary>
        [Test]
        public void PortalPermissionSetsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.PortalPermissionSetsIdGet(id, filter);
            //Assert.IsInstanceOf<PortalPermissionSet> (response, "response is PortalPermissionSet");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsIdHead
        /// </summary>
        [Test]
        public void PortalPermissionSetsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalPermissionSetsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsIdPatch
        /// </summary>
        [Test]
        public void PortalPermissionSetsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalPermissionSet data = null;
            //var response = instance.PortalPermissionSetsIdPatch(id, data);
            //Assert.IsInstanceOf<PortalPermissionSet> (response, "response is PortalPermissionSet");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsIdPortalGet
        /// </summary>
        [Test]
        public void PortalPermissionSetsIdPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalPermissionSetsIdPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsIdPut
        /// </summary>
        [Test]
        public void PortalPermissionSetsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalPermissionSet data = null;
            //var response = instance.PortalPermissionSetsIdPut(id, data);
            //Assert.IsInstanceOf<PortalPermissionSet> (response, "response is PortalPermissionSet");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsIdReplacePost
        /// </summary>
        [Test]
        public void PortalPermissionSetsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalPermissionSet data = null;
            //var response = instance.PortalPermissionSetsIdReplacePost(id, data);
            //Assert.IsInstanceOf<PortalPermissionSet> (response, "response is PortalPermissionSet");
        }
        
        /// <summary>
        /// Test PortalPermissionSetsPost
        /// </summary>
        [Test]
        public void PortalPermissionSetsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalPermissionSet data = null;
            //var response = instance.PortalPermissionSetsPost(data);
            //Assert.IsInstanceOf<PortalPermissionSet> (response, "response is PortalPermissionSet");
        }
        
    }

}
