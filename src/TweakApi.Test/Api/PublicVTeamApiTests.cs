/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.6-alpha.2
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
    ///  Class for testing PublicVTeamApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicVTeamApiTests
    {
        private PublicVTeamApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicVTeamApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicVTeamApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicVTeamApi
            //Assert.IsInstanceOfType(typeof(PublicVTeamApi), instance, "instance is a PublicVTeamApi");
        }

        
        /// <summary>
        /// Test V1TeamBuilderConfigsDefaultGet
        /// </summary>
        [Test]
        public void V1TeamBuilderConfigsDefaultGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1TeamBuilderConfigsDefaultGet();
            //Assert.IsInstanceOf<TeamBuilderConfig> (response, "response is TeamBuilderConfig");
        }
        
        /// <summary>
        /// Test V1TeamBuilderConfigsDefaultProductSizeMaterialsGet
        /// </summary>
        [Test]
        public void V1TeamBuilderConfigsDefaultProductSizeMaterialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1TeamBuilderConfigsDefaultProductSizeMaterialsGet();
            //Assert.IsInstanceOf<ProductSizeMaterial> (response, "response is ProductSizeMaterial");
        }
        
        /// <summary>
        /// Test V1TeamBuilderConfigsIdGet
        /// </summary>
        [Test]
        public void V1TeamBuilderConfigsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.V1TeamBuilderConfigsIdGet(id);
            //Assert.IsInstanceOf<TeamBuilderConfig> (response, "response is TeamBuilderConfig");
        }
        
        /// <summary>
        /// Test V1TeamBuilderConfigsIdProductSizeMaterialsGet
        /// </summary>
        [Test]
        public void V1TeamBuilderConfigsIdProductSizeMaterialsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.V1TeamBuilderConfigsIdProductSizeMaterialsGet(id);
            //Assert.IsInstanceOf<TeamBuilderConfigProductSizeMaterial> (response, "response is TeamBuilderConfigProductSizeMaterial");
        }
        
    }

}
