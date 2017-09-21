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
    ///  Class for testing DataSourceKeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataSourceKeyApiTests
    {
        private DataSourceKeyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataSourceKeyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataSourceKeyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataSourceKeyApi
            //Assert.IsInstanceOfType(typeof(DataSourceKeyApi), instance, "instance is a DataSourceKeyApi");
        }

        
        /// <summary>
        /// Test DataSourcesChangeStreamGet
        /// </summary>
        [Test]
        public void DataSourcesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourcesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourcesChangeStreamPost
        /// </summary>
        [Test]
        public void DataSourcesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourcesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourcesCountGet
        /// </summary>
        [Test]
        public void DataSourcesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DataSourcesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DataSourcesFindOneGet
        /// </summary>
        [Test]
        public void DataSourcesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourcesFindOneGet(filter);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesGet
        /// </summary>
        [Test]
        public void DataSourcesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourcesGet(filter);
            //Assert.IsInstanceOf<List<DataSourceKey>> (response, "response is List<DataSourceKey>");
        }
        
        /// <summary>
        /// Test DataSourcesIdDataSourceGet
        /// </summary>
        [Test]
        public void DataSourcesIdDataSourceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourcesIdDataSourceGet(id, refresh);
            //Assert.IsInstanceOf<DataSource> (response, "response is DataSource");
        }
        
        /// <summary>
        /// Test DataSourcesIdDelete
        /// </summary>
        [Test]
        public void DataSourcesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourcesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DataSourcesIdExistsGet
        /// </summary>
        [Test]
        public void DataSourcesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourcesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourcesIdGet
        /// </summary>
        [Test]
        public void DataSourcesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourcesIdGet(id, filter);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesIdHead
        /// </summary>
        [Test]
        public void DataSourcesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourcesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourcesIdPatch
        /// </summary>
        [Test]
        public void DataSourcesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceKey data = null;
            //var response = instance.DataSourcesIdPatch(id, data);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesIdPut
        /// </summary>
        [Test]
        public void DataSourcesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceKey data = null;
            //var response = instance.DataSourcesIdPut(id, data);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesIdRecordValuesCountGet
        /// </summary>
        [Test]
        public void DataSourcesIdRecordValuesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DataSourcesIdRecordValuesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DataSourcesIdRecordValuesDelete
        /// </summary>
        [Test]
        public void DataSourcesIdRecordValuesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DataSourcesIdRecordValuesDelete(id);
            
        }
        
        /// <summary>
        /// Test DataSourcesIdRecordValuesFkDelete
        /// </summary>
        [Test]
        public void DataSourcesIdRecordValuesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DataSourcesIdRecordValuesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DataSourcesIdRecordValuesFkGet
        /// </summary>
        [Test]
        public void DataSourcesIdRecordValuesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DataSourcesIdRecordValuesFkGet(id, fk);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourcesIdRecordValuesFkPut
        /// </summary>
        [Test]
        public void DataSourcesIdRecordValuesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourcesIdRecordValuesFkPut(id, fk, data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourcesIdRecordValuesGet
        /// </summary>
        [Test]
        public void DataSourcesIdRecordValuesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourcesIdRecordValuesGet(id, filter);
            //Assert.IsInstanceOf<List<DataSourceRecordValue>> (response, "response is List<DataSourceRecordValue>");
        }
        
        /// <summary>
        /// Test DataSourcesIdRecordValuesPost
        /// </summary>
        [Test]
        public void DataSourcesIdRecordValuesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceRecordValue data = null;
            //var response = instance.DataSourcesIdRecordValuesPost(id, data);
            //Assert.IsInstanceOf<DataSourceRecordValue> (response, "response is DataSourceRecordValue");
        }
        
        /// <summary>
        /// Test DataSourcesIdReplacePost
        /// </summary>
        [Test]
        public void DataSourcesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceKey data = null;
            //var response = instance.DataSourcesIdReplacePost(id, data);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesIdTeamGet
        /// </summary>
        [Test]
        public void DataSourcesIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourcesIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test DataSourcesPatch
        /// </summary>
        [Test]
        public void DataSourcesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceKey data = null;
            //var response = instance.DataSourcesPatch(data);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesPost
        /// </summary>
        [Test]
        public void DataSourcesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceKey data = null;
            //var response = instance.DataSourcesPost(data);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesPut
        /// </summary>
        [Test]
        public void DataSourcesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceKey data = null;
            //var response = instance.DataSourcesPut(data);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DataSourcesReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceKey data = null;
            //var response = instance.DataSourcesReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
        /// <summary>
        /// Test DataSourcesUpdatePost
        /// </summary>
        [Test]
        public void DataSourcesUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DataSourceKey data = null;
            //var response = instance.DataSourcesUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourcesUpsertWithWherePost
        /// </summary>
        [Test]
        public void DataSourcesUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DataSourceKey data = null;
            //var response = instance.DataSourcesUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DataSourceKey> (response, "response is DataSourceKey");
        }
        
    }

}
