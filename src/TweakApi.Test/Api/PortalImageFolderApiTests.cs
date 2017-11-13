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
    ///  Class for testing PortalImageFolderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PortalImageFolderApiTests
    {
        private PortalImageFolderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PortalImageFolderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PortalImageFolderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PortalImageFolderApi
            //Assert.IsInstanceOfType(typeof(PortalImageFolderApi), instance, "instance is a PortalImageFolderApi");
        }

        
        /// <summary>
        /// Test PortalImageFoldersChangeStreamGet
        /// </summary>
        [Test]
        public void PortalImageFoldersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalImageFoldersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalImageFoldersChangeStreamPost
        /// </summary>
        [Test]
        public void PortalImageFoldersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.PortalImageFoldersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test PortalImageFoldersCountGet
        /// </summary>
        [Test]
        public void PortalImageFoldersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.PortalImageFoldersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test PortalImageFoldersFindOneGet
        /// </summary>
        [Test]
        public void PortalImageFoldersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalImageFoldersFindOneGet(filter);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersGet
        /// </summary>
        [Test]
        public void PortalImageFoldersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.PortalImageFoldersGet(filter);
            //Assert.IsInstanceOf<List<PortalImageFolder>> (response, "response is List<PortalImageFolder>");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdDelete
        /// </summary>
        [Test]
        public void PortalImageFoldersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalImageFoldersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdExistsGet
        /// </summary>
        [Test]
        public void PortalImageFoldersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalImageFoldersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdFolderGet
        /// </summary>
        [Test]
        public void PortalImageFoldersIdFolderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalImageFoldersIdFolderGet(id, refresh);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdGet
        /// </summary>
        [Test]
        public void PortalImageFoldersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.PortalImageFoldersIdGet(id, filter);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdHead
        /// </summary>
        [Test]
        public void PortalImageFoldersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.PortalImageFoldersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdPatch
        /// </summary>
        [Test]
        public void PortalImageFoldersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersIdPatch(id, data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdPortalGet
        /// </summary>
        [Test]
        public void PortalImageFoldersIdPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.PortalImageFoldersIdPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdPut
        /// </summary>
        [Test]
        public void PortalImageFoldersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersIdPut(id, data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersIdReplacePost
        /// </summary>
        [Test]
        public void PortalImageFoldersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersIdReplacePost(id, data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersPatch
        /// </summary>
        [Test]
        public void PortalImageFoldersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersPatch(data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersPost
        /// </summary>
        [Test]
        public void PortalImageFoldersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersPost(data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersPut
        /// </summary>
        [Test]
        public void PortalImageFoldersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersPut(data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersReplaceOrCreatePost
        /// </summary>
        [Test]
        public void PortalImageFoldersReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test PortalImageFoldersUpdatePost
        /// </summary>
        [Test]
        public void PortalImageFoldersUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test PortalImageFoldersUpsertWithWherePost
        /// </summary>
        [Test]
        public void PortalImageFoldersUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //PortalImageFolder data = null;
            //var response = instance.PortalImageFoldersUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
    }

}
