/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.4
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
    ///  Class for testing ProductGroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductGroupApiTests
    {
        private ProductGroupApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductGroupApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductGroupApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductGroupApi
            //Assert.IsInstanceOfType(typeof(ProductGroupApi), instance, "instance is a ProductGroupApi");
        }

        
        /// <summary>
        /// Test ProductGroupsChangeStreamGet
        /// </summary>
        [Test]
        public void ProductGroupsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductGroupsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductGroupsChangeStreamPost
        /// </summary>
        [Test]
        public void ProductGroupsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductGroupsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductGroupsCountGet
        /// </summary>
        [Test]
        public void ProductGroupsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ProductGroupsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ProductGroupsFindOneGet
        /// </summary>
        [Test]
        public void ProductGroupsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductGroupsFindOneGet(filter);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsGet
        /// </summary>
        [Test]
        public void ProductGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductGroupsGet(filter);
            //Assert.IsInstanceOf<List<ProductGroup>> (response, "response is List<ProductGroup>");
        }
        
        /// <summary>
        /// Test ProductGroupsIdDelete
        /// </summary>
        [Test]
        public void ProductGroupsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductGroupsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ProductGroupsIdExistsGet
        /// </summary>
        [Test]
        public void ProductGroupsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductGroupsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductGroupsIdGet
        /// </summary>
        [Test]
        public void ProductGroupsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductGroupsIdGet(id, filter);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsIdHead
        /// </summary>
        [Test]
        public void ProductGroupsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductGroupsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductGroupsIdPatch
        /// </summary>
        [Test]
        public void ProductGroupsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductGroup data = null;
            //var response = instance.ProductGroupsIdPatch(id, data);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsIdPut
        /// </summary>
        [Test]
        public void ProductGroupsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductGroup data = null;
            //var response = instance.ProductGroupsIdPut(id, data);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsIdReplacePost
        /// </summary>
        [Test]
        public void ProductGroupsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductGroup data = null;
            //var response = instance.ProductGroupsIdReplacePost(id, data);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsIdTypesCountGet
        /// </summary>
        [Test]
        public void ProductGroupsIdTypesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ProductGroupsIdTypesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ProductGroupsIdTypesDelete
        /// </summary>
        [Test]
        public void ProductGroupsIdTypesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ProductGroupsIdTypesDelete(id);
            
        }
        
        /// <summary>
        /// Test ProductGroupsIdTypesFkDelete
        /// </summary>
        [Test]
        public void ProductGroupsIdTypesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ProductGroupsIdTypesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ProductGroupsIdTypesFkGet
        /// </summary>
        [Test]
        public void ProductGroupsIdTypesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ProductGroupsIdTypesFkGet(id, fk);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductGroupsIdTypesFkPut
        /// </summary>
        [Test]
        public void ProductGroupsIdTypesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ProductType data = null;
            //var response = instance.ProductGroupsIdTypesFkPut(id, fk, data);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductGroupsIdTypesGet
        /// </summary>
        [Test]
        public void ProductGroupsIdTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductGroupsIdTypesGet(id, filter);
            //Assert.IsInstanceOf<List<ProductType>> (response, "response is List<ProductType>");
        }
        
        /// <summary>
        /// Test ProductGroupsIdTypesPost
        /// </summary>
        [Test]
        public void ProductGroupsIdTypesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductType data = null;
            //var response = instance.ProductGroupsIdTypesPost(id, data);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductGroupsPatch
        /// </summary>
        [Test]
        public void ProductGroupsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductGroup data = null;
            //var response = instance.ProductGroupsPatch(data);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsPost
        /// </summary>
        [Test]
        public void ProductGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductGroup data = null;
            //var response = instance.ProductGroupsPost(data);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsPut
        /// </summary>
        [Test]
        public void ProductGroupsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductGroup data = null;
            //var response = instance.ProductGroupsPut(data);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ProductGroupsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductGroup data = null;
            //var response = instance.ProductGroupsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
        /// <summary>
        /// Test ProductGroupsUpdatePost
        /// </summary>
        [Test]
        public void ProductGroupsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductGroup data = null;
            //var response = instance.ProductGroupsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductGroupsUpsertWithWherePost
        /// </summary>
        [Test]
        public void ProductGroupsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductGroup data = null;
            //var response = instance.ProductGroupsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<ProductGroup> (response, "response is ProductGroup");
        }
        
    }

}
