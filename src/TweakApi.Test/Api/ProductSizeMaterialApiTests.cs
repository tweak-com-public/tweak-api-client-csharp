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
    ///  Class for testing ProductSizeMaterialApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductSizeMaterialApiTests
    {
        private ProductSizeMaterialApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductSizeMaterialApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductSizeMaterialApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductSizeMaterialApi
            //Assert.IsInstanceOfType(typeof(ProductSizeMaterialApi), instance, "instance is a ProductSizeMaterialApi");
        }

        
        /// <summary>
        /// Test ProductSizeMaterialsChangeStreamGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductSizeMaterialsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsChangeStreamPost
        /// </summary>
        [Test]
        public void ProductSizeMaterialsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductSizeMaterialsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsCountGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ProductSizeMaterialsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsFindOneGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductSizeMaterialsFindOneGet(filter);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductSizeMaterialsGet(filter);
            //Assert.IsInstanceOf<List<ProductSizeMaterial>> (response, "response is List<ProductSizeMaterial>");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdDelete
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductSizeMaterialsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdExistsGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductSizeMaterialsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductSizeMaterialsIdGet(id, filter);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdHead
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductSizeMaterialsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdMaterialGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdMaterialGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductSizeMaterialsIdMaterialGet(id, refresh);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdPatch
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductSizeMaterial data = null;
            //var response = instance.ProductSizeMaterialsIdPatch(id, data);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdPdfColorProfileGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdPdfColorProfileGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductSizeMaterialsIdPdfColorProfileGet(id, refresh);
            //Assert.IsInstanceOf<ProductPdfColorProfile> (response, "response is ProductPdfColorProfile");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdPut
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductSizeMaterial data = null;
            //var response = instance.ProductSizeMaterialsIdPut(id, data);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdReplacePost
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductSizeMaterial data = null;
            //var response = instance.ProductSizeMaterialsIdReplacePost(id, data);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdSizeGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdSizeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductSizeMaterialsIdSizeGet(id, refresh);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsIdTeamGet
        /// </summary>
        [Test]
        public void ProductSizeMaterialsIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductSizeMaterialsIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test ProductSizeMaterialsPost
        /// </summary>
        [Test]
        public void ProductSizeMaterialsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductSizeMaterial data = null;
            //var response = instance.ProductSizeMaterialsPost(data);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
    }

}
