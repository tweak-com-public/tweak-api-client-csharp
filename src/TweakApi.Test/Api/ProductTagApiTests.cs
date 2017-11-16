/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.3
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
    ///  Class for testing ProductTagApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductTagApiTests
    {
        private ProductTagApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductTagApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductTagApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductTagApi
            //Assert.IsInstanceOfType(typeof(ProductTagApi), instance, "instance is a ProductTagApi");
        }

        
        /// <summary>
        /// Test ProductTagsChangeStreamGet
        /// </summary>
        [Test]
        public void ProductTagsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductTagsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductTagsChangeStreamPost
        /// </summary>
        [Test]
        public void ProductTagsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductTagsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductTagsCountGet
        /// </summary>
        [Test]
        public void ProductTagsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ProductTagsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ProductTagsFindOneGet
        /// </summary>
        [Test]
        public void ProductTagsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductTagsFindOneGet(filter);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsGet
        /// </summary>
        [Test]
        public void ProductTagsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductTagsGet(filter);
            //Assert.IsInstanceOf<List<ProductTag>> (response, "response is List<ProductTag>");
        }
        
        /// <summary>
        /// Test ProductTagsIdDelete
        /// </summary>
        [Test]
        public void ProductTagsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductTagsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ProductTagsIdExistsGet
        /// </summary>
        [Test]
        public void ProductTagsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductTagsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductTagsIdGet
        /// </summary>
        [Test]
        public void ProductTagsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductTagsIdGet(id, filter);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsIdHead
        /// </summary>
        [Test]
        public void ProductTagsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductTagsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductTagsIdPatch
        /// </summary>
        [Test]
        public void ProductTagsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductTag data = null;
            //var response = instance.ProductTagsIdPatch(id, data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsIdProductGet
        /// </summary>
        [Test]
        public void ProductTagsIdProductGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductTagsIdProductGet(id, refresh);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductTagsIdPut
        /// </summary>
        [Test]
        public void ProductTagsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductTag data = null;
            //var response = instance.ProductTagsIdPut(id, data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsIdReplacePost
        /// </summary>
        [Test]
        public void ProductTagsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductTag data = null;
            //var response = instance.ProductTagsIdReplacePost(id, data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsIdTagGet
        /// </summary>
        [Test]
        public void ProductTagsIdTagGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductTagsIdTagGet(id, refresh);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test ProductTagsPatch
        /// </summary>
        [Test]
        public void ProductTagsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductTag data = null;
            //var response = instance.ProductTagsPatch(data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsPost
        /// </summary>
        [Test]
        public void ProductTagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductTag data = null;
            //var response = instance.ProductTagsPost(data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsPut
        /// </summary>
        [Test]
        public void ProductTagsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductTag data = null;
            //var response = instance.ProductTagsPut(data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ProductTagsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductTag data = null;
            //var response = instance.ProductTagsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test ProductTagsUpdatePost
        /// </summary>
        [Test]
        public void ProductTagsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductTag data = null;
            //var response = instance.ProductTagsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductTagsUpsertWithWherePost
        /// </summary>
        [Test]
        public void ProductTagsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductTag data = null;
            //var response = instance.ProductTagsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
    }

}
