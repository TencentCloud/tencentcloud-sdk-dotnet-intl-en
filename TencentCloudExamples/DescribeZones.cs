/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloudExamples
{
    public class DescribeZones
    {
        public static void Run(string[] args)
        {
            try
            {
                // Mandatory steps:
                // Instantiate an authentication object. You need to pass your Tencent Cloud account's secretId and secretKey as parameters.
                // This example reads them from environment variables. You need to set these two values in your environment first.
                // You can also hardcode the key pair directly in your code, but be careful not to copy, upload, or share the code with others
                // to avoid leaking the key pair and jeopardizing your assets.
                Credential cred = new Credential
                {
                    SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                    SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
                };

                // Instantiate a client profile object (optional; can be skipped if there are no special requirements).
                ClientProfile clientProfile = new ClientProfile();
                // Optional step:
                // Instantiate a client configuration object, which allows you to set the timeout period and other configurations.
                HttpProfile httpProfile = new HttpProfile();
                // Proxy server; set this if you are in an environment with a proxy server.
                httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

                clientProfile.HttpProfile = httpProfile;

                // Instantiate the client object for the product you want to request (using CVM as an example).
                // The second parameter is the region information, which can be a string like "ap-guangzhou" or a predefined constant. clientProfile is optional.
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // Instantiate a request object. Based on the API being called and the actual situation, you can further set the request parameters.
                // You can check the SDK source code directly to see what properties can be set for DescribeZonesRequest.
                // Properties can be a basic type or reference another data structure.
                // It is recommended to use an IDE for development, as it allows for convenient jumping to and reviewing the documentation for various APIs and data structures.
                DescribeZonesRequest req = new DescribeZonesRequest();

                // Call the DescribeZones method via the client object to initiate the request. Note that the method name corresponds to the request object.
                // The returned 'resp' is an instance of the DescribeZonesResponse class, which corresponds to the request object.
                DescribeZonesResponse resp = client.DescribeZonesSync(req);

                // Print the JSON format response string.
                Console.WriteLine(AbstractModel.ToJsonString(resp));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.Read();
        }
    }
}