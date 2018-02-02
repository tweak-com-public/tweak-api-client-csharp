/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.7-alpha.2
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
    ///  Class for testing ImageFolderMemberApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ImageFolderMemberApiTests
    {
        private ImageFolderMemberApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImageFolderMemberApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ImageFolderMemberApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ImageFolderMemberApi
            //Assert.IsInstanceOfType(typeof(ImageFolderMemberApi), instance, "instance is a ImageFolderMemberApi");
        }

        
        /// <summary>
        /// Test ImageFolderMembersChangeStreamGet
        /// </summary>
        [Test]
        public void ImageFolderMembersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ImageFolderMembersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ImageFolderMembersChangeStreamPost
        /// </summary>
        [Test]
        public void ImageFolderMembersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ImageFolderMembersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ImageFolderMembersCountGet
        /// </summary>
        [Test]
        public void ImageFolderMembersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ImageFolderMembersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ImageFolderMembersFindOneGet
        /// </summary>
        [Test]
        public void ImageFolderMembersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ImageFolderMembersFindOneGet(filter);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersGet
        /// </summary>
        [Test]
        public void ImageFolderMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ImageFolderMembersGet(filter);
            //Assert.IsInstanceOf<List<ImageFolderMember>> (response, "response is List<ImageFolderMember>");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdDelete
        /// </summary>
        [Test]
        public void ImageFolderMembersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImageFolderMembersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdExistsGet
        /// </summary>
        [Test]
        public void ImageFolderMembersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImageFolderMembersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdFolderGet
        /// </summary>
        [Test]
        public void ImageFolderMembersIdFolderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ImageFolderMembersIdFolderGet(id, refresh);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdGet
        /// </summary>
        [Test]
        public void ImageFolderMembersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ImageFolderMembersIdGet(id, filter);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdHead
        /// </summary>
        [Test]
        public void ImageFolderMembersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImageFolderMembersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdMemberGet
        /// </summary>
        [Test]
        public void ImageFolderMembersIdMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ImageFolderMembersIdMemberGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdPatch
        /// </summary>
        [Test]
        public void ImageFolderMembersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersIdPatch(id, data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdPut
        /// </summary>
        [Test]
        public void ImageFolderMembersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersIdPut(id, data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersIdReplacePost
        /// </summary>
        [Test]
        public void ImageFolderMembersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersIdReplacePost(id, data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersPatch
        /// </summary>
        [Test]
        public void ImageFolderMembersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersPatch(data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersPost
        /// </summary>
        [Test]
        public void ImageFolderMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersPost(data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersPut
        /// </summary>
        [Test]
        public void ImageFolderMembersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersPut(data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ImageFolderMembersReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFolderMembersUpdatePost
        /// </summary>
        [Test]
        public void ImageFolderMembersUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test ImageFolderMembersUpsertWithWherePost
        /// </summary>
        [Test]
        public void ImageFolderMembersUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ImageFolderMember data = null;
            //var response = instance.ImageFolderMembersUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
    }

}
