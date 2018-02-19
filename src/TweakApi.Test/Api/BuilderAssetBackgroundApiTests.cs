/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.13
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
    ///  Class for testing BuilderAssetBackgroundApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BuilderAssetBackgroundApiTests
    {
        private BuilderAssetBackgroundApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BuilderAssetBackgroundApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BuilderAssetBackgroundApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BuilderAssetBackgroundApi
            //Assert.IsInstanceOfType(typeof(BuilderAssetBackgroundApi), instance, "instance is a BuilderAssetBackgroundApi");
        }

        
        /// <summary>
        /// Test BuilderAssetBackgroundsFoldersFolderPathGet
        /// </summary>
        [Test]
        public void BuilderAssetBackgroundsFoldersFolderPathGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string folderPath = null;
            //string filter = null;
            //var response = instance.BuilderAssetBackgroundsFoldersFolderPathGet(folderPath, filter);
            //Assert.IsInstanceOf<List<CloudinaryImage>> (response, "response is List<CloudinaryImage>");
        }
        
        /// <summary>
        /// Test BuilderAssetBackgroundsFoldersGet
        /// </summary>
        [Test]
        public void BuilderAssetBackgroundsFoldersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.BuilderAssetBackgroundsFoldersGet();
            //Assert.IsInstanceOf<List<BuilderAssetBackgroundFolder>> (response, "response is List<BuilderAssetBackgroundFolder>");
        }
        
        /// <summary>
        /// Test BuilderAssetBackgroundsGet
        /// </summary>
        [Test]
        public void BuilderAssetBackgroundsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.BuilderAssetBackgroundsGet(filter);
            //Assert.IsInstanceOf<List<CloudinaryImage>> (response, "response is List<CloudinaryImage>");
        }
        
    }

}
