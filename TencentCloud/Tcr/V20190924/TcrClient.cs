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

namespace TencentCloud.Tcr.V20190924
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcr.V20190924.Models;

   public class TcrClient : AbstractClient{

       private const string endpoint = "tcr.tencentcloudapi.com";
       private const string version = "2019-09-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to verify the information of the Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public async Task<CheckInstanceResponse> CheckInstance(CheckInstanceRequest req)
        {
             JsonResponseModel<CheckInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify the information of the Enterprise Edition instance.
        /// </summary>
        /// <param name="req"><see cref="CheckInstanceRequest"/></param>
        /// <returns><see cref="CheckInstanceResponse"/></returns>
        public CheckInstanceResponse CheckInstanceSync(CheckInstanceRequest req)
        {
             JsonResponseModel<CheckInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public async Task<CreateImmutableTagRulesResponse> CreateImmutableTagRules(CreateImmutableTagRulesRequest req)
        {
             JsonResponseModel<CreateImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="CreateImmutableTagRulesRequest"/></param>
        /// <returns><see cref="CreateImmutableTagRulesResponse"/></returns>
        public CreateImmutableTagRulesResponse CreateImmutableTagRulesSync(CreateImmutableTagRulesRequest req)
        {
             JsonResponseModel<CreateImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a temporary or long-term instance access credential.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public async Task<CreateInstanceTokenResponse> CreateInstanceToken(CreateInstanceTokenRequest req)
        {
             JsonResponseModel<CreateInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a temporary or long-term instance access credential.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceTokenRequest"/></param>
        /// <returns><see cref="CreateInstanceTokenResponse"/></returns>
        public CreateInstanceTokenResponse CreateInstanceTokenSync(CreateInstanceTokenRequest req)
        {
             JsonResponseModel<CreateInstanceTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create multiple public network access allowlist policies of the TCR instance.
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public async Task<CreateMultipleSecurityPolicyResponse> CreateMultipleSecurityPolicy(CreateMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create multiple public network access allowlist policies of the TCR instance.
        /// </summary>
        /// <param name="req"><see cref="CreateMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="CreateMultipleSecurityPolicyResponse"/></returns>
        public CreateMultipleSecurityPolicyResponse CreateMultipleSecurityPolicySync(CreateMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<CreateMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a replication instance.
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public async Task<CreateReplicationInstanceResponse> CreateReplicationInstance(CreateReplicationInstanceRequest req)
        {
             JsonResponseModel<CreateReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a replication instance.
        /// </summary>
        /// <param name="req"><see cref="CreateReplicationInstanceRequest"/></param>
        /// <returns><see cref="CreateReplicationInstanceResponse"/></returns>
        public CreateReplicationInstanceResponse CreateReplicationInstanceSync(CreateReplicationInstanceRequest req)
        {
             JsonResponseModel<CreateReplicationInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReplicationInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReplicationInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to delete the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public async Task<DeleteImmutableTagRulesResponse> DeleteImmutableTagRules(DeleteImmutableTagRulesRequest req)
        {
             JsonResponseModel<DeleteImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  This API is used to delete the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DeleteImmutableTagRulesResponse"/></returns>
        public DeleteImmutableTagRulesResponse DeleteImmutableTagRulesSync(DeleteImmutableTagRulesRequest req)
        {
             JsonResponseModel<DeleteImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete multiple public network access allowlist policies of the instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public async Task<DeleteMultipleSecurityPolicyResponse> DeleteMultipleSecurityPolicy(DeleteMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete multiple public network access allowlist policies of the instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteMultipleSecurityPolicyRequest"/></param>
        /// <returns><see cref="DeleteMultipleSecurityPolicyResponse"/></returns>
        public DeleteMultipleSecurityPolicyResponse DeleteMultipleSecurityPolicySync(DeleteMultipleSecurityPolicyRequest req)
        {
             JsonResponseModel<DeleteMultipleSecurityPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMultipleSecurityPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMultipleSecurityPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public async Task<DescribeImmutableTagRulesResponse> DescribeImmutableTagRules(DescribeImmutableTagRulesRequest req)
        {
             JsonResponseModel<DescribeImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to list the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="DescribeImmutableTagRulesRequest"/></param>
        /// <returns><see cref="DescribeImmutableTagRulesResponse"/></returns>
        public DescribeImmutableTagRulesResponse DescribeImmutableTagRulesSync(DescribeImmutableTagRulesRequest req)
        {
             JsonResponseModel<DescribeImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task status of creating a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public async Task<DescribeReplicationInstanceCreateTasksResponse> DescribeReplicationInstanceCreateTasks(DescribeReplicationInstanceCreateTasksRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstanceCreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the task status of creating a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceCreateTasksRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceCreateTasksResponse"/></returns>
        public DescribeReplicationInstanceCreateTasksResponse DescribeReplicationInstanceCreateTasksSync(DescribeReplicationInstanceCreateTasksRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstanceCreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceCreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the synchronization status of a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public async Task<DescribeReplicationInstanceSyncStatusResponse> DescribeReplicationInstanceSyncStatus(DescribeReplicationInstanceSyncStatusRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstanceSyncStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the synchronization status of a replication instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstanceSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstanceSyncStatusResponse"/></returns>
        public DescribeReplicationInstanceSyncStatusResponse DescribeReplicationInstanceSyncStatusSync(DescribeReplicationInstanceSyncStatusRequest req)
        {
             JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstanceSyncStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstanceSyncStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of replication instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public async Task<DescribeReplicationInstancesResponse> DescribeReplicationInstances(DescribeReplicationInstancesRequest req)
        {
             JsonResponseModel<DescribeReplicationInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReplicationInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of replication instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeReplicationInstancesRequest"/></param>
        /// <returns><see cref="DescribeReplicationInstancesResponse"/></returns>
        public DescribeReplicationInstancesResponse DescribeReplicationInstancesSync(DescribeReplicationInstancesRequest req)
        {
             JsonResponseModel<DescribeReplicationInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReplicationInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReplicationInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage the instance synchronization rule.
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public async Task<ManageReplicationResponse> ManageReplication(ManageReplicationRequest req)
        {
             JsonResponseModel<ManageReplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manage the instance synchronization rule.
        /// </summary>
        /// <param name="req"><see cref="ManageReplicationRequest"/></param>
        /// <returns><see cref="ManageReplicationResponse"/></returns>
        public ManageReplicationResponse ManageReplicationSync(ManageReplicationRequest req)
        {
             JsonResponseModel<ManageReplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public async Task<ModifyImmutableTagRulesResponse> ModifyImmutableTagRules(ModifyImmutableTagRulesRequest req)
        {
             JsonResponseModel<ModifyImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the tag immutability rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyImmutableTagRulesRequest"/></param>
        /// <returns><see cref="ModifyImmutableTagRulesResponse"/></returns>
        public ModifyImmutableTagRulesResponse ModifyImmutableTagRulesSync(ModifyImmutableTagRulesRequest req)
        {
             JsonResponseModel<ModifyImmutableTagRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImmutableTagRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImmutableTagRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public async Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update instance information.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
             JsonResponseModel<ModifyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
