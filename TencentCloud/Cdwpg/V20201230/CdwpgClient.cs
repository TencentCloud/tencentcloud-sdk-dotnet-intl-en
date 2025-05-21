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

namespace TencentCloud.Cdwpg.V20201230
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdwpg.V20201230.Models;

   public class CdwpgClient : AbstractClient{

       private const string endpoint = "cdwpg.intl.tencentcloudapi.com";
       private const string version = "2020-12-30";
       private const string sdkVersion = "SDK_NET_3.0.1135";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdwpgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdwpgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create  instance
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceByApiRequest"/></param>
        /// <returns><see cref="CreateInstanceByApiResponse"/></returns>
        public Task<CreateInstanceByApiResponse> CreateInstanceByApi(CreateInstanceByApiRequest req)
        {
            return InternalRequestAsync<CreateInstanceByApiResponse>(req, "CreateInstanceByApi");
        }

        /// <summary>
        /// This API is used to create  instance
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceByApiRequest"/></param>
        /// <returns><see cref="CreateInstanceByApiResponse"/></returns>
        public CreateInstanceByApiResponse CreateInstanceByApiSync(CreateInstanceByApiRequest req)
        {
            return InternalRequestAsync<CreateInstanceByApiResponse>(req, "CreateInstanceByApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the account list corresponding to the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// This API is used to obtain the account list corresponding to the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe DBConfig History
        /// </summary>
        /// <param name="req"><see cref="DescribeDBConfigHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBConfigHistoryResponse"/></returns>
        public Task<DescribeDBConfigHistoryResponse> DescribeDBConfigHistory(DescribeDBConfigHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDBConfigHistoryResponse>(req, "DescribeDBConfigHistory");
        }

        /// <summary>
        /// Describe DBConfig History
        /// </summary>
        /// <param name="req"><see cref="DescribeDBConfigHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBConfigHistoryResponse"/></returns>
        public DescribeDBConfigHistoryResponse DescribeDBConfigHistorySync(DescribeDBConfigHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDBConfigHistoryResponse>(req, "DescribeDBConfigHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to describe instance configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParamsRequest"/></param>
        /// <returns><see cref="DescribeDBParamsResponse"/></returns>
        public Task<DescribeDBParamsResponse> DescribeDBParams(DescribeDBParamsRequest req)
        {
            return InternalRequestAsync<DescribeDBParamsResponse>(req, "DescribeDBParams");
        }

        /// <summary>
        /// This API is used to describe instance configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParamsRequest"/></param>
        /// <returns><see cref="DescribeDBParamsResponse"/></returns>
        public DescribeDBParamsResponse DescribeDBParamsSync(DescribeDBParamsRequest req)
        {
            return InternalRequestAsync<DescribeDBParamsResponse>(req, "DescribeDBParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query error logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorLogRequest"/></param>
        /// <returns><see cref="DescribeErrorLogResponse"/></returns>
        public Task<DescribeErrorLogResponse> DescribeErrorLog(DescribeErrorLogRequest req)
        {
            return InternalRequestAsync<DescribeErrorLogResponse>(req, "DescribeErrorLog");
        }

        /// <summary>
        /// This API is used to query error logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorLogRequest"/></param>
        /// <returns><see cref="DescribeErrorLogResponse"/></returns>
        public DescribeErrorLogResponse DescribeErrorLogSync(DescribeErrorLogRequest req)
        {
            return InternalRequestAsync<DescribeErrorLogResponse>(req, "DescribeErrorLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance information by an instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// This API is used to query the instance information by an instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceInfoResponse"/></returns>
        public Task<DescribeInstanceInfoResponse> DescribeInstanceInfo(DescribeInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceInfoResponse>(req, "DescribeInstanceInfo");
        }

        /// <summary>
        /// This API is used to get instance information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceInfoResponse"/></returns>
        public DescribeInstanceInfoResponse DescribeInstanceInfoSync(DescribeInstanceInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceInfoResponse>(req, "DescribeInstanceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to list nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public Task<DescribeInstanceNodesResponse> DescribeInstanceNodes(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes");
        }

        /// <summary>
        /// This API is used to list nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public DescribeInstanceNodesResponse DescribeInstanceNodesSync(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get operations of the instance .
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations");
        }

        /// <summary>
        /// This API is used to get operations of the instance .
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public DescribeInstanceOperationsResponse DescribeInstanceOperationsSync(DescribeInstanceOperationsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceOperationsResponse>(req, "DescribeInstanceOperations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to display instance status, process progress, etc., in the instance details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public Task<DescribeInstanceStateResponse> DescribeInstanceState(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState");
        }

        /// <summary>
        /// This API is used to display instance status, process progress, etc., in the instance details page.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public DescribeInstanceStateResponse DescribeInstanceStateSync(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of  instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to get a list of  instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a list of instance
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleInstancesRequest"/></param>
        /// <returns><see cref="DescribeSimpleInstancesResponse"/></returns>
        public Task<DescribeSimpleInstancesResponse> DescribeSimpleInstances(DescribeSimpleInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSimpleInstancesResponse>(req, "DescribeSimpleInstances");
        }

        /// <summary>
        /// This API is used to get a list of instance
        /// </summary>
        /// <param name="req"><see cref="DescribeSimpleInstancesRequest"/></param>
        /// <returns><see cref="DescribeSimpleInstancesResponse"/></returns>
        public DescribeSimpleInstancesResponse DescribeSimpleInstancesSync(DescribeSimpleInstancesRequest req)
        {
            return InternalRequestAsync<DescribeSimpleInstancesResponse>(req, "DescribeSimpleInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query slow SQL logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public Task<DescribeSlowLogResponse> DescribeSlowLog(DescribeSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogResponse>(req, "DescribeSlowLog");
        }

        /// <summary>
        /// This API is used to query slow SQL logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public DescribeSlowLogResponse DescribeSlowLogSync(DescribeSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogResponse>(req, "DescribeSlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain instance upgrade records.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpgradeListRequest"/></param>
        /// <returns><see cref="DescribeUpgradeListResponse"/></returns>
        public Task<DescribeUpgradeListResponse> DescribeUpgradeList(DescribeUpgradeListRequest req)
        {
            return InternalRequestAsync<DescribeUpgradeListResponse>(req, "DescribeUpgradeList");
        }

        /// <summary>
        /// This API is used to obtain instance upgrade records.
        /// </summary>
        /// <param name="req"><see cref="DescribeUpgradeListRequest"/></param>
        /// <returns><see cref="DescribeUpgradeListResponse"/></returns>
        public DescribeUpgradeListResponse DescribeUpgradeListSync(DescribeUpgradeListRequest req)
        {
            return InternalRequestAsync<DescribeUpgradeListResponse>(req, "DescribeUpgradeList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Describe User HbaConfig.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserHbaConfigRequest"/></param>
        /// <returns><see cref="DescribeUserHbaConfigResponse"/></returns>
        public Task<DescribeUserHbaConfigResponse> DescribeUserHbaConfig(DescribeUserHbaConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserHbaConfigResponse>(req, "DescribeUserHbaConfig");
        }

        /// <summary>
        /// Describe User HbaConfig.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserHbaConfigRequest"/></param>
        /// <returns><see cref="DescribeUserHbaConfigResponse"/></returns>
        public DescribeUserHbaConfigResponse DescribeUserHbaConfigSync(DescribeUserHbaConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserHbaConfigResponse>(req, "DescribeUserHbaConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to destroy instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceByApiRequest"/></param>
        /// <returns><see cref="DestroyInstanceByApiResponse"/></returns>
        public Task<DestroyInstanceByApiResponse> DestroyInstanceByApi(DestroyInstanceByApiRequest req)
        {
            return InternalRequestAsync<DestroyInstanceByApiResponse>(req, "DestroyInstanceByApi");
        }

        /// <summary>
        /// This API is used to destroy instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceByApiRequest"/></param>
        /// <returns><see cref="DestroyInstanceByApiResponse"/></returns>
        public DestroyInstanceByApiResponse DestroyInstanceByApiSync(DestroyInstanceByApiRequest req)
        {
            return InternalRequestAsync<DestroyInstanceByApiResponse>(req, "DestroyInstanceByApi")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance configurations
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public Task<ModifyDBParametersResponse> ModifyDBParameters(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters");
        }

        /// <summary>
        /// This API is used to modify instance configurations
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public ModifyDBParametersResponse ModifyDBParametersSync(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance information. Only the name of an instance can be modified currently.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// This API is used to modify instance information. Only the name of an instance can be modified currently.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify user Hba configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserHbaRequest"/></param>
        /// <returns><see cref="ModifyUserHbaResponse"/></returns>
        public Task<ModifyUserHbaResponse> ModifyUserHba(ModifyUserHbaRequest req)
        {
            return InternalRequestAsync<ModifyUserHbaResponse>(req, "ModifyUserHba");
        }

        /// <summary>
        /// This API is used to modify user Hba configurations.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserHbaRequest"/></param>
        /// <returns><see cref="ModifyUserHbaResponse"/></returns>
        public ModifyUserHbaResponse ModifyUserHbaSync(ModifyUserHbaRequest req)
        {
            return InternalRequestAsync<ModifyUserHbaResponse>(req, "ModifyUserHba")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change account password.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// This API is used to change account password.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used by users to proactively restart instances in the console.
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance");
        }

        /// <summary>
        /// This API is used by users to proactively restart instances in the console.
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public RestartInstanceResponse RestartInstanceSync(RestartInstanceRequest req)
        {
            return InternalRequestAsync<RestartInstanceResponse>(req, "RestartInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale out instance.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance");
        }

        /// <summary>
        /// This API is used to scale out instance.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale up instance in the console.
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public Task<ScaleUpInstanceResponse> ScaleUpInstance(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance");
        }

        /// <summary>
        /// This API is used to scale up instance in the console.
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public ScaleUpInstanceResponse ScaleUpInstanceSync(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade Instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// This API is used to upgrade Instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
