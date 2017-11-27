/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.6
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
    ///  Class for testing DesignPermissionSetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DesignPermissionSetApiTests
    {
        private DesignPermissionSetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DesignPermissionSetApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DesignPermissionSetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DesignPermissionSetApi
            //Assert.IsInstanceOfType(typeof(DesignPermissionSetApi), instance, "instance is a DesignPermissionSetApi");
        }

        
        /// <summary>
        /// Test DesignPermissionSetsChangeStreamGet
        /// </summary>
        [Test]
        public void DesignPermissionSetsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignPermissionSetsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsChangeStreamPost
        /// </summary>
        [Test]
        public void DesignPermissionSetsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignPermissionSetsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsCountGet
        /// </summary>
        [Test]
        public void DesignPermissionSetsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DesignPermissionSetsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsFindOneGet
        /// </summary>
        [Test]
        public void DesignPermissionSetsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignPermissionSetsFindOneGet(filter);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsGet
        /// </summary>
        [Test]
        public void DesignPermissionSetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignPermissionSetsGet(filter);
            //Assert.IsInstanceOf<List<DesignPermissionSet>> (response, "response is List<DesignPermissionSet>");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsIdDelete
        /// </summary>
        [Test]
        public void DesignPermissionSetsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignPermissionSetsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsIdDesignGet
        /// </summary>
        [Test]
        public void DesignPermissionSetsIdDesignGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignPermissionSetsIdDesignGet(id, refresh);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsIdExistsGet
        /// </summary>
        [Test]
        public void DesignPermissionSetsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignPermissionSetsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsIdGet
        /// </summary>
        [Test]
        public void DesignPermissionSetsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignPermissionSetsIdGet(id, filter);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsIdHead
        /// </summary>
        [Test]
        public void DesignPermissionSetsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignPermissionSetsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsIdPatch
        /// </summary>
        [Test]
        public void DesignPermissionSetsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsIdPatch(id, data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsIdPut
        /// </summary>
        [Test]
        public void DesignPermissionSetsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsIdPut(id, data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsIdReplacePost
        /// </summary>
        [Test]
        public void DesignPermissionSetsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsIdReplacePost(id, data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsPatch
        /// </summary>
        [Test]
        public void DesignPermissionSetsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsPatch(data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsPost
        /// </summary>
        [Test]
        public void DesignPermissionSetsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsPost(data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsPut
        /// </summary>
        [Test]
        public void DesignPermissionSetsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsPut(data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DesignPermissionSetsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsUpdatePost
        /// </summary>
        [Test]
        public void DesignPermissionSetsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DesignPermissionSetsUpsertWithWherePost
        /// </summary>
        [Test]
        public void DesignPermissionSetsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignPermissionSet data = null;
            //var response = instance.DesignPermissionSetsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
    }

}
