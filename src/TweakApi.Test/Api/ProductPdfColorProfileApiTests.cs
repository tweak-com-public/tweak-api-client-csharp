/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.2
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
    ///  Class for testing ProductPdfColorProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductPdfColorProfileApiTests
    {
        private ProductPdfColorProfileApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductPdfColorProfileApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductPdfColorProfileApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductPdfColorProfileApi
            //Assert.IsInstanceOfType(typeof(ProductPdfColorProfileApi), instance, "instance is a ProductPdfColorProfileApi");
        }

        
        /// <summary>
        /// Test ProductPdfColorProfilesChangeStreamGet
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductPdfColorProfilesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesChangeStreamPost
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductPdfColorProfilesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesCountGet
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ProductPdfColorProfilesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesFindOneGet
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductPdfColorProfilesFindOneGet(filter);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesGet
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductPdfColorProfilesGet(filter);
            //Assert.IsInstanceOf<List<ProductPdfColorProfile>> (response, "response is List<ProductPdfColorProfile>");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesIdDelete
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductPdfColorProfilesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesIdExistsGet
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductPdfColorProfilesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesIdGet
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductPdfColorProfilesIdGet(id, filter);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesIdHead
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductPdfColorProfilesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesIdPatch
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesIdPatch(id, data);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesIdPut
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesIdPut(id, data);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesIdReplacePost
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesIdReplacePost(id, data);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesIdTeamGet
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductPdfColorProfilesIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesPatch
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesPatch(data);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesPost
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesPost(data);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesPut
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesPut(data);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesUpdatePost
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test ProductPdfColorProfilesUpsertWithWherePost
        /// </summary>
        [Test]
        public void ProductPdfColorProfilesUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductPdfColorProfile data = null;
            //var response = instance.ProductPdfColorProfilesUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
    }

}
