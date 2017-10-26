/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.4
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
    ///  Class for testing QTaskApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class QTaskApiTests
    {
        private QTaskApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QTaskApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QTaskApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' QTaskApi
            //Assert.IsInstanceOfType(typeof(QTaskApi), instance, "instance is a QTaskApi");
        }

        
        /// <summary>
        /// Test QTasksChangeStreamGet
        /// </summary>
        [Test]
        public void QTasksChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.QTasksChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test QTasksChangeStreamPost
        /// </summary>
        [Test]
        public void QTasksChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.QTasksChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test QTasksCountGet
        /// </summary>
        [Test]
        public void QTasksCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.QTasksCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test QTasksFindOneGet
        /// </summary>
        [Test]
        public void QTasksFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.QTasksFindOneGet(filter);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksGet
        /// </summary>
        [Test]
        public void QTasksGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.QTasksGet(filter);
            //Assert.IsInstanceOf<List<QTask>> (response, "response is List<QTask>");
        }
        
        /// <summary>
        /// Test QTasksIdDelete
        /// </summary>
        [Test]
        public void QTasksIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.QTasksIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test QTasksIdExistsGet
        /// </summary>
        [Test]
        public void QTasksIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.QTasksIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test QTasksIdGet
        /// </summary>
        [Test]
        public void QTasksIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.QTasksIdGet(id, filter);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksIdHead
        /// </summary>
        [Test]
        public void QTasksIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.QTasksIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test QTasksIdItemGet
        /// </summary>
        [Test]
        public void QTasksIdItemGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.QTasksIdItemGet(id, refresh);
            //Assert.IsInstanceOf<PersistedModel> (response, "response is PersistedModel");
        }
        
        /// <summary>
        /// Test QTasksIdPatch
        /// </summary>
        [Test]
        public void QTasksIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //QTask data = null;
            //var response = instance.QTasksIdPatch(id, data);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksIdPut
        /// </summary>
        [Test]
        public void QTasksIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //QTask data = null;
            //var response = instance.QTasksIdPut(id, data);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksIdReplacePost
        /// </summary>
        [Test]
        public void QTasksIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //QTask data = null;
            //var response = instance.QTasksIdReplacePost(id, data);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksPatch
        /// </summary>
        [Test]
        public void QTasksPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QTask data = null;
            //var response = instance.QTasksPatch(data);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksPost
        /// </summary>
        [Test]
        public void QTasksPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QTask data = null;
            //var response = instance.QTasksPost(data);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksPut
        /// </summary>
        [Test]
        public void QTasksPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QTask data = null;
            //var response = instance.QTasksPut(data);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksReplaceOrCreatePost
        /// </summary>
        [Test]
        public void QTasksReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QTask data = null;
            //var response = instance.QTasksReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
        /// <summary>
        /// Test QTasksUpdatePost
        /// </summary>
        [Test]
        public void QTasksUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //QTask data = null;
            //var response = instance.QTasksUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test QTasksUpsertWithWherePost
        /// </summary>
        [Test]
        public void QTasksUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //QTask data = null;
            //var response = instance.QTasksUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<QTask> (response, "response is QTask");
        }
        
    }

}
