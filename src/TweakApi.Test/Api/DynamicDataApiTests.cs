/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.1
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
    ///  Class for testing DynamicDataApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DynamicDataApiTests
    {
        private DynamicDataApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DynamicDataApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DynamicDataApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DynamicDataApi
            //Assert.IsInstanceOfType(typeof(DynamicDataApi), instance, "instance is a DynamicDataApi");
        }

        
        /// <summary>
        /// Test DynamicDataChangeStreamGet
        /// </summary>
        [Test]
        public void DynamicDataChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DynamicDataChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DynamicDataChangeStreamPost
        /// </summary>
        [Test]
        public void DynamicDataChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DynamicDataChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DynamicDataCountGet
        /// </summary>
        [Test]
        public void DynamicDataCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DynamicDataCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DynamicDataFindOneGet
        /// </summary>
        [Test]
        public void DynamicDataFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DynamicDataFindOneGet(filter);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataGet
        /// </summary>
        [Test]
        public void DynamicDataGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DynamicDataGet(filter);
            //Assert.IsInstanceOf<List<DynamicData>> (response, "response is List<DynamicData>");
        }
        
        /// <summary>
        /// Test DynamicDataIdDelete
        /// </summary>
        [Test]
        public void DynamicDataIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DynamicDataIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DynamicDataIdExistsGet
        /// </summary>
        [Test]
        public void DynamicDataIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DynamicDataIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DynamicDataIdGet
        /// </summary>
        [Test]
        public void DynamicDataIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DynamicDataIdGet(id, filter);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataIdHead
        /// </summary>
        [Test]
        public void DynamicDataIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DynamicDataIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DynamicDataIdPatch
        /// </summary>
        [Test]
        public void DynamicDataIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DynamicDataIdPatch(id, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataIdPut
        /// </summary>
        [Test]
        public void DynamicDataIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DynamicDataIdPut(id, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsCountGet
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DynamicDataIdRecordsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsDelete
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DynamicDataIdRecordsDelete(id, where);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsFkDelete
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DynamicDataIdRecordsFkDelete(id, fk);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsFkGet
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //string filter = null;
            //var response = instance.DynamicDataIdRecordsFkGet(id, fk, filter);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsFkPut
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DynamicData data = null;
            //var response = instance.DynamicDataIdRecordsFkPut(id, fk, data);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsGet
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DynamicDataIdRecordsGet(id, filter);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsMigratePost
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsMigratePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DynamicDataIdRecordsMigratePost(id, data);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsPost
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DynamicDataIdRecordsPost(id, data);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DynamicDataIdRecordsUploadCsvPost
        /// </summary>
        [Test]
        public void DynamicDataIdRecordsUploadCsvPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DynamicDataIdRecordsUploadCsvPost(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DynamicDataIdReplacePost
        /// </summary>
        [Test]
        public void DynamicDataIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DynamicDataIdReplacePost(id, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataIdTeamGet
        /// </summary>
        [Test]
        public void DynamicDataIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DynamicDataIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test DynamicDataPatch
        /// </summary>
        [Test]
        public void DynamicDataPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DynamicData data = null;
            //var response = instance.DynamicDataPatch(data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataPost
        /// </summary>
        [Test]
        public void DynamicDataPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DynamicData data = null;
            //var response = instance.DynamicDataPost(data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataPut
        /// </summary>
        [Test]
        public void DynamicDataPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DynamicData data = null;
            //var response = instance.DynamicDataPut(data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DynamicDataReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DynamicData data = null;
            //var response = instance.DynamicDataReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DynamicDataUpdatePost
        /// </summary>
        [Test]
        public void DynamicDataUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DynamicData data = null;
            //var response = instance.DynamicDataUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DynamicDataUpsertWithWherePost
        /// </summary>
        [Test]
        public void DynamicDataUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DynamicData data = null;
            //var response = instance.DynamicDataUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
    }

}
