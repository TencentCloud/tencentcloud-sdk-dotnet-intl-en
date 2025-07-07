/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloud.Tests
{
    [TestClass]
    public sealed class DescribeInstances
    {
        [TestMethod]
        public void TestDescribeInstances()
        {
            // Necessary steps:
            // Instantiate an authentication object.
            // The input parameters need to be the Tencent Cloud account key pair secretId and secretKey.
            // The method used here is to read from environment variables,
            // and these two values need to be set in the environment variables first.
            // You can also write the key pair directly in the code, but be careful not to copy, upload or share the code with others.
            // To avoid disclosing the key pair and endangering the security of your property.
            Credential cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            // Instantiate a ClientProfile, optional, can be skipped if there are no special requirements
            ClientProfile clientProfile = new ClientProfile();
            // Specify the signature algorithm (default is HmacSHA256)
            clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
            // Optional
            // Instantiate a client configuration object, which can specify configurations such as timeout and so on.
            HttpProfile httpProfile = new HttpProfile();
            // The SDK uses the POST method by default.
            // If you must use the GET method, you can set it here. The GET method cannot handle some larger requests.
            httpProfile.ReqMethod = "GET";
            // The SDK has a default timeout, please do not adjust it unless necessary.
            // Check in the code for the latest default values if necessary.
            httpProfile.Timeout = 10; // Request connection timeout in seconds (default 60 seconds)
            // The SDK will automatically specify the domain name.
            // Usually there is no need to specify a domain name,
            // but if you are accessing services in the financial district,
            // You must manually specify the domain name, for example,
            // the Shanghai financial region name of the cloud server: cvm.ap-shanghai-fsi.tencentcloudapi.com
            httpProfile.Endpoint = "cvm.tencentcloudapi.com";
            // Proxy server, set when there is a proxy server in your environment
            httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

            clientProfile.HttpProfile = httpProfile;

            // Instantiate the client object to request the product (take cvm as an example)
            // The second parameter is regional information. You can directly fill in the string ap-guangzhou,
            // or refer to the preset constants. clientProfile is optional.
            CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

            // Instantiate a request object, and further set the request parameters according to the calling interface and the actual situation.
            // You can directly query the SDK source code to determine which attributes of DescribeInstancesRequest can be set.
            // The property may be a primitive type, or it may refer to another data structure.
            // It is recommended to use IDE for development. You can easily jump to the documentation of each interface and data structure.
            DescribeInstancesRequest req = new DescribeInstancesRequest();

            // Basic type settings.
            // This interface allows setting the number of instances returned. Specify here to return only one.
            // The SDK uses pointer style to specify parameters. Even for basic types, you need to use pointers to assign parameters.
            // SDK provides pointer reference encapsulation functions for basic types
            req.Limit = 1;
            // Array type settings.
            // This interface allows filtering by specifying an instance ID, but since it conflicts with the Filter parameter to be demonstrated next, comment it out first.
            // req.InstanceIds = new string[] { "ins-r8hr2upy" };

            // Settings for complex objects.
            // In this interface, Filters is an array, the elements of the array are complex objects Filter, and the member Values of Filter is a string array.
            // Fill in the request parameters. The member variables of the request object here are the input parameters of the corresponding interface.
            // You can check the definition of request parameters through the official website interface document or jump to the definition of the request object.
            // Create a Filter object and query the cvm instance using the zone dimension.
            Filter zoneFilter = new Filter();
            zoneFilter.Name = "zone";
            zoneFilter.Values = new string[] { "ap-guangzhou-1", "ap-guangzhou-2" };
            Filter nameFilter = new Filter();
            nameFilter.Name = "instance-name";
            nameFilter.Values = new string[] { "NameTest" };
            req.Filters = new Filter[] { zoneFilter, nameFilter }; // Filters is a list whose members are Filter objects

            // It also supports assigning request parameters in strings in standard json format.
            // The following code is equivalent to the parameter assignment above
            //string strParams = "{\"Filters\":[{\"Name\":\"zone\",\"Values\":[\"ap-guangzhou-1\",\"ap-guangzhou-2\"]}]}";
            //req = DescribeInstancesRequest.FromJsonString<DescribeInstancesRequest>(strParams);

            // Call the DescribeInstances method through the client object to initiate a request.
            // Note that the request method name corresponds to the request object
            //The returned resp is an instance of the DescribeInstancesResponse class, corresponding to the request object
            DescribeInstancesResponse resp = client.DescribeInstances(req).ConfigureAwait(false).GetAwaiter()
                .GetResult();

            // Output the string return packet in json format
            Console.WriteLine(AbstractModel.ToJsonString(resp));

            // You can also take out a single value.
            // You can check the definition of the return field through the official website interface document or jump to the definition of the response object.
            Console.WriteLine(resp.TotalCount);
        }

        [TestMethod]
        public void TestDescribeInstancesSync()
        {
            Credential cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            ClientProfile clientProfile = new ClientProfile();
            clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
            HttpProfile httpProfile = new HttpProfile();
            httpProfile.ReqMethod = "GET";
            httpProfile.Timeout = 10;
            httpProfile.Endpoint = "cvm.tencentcloudapi.com";
            httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

            clientProfile.HttpProfile = httpProfile;

            CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);
            DescribeInstancesRequest req = new DescribeInstancesRequest();
            req.Limit = 1;
            Filter zoneFilter = new Filter();
            zoneFilter.Name = "zone";
            zoneFilter.Values = new string[] { "ap-guangzhou-1", "ap-guangzhou-2" };
            Filter nameFilter = new Filter();
            nameFilter.Name = "instance-name";
            nameFilter.Values = new string[] { "中文测试" };
            req.Filters = new Filter[] { zoneFilter, nameFilter };

            DescribeInstancesResponse resp = client.DescribeInstancesSync(req);
            Console.WriteLine(AbstractModel.ToJsonString(resp));
            Console.WriteLine(resp.TotalCount);
        }
    }
}