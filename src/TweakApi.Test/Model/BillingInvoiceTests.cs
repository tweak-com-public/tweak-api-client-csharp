/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.4
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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TweakApi.Api;
using TweakApi.Model;
using TweakApi.Client;
using System.Reflection;

namespace TweakApi.Test
{
    /// <summary>
    ///  Class for testing BillingInvoice
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BillingInvoiceTests
    {
        // TODO uncomment below to declare an instance variable for BillingInvoice
        //private BillingInvoice instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BillingInvoice
            //instance = new BillingInvoice();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingInvoice
        /// </summary>
        [Test]
        public void BillingInvoiceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BillingInvoice
            //Assert.IsInstanceOfType<BillingInvoice> (instance, "variable 'instance' is a BillingInvoice");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'AmountDue'
        /// </summary>
        [Test]
        public void AmountDueTest()
        {
            // TODO unit test for the property 'AmountDue'
        }
        /// <summary>
        /// Test the property 'AttemptCount'
        /// </summary>
        [Test]
        public void AttemptCountTest()
        {
            // TODO unit test for the property 'AttemptCount'
        }
        /// <summary>
        /// Test the property 'Attempted'
        /// </summary>
        [Test]
        public void AttemptedTest()
        {
            // TODO unit test for the property 'Attempted'
        }
        /// <summary>
        /// Test the property 'Charged'
        /// </summary>
        [Test]
        public void ChargedTest()
        {
            // TODO unit test for the property 'Charged'
        }
        /// <summary>
        /// Test the property 'Closed'
        /// </summary>
        [Test]
        public void ClosedTest()
        {
            // TODO unit test for the property 'Closed'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'Customer'
        /// </summary>
        [Test]
        public void CustomerTest()
        {
            // TODO unit test for the property 'Customer'
        }
        /// <summary>
        /// Test the property 'Date'
        /// </summary>
        [Test]
        public void DateTest()
        {
            // TODO unit test for the property 'Date'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'EndingBalance'
        /// </summary>
        [Test]
        public void EndingBalanceTest()
        {
            // TODO unit test for the property 'EndingBalance'
        }
        /// <summary>
        /// Test the property 'Forgiven'
        /// </summary>
        [Test]
        public void ForgivenTest()
        {
            // TODO unit test for the property 'Forgiven'
        }
        /// <summary>
        /// Test the property 'Lines'
        /// </summary>
        [Test]
        public void LinesTest()
        {
            // TODO unit test for the property 'Lines'
        }
        /// <summary>
        /// Test the property 'NextPaymentAttempt'
        /// </summary>
        [Test]
        public void NextPaymentAttemptTest()
        {
            // TODO unit test for the property 'NextPaymentAttempt'
        }
        /// <summary>
        /// Test the property 'Paid'
        /// </summary>
        [Test]
        public void PaidTest()
        {
            // TODO unit test for the property 'Paid'
        }
        /// <summary>
        /// Test the property 'PeriodEnd'
        /// </summary>
        [Test]
        public void PeriodEndTest()
        {
            // TODO unit test for the property 'PeriodEnd'
        }
        /// <summary>
        /// Test the property 'PeriodStart'
        /// </summary>
        [Test]
        public void PeriodStartTest()
        {
            // TODO unit test for the property 'PeriodStart'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'ReciptNumber'
        /// </summary>
        [Test]
        public void ReciptNumberTest()
        {
            // TODO unit test for the property 'ReciptNumber'
        }
        /// <summary>
        /// Test the property 'StartingBalance'
        /// </summary>
        [Test]
        public void StartingBalanceTest()
        {
            // TODO unit test for the property 'StartingBalance'
        }
        /// <summary>
        /// Test the property 'StatementDescriptor'
        /// </summary>
        [Test]
        public void StatementDescriptorTest()
        {
            // TODO unit test for the property 'StatementDescriptor'
        }
        /// <summary>
        /// Test the property 'Subscription'
        /// </summary>
        [Test]
        public void SubscriptionTest()
        {
            // TODO unit test for the property 'Subscription'
        }
        /// <summary>
        /// Test the property 'SubscriptionProrationDate'
        /// </summary>
        [Test]
        public void SubscriptionProrationDateTest()
        {
            // TODO unit test for the property 'SubscriptionProrationDate'
        }
        /// <summary>
        /// Test the property 'Subtotal'
        /// </summary>
        [Test]
        public void SubtotalTest()
        {
            // TODO unit test for the property 'Subtotal'
        }
        /// <summary>
        /// Test the property 'Tax'
        /// </summary>
        [Test]
        public void TaxTest()
        {
            // TODO unit test for the property 'Tax'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }

    }

}
