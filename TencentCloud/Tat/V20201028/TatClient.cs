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
       private const string sdkVersion = "SDK_NET_3.0.925";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TatClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to cancel the command executed on one or more CVM instances.
        /// 
        /// * If the command has not been delivered to the TAT agent, the task status is `PENDING`, `DELIVERING`, or `DELIVER_DELAYED`, and will be `CANCELLED` after the command is canceled.
        /// * If the command has been delivered to the TAT agent, the task status is `RUNNING`, and will be `TERMINATED` after the command is canceled.
        /// </summary>
        /// <param name="req"><see cref="CancelInvocationRequest"/></param>
        /// <returns><see cref="CancelInvocationResponse"/></returns>
        public Task<CancelInvocationResponse> CancelInvocation(CancelInvocationRequest req)
        {
            return InternalRequestAsync<CancelInvocationResponse>(req, "CancelInvocation");
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
            return InternalRequestAsync<CancelInvocationResponse>(req, "CancelInvocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a command.
        /// </summary>
        /// <param name="req"><see cref="CreateCommandRequest"/></param>
        /// <returns><see cref="CreateCommandResponse"/></returns>
        public Task<CreateCommandResponse> CreateCommand(CreateCommandRequest req)
        {
            return InternalRequestAsync<CreateCommandResponse>(req, "CreateCommand");
        }

        /// <summary>
        /// This API is used to create a command.
        /// </summary>
        /// <param name="req"><see cref="CreateCommandRequest"/></param>
        /// <returns><see cref="CreateCommandResponse"/></returns>
        public CreateCommandResponse CreateCommandSync(CreateCommandRequest req)
        {
            return InternalRequestAsync<CreateCommandResponse>(req, "CreateCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an invoker.
        /// </summary>
        /// <param name="req"><see cref="CreateInvokerRequest"/></param>
        /// <returns><see cref="CreateInvokerResponse"/></returns>
        public Task<CreateInvokerResponse> CreateInvoker(CreateInvokerRequest req)
        {
            return InternalRequestAsync<CreateInvokerResponse>(req, "CreateInvoker");
        }

        /// <summary>
        /// This API is used to create an invoker.
        /// </summary>
        /// <param name="req"><see cref="CreateInvokerRequest"/></param>
        /// <returns><see cref="CreateInvokerResponse"/></returns>
        public CreateInvokerResponse CreateInvokerSync(CreateInvokerRequest req)
        {
            return InternalRequestAsync<CreateInvokerResponse>(req, "CreateInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a command.
        /// Commands bound to an invoker cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandRequest"/></param>
        /// <returns><see cref="DeleteCommandResponse"/></returns>
        public Task<DeleteCommandResponse> DeleteCommand(DeleteCommandRequest req)
        {
            return InternalRequestAsync<DeleteCommandResponse>(req, "DeleteCommand");
        }

        /// <summary>
        /// This API is used to delete a command.
        /// Commands bound to an invoker cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteCommandRequest"/></param>
        /// <returns><see cref="DeleteCommandResponse"/></returns>
        public DeleteCommandResponse DeleteCommandSync(DeleteCommandRequest req)
        {
            return InternalRequestAsync<DeleteCommandResponse>(req, "DeleteCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an invoker.
        /// </summary>
        /// <param name="req"><see cref="DeleteInvokerRequest"/></param>
        /// <returns><see cref="DeleteInvokerResponse"/></returns>
        public Task<DeleteInvokerResponse> DeleteInvoker(DeleteInvokerRequest req)
        {
            return InternalRequestAsync<DeleteInvokerResponse>(req, "DeleteInvoker");
        }

        /// <summary>
        /// This API is used to delete an invoker.
        /// </summary>
        /// <param name="req"><see cref="DeleteInvokerRequest"/></param>
        /// <returns><see cref="DeleteInvokerResponse"/></returns>
        public DeleteInvokerResponse DeleteInvokerSync(DeleteInvokerRequest req)
        {
            return InternalRequestAsync<DeleteInvokerResponse>(req, "DeleteInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the status of the TAT agent.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutomationAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeAutomationAgentStatusResponse"/></returns>
        public Task<DescribeAutomationAgentStatusResponse> DescribeAutomationAgentStatus(DescribeAutomationAgentStatusRequest req)
        {
            return InternalRequestAsync<DescribeAutomationAgentStatusResponse>(req, "DescribeAutomationAgentStatus");
        }

        /// <summary>
        /// This API is used to query the status of the TAT agent.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutomationAgentStatusRequest"/></param>
        /// <returns><see cref="DescribeAutomationAgentStatusResponse"/></returns>
        public DescribeAutomationAgentStatusResponse DescribeAutomationAgentStatusSync(DescribeAutomationAgentStatusRequest req)
        {
            return InternalRequestAsync<DescribeAutomationAgentStatusResponse>(req, "DescribeAutomationAgentStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query command details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandsRequest"/></param>
        /// <returns><see cref="DescribeCommandsResponse"/></returns>
        public Task<DescribeCommandsResponse> DescribeCommands(DescribeCommandsRequest req)
        {
            return InternalRequestAsync<DescribeCommandsResponse>(req, "DescribeCommands");
        }

        /// <summary>
        /// This API is used to query command details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCommandsRequest"/></param>
        /// <returns><see cref="DescribeCommandsResponse"/></returns>
        public DescribeCommandsResponse DescribeCommandsSync(DescribeCommandsRequest req)
        {
            return InternalRequestAsync<DescribeCommandsResponse>(req, "DescribeCommands")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query execution task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationTasksRequest"/></param>
        /// <returns><see cref="DescribeInvocationTasksResponse"/></returns>
        public Task<DescribeInvocationTasksResponse> DescribeInvocationTasks(DescribeInvocationTasksRequest req)
        {
            return InternalRequestAsync<DescribeInvocationTasksResponse>(req, "DescribeInvocationTasks");
        }

        /// <summary>
        /// This API is used to query execution task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationTasksRequest"/></param>
        /// <returns><see cref="DescribeInvocationTasksResponse"/></returns>
        public DescribeInvocationTasksResponse DescribeInvocationTasksSync(DescribeInvocationTasksRequest req)
        {
            return InternalRequestAsync<DescribeInvocationTasksResponse>(req, "DescribeInvocationTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query execution activity details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public Task<DescribeInvocationsResponse> DescribeInvocations(DescribeInvocationsRequest req)
        {
            return InternalRequestAsync<DescribeInvocationsResponse>(req, "DescribeInvocations");
        }

        /// <summary>
        /// This API is used to query execution activity details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationsRequest"/></param>
        /// <returns><see cref="DescribeInvocationsResponse"/></returns>
        public DescribeInvocationsResponse DescribeInvocationsSync(DescribeInvocationsRequest req)
        {
            return InternalRequestAsync<DescribeInvocationsResponse>(req, "DescribeInvocations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the execution history of an invoker.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokerRecordsRequest"/></param>
        /// <returns><see cref="DescribeInvokerRecordsResponse"/></returns>
        public Task<DescribeInvokerRecordsResponse> DescribeInvokerRecords(DescribeInvokerRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInvokerRecordsResponse>(req, "DescribeInvokerRecords");
        }

        /// <summary>
        /// This API is used to query the execution history of an invoker.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokerRecordsRequest"/></param>
        /// <returns><see cref="DescribeInvokerRecordsResponse"/></returns>
        public DescribeInvokerRecordsResponse DescribeInvokerRecordsSync(DescribeInvokerRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInvokerRecordsResponse>(req, "DescribeInvokerRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query invoker details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokersRequest"/></param>
        /// <returns><see cref="DescribeInvokersResponse"/></returns>
        public Task<DescribeInvokersResponse> DescribeInvokers(DescribeInvokersRequest req)
        {
            return InternalRequestAsync<DescribeInvokersResponse>(req, "DescribeInvokers");
        }

        /// <summary>
        /// This API is used to query invoker details.
        /// </summary>
        /// <param name="req"><see cref="DescribeInvokersRequest"/></param>
        /// <returns><see cref="DescribeInvokersResponse"/></returns>
        public DescribeInvokersResponse DescribeInvokersSync(DescribeInvokersRequest req)
        {
            return InternalRequestAsync<DescribeInvokersResponse>(req, "DescribeInvokers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of regions that supports TAT.
        /// If the `RegionState` is `AVAILABLE`, it means that TAT is available in the region. If no value is returned, TAT is not available in the region.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// This API is used to query the list of regions that supports TAT.
        /// If the `RegionState` is `AVAILABLE`, it means that TAT is available in the region. If no value is returned, TAT is not available in the region.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable an invoker.
        /// </summary>
        /// <param name="req"><see cref="DisableInvokerRequest"/></param>
        /// <returns><see cref="DisableInvokerResponse"/></returns>
        public Task<DisableInvokerResponse> DisableInvoker(DisableInvokerRequest req)
        {
            return InternalRequestAsync<DisableInvokerResponse>(req, "DisableInvoker");
        }

        /// <summary>
        /// This API is used to disable an invoker.
        /// </summary>
        /// <param name="req"><see cref="DisableInvokerRequest"/></param>
        /// <returns><see cref="DisableInvokerResponse"/></returns>
        public DisableInvokerResponse DisableInvokerSync(DisableInvokerRequest req)
        {
            return InternalRequestAsync<DisableInvokerResponse>(req, "DisableInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable an invoker.
        /// </summary>
        /// <param name="req"><see cref="EnableInvokerRequest"/></param>
        /// <returns><see cref="EnableInvokerResponse"/></returns>
        public Task<EnableInvokerResponse> EnableInvoker(EnableInvokerRequest req)
        {
            return InternalRequestAsync<EnableInvokerResponse>(req, "EnableInvoker");
        }

        /// <summary>
        /// This API is used to enable an invoker.
        /// </summary>
        /// <param name="req"><see cref="EnableInvokerRequest"/></param>
        /// <returns><see cref="EnableInvokerResponse"/></returns>
        public EnableInvokerResponse EnableInvokerSync(EnableInvokerRequest req)
        {
            return InternalRequestAsync<EnableInvokerResponse>(req, "EnableInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<InvokeCommandResponse> InvokeCommand(InvokeCommandRequest req)
        {
            return InternalRequestAsync<InvokeCommandResponse>(req, "InvokeCommand");
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
            return InternalRequestAsync<InvokeCommandResponse>(req, "InvokeCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a command.
        /// </summary>
        /// <param name="req"><see cref="ModifyCommandRequest"/></param>
        /// <returns><see cref="ModifyCommandResponse"/></returns>
        public Task<ModifyCommandResponse> ModifyCommand(ModifyCommandRequest req)
        {
            return InternalRequestAsync<ModifyCommandResponse>(req, "ModifyCommand");
        }

        /// <summary>
        /// This API is used to modify a command.
        /// </summary>
        /// <param name="req"><see cref="ModifyCommandRequest"/></param>
        /// <returns><see cref="ModifyCommandResponse"/></returns>
        public ModifyCommandResponse ModifyCommandSync(ModifyCommandRequest req)
        {
            return InternalRequestAsync<ModifyCommandResponse>(req, "ModifyCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an invoker.
        /// </summary>
        /// <param name="req"><see cref="ModifyInvokerRequest"/></param>
        /// <returns><see cref="ModifyInvokerResponse"/></returns>
        public Task<ModifyInvokerResponse> ModifyInvoker(ModifyInvokerRequest req)
        {
            return InternalRequestAsync<ModifyInvokerResponse>(req, "ModifyInvoker");
        }

        /// <summary>
        /// This API is used to modify an invoker.
        /// </summary>
        /// <param name="req"><see cref="ModifyInvokerRequest"/></param>
        /// <returns><see cref="ModifyInvokerResponse"/></returns>
        public ModifyInvokerResponse ModifyInvokerSync(ModifyInvokerRequest req)
        {
            return InternalRequestAsync<ModifyInvokerResponse>(req, "ModifyInvoker")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to preview the command with custom parameters. The command is not executed.
        /// </summary>
        /// <param name="req"><see cref="PreviewReplacedCommandContentRequest"/></param>
        /// <returns><see cref="PreviewReplacedCommandContentResponse"/></returns>
        public Task<PreviewReplacedCommandContentResponse> PreviewReplacedCommandContent(PreviewReplacedCommandContentRequest req)
        {
            return InternalRequestAsync<PreviewReplacedCommandContentResponse>(req, "PreviewReplacedCommandContent");
        }

        /// <summary>
        /// This API is used to preview the command with custom parameters. The command is not executed.
        /// </summary>
        /// <param name="req"><see cref="PreviewReplacedCommandContentRequest"/></param>
        /// <returns><see cref="PreviewReplacedCommandContentResponse"/></returns>
        public PreviewReplacedCommandContentResponse PreviewReplacedCommandContentSync(PreviewReplacedCommandContentRequest req)
        {
            return InternalRequestAsync<PreviewReplacedCommandContentResponse>(req, "PreviewReplacedCommandContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<RunCommandResponse> RunCommand(RunCommandRequest req)
        {
            return InternalRequestAsync<RunCommandResponse>(req, "RunCommand");
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
            return InternalRequestAsync<RunCommandResponse>(req, "RunCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
