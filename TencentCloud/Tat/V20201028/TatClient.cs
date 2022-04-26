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

namespace TencentCloud.Tat.V20201028
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tat.V20201028.Models;

   public class TatClient : AbstractClient{

       private const string endpoint = "tat.tencentcloudapi.com";
       private const string version = "2020-10-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TatClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TatClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to cancel the command executed on one or more CVM instances.
        /// 
        /// * If the command has not been delivered to the TAT agent, the task status is `PENDING`, `DELIVERING`, or `DELIVER_DELAYED`, and will be `CANCELLED` after the command is canceled.
        /// * If the command has been delivered to the TAT agent, the task status is `RUNNING`, and will be `TERMINATED` after the command is canceled.
        /// </summary>
        /// <param name="req"><see cref="CancelInvocationRequest"/></param>
        /// <returns><see cref="CancelInvocationResponse"/></returns>
        public async Task<CancelInvocationResponse> CancelInvocation(CancelInvocationRequest req)
        {
             JsonResponseModel<CancelInvocationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelInvocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelInvocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel the command executed on one or more CVM instances.
        /// 
        /// * If the command has not been delivered to the TAT agent, the task status is `PENDING`, `DELIVERING`, or `DELIVER_DELAYED`, and will be `CANCELLED` after the command is canceled.
        /// * If the command has been delivered to the TAT agent, the task status is `RUNNING`, and will be `TERMINATED` after the command is canceled.
        /// </summary>
        /// <param name="req"><see cref="CancelInvocationRequest"/></param>
        /// <returns><see cref="CancelInvocationResponse"/></returns>
        public CancelInvocationResponse CancelInvocationSync(CancelInvocationRequest req)
        {
             JsonResponseModel<CancelInvocationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelInvocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelInvocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a command.
        /// </summary>
        /// <param name="req"><see cref="CreateCommandRequest"/></param>
        /// <returns><see cref="CreateCommandResponse"/></returns>
        public async Task<CreateCommandResponse> CreateCommand(CreateCommandRequest req)
        {
             JsonResponseModel<CreateCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a command.
        /// </summary>
        /// <param name="req"><see cref="CreateCommandRequest"/></param>
        /// <returns><see cref="CreateCommandResponse"/></returns>
        public CreateCommandResponse CreateCommandSync(CreateCommandRequest req)
        {
             JsonResponseModel<CreateCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an invoker.
        /// </summary>
        /// <param name="req"><see cref="CreateInvokerRequest"/></param>
        /// <returns><see cref="CreateInvokerResponse"/></returns>
        public async Task<CreateInvokerResponse> CreateInvoker(CreateInvokerRequest req)
        {
             JsonResponseModel<CreateInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an invoker.
        /// </summary>
        /// <param name="req"><see cref="CreateInvokerRequest"/></param>
        /// <returns><see cref="CreateInvokerResponse"/></returns>
        public CreateInvokerResponse CreateInvokerSync(CreateInvokerRequest req)
        {
             JsonResponseModel<CreateInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a command.
        /// Commands bound to an invoker cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandRequest"/></param>
        /// <returns><see cref="DeleteCommandResponse"/></returns>
        public async Task<DeleteCommandResponse> DeleteCommand(DeleteCommandRequest req)
        {
             JsonResponseModel<DeleteCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a command.
        /// Commands bound to an invoker cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandRequest"/></param>
        /// <returns><see cref="DeleteCommandResponse"/></returns>
        public DeleteCommandResponse DeleteCommandSync(DeleteCommandRequest req)
        {
             JsonResponseModel<DeleteCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an invoker.
        /// </summary>
        /// <param name="req"><see cref="DeleteInvokerRequest"/></param>
        /// <returns><see cref="DeleteInvokerResponse"/></returns>
        public async Task<DeleteInvokerResponse> DeleteInvoker(DeleteInvokerRequest req)
        {
             JsonResponseModel<DeleteInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an invoker.
        /// </summary>
        /// <param name="req"><see cref="DeleteInvokerRequest"/></param>
        /// <returns><see cref="DeleteInvokerResponse"/></returns>
        public DeleteInvokerResponse DeleteInvokerSync(DeleteInvokerRequest req)
        {
             JsonResponseModel<DeleteInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of the TAT agent.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutomationAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeAutomationAgentStatusResponse"/></returns>
        public async Task<DescribeAutomationAgentStatusResponse> DescribeAutomationAgentStatus(DescribeAutomationAgentStatusRequest req)
        {
             JsonResponseModel<DescribeAutomationAgentStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutomationAgentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutomationAgentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of the TAT agent.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutomationAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeAutomationAgentStatusResponse"/></returns>
        public DescribeAutomationAgentStatusResponse DescribeAutomationAgentStatusSync(DescribeAutomationAgentStatusRequest req)
        {
             JsonResponseModel<DescribeAutomationAgentStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutomationAgentStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutomationAgentStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query command details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandsRequest"/></param>
        /// <returns><see cref="DescribeCommandsResponse"/></returns>
        public async Task<DescribeCommandsResponse> DescribeCommands(DescribeCommandsRequest req)
        {
             JsonResponseModel<DescribeCommandsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCommands");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCommandsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query command details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandsRequest"/></param>
        /// <returns><see cref="DescribeCommandsResponse"/></returns>
        public DescribeCommandsResponse DescribeCommandsSync(DescribeCommandsRequest req)
        {
             JsonResponseModel<DescribeCommandsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCommands");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCommandsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query execution task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationTasksRequest"/></param>
        /// <returns><see cref="DescribeInvocationTasksResponse"/></returns>
        public async Task<DescribeInvocationTasksResponse> DescribeInvocationTasks(DescribeInvocationTasksRequest req)
        {
             JsonResponseModel<DescribeInvocationTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInvocationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvocationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query execution task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationTasksRequest"/></param>
        /// <returns><see cref="DescribeInvocationTasksResponse"/></returns>
        public DescribeInvocationTasksResponse DescribeInvocationTasksSync(DescribeInvocationTasksRequest req)
        {
             JsonResponseModel<DescribeInvocationTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInvocationTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvocationTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query execution activity details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public async Task<DescribeInvocationsResponse> DescribeInvocations(DescribeInvocationsRequest req)
        {
             JsonResponseModel<DescribeInvocationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInvocations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvocationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query execution activity details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public DescribeInvocationsResponse DescribeInvocationsSync(DescribeInvocationsRequest req)
        {
             JsonResponseModel<DescribeInvocationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInvocations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvocationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution history of an invoker.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokerRecordsRequest"/></param>
        /// <returns><see cref="DescribeInvokerRecordsResponse"/></returns>
        public async Task<DescribeInvokerRecordsResponse> DescribeInvokerRecords(DescribeInvokerRecordsRequest req)
        {
             JsonResponseModel<DescribeInvokerRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInvokerRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvokerRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the execution history of an invoker.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokerRecordsRequest"/></param>
        /// <returns><see cref="DescribeInvokerRecordsResponse"/></returns>
        public DescribeInvokerRecordsResponse DescribeInvokerRecordsSync(DescribeInvokerRecordsRequest req)
        {
             JsonResponseModel<DescribeInvokerRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInvokerRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvokerRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query invoker details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokersRequest"/></param>
        /// <returns><see cref="DescribeInvokersResponse"/></returns>
        public async Task<DescribeInvokersResponse> DescribeInvokers(DescribeInvokersRequest req)
        {
             JsonResponseModel<DescribeInvokersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInvokers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvokersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query invoker details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokersRequest"/></param>
        /// <returns><see cref="DescribeInvokersResponse"/></returns>
        public DescribeInvokersResponse DescribeInvokersSync(DescribeInvokersRequest req)
        {
             JsonResponseModel<DescribeInvokersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInvokers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInvokersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of regions that supports TAT.
        /// If the `RegionState` is `AVAILABLE`, it means that TAT is available in the region. If no value is returned, TAT is not available in the region.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of regions that supports TAT.
        /// If the `RegionState` is `AVAILABLE`, it means that TAT is available in the region. If no value is returned, TAT is not available in the region.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable an invoker.
        /// </summary>
        /// <param name="req"><see cref="DisableInvokerRequest"/></param>
        /// <returns><see cref="DisableInvokerResponse"/></returns>
        public async Task<DisableInvokerResponse> DisableInvoker(DisableInvokerRequest req)
        {
             JsonResponseModel<DisableInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable an invoker.
        /// </summary>
        /// <param name="req"><see cref="DisableInvokerRequest"/></param>
        /// <returns><see cref="DisableInvokerResponse"/></returns>
        public DisableInvokerResponse DisableInvokerSync(DisableInvokerRequest req)
        {
             JsonResponseModel<DisableInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable an invoker.
        /// </summary>
        /// <param name="req"><see cref="EnableInvokerRequest"/></param>
        /// <returns><see cref="EnableInvokerResponse"/></returns>
        public async Task<EnableInvokerResponse> EnableInvoker(EnableInvokerRequest req)
        {
             JsonResponseModel<EnableInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable an invoker.
        /// </summary>
        /// <param name="req"><see cref="EnableInvokerRequest"/></param>
        /// <returns><see cref="EnableInvokerResponse"/></returns>
        public EnableInvokerResponse EnableInvokerSync(EnableInvokerRequest req)
        {
             JsonResponseModel<EnableInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to trigger a command on the specified instance and returns the execution activity ID (inv-xxxxxxxx) on success. Each execution activity has one or more execution tasks (invt-xxxxxxxx) and each execution task indicates an execution record on a CVM or Lighthouse instance.
        /// 
        /// * If the agent is not installed on the instance or is offline, an error is returned.
        /// * If the command type is not supported by the agent runtime environment, an error is returned.
        /// * The specified instance needs to be in a VPC network.
        /// * The specified instance needs to be in the RUNNING status.
        /// * Only one type of instances (CVM or Lighthouse) can be specified in a single request.
        /// </summary>
        /// <param name="req"><see cref="InvokeCommandRequest"/></param>
        /// <returns><see cref="InvokeCommandResponse"/></returns>
        public async Task<InvokeCommandResponse> InvokeCommand(InvokeCommandRequest req)
        {
             JsonResponseModel<InvokeCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InvokeCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to trigger a command on the specified instance and returns the execution activity ID (inv-xxxxxxxx) on success. Each execution activity has one or more execution tasks (invt-xxxxxxxx) and each execution task indicates an execution record on a CVM or Lighthouse instance.
        /// 
        /// * If the agent is not installed on the instance or is offline, an error is returned.
        /// * If the command type is not supported by the agent runtime environment, an error is returned.
        /// * The specified instance needs to be in a VPC network.
        /// * The specified instance needs to be in the RUNNING status.
        /// * Only one type of instances (CVM or Lighthouse) can be specified in a single request.
        /// </summary>
        /// <param name="req"><see cref="InvokeCommandRequest"/></param>
        /// <returns><see cref="InvokeCommandResponse"/></returns>
        public InvokeCommandResponse InvokeCommandSync(InvokeCommandRequest req)
        {
             JsonResponseModel<InvokeCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InvokeCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InvokeCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a command.
        /// </summary>
        /// <param name="req"><see cref="ModifyCommandRequest"/></param>
        /// <returns><see cref="ModifyCommandResponse"/></returns>
        public async Task<ModifyCommandResponse> ModifyCommand(ModifyCommandRequest req)
        {
             JsonResponseModel<ModifyCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a command.
        /// </summary>
        /// <param name="req"><see cref="ModifyCommandRequest"/></param>
        /// <returns><see cref="ModifyCommandResponse"/></returns>
        public ModifyCommandResponse ModifyCommandSync(ModifyCommandRequest req)
        {
             JsonResponseModel<ModifyCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an invoker.
        /// </summary>
        /// <param name="req"><see cref="ModifyInvokerRequest"/></param>
        /// <returns><see cref="ModifyInvokerResponse"/></returns>
        public async Task<ModifyInvokerResponse> ModifyInvoker(ModifyInvokerRequest req)
        {
             JsonResponseModel<ModifyInvokerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an invoker.
        /// </summary>
        /// <param name="req"><see cref="ModifyInvokerRequest"/></param>
        /// <returns><see cref="ModifyInvokerResponse"/></returns>
        public ModifyInvokerResponse ModifyInvokerSync(ModifyInvokerRequest req)
        {
             JsonResponseModel<ModifyInvokerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInvoker");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInvokerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to preview the command with custom parameters. The command is not executed.
        /// </summary>
        /// <param name="req"><see cref="PreviewReplacedCommandContentRequest"/></param>
        /// <returns><see cref="PreviewReplacedCommandContentResponse"/></returns>
        public async Task<PreviewReplacedCommandContentResponse> PreviewReplacedCommandContent(PreviewReplacedCommandContentRequest req)
        {
             JsonResponseModel<PreviewReplacedCommandContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PreviewReplacedCommandContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PreviewReplacedCommandContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to preview the command with custom parameters. The command is not executed.
        /// </summary>
        /// <param name="req"><see cref="PreviewReplacedCommandContentRequest"/></param>
        /// <returns><see cref="PreviewReplacedCommandContentResponse"/></returns>
        public PreviewReplacedCommandContentResponse PreviewReplacedCommandContentSync(PreviewReplacedCommandContentRequest req)
        {
             JsonResponseModel<PreviewReplacedCommandContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PreviewReplacedCommandContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PreviewReplacedCommandContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to execute a command and returns the execution activity ID (inv-xxxxxxxx) on success. Each execution has one or more execution tasks (invt-xxxxxxxx) and each execution task indicates an execution record on a CVM or Lighthouse instance.
        /// 
        /// * If the agent is not installed on the instance or is offline, an error is returned.
        /// * If the command type is not supported by the agent runtime environment, an error is returned.
        /// * The specified instance needs to be in a VPC network.
        /// * The specified instance needs to be in the `RUNNING` status.
        /// * Only one type of instances (CVM or Lighthouse) can be specified in a single request.
        /// </summary>
        /// <param name="req"><see cref="RunCommandRequest"/></param>
        /// <returns><see cref="RunCommandResponse"/></returns>
        public async Task<RunCommandResponse> RunCommand(RunCommandRequest req)
        {
             JsonResponseModel<RunCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to execute a command and returns the execution activity ID (inv-xxxxxxxx) on success. Each execution has one or more execution tasks (invt-xxxxxxxx) and each execution task indicates an execution record on a CVM or Lighthouse instance.
        /// 
        /// * If the agent is not installed on the instance or is offline, an error is returned.
        /// * If the command type is not supported by the agent runtime environment, an error is returned.
        /// * The specified instance needs to be in a VPC network.
        /// * The specified instance needs to be in the `RUNNING` status.
        /// * Only one type of instances (CVM or Lighthouse) can be specified in a single request.
        /// </summary>
        /// <param name="req"><see cref="RunCommandRequest"/></param>
        /// <returns><see cref="RunCommandResponse"/></returns>
        public RunCommandResponse RunCommandSync(RunCommandRequest req)
        {
             JsonResponseModel<RunCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
