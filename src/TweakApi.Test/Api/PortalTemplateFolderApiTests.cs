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
    ///  Class for testing PortalTemplateFolderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PortalTemplateFolderApiTests
    {
        private PortalTemplateFolderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PortalTemplateFolderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PortalTemplateFolderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PortalTemplateFolderApi
            //Assert.IsInstanceOfType(typeof(PortalTemplateFolderApi), instance, "instance is a PortalTemplateFolderApi");
        }

        
        /// <summary>
        /// Test PortalTemplateFoldersChangeStreamGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalTemplateFoldersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersChangeStreamPost
        /// </summary>
        [Test]
        public void PortalTemplateFoldersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalTemplateFoldersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersCountGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.PortalTemplateFoldersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersFindOneGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalTemplateFoldersFindOneGet(filter);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalTemplateFoldersGet(filter);
            //Assert.IsInstanceOf<List<PortalTemplateFolder>> (response, "response is List<PortalTemplateFolder>");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdChildrenCountGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdChildrenCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.PortalTemplateFoldersIdChildrenCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdChildrenFkDelete
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdChildrenFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.PortalTemplateFoldersIdChildrenFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdChildrenFkGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdChildrenFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.PortalTemplateFoldersIdChildrenFkGet(id, fk);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdChildrenFkPut
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdChildrenFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //PortalTemplateFolder data = null;
            //var response = instance.PortalTemplateFoldersIdChildrenFkPut(id, fk, data);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdChildrenGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdChildrenGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.PortalTemplateFoldersIdChildrenGet(id, filter);
            //Assert.IsInstanceOf<List<PortalTemplateFolder>> (response, "response is List<PortalTemplateFolder>");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdChildrenPost
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdChildrenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalTemplateFolder data = null;
            //var response = instance.PortalTemplateFoldersIdChildrenPost(id, data);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdDelete
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalTemplateFoldersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdExistsGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalTemplateFoldersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.PortalTemplateFoldersIdGet(id, filter);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdHead
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalTemplateFoldersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdParentGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdParentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalTemplateFoldersIdParentGet(id, refresh);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdPatch
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalTemplateFolder data = null;
            //var response = instance.PortalTemplateFoldersIdPatch(id, data);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdPortalGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalTemplateFoldersIdPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdPut
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalTemplateFolder data = null;
            //var response = instance.PortalTemplateFoldersIdPut(id, data);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdReplacePost
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalTemplateFolder data = null;
            //var response = instance.PortalTemplateFoldersIdReplacePost(id, data);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesCountGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.PortalTemplateFoldersIdTemplatesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesFkDelete
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.PortalTemplateFoldersIdTemplatesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesFkGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.PortalTemplateFoldersIdTemplatesFkGet(id, fk);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesFkPut
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Template data = null;
            //var response = instance.PortalTemplateFoldersIdTemplatesFkPut(id, fk, data);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesGet
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.PortalTemplateFoldersIdTemplatesGet(id, filter);
            //Assert.IsInstanceOf<List<Template>> (response, "response is List<Template>");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesPost
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Template data = null;
            //var response = instance.PortalTemplateFoldersIdTemplatesPost(id, data);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesRelFkDelete
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.PortalTemplateFoldersIdTemplatesRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesRelFkHead
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.PortalTemplateFoldersIdTemplatesRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersIdTemplatesRelFkPut
        /// </summary>
        [Test]
        public void PortalTemplateFoldersIdTemplatesRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //PortalTemplate data = null;
            //var response = instance.PortalTemplateFoldersIdTemplatesRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<PortalTemplate> (response, "response is PortalTemplate");
        }
        
        /// <summary>
        /// Test PortalTemplateFoldersPost
        /// </summary>
        [Test]
        public void PortalTemplateFoldersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalTemplateFolder data = null;
            //var response = instance.PortalTemplateFoldersPost(data);
            //Assert.IsInstanceOf<PortalTemplateFolder> (response, "response is PortalTemplateFolder");
        }
        
    }

}
