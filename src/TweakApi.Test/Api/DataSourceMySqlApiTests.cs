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
    ///  Class for testing DataSourceMySqlApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataSourceMySqlApiTests
    {
        private DataSourceMySqlApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataSourceMySqlApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataSourceMySqlApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataSourceMySqlApi
            //Assert.IsInstanceOfType(typeof(DataSourceMySqlApi), instance, "instance is a DataSourceMySqlApi");
        }

        
        /// <summary>
        /// Test DataSourceMySqlsChangeStreamGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceMySqlsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsChangeStreamPost
        /// </summary>
        [Test]
        public void DataSourceMySqlsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceMySqlsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsCountGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DataSourceMySqlsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsFindOneGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceMySqlsFindOneGet(filter);
            //Assert.IsInstanceOf<DataSourceMySql> (response, "response is DataSourceMySql");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceMySqlsGet(filter);
            //Assert.IsInstanceOf<List<DataSourceMySql>> (response, "response is List<DataSourceMySql>");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdDelete
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMySqlsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdDynamicDatasCountGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdDynamicDatasCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DataSourceMySqlsIdDynamicDatasCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdDynamicDatasDelete
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdDynamicDatasDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DataSourceMySqlsIdDynamicDatasDelete(id);
            
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdDynamicDatasFkDelete
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdDynamicDatasFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DataSourceMySqlsIdDynamicDatasFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdDynamicDatasFkGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdDynamicDatasFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DataSourceMySqlsIdDynamicDatasFkGet(id, fk);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdDynamicDatasFkPut
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdDynamicDatasFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DynamicData data = null;
            //var response = instance.DataSourceMySqlsIdDynamicDatasFkPut(id, fk, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdDynamicDatasGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdDynamicDatasGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceMySqlsIdDynamicDatasGet(id, filter);
            //Assert.IsInstanceOf<List<DynamicData>> (response, "response is List<DynamicData>");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdDynamicDatasPost
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdDynamicDatasPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DataSourceMySqlsIdDynamicDatasPost(id, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdExistsGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMySqlsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceMySqlsIdGet(id, filter);
            //Assert.IsInstanceOf<DataSourceMySql> (response, "response is DataSourceMySql");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdHead
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMySqlsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdPatch
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMySql data = null;
            //var response = instance.DataSourceMySqlsIdPatch(id, data);
            //Assert.IsInstanceOf<DataSourceMySql> (response, "response is DataSourceMySql");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdPut
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMySql data = null;
            //var response = instance.DataSourceMySqlsIdPut(id, data);
            //Assert.IsInstanceOf<DataSourceMySql> (response, "response is DataSourceMySql");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdReplacePost
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMySql data = null;
            //var response = instance.DataSourceMySqlsIdReplacePost(id, data);
            //Assert.IsInstanceOf<DataSourceMySql> (response, "response is DataSourceMySql");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsIdTeamGet
        /// </summary>
        [Test]
        public void DataSourceMySqlsIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceMySqlsIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test DataSourceMySqlsPost
        /// </summary>
        [Test]
        public void DataSourceMySqlsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceMySql data = null;
            //var response = instance.DataSourceMySqlsPost(data);
            //Assert.IsInstanceOf<DataSourceMySql> (response, "response is DataSourceMySql");
        }
        
    }

}
