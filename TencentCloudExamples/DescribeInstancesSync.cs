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
    public class DescribeInstancesSync
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
                // Specify the signing algorithm (default is HmacSHA256).
                clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
                // Optional step:
                // Instantiate a client configuration object, which allows you to set the timeout period and other configurations.
                HttpProfile httpProfile = new HttpProfile();
                // The SDK defaults to using the POST method.
                // If you must use the GET method, you can set it here. The GET method cannot handle some larger requests.
                httpProfile.ReqMethod = "GET";
                // The SDK has a default timeout period. Do not adjust it unless necessary.
                // If you need to, please check the code for the latest default value.
                httpProfile.Timeout = 10; // Request connection timeout, in seconds (default is 60 seconds).
                // The SDK automatically specifies the domain name. It is usually not necessary to specify a domain name, but if you are accessing a service in a financial zone,
                // you must manually specify the domain name, for example, for a CVM in the Shanghai financial zone: cvm.ap-shanghai-fsi.tencentcloudapi.com
                httpProfile.Endpoint = "cvm.tencentcloudapi.com";
                // Proxy server; set this if you are in an environment with a proxy server.
                httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

                clientProfile.HttpProfile = httpProfile;

                // Instantiate the client object for the product you want to request (using CVM as an example).
                // The second parameter is the region information, which can be a string like "ap-guangzhou" or a predefined constant. clientProfile is optional.
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // Instantiate a request object. Based on the API being called and the actual situation, you can further set the request parameters.
                // You can check the SDK source code directly to see what properties can be set for DescribeInstancesRequest.
                // Properties can be a basic type or reference another data structure.
                // It is recommended to use an IDE for development, as it allows for convenient jumping to and reviewing the documentation for various APIs and data structures.
                DescribeInstancesRequest req = new DescribeInstancesRequest();

                // Setting basic types.
                // This API allows you to set the number of instances to return. Here, we specify to return only one.
                // The SDK uses a pointer-style for specifying parameters. Even for basic types, you need to use a pointer to assign the parameter.
                // The SDK provides a wrapper function for pointer references of basic types.
                req.Limit = 1;
                // Setting array types.
                // This API allows you to specify instance IDs for filtering, but since it conflicts with the Filter parameter demonstration below, it is commented out for now.
                // req.InstanceIds = new string[] { "ins-r8hr2upy" };

                // Setting complex objects.
                // In this API, Filters is an array, whose elements are the complex object Filter, and the member Values of Filter is a string array.
                // Fill in the request parameters. The member variables of the request object correspond to the input parameters of the API.
                // You can check the API documentation on the official website or jump to the definition of the request object to view the definitions of the request parameters.
                Filter zoneFilter = new Filter(); // Create a Filter object to query CVM instances by zone dimension.
                zoneFilter.Name = "zone";
                zoneFilter.Values = new string[] { "ap-guangzhou-1", "ap-guangzhou-2" };
                Filter nameFilter = new Filter();
                nameFilter.Name = "instance-name";
                nameFilter.Values = new string[] { "中文测试" };
                req.Filters = new Filter[]
                    { zoneFilter, nameFilter }; // Filters is a list whose members are Filter objects.

                //// The request parameters also support being assigned using a standard JSON format string. The code below is equivalent to the parameter assignment above.
                //string strParams = "{\"Filters\":[{\"Name\":\"zone\",\"Values\":[\"ap-guangzhou-1\",\"ap-guangzhou-2\"]}]}";
                //req = DescribeInstancesRequest.FromJsonString<DescribeInstancesRequest>(strParams);

                // Call the DescribeInstances method via the client object to initiate the request. Note that the method name corresponds to the request object.
                // The returned 'resp' is an instance of the DescribeInstancesResponse class, which corresponds to the request object.
                DescribeInstancesResponse resp = client.DescribeInstancesSync(req);

                // Print the JSON format response string.
                Console.WriteLine(AbstractModel.ToJsonString(resp));

                // You can also retrieve individual values.
                // You can check the API documentation on the official website or jump to the definition of the response object to view the definitions of the returned fields.
                Console.WriteLine(resp.TotalCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.Read();
        }
    }
}