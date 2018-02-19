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
    ///  Class for testing DataSourcePostgreSqlApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataSourcePostgreSqlApiTests
    {
        private DataSourcePostgreSqlApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataSourcePostgreSqlApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataSourcePostgreSqlApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataSourcePostgreSqlApi
            //Assert.IsInstanceOfType(typeof(DataSourcePostgreSqlApi), instance, "instance is a DataSourcePostgreSqlApi");
        }

        
        /// <summary>
        /// Test DataSourcePostgreSqlsChangeStreamGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourcePostgreSqlsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsChangeStreamPost
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourcePostgreSqlsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsCountGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DataSourcePostgreSqlsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsFindOneGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourcePostgreSqlsFindOneGet(filter);
            //Assert.IsInstanceOf<DataSourcePostgreSql> (response, "response is DataSourcePostgreSql");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourcePostgreSqlsGet(filter);
            //Assert.IsInstanceOf<List<DataSourcePostgreSql>> (response, "response is List<DataSourcePostgreSql>");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdDelete
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourcePostgreSqlsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdDynamicDatasCountGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdDynamicDatasCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DataSourcePostgreSqlsIdDynamicDatasCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdDynamicDatasDelete
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdDynamicDatasDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DataSourcePostgreSqlsIdDynamicDatasDelete(id);
            
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdDynamicDatasFkDelete
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdDynamicDatasFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DataSourcePostgreSqlsIdDynamicDatasFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdDynamicDatasFkGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdDynamicDatasFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DataSourcePostgreSqlsIdDynamicDatasFkGet(id, fk);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdDynamicDatasFkPut
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdDynamicDatasFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DynamicData data = null;
            //var response = instance.DataSourcePostgreSqlsIdDynamicDatasFkPut(id, fk, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdDynamicDatasGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdDynamicDatasGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourcePostgreSqlsIdDynamicDatasGet(id, filter);
            //Assert.IsInstanceOf<List<DynamicData>> (response, "response is List<DynamicData>");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdDynamicDatasPost
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdDynamicDatasPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DataSourcePostgreSqlsIdDynamicDatasPost(id, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdExistsGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourcePostgreSqlsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourcePostgreSqlsIdGet(id, filter);
            //Assert.IsInstanceOf<DataSourcePostgreSql> (response, "response is DataSourcePostgreSql");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdHead
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourcePostgreSqlsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdPatch
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourcePostgreSql data = null;
            //var response = instance.DataSourcePostgreSqlsIdPatch(id, data);
            //Assert.IsInstanceOf<DataSourcePostgreSql> (response, "response is DataSourcePostgreSql");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdPut
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourcePostgreSql data = null;
            //var response = instance.DataSourcePostgreSqlsIdPut(id, data);
            //Assert.IsInstanceOf<DataSourcePostgreSql> (response, "response is DataSourcePostgreSql");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdReplacePost
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourcePostgreSql data = null;
            //var response = instance.DataSourcePostgreSqlsIdReplacePost(id, data);
            //Assert.IsInstanceOf<DataSourcePostgreSql> (response, "response is DataSourcePostgreSql");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsIdTeamGet
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourcePostgreSqlsIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test DataSourcePostgreSqlsPost
        /// </summary>
        [Test]
        public void DataSourcePostgreSqlsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourcePostgreSql data = null;
            //var response = instance.DataSourcePostgreSqlsPost(data);
            //Assert.IsInstanceOf<DataSourcePostgreSql> (response, "response is DataSourcePostgreSql");
        }
        
    }

}
