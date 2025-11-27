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
                // Essential step:
                // Instantiate an authentication object, which requires the Tencent Cloud account key pair
                // secretId and secretKey as input parameters.
                // Here, we read them from environment variables, so these two values need to be set
                // in the environment variables first.
                // You can also hardcode the key pair directly in the code, but be careful not to copy,
                // upload, or share the code with others,
                // to avoid exposing the key pair and jeopardizing your property security.
                Credential cred = new Credential
                {
                    SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                    SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
                };

                // Instantiate a client option, which is optional. You can skip it if there are no special requirements.
                ClientProfile clientProfile = new ClientProfile();
                // Non-essential step
                // Instantiate a client configuration object, which allows specifying configurations like timeout.
                HttpProfile httpProfile = new HttpProfile();
                // Proxy server, set this if you have a proxy server in your environment
                httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

                clientProfile.HttpProfile = httpProfile;

                // Instantiate the client object for the product to be requested (taking cvm as an example)
                // The second parameter is region information, which can be a string like ap-guangzhou or a predefined constant. clientProfile is optional.
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // Instantiate a request object. Request parameters can be further set according to the called interface and actual situation.
                // You can directly check the SDK source code to determine which properties of DescribeZonesRequest can be set.
                // Properties may be basic types or refer to another data structure.
                // It is recommended to use an IDE for development, as it allows for easy jumping to and viewing of the documentation for various interfaces and data structures.
                DescribeZonesRequest req = new DescribeZonesRequest();

                // Call the DescribeZonesSync method via the client object to initiate the request. Note that the request method name corresponds to the request object.
                // The returned resp is an instance of the DescribeZonesResponse class, corresponding to the request object.
                DescribeZonesResponse resp = client.DescribeZonesSync(req);

                // Output the JSON format response string
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
