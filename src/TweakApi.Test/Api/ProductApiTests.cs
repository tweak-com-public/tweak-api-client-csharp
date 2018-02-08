/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.0
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
    ///  Class for testing ProductApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductApiTests
    {
        private ProductApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductApi
            //Assert.IsInstanceOfType(typeof(ProductApi), instance, "instance is a ProductApi");
        }

        
        /// <summary>
        /// Test ProductsChangeStreamGet
        /// </summary>
        [Test]
        public void ProductsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductsChangeStreamPost
        /// </summary>
        [Test]
        public void ProductsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductsCountGet
        /// </summary>
        [Test]
        public void ProductsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ProductsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductsFindOneGet
        /// </summary>
        [Test]
        public void ProductsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductsFindOneGet(filter);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsGet
        /// </summary>
        [Test]
        public void ProductsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductsGet(filter);
            //Assert.IsInstanceOf<List<Product>> (response, "response is List<Product>");
        }
        
        /// <summary>
        /// Test ProductsIdDelete
        /// </summary>
        [Test]
        public void ProductsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ProductsIdExistsGet
        /// </summary>
        [Test]
        public void ProductsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductsIdGet
        /// </summary>
        [Test]
        public void ProductsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductsIdGet(id, filter);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsIdHead
        /// </summary>
        [Test]
        public void ProductsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductsIdPatch
        /// </summary>
        [Test]
        public void ProductsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Product data = null;
            //var response = instance.ProductsIdPatch(id, data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsIdPut
        /// </summary>
        [Test]
        public void ProductsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Product data = null;
            //var response = instance.ProductsIdPut(id, data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsIdReplacePost
        /// </summary>
        [Test]
        public void ProductsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Product data = null;
            //var response = instance.ProductsIdReplacePost(id, data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsIdSizeGet
        /// </summary>
        [Test]
        public void ProductsIdSizeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductsIdSizeGet(id, refresh);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductsIdTagsCountGet
        /// </summary>
        [Test]
        public void ProductsIdTagsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ProductsIdTagsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductsIdTagsDelete
        /// </summary>
        [Test]
        public void ProductsIdTagsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ProductsIdTagsDelete(id);
            
        }
        
        /// <summary>
        /// Test ProductsIdTagsFkDelete
        /// </summary>
        [Test]
        public void ProductsIdTagsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ProductsIdTagsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ProductsIdTagsFkGet
        /// </summary>
        [Test]
        public void ProductsIdTagsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ProductsIdTagsFkGet(id, fk);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test ProductsIdTagsFkPut
        /// </summary>
        [Test]
        public void ProductsIdTagsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Tag data = null;
            //var response = instance.ProductsIdTagsFkPut(id, fk, data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test ProductsIdTagsGet
        /// </summary>
        [Test]
        public void ProductsIdTagsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductsIdTagsGet(id, filter);
            //Assert.IsInstanceOf<List<Tag>> (response, "response is List<Tag>");
        }
        
        /// <summary>
        /// Test ProductsIdTagsPost
        /// </summary>
        [Test]
        public void ProductsIdTagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Tag data = null;
            //var response = instance.ProductsIdTagsPost(id, data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test ProductsIdTagsRelFkDelete
        /// </summary>
        [Test]
        public void ProductsIdTagsRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ProductsIdTagsRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ProductsIdTagsRelFkHead
        /// </summary>
        [Test]
        public void ProductsIdTagsRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ProductsIdTagsRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test ProductsIdTagsRelFkPut
        /// </summary>
        [Test]
        public void ProductsIdTagsRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ProductTag data = null;
            //var response = instance.ProductsIdTagsRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductsPatch
        /// </summary>
        [Test]
        public void ProductsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Product data = null;
            //var response = instance.ProductsPatch(data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsPost
        /// </summary>
        [Test]
        public void ProductsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Product data = null;
            //var response = instance.ProductsPost(data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsPut
        /// </summary>
        [Test]
        public void ProductsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Product data = null;
            //var response = instance.ProductsPut(data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ProductsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Product data = null;
            //var response = instance.ProductsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductsUpdatePost
        /// </summary>
        [Test]
        public void ProductsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Product data = null;
            //var response = instance.ProductsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test ProductsUpsertWithWherePost
        /// </summary>
        [Test]
        public void ProductsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Product data = null;
            //var response = instance.ProductsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
    }

}
