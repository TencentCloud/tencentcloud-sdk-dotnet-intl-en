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

namespace TencentCloud.Emr.V20190103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Emr.V20190103.Models;

   public class EmrClient : AbstractClient{

       private const string endpoint = "emr.tencentcloudapi.com";
       private const string version = "2019-01-03";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EmrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EmrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public async Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
             JsonResponseModel<CreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a hardware node.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public async Task<DescribeClusterNodesResponse> DescribeClusterNodes(DescribeClusterNodesRequest req)
        {
             JsonResponseModel<DescribeClusterNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a hardware node.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public DescribeClusterNodesResponse DescribeClusterNodesSync(DescribeClusterNodesRequest req)
        {
             JsonResponseModel<DescribeClusterNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query EMR instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query EMR instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
             JsonResponseModel<DescribeInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get data from the YARN Resource Scheduling page.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public async Task<DescribeResourceScheduleResponse> DescribeResourceSchedule(DescribeResourceScheduleRequest req)
        {
             JsonResponseModel<DescribeResourceScheduleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get data from the YARN Resource Scheduling page.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public DescribeResourceScheduleResponse DescribeResourceScheduleSync(DescribeResourceScheduleRequest req)
        {
             JsonResponseModel<DescribeResourceScheduleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceSchedule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceScheduleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query price of instance creation.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public async Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query price of instance creation.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceCreateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for renewal.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public async Task<InquiryPriceRenewInstanceResponse> InquiryPriceRenewInstance(InquiryPriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price for renewal.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public InquiryPriceRenewInstanceResponse InquiryPriceRenewInstanceSync(InquiryPriceRenewInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query price of scaling.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public async Task<InquiryPriceUpdateInstanceResponse> InquiryPriceUpdateInstance(InquiryPriceUpdateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query price of scaling.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public InquiryPriceUpdateInstanceResponse InquiryPriceUpdateInstanceSync(InquiryPriceUpdateInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the resource configuration of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public async Task<ModifyResourceScheduleConfigResponse> ModifyResourceScheduleConfig(ModifyResourceScheduleConfigRequest req)
        {
             JsonResponseModel<ModifyResourceScheduleConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceScheduleConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceScheduleConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the resource configuration of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public ModifyResourceScheduleConfigResponse ModifyResourceScheduleConfigSync(ModifyResourceScheduleConfigRequest req)
        {
             JsonResponseModel<ModifyResourceScheduleConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceScheduleConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceScheduleConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the YARN resource scheduler (the change will take effect after you click Apply).
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public async Task<ModifyResourceSchedulerResponse> ModifyResourceScheduler(ModifyResourceSchedulerRequest req)
        {
             JsonResponseModel<ModifyResourceSchedulerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceScheduler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceSchedulerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the YARN resource scheduler (the change will take effect after you click Apply).
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public ModifyResourceSchedulerResponse ModifyResourceSchedulerSync(ModifyResourceSchedulerRequest req)
        {
             JsonResponseModel<ModifyResourceSchedulerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceScheduler");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceSchedulerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a task node.
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public async Task<TerminateTasksResponse> TerminateTasks(TerminateTasksRequest req)
        {
             JsonResponseModel<TerminateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a task node.
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public TerminateTasksResponse TerminateTasksSync(TerminateTasksRequest req)
        {
             JsonResponseModel<TerminateTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
