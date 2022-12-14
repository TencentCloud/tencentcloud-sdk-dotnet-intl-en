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
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to add user lists (user management).
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public async Task<AddUsersForUserManagerResponse> AddUsersForUserManager(AddUsersForUserManagerRequest req)
        {
             JsonResponseModel<AddUsersForUserManagerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUsersForUserManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUsersForUserManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to add user lists (user management).
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public AddUsersForUserManagerResponse AddUsersForUserManagerSync(AddUsersForUserManagerRequest req)
        {
             JsonResponseModel<AddUsersForUserManagerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUsersForUserManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUsersForUserManagerResponse>>(strResp);
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
        /// This API is used to query the information of nodes in a cluster.
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
        /// This API is used to query the information of nodes in a cluster.
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
        ///  This API is used to query the Yarn application statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public async Task<DescribeEmrApplicationStaticsResponse> DescribeEmrApplicationStatics(DescribeEmrApplicationStaticsRequest req)
        {
             JsonResponseModel<DescribeEmrApplicationStaticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEmrApplicationStatics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmrApplicationStaticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to query the Yarn application statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public DescribeEmrApplicationStaticsResponse DescribeEmrApplicationStaticsSync(DescribeEmrApplicationStaticsRequest req)
        {
             JsonResponseModel<DescribeEmrApplicationStaticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEmrApplicationStatics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmrApplicationStaticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of instances in a cluster.
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
        /// This API is used to query the information of instances in a cluster.
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
        /// This API is used to query the cluster list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public async Task<DescribeInstancesListResponse> DescribeInstancesList(DescribeInstancesListRequest req)
        {
             JsonResponseModel<DescribeInstancesListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstancesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the cluster list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public DescribeInstancesListResponse DescribeInstancesListSync(DescribeInstancesListRequest req)
        {
             JsonResponseModel<DescribeInstancesListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstancesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstancesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the data of YARN Resource Scheduling.
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
        /// This API is used to query the data of YARN Resource Scheduling.
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
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to export users in batches. For a Kerberos cluster, set `NeedKeytabInfo` to `true` to obtain the download link of the Keytab file. If `SupportDownLoadKeyTab` is `true`, but `DownLoadKeyTabUrl` is null, the Keytab file is not ready yet (being generated) in the backend.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public async Task<DescribeUsersForUserManagerResponse> DescribeUsersForUserManager(DescribeUsersForUserManagerRequest req)
        {
             JsonResponseModel<DescribeUsersForUserManagerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsersForUserManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersForUserManagerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to export users in batches. For a Kerberos cluster, set `NeedKeytabInfo` to `true` to obtain the download link of the Keytab file. If `SupportDownLoadKeyTab` is `true`, but `DownLoadKeyTabUrl` is null, the Keytab file is not ready yet (being generated) in the backend.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public DescribeUsersForUserManagerResponse DescribeUsersForUserManagerSync(DescribeUsersForUserManagerRequest req)
        {
             JsonResponseModel<DescribeUsersForUserManagerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsersForUserManager");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersForUserManagerResponse>>(strResp);
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
        /// This API is used to query price of scale-out.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public async Task<InquiryPriceScaleOutInstanceResponse> InquiryPriceScaleOutInstance(InquiryPriceScaleOutInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query price of scale-out.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public InquiryPriceScaleOutInstanceResponse InquiryPriceScaleOutInstanceSync(InquiryPriceScaleOutInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceScaleOutInstanceResponse>>(strResp);
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
        /// This API is used to scale out instances.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public async Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
             JsonResponseModel<ScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to scale out instances.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
             JsonResponseModel<ScaleOutInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScaleOutInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate EMR instances. It is only supported in the official paid edition of EMR.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public async Task<TerminateInstanceResponse> TerminateInstance(TerminateInstanceRequest req)
        {
             JsonResponseModel<TerminateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate EMR instances. It is only supported in the official paid edition of EMR.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public TerminateInstanceResponse TerminateInstanceSync(TerminateInstanceRequest req)
        {
             JsonResponseModel<TerminateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateInstanceResponse>>(strResp);
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
