/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.1
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
    ///  Class for testing ProductSizeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductSizeApiTests
    {
        private ProductSizeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductSizeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductSizeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductSizeApi
            //Assert.IsInstanceOfType(typeof(ProductSizeApi), instance, "instance is a ProductSizeApi");
        }

        
        /// <summary>
        /// Test ProductSizesChangeStreamGet
        /// </summary>
        [Test]
        public void ProductSizesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductSizesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductSizesChangeStreamPost
        /// </summary>
        [Test]
        public void ProductSizesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ProductSizesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ProductSizesCountGet
        /// </summary>
        [Test]
        public void ProductSizesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ProductSizesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ProductSizesFindOneGet
        /// </summary>
        [Test]
        public void ProductSizesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductSizesFindOneGet(filter);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesGet
        /// </summary>
        [Test]
        public void ProductSizesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ProductSizesGet(filter);
            //Assert.IsInstanceOf<List<ProductSize>> (response, "response is List<ProductSize>");
        }
        
        /// <summary>
        /// Test ProductSizesIdDelete
        /// </summary>
        [Test]
        public void ProductSizesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductSizesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ProductSizesIdExistsGet
        /// </summary>
        [Test]
        public void ProductSizesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductSizesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductSizesIdGet
        /// </summary>
        [Test]
        public void ProductSizesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductSizesIdGet(id, filter);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesIdHead
        /// </summary>
        [Test]
        public void ProductSizesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ProductSizesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsCountGet
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ProductSizesIdMaterialsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsDelete
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ProductSizesIdMaterialsDelete(id);
            
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsFkDelete
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ProductSizesIdMaterialsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsFkGet
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ProductSizesIdMaterialsFkGet(id, fk);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsFkPut
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ProductMaterial data = null;
            //var response = instance.ProductSizesIdMaterialsFkPut(id, fk, data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsGet
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductSizesIdMaterialsGet(id, filter);
            //Assert.IsInstanceOf<List<ProductMaterial>> (response, "response is List<ProductMaterial>");
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsPost
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductMaterial data = null;
            //var response = instance.ProductSizesIdMaterialsPost(id, data);
            //Assert.IsInstanceOf<ProductMaterial> (response, "response is ProductMaterial");
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsRelFkDelete
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ProductSizesIdMaterialsRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsRelFkHead
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ProductSizesIdMaterialsRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test ProductSizesIdMaterialsRelFkPut
        /// </summary>
        [Test]
        public void ProductSizesIdMaterialsRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ProductSizeMaterial data = null;
            //var response = instance.ProductSizesIdMaterialsRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizesIdPatch
        /// </summary>
        [Test]
        public void ProductSizesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductSize data = null;
            //var response = instance.ProductSizesIdPatch(id, data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesIdProductsCountGet
        /// </summary>
        [Test]
        public void ProductSizesIdProductsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ProductSizesIdProductsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ProductSizesIdProductsDelete
        /// </summary>
        [Test]
        public void ProductSizesIdProductsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ProductSizesIdProductsDelete(id);
            
        }
        
        /// <summary>
        /// Test ProductSizesIdProductsFkDelete
        /// </summary>
        [Test]
        public void ProductSizesIdProductsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ProductSizesIdProductsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ProductSizesIdProductsFkGet
        /// </summary>
        [Test]
        public void ProductSizesIdProductsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ProductSizesIdProductsFkGet(id, fk);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductSizesIdProductsFkPut
        /// </summary>
        [Test]
        public void ProductSizesIdProductsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Product data = null;
            //var response = instance.ProductSizesIdProductsFkPut(id, fk, data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductSizesIdProductsGet
        /// </summary>
        [Test]
        public void ProductSizesIdProductsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductSizesIdProductsGet(id, filter);
            //Assert.IsInstanceOf<List<Product>> (response, "response is List<Product>");
        }
        
        /// <summary>
        /// Test ProductSizesIdProductsPost
        /// </summary>
        [Test]
        public void ProductSizesIdProductsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Product data = null;
            //var response = instance.ProductSizesIdProductsPost(id, data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test ProductSizesIdPut
        /// </summary>
        [Test]
        public void ProductSizesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductSize data = null;
            //var response = instance.ProductSizesIdPut(id, data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesIdReplacePost
        /// </summary>
        [Test]
        public void ProductSizesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductSize data = null;
            //var response = instance.ProductSizesIdReplacePost(id, data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesIdSizeMaterialsCountGet
        /// </summary>
        [Test]
        public void ProductSizesIdSizeMaterialsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ProductSizesIdSizeMaterialsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ProductSizesIdSizeMaterialsDelete
        /// </summary>
        [Test]
        public void ProductSizesIdSizeMaterialsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ProductSizesIdSizeMaterialsDelete(id);
            
        }
        
        /// <summary>
        /// Test ProductSizesIdSizeMaterialsFkDelete
        /// </summary>
        [Test]
        public void ProductSizesIdSizeMaterialsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ProductSizesIdSizeMaterialsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ProductSizesIdSizeMaterialsFkGet
        /// </summary>
        [Test]
        public void ProductSizesIdSizeMaterialsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ProductSizesIdSizeMaterialsFkGet(id, fk);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizesIdSizeMaterialsFkPut
        /// </summary>
        [Test]
        public void ProductSizesIdSizeMaterialsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ProductSizeMaterial data = null;
            //var response = instance.ProductSizesIdSizeMaterialsFkPut(id, fk, data);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizesIdSizeMaterialsGet
        /// </summary>
        [Test]
        public void ProductSizesIdSizeMaterialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ProductSizesIdSizeMaterialsGet(id, filter);
            //Assert.IsInstanceOf<List<ProductSizeMaterial>> (response, "response is List<ProductSizeMaterial>");
        }
        
        /// <summary>
        /// Test ProductSizesIdSizeMaterialsPost
        /// </summary>
        [Test]
        public void ProductSizesIdSizeMaterialsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProductSizeMaterial data = null;
            //var response = instance.ProductSizesIdSizeMaterialsPost(id, data);
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test ProductSizesIdTypeGet
        /// </summary>
        [Test]
        public void ProductSizesIdTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ProductSizesIdTypeGet(id, refresh);
            //Assert.IsInstanceOf<ProductType> (response, "response is ProductType");
        }
        
        /// <summary>
        /// Test ProductSizesPatch
        /// </summary>
        [Test]
        public void ProductSizesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductSize data = null;
            //var response = instance.ProductSizesPatch(data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesPost
        /// </summary>
        [Test]
        public void ProductSizesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductSize data = null;
            //var response = instance.ProductSizesPost(data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesPut
        /// </summary>
        [Test]
        public void ProductSizesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductSize data = null;
            //var response = instance.ProductSizesPut(data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ProductSizesReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductSize data = null;
            //var response = instance.ProductSizesReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
        /// <summary>
        /// Test ProductSizesUpdatePost
        /// </summary>
        [Test]
        public void ProductSizesUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductSize data = null;
            //var response = instance.ProductSizesUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ProductSizesUpsertWithWherePost
        /// </summary>
        [Test]
        public void ProductSizesUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ProductSize data = null;
            //var response = instance.ProductSizesUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<ProductSize> (response, "response is ProductSize");
        }
        
    }

}
