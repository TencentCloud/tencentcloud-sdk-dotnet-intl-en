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

namespace TencentCloud.Yunjing.V20180228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Yunjing.V20180228.Models;

   public class YunjingClient : AbstractClient{

       private const string endpoint = "yunjing.tencentcloudapi.com";
       private const string version = "2018-02-28";
       private const string sdkVersion = "SDK_NET_3.0.941";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public YunjingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public YunjingClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add a allowlist rule.
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListResponse"/></returns>
        public Task<AddLoginWhiteListResponse> AddLoginWhiteList(AddLoginWhiteListRequest req)
        {
            return InternalRequestAsync<AddLoginWhiteListResponse>(req, "AddLoginWhiteList");
        }

        /// <summary>
        /// This API is used to add a allowlist rule.
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListResponse"/></returns>
        public AddLoginWhiteListResponse AddLoginWhiteListSync(AddLoginWhiteListRequest req)
        {
            return InternalRequestAsync<AddLoginWhiteListResponse>(req, "AddLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a tag to a server.
        /// </summary>
        /// <param name="req"><see cref="AddMachineTagRequest"/></param>
        /// <returns><see cref="AddMachineTagResponse"/></returns>
        public Task<AddMachineTagResponse> AddMachineTag(AddMachineTagRequest req)
        {
            return InternalRequestAsync<AddMachineTagResponse>(req, "AddMachineTag");
        }

        /// <summary>
        /// This API is used to add a tag to a server.
        /// </summary>
        /// <param name="req"><see cref="AddMachineTagRequest"/></param>
        /// <returns><see cref="AddMachineTagResponse"/></returns>
        public AddMachineTagResponse AddMachineTagSync(AddMachineTagRequest req)
        {
            return InternalRequestAsync<AddMachineTagResponse>(req, "AddMachineTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to deactivate CWP Pro.
        /// </summary>
        /// <param name="req"><see cref="CloseProVersionRequest"/></param>
        /// <returns><see cref="CloseProVersionResponse"/></returns>
        public Task<CloseProVersionResponse> CloseProVersion(CloseProVersionRequest req)
        {
            return InternalRequestAsync<CloseProVersionResponse>(req, "CloseProVersion");
        }

        /// <summary>
        /// This API is used to deactivate CWP Pro.
        /// </summary>
        /// <param name="req"><see cref="CloseProVersionRequest"/></param>
        /// <returns><see cref="CloseProVersionResponse"/></returns>
        public CloseProVersionResponse CloseProVersionSync(CloseProVersionRequest req)
        {
            return InternalRequestAsync<CloseProVersionResponse>(req, "CloseProVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a real-time port acquisition task.
        /// </summary>
        /// <param name="req"><see cref="CreateOpenPortTaskRequest"/></param>
        /// <returns><see cref="CreateOpenPortTaskResponse"/></returns>
        public Task<CreateOpenPortTaskResponse> CreateOpenPortTask(CreateOpenPortTaskRequest req)
        {
            return InternalRequestAsync<CreateOpenPortTaskResponse>(req, "CreateOpenPortTask");
        }

        /// <summary>
        /// This API is used to create a real-time port acquisition task.
        /// </summary>
        /// <param name="req"><see cref="CreateOpenPortTaskRequest"/></param>
        /// <returns><see cref="CreateOpenPortTaskResponse"/></returns>
        public CreateOpenPortTaskResponse CreateOpenPortTaskSync(CreateOpenPortTaskRequest req)
        {
            return InternalRequestAsync<CreateOpenPortTaskResponse>(req, "CreateOpenPortTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a real-time process pulling task.
        /// </summary>
        /// <param name="req"><see cref="CreateProcessTaskRequest"/></param>
        /// <returns><see cref="CreateProcessTaskResponse"/></returns>
        public Task<CreateProcessTaskResponse> CreateProcessTask(CreateProcessTaskRequest req)
        {
            return InternalRequestAsync<CreateProcessTaskResponse>(req, "CreateProcessTask");
        }

        /// <summary>
        /// This API is used to create a real-time process pulling task.
        /// </summary>
        /// <param name="req"><see cref="CreateProcessTaskRequest"/></param>
        /// <returns><see cref="CreateProcessTaskResponse"/></returns>
        public CreateProcessTaskResponse CreateProcessTaskSync(CreateProcessTaskRequest req)
        {
            return InternalRequestAsync<CreateProcessTaskResponse>(req, "CreateProcessTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add one or more usual login locations.
        /// </summary>
        /// <param name="req"><see cref="CreateUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="CreateUsualLoginPlacesResponse"/></returns>
        public Task<CreateUsualLoginPlacesResponse> CreateUsualLoginPlaces(CreateUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<CreateUsualLoginPlacesResponse>(req, "CreateUsualLoginPlaces");
        }

        /// <summary>
        /// This API is used to add one or more usual login locations.
        /// </summary>
        /// <param name="req"><see cref="CreateUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="CreateUsualLoginPlacesResponse"/></returns>
        public CreateUsualLoginPlacesResponse CreateUsualLoginPlacesSync(CreateUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<CreateUsualLoginPlacesResponse>(req, "CreateUsualLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete brute force attack records.
        /// </summary>
        /// <param name="req"><see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns><see cref="DeleteBruteAttacksResponse"/></returns>
        public Task<DeleteBruteAttacksResponse> DeleteBruteAttacks(DeleteBruteAttacksRequest req)
        {
            return InternalRequestAsync<DeleteBruteAttacksResponse>(req, "DeleteBruteAttacks");
        }

        /// <summary>
        /// This API is used to delete brute force attack records.
        /// </summary>
        /// <param name="req"><see cref="DeleteBruteAttacksRequest"/></param>
        /// <returns><see cref="DeleteBruteAttacksResponse"/></returns>
        public DeleteBruteAttacksResponse DeleteBruteAttacksSync(DeleteBruteAttacksRequest req)
        {
            return InternalRequestAsync<DeleteBruteAttacksResponse>(req, "DeleteBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a allowlist rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public Task<DeleteLoginWhiteListResponse> DeleteLoginWhiteList(DeleteLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteLoginWhiteListResponse>(req, "DeleteLoginWhiteList");
        }

        /// <summary>
        /// This API is used to delete a allowlist rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public DeleteLoginWhiteListResponse DeleteLoginWhiteListSync(DeleteLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteLoginWhiteListResponse>(req, "DeleteLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to uninstall the CWP agent.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public Task<DeleteMachineResponse> DeleteMachine(DeleteMachineRequest req)
        {
            return InternalRequestAsync<DeleteMachineResponse>(req, "DeleteMachine");
        }

        /// <summary>
        /// This API is used to uninstall the CWP agent.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public DeleteMachineResponse DeleteMachineSync(DeleteMachineRequest req)
        {
            return InternalRequestAsync<DeleteMachineResponse>(req, "DeleteMachine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a tag from a server.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineTagRequest"/></param>
        /// <returns><see cref="DeleteMachineTagResponse"/></returns>
        public Task<DeleteMachineTagResponse> DeleteMachineTag(DeleteMachineTagRequest req)
        {
            return InternalRequestAsync<DeleteMachineTagResponse>(req, "DeleteMachineTag");
        }

        /// <summary>
        /// This API is used to remove a tag from a server.
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineTagRequest"/></param>
        /// <returns><see cref="DeleteMachineTagResponse"/></returns>
        public DeleteMachineTagResponse DeleteMachineTagSync(DeleteMachineTagRequest req)
        {
            return InternalRequestAsync<DeleteMachineTagResponse>(req, "DeleteMachineTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete malicious request records.
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestsResponse"/></returns>
        public Task<DeleteMaliciousRequestsResponse> DeleteMaliciousRequests(DeleteMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DeleteMaliciousRequestsResponse>(req, "DeleteMaliciousRequests");
        }

        /// <summary>
        /// This API is used to delete malicious request records.
        /// </summary>
        /// <param name="req"><see cref="DeleteMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DeleteMaliciousRequestsResponse"/></returns>
        public DeleteMaliciousRequestsResponse DeleteMaliciousRequestsSync(DeleteMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DeleteMaliciousRequestsResponse>(req, "DeleteMaliciousRequests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete trojan records.
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwaresRequest"/></param>
        /// <returns><see cref="DeleteMalwaresResponse"/></returns>
        public Task<DeleteMalwaresResponse> DeleteMalwares(DeleteMalwaresRequest req)
        {
            return InternalRequestAsync<DeleteMalwaresResponse>(req, "DeleteMalwares");
        }

        /// <summary>
        /// This API is used to delete trojan records.
        /// </summary>
        /// <param name="req"><see cref="DeleteMalwaresRequest"/></param>
        /// <returns><see cref="DeleteMalwaresResponse"/></returns>
        public DeleteMalwaresResponse DeleteMalwaresSync(DeleteMalwaresRequest req)
        {
            return InternalRequestAsync<DeleteMalwaresResponse>(req, "DeleteMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete unusual login location records.
        /// </summary>
        /// <param name="req"><see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteNonlocalLoginPlacesResponse"/></returns>
        public Task<DeleteNonlocalLoginPlacesResponse> DeleteNonlocalLoginPlaces(DeleteNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteNonlocalLoginPlacesResponse>(req, "DeleteNonlocalLoginPlaces");
        }

        /// <summary>
        /// This API is used to delete unusual login location records.
        /// </summary>
        /// <param name="req"><see cref="DeleteNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteNonlocalLoginPlacesResponse"/></returns>
        public DeleteNonlocalLoginPlacesResponse DeleteNonlocalLoginPlacesSync(DeleteNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteNonlocalLoginPlacesResponse>(req, "DeleteNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or more usual login locations.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteUsualLoginPlacesResponse"/></returns>
        public Task<DeleteUsualLoginPlacesResponse> DeleteUsualLoginPlaces(DeleteUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteUsualLoginPlacesResponse>(req, "DeleteUsualLoginPlaces");
        }

        /// <summary>
        /// This API is used to delete one or more usual login locations.
        /// </summary>
        /// <param name="req"><see cref="DeleteUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DeleteUsualLoginPlacesResponse"/></returns>
        public DeleteUsualLoginPlacesResponse DeleteUsualLoginPlacesSync(DeleteUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DeleteUsualLoginPlacesResponse>(req, "DeleteUsualLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the account statistics list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAccountStatisticsResponse"/></returns>
        public Task<DescribeAccountStatisticsResponse> DescribeAccountStatistics(DescribeAccountStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAccountStatisticsResponse>(req, "DescribeAccountStatistics");
        }

        /// <summary>
        /// This API is used to get the account statistics list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAccountStatisticsResponse"/></returns>
        public DescribeAccountStatisticsResponse DescribeAccountStatisticsSync(DescribeAccountStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeAccountStatisticsResponse>(req, "DescribeAccountStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the account list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// This API is used to get the account list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of vulnerabilities on a single server.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVulsRequest"/></param>
        /// <returns><see cref="DescribeAgentVulsResponse"/></returns>
        public Task<DescribeAgentVulsResponse> DescribeAgentVuls(DescribeAgentVulsRequest req)
        {
            return InternalRequestAsync<DescribeAgentVulsResponse>(req, "DescribeAgentVuls");
        }

        /// <summary>
        /// This API is used to get the list of vulnerabilities on a single server.
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentVulsRequest"/></param>
        /// <returns><see cref="DescribeAgentVulsResponse"/></returns>
        public DescribeAgentVulsResponse DescribeAgentVulsSync(DescribeAgentVulsRequest req)
        {
            return InternalRequestAsync<DescribeAgentVulsResponse>(req, "DescribeAgentVuls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the alarm settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmAttributeRequest"/></param>
        /// <returns><see cref="DescribeAlarmAttributeResponse"/></returns>
        public Task<DescribeAlarmAttributeResponse> DescribeAlarmAttribute(DescribeAlarmAttributeRequest req)
        {
            return InternalRequestAsync<DescribeAlarmAttributeResponse>(req, "DescribeAlarmAttribute");
        }

        /// <summary>
        /// This API is used to get the alarm settings.
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmAttributeRequest"/></param>
        /// <returns><see cref="DescribeAlarmAttributeResponse"/></returns>
        public DescribeAlarmAttributeResponse DescribeAlarmAttributeSync(DescribeAlarmAttributeRequest req)
        {
            return InternalRequestAsync<DescribeAlarmAttributeResponse>(req, "DescribeAlarmAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the brute force attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeBruteAttacksResponse"/></returns>
        public Task<DescribeBruteAttacksResponse> DescribeBruteAttacks(DescribeBruteAttacksRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttacksResponse>(req, "DescribeBruteAttacks");
        }

        /// <summary>
        /// This API is used to get the brute force attack event list.
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeBruteAttacksResponse"/></returns>
        public DescribeBruteAttacksResponse DescribeBruteAttacksSync(DescribeBruteAttacksRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttacksResponse>(req, "DescribeBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the component information.
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentInfoRequest"/></param>
        /// <returns><see cref="DescribeComponentInfoResponse"/></returns>
        public Task<DescribeComponentInfoResponse> DescribeComponentInfo(DescribeComponentInfoRequest req)
        {
            return InternalRequestAsync<DescribeComponentInfoResponse>(req, "DescribeComponentInfo");
        }

        /// <summary>
        /// This API is used to get the component information.
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentInfoRequest"/></param>
        /// <returns><see cref="DescribeComponentInfoResponse"/></returns>
        public DescribeComponentInfoResponse DescribeComponentInfoSync(DescribeComponentInfoRequest req)
        {
            return InternalRequestAsync<DescribeComponentInfoResponse>(req, "DescribeComponentInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the component statistics list.
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComponentStatisticsResponse"/></returns>
        public Task<DescribeComponentStatisticsResponse> DescribeComponentStatistics(DescribeComponentStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComponentStatisticsResponse>(req, "DescribeComponentStatistics");
        }

        /// <summary>
        /// This API is used to get the component statistics list.
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComponentStatisticsResponse"/></returns>
        public DescribeComponentStatisticsResponse DescribeComponentStatisticsSync(DescribeComponentStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComponentStatisticsResponse>(req, "DescribeComponentStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the component list.
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentsRequest"/></param>
        /// <returns><see cref="DescribeComponentsResponse"/></returns>
        public Task<DescribeComponentsResponse> DescribeComponents(DescribeComponentsRequest req)
        {
            return InternalRequestAsync<DescribeComponentsResponse>(req, "DescribeComponents");
        }

        /// <summary>
        /// This API is used to get the component list.
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentsRequest"/></param>
        /// <returns><see cref="DescribeComponentsResponse"/></returns>
        public DescribeComponentsResponse DescribeComponentsSync(DescribeComponentsRequest req)
        {
            return InternalRequestAsync<DescribeComponentsResponse>(req, "DescribeComponents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the account change history list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns><see cref="DescribeHistoryAccountsResponse"/></returns>
        public Task<DescribeHistoryAccountsResponse> DescribeHistoryAccounts(DescribeHistoryAccountsRequest req)
        {
            return InternalRequestAsync<DescribeHistoryAccountsResponse>(req, "DescribeHistoryAccounts");
        }

        /// <summary>
        /// This API is used to get the account change history list.
        /// </summary>
        /// <param name="req"><see cref="DescribeHistoryAccountsRequest"/></param>
        /// <returns><see cref="DescribeHistoryAccountsResponse"/></returns>
        public DescribeHistoryAccountsResponse DescribeHistoryAccountsSync(DescribeHistoryAccountsRequest req)
        {
            return InternalRequestAsync<DescribeHistoryAccountsResponse>(req, "DescribeHistoryAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of servers affected by a vulnerability.
        /// </summary>
        /// <param name="req"><see cref="DescribeImpactedHostsRequest"/></param>
        /// <returns><see cref="DescribeImpactedHostsResponse"/></returns>
        public Task<DescribeImpactedHostsResponse> DescribeImpactedHosts(DescribeImpactedHostsRequest req)
        {
            return InternalRequestAsync<DescribeImpactedHostsResponse>(req, "DescribeImpactedHosts");
        }

        /// <summary>
        /// This API is used to get the list of servers affected by a vulnerability.
        /// </summary>
        /// <param name="req"><see cref="DescribeImpactedHostsRequest"/></param>
        /// <returns><see cref="DescribeImpactedHostsResponse"/></returns>
        public DescribeImpactedHostsResponse DescribeImpactedHostsSync(DescribeImpactedHostsRequest req)
        {
            return InternalRequestAsync<DescribeImpactedHostsResponse>(req, "DescribeImpactedHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of login allowlist entries.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteListResponse"/></returns>
        public Task<DescribeLoginWhiteListResponse> DescribeLoginWhiteList(DescribeLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteListResponse>(req, "DescribeLoginWhiteList");
        }

        /// <summary>
        /// This API is used to get the list of login allowlist entries.
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteListResponse"/></returns>
        public DescribeLoginWhiteListResponse DescribeLoginWhiteListSync(DescribeLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteListResponse>(req, "DescribeLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get server details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeMachineInfoResponse"/></returns>
        public Task<DescribeMachineInfoResponse> DescribeMachineInfo(DescribeMachineInfoRequest req)
        {
            return InternalRequestAsync<DescribeMachineInfoResponse>(req, "DescribeMachineInfo");
        }

        /// <summary>
        /// This API is used to get server details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineInfoRequest"/></param>
        /// <returns><see cref="DescribeMachineInfoResponse"/></returns>
        public DescribeMachineInfoResponse DescribeMachineInfoSync(DescribeMachineInfoRequest req)
        {
            return InternalRequestAsync<DescribeMachineInfoResponse>(req, "DescribeMachineInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of servers in a specified region.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines");
        }

        /// <summary>
        /// This API is used to get the list of servers in a specified region.
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public DescribeMachinesResponse DescribeMachinesSync(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get malicious request data.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestsResponse"/></returns>
        public Task<DescribeMaliciousRequestsResponse> DescribeMaliciousRequests(DescribeMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DescribeMaliciousRequestsResponse>(req, "DescribeMaliciousRequests");
        }

        /// <summary>
        /// This API is used to get malicious request data.
        /// </summary>
        /// <param name="req"><see cref="DescribeMaliciousRequestsRequest"/></param>
        /// <returns><see cref="DescribeMaliciousRequestsResponse"/></returns>
        public DescribeMaliciousRequestsResponse DescribeMaliciousRequestsSync(DescribeMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<DescribeMaliciousRequestsResponse>(req, "DescribeMaliciousRequests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of trojan events.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwaresRequest"/></param>
        /// <returns><see cref="DescribeMalwaresResponse"/></returns>
        public Task<DescribeMalwaresResponse> DescribeMalwares(DescribeMalwaresRequest req)
        {
            return InternalRequestAsync<DescribeMalwaresResponse>(req, "DescribeMalwares");
        }

        /// <summary>
        /// This API is used to get the list of trojan events.
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwaresRequest"/></param>
        /// <returns><see cref="DescribeMalwaresResponse"/></returns>
        public DescribeMalwaresResponse DescribeMalwaresSync(DescribeMalwaresRequest req)
        {
            return InternalRequestAsync<DescribeMalwaresResponse>(req, "DescribeMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get unusual login events.
        /// </summary>
        /// <param name="req"><see cref="DescribeNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeNonlocalLoginPlacesResponse"/></returns>
        public Task<DescribeNonlocalLoginPlacesResponse> DescribeNonlocalLoginPlaces(DescribeNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeNonlocalLoginPlacesResponse>(req, "DescribeNonlocalLoginPlaces");
        }

        /// <summary>
        /// This API is used to get unusual login events.
        /// </summary>
        /// <param name="req"><see cref="DescribeNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeNonlocalLoginPlacesResponse"/></returns>
        public DescribeNonlocalLoginPlacesResponse DescribeNonlocalLoginPlacesSync(DescribeNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeNonlocalLoginPlacesResponse>(req, "DescribeNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the statistics on port usage
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortStatisticsResponse"/></returns>
        public Task<DescribeOpenPortStatisticsResponse> DescribeOpenPortStatistics(DescribeOpenPortStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortStatisticsResponse>(req, "DescribeOpenPortStatistics");
        }

        /// <summary>
        /// This API is used to get the statistics on port usage
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortStatisticsResponse"/></returns>
        public DescribeOpenPortStatisticsResponse DescribeOpenPortStatisticsSync(DescribeOpenPortStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortStatisticsResponse>(req, "DescribeOpenPortStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the status of a real-time port pulling task.
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeOpenPortTaskStatusResponse"/></returns>
        public Task<DescribeOpenPortTaskStatusResponse> DescribeOpenPortTaskStatus(DescribeOpenPortTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortTaskStatusResponse>(req, "DescribeOpenPortTaskStatus");
        }

        /// <summary>
        /// This API is used to get the status of a real-time port pulling task.
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeOpenPortTaskStatusResponse"/></returns>
        public DescribeOpenPortTaskStatusResponse DescribeOpenPortTaskStatusSync(DescribeOpenPortTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortTaskStatusResponse>(req, "DescribeOpenPortTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the port list.
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortsResponse"/></returns>
        public Task<DescribeOpenPortsResponse> DescribeOpenPorts(DescribeOpenPortsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortsResponse>(req, "DescribeOpenPorts");
        }

        /// <summary>
        /// This API is used to get the port list.
        /// </summary>
        /// <param name="req"><see cref="DescribeOpenPortsRequest"/></param>
        /// <returns><see cref="DescribeOpenPortsResponse"/></returns>
        public DescribeOpenPortsResponse DescribeOpenPortsSync(DescribeOpenPortsRequest req)
        {
            return InternalRequestAsync<DescribeOpenPortsResponse>(req, "DescribeOpenPorts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the overview statistics of CWP under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOverviewStatisticsResponse"/></returns>
        public Task<DescribeOverviewStatisticsResponse> DescribeOverviewStatistics(DescribeOverviewStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOverviewStatisticsResponse>(req, "DescribeOverviewStatistics");
        }

        /// <summary>
        /// This API is used to get the overview statistics of CWP under the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeOverviewStatisticsRequest"/></param>
        /// <returns><see cref="DescribeOverviewStatisticsResponse"/></returns>
        public DescribeOverviewStatisticsResponse DescribeOverviewStatisticsSync(DescribeOverviewStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeOverviewStatisticsResponse>(req, "DescribeOverviewStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the CWP Pro information.
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public Task<DescribeProVersionInfoResponse> DescribeProVersionInfo(DescribeProVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeProVersionInfoResponse>(req, "DescribeProVersionInfo");
        }

        /// <summary>
        /// This API is used to get the CWP Pro information.
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public DescribeProVersionInfoResponse DescribeProVersionInfoSync(DescribeProVersionInfoRequest req)
        {
            return InternalRequestAsync<DescribeProVersionInfoResponse>(req, "DescribeProVersionInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the process statistics list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProcessStatisticsResponse"/></returns>
        public Task<DescribeProcessStatisticsResponse> DescribeProcessStatistics(DescribeProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProcessStatisticsResponse>(req, "DescribeProcessStatistics");
        }

        /// <summary>
        /// This API is used to get the process statistics list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProcessStatisticsResponse"/></returns>
        public DescribeProcessStatisticsResponse DescribeProcessStatisticsSync(DescribeProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProcessStatisticsResponse>(req, "DescribeProcessStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the status of a real-time process pulling task.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeProcessTaskStatusResponse"/></returns>
        public Task<DescribeProcessTaskStatusResponse> DescribeProcessTaskStatus(DescribeProcessTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeProcessTaskStatusResponse>(req, "DescribeProcessTaskStatus");
        }

        /// <summary>
        /// This API is used to get the status of a real-time process pulling task.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeProcessTaskStatusResponse"/></returns>
        public DescribeProcessTaskStatusResponse DescribeProcessTaskStatusSync(DescribeProcessTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeProcessTaskStatusResponse>(req, "DescribeProcessTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the process list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessesRequest"/></param>
        /// <returns><see cref="DescribeProcessesResponse"/></returns>
        public Task<DescribeProcessesResponse> DescribeProcesses(DescribeProcessesRequest req)
        {
            return InternalRequestAsync<DescribeProcessesResponse>(req, "DescribeProcesses");
        }

        /// <summary>
        /// This API is used to get the process list.
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessesRequest"/></param>
        /// <returns><see cref="DescribeProcessesResponse"/></returns>
        public DescribeProcessesResponse DescribeProcessesSync(DescribeProcessesRequest req)
        {
            return InternalRequestAsync<DescribeProcessesResponse>(req, "DescribeProcesses")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the security event message data.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns><see cref="DescribeSecurityDynamicsResponse"/></returns>
        public Task<DescribeSecurityDynamicsResponse> DescribeSecurityDynamics(DescribeSecurityDynamicsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityDynamicsResponse>(req, "DescribeSecurityDynamics");
        }

        /// <summary>
        /// This API is used to get the security event message data.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityDynamicsRequest"/></param>
        /// <returns><see cref="DescribeSecurityDynamicsResponse"/></returns>
        public DescribeSecurityDynamicsResponse DescribeSecurityDynamicsSync(DescribeSecurityDynamicsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityDynamicsResponse>(req, "DescribeSecurityDynamics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the security event statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTrendsResponse"/></returns>
        public Task<DescribeSecurityTrendsResponse> DescribeSecurityTrends(DescribeSecurityTrendsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTrendsResponse>(req, "DescribeSecurityTrends");
        }

        /// <summary>
        /// This API is used to get the security event statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityTrendsRequest"/></param>
        /// <returns><see cref="DescribeSecurityTrendsResponse"/></returns>
        public DescribeSecurityTrendsResponse DescribeSecurityTrendsSync(DescribeSecurityTrendsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityTrendsResponse>(req, "DescribeSecurityTrends")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of servers associated with a specified tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagMachinesRequest"/></param>
        /// <returns><see cref="DescribeTagMachinesResponse"/></returns>
        public Task<DescribeTagMachinesResponse> DescribeTagMachines(DescribeTagMachinesRequest req)
        {
            return InternalRequestAsync<DescribeTagMachinesResponse>(req, "DescribeTagMachines");
        }

        /// <summary>
        /// This API is used to get the information of servers associated with a specified tag.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagMachinesRequest"/></param>
        /// <returns><see cref="DescribeTagMachinesResponse"/></returns>
        public DescribeTagMachinesResponse DescribeTagMachinesSync(DescribeTagMachinesRequest req)
        {
            return InternalRequestAsync<DescribeTagMachinesResponse>(req, "DescribeTagMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get all server tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags");
        }

        /// <summary>
        /// This API is used to get all server tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query usual login locations.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeUsualLoginPlacesResponse"/></returns>
        public Task<DescribeUsualLoginPlacesResponse> DescribeUsualLoginPlaces(DescribeUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeUsualLoginPlacesResponse>(req, "DescribeUsualLoginPlaces");
        }

        /// <summary>
        /// This API is used to query usual login locations.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsualLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeUsualLoginPlacesResponse"/></returns>
        public DescribeUsualLoginPlacesResponse DescribeUsualLoginPlacesSync(DescribeUsualLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeUsualLoginPlacesResponse>(req, "DescribeUsualLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get vulnerability details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoRequest"/></param>
        /// <returns><see cref="DescribeVulInfoResponse"/></returns>
        public Task<DescribeVulInfoResponse> DescribeVulInfo(DescribeVulInfoRequest req)
        {
            return InternalRequestAsync<DescribeVulInfoResponse>(req, "DescribeVulInfo");
        }

        /// <summary>
        /// This API is used to get vulnerability details.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulInfoRequest"/></param>
        /// <returns><see cref="DescribeVulInfoResponse"/></returns>
        public DescribeVulInfoResponse DescribeVulInfoSync(DescribeVulInfoRequest req)
        {
            return InternalRequestAsync<DescribeVulInfoResponse>(req, "DescribeVulInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the vulnerability detection result.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanResultRequest"/></param>
        /// <returns><see cref="DescribeVulScanResultResponse"/></returns>
        public Task<DescribeVulScanResultResponse> DescribeVulScanResult(DescribeVulScanResultRequest req)
        {
            return InternalRequestAsync<DescribeVulScanResultResponse>(req, "DescribeVulScanResult");
        }

        /// <summary>
        /// This API is used to get the vulnerability detection result.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanResultRequest"/></param>
        /// <returns><see cref="DescribeVulScanResultResponse"/></returns>
        public DescribeVulScanResultResponse DescribeVulScanResultSync(DescribeVulScanResultRequest req)
        {
            return InternalRequestAsync<DescribeVulScanResultResponse>(req, "DescribeVulScanResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public Task<DescribeVulsResponse> DescribeVuls(DescribeVulsRequest req)
        {
            return InternalRequestAsync<DescribeVulsResponse>(req, "DescribeVuls");
        }

        /// <summary>
        /// This API is used to get the vulnerability list.
        /// </summary>
        /// <param name="req"><see cref="DescribeVulsRequest"/></param>
        /// <returns><see cref="DescribeVulsResponse"/></returns>
        public DescribeVulsResponse DescribeVulsSync(DescribeVulsRequest req)
        {
            return InternalRequestAsync<DescribeVulsResponse>(req, "DescribeVuls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the brute force attack data in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportBruteAttacksResponse"/></returns>
        public Task<DescribeWeeklyReportBruteAttacksResponse> DescribeWeeklyReportBruteAttacks(DescribeWeeklyReportBruteAttacksRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportBruteAttacksResponse>(req, "DescribeWeeklyReportBruteAttacks");
        }

        /// <summary>
        /// This API is used to get the brute force attack data in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportBruteAttacksRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportBruteAttacksResponse"/></returns>
        public DescribeWeeklyReportBruteAttacksResponse DescribeWeeklyReportBruteAttacksSync(DescribeWeeklyReportBruteAttacksRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportBruteAttacksResponse>(req, "DescribeWeeklyReportBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportInfoRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportInfoResponse"/></returns>
        public Task<DescribeWeeklyReportInfoResponse> DescribeWeeklyReportInfo(DescribeWeeklyReportInfoRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportInfoResponse>(req, "DescribeWeeklyReportInfo");
        }

        /// <summary>
        /// This API is used to get the details in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportInfoRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportInfoResponse"/></returns>
        public DescribeWeeklyReportInfoResponse DescribeWeeklyReportInfoSync(DescribeWeeklyReportInfoRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportInfoResponse>(req, "DescribeWeeklyReportInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the trojan data in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportMalwaresRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportMalwaresResponse"/></returns>
        public Task<DescribeWeeklyReportMalwaresResponse> DescribeWeeklyReportMalwares(DescribeWeeklyReportMalwaresRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportMalwaresResponse>(req, "DescribeWeeklyReportMalwares");
        }

        /// <summary>
        /// This API is used to get the trojan data in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportMalwaresRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportMalwaresResponse"/></returns>
        public DescribeWeeklyReportMalwaresResponse DescribeWeeklyReportMalwaresSync(DescribeWeeklyReportMalwaresRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportMalwaresResponse>(req, "DescribeWeeklyReportMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the unusual login location data in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportNonlocalLoginPlacesResponse"/></returns>
        public Task<DescribeWeeklyReportNonlocalLoginPlacesResponse> DescribeWeeklyReportNonlocalLoginPlaces(DescribeWeeklyReportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportNonlocalLoginPlacesResponse>(req, "DescribeWeeklyReportNonlocalLoginPlaces");
        }

        /// <summary>
        /// This API is used to get the unusual login location data in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportNonlocalLoginPlacesResponse"/></returns>
        public DescribeWeeklyReportNonlocalLoginPlacesResponse DescribeWeeklyReportNonlocalLoginPlacesSync(DescribeWeeklyReportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportNonlocalLoginPlacesResponse>(req, "DescribeWeeklyReportNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the vulnerability data in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportVulsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportVulsResponse"/></returns>
        public Task<DescribeWeeklyReportVulsResponse> DescribeWeeklyReportVuls(DescribeWeeklyReportVulsRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportVulsResponse>(req, "DescribeWeeklyReportVuls");
        }

        /// <summary>
        /// This API is used to get the vulnerability data in the weekly CWP Pro report.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportVulsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportVulsResponse"/></returns>
        public DescribeWeeklyReportVulsResponse DescribeWeeklyReportVulsSync(DescribeWeeklyReportVulsRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportVulsResponse>(req, "DescribeWeeklyReportVuls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the weekly report list.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportsResponse"/></returns>
        public Task<DescribeWeeklyReportsResponse> DescribeWeeklyReports(DescribeWeeklyReportsRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportsResponse>(req, "DescribeWeeklyReports");
        }

        /// <summary>
        /// This API is used to get the weekly report list.
        /// </summary>
        /// <param name="req"><see cref="DescribeWeeklyReportsRequest"/></param>
        /// <returns><see cref="DescribeWeeklyReportsResponse"/></returns>
        public DescribeWeeklyReportsResponse DescribeWeeklyReportsSync(DescribeWeeklyReportsRequest req)
        {
            return InternalRequestAsync<DescribeWeeklyReportsResponse>(req, "DescribeWeeklyReports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add or edit tags.
        /// </summary>
        /// <param name="req"><see cref="EditTagsRequest"/></param>
        /// <returns><see cref="EditTagsResponse"/></returns>
        public Task<EditTagsResponse> EditTags(EditTagsRequest req)
        {
            return InternalRequestAsync<EditTagsResponse>(req, "EditTags");
        }

        /// <summary>
        /// This API is used to add or edit tags.
        /// </summary>
        /// <param name="req"><see cref="EditTagsRequest"/></param>
        /// <returns><see cref="EditTagsResponse"/></returns>
        public EditTagsResponse EditTagsSync(EditTagsRequest req)
        {
            return InternalRequestAsync<EditTagsResponse>(req, "EditTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export brute force attack records into a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportBruteAttacksRequest"/></param>
        /// <returns><see cref="ExportBruteAttacksResponse"/></returns>
        public Task<ExportBruteAttacksResponse> ExportBruteAttacks(ExportBruteAttacksRequest req)
        {
            return InternalRequestAsync<ExportBruteAttacksResponse>(req, "ExportBruteAttacks");
        }

        /// <summary>
        /// This API is used to export brute force attack records into a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportBruteAttacksRequest"/></param>
        /// <returns><see cref="ExportBruteAttacksResponse"/></returns>
        public ExportBruteAttacksResponse ExportBruteAttacksSync(ExportBruteAttacksRequest req)
        {
            return InternalRequestAsync<ExportBruteAttacksResponse>(req, "ExportBruteAttacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export the malicious request file into a CSV file for download.
        /// </summary>
        /// <param name="req"><see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns><see cref="ExportMaliciousRequestsResponse"/></returns>
        public Task<ExportMaliciousRequestsResponse> ExportMaliciousRequests(ExportMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<ExportMaliciousRequestsResponse>(req, "ExportMaliciousRequests");
        }

        /// <summary>
        /// This API is used to export the malicious request file into a CSV file for download.
        /// </summary>
        /// <param name="req"><see cref="ExportMaliciousRequestsRequest"/></param>
        /// <returns><see cref="ExportMaliciousRequestsResponse"/></returns>
        public ExportMaliciousRequestsResponse ExportMaliciousRequestsSync(ExportMaliciousRequestsRequest req)
        {
            return InternalRequestAsync<ExportMaliciousRequestsResponse>(req, "ExportMaliciousRequests")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export trojan records into a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportMalwaresRequest"/></param>
        /// <returns><see cref="ExportMalwaresResponse"/></returns>
        public Task<ExportMalwaresResponse> ExportMalwares(ExportMalwaresRequest req)
        {
            return InternalRequestAsync<ExportMalwaresResponse>(req, "ExportMalwares");
        }

        /// <summary>
        /// This API is used to export trojan records into a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportMalwaresRequest"/></param>
        /// <returns><see cref="ExportMalwaresResponse"/></returns>
        public ExportMalwaresResponse ExportMalwaresSync(ExportMalwaresRequest req)
        {
            return InternalRequestAsync<ExportMalwaresResponse>(req, "ExportMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to export unusual login location events into a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="ExportNonlocalLoginPlacesResponse"/></returns>
        public Task<ExportNonlocalLoginPlacesResponse> ExportNonlocalLoginPlaces(ExportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<ExportNonlocalLoginPlacesResponse>(req, "ExportNonlocalLoginPlaces");
        }

        /// <summary>
        /// This API is used to export unusual login location events into a CSV file.
        /// </summary>
        /// <param name="req"><see cref="ExportNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="ExportNonlocalLoginPlacesResponse"/></returns>
        public ExportNonlocalLoginPlacesResponse ExportNonlocalLoginPlacesSync(ExportNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<ExportNonlocalLoginPlacesResponse>(req, "ExportNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to ignore one or more vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns><see cref="IgnoreImpactedHostsResponse"/></returns>
        public Task<IgnoreImpactedHostsResponse> IgnoreImpactedHosts(IgnoreImpactedHostsRequest req)
        {
            return InternalRequestAsync<IgnoreImpactedHostsResponse>(req, "IgnoreImpactedHosts");
        }

        /// <summary>
        /// This API is used to ignore one or more vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="IgnoreImpactedHostsRequest"/></param>
        /// <returns><see cref="IgnoreImpactedHostsResponse"/></returns>
        public IgnoreImpactedHostsResponse IgnoreImpactedHostsSync(IgnoreImpactedHostsRequest req)
        {
            return InternalRequestAsync<IgnoreImpactedHostsResponse>(req, "IgnoreImpactedHosts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the current location as the usual login location.
        /// </summary>
        /// <param name="req"><see cref="MisAlarmNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="MisAlarmNonlocalLoginPlacesResponse"/></returns>
        public Task<MisAlarmNonlocalLoginPlacesResponse> MisAlarmNonlocalLoginPlaces(MisAlarmNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<MisAlarmNonlocalLoginPlacesResponse>(req, "MisAlarmNonlocalLoginPlaces");
        }

        /// <summary>
        /// This API is used to set the current location as the usual login location.
        /// </summary>
        /// <param name="req"><see cref="MisAlarmNonlocalLoginPlacesRequest"/></param>
        /// <returns><see cref="MisAlarmNonlocalLoginPlacesResponse"/></returns>
        public MisAlarmNonlocalLoginPlacesResponse MisAlarmNonlocalLoginPlacesSync(MisAlarmNonlocalLoginPlacesRequest req)
        {
            return InternalRequestAsync<MisAlarmNonlocalLoginPlacesResponse>(req, "MisAlarmNonlocalLoginPlaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify alarm settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmAttributeRequest"/></param>
        /// <returns><see cref="ModifyAlarmAttributeResponse"/></returns>
        public Task<ModifyAlarmAttributeResponse> ModifyAlarmAttribute(ModifyAlarmAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmAttributeResponse>(req, "ModifyAlarmAttribute");
        }

        /// <summary>
        /// This API is used to modify alarm settings.
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmAttributeRequest"/></param>
        /// <returns><see cref="ModifyAlarmAttributeResponse"/></returns>
        public ModifyAlarmAttributeResponse ModifyAlarmAttributeSync(ModifyAlarmAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmAttributeResponse>(req, "ModifyAlarmAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set whether to automatically activate CWP Pro for newly added servers.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoOpenProVersionConfigResponse"/></returns>
        public Task<ModifyAutoOpenProVersionConfigResponse> ModifyAutoOpenProVersionConfig(ModifyAutoOpenProVersionConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoOpenProVersionConfigResponse>(req, "ModifyAutoOpenProVersionConfig");
        }

        /// <summary>
        /// This API is used to set whether to automatically activate CWP Pro for newly added servers.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoOpenProVersionConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoOpenProVersionConfigResponse"/></returns>
        public ModifyAutoOpenProVersionConfigResponse ModifyAutoOpenProVersionConfigSync(ModifyAutoOpenProVersionConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoOpenProVersionConfigResponse>(req, "ModifyAutoOpenProVersionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit a allowlist rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteListRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteListResponse"/></returns>
        public Task<ModifyLoginWhiteListResponse> ModifyLoginWhiteList(ModifyLoginWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteListResponse>(req, "ModifyLoginWhiteList");
        }

        /// <summary>
        /// This API is used to edit a allowlist rule.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteListRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteListResponse"/></returns>
        public ModifyLoginWhiteListResponse ModifyLoginWhiteListSync(ModifyLoginWhiteListRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteListResponse>(req, "ModifyLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the renewal flag of CWP Pro.
        /// </summary>
        /// <param name="req"><see cref="ModifyProVersionRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyProVersionRenewFlagResponse"/></returns>
        public Task<ModifyProVersionRenewFlagResponse> ModifyProVersionRenewFlag(ModifyProVersionRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyProVersionRenewFlagResponse>(req, "ModifyProVersionRenewFlag");
        }

        /// <summary>
        /// This API is used to modify the renewal flag of CWP Pro.
        /// </summary>
        /// <param name="req"><see cref="ModifyProVersionRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyProVersionRenewFlagResponse"/></returns>
        public ModifyProVersionRenewFlagResponse ModifyProVersionRenewFlagSync(ModifyProVersionRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyProVersionRenewFlagResponse>(req, "ModifyProVersionRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to activate CWP Pro.
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionRequest"/></param>
        /// <returns><see cref="OpenProVersionResponse"/></returns>
        public Task<OpenProVersionResponse> OpenProVersion(OpenProVersionRequest req)
        {
            return InternalRequestAsync<OpenProVersionResponse>(req, "OpenProVersion");
        }

        /// <summary>
        /// This API is used to activate CWP Pro.
        /// </summary>
        /// <param name="req"><see cref="OpenProVersionRequest"/></param>
        /// <returns><see cref="OpenProVersionResponse"/></returns>
        public OpenProVersionResponse OpenProVersionSync(OpenProVersionRequest req)
        {
            return InternalRequestAsync<OpenProVersionResponse>(req, "OpenProVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recover isolated trojan files in a batch.
        /// </summary>
        /// <param name="req"><see cref="RecoverMalwaresRequest"/></param>
        /// <returns><see cref="RecoverMalwaresResponse"/></returns>
        public Task<RecoverMalwaresResponse> RecoverMalwares(RecoverMalwaresRequest req)
        {
            return InternalRequestAsync<RecoverMalwaresResponse>(req, "RecoverMalwares");
        }

        /// <summary>
        /// This API is used to recover isolated trojan files in a batch.
        /// </summary>
        /// <param name="req"><see cref="RecoverMalwaresRequest"/></param>
        /// <returns><see cref="RecoverMalwaresResponse"/></returns>
        public RecoverMalwaresResponse RecoverMalwaresSync(RecoverMalwaresRequest req)
        {
            return InternalRequestAsync<RecoverMalwaresResponse>(req, "RecoverMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to re-scan for vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="RescanImpactedHostRequest"/></param>
        /// <returns><see cref="RescanImpactedHostResponse"/></returns>
        public Task<RescanImpactedHostResponse> RescanImpactedHost(RescanImpactedHostRequest req)
        {
            return InternalRequestAsync<RescanImpactedHostResponse>(req, "RescanImpactedHost");
        }

        /// <summary>
        /// This API is used to re-scan for vulnerabilities.
        /// </summary>
        /// <param name="req"><see cref="RescanImpactedHostRequest"/></param>
        /// <returns><see cref="RescanImpactedHostResponse"/></returns>
        public RescanImpactedHostResponse RescanImpactedHostSync(RescanImpactedHostRequest req)
        {
            return InternalRequestAsync<RescanImpactedHostResponse>(req, "RescanImpactedHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate trojans.
        /// </summary>
        /// <param name="req"><see cref="SeparateMalwaresRequest"/></param>
        /// <returns><see cref="SeparateMalwaresResponse"/></returns>
        public Task<SeparateMalwaresResponse> SeparateMalwares(SeparateMalwaresRequest req)
        {
            return InternalRequestAsync<SeparateMalwaresResponse>(req, "SeparateMalwares");
        }

        /// <summary>
        /// This API is used to isolate trojans.
        /// </summary>
        /// <param name="req"><see cref="SeparateMalwaresRequest"/></param>
        /// <returns><see cref="SeparateMalwaresResponse"/></returns>
        public SeparateMalwaresResponse SeparateMalwaresSync(SeparateMalwaresRequest req)
        {
            return InternalRequestAsync<SeparateMalwaresResponse>(req, "SeparateMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trust a malicious request.
        /// </summary>
        /// <param name="req"><see cref="TrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="TrustMaliciousRequestResponse"/></returns>
        public Task<TrustMaliciousRequestResponse> TrustMaliciousRequest(TrustMaliciousRequestRequest req)
        {
            return InternalRequestAsync<TrustMaliciousRequestResponse>(req, "TrustMaliciousRequest");
        }

        /// <summary>
        /// This API is used to trust a malicious request.
        /// </summary>
        /// <param name="req"><see cref="TrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="TrustMaliciousRequestResponse"/></returns>
        public TrustMaliciousRequestResponse TrustMaliciousRequestSync(TrustMaliciousRequestRequest req)
        {
            return InternalRequestAsync<TrustMaliciousRequestResponse>(req, "TrustMaliciousRequest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to trust an identified trojan file.
        /// </summary>
        /// <param name="req"><see cref="TrustMalwaresRequest"/></param>
        /// <returns><see cref="TrustMalwaresResponse"/></returns>
        public Task<TrustMalwaresResponse> TrustMalwares(TrustMalwaresRequest req)
        {
            return InternalRequestAsync<TrustMalwaresResponse>(req, "TrustMalwares");
        }

        /// <summary>
        /// This API is used to trust an identified trojan file.
        /// </summary>
        /// <param name="req"><see cref="TrustMalwaresRequest"/></param>
        /// <returns><see cref="TrustMalwaresResponse"/></returns>
        public TrustMalwaresResponse TrustMalwaresSync(TrustMalwaresRequest req)
        {
            return InternalRequestAsync<TrustMalwaresResponse>(req, "TrustMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to untrust a malicious request.
        /// </summary>
        /// <param name="req"><see cref="UntrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="UntrustMaliciousRequestResponse"/></returns>
        public Task<UntrustMaliciousRequestResponse> UntrustMaliciousRequest(UntrustMaliciousRequestRequest req)
        {
            return InternalRequestAsync<UntrustMaliciousRequestResponse>(req, "UntrustMaliciousRequest");
        }

        /// <summary>
        /// This API is used to untrust a malicious request.
        /// </summary>
        /// <param name="req"><see cref="UntrustMaliciousRequestRequest"/></param>
        /// <returns><see cref="UntrustMaliciousRequestResponse"/></returns>
        public UntrustMaliciousRequestResponse UntrustMaliciousRequestSync(UntrustMaliciousRequestRequest req)
        {
            return InternalRequestAsync<UntrustMaliciousRequestResponse>(req, "UntrustMaliciousRequest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to untrust a trojan file.
        /// </summary>
        /// <param name="req"><see cref="UntrustMalwaresRequest"/></param>
        /// <returns><see cref="UntrustMalwaresResponse"/></returns>
        public Task<UntrustMalwaresResponse> UntrustMalwares(UntrustMalwaresRequest req)
        {
            return InternalRequestAsync<UntrustMalwaresResponse>(req, "UntrustMalwares");
        }

        /// <summary>
        /// This API is used to untrust a trojan file.
        /// </summary>
        /// <param name="req"><see cref="UntrustMalwaresRequest"/></param>
        /// <returns><see cref="UntrustMalwaresResponse"/></returns>
        public UntrustMalwaresResponse UntrustMalwaresSync(UntrustMalwaresRequest req)
        {
            return InternalRequestAsync<UntrustMalwaresResponse>(req, "UntrustMalwares")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
