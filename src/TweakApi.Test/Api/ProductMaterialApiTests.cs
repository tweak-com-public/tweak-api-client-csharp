/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.7-beta.3
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
    ///  Class for testing ProductMaterialApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductMaterialApiTests
    {
        private ProductMaterialApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductMaterialApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductMaterialApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductMaterialApi
            //Assert.IsInstanceOfType(typeof(ProductMaterialApi), instance, "instance is a ProductMaterialApi");
        }

        
        /// <summary>
        /// Test ProductMaterialsChangeStreamGet
        /// </summary>
        [Test]
        public void ProductMaterialsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductMaterialsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductMaterialsChangeStreamPost
        /// </summary>
        [Test]
        public void ProductMaterialsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductMaterialsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductMaterialsCountGet
        /// </summary>
        [Test]
        public void ProductMaterialsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ProductMaterialsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductMaterialsFindOneGet
        /// </summary>
        [Test]
        public void ProductMaterialsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductMaterialsFindOneGet(filter);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsGet
        /// </summary>
        [Test]
        public void ProductMaterialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductMaterialsGet(filter);
            //Assert.IsInstanceOf<List<ProductMaterial>> (response, "response is List<ProductMaterial>");
        }
        
        /// <summary>
        /// Test ProductMaterialsIdDelete
        /// </summary>
        [Test]
        public void ProductMaterialsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductMaterialsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ProductMaterialsIdExistsGet
        /// </summary>
        [Test]
        public void ProductMaterialsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductMaterialsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductMaterialsIdGet
        /// </summary>
        [Test]
        public void ProductMaterialsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductMaterialsIdGet(id, filter);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsIdHead
        /// </summary>
        [Test]
        public void ProductMaterialsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductMaterialsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductMaterialsIdPatch
        /// </summary>
        [Test]
        public void ProductMaterialsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsIdPatch(id, data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsIdPut
        /// </summary>
        [Test]
        public void ProductMaterialsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsIdPut(id, data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsIdReplacePost
        /// </summary>
        [Test]
        public void ProductMaterialsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsIdReplacePost(id, data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsIdTeamGet
        /// </summary>
        [Test]
        public void ProductMaterialsIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductMaterialsIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test ProductMaterialsPatch
        /// </summary>
        [Test]
        public void ProductMaterialsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsPatch(data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsPost
        /// </summary>
        [Test]
        public void ProductMaterialsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsPost(data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsPut
        /// </summary>
        [Test]
        public void ProductMaterialsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsPut(data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ProductMaterialsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductMaterialsUpdatePost
        /// </summary>
        [Test]
        public void ProductMaterialsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test ProductMaterialsUpsertWithWherePost
        /// </summary>
        [Test]
        public void ProductMaterialsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductMaterial data = null;
            //var response = instance.ProductMaterialsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
    }

}
