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

namespace TencentCloud.Cfs.V20190719
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfs.V20190719.Models;

   public class CfsClient : AbstractClient{

       private const string endpoint = "cfs.tencentcloudapi.com";
       private const string version = "2019-07-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create a file system.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns><see cref="CreateCfsFileSystemResponse"/></returns>
        public async Task<CreateCfsFileSystemResponse> CreateCfsFileSystem(CreateCfsFileSystemRequest req)
        {
             JsonResponseModel<CreateCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a file system.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns><see cref="CreateCfsFileSystemResponse"/></returns>
        public CreateCfsFileSystemResponse CreateCfsFileSystemSync(CreateCfsFileSystemRequest req)
        {
             JsonResponseModel<CreateCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a permission group.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsPGroupRequest"/></param>
        /// <returns><see cref="CreateCfsPGroupResponse"/></returns>
        public async Task<CreateCfsPGroupResponse> CreateCfsPGroup(CreateCfsPGroupRequest req)
        {
             JsonResponseModel<CreateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a permission group.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsPGroupRequest"/></param>
        /// <returns><see cref="CreateCfsPGroupResponse"/></returns>
        public CreateCfsPGroupResponse CreateCfsPGroupSync(CreateCfsPGroupRequest req)
        {
             JsonResponseModel<CreateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a permission group rule.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsRuleRequest"/></param>
        /// <returns><see cref="CreateCfsRuleResponse"/></returns>
        public async Task<CreateCfsRuleResponse> CreateCfsRule(CreateCfsRuleRequest req)
        {
             JsonResponseModel<CreateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a permission group rule.
        /// </summary>
        /// <param name="req"><see cref="CreateCfsRuleRequest"/></param>
        /// <returns><see cref="CreateCfsRuleResponse"/></returns>
        public CreateCfsRuleResponse CreateCfsRuleSync(CreateCfsRuleRequest req)
        {
             JsonResponseModel<CreateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a file system.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns><see cref="DeleteCfsFileSystemResponse"/></returns>
        public async Task<DeleteCfsFileSystemResponse> DeleteCfsFileSystem(DeleteCfsFileSystemRequest req)
        {
             JsonResponseModel<DeleteCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a file system.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns><see cref="DeleteCfsFileSystemResponse"/></returns>
        public DeleteCfsFileSystemResponse DeleteCfsFileSystemSync(DeleteCfsFileSystemRequest req)
        {
             JsonResponseModel<DeleteCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a permission group.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns><see cref="DeleteCfsPGroupResponse"/></returns>
        public async Task<DeleteCfsPGroupResponse> DeleteCfsPGroup(DeleteCfsPGroupRequest req)
        {
             JsonResponseModel<DeleteCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a permission group.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns><see cref="DeleteCfsPGroupResponse"/></returns>
        public DeleteCfsPGroupResponse DeleteCfsPGroupSync(DeleteCfsPGroupRequest req)
        {
             JsonResponseModel<DeleteCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a permission group rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsRuleRequest"/></param>
        /// <returns><see cref="DeleteCfsRuleResponse"/></returns>
        public async Task<DeleteCfsRuleResponse> DeleteCfsRule(DeleteCfsRuleRequest req)
        {
             JsonResponseModel<DeleteCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a permission group rule.
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsRuleRequest"/></param>
        /// <returns><see cref="DeleteCfsRuleResponse"/></returns>
        public DeleteCfsRuleResponse DeleteCfsRuleSync(DeleteCfsRuleRequest req)
        {
             JsonResponseModel<DeleteCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a mount target.
        /// </summary>
        /// <param name="req"><see cref="DeleteMountTargetRequest"/></param>
        /// <returns><see cref="DeleteMountTargetResponse"/></returns>
        public async Task<DeleteMountTargetResponse> DeleteMountTarget(DeleteMountTargetRequest req)
        {
             JsonResponseModel<DeleteMountTargetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMountTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMountTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a mount target.
        /// </summary>
        /// <param name="req"><see cref="DeleteMountTargetRequest"/></param>
        /// <returns><see cref="DeleteMountTargetResponse"/></returns>
        public DeleteMountTargetResponse DeleteMountTargetSync(DeleteMountTargetRequest req)
        {
             JsonResponseModel<DeleteMountTargetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMountTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMountTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the availability of a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeAvailableZoneInfoResponse"/></returns>
        public async Task<DescribeAvailableZoneInfoResponse> DescribeAvailableZoneInfo(DescribeAvailableZoneInfoRequest req)
        {
             JsonResponseModel<DescribeAvailableZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the availability of a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeAvailableZoneInfoResponse"/></returns>
        public DescribeAvailableZoneInfoResponse DescribeAvailableZoneInfoSync(DescribeAvailableZoneInfoRequest req)
        {
             JsonResponseModel<DescribeAvailableZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query clients on which this file system is mounted. To do so, the client needs to have the CFS monitoring plugin installed.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemClientsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemClientsResponse"/></returns>
        public async Task<DescribeCfsFileSystemClientsResponse> DescribeCfsFileSystemClients(DescribeCfsFileSystemClientsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemClientsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsFileSystemClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query clients on which this file system is mounted. To do so, the client needs to have the CFS monitoring plugin installed.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemClientsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemClientsResponse"/></returns>
        public DescribeCfsFileSystemClientsResponse DescribeCfsFileSystemClientsSync(DescribeCfsFileSystemClientsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemClientsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsFileSystemClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query file systems.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemsResponse"/></returns>
        public async Task<DescribeCfsFileSystemsResponse> DescribeCfsFileSystems(DescribeCfsFileSystemsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsFileSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query file systems.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemsResponse"/></returns>
        public DescribeCfsFileSystemsResponse DescribeCfsFileSystemsSync(DescribeCfsFileSystemsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsFileSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of permission groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns><see cref="DescribeCfsPGroupsResponse"/></returns>
        public async Task<DescribeCfsPGroupsResponse> DescribeCfsPGroups(DescribeCfsPGroupsRequest req)
        {
             JsonResponseModel<DescribeCfsPGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsPGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsPGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of permission groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns><see cref="DescribeCfsPGroupsResponse"/></returns>
        public DescribeCfsPGroupsResponse DescribeCfsPGroupsSync(DescribeCfsPGroupsRequest req)
        {
             JsonResponseModel<DescribeCfsPGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsPGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsPGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of permission group rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsRulesRequest"/></param>
        /// <returns><see cref="DescribeCfsRulesResponse"/></returns>
        public async Task<DescribeCfsRulesResponse> DescribeCfsRules(DescribeCfsRulesRequest req)
        {
             JsonResponseModel<DescribeCfsRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of permission group rules.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsRulesRequest"/></param>
        /// <returns><see cref="DescribeCfsRulesResponse"/></returns>
        public DescribeCfsRulesResponse DescribeCfsRulesSync(DescribeCfsRulesRequest req)
        {
             JsonResponseModel<DescribeCfsRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of the CFS service.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeCfsServiceStatusResponse"/></returns>
        public async Task<DescribeCfsServiceStatusResponse> DescribeCfsServiceStatus(DescribeCfsServiceStatusRequest req)
        {
             JsonResponseModel<DescribeCfsServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the status of the CFS service.
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeCfsServiceStatusResponse"/></returns>
        public DescribeCfsServiceStatusResponse DescribeCfsServiceStatusSync(DescribeCfsServiceStatusRequest req)
        {
             JsonResponseModel<DescribeCfsServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the mount targets of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeMountTargetsRequest"/></param>
        /// <returns><see cref="DescribeMountTargetsResponse"/></returns>
        public async Task<DescribeMountTargetsResponse> DescribeMountTargets(DescribeMountTargetsRequest req)
        {
             JsonResponseModel<DescribeMountTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMountTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the mount targets of a file system.
        /// </summary>
        /// <param name="req"><see cref="DescribeMountTargetsRequest"/></param>
        /// <returns><see cref="DescribeMountTargetsResponse"/></returns>
        public DescribeMountTargetsResponse DescribeMountTargetsSync(DescribeMountTargetsRequest req)
        {
             JsonResponseModel<DescribeMountTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMountTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to activate the CFS service.
        /// </summary>
        /// <param name="req"><see cref="SignUpCfsServiceRequest"/></param>
        /// <returns><see cref="SignUpCfsServiceResponse"/></returns>
        public async Task<SignUpCfsServiceResponse> SignUpCfsService(SignUpCfsServiceRequest req)
        {
             JsonResponseModel<SignUpCfsServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SignUpCfsService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignUpCfsServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to activate the CFS service.
        /// </summary>
        /// <param name="req"><see cref="SignUpCfsServiceRequest"/></param>
        /// <returns><see cref="SignUpCfsServiceResponse"/></returns>
        public SignUpCfsServiceResponse SignUpCfsServiceSync(SignUpCfsServiceRequest req)
        {
             JsonResponseModel<SignUpCfsServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SignUpCfsService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignUpCfsServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a file system name.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemNameResponse"/></returns>
        public async Task<UpdateCfsFileSystemNameResponse> UpdateCfsFileSystemName(UpdateCfsFileSystemNameRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a file system name.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemNameResponse"/></returns>
        public UpdateCfsFileSystemNameResponse UpdateCfsFileSystemNameSync(UpdateCfsFileSystemNameRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsFileSystemName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the permission group used by a file system.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemPGroupResponse"/></returns>
        public async Task<UpdateCfsFileSystemPGroupResponse> UpdateCfsFileSystemPGroup(UpdateCfsFileSystemPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the permission group used by a file system.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemPGroupResponse"/></returns>
        public UpdateCfsFileSystemPGroupResponse UpdateCfsFileSystemPGroupSync(UpdateCfsFileSystemPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsFileSystemPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the capacity limit of a file system.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemSizeLimitResponse"/></returns>
        public async Task<UpdateCfsFileSystemSizeLimitResponse> UpdateCfsFileSystemSizeLimit(UpdateCfsFileSystemSizeLimitRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemSizeLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the capacity limit of a file system.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemSizeLimitResponse"/></returns>
        public UpdateCfsFileSystemSizeLimitResponse UpdateCfsFileSystemSizeLimitSync(UpdateCfsFileSystemSizeLimitRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsFileSystemSizeLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of a permission group.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsPGroupResponse"/></returns>
        public async Task<UpdateCfsPGroupResponse> UpdateCfsPGroup(UpdateCfsPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of a permission group.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsPGroupResponse"/></returns>
        public UpdateCfsPGroupResponse UpdateCfsPGroupSync(UpdateCfsPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a permission rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsRuleRequest"/></param>
        /// <returns><see cref="UpdateCfsRuleResponse"/></returns>
        public async Task<UpdateCfsRuleResponse> UpdateCfsRule(UpdateCfsRuleRequest req)
        {
             JsonResponseModel<UpdateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update a permission rule.
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsRuleRequest"/></param>
        /// <returns><see cref="UpdateCfsRuleResponse"/></returns>
        public UpdateCfsRuleResponse UpdateCfsRuleSync(UpdateCfsRuleRequest req)
        {
             JsonResponseModel<UpdateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
