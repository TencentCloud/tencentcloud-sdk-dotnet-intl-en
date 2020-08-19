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

namespace TencentCloud.Es.V20180416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Es.V20180416.Models;

   public class EsClient : AbstractClient{

       private const string endpoint = "es.tencentcloudapi.com";
       private const string version = "2018-04-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create an ES cluster instance with the specified specification.
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
        /// This API is used to create an ES cluster instance with the specified specification.
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
        /// This API is used to terminate a cluster instance. 
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a cluster instance. 
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
             JsonResponseModel<DeleteInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the eligible ES cluster logs in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public async Task<DescribeInstanceLogsResponse> DescribeInstanceLogs(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the eligible ES cluster logs in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceLogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceLogsResponse"/></returns>
        public DescribeInstanceLogsResponse DescribeInstanceLogsSync(DescribeInstanceLogsRequest req)
        {
             JsonResponseModel<DescribeInstanceLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the operation history of an instance by specified criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public async Task<DescribeInstanceOperationsResponse> DescribeInstanceOperations(DescribeInstanceOperationsRequest req)
        {
             JsonResponseModel<DescribeInstanceOperationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the operation history of an instance by specified criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceOperationsRequest"/></param>
        /// <returns><see cref="DescribeInstanceOperationsResponse"/></returns>
        public DescribeInstanceOperationsResponse DescribeInstanceOperationsSync(DescribeInstanceOperationsRequest req)
        {
             JsonResponseModel<DescribeInstanceOperationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceOperations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceOperationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all eligible instances in the current region under the current account.
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
        /// This API is used to query all eligible instances in the current region under the current account.
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
        /// This API is used to restart an ES cluster instance (for operations such as system update). 
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public async Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest req)
        {
             JsonResponseModel<RestartInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an ES cluster instance (for operations such as system update). 
        /// </summary>
        /// <param name="req"><see cref="RestartInstanceRequest"/></param>
        /// <returns><see cref="RestartInstanceResponse"/></returns>
        public RestartInstanceResponse RestartInstanceSync(RestartInstanceRequest req)
        {
             JsonResponseModel<RestartInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for operations such as modifying node specification, renaming an instance, modifying configuration, resetting password, and setting Kibana blocklist/allowlist. `InstanceId` is required, while `ForceRestart` is optional. Other parameters or parameter combinations and their meanings are as follows:
        /// - InstanceName: renames an instance (only for instance identification)
        /// - NodeInfoList: modifies node configuration (horizontally scaling nodes, vertically scaling nodes, adding primary nodes, adding cold nodes, etc.)
        /// - EsConfig: modifies cluster configuration
        /// - Password: changes the password of the default user "elastic"
        /// - EsAcl: modifies the ACL
        /// - CosBackUp: sets auto-backup to COS for a cluster
        /// Only one of the parameters or parameter combinations above can be passed in at a time, while passing fewer or more ones will cause the request to fail.
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public async Task<UpdateInstanceResponse> UpdateInstance(UpdateInstanceRequest req)
        {
             JsonResponseModel<UpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for operations such as modifying node specification, renaming an instance, modifying configuration, resetting password, and setting Kibana blocklist/allowlist. `InstanceId` is required, while `ForceRestart` is optional. Other parameters or parameter combinations and their meanings are as follows:
        /// - InstanceName: renames an instance (only for instance identification)
        /// - NodeInfoList: modifies node configuration (horizontally scaling nodes, vertically scaling nodes, adding primary nodes, adding cold nodes, etc.)
        /// - EsConfig: modifies cluster configuration
        /// - Password: changes the password of the default user "elastic"
        /// - EsAcl: modifies the ACL
        /// - CosBackUp: sets auto-backup to COS for a cluster
        /// Only one of the parameters or parameter combinations above can be passed in at a time, while passing fewer or more ones will cause the request to fail.
        /// </summary>
        /// <param name="req"><see cref="UpdateInstanceRequest"/></param>
        /// <returns><see cref="UpdateInstanceResponse"/></returns>
        public UpdateInstanceResponse UpdateInstanceSync(UpdateInstanceRequest req)
        {
             JsonResponseModel<UpdateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the list of plugins.
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public async Task<UpdatePluginsResponse> UpdatePlugins(UpdatePluginsRequest req)
        {
             JsonResponseModel<UpdatePluginsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdatePlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the list of plugins.
        /// </summary>
        /// <param name="req"><see cref="UpdatePluginsRequest"/></param>
        /// <returns><see cref="UpdatePluginsResponse"/></returns>
        public UpdatePluginsResponse UpdatePluginsSync(UpdatePluginsRequest req)
        {
             JsonResponseModel<UpdatePluginsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdatePlugins");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdatePluginsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade ES cluster version
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade ES cluster version
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
             JsonResponseModel<UpgradeInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade ES X-Pack.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public async Task<UpgradeLicenseResponse> UpgradeLicense(UpgradeLicenseRequest req)
        {
             JsonResponseModel<UpgradeLicenseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade ES X-Pack.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLicenseRequest"/></param>
        /// <returns><see cref="UpgradeLicenseResponse"/></returns>
        public UpgradeLicenseResponse UpgradeLicenseSync(UpgradeLicenseRequest req)
        {
             JsonResponseModel<UpgradeLicenseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeLicense");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLicenseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
