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
    ///  Class for testing ProductTypeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductTypeApiTests
    {
        private ProductTypeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductTypeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductTypeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductTypeApi
            //Assert.IsInstanceOfType(typeof(ProductTypeApi), instance, "instance is a ProductTypeApi");
        }

        
        /// <summary>
        /// Test ProductTypesChangeStreamGet
        /// </summary>
        [Test]
        public void ProductTypesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductTypesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductTypesChangeStreamPost
        /// </summary>
        [Test]
        public void ProductTypesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductTypesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductTypesCountGet
        /// </summary>
        [Test]
        public void ProductTypesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ProductTypesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductTypesFindOneGet
        /// </summary>
        [Test]
        public void ProductTypesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductTypesFindOneGet(filter);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductTypesGet
        /// </summary>
        [Test]
        public void ProductTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductTypesGet(filter);
            //Assert.IsInstanceOf<List<ProductType>> (response, "response is List<ProductType>");
        }
        
        /// <summary>
        /// Test ProductTypesIdDelete
        /// </summary>
        [Test]
        public void ProductTypesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductTypesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ProductTypesIdExistsGet
        /// </summary>
        [Test]
        public void ProductTypesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductTypesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductTypesIdGet
        /// </summary>
        [Test]
        public void ProductTypesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductTypesIdGet(id, filter);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductTypesIdGroupGet
        /// </summary>
        [Test]
        public void ProductTypesIdGroupGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductTypesIdGroupGet(id, refresh);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductTypesIdHead
        /// </summary>
        [Test]
        public void ProductTypesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductTypesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductTypesIdPatch
        /// </summary>
        [Test]
        public void ProductTypesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductType data = null;
            //var response = instance.ProductTypesIdPatch(id, data);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductTypesIdPut
        /// </summary>
        [Test]
        public void ProductTypesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductType data = null;
            //var response = instance.ProductTypesIdPut(id, data);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductTypesIdReplacePost
        /// </summary>
        [Test]
        public void ProductTypesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductType data = null;
            //var response = instance.ProductTypesIdReplacePost(id, data);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductTypesIdSizesCountGet
        /// </summary>
        [Test]
        public void ProductTypesIdSizesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ProductTypesIdSizesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductTypesIdSizesFkDelete
        /// </summary>
        [Test]
        public void ProductTypesIdSizesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ProductTypesIdSizesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ProductTypesIdSizesFkGet
        /// </summary>
        [Test]
        public void ProductTypesIdSizesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ProductTypesIdSizesFkGet(id, fk);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductTypesIdSizesFkPut
        /// </summary>
        [Test]
        public void ProductTypesIdSizesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ProductSize data = null;
            //var response = instance.ProductTypesIdSizesFkPut(id, fk, data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductTypesIdSizesGet
        /// </summary>
        [Test]
        public void ProductTypesIdSizesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductTypesIdSizesGet(id, filter);
            //Assert.IsInstanceOf<List<ProductSize>> (response, "response is List<ProductSize>");
        }
        
        /// <summary>
        /// Test ProductTypesIdSizesPost
        /// </summary>
        [Test]
        public void ProductTypesIdSizesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductSize data = null;
            //var response = instance.ProductTypesIdSizesPost(id, data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductTypesPost
        /// </summary>
        [Test]
        public void ProductTypesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductType data = null;
            //var response = instance.ProductTypesPost(data);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
    }

}
