/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-beta.1
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
    ///  Class for testing DataSourceRecordValueApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataSourceRecordValueApiTests
    {
        private DataSourceRecordValueApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataSourceRecordValueApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataSourceRecordValueApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataSourceRecordValueApi
            //Assert.IsInstanceOfType(typeof(DataSourceRecordValueApi), instance, "instance is a DataSourceRecordValueApi");
        }

        
        /// <summary>
        /// Test DataSourceRecordValuesChangeStreamGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceRecordValuesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesChangeStreamPost
        /// </summary>
        [Test]
        public void DataSourceRecordValuesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceRecordValuesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesCountGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DataSourceRecordValuesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesFindOneGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceRecordValuesFindOneGet(filter);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceRecordValuesGet(filter);
            //Assert.IsInstanceOf<List<DataSourceRecordValue>> (response, "response is List<DataSourceRecordValue>");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdDataSourceGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdDataSourceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceRecordValuesIdDataSourceGet(id, refresh);
            //Assert.IsInstanceOf<DataSource> (response, "response is DataSource");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdDelete
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceRecordValuesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdExistsGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceRecordValuesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceRecordValuesIdGet(id, filter);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdHead
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceRecordValuesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdKeyGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdKeyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceRecordValuesIdKeyGet(id, refresh);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdPatch
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesIdPatch(id, data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdPut
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesIdPut(id, data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdReplacePost
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesIdReplacePost(id, data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdTeamGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceRecordValuesIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesIdValuesGet
        /// </summary>
        [Test]
        public void DataSourceRecordValuesIdValuesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceRecordValuesIdValuesGet(id, refresh);
            //Assert.IsInstanceOf<DataSourceRecord> (response, "response is DataSourceRecord");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesPatch
        /// </summary>
        [Test]
        public void DataSourceRecordValuesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesPatch(data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesPost
        /// </summary>
        [Test]
        public void DataSourceRecordValuesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesPost(data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesPut
        /// </summary>
        [Test]
        public void DataSourceRecordValuesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesPut(data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DataSourceRecordValuesReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesUpdatePost
        /// </summary>
        [Test]
        public void DataSourceRecordValuesUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourceRecordValuesUpsertWithWherePost
        /// </summary>
        [Test]
        public void DataSourceRecordValuesUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourceRecordValuesUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
    }

}
