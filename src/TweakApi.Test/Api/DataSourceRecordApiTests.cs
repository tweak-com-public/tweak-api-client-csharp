/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.12
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
    ///  Class for testing DataSourceRecordApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataSourceRecordApiTests
    {
        private DataSourceRecordApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataSourceRecordApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataSourceRecordApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataSourceRecordApi
            //Assert.IsInstanceOfType(typeof(DataSourceRecordApi), instance, "instance is a DataSourceRecordApi");
        }

        
        /// <summary>
        /// Test DataSourceRecordsChangeStreamGet
        /// </summary>
        [Test]
        public void DataSourceRecordsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceRecordsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceRecordsChangeStreamPost
        /// </summary>
        [Test]
        public void DataSourceRecordsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceRecordsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceRecordsCountGet
        /// </summary>
        [Test]
        public void DataSourceRecordsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DataSourceRecordsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DataSourceRecordsFindOneGet
        /// </summary>
        [Test]
        public void DataSourceRecordsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceRecordsFindOneGet(filter);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsGet
        /// </summary>
        [Test]
        public void DataSourceRecordsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceRecordsGet(filter);
            //Assert.IsInstanceOf<List<DataSourceRecord>> (response, "response is List<DataSourceRecord>");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdDataSourceGet
        /// </summary>
        [Test]
        public void DataSourceRecordsIdDataSourceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceRecordsIdDataSourceGet(id, refresh);
            //Assert.IsInstanceOf<DataSource> (response, "response is DataSource");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdDelete
        /// </summary>
        [Test]
        public void DataSourceRecordsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceRecordsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdExistsGet
        /// </summary>
        [Test]
        public void DataSourceRecordsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceRecordsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdGet
        /// </summary>
        [Test]
        public void DataSourceRecordsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceRecordsIdGet(id, filter);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdHead
        /// </summary>
        [Test]
        public void DataSourceRecordsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceRecordsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdPatch
        /// </summary>
        [Test]
        public void DataSourceRecordsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsIdPatch(id, data);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdPut
        /// </summary>
        [Test]
        public void DataSourceRecordsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsIdPut(id, data);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdReplacePost
        /// </summary>
        [Test]
        public void DataSourceRecordsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsIdReplacePost(id, data);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdTeamGet
        /// </summary>
        [Test]
        public void DataSourceRecordsIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceRecordsIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdValuesCountGet
        /// </summary>
        [Test]
        public void DataSourceRecordsIdValuesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DataSourceRecordsIdValuesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdValuesDelete
        /// </summary>
        [Test]
        public void DataSourceRecordsIdValuesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DataSourceRecordsIdValuesDelete(id);
            
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdValuesFkDelete
        /// </summary>
        [Test]
        public void DataSourceRecordsIdValuesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DataSourceRecordsIdValuesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdValuesFkGet
        /// </summary>
        [Test]
        public void DataSourceRecordsIdValuesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DataSourceRecordsIdValuesFkGet(id, fk);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdValuesFkPut
        /// </summary>
        [Test]
        public void DataSourceRecordsIdValuesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordsIdValuesFkPut(id, fk, data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdValuesGet
        /// </summary>
        [Test]
        public void DataSourceRecordsIdValuesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceRecordsIdValuesGet(id, filter);
            //Assert.IsInstanceOf<List<DataSourceRecordValue>> (response, "response is List<DataSourceRecordValue>");
        }
        
        /// <summary>
        /// Test DataSourceRecordsIdValuesPost
        /// </summary>
        [Test]
        public void DataSourceRecordsIdValuesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordsIdValuesPost(id, data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordsPatch
        /// </summary>
        [Test]
        public void DataSourceRecordsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsPatch(data);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsPost
        /// </summary>
        [Test]
        public void DataSourceRecordsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsPost(data);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsPut
        /// </summary>
        [Test]
        public void DataSourceRecordsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsPut(data);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DataSourceRecordsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordsUpdatePost
        /// </summary>
        [Test]
        public void DataSourceRecordsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourceRecordsUpsertWithWherePost
        /// </summary>
        [Test]
        public void DataSourceRecordsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DataSourceRecord data = null;
            //var response = instance.DataSourceRecordsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
    }

}
