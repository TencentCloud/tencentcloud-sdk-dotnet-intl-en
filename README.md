# Overview

Welcome to Tencent Cloud Software Development Kit (SDK) 3.0, a companion tool for the TencentCloud API 3.0 platform. All Tencent Cloud services and products will be connected to it in the future. The new SDK version is unified and features the same SDK usage, API call methods, error codes, and returned packet formats for different languages.

Tencent Cloud SDK for .NET helps .NET developers debug and use TencentCloud APIs with ease. This document describes Tencent Cloud SDK for .NET and how to quickly use it with code examples provided. 

# Dependent Environment

1. Dependent environment: .NET Framework 4.5+ and .NET Core 2.1.
2. Activate your product in the Tencent Cloud Console.
3. Get the `SecretID`, `SecretKey`, and endpoint. The general format of endpoint is `\*.tencentcloudapi.com`. For example, the endpoint of CVM is `cvm.tencentcloudapi.com`. For more information, please see the documentation of the specified product.
4. Download the relevant materials and configure the relevant files.

# Installation

Before installing Tencent Cloud SDK for .NET and using TencentCloud API, apply for security credentials in the Tencent Cloud Console. Security credential consists of `SecretID` and `SecretKey`. `SecretID` is for identifying the API requester. `SecretKey` is a key used for signature string encryption and authentication by the server. Please keep your `SecretKey` private and do not disclose it to others.

## Installing via NuGet (recommended)

