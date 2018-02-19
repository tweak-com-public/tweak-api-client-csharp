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
    ///  Class for testing DataSourceMongoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DataSourceMongoApiTests
    {
        private DataSourceMongoApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DataSourceMongoApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataSourceMongoApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataSourceMongoApi
            //Assert.IsInstanceOfType(typeof(DataSourceMongoApi), instance, "instance is a DataSourceMongoApi");
        }

        
        /// <summary>
        /// Test DataSourceMongosChangeStreamGet
        /// </summary>
        [Test]
        public void DataSourceMongosChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceMongosChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceMongosChangeStreamPost
        /// </summary>
        [Test]
        public void DataSourceMongosChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DataSourceMongosChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DataSourceMongosCountGet
        /// </summary>
        [Test]
        public void DataSourceMongosCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DataSourceMongosCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceMongosFindOneGet
        /// </summary>
        [Test]
        public void DataSourceMongosFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceMongosFindOneGet(filter);
            //Assert.IsInstanceOf<DataSourceMongo> (response, "response is DataSourceMongo");
        }
        
        /// <summary>
        /// Test DataSourceMongosGet
        /// </summary>
        [Test]
        public void DataSourceMongosGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DataSourceMongosGet(filter);
            //Assert.IsInstanceOf<List<DataSourceMongo>> (response, "response is List<DataSourceMongo>");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdDelete
        /// </summary>
        [Test]
        public void DataSourceMongosIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMongosIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdDynamicDatasCountGet
        /// </summary>
        [Test]
        public void DataSourceMongosIdDynamicDatasCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DataSourceMongosIdDynamicDatasCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdDynamicDatasDelete
        /// </summary>
        [Test]
        public void DataSourceMongosIdDynamicDatasDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DataSourceMongosIdDynamicDatasDelete(id);
            
        }
        
        /// <summary>
        /// Test DataSourceMongosIdDynamicDatasFkDelete
        /// </summary>
        [Test]
        public void DataSourceMongosIdDynamicDatasFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DataSourceMongosIdDynamicDatasFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DataSourceMongosIdDynamicDatasFkGet
        /// </summary>
        [Test]
        public void DataSourceMongosIdDynamicDatasFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DataSourceMongosIdDynamicDatasFkGet(id, fk);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdDynamicDatasFkPut
        /// </summary>
        [Test]
        public void DataSourceMongosIdDynamicDatasFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DynamicData data = null;
            //var response = instance.DataSourceMongosIdDynamicDatasFkPut(id, fk, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdDynamicDatasGet
        /// </summary>
        [Test]
        public void DataSourceMongosIdDynamicDatasGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceMongosIdDynamicDatasGet(id, filter);
            //Assert.IsInstanceOf<List<DynamicData>> (response, "response is List<DynamicData>");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdDynamicDatasPost
        /// </summary>
        [Test]
        public void DataSourceMongosIdDynamicDatasPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DynamicData data = null;
            //var response = instance.DataSourceMongosIdDynamicDatasPost(id, data);
            //Assert.IsInstanceOf<DynamicData> (response, "response is DynamicData");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdExistsGet
        /// </summary>
        [Test]
        public void DataSourceMongosIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMongosIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdGet
        /// </summary>
        [Test]
        public void DataSourceMongosIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DataSourceMongosIdGet(id, filter);
            //Assert.IsInstanceOf<DataSourceMongo> (response, "response is DataSourceMongo");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdHead
        /// </summary>
        [Test]
        public void DataSourceMongosIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DataSourceMongosIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdPatch
        /// </summary>
        [Test]
        public void DataSourceMongosIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMongo data = null;
            //var response = instance.DataSourceMongosIdPatch(id, data);
            //Assert.IsInstanceOf<DataSourceMongo> (response, "response is DataSourceMongo");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdPut
        /// </summary>
        [Test]
        public void DataSourceMongosIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMongo data = null;
            //var response = instance.DataSourceMongosIdPut(id, data);
            //Assert.IsInstanceOf<DataSourceMongo> (response, "response is DataSourceMongo");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdReplacePost
        /// </summary>
        [Test]
        public void DataSourceMongosIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DataSourceMongo data = null;
            //var response = instance.DataSourceMongosIdReplacePost(id, data);
            //Assert.IsInstanceOf<DataSourceMongo> (response, "response is DataSourceMongo");
        }
        
        /// <summary>
        /// Test DataSourceMongosIdTeamGet
        /// </summary>
        [Test]
        public void DataSourceMongosIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DataSourceMongosIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test DataSourceMongosPost
        /// </summary>
        [Test]
        public void DataSourceMongosPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DataSourceMongo data = null;
            //var response = instance.DataSourceMongosPost(data);
            //Assert.IsInstanceOf<DataSourceMongo> (response, "response is DataSourceMongo");
        }
        
    }

}
