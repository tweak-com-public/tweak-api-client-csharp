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
    ///  Class for testing DataSourceMsSqlApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataSourceMsSqlApiTests
    {
        private DataSourceMsSqlApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataSourceMsSqlApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataSourceMsSqlApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataSourceMsSqlApi
            //Assert.IsInstanceOfType(typeof(DataSourceMsSqlApi), instance, "instance is a DataSourceMsSqlApi");
        }

        
        /// <summary>
        /// Test DataSourceMsSqlsChangeStreamGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceMsSqlsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsChangeStreamPost
        /// </summary>
        [Test]
        public void DataSourceMsSqlsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceMsSqlsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsCountGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DataSourceMsSqlsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsFindOneGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceMsSqlsFindOneGet(filter);
            //Assert.IsInstanceOf<DataSourceMsSql> (response, "response is DataSourceMsSql");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceMsSqlsGet(filter);
            //Assert.IsInstanceOf<List<DataSourceMsSql>> (response, "response is List<DataSourceMsSql>");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdDelete
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMsSqlsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdDynamicDatasCountGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdDynamicDatasCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DataSourceMsSqlsIdDynamicDatasCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdDynamicDatasDelete
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdDynamicDatasDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DataSourceMsSqlsIdDynamicDatasDelete(id);
            
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdDynamicDatasFkDelete
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdDynamicDatasFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DataSourceMsSqlsIdDynamicDatasFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdDynamicDatasFkGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdDynamicDatasFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DataSourceMsSqlsIdDynamicDatasFkGet(id, fk);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdDynamicDatasFkPut
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdDynamicDatasFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DynamicData data = null;
            //var response = instance.DataSourceMsSqlsIdDynamicDatasFkPut(id, fk, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdDynamicDatasGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdDynamicDatasGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceMsSqlsIdDynamicDatasGet(id, filter);
            //Assert.IsInstanceOf<List<DynamicData>> (response, "response is List<DynamicData>");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdDynamicDatasPost
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdDynamicDatasPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DataSourceMsSqlsIdDynamicDatasPost(id, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdExistsGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMsSqlsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceMsSqlsIdGet(id, filter);
            //Assert.IsInstanceOf<DataSourceMsSql> (response, "response is DataSourceMsSql");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdHead
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMsSqlsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdPatch
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMsSql data = null;
            //var response = instance.DataSourceMsSqlsIdPatch(id, data);
            //Assert.IsInstanceOf<DataSourceMsSql> (response, "response is DataSourceMsSql");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdPut
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMsSql data = null;
            //var response = instance.DataSourceMsSqlsIdPut(id, data);
            //Assert.IsInstanceOf<DataSourceMsSql> (response, "response is DataSourceMsSql");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdReplacePost
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMsSql data = null;
            //var response = instance.DataSourceMsSqlsIdReplacePost(id, data);
            //Assert.IsInstanceOf<DataSourceMsSql> (response, "response is DataSourceMsSql");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsIdTeamGet
        /// </summary>
        [Test]
        public void DataSourceMsSqlsIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceMsSqlsIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test DataSourceMsSqlsPost
        /// </summary>
        [Test]
        public void DataSourceMsSqlsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceMsSql data = null;
            //var response = instance.DataSourceMsSqlsPost(data);
            //Assert.IsInstanceOf<DataSourceMsSql> (response, "response is DataSourceMsSql");
        }
        
    }

}