1. Install by running the `dotnet add package TencentCloudSDK --version 3.0.0` command. Please go to the [NuGet](https://www.nuget.org/packages/TencentCloudSDK/) page to get additional information.

2. Add the package through Visual Studio.

## Installing via source code

Go to the [Github code hosting page](https://github.com/tencentcloud/tencentcloud-sdk-dotnet-intl-en) to download the latest code, decompress and install it in your working directory, and then open it with Visual Studio 2017 for compiling.

# Example

Each API has a corresponding request structure and a response structure. For example, the `DescribeInstances` API for querying CVM instance list has a corresponding request structure `DescribeInstancesRequest` and a response structure `DescribeInstancesResponse`.

The following uses the API for querying CVM instance list as an example to describe the basic usage of the SDK. For the purpose of demonstration, some nonessential items have been added to show the common features of the SDK, which makes the example look bloated. When using the SDK to write code, you are recommended to keep it simple.

```C#
using System;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloudExamples
{
    class DescribeInstances
    {
        static void Main(string[] args)
        {
            try
            {
                // Essential steps:
                // Instantiate an authentication object. The Tencent Cloud account key pair `secretId` and `secretKey` need to be passed in as the input parameters.
                // The example here uses the way to read from the environment variable, so you need to set these two values in the environment variable first.
                // You can also write the key pair directly into the code, but be careful not to copy, upload, or share the code to others;
                // otherwise, the key pair may be leaked, causing damage to your properties.
                Credential cred = new Credential {
                    SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                    SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
                };               

                // Instantiate a client option (optional; skip if no special requirements are present)
                ClientProfile clientProfile = new ClientProfile();
                // Specify the signature algorithm (HmacSHA256 by default)
                clientProfile.SignMethod = ClientProfile.SIGN_SHA1;
                // Nonessential steps
                // Instantiate a client configuration object. You can specify the timeout period and other configuration items
                HttpProfile httpProfile = new HttpProfile();
                // The SDK uses the POST method by default.
                // If you have to use the GET method, you can set it here, but the GET method cannot handle some large requests.
                httpProfile.ReqMethod = "POST";
                // The SDK has a default timeout period. Do not adjust it unless absolutely necessary.
                // If needed, check in the code to get the latest default value.
                httpProfile.Timeout = 10; // Request connection timeout period in seconds (60 seconds by default)
                // The SDK automatically specifies the domain name. Generally, you don't need to specify a domain name, but if you are accessing a service in a finance availability zone,
                // you have to manually specify the domain name, such as cvm.ap-shanghai-fsi.tencentcloudapi.com for the Shanghai Finance availability zone in the CVM
                httpProfile.Endpoint = ("cvm.tencentcloudapi.com");
                // Proxy server. Set it when there is a proxy server in your environment
                httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

                clientProfile.HttpProfile = httpProfile;

                // Instantiate the client object of the requested product (with CVM as an example)
                // The second parameter is the region information. You can enter the string `ap-guangzhou` directly or import the preset constant. `clientProfile` is optional
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // Instantiate a request object. You can further set the request parameters according to the API called and actual conditions
                // You can check the SDK source code directly to determine which attributes of `DescribeInstancesRequest` can be set.
                // An attribute may be of a basic type or import another data structure.
                // You are recommended to use the IDE for development where you can redirect to and view the documentation of each API and data structure easily.
                DescribeInstancesRequest req = new DescribeInstancesRequest();
              
                // Settings of a basic parameter.
                // This API allows setting the number of instances returned, which is specified as only one here.
                // The SDK uses the pointer style to specify parameters, so even for basic parameters, you need to use pointers to assign values to them.
                // The SDK provides encapsulation functions for importing the pointers of basic parameters
                req.Limit = 1;
                // Settings of an array.
                // This API allows filtering by specified instance ID; however, as it conflicts with the `Filter` parameter to be demonstrated next, it is commented out here.
                // req.InstanceIds = new string[] { "ins-r8hr2upy" };

                // Settings of a complex object.
                // In this API, `Filters` is an array whose elements are complex objects `Filter`, and the member `Values` of `Filter` are string arrays.
                // Populate the request parameters. Here, the member variables of the request object are the input parameters of the corresponding API
                // You can view the definition of the request parameters in the API documentation at the official website or by redirecting to the definition of the request object
                Filter respFilter = new Filter(); // Create a `Filter` object to query CVM instances in the `zone` dimension
                respFilter.Name = "zone";
                respFilter.Values = new string[] { "ap-guangzhou-1", "ap-guangzhou-2" };
                req.Filters = new Filter[] { respFilter }; // `Filters` is a list of `Filter` objects

                //// Here, you can assign values to the request parameters by using a string in standard JSON format. The following code is equivalent to the parameter value assignment above
                //string strParams = "{\"Filters\":[{\"Name\":\"zone\",\"Values\":[\"ap-guangzhou-1\",\"ap-guangzhou-2\"]}]}";
                //req = DescribeInstancesRequest.FromJsonString<DescribeInstancesRequest>(strParams);

                // Initialize the request by calling the `DescribeInstances` method on the client object. Note: the request method name corresponds to the request object
                // The returned `resp` is an instance of the `DescribeInstancesResponse` class which corresponds to the request object
                DescribeInstancesResponse resp = client.DescribeInstances(req).
                    ConfigureAwait(false).GetAwaiter().GetResult();

                // Call the result with a sync API
                // DescribeInstancesResponse resp = client.DescribeInstancesSync(req);

                // A string return packet in JSON format is output
                Console.WriteLine(AbstractModel.ToJsonString(resp));

                // You can also take a single value
                // You can view the definition of the return field in the API documentation at the official website or by redirecting to the definition of the response object
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

```

For more examples, please see the `TencentCloudExamples` directory at [GitHub](https://github.com/TencentCloud/tencentcloud-sdk-dotnet-intl-en).

## Sync and async calls

The new version of the SDK provides both async and sync APIs. The sync APIs have the ```Sync``` suffix uniformly after the async APIs as demonstrated in the code above.

Note:

In the example, as it is a console application, you can call the async APIs synchronously, i.e., `ConfigureAwait(false).GetAwaiter().GetResult()`.
When developing ASP applications or Windows Forms applications, you cannot call the async APIs synchronously in the response method of UI controls; otherwise, the UI will stop responding.
The solution is to change the response method of the UI controls to async and pay attention to the sync context.
In addition, as async call immediately returns control to the user, it is prone to cause the user to click multiple times or perform unexpected operations. Such problems should be avoided in the program.
