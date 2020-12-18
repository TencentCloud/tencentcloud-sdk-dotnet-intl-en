/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cloudaudit.V20190319
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudaudit.V20190319.Models;

   public class CloudauditClient : AbstractClient{

       private const string endpoint = "cloudaudit.tencentcloudapi.com";
       private const string version = "2019-03-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudauditClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudauditClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create resource recorders to detect and record resource configuration changes.
        /// </summary>
        /// <param name="req"><see cref="CreateRecorderRequest"/></param>
        /// <returns><see cref="CreateRecorderResponse"/></returns>
        public async Task<CreateRecorderResponse> CreateRecorder(CreateRecorderRequest req)
        {
             JsonResponseModel<CreateRecorderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRecorder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecorderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create resource recorders to detect and record resource configuration changes.
        /// </summary>
        /// <param name="req"><see cref="CreateRecorderRequest"/></param>
        /// <returns><see cref="CreateRecorderResponse"/></returns>
        public CreateRecorderResponse CreateRecorderSync(CreateRecorderRequest req)
        {
             JsonResponseModel<CreateRecorderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRecorder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRecorderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete resource recorders. After deletion, resource configuration changes will not be recorded.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecorderRequest"/></param>
        /// <returns><see cref="DeleteRecorderResponse"/></returns>
        public async Task<DeleteRecorderResponse> DeleteRecorder(DeleteRecorderRequest req)
        {
             JsonResponseModel<DeleteRecorderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecorder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecorderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete resource recorders. After deletion, resource configuration changes will not be recorded.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecorderRequest"/></param>
        /// <returns><see cref="DeleteRecorderResponse"/></returns>
        public DeleteRecorderResponse DeleteRecorderSync(DeleteRecorderRequest req)
        {
             JsonResponseModel<DeleteRecorderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecorder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecorderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the basic information of discovered resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiscoveredResourceRequest"/></param>
        /// <returns><see cref="DescribeDiscoveredResourceResponse"/></returns>
        public async Task<DescribeDiscoveredResourceResponse> DescribeDiscoveredResource(DescribeDiscoveredResourceRequest req)
        {
             JsonResponseModel<DescribeDiscoveredResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiscoveredResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiscoveredResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the basic information of discovered resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiscoveredResourceRequest"/></param>
        /// <returns><see cref="DescribeDiscoveredResourceResponse"/></returns>
        public DescribeDiscoveredResourceResponse DescribeDiscoveredResourceSync(DescribeDiscoveredResourceRequest req)
        {
             JsonResponseModel<DescribeDiscoveredResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiscoveredResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiscoveredResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display current configurations and status of a recorder.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecorderRequest"/></param>
        /// <returns><see cref="DescribeRecorderResponse"/></returns>
        public async Task<DescribeRecorderResponse> DescribeRecorder(DescribeRecorderRequest req)
        {
             JsonResponseModel<DescribeRecorderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRecorder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecorderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to display current configurations and status of a recorder.
        /// </summary>
        /// <param name="req"><see cref="DescribeRecorderRequest"/></param>
        /// <returns><see cref="DescribeRecorderResponse"/></returns>
        public DescribeRecorderResponse DescribeRecorderSync(DescribeRecorderRequest req)
        {
             JsonResponseModel<DescribeRecorderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRecorder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRecorderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of resource configuration items and display resource configuration changes in chronological order.
        /// </summary>
        /// <param name="req"><see cref="GetConfigurationItemsRequest"/></param>
        /// <returns><see cref="GetConfigurationItemsResponse"/></returns>
        public async Task<GetConfigurationItemsResponse> GetConfigurationItems(GetConfigurationItemsRequest req)
        {
             JsonResponseModel<GetConfigurationItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetConfigurationItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetConfigurationItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of resource configuration items and display resource configuration changes in chronological order.
        /// </summary>
        /// <param name="req"><see cref="GetConfigurationItemsRequest"/></param>
        /// <returns><see cref="GetConfigurationItemsResponse"/></returns>
        public GetConfigurationItemsResponse GetConfigurationItemsSync(GetConfigurationItemsRequest req)
        {
             JsonResponseModel<GetConfigurationItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetConfigurationItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetConfigurationItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the list of discovered resources.
        /// </summary>
        /// <param name="req"><see cref="ListDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListDiscoveredResourcesResponse"/></returns>
        public async Task<ListDiscoveredResourcesResponse> ListDiscoveredResources(ListDiscoveredResourcesRequest req)
        {
             JsonResponseModel<ListDiscoveredResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListDiscoveredResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDiscoveredResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the list of discovered resources.
        /// </summary>
        /// <param name="req"><see cref="ListDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListDiscoveredResourcesResponse"/></returns>
        public ListDiscoveredResourcesResponse ListDiscoveredResourcesSync(ListDiscoveredResourcesRequest req)
        {
             JsonResponseModel<ListDiscoveredResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListDiscoveredResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDiscoveredResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of all CFA supported resource types.
        /// </summary>
        /// <param name="req"><see cref="ListSupportResourceTypesRequest"/></param>
        /// <returns><see cref="ListSupportResourceTypesResponse"/></returns>
        public async Task<ListSupportResourceTypesResponse> ListSupportResourceTypes(ListSupportResourceTypesRequest req)
        {
             JsonResponseModel<ListSupportResourceTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSupportResourceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSupportResourceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of all CFA supported resource types.
        /// </summary>
        /// <param name="req"><see cref="ListSupportResourceTypesRequest"/></param>
        /// <returns><see cref="ListSupportResourceTypesResponse"/></returns>
        public ListSupportResourceTypesResponse ListSupportResourceTypesSync(ListSupportResourceTypesRequest req)
        {
             JsonResponseModel<ListSupportResourceTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSupportResourceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSupportResourceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the resources to monitor, recorder name, and other recorder configurations.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecorderRequest"/></param>
        /// <returns><see cref="UpdateRecorderResponse"/></returns>
        public async Task<UpdateRecorderResponse> UpdateRecorder(UpdateRecorderRequest req)
        {
             JsonResponseModel<UpdateRecorderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRecorder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecorderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the resources to monitor, recorder name, and other recorder configurations.
        /// </summary>
        /// <param name="req"><see cref="UpdateRecorderRequest"/></param>
        /// <returns><see cref="UpdateRecorderResponse"/></returns>
        public UpdateRecorderResponse UpdateRecorderSync(UpdateRecorderRequest req)
        {
             JsonResponseModel<UpdateRecorderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRecorder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRecorderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
