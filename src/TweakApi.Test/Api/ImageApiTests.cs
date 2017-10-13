/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.0
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
    ///  Class for testing ImageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ImageApiTests
    {
        private ImageApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImageApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ImageApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ImageApi
            //Assert.IsInstanceOfType(typeof(ImageApi), instance, "instance is a ImageApi");
        }

        
        /// <summary>
        /// Test ImagesChangeStreamGet
        /// </summary>
        [Test]
        public void ImagesChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ImagesChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ImagesChangeStreamPost
        /// </summary>
        [Test]
        public void ImagesChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ImagesChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ImagesCountGet
        /// </summary>
        [Test]
        public void ImagesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ImagesCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ImagesFindOneGet
        /// </summary>
        [Test]
        public void ImagesFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ImagesFindOneGet(filter);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesGet
        /// </summary>
        [Test]
        public void ImagesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ImagesGet(filter);
            //Assert.IsInstanceOf<List<Image>> (response, "response is List<Image>");
        }
        
        /// <summary>
        /// Test ImagesIdDelete
        /// </summary>
        [Test]
        public void ImagesIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImagesIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ImagesIdExistsGet
        /// </summary>
        [Test]
        public void ImagesIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImagesIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ImagesIdFolderGet
        /// </summary>
        [Test]
        public void ImagesIdFolderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ImagesIdFolderGet(id, refresh);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImagesIdGet
        /// </summary>
        [Test]
        public void ImagesIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ImagesIdGet(id, filter);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesIdHead
        /// </summary>
        [Test]
        public void ImagesIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImagesIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ImagesIdPatch
        /// </summary>
        [Test]
        public void ImagesIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Image data = null;
            //var response = instance.ImagesIdPatch(id, data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesIdPut
        /// </summary>
        [Test]
        public void ImagesIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Image data = null;
            //var response = instance.ImagesIdPut(id, data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesIdReplacePost
        /// </summary>
        [Test]
        public void ImagesIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Image data = null;
            //var response = instance.ImagesIdReplacePost(id, data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesIdTeamGet
        /// </summary>
        [Test]
        public void ImagesIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ImagesIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test ImagesPatch
        /// </summary>
        [Test]
        public void ImagesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Image data = null;
            //var response = instance.ImagesPatch(data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesPost
        /// </summary>
        [Test]
        public void ImagesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Image data = null;
            //var response = instance.ImagesPost(data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesPut
        /// </summary>
        [Test]
        public void ImagesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Image data = null;
            //var response = instance.ImagesPut(data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ImagesReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Image data = null;
            //var response = instance.ImagesReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImagesUpdatePost
        /// </summary>
        [Test]
        public void ImagesUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Image data = null;
            //var response = instance.ImagesUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ImagesUpsertWithWherePost
        /// </summary>
        [Test]
        public void ImagesUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Image data = null;
            //var response = instance.ImagesUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
    }

}
