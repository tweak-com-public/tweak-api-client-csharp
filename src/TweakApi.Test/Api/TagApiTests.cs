/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-beta.5
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
    ///  Class for testing TagApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TagApiTests
    {
        private TagApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TagApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TagApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TagApi
            //Assert.IsInstanceOfType(typeof(TagApi), instance, "instance is a TagApi");
        }

        
        /// <summary>
        /// Test TagsChangeStreamGet
        /// </summary>
        [Test]
        public void TagsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TagsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TagsChangeStreamPost
        /// </summary>
        [Test]
        public void TagsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TagsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TagsCountGet
        /// </summary>
        [Test]
        public void TagsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TagsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TagsFindOneGet
        /// </summary>
        [Test]
        public void TagsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TagsFindOneGet(filter);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsGet
        /// </summary>
        [Test]
        public void TagsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TagsGet(filter);
            //Assert.IsInstanceOf<List<Tag>> (response, "response is List<Tag>");
        }
        
        /// <summary>
        /// Test TagsIdDelete
        /// </summary>
        [Test]
        public void TagsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TagsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TagsIdDesignsCountGet
        /// </summary>
        [Test]
        public void TagsIdDesignsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.TagsIdDesignsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TagsIdDesignsDelete
        /// </summary>
        [Test]
        public void TagsIdDesignsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.TagsIdDesignsDelete(id);
            
        }
        
        /// <summary>
        /// Test TagsIdDesignsFkDelete
        /// </summary>
        [Test]
        public void TagsIdDesignsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.TagsIdDesignsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test TagsIdDesignsFkGet
        /// </summary>
        [Test]
        public void TagsIdDesignsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.TagsIdDesignsFkGet(id, fk);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test TagsIdDesignsFkPut
        /// </summary>
        [Test]
        public void TagsIdDesignsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Design data = null;
            //var response = instance.TagsIdDesignsFkPut(id, fk, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test TagsIdDesignsGet
        /// </summary>
        [Test]
        public void TagsIdDesignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TagsIdDesignsGet(id, filter);
            //Assert.IsInstanceOf<List<Design>> (response, "response is List<Design>");
        }
        
        /// <summary>
        /// Test TagsIdDesignsPost
        /// </summary>
        [Test]
        public void TagsIdDesignsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Design data = null;
            //var response = instance.TagsIdDesignsPost(id, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test TagsIdDesignsRelFkDelete
        /// </summary>
        [Test]
        public void TagsIdDesignsRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.TagsIdDesignsRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test TagsIdDesignsRelFkHead
        /// </summary>
        [Test]
        public void TagsIdDesignsRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.TagsIdDesignsRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test TagsIdDesignsRelFkPut
        /// </summary>
        [Test]
        public void TagsIdDesignsRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DesignTag data = null;
            //var response = instance.TagsIdDesignsRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test TagsIdExistsGet
        /// </summary>
        [Test]
        public void TagsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TagsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TagsIdGet
        /// </summary>
        [Test]
        public void TagsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TagsIdGet(id, filter);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsIdHead
        /// </summary>
        [Test]
        public void TagsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TagsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TagsIdPatch
        /// </summary>
        [Test]
        public void TagsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Tag data = null;
            //var response = instance.TagsIdPatch(id, data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsIdProductsCountGet
        /// </summary>
        [Test]
        public void TagsIdProductsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.TagsIdProductsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TagsIdProductsDelete
        /// </summary>
        [Test]
        public void TagsIdProductsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.TagsIdProductsDelete(id);
            
        }
        
        /// <summary>
        /// Test TagsIdProductsFkDelete
        /// </summary>
        [Test]
        public void TagsIdProductsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.TagsIdProductsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test TagsIdProductsFkGet
        /// </summary>
        [Test]
        public void TagsIdProductsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.TagsIdProductsFkGet(id, fk);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test TagsIdProductsFkPut
        /// </summary>
        [Test]
        public void TagsIdProductsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Product data = null;
            //var response = instance.TagsIdProductsFkPut(id, fk, data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test TagsIdProductsGet
        /// </summary>
        [Test]
        public void TagsIdProductsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TagsIdProductsGet(id, filter);
            //Assert.IsInstanceOf<List<Product>> (response, "response is List<Product>");
        }
        
        /// <summary>
        /// Test TagsIdProductsPost
        /// </summary>
        [Test]
        public void TagsIdProductsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Product data = null;
            //var response = instance.TagsIdProductsPost(id, data);
            //Assert.IsInstanceOf<Product> (response, "response is Product");
        }
        
        /// <summary>
        /// Test TagsIdProductsRelFkDelete
        /// </summary>
        [Test]
        public void TagsIdProductsRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.TagsIdProductsRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test TagsIdProductsRelFkHead
        /// </summary>
        [Test]
        public void TagsIdProductsRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.TagsIdProductsRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test TagsIdProductsRelFkPut
        /// </summary>
        [Test]
        public void TagsIdProductsRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ProductTag data = null;
            //var response = instance.TagsIdProductsRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<ProductTag> (response, "response is ProductTag");
        }
        
        /// <summary>
        /// Test TagsIdPut
        /// </summary>
        [Test]
        public void TagsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Tag data = null;
            //var response = instance.TagsIdPut(id, data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsIdReplacePost
        /// </summary>
        [Test]
        public void TagsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Tag data = null;
            //var response = instance.TagsIdReplacePost(id, data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsIdTemplatesCountGet
        /// </summary>
        [Test]
        public void TagsIdTemplatesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.TagsIdTemplatesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TagsIdTemplatesDelete
        /// </summary>
        [Test]
        public void TagsIdTemplatesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.TagsIdTemplatesDelete(id);
            
        }
        
        /// <summary>
        /// Test TagsIdTemplatesFkDelete
        /// </summary>
        [Test]
        public void TagsIdTemplatesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.TagsIdTemplatesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test TagsIdTemplatesFkGet
        /// </summary>
        [Test]
        public void TagsIdTemplatesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.TagsIdTemplatesFkGet(id, fk);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TagsIdTemplatesFkPut
        /// </summary>
        [Test]
        public void TagsIdTemplatesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Template data = null;
            //var response = instance.TagsIdTemplatesFkPut(id, fk, data);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TagsIdTemplatesGet
        /// </summary>
        [Test]
        public void TagsIdTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TagsIdTemplatesGet(id, filter);
            //Assert.IsInstanceOf<List<Template>> (response, "response is List<Template>");
        }
        
        /// <summary>
        /// Test TagsIdTemplatesPost
        /// </summary>
        [Test]
        public void TagsIdTemplatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Template data = null;
            //var response = instance.TagsIdTemplatesPost(id, data);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TagsIdTemplatesRelFkDelete
        /// </summary>
        [Test]
        public void TagsIdTemplatesRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.TagsIdTemplatesRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test TagsIdTemplatesRelFkHead
        /// </summary>
        [Test]
        public void TagsIdTemplatesRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.TagsIdTemplatesRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test TagsIdTemplatesRelFkPut
        /// </summary>
        [Test]
        public void TagsIdTemplatesRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //TemplateTag data = null;
            //var response = instance.TagsIdTemplatesRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<TemplateTag> (response, "response is TemplateTag");
        }
        
        /// <summary>
        /// Test TagsPatch
        /// </summary>
        [Test]
        public void TagsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Tag data = null;
            //var response = instance.TagsPatch(data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsPost
        /// </summary>
        [Test]
        public void TagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Tag data = null;
            //var response = instance.TagsPost(data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsPut
        /// </summary>
        [Test]
        public void TagsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Tag data = null;
            //var response = instance.TagsPut(data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void TagsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Tag data = null;
            //var response = instance.TagsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test TagsUpdatePost
        /// </summary>
        [Test]
        public void TagsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Tag data = null;
            //var response = instance.TagsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TagsUpsertWithWherePost
        /// </summary>
        [Test]
        public void TagsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Tag data = null;
            //var response = instance.TagsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
    }

}
