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

namespace TencentCloud.Redis.V20180412
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Redis.V20180412.Models;

   public class RedisClient : AbstractClient{

       private const string endpoint = "redis.tencentcloudapi.com";
       private const string version = "2018-04-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RedisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RedisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to deactivate an instance in the recycle bin immediately.
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public async Task<CleanUpInstanceResponse> CleanUpInstance(CleanUpInstanceRequest req)
        {
             JsonResponseModel<CleanUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CleanUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deactivate an instance in the recycle bin immediately.
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public CleanUpInstanceResponse CleanUpInstanceSync(CleanUpInstanceRequest req)
        {
             JsonResponseModel<CleanUpInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CleanUpInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CleanUpInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear the data of a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public async Task<ClearInstanceResponse> ClearInstance(ClearInstanceRequest req)
        {
             JsonResponseModel<ClearInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear the data of a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public ClearInstanceResponse ClearInstanceSync(ClearInstanceRequest req)
        {
             JsonResponseModel<ClearInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public async Task<CreateInstanceAccountResponse> CreateInstanceAccount(CreateInstanceAccountRequest req)
        {
             JsonResponseModel<CreateInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceAccountRequest"/></param>
        /// <returns><see cref="CreateInstanceAccountResponse"/></returns>
        public CreateInstanceAccountResponse CreateInstanceAccountSync(CreateInstanceAccountRequest req)
        {
             JsonResponseModel<CreateInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public async Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public async Task<DeleteInstanceAccountResponse> DeleteInstanceAccount(DeleteInstanceAccountRequest req)
        {
             JsonResponseModel<DeleteInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceAccountRequest"/></param>
        /// <returns><see cref="DeleteInstanceAccountResponse"/></returns>
        public DeleteInstanceAccountResponse DeleteInstanceAccountSync(DeleteInstanceAccountRequest req)
        {
             JsonResponseModel<DeleteInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the backup configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public async Task<DescribeAutoBackupConfigResponse> DescribeAutoBackupConfig(DescribeAutoBackupConfigRequest req)
        {
             JsonResponseModel<DescribeAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the backup configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public DescribeAutoBackupConfigResponse DescribeAutoBackupConfigSync(DescribeAutoBackupConfigRequest req)
        {
             JsonResponseModel<DescribeAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download address of a backup RDB (it is during beta test and can be used only after you apply for the eligibility).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public async Task<DescribeBackupUrlResponse> DescribeBackupUrl(DescribeBackupUrlRequest req)
        {
             JsonResponseModel<DescribeBackupUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download address of a backup RDB (it is during beta test and can be used only after you apply for the eligibility).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupUrlRequest"/></param>
        /// <returns><see cref="DescribeBackupUrlResponse"/></returns>
        public DescribeBackupUrlResponse DescribeBackupUrlSync(DescribeBackupUrlRequest req)
        {
             JsonResponseModel<DescribeBackupUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view instance sub-account information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public async Task<DescribeInstanceAccountResponse> DescribeInstanceAccount(DescribeInstanceAccountRequest req)
        {
             JsonResponseModel<DescribeInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view instance sub-account information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceAccountRequest"/></param>
        /// <returns><see cref="DescribeInstanceAccountResponse"/></returns>
        public DescribeInstanceAccountResponse DescribeInstanceAccountSync(DescribeInstanceAccountRequest req)
        {
             JsonResponseModel<DescribeInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Redis instance backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public async Task<DescribeInstanceBackupsResponse> DescribeInstanceBackups(DescribeInstanceBackupsRequest req)
        {
             JsonResponseModel<DescribeInstanceBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Redis instance backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public DescribeInstanceBackupsResponse DescribeInstanceBackupsSync(DescribeInstanceBackupsRequest req)
        {
             JsonResponseModel<DescribeInstanceBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public async Task<DescribeInstanceDealDetailResponse> DescribeInstanceDealDetail(DescribeInstanceDealDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDealDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceDealDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDealDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public DescribeInstanceDealDetailResponse DescribeInstanceDealDetailSync(DescribeInstanceDealDetailRequest req)
        {
             JsonResponseModel<DescribeInstanceDealDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceDealDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceDealDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeyResponse> DescribeInstanceMonitorBigKey(DescribeInstanceMonitorBigKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyResponse"/></returns>
        public DescribeInstanceMonitorBigKeyResponse DescribeInstanceMonitorBigKeySync(DescribeInstanceMonitorBigKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key size distribution of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeySizeDistResponse> DescribeInstanceMonitorBigKeySizeDist(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKeySizeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key size distribution of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeySizeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeySizeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeySizeDistResponse DescribeInstanceMonitorBigKeySizeDistSync(DescribeInstanceMonitorBigKeySizeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKeySizeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeySizeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key type distribution of an instance
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorBigKeyTypeDistResponse> DescribeInstanceMonitorBigKeyTypeDist(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorBigKeyTypeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the big key type distribution of an instance
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorBigKeyTypeDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorBigKeyTypeDistResponse"/></returns>
        public DescribeInstanceMonitorBigKeyTypeDistResponse DescribeInstanceMonitorBigKeyTypeDistSync(DescribeInstanceMonitorBigKeyTypeDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorBigKeyTypeDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorBigKeyTypeDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the hot key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public async Task<DescribeInstanceMonitorHotKeyResponse> DescribeInstanceMonitorHotKey(DescribeInstanceMonitorHotKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorHotKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorHotKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorHotKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the hot key of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorHotKeyRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorHotKeyResponse"/></returns>
        public DescribeInstanceMonitorHotKeyResponse DescribeInstanceMonitorHotKeySync(DescribeInstanceMonitorHotKeyRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorHotKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorHotKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorHotKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the access source information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public async Task<DescribeInstanceMonitorSIPResponse> DescribeInstanceMonitorSIP(DescribeInstanceMonitorSIPRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorSIPResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorSIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorSIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the access source information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorSIPRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorSIPResponse"/></returns>
        public DescribeInstanceMonitorSIPResponse DescribeInstanceMonitorSIPSync(DescribeInstanceMonitorSIPRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorSIPResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorSIP");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorSIPResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the distribution of instance access duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public async Task<DescribeInstanceMonitorTookDistResponse> DescribeInstanceMonitorTookDist(DescribeInstanceMonitorTookDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTookDistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTookDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTookDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the distribution of instance access duration.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTookDistRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTookDistResponse"/></returns>
        public DescribeInstanceMonitorTookDistResponse DescribeInstanceMonitorTookDistSync(DescribeInstanceMonitorTookDistRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTookDistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTookDist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTookDistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an instance access command.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public async Task<DescribeInstanceMonitorTopNCmdResponse> DescribeInstanceMonitorTopNCmd(DescribeInstanceMonitorTopNCmdRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTopNCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an instance access command.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdResponse DescribeInstanceMonitorTopNCmdSync(DescribeInstanceMonitorTopNCmdRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTopNCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instance CPU time.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public async Task<DescribeInstanceMonitorTopNCmdTookResponse> DescribeInstanceMonitorTopNCmdTook(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceMonitorTopNCmdTook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instance CPU time.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceMonitorTopNCmdTookRequest"/></param>
        /// <returns><see cref="DescribeInstanceMonitorTopNCmdTookResponse"/></returns>
        public DescribeInstanceMonitorTopNCmdTookResponse DescribeInstanceMonitorTopNCmdTookSync(DescribeInstanceMonitorTopNCmdTookRequest req)
        {
             JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceMonitorTopNCmdTook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceMonitorTopNCmdTookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of parameter modifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public async Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceParamRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of parameter modifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceParamRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of instance parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public async Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of instance parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
             JsonResponseModel<DescribeInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public async Task<DescribeInstanceSecurityGroupResponse> DescribeInstanceSecurityGroup(DescribeInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeInstanceSecurityGroupResponse"/></returns>
        public DescribeInstanceSecurityGroupResponse DescribeInstanceSecurityGroupSync(DescribeInstanceSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeInstanceSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of cluster edition instance shards.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public async Task<DescribeInstanceShardsResponse> DescribeInstanceShards(DescribeInstanceShardsRequest req)
        {
             JsonResponseModel<DescribeInstanceShardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of cluster edition instance shards.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public DescribeInstanceShardsResponse DescribeInstanceShardsSync(DescribeInstanceShardsRequest req)
        {
             JsonResponseModel<DescribeInstanceShardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceShards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceShardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of Redis instances.
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
        /// This API is used to query the list of Redis instances.
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
        /// This API is used to query the purchasable capacity specifications of Redis instances in the specified AZ and instance type. If you are not in the whitelist for the AZ or instance type, you cannot view the details of the capacity specifications. To apply for the eligibility, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public async Task<DescribeProductInfoResponse> DescribeProductInfo(DescribeProductInfoRequest req)
        {
             JsonResponseModel<DescribeProductInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable capacity specifications of Redis instances in the specified AZ and instance type. If you are not in the whitelist for the AZ or instance type, you cannot view the details of the capacity specifications. To apply for the eligibility, please submit a ticket.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public DescribeProductInfoResponse DescribeProductInfoSync(DescribeProductInfoRequest req)
        {
             JsonResponseModel<DescribeProductInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group information of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupResponse> DescribeProjectSecurityGroup(DescribeProjectSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group information of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupResponse"/></returns>
        public DescribeProjectSecurityGroupResponse DescribeProjectSecurityGroupSync(DescribeProjectSecurityGroupRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the slow log.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public async Task<DescribeSlowLogResponse> DescribeSlowLog(DescribeSlowLogRequest req)
        {
             JsonResponseModel<DescribeSlowLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the slow log.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogRequest"/></param>
        /// <returns><see cref="DescribeSlowLogResponse"/></returns>
        public DescribeSlowLogResponse DescribeSlowLogSync(DescribeSlowLogRequest req)
        {
             JsonResponseModel<DescribeSlowLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a task result.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public async Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query a task result.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
             JsonResponseModel<DescribeTaskInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public async Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
             JsonResponseModel<DescribeTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public async Task<DestroyPostpaidInstanceResponse> DestroyPostpaidInstance(DestroyPostpaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPostpaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPostpaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPostpaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public DestroyPostpaidInstanceResponse DestroyPostpaidInstanceSync(DestroyPostpaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPostpaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPostpaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPostpaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return a monthly subscribed instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public async Task<DestroyPrepaidInstanceResponse> DestroyPrepaidInstance(DestroyPrepaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPrepaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyPrepaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrepaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to return a monthly subscribed instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public DestroyPrepaidInstanceResponse DestroyPrepaidInstanceSync(DestroyPrepaidInstanceRequest req)
        {
             JsonResponseModel<DestroyPrepaidInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyPrepaidInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyPrepaidInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public async Task<DisableReplicaReadonlyResponse> DisableReplicaReadonly(DisableReplicaReadonlyRequest req)
        {
             JsonResponseModel<DisableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="DisableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="DisableReplicaReadonlyResponse"/></returns>
        public DisableReplicaReadonlyResponse DisableReplicaReadonlySync(DisableReplicaReadonlyRequest req)
        {
             JsonResponseModel<DisableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public async Task<EnableReplicaReadonlyResponse> EnableReplicaReadonly(EnableReplicaReadonlyRequest req)
        {
             JsonResponseModel<EnableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable read/write separation.
        /// </summary>
        /// <param name="req"><see cref="EnableReplicaReadonlyRequest"/></param>
        /// <returns><see cref="EnableReplicaReadonlyResponse"/></returns>
        public EnableReplicaReadonlyResponse EnableReplicaReadonlySync(EnableReplicaReadonlyRequest req)
        {
             JsonResponseModel<EnableReplicaReadonlyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableReplicaReadonly");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableReplicaReadonlyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manually back up a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public async Task<ManualBackupInstanceResponse> ManualBackupInstance(ManualBackupInstanceRequest req)
        {
             JsonResponseModel<ManualBackupInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManualBackupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualBackupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manually back up a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="ManualBackupInstanceRequest"/></param>
        /// <returns><see cref="ManualBackupInstanceResponse"/></returns>
        public ManualBackupInstanceResponse ManualBackupInstanceSync(ManualBackupInstanceRequest req)
        {
             JsonResponseModel<ManualBackupInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManualBackupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManualBackupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the Redis password.
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public async Task<ModfiyInstancePasswordResponse> ModfiyInstancePassword(ModfiyInstancePasswordRequest req)
        {
             JsonResponseModel<ModfiyInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModfiyInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModfiyInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the Redis password.
        /// </summary>
        /// <param name="req"><see cref="ModfiyInstancePasswordRequest"/></param>
        /// <returns><see cref="ModfiyInstancePasswordResponse"/></returns>
        public ModfiyInstancePasswordResponse ModfiyInstancePasswordSync(ModfiyInstancePasswordRequest req)
        {
             JsonResponseModel<ModfiyInstancePasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModfiyInstancePassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModfiyInstancePasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set an auto-backup schedule.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public async Task<ModifyAutoBackupConfigResponse> ModifyAutoBackupConfig(ModifyAutoBackupConfigRequest req)
        {
             JsonResponseModel<ModifyAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set an auto-backup schedule.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public ModifyAutoBackupConfigResponse ModifyAutoBackupConfigSync(ModifyAutoBackupConfigRequest req)
        {
             JsonResponseModel<ModifyAutoBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance information.
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
        /// This API is used to modify instance information.
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

        /// <summary>
        /// This API is used to modify an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public async Task<ModifyInstanceAccountResponse> ModifyInstanceAccount(ModifyInstanceAccountRequest req)
        {
             JsonResponseModel<ModifyInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an instance sub-account.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceAccountRequest"/></param>
        /// <returns><see cref="ModifyInstanceAccountResponse"/></returns>
        public ModifyInstanceAccountResponse ModifyInstanceAccountSync(ModifyInstanceAccountRequest req)
        {
             JsonResponseModel<ModifyInstanceAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public async Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
             JsonResponseModel<ModifyInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
             JsonResponseModel<ModifyInstanceParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the network configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public async Task<ModifyNetworkConfigResponse> ModifyNetworkConfig(ModifyNetworkConfigRequest req)
        {
             JsonResponseModel<ModifyNetworkConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNetworkConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the network configuration of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public ModifyNetworkConfigResponse ModifyNetworkConfigSync(ModifyNetworkConfigRequest req)
        {
             JsonResponseModel<ModifyNetworkConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNetworkConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNetworkConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew an instance.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public async Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew an instance.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset a password.
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public async Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
             JsonResponseModel<ResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset a password.
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
             JsonResponseModel<ResetPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public async Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore a Redis instance.
        /// </summary>
        /// <param name="req"><see cref="RestoreInstanceRequest"/></param>
        /// <returns><see cref="RestoreInstanceResponse"/></returns>
        public RestoreInstanceResponse RestoreInstanceSync(RestoreInstanceRequest req)
        {
             JsonResponseModel<RestoreInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestoreInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestoreInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deisolate an instance.
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public async Task<StartupInstanceResponse> StartupInstance(StartupInstanceRequest req)
        {
             JsonResponseModel<StartupInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deisolate an instance.
        /// </summary>
        /// <param name="req"><see cref="StartupInstanceRequest"/></param>
        /// <returns><see cref="StartupInstanceResponse"/></returns>
        public StartupInstanceResponse StartupInstanceSync(StartupInstanceRequest req)
        {
             JsonResponseModel<StartupInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartupInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartupInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to swap the VIPs of instances for instance disaster recovery switch in scenarios where cross-AZ disaster recovery is supported through DTS. After the VIPs of the source and target instances are swapped, the target instance can be written into and the DTS sync task between them will be disconnected.
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public async Task<SwitchInstanceVipResponse> SwitchInstanceVip(SwitchInstanceVipRequest req)
        {
             JsonResponseModel<SwitchInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to swap the VIPs of instances for instance disaster recovery switch in scenarios where cross-AZ disaster recovery is supported through DTS. After the VIPs of the source and target instances are swapped, the target instance can be written into and the DTS sync task between them will be disconnected.
        /// </summary>
        /// <param name="req"><see cref="SwitchInstanceVipRequest"/></param>
        /// <returns><see cref="SwitchInstanceVipResponse"/></returns>
        public SwitchInstanceVipResponse SwitchInstanceVipSync(SwitchInstanceVipRequest req)
        {
             JsonResponseModel<SwitchInstanceVipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchInstanceVip");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchInstanceVipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade an instance.
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
        /// This API is used to upgrade an instance.
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

    }
}
