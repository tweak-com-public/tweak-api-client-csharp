/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.4-alpha.4
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
    ///  Class for testing PublicVBuilderAssetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicVBuilderAssetApiTests
    {
        private PublicVBuilderAssetApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicVBuilderAssetApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicVBuilderAssetApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicVBuilderAssetApi
            //Assert.IsInstanceOfType(typeof(PublicVBuilderAssetApi), instance, "instance is a PublicVBuilderAssetApi");
        }

        
        /// <summary>
        /// Test V1BuilderAssetBackgroundsFoldersFolderPathGet
        /// </summary>
        [Test]
        public void V1BuilderAssetBackgroundsFoldersFolderPathGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string folderPath = null;
            //string filter = null;
            //var response = instance.V1BuilderAssetBackgroundsFoldersFolderPathGet(folderPath, filter);
            //Assert.IsInstanceOf<List<CloudinaryImage>> (response, "response is List<CloudinaryImage>");
        }
        
        /// <summary>
        /// Test V1BuilderAssetBackgroundsFoldersGet
        /// </summary>
        [Test]
        public void V1BuilderAssetBackgroundsFoldersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1BuilderAssetBackgroundsFoldersGet();
            //Assert.IsInstanceOf<List<BuilderAssetBackgroundFolder>> (response, "response is List<BuilderAssetBackgroundFolder>");
        }
        
        /// <summary>
        /// Test V1BuilderAssetBackgroundsGet
        /// </summary>
        [Test]
        public void V1BuilderAssetBackgroundsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.V1BuilderAssetBackgroundsGet(filter);
            //Assert.IsInstanceOf<List<CloudinaryImage>> (response, "response is List<CloudinaryImage>");
        }
        
    }

}