/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.13
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
    ///  Class for testing TestCacheApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TestCacheApiTests
    {
        private TestCacheApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TestCacheApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TestCacheApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TestCacheApi
            //Assert.IsInstanceOfType(typeof(TestCacheApi), instance, "instance is a TestCacheApi");
        }

        
        /// <summary>
        /// Test TestCachesChangeStreamGet
        /// </summary>
        [Test]
        public void TestCachesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TestCachesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TestCachesChangeStreamPost
        /// </summary>
        [Test]
        public void TestCachesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TestCachesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TestCachesCountGet
        /// </summary>
        [Test]
        public void TestCachesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TestCachesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TestCachesFindOneGet
        /// </summary>
        [Test]
        public void TestCachesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TestCachesFindOneGet(filter);
            //Assert.IsInstanceOf<TestCache> (response, "response is TestCache");
        }
        
        /// <summary>
        /// Test TestCachesGet
        /// </summary>
        [Test]
        public void TestCachesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TestCachesGet(filter);
            //Assert.IsInstanceOf<List<TestCache>> (response, "response is List<TestCache>");
        }
        
        /// <summary>
        /// Test TestCachesIdDelete
        /// </summary>
        [Test]
        public void TestCachesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TestCachesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TestCachesIdExistsGet
        /// </summary>
        [Test]
        public void TestCachesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TestCachesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TestCachesIdGet
        /// </summary>
        [Test]
        public void TestCachesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TestCachesIdGet(id, filter);
            //Assert.IsInstanceOf<TestCache> (response, "response is TestCache");
        }
        
        /// <summary>
        /// Test TestCachesIdHead
        /// </summary>
        [Test]
        public void TestCachesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TestCachesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TestCachesIdPatch
        /// </summary>
        [Test]
        public void TestCachesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TestCache data = null;
            //var response = instance.TestCachesIdPatch(id, data);
            //Assert.IsInstanceOf<TestCache> (response, "response is TestCache");
        }
        
        /// <summary>
        /// Test TestCachesIdPut
        /// </summary>
        [Test]
        public void TestCachesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TestCache data = null;
            //var response = instance.TestCachesIdPut(id, data);
            //Assert.IsInstanceOf<TestCache> (response, "response is TestCache");
        }
        
        /// <summary>
        /// Test TestCachesIdReplacePost
        /// </summary>
        [Test]
        public void TestCachesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TestCache data = null;
            //var response = instance.TestCachesIdReplacePost(id, data);
            //Assert.IsInstanceOf<TestCache> (response, "response is TestCache");
        }
        
        /// <summary>
        /// Test TestCachesPost
        /// </summary>
        [Test]
        public void TestCachesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TestCache data = null;
            //var response = instance.TestCachesPost(data);
            //Assert.IsInstanceOf<TestCache> (response, "response is TestCache");
        }
        
    }

}
