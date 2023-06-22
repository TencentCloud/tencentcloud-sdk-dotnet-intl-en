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

namespace TencentCloud.Cdb.V20170320
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdb.V20170320.Models;

   public class CdbClient : AbstractClient{

       private const string endpoint = "cdb.tencentcloudapi.com";
       private const string version = "2017-03-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API (AddTimeWindow) is used to add a maintenance time window for a TencentDB instance, so as to specify when the instance can automatically perform access switch operations.
        /// </summary>
        /// <param name="req"><see cref="AddTimeWindowRequest"/></param>
        /// <returns><see cref="AddTimeWindowResponse"/></returns>
        public async Task<AddTimeWindowResponse> AddTimeWindow(AddTimeWindowRequest req)
        {
             JsonResponseModel<AddTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AddTimeWindow) is used to add a maintenance time window for a TencentDB instance, so as to specify when the instance can automatically perform access switch operations.
        /// </summary>
        /// <param name="req"><see cref="AddTimeWindowRequest"/></param>
        /// <returns><see cref="AddTimeWindowResponse"/></returns>
        public AddTimeWindowResponse AddTimeWindowSync(AddTimeWindowRequest req)
        {
             JsonResponseModel<AddTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the configuration of database proxy.
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyResponse"/></returns>
        public async Task<AdjustCdbProxyResponse> AdjustCdbProxy(AdjustCdbProxyRequest req)
        {
             JsonResponseModel<AdjustCdbProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AdjustCdbProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustCdbProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the configuration of database proxy.
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyResponse"/></returns>
        public AdjustCdbProxyResponse AdjustCdbProxySync(AdjustCdbProxyRequest req)
        {
             JsonResponseModel<AdjustCdbProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AdjustCdbProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustCdbProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the database proxy address.
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyAddressRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyAddressResponse"/></returns>
        public async Task<AdjustCdbProxyAddressResponse> AdjustCdbProxyAddress(AdjustCdbProxyAddressRequest req)
        {
             JsonResponseModel<AdjustCdbProxyAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AdjustCdbProxyAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustCdbProxyAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to adjust the database proxy address.
        /// </summary>
        /// <param name="req"><see cref="AdjustCdbProxyAddressRequest"/></param>
        /// <returns><see cref="AdjustCdbProxyAddressResponse"/></returns>
        public AdjustCdbProxyAddressResponse AdjustCdbProxyAddressSync(AdjustCdbProxyAddressRequest req)
        {
             JsonResponseModel<AdjustCdbProxyAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AdjustCdbProxyAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustCdbProxyAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to aggregate the audit logs filtered by different conditions and aggregate the statistics of the specified data rows.
        /// </summary>
        /// <param name="req"><see cref="AnalyzeAuditLogsRequest"/></param>
        /// <returns><see cref="AnalyzeAuditLogsResponse"/></returns>
        public async Task<AnalyzeAuditLogsResponse> AnalyzeAuditLogs(AnalyzeAuditLogsRequest req)
        {
             JsonResponseModel<AnalyzeAuditLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AnalyzeAuditLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeAuditLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to aggregate the audit logs filtered by different conditions and aggregate the statistics of the specified data rows.
        /// </summary>
        /// <param name="req"><see cref="AnalyzeAuditLogsRequest"/></param>
        /// <returns><see cref="AnalyzeAuditLogsResponse"/></returns>
        public AnalyzeAuditLogsResponse AnalyzeAuditLogsSync(AnalyzeAuditLogsRequest req)
        {
             JsonResponseModel<AnalyzeAuditLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AnalyzeAuditLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeAuditLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AssociateSecurityGroups) is used to bind security groups to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public async Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (AssociateSecurityGroups) is used to bind security groups to instances in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
             JsonResponseModel<AssociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rebalance the loads of instances in an RO group. Please note that the database connections to those instances will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases. This operation should be performed with caution.
        /// </summary>
        /// <param name="req"><see cref="BalanceRoGroupLoadRequest"/></param>
        /// <returns><see cref="BalanceRoGroupLoadResponse"/></returns>
        public async Task<BalanceRoGroupLoadResponse> BalanceRoGroupLoad(BalanceRoGroupLoadRequest req)
        {
             JsonResponseModel<BalanceRoGroupLoadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BalanceRoGroupLoad");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BalanceRoGroupLoadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rebalance the loads of instances in an RO group. Please note that the database connections to those instances will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases. This operation should be performed with caution.
        /// </summary>
        /// <param name="req"><see cref="BalanceRoGroupLoadRequest"/></param>
        /// <returns><see cref="BalanceRoGroupLoadResponse"/></returns>
        public BalanceRoGroupLoadResponse BalanceRoGroupLoadSync(BalanceRoGroupLoadRequest req)
        {
             JsonResponseModel<BalanceRoGroupLoadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BalanceRoGroupLoad");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BalanceRoGroupLoadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable database proxy.
        /// </summary>
        /// <param name="req"><see cref="CloseCDBProxyRequest"/></param>
        /// <returns><see cref="CloseCDBProxyResponse"/></returns>
        public async Task<CloseCDBProxyResponse> CloseCDBProxy(CloseCDBProxyRequest req)
        {
             JsonResponseModel<CloseCDBProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseCDBProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseCDBProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable database proxy.
        /// </summary>
        /// <param name="req"><see cref="CloseCDBProxyRequest"/></param>
        /// <returns><see cref="CloseCDBProxyResponse"/></returns>
        public CloseCDBProxyResponse CloseCDBProxySync(CloseCDBProxyRequest req)
        {
             JsonResponseModel<CloseCDBProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseCDBProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseCDBProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable the database proxy address.
        /// </summary>
        /// <param name="req"><see cref="CloseCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CloseCdbProxyAddressResponse"/></returns>
        public async Task<CloseCdbProxyAddressResponse> CloseCdbProxyAddress(CloseCdbProxyAddressRequest req)
        {
             JsonResponseModel<CloseCdbProxyAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseCdbProxyAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseCdbProxyAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable the database proxy address.
        /// </summary>
        /// <param name="req"><see cref="CloseCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CloseCdbProxyAddressResponse"/></returns>
        public CloseCdbProxyAddressResponse CloseCdbProxyAddressSync(CloseCdbProxyAddressRequest req)
        {
             JsonResponseModel<CloseCdbProxyAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseCdbProxyAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseCdbProxyAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CloseWanService) is used to disable public network access for TencentDB instance, which will make public IP addresses inaccessible.
        /// </summary>
        /// <param name="req"><see cref="CloseWanServiceRequest"/></param>
        /// <returns><see cref="CloseWanServiceResponse"/></returns>
        public async Task<CloseWanServiceResponse> CloseWanService(CloseWanServiceRequest req)
        {
             JsonResponseModel<CloseWanServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseWanService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseWanServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CloseWanService) is used to disable public network access for TencentDB instance, which will make public IP addresses inaccessible.
        /// </summary>
        /// <param name="req"><see cref="CloseWanServiceRequest"/></param>
        /// <returns><see cref="CloseWanServiceResponse"/></returns>
        public CloseWanServiceResponse CloseWanServiceSync(CloseWanServiceRequest req)
        {
             JsonResponseModel<CloseWanServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseWanService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseWanServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TencentDB account. The account name, host address, and password are required. Account remarks and maximum connections can also be configured.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public async Task<CreateAccountsResponse> CreateAccounts(CreateAccountsRequest req)
        {
             JsonResponseModel<CreateAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TencentDB account. The account name, host address, and password are required. Account remarks and maximum connections can also be configured.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountsRequest"/></param>
        /// <returns><see cref="CreateAccountsResponse"/></returns>
        public CreateAccountsResponse CreateAccountsSync(CreateAccountsRequest req)
        {
             JsonResponseModel<CreateAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an audit policy for a TencentDB instance by associating an audit rule with the TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditPolicyRequest"/></param>
        /// <returns><see cref="CreateAuditPolicyResponse"/></returns>
        public async Task<CreateAuditPolicyResponse> CreateAuditPolicy(CreateAuditPolicyRequest req)
        {
             JsonResponseModel<CreateAuditPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAuditPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuditPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an audit policy for a TencentDB instance by associating an audit rule with the TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditPolicyRequest"/></param>
        /// <returns><see cref="CreateAuditPolicyResponse"/></returns>
        public CreateAuditPolicyResponse CreateAuditPolicySync(CreateAuditPolicyRequest req)
        {
             JsonResponseModel<CreateAuditPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAuditPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAuditPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateBackup) is used to create a TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public async Task<CreateBackupResponse> CreateBackup(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateBackup) is used to create a TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="CreateBackupRequest"/></param>
        /// <returns><see cref="CreateBackupResponse"/></returns>
        public CreateBackupResponse CreateBackupSync(CreateBackupRequest req)
        {
             JsonResponseModel<CreateBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used create a database proxy for a source instance.
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyRequest"/></param>
        /// <returns><see cref="CreateCdbProxyResponse"/></returns>
        public async Task<CreateCdbProxyResponse> CreateCdbProxy(CreateCdbProxyRequest req)
        {
             JsonResponseModel<CreateCdbProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCdbProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCdbProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used create a database proxy for a source instance.
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyRequest"/></param>
        /// <returns><see cref="CreateCdbProxyResponse"/></returns>
        public CreateCdbProxyResponse CreateCdbProxySync(CreateCdbProxyRequest req)
        {
             JsonResponseModel<CreateCdbProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCdbProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCdbProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a database proxy address.
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CreateCdbProxyAddressResponse"/></returns>
        public async Task<CreateCdbProxyAddressResponse> CreateCdbProxyAddress(CreateCdbProxyAddressRequest req)
        {
             JsonResponseModel<CreateCdbProxyAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCdbProxyAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCdbProxyAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a database proxy address.
        /// </summary>
        /// <param name="req"><see cref="CreateCdbProxyAddressRequest"/></param>
        /// <returns><see cref="CreateCdbProxyAddressResponse"/></returns>
        public CreateCdbProxyAddressResponse CreateCdbProxyAddressSync(CreateCdbProxyAddressRequest req)
        {
             JsonResponseModel<CreateCdbProxyAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCdbProxyAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCdbProxyAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a clone of a specific instance, and roll back the clone by using a physical backup file of the instance or roll back the clone to a point in time.
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public async Task<CreateCloneInstanceResponse> CreateCloneInstance(CreateCloneInstanceRequest req)
        {
             JsonResponseModel<CreateCloneInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloneInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloneInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a clone of a specific instance, and roll back the clone by using a physical backup file of the instance or roll back the clone to a point in time.
        /// </summary>
        /// <param name="req"><see cref="CreateCloneInstanceRequest"/></param>
        /// <returns><see cref="CreateCloneInstanceResponse"/></returns>
        public CreateCloneInstanceResponse CreateCloneInstanceSync(CreateCloneInstanceRequest req)
        {
             JsonResponseModel<CreateCloneInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloneInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloneInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateDBImportJob) is used to create a data import task for a TencentDB instance.
        /// 
        /// Note that the files for a data import task must be uploaded to Tencent Cloud in advance. You need to do so in the console.
        /// </summary>
        /// <param name="req"><see cref="CreateDBImportJobRequest"/></param>
        /// <returns><see cref="CreateDBImportJobResponse"/></returns>
        public async Task<CreateDBImportJobResponse> CreateDBImportJob(CreateDBImportJobRequest req)
        {
             JsonResponseModel<CreateDBImportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBImportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBImportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateDBImportJob) is used to create a data import task for a TencentDB instance.
        /// 
        /// Note that the files for a data import task must be uploaded to Tencent Cloud in advance. You need to do so in the console.
        /// </summary>
        /// <param name="req"><see cref="CreateDBImportJobRequest"/></param>
        /// <returns><see cref="CreateDBImportJobResponse"/></returns>
        public CreateDBImportJobResponse CreateDBImportJobSync(CreateDBImportJobRequest req)
        {
             JsonResponseModel<CreateDBImportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBImportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBImportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a monthly subscribed TencentDB instance (which can be a source, disaster recovery, or read-only instance) by passing in information such as instance specifications, MySQL version number, purchased duration, and quantity.
        /// 
        /// This is an asynchronous API. You can also use the [DescribeDBInstances](https://intl.cloud.tencent.com/document/api/236/15872?from_cn_redirect=1) API to query the instance details. If the output parameter `Status` is `1` and the output parameter `TaskStatus` is `0`, the instance has been successfully delivered.
        /// 
        /// 1. You can use the [DescribeDBZoneConfig](https://intl.cloud.tencent.com/document/api/236/17229?from_cn_redirect=1) API to query the purchasable instance specifications, and then use the [DescribeDBPrice](https://intl.cloud.tencent.com/document/api/236/18566?from_cn_redirect=1) API to query the prices of the purchasable instances.
        /// 2. You can create up to 100 instances at a time, with an instance validity period of up to 36 months.
        /// 3. MySQL v5.5, v5.6, v5.7, and v8.0 are supported.
        /// 4. Source instances, read-only instances, and disaster recovery instances can be created.
        /// 5. If `Port`, `ParamList`, or `Password` is specified in the input parameters, the instance (excluding basic instances) will be initialized.
        /// 6. If `Port`, `ParamTemplateId`, or `AlarmPolicyList` is specified in the input parameters, you need to update your SDK to the latest version.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public async Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
             JsonResponseModel<CreateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a monthly subscribed TencentDB instance (which can be a source, disaster recovery, or read-only instance) by passing in information such as instance specifications, MySQL version number, purchased duration, and quantity.
        /// 
        /// This is an asynchronous API. You can also use the [DescribeDBInstances](https://intl.cloud.tencent.com/document/api/236/15872?from_cn_redirect=1) API to query the instance details. If the output parameter `Status` is `1` and the output parameter `TaskStatus` is `0`, the instance has been successfully delivered.
        /// 
        /// 1. You can use the [DescribeDBZoneConfig](https://intl.cloud.tencent.com/document/api/236/17229?from_cn_redirect=1) API to query the purchasable instance specifications, and then use the [DescribeDBPrice](https://intl.cloud.tencent.com/document/api/236/18566?from_cn_redirect=1) API to query the prices of the purchasable instances.
        /// 2. You can create up to 100 instances at a time, with an instance validity period of up to 36 months.
        /// 3. MySQL v5.5, v5.6, v5.7, and v8.0 are supported.
        /// 4. Source instances, read-only instances, and disaster recovery instances can be created.
        /// 5. If `Port`, `ParamList`, or `Password` is specified in the input parameters, the instance (excluding basic instances) will be initialized.
        /// 6. If `Port`, `ParamTemplateId`, or `AlarmPolicyList` is specified in the input parameters, you need to update your SDK to the latest version.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public CreateDBInstanceResponse CreateDBInstanceSync(CreateDBInstanceRequest req)
        {
             JsonResponseModel<CreateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go TencentDB instance (which can be a source, disaster recovery, or read-only instance) by passing in information such as instance specifications, MySQL version number, and quantity.
        /// 
        /// This is an async API. You can also use the [DescribeDBInstances](https://intl.cloud.tencent.com/document/api/236/15872?from_cn_redirect=1) API to query the instance details. If the `Status` value of an instance is `1` and `TaskStatus` is `0`, the instance has been successfully delivered.
        /// 
        /// 1. You can use the [DescribeDBZoneConfig](https://intl.cloud.tencent.com/document/api/236/17229?from_cn_redirect=1) API to query the purchasable instance specifications, and then use the [DescribeDBPrice](https://intl.cloud.tencent.com/document/api/236/18566?from_cn_redirect=1) API to query the prices of the purchasable instances.
        /// 2. You can create up to 100 instances at a time, with an instance validity period of up to 36 months.
        /// 3. MySQL 5.5, 5.6, 5.7, and 8.0 are supported.
        /// 4. Source instances, disaster recovery instances, and read-only instances can be created.
        /// 5. If `Port`, `ParamList`, or `Password` is specified in the input parameters, the instance will be initialized.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public async Task<CreateDBInstanceHourResponse> CreateDBInstanceHour(CreateDBInstanceHourRequest req)
        {
             JsonResponseModel<CreateDBInstanceHourResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstanceHour");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceHourResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go TencentDB instance (which can be a source, disaster recovery, or read-only instance) by passing in information such as instance specifications, MySQL version number, and quantity.
        /// 
        /// This is an async API. You can also use the [DescribeDBInstances](https://intl.cloud.tencent.com/document/api/236/15872?from_cn_redirect=1) API to query the instance details. If the `Status` value of an instance is `1` and `TaskStatus` is `0`, the instance has been successfully delivered.
        /// 
        /// 1. You can use the [DescribeDBZoneConfig](https://intl.cloud.tencent.com/document/api/236/17229?from_cn_redirect=1) API to query the purchasable instance specifications, and then use the [DescribeDBPrice](https://intl.cloud.tencent.com/document/api/236/18566?from_cn_redirect=1) API to query the prices of the purchasable instances.
        /// 2. You can create up to 100 instances at a time, with an instance validity period of up to 36 months.
        /// 3. MySQL 5.5, 5.6, 5.7, and 8.0 are supported.
        /// 4. Source instances, disaster recovery instances, and read-only instances can be created.
        /// 5. If `Port`, `ParamList`, or `Password` is specified in the input parameters, the instance will be initialized.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceHourRequest"/></param>
        /// <returns><see cref="CreateDBInstanceHourResponse"/></returns>
        public CreateDBInstanceHourResponse CreateDBInstanceHourSync(CreateDBInstanceHourRequest req)
        {
             JsonResponseModel<CreateDBInstanceHourResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstanceHour");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceHourResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a parameter template. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public async Task<CreateParamTemplateResponse> CreateParamTemplate(CreateParamTemplateRequest req)
        {
             JsonResponseModel<CreateParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a parameter template. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="CreateParamTemplateRequest"/></param>
        /// <returns><see cref="CreateParamTemplateResponse"/></returns>
        public CreateParamTemplateResponse CreateParamTemplateSync(CreateParamTemplateRequest req)
        {
             JsonResponseModel<CreateParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VIP exclusive to a TencentDB read-only instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRoInstanceIpRequest"/></param>
        /// <returns><see cref="CreateRoInstanceIpResponse"/></returns>
        public async Task<CreateRoInstanceIpResponse> CreateRoInstanceIp(CreateRoInstanceIpRequest req)
        {
             JsonResponseModel<CreateRoInstanceIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoInstanceIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoInstanceIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a VIP exclusive to a TencentDB read-only instance.
        /// </summary>
        /// <param name="req"><see cref="CreateRoInstanceIpRequest"/></param>
        /// <returns><see cref="CreateRoInstanceIpResponse"/></returns>
        public CreateRoInstanceIpResponse CreateRoInstanceIpSync(CreateRoInstanceIpRequest req)
        {
             JsonResponseModel<CreateRoInstanceIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoInstanceIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoInstanceIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAccounts) is used to delete TencentDB accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public async Task<DeleteAccountsResponse> DeleteAccounts(DeleteAccountsRequest req)
        {
             JsonResponseModel<DeleteAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAccounts) is used to delete TencentDB accounts.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountsRequest"/></param>
        /// <returns><see cref="DeleteAccountsResponse"/></returns>
        public DeleteAccountsResponse DeleteAccountsSync(DeleteAccountsRequest req)
        {
             JsonResponseModel<DeleteAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a database backup. It can only delete manually initiated backups.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public async Task<DeleteBackupResponse> DeleteBackup(DeleteBackupRequest req)
        {
             JsonResponseModel<DeleteBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a database backup. It can only delete manually initiated backups.
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupRequest"/></param>
        /// <returns><see cref="DeleteBackupResponse"/></returns>
        public DeleteBackupResponse DeleteBackupSync(DeleteBackupRequest req)
        {
             JsonResponseModel<DeleteBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a parameter template. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public async Task<DeleteParamTemplateResponse> DeleteParamTemplate(DeleteParamTemplateRequest req)
        {
             JsonResponseModel<DeleteParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a parameter template. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="DeleteParamTemplateRequest"/></param>
        /// <returns><see cref="DeleteParamTemplateResponse"/></returns>
        public DeleteParamTemplateResponse DeleteParamTemplateSync(DeleteParamTemplateRequest req)
        {
             JsonResponseModel<DeleteParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteTimeWindow) is used to delete a maintenance time window for a TencentDB instance. After it is deleted, the default maintenance time window will be 03:00-04:00, i.e., switch to a new instance will be performed during 03:00-04:00 by default.
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeWindowRequest"/></param>
        /// <returns><see cref="DeleteTimeWindowResponse"/></returns>
        public async Task<DeleteTimeWindowResponse> DeleteTimeWindow(DeleteTimeWindowRequest req)
        {
             JsonResponseModel<DeleteTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteTimeWindow) is used to delete a maintenance time window for a TencentDB instance. After it is deleted, the default maintenance time window will be 03:00-04:00, i.e., switch to a new instance will be performed during 03:00-04:00 by default.
        /// </summary>
        /// <param name="req"><see cref="DeleteTimeWindowRequest"/></param>
        /// <returns><see cref="DeleteTimeWindowResponse"/></returns>
        public DeleteTimeWindowResponse DeleteTimeWindowSync(DeleteTimeWindowRequest req)
        {
             JsonResponseModel<DeleteTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAccountPrivileges) is used to query the information of TencentDB account permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public async Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
             JsonResponseModel<DescribeAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAccountPrivileges) is used to query the information of TencentDB account permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
             JsonResponseModel<DescribeAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query information of all TencentDB accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query information of all TencentDB accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAsyncRequestInfo) is used to query the async task execution result of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public async Task<DescribeAsyncRequestInfoResponse> DescribeAsyncRequestInfo(DescribeAsyncRequestInfoRequest req)
        {
             JsonResponseModel<DescribeAsyncRequestInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAsyncRequestInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncRequestInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAsyncRequestInfo) is used to query the async task execution result of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAsyncRequestInfoRequest"/></param>
        /// <returns><see cref="DescribeAsyncRequestInfoResponse"/></returns>
        public DescribeAsyncRequestInfoResponse DescribeAsyncRequestInfoSync(DescribeAsyncRequestInfoRequest req)
        {
             JsonResponseModel<DescribeAsyncRequestInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAsyncRequestInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAsyncRequestInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the audit policies of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuditPoliciesResponse"/></returns>
        public async Task<DescribeAuditPoliciesResponse> DescribeAuditPolicies(DescribeAuditPoliciesRequest req)
        {
             JsonResponseModel<DescribeAuditPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuditPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the audit policies of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAuditPoliciesResponse"/></returns>
        public DescribeAuditPoliciesResponse DescribeAuditPoliciesSync(DescribeAuditPoliciesRequest req)
        {
             JsonResponseModel<DescribeAuditPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuditPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the audit rules in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRulesRequest"/></param>
        /// <returns><see cref="DescribeAuditRulesResponse"/></returns>
        public async Task<DescribeAuditRulesResponse> DescribeAuditRules(DescribeAuditRulesRequest req)
        {
             JsonResponseModel<DescribeAuditRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuditRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the audit rules in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRulesRequest"/></param>
        /// <returns><see cref="DescribeAuditRulesResponse"/></returns>
        public DescribeAuditRulesResponse DescribeAuditRulesSync(DescribeAuditRulesRequest req)
        {
             JsonResponseModel<DescribeAuditRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuditRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeBackupConfig) is used to query the configuration information of a TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public async Task<DescribeBackupConfigResponse> DescribeBackupConfig(DescribeBackupConfigRequest req)
        {
             JsonResponseModel<DescribeBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeBackupConfig) is used to query the configuration information of a TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeBackupConfigResponse"/></returns>
        public DescribeBackupConfigResponse DescribeBackupConfigSync(DescribeBackupConfigRequest req)
        {
             JsonResponseModel<DescribeBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the decryption key of a backup file.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDecryptionKeyRequest"/></param>
        /// <returns><see cref="DescribeBackupDecryptionKeyResponse"/></returns>
        public async Task<DescribeBackupDecryptionKeyResponse> DescribeBackupDecryptionKey(DescribeBackupDecryptionKeyRequest req)
        {
             JsonResponseModel<DescribeBackupDecryptionKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDecryptionKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDecryptionKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the decryption key of a backup file.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDecryptionKeyRequest"/></param>
        /// <returns><see cref="DescribeBackupDecryptionKeyResponse"/></returns>
        public DescribeBackupDecryptionKeyResponse DescribeBackupDecryptionKeySync(DescribeBackupDecryptionKeyRequest req)
        {
             JsonResponseModel<DescribeBackupDecryptionKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDecryptionKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDecryptionKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the restrictions of downloading backups in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public async Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the restrictions of downloading backups in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the default encryption status of an instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeBackupEncryptionStatusResponse"/></returns>
        public async Task<DescribeBackupEncryptionStatusResponse> DescribeBackupEncryptionStatus(DescribeBackupEncryptionStatusRequest req)
        {
             JsonResponseModel<DescribeBackupEncryptionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupEncryptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupEncryptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the default encryption status of an instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="DescribeBackupEncryptionStatusResponse"/></returns>
        public DescribeBackupEncryptionStatusResponse DescribeBackupEncryptionStatusSync(DescribeBackupEncryptionStatusRequest req)
        {
             JsonResponseModel<DescribeBackupEncryptionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupEncryptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupEncryptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup overview of a user. It will return the user's current total number of backups, total capacity used by backups, capacity in the free tier, and paid capacity (all capacity values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public async Task<DescribeBackupOverviewResponse> DescribeBackupOverview(DescribeBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup overview of a user. It will return the user's current total number of backups, total capacity used by backups, capacity in the free tier, and paid capacity (all capacity values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public DescribeBackupOverviewResponse DescribeBackupOverviewSync(DescribeBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the statistics of backups. It will return the capacity used by backups at the instance level and the number and used capacity of data backups and log backups of each instance (all capacity values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public async Task<DescribeBackupSummariesResponse> DescribeBackupSummaries(DescribeBackupSummariesRequest req)
        {
             JsonResponseModel<DescribeBackupSummariesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupSummaries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupSummariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the statistics of backups. It will return the capacity used by backups at the instance level and the number and used capacity of data backups and log backups of each instance (all capacity values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public DescribeBackupSummariesResponse DescribeBackupSummariesSync(DescribeBackupSummariesRequest req)
        {
             JsonResponseModel<DescribeBackupSummariesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupSummaries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupSummariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeBackups) is used to query the backups of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public async Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest req)
        {
             JsonResponseModel<DescribeBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeBackups) is used to query the backups of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupsRequest"/></param>
        /// <returns><see cref="DescribeBackupsResponse"/></returns>
        public DescribeBackupsResponse DescribeBackupsSync(DescribeBackupsRequest req)
        {
             JsonResponseModel<DescribeBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the log backup overview of a user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBinlogBackupOverviewResponse"/></returns>
        public async Task<DescribeBinlogBackupOverviewResponse> DescribeBinlogBackupOverview(DescribeBinlogBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeBinlogBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBinlogBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBinlogBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the log backup overview of a user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBinlogBackupOverviewResponse"/></returns>
        public DescribeBinlogBackupOverviewResponse DescribeBinlogBackupOverviewSync(DescribeBinlogBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeBinlogBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBinlogBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBinlogBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of binlog files of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public async Task<DescribeBinlogsResponse> DescribeBinlogs(DescribeBinlogsRequest req)
        {
             JsonResponseModel<DescribeBinlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBinlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBinlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of binlog files of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBinlogsRequest"/></param>
        /// <returns><see cref="DescribeBinlogsResponse"/></returns>
        public DescribeBinlogsResponse DescribeBinlogsSync(DescribeBinlogsRequest req)
        {
             JsonResponseModel<DescribeBinlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBinlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBinlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口已经废弃，请使用+DescribeCdbProxyInfo+进行替换。
        /// 
        /// This API is deprecated and replaced by the `DescribeCdbProxyInfo` API. 
        /// 
        /// This API is used to query database proxy. It will be deprecated and replaced by the `QueryCDBProxy` API.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDBProxyRequest"/></param>
        /// <returns><see cref="DescribeCDBProxyResponse"/></returns>
        public async Task<DescribeCDBProxyResponse> DescribeCDBProxy(DescribeCDBProxyRequest req)
        {
             JsonResponseModel<DescribeCDBProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCDBProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDBProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口已经废弃，请使用+DescribeCdbProxyInfo+进行替换。
        /// 
        /// This API is deprecated and replaced by the `DescribeCdbProxyInfo` API. 
        /// 
        /// This API is used to query database proxy. It will be deprecated and replaced by the `QueryCDBProxy` API.
        /// </summary>
        /// <param name="req"><see cref="DescribeCDBProxyRequest"/></param>
        /// <returns><see cref="DescribeCDBProxyResponse"/></returns>
        public DescribeCDBProxyResponse DescribeCDBProxySync(DescribeCDBProxyRequest req)
        {
             JsonResponseModel<DescribeCDBProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCDBProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCDBProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbProxyInfoRequest"/></param>
        /// <returns><see cref="DescribeCdbProxyInfoResponse"/></returns>
        public async Task<DescribeCdbProxyInfoResponse> DescribeCdbProxyInfo(DescribeCdbProxyInfoRequest req)
        {
             JsonResponseModel<DescribeCdbProxyInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdbProxyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdbProxyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbProxyInfoRequest"/></param>
        /// <returns><see cref="DescribeCdbProxyInfoResponse"/></returns>
        public DescribeCdbProxyInfoResponse DescribeCdbProxyInfoSync(DescribeCdbProxyInfoRequest req)
        {
             JsonResponseModel<DescribeCdbProxyInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdbProxyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdbProxyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable specifications of TencentDB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbZoneConfigRequest"/></param>
        /// <returns><see cref="DescribeCdbZoneConfigResponse"/></returns>
        public async Task<DescribeCdbZoneConfigResponse> DescribeCdbZoneConfig(DescribeCdbZoneConfigRequest req)
        {
             JsonResponseModel<DescribeCdbZoneConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdbZoneConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdbZoneConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable specifications of TencentDB instances in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeCdbZoneConfigRequest"/></param>
        /// <returns><see cref="DescribeCdbZoneConfigResponse"/></returns>
        public DescribeCdbZoneConfigResponse DescribeCdbZoneConfigSync(DescribeCdbZoneConfigRequest req)
        {
             JsonResponseModel<DescribeCdbZoneConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdbZoneConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdbZoneConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the clone task list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneListRequest"/></param>
        /// <returns><see cref="DescribeCloneListResponse"/></returns>
        public async Task<DescribeCloneListResponse> DescribeCloneList(DescribeCloneListRequest req)
        {
             JsonResponseModel<DescribeCloneListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloneList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloneListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the clone task list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneListRequest"/></param>
        /// <returns><see cref="DescribeCloneListResponse"/></returns>
        public DescribeCloneListResponse DescribeCloneListSync(DescribeCloneListRequest req)
        {
             JsonResponseModel<DescribeCloneListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloneList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloneListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query database version attributes, including supported features such as database encryption and audit.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBFeaturesRequest"/></param>
        /// <returns><see cref="DescribeDBFeaturesResponse"/></returns>
        public async Task<DescribeDBFeaturesResponse> DescribeDBFeatures(DescribeDBFeaturesRequest req)
        {
             JsonResponseModel<DescribeDBFeaturesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBFeatures");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBFeaturesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query database version attributes, including supported features such as database encryption and audit.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBFeaturesRequest"/></param>
        /// <returns><see cref="DescribeDBFeaturesResponse"/></returns>
        public DescribeDBFeaturesResponse DescribeDBFeaturesSync(DescribeDBFeaturesRequest req)
        {
             JsonResponseModel<DescribeDBFeaturesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBFeatures");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBFeaturesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBImportRecords) is used to query the records of import tasks in a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBImportRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBImportRecordsResponse"/></returns>
        public async Task<DescribeDBImportRecordsResponse> DescribeDBImportRecords(DescribeDBImportRecordsRequest req)
        {
             JsonResponseModel<DescribeDBImportRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBImportRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBImportRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBImportRecords) is used to query the records of import tasks in a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBImportRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBImportRecordsResponse"/></returns>
        public DescribeDBImportRecordsResponse DescribeDBImportRecordsSync(DescribeDBImportRecordsRequest req)
        {
             JsonResponseModel<DescribeDBImportRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBImportRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBImportRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstanceCharset) is used to query the character set and its name of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceCharsetRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceCharsetResponse"/></returns>
        public async Task<DescribeDBInstanceCharsetResponse> DescribeDBInstanceCharset(DescribeDBInstanceCharsetRequest req)
        {
             JsonResponseModel<DescribeDBInstanceCharsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceCharset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceCharsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstanceCharset) is used to query the character set and its name of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceCharsetRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceCharsetResponse"/></returns>
        public DescribeDBInstanceCharsetResponse DescribeDBInstanceCharsetSync(DescribeDBInstanceCharsetRequest req)
        {
             JsonResponseModel<DescribeDBInstanceCharsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceCharset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceCharsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstanceConfig) is used to query the configuration information of a TencentDB instance, such as its synchronization mode and deployment mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceConfigResponse"/></returns>
        public async Task<DescribeDBInstanceConfigResponse> DescribeDBInstanceConfig(DescribeDBInstanceConfigRequest req)
        {
             JsonResponseModel<DescribeDBInstanceConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstanceConfig) is used to query the configuration information of a TencentDB instance, such as its synchronization mode and deployment mode.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceConfigResponse"/></returns>
        public DescribeDBInstanceConfigResponse DescribeDBInstanceConfigSync(DescribeDBInstanceConfigRequest req)
        {
             JsonResponseModel<DescribeDBInstanceConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstanceGTID) is used to query whether GTID is activated for a TencentDB instance. Instances on or below version 5.5 are not supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceGTIDResponse"/></returns>
        public async Task<DescribeDBInstanceGTIDResponse> DescribeDBInstanceGTID(DescribeDBInstanceGTIDRequest req)
        {
             JsonResponseModel<DescribeDBInstanceGTIDResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceGTID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceGTIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstanceGTID) is used to query whether GTID is activated for a TencentDB instance. Instances on or below version 5.5 are not supported.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceGTIDResponse"/></returns>
        public DescribeDBInstanceGTIDResponse DescribeDBInstanceGTIDSync(DescribeDBInstanceGTIDRequest req)
        {
             JsonResponseModel<DescribeDBInstanceGTIDResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceGTID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceGTIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the basic information of an instance (instance ID, instance name, and whether encryption is enabled).
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInfoResponse"/></returns>
        public async Task<DescribeDBInstanceInfoResponse> DescribeDBInstanceInfo(DescribeDBInstanceInfoRequest req)
        {
             JsonResponseModel<DescribeDBInstanceInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the basic information of an instance (instance ID, instance name, and whether encryption is enabled).
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceInfoRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceInfoResponse"/></returns>
        public DescribeDBInstanceInfoResponse DescribeDBInstanceInfoSync(DescribeDBInstanceInfoRequest req)
        {
             JsonResponseModel<DescribeDBInstanceInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstanceRebootTime) is used to query the estimated time needed for a TencentDB instance to restart.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceRebootTimeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceRebootTimeResponse"/></returns>
        public async Task<DescribeDBInstanceRebootTimeResponse> DescribeDBInstanceRebootTime(DescribeDBInstanceRebootTimeRequest req)
        {
             JsonResponseModel<DescribeDBInstanceRebootTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceRebootTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceRebootTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstanceRebootTime) is used to query the estimated time needed for a TencentDB instance to restart.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceRebootTimeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceRebootTimeResponse"/></returns>
        public DescribeDBInstanceRebootTimeResponse DescribeDBInstanceRebootTimeSync(DescribeDBInstanceRebootTimeRequest req)
        {
             JsonResponseModel<DescribeDBInstanceRebootTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceRebootTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceRebootTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstances) is used to query the list of TencentDB instances (which can be primary, disaster recovery, or read-only instances). It supports filtering instances by project ID, instance ID, access address, and instance status.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public async Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBInstances) is used to query the list of TencentDB instances (which can be primary, disaster recovery, or read-only instances). It supports filtering instances by project ID, instance ID, access address, and instance status.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchase or renewal price of a pay-as-you-go or monthly subscribed TencentDB instance by passing in information such as instance type, purchase duration, number of instances to purchase, memory size, disk size, and AZ. For the price of instance renewal, you can pass in instance name to query.
        /// 
        /// Note: To query prices in a specific region, you need to use the access point of the region. For more information on access points, see <a href="https://www.tencentcloud.com/document/product/236/15832">Service Address</a>. For example, to query prices in Guangzhou, send a request to: cdb.ap-guangzhou.tencentcloudapi.com. Likewise, to query prices in Shanghai, send a request to: cdb.ap-shanghai.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDBPriceResponse"/></returns>
        public async Task<DescribeDBPriceResponse> DescribeDBPrice(DescribeDBPriceRequest req)
        {
             JsonResponseModel<DescribeDBPriceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchase or renewal price of a pay-as-you-go or monthly subscribed TencentDB instance by passing in information such as instance type, purchase duration, number of instances to purchase, memory size, disk size, and AZ. For the price of instance renewal, you can pass in instance name to query.
        /// 
        /// Note: To query prices in a specific region, you need to use the access point of the region. For more information on access points, see <a href="https://www.tencentcloud.com/document/product/236/15832">Service Address</a>. For example, to query prices in Guangzhou, send a request to: cdb.ap-guangzhou.tencentcloudapi.com. Likewise, to query prices in Shanghai, send a request to: cdb.ap-shanghai.tencentcloudapi.com.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDBPriceResponse"/></returns>
        public DescribeDBPriceResponse DescribeDBPriceSync(DescribeDBPriceRequest req)
        {
             JsonResponseModel<DescribeDBPriceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBPrice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBPriceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBSecurityGroups) is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public async Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBSecurityGroups) is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBSwitchRecords) is used to query the instance switch records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSwitchRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBSwitchRecordsResponse"/></returns>
        public async Task<DescribeDBSwitchRecordsResponse> DescribeDBSwitchRecords(DescribeDBSwitchRecordsRequest req)
        {
             JsonResponseModel<DescribeDBSwitchRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSwitchRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSwitchRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDBSwitchRecords) is used to query the instance switch records.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSwitchRecordsRequest"/></param>
        /// <returns><see cref="DescribeDBSwitchRecordsResponse"/></returns>
        public DescribeDBSwitchRecordsResponse DescribeDBSwitchRecordsSync(DescribeDBSwitchRecordsRequest req)
        {
             JsonResponseModel<DescribeDBSwitchRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSwitchRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSwitchRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the data backup overview of a user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeDataBackupOverviewResponse"/></returns>
        public async Task<DescribeDataBackupOverviewResponse> DescribeDataBackupOverview(DescribeDataBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeDataBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the data backup overview of a user in the current region.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeDataBackupOverviewResponse"/></returns>
        public DescribeDataBackupOverviewResponse DescribeDataBackupOverviewSync(DescribeDataBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeDataBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of databases in a TencentDB instance which must be a source or disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public async Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of databases in a TencentDB instance which must be a source or disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDefaultParams) is used to query the list of default configurable parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParamsRequest"/></param>
        /// <returns><see cref="DescribeDefaultParamsResponse"/></returns>
        public async Task<DescribeDefaultParamsResponse> DescribeDefaultParams(DescribeDefaultParamsRequest req)
        {
             JsonResponseModel<DescribeDefaultParamsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDefaultParams) is used to query the list of default configurable parameters.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParamsRequest"/></param>
        /// <returns><see cref="DescribeDefaultParamsResponse"/></returns>
        public DescribeDefaultParamsResponse DescribeDefaultParamsSync(DescribeDefaultParamsRequest req)
        {
             JsonResponseModel<DescribeDefaultParamsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultParams");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultParamsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDeviceMonitorInfo) is used to query the monitoring information of a TencentDB physical machine on the day. Currently, it only supports instances with 488 GB memory and 6 TB disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorInfoResponse"/></returns>
        public async Task<DescribeDeviceMonitorInfoResponse> DescribeDeviceMonitorInfo(DescribeDeviceMonitorInfoRequest req)
        {
             JsonResponseModel<DescribeDeviceMonitorInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceMonitorInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceMonitorInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeDeviceMonitorInfo) is used to query the monitoring information of a TencentDB physical machine on the day. Currently, it only supports instances with 488 GB memory and 6 TB disk.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceMonitorInfoRequest"/></param>
        /// <returns><see cref="DescribeDeviceMonitorInfoResponse"/></returns>
        public DescribeDeviceMonitorInfoResponse DescribeDeviceMonitorInfoSync(DescribeDeviceMonitorInfoRequest req)
        {
             JsonResponseModel<DescribeDeviceMonitorInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceMonitorInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceMonitorInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the error logs of an instance over the past month by search criteria.
        /// Note: the HTTP response packet will be very large if it contain a single large error log, which causes the API call to time out. If this happens, we recommend you lower the value of the input parameter `Limit` to reduce the packet size so that the API can respond timely.
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorLogDataRequest"/></param>
        /// <returns><see cref="DescribeErrorLogDataResponse"/></returns>
        public async Task<DescribeErrorLogDataResponse> DescribeErrorLogData(DescribeErrorLogDataRequest req)
        {
             JsonResponseModel<DescribeErrorLogDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeErrorLogData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeErrorLogDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the error logs of an instance over the past month by search criteria.
        /// Note: the HTTP response packet will be very large if it contain a single large error log, which causes the API call to time out. If this happens, we recommend you lower the value of the input parameter `Limit` to reduce the packet size so that the API can respond timely.
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorLogDataRequest"/></param>
        /// <returns><see cref="DescribeErrorLogDataResponse"/></returns>
        public DescribeErrorLogDataResponse DescribeErrorLogDataSync(DescribeErrorLogDataRequest req)
        {
             JsonResponseModel<DescribeErrorLogDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeErrorLogData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeErrorLogDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeInstanceParamRecords) is used to query the parameter modification records of an instance.
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
        /// This API (DescribeInstanceParamRecords) is used to query the parameter modification records of an instance.
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
        /// This API (DescribeInstanceParams) is used to query the list of parameters for an instance.
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
        /// This API (DescribeInstanceParams) is used to query the list of parameters for an instance.
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
        /// This API is used to query the retention policy of local binlog of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="DescribeLocalBinlogConfigResponse"/></returns>
        public async Task<DescribeLocalBinlogConfigResponse> DescribeLocalBinlogConfig(DescribeLocalBinlogConfigRequest req)
        {
             JsonResponseModel<DescribeLocalBinlogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLocalBinlogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLocalBinlogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the retention policy of local binlog of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="DescribeLocalBinlogConfigResponse"/></returns>
        public DescribeLocalBinlogConfigResponse DescribeLocalBinlogConfigSync(DescribeLocalBinlogConfigRequest req)
        {
             JsonResponseModel<DescribeLocalBinlogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLocalBinlogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLocalBinlogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query parameter template details. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public async Task<DescribeParamTemplateInfoResponse> DescribeParamTemplateInfo(DescribeParamTemplateInfoRequest req)
        {
             JsonResponseModel<DescribeParamTemplateInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamTemplateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query parameter template details. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplateInfoRequest"/></param>
        /// <returns><see cref="DescribeParamTemplateInfoResponse"/></returns>
        public DescribeParamTemplateInfoResponse DescribeParamTemplateInfoSync(DescribeParamTemplateInfoRequest req)
        {
             JsonResponseModel<DescribeParamTemplateInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamTemplateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the parameter template list. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public async Task<DescribeParamTemplatesResponse> DescribeParamTemplates(DescribeParamTemplatesRequest req)
        {
             JsonResponseModel<DescribeParamTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the parameter template list. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParamTemplatesResponse"/></returns>
        public DescribeParamTemplatesResponse DescribeParamTemplatesSync(DescribeParamTemplatesRequest req)
        {
             JsonResponseModel<DescribeParamTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProjectSecurityGroups) is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public async Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeProjectSecurityGroups) is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeProjectSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjectSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+DescribeCdbProxyInfo+替代。
        /// 
        /// This API has been deprecated and replaced by the `DescribeCdbProxyInfo` API. 
        /// 
        /// This API is used to query the connection pool configuration of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyConnectionPoolConfRequest"/></param>
        /// <returns><see cref="DescribeProxyConnectionPoolConfResponse"/></returns>
        public async Task<DescribeProxyConnectionPoolConfResponse> DescribeProxyConnectionPoolConf(DescribeProxyConnectionPoolConfRequest req)
        {
             JsonResponseModel<DescribeProxyConnectionPoolConfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyConnectionPoolConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyConnectionPoolConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+DescribeCdbProxyInfo+替代。
        /// 
        /// This API has been deprecated and replaced by the `DescribeCdbProxyInfo` API. 
        /// 
        /// This API is used to query the connection pool configuration of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyConnectionPoolConfRequest"/></param>
        /// <returns><see cref="DescribeProxyConnectionPoolConfResponse"/></returns>
        public DescribeProxyConnectionPoolConfResponse DescribeProxyConnectionPoolConfSync(DescribeProxyConnectionPoolConfRequest req)
        {
             JsonResponseModel<DescribeProxyConnectionPoolConfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyConnectionPoolConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyConnectionPoolConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the proxy configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyCustomConfRequest"/></param>
        /// <returns><see cref="DescribeProxyCustomConfResponse"/></returns>
        public async Task<DescribeProxyCustomConfResponse> DescribeProxyCustomConf(DescribeProxyCustomConfRequest req)
        {
             JsonResponseModel<DescribeProxyCustomConfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyCustomConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyCustomConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the proxy configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyCustomConfRequest"/></param>
        /// <returns><see cref="DescribeProxyCustomConfResponse"/></returns>
        public DescribeProxyCustomConfResponse DescribeProxyCustomConfSync(DescribeProxyCustomConfRequest req)
        {
             JsonResponseModel<DescribeProxyCustomConfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyCustomConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyCustomConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the supported proxy versions and parameters for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySupportParamRequest"/></param>
        /// <returns><see cref="DescribeProxySupportParamResponse"/></returns>
        public async Task<DescribeProxySupportParamResponse> DescribeProxySupportParam(DescribeProxySupportParamRequest req)
        {
             JsonResponseModel<DescribeProxySupportParamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxySupportParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxySupportParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the supported proxy versions and parameters for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySupportParamRequest"/></param>
        /// <returns><see cref="DescribeProxySupportParamResponse"/></returns>
        public DescribeProxySupportParamResponse DescribeProxySupportParamSync(DescribeProxySupportParamRequest req)
        {
             JsonResponseModel<DescribeProxySupportParamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxySupportParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxySupportParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of a remote TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeRemoteBackupConfigResponse"/></returns>
        public async Task<DescribeRemoteBackupConfigResponse> DescribeRemoteBackupConfig(DescribeRemoteBackupConfigRequest req)
        {
             JsonResponseModel<DescribeRemoteBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRemoteBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRemoteBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of a remote TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="DescribeRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeRemoteBackupConfigResponse"/></returns>
        public DescribeRemoteBackupConfigResponse DescribeRemoteBackupConfigSync(DescribeRemoteBackupConfigRequest req)
        {
             JsonResponseModel<DescribeRemoteBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRemoteBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRemoteBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of all RO groups of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoGroupsRequest"/></param>
        /// <returns><see cref="DescribeRoGroupsResponse"/></returns>
        public async Task<DescribeRoGroupsResponse> DescribeRoGroups(DescribeRoGroupsRequest req)
        {
             JsonResponseModel<DescribeRoGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of all RO groups of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoGroupsRequest"/></param>
        /// <returns><see cref="DescribeRoGroupsResponse"/></returns>
        public DescribeRoGroupsResponse DescribeRoGroupsSync(DescribeRoGroupsRequest req)
        {
             JsonResponseModel<DescribeRoGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the minimum specification of a read-only instance that can be purchased or upgraded to.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoMinScaleRequest"/></param>
        /// <returns><see cref="DescribeRoMinScaleResponse"/></returns>
        public async Task<DescribeRoMinScaleResponse> DescribeRoMinScale(DescribeRoMinScaleRequest req)
        {
             JsonResponseModel<DescribeRoMinScaleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoMinScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoMinScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the minimum specification of a read-only instance that can be purchased or upgraded to.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoMinScaleRequest"/></param>
        /// <returns><see cref="DescribeRoMinScaleResponse"/></returns>
        public DescribeRoMinScaleResponse DescribeRoMinScaleSync(DescribeRoMinScaleRequest req)
        {
             JsonResponseModel<DescribeRoMinScaleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoMinScale");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoMinScaleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRollbackRangeTime) is used to query the time range available for instance rollback.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackRangeTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackRangeTimeResponse"/></returns>
        public async Task<DescribeRollbackRangeTimeResponse> DescribeRollbackRangeTime(DescribeRollbackRangeTimeRequest req)
        {
             JsonResponseModel<DescribeRollbackRangeTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRollbackRangeTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackRangeTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeRollbackRangeTime) is used to query the time range available for instance rollback.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackRangeTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackRangeTimeResponse"/></returns>
        public DescribeRollbackRangeTimeResponse DescribeRollbackRangeTimeSync(DescribeRollbackRangeTimeRequest req)
        {
             JsonResponseModel<DescribeRollbackRangeTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRollbackRangeTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackRangeTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a TencentDB instance rollback task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRollbackTaskDetailResponse"/></returns>
        public async Task<DescribeRollbackTaskDetailResponse> DescribeRollbackTaskDetail(DescribeRollbackTaskDetailRequest req)
        {
             JsonResponseModel<DescribeRollbackTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRollbackTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a TencentDB instance rollback task.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeRollbackTaskDetailResponse"/></returns>
        public DescribeRollbackTaskDetailResponse DescribeRollbackTaskDetailSync(DescribeRollbackTaskDetailRequest req)
        {
             JsonResponseModel<DescribeRollbackTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRollbackTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the slow logs of an instance over the past month by search criteria.
        /// Note: the HTTP response packet will be very large if it contain a single large slow log, which causes the API call to time out. If this happens, we recommend you lower the value of the input parameter `Limit` to reduce the packet size so that the API can respond timely.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogDataRequest"/></param>
        /// <returns><see cref="DescribeSlowLogDataResponse"/></returns>
        public async Task<DescribeSlowLogDataResponse> DescribeSlowLogData(DescribeSlowLogDataRequest req)
        {
             JsonResponseModel<DescribeSlowLogDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the slow logs of an instance over the past month by search criteria.
        /// Note: the HTTP response packet will be very large if it contain a single large slow log, which causes the API call to time out. If this happens, we recommend you lower the value of the input parameter `Limit` to reduce the packet size so that the API can respond timely.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogDataRequest"/></param>
        /// <returns><see cref="DescribeSlowLogDataResponse"/></returns>
        public DescribeSlowLogDataResponse DescribeSlowLogDataSync(DescribeSlowLogDataRequest req)
        {
             JsonResponseModel<DescribeSlowLogDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSlowLogs) is used to query the slow logs of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public async Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
             JsonResponseModel<DescribeSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSlowLogs) is used to query the slow logs of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
             JsonResponseModel<DescribeSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSupportedPrivileges) is used to query the information of TencentDB account permissions, including global permissions, database permissions, table permissions, and column permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeSupportedPrivilegesResponse"/></returns>
        public async Task<DescribeSupportedPrivilegesResponse> DescribeSupportedPrivileges(DescribeSupportedPrivilegesRequest req)
        {
             JsonResponseModel<DescribeSupportedPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSupportedPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSupportedPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeSupportedPrivileges) is used to query the information of TencentDB account permissions, including global permissions, database permissions, table permissions, and column permissions.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeSupportedPrivilegesResponse"/></returns>
        public DescribeSupportedPrivilegesResponse DescribeSupportedPrivilegesSync(DescribeSupportedPrivilegesRequest req)
        {
             JsonResponseModel<DescribeSupportedPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSupportedPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSupportedPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of database tables in a TencentDB instance. It only supports source or disaster recovery instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public async Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of database tables in a TencentDB instance. It only supports source or disaster recovery instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTagsOfInstanceIds) is used to query the tag information of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsOfInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeTagsOfInstanceIdsResponse"/></returns>
        public async Task<DescribeTagsOfInstanceIdsResponse> DescribeTagsOfInstanceIds(DescribeTagsOfInstanceIdsRequest req)
        {
             JsonResponseModel<DescribeTagsOfInstanceIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagsOfInstanceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsOfInstanceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTagsOfInstanceIds) is used to query the tag information of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsOfInstanceIdsRequest"/></param>
        /// <returns><see cref="DescribeTagsOfInstanceIdsResponse"/></returns>
        public DescribeTagsOfInstanceIdsResponse DescribeTagsOfInstanceIdsSync(DescribeTagsOfInstanceIdsRequest req)
        {
             JsonResponseModel<DescribeTagsOfInstanceIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagsOfInstanceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsOfInstanceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTasks) is used to query the list of tasks for a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTasks) is used to query the list of tasks for a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTimeWindow) is used to query the maintenance time window of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeTimeWindowResponse"/></returns>
        public async Task<DescribeTimeWindowResponse> DescribeTimeWindow(DescribeTimeWindowRequest req)
        {
             JsonResponseModel<DescribeTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeTimeWindow) is used to query the maintenance time window of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeTimeWindowRequest"/></param>
        /// <returns><see cref="DescribeTimeWindowResponse"/></returns>
        public DescribeTimeWindowResponse DescribeTimeWindowSync(DescribeTimeWindowRequest req)
        {
             JsonResponseModel<DescribeTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of SQL files imported by users. The common request parameter `Region` must be `ap-shanghai`.
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadedFilesRequest"/></param>
        /// <returns><see cref="DescribeUploadedFilesResponse"/></returns>
        public async Task<DescribeUploadedFilesResponse> DescribeUploadedFiles(DescribeUploadedFilesRequest req)
        {
             JsonResponseModel<DescribeUploadedFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUploadedFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUploadedFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of SQL files imported by users. The common request parameter `Region` must be `ap-shanghai`.
        /// </summary>
        /// <param name="req"><see cref="DescribeUploadedFilesRequest"/></param>
        /// <returns><see cref="DescribeUploadedFilesResponse"/></returns>
        public DescribeUploadedFilesResponse DescribeUploadedFilesSync(DescribeUploadedFilesRequest req)
        {
             JsonResponseModel<DescribeUploadedFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUploadedFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUploadedFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DisassociateSecurityGroups) is used to unbind security groups from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public async Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DisassociateSecurityGroups) is used to unbind security groups from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
             JsonResponseModel<DisassociateSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口不再维护，参考CreateDBInstance+API文档，在发货时即可完成初始化。
        /// 
        /// This API was disused. You can refer to the CreateDBInstance API, and initialize the instance when creating it.
        /// 
        /// This API is used to initialize a TencentDB instance, including initial password, default character set, and instance port number. But it is disused and not recommended. You can now set the instance information by using the parameter `Password`, `ParamList`, and `Port` respectively in the `CreateDBInstance` and `CreateDBInstanceHour` APIs.
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public async Task<InitDBInstancesResponse> InitDBInstances(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口不再维护，参考CreateDBInstance+API文档，在发货时即可完成初始化。
        /// 
        /// This API was disused. You can refer to the CreateDBInstance API, and initialize the instance when creating it.
        /// 
        /// This API is used to initialize a TencentDB instance, including initial password, default character set, and instance port number. But it is disused and not recommended. You can now set the instance information by using the parameter `Password`, `ParamList`, and `Port` respectively in the `CreateDBInstance` and `CreateDBInstanceHour` APIs.
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public InitDBInstancesResponse InitDBInstancesSync(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to isolate a TencentDB instance, which will no longer be accessible via IP and port. The isolated instance can be started up in the recycle bin. If it is isolated due to arrears, please top up your account as soon as possible.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public async Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
             JsonResponseModel<IsolateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to isolate a TencentDB instance, which will no longer be accessible via IP and port. The isolated instance can be started up in the recycle bin. If it is isolated due to arrears, please top up your account as soon as possible.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
             JsonResponseModel<IsolateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAccountDescription) is used to modify the remarks of a TencentDB instance account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public async Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAccountDescription) is used to modify the remarks of a TencentDB instance account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
             JsonResponseModel<ModifyAccountDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the maximum connections of one or more TencentDB instance accounts.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountMaxUserConnectionsRequest"/></param>
        /// <returns><see cref="ModifyAccountMaxUserConnectionsResponse"/></returns>
        public async Task<ModifyAccountMaxUserConnectionsResponse> ModifyAccountMaxUserConnections(ModifyAccountMaxUserConnectionsRequest req)
        {
             JsonResponseModel<ModifyAccountMaxUserConnectionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountMaxUserConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountMaxUserConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the maximum connections of one or more TencentDB instance accounts.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountMaxUserConnectionsRequest"/></param>
        /// <returns><see cref="ModifyAccountMaxUserConnectionsResponse"/></returns>
        public ModifyAccountMaxUserConnectionsResponse ModifyAccountMaxUserConnectionsSync(ModifyAccountMaxUserConnectionsRequest req)
        {
             JsonResponseModel<ModifyAccountMaxUserConnectionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountMaxUserConnections");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountMaxUserConnectionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAccountPassword) is used to modify the password of a TencentDB instance account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyAccountPasswordResponse"/></returns>
        public async Task<ModifyAccountPasswordResponse> ModifyAccountPassword(ModifyAccountPasswordRequest req)
        {
             JsonResponseModel<ModifyAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAccountPassword) is used to modify the password of a TencentDB instance account.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPasswordRequest"/></param>
        /// <returns><see cref="ModifyAccountPasswordResponse"/></returns>
        public ModifyAccountPasswordResponse ModifyAccountPasswordSync(ModifyAccountPasswordRequest req)
        {
             JsonResponseModel<ModifyAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the permissions of a TencentDB instance account.
        /// 
        /// Note that when modifying account permissions, you need to pass in the full permission information of the account. You can [query the account permission information
        /// ](https://intl.cloud.tencent.com/document/api/236/17500?from_cn_redirect=1) first before modifying permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public async Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the permissions of a TencentDB instance account.
        /// 
        /// Note that when modifying account permissions, you need to pass in the full permission information of the account. You can [query the account permission information
        /// ](https://intl.cloud.tencent.com/document/api/236/17500?from_cn_redirect=1) first before modifying permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the auto-renewal flag of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public async Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the auto-renewal flag of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
             JsonResponseModel<ModifyAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyBackupConfig) is used to modify the database backup configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public async Task<ModifyBackupConfigResponse> ModifyBackupConfig(ModifyBackupConfigRequest req)
        {
             JsonResponseModel<ModifyBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyBackupConfig) is used to modify the database backup configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyBackupConfigResponse"/></returns>
        public ModifyBackupConfigResponse ModifyBackupConfigSync(ModifyBackupConfigRequest req)
        {
             JsonResponseModel<ModifyBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the restrictions of downloading backups in a region. You can specify which types of networks (private, or both private and public), VPCs, and IPs to download backups.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public async Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<ModifyBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the restrictions of downloading backups in a region. You can specify which types of networks (private, or both private and public), VPCs, and IPs to download backups.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<ModifyBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default encryption status of an instance backup. 
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="ModifyBackupEncryptionStatusResponse"/></returns>
        public async Task<ModifyBackupEncryptionStatusResponse> ModifyBackupEncryptionStatus(ModifyBackupEncryptionStatusRequest req)
        {
             JsonResponseModel<ModifyBackupEncryptionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupEncryptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupEncryptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set the default encryption status of an instance backup. 
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupEncryptionStatusRequest"/></param>
        /// <returns><see cref="ModifyBackupEncryptionStatusResponse"/></returns>
        public ModifyBackupEncryptionStatusResponse ModifyBackupEncryptionStatusSync(ModifyBackupEncryptionStatusRequest req)
        {
             JsonResponseModel<ModifyBackupEncryptionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupEncryptionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupEncryptionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+AdjustCdbProxyAddress+进行替代。
        /// 
        /// This API has been deprecated and replaced with `AdjustCdbProxyAddress`. 
        /// 
        /// This API is used to configure the connection pool of database proxy. The supported configurations can be obtained by the `DescribeProxyConnectionPoolConf` API.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDBProxyConnectionPoolRequest"/></param>
        /// <returns><see cref="ModifyCDBProxyConnectionPoolResponse"/></returns>
        public async Task<ModifyCDBProxyConnectionPoolResponse> ModifyCDBProxyConnectionPool(ModifyCDBProxyConnectionPoolRequest req)
        {
             JsonResponseModel<ModifyCDBProxyConnectionPoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCDBProxyConnectionPool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCDBProxyConnectionPoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+AdjustCdbProxyAddress+进行替代。
        /// 
        /// This API has been deprecated and replaced with `AdjustCdbProxyAddress`. 
        /// 
        /// This API is used to configure the connection pool of database proxy. The supported configurations can be obtained by the `DescribeProxyConnectionPoolConf` API.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDBProxyConnectionPoolRequest"/></param>
        /// <returns><see cref="ModifyCDBProxyConnectionPoolResponse"/></returns>
        public ModifyCDBProxyConnectionPoolResponse ModifyCDBProxyConnectionPoolSync(ModifyCDBProxyConnectionPoolRequest req)
        {
             JsonResponseModel<ModifyCDBProxyConnectionPoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCDBProxyConnectionPool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCDBProxyConnectionPoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+ModifyCdbProxyAddressDesc+进行替代。
        /// 
        /// This API has been deprecated and replaced with `ModifyCdbProxyAddressDesc`. 
        /// 
        /// This API is used to modify the description of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDBProxyDescRequest"/></param>
        /// <returns><see cref="ModifyCDBProxyDescResponse"/></returns>
        public async Task<ModifyCDBProxyDescResponse> ModifyCDBProxyDesc(ModifyCDBProxyDescRequest req)
        {
             JsonResponseModel<ModifyCDBProxyDescResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCDBProxyDesc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCDBProxyDescResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+ModifyCdbProxyAddressDesc+进行替代。
        /// 
        /// This API has been deprecated and replaced with `ModifyCdbProxyAddressDesc`. 
        /// 
        /// This API is used to modify the description of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDBProxyDescRequest"/></param>
        /// <returns><see cref="ModifyCDBProxyDescResponse"/></returns>
        public ModifyCDBProxyDescResponse ModifyCDBProxyDescSync(ModifyCDBProxyDescRequest req)
        {
             JsonResponseModel<ModifyCDBProxyDescResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCDBProxyDesc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCDBProxyDescResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+ModifyCdbProxyAddressVipAndVPort+进行替代。
        /// 
        /// This API has been deprecated and replaced with `ModifyCdbProxyAddressVipAndVPort`. 
        /// 
        /// This API is used to modify the VIP or the port of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDBProxyVipVPortRequest"/></param>
        /// <returns><see cref="ModifyCDBProxyVipVPortResponse"/></returns>
        public async Task<ModifyCDBProxyVipVPortResponse> ModifyCDBProxyVipVPort(ModifyCDBProxyVipVPortRequest req)
        {
             JsonResponseModel<ModifyCDBProxyVipVPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCDBProxyVipVPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCDBProxyVipVPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+ModifyCdbProxyAddressVipAndVPort+进行替代。
        /// 
        /// This API has been deprecated and replaced with `ModifyCdbProxyAddressVipAndVPort`. 
        /// 
        /// This API is used to modify the VIP or the port of a database proxy.
        /// </summary>
        /// <param name="req"><see cref="ModifyCDBProxyVipVPortRequest"/></param>
        /// <returns><see cref="ModifyCDBProxyVipVPortResponse"/></returns>
        public ModifyCDBProxyVipVPortResponse ModifyCDBProxyVipVPortSync(ModifyCDBProxyVipVPortRequest req)
        {
             JsonResponseModel<ModifyCDBProxyVipVPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCDBProxyVipVPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCDBProxyVipVPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the description of a proxy address.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressDescRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressDescResponse"/></returns>
        public async Task<ModifyCdbProxyAddressDescResponse> ModifyCdbProxyAddressDesc(ModifyCdbProxyAddressDescRequest req)
        {
             JsonResponseModel<ModifyCdbProxyAddressDescResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCdbProxyAddressDesc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCdbProxyAddressDescResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the description of a proxy address.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressDescRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressDescResponse"/></returns>
        public ModifyCdbProxyAddressDescResponse ModifyCdbProxyAddressDescSync(ModifyCdbProxyAddressDescRequest req)
        {
             JsonResponseModel<ModifyCdbProxyAddressDescResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCdbProxyAddressDesc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCdbProxyAddressDescResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC of the database proxy address.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressVipAndVPortRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressVipAndVPortResponse"/></returns>
        public async Task<ModifyCdbProxyAddressVipAndVPortResponse> ModifyCdbProxyAddressVipAndVPort(ModifyCdbProxyAddressVipAndVPortRequest req)
        {
             JsonResponseModel<ModifyCdbProxyAddressVipAndVPortResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCdbProxyAddressVipAndVPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCdbProxyAddressVipAndVPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the VPC of the database proxy address.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyAddressVipAndVPortRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyAddressVipAndVPortResponse"/></returns>
        public ModifyCdbProxyAddressVipAndVPortResponse ModifyCdbProxyAddressVipAndVPortSync(ModifyCdbProxyAddressVipAndVPortRequest req)
        {
             JsonResponseModel<ModifyCdbProxyAddressVipAndVPortResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCdbProxyAddressVipAndVPort");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCdbProxyAddressVipAndVPortResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure the database proxy parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyParamRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyParamResponse"/></returns>
        public async Task<ModifyCdbProxyParamResponse> ModifyCdbProxyParam(ModifyCdbProxyParamRequest req)
        {
             JsonResponseModel<ModifyCdbProxyParamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCdbProxyParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCdbProxyParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure the database proxy parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyCdbProxyParamRequest"/></param>
        /// <returns><see cref="ModifyCdbProxyParamResponse"/></returns>
        public ModifyCdbProxyParamResponse ModifyCdbProxyParamSync(ModifyCdbProxyParamRequest req)
        {
             JsonResponseModel<ModifyCdbProxyParamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCdbProxyParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCdbProxyParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDBInstanceName) is used to rename a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public async Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDBInstanceName) is used to rename a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDBInstanceProject) is used to modify the project to which a TencentDB instance belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public async Task<ModifyDBInstanceProjectResponse> ModifyDBInstanceProject(ModifyDBInstanceProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstanceProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDBInstanceProject) is used to modify the project to which a TencentDB instance belongs.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceProjectResponse"/></returns>
        public ModifyDBInstanceProjectResponse ModifyDBInstanceProjectSync(ModifyDBInstanceProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstanceProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDBInstanceSecurityGroups) is used to modify the security groups bound to a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public async Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDBInstanceSecurityGroups) is used to modify the security groups bound to a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the IP and port number of a TencentDB instance, switch from classic network to VPC, or change VPC subnets.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVipVportRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVipVportResponse"/></returns>
        public async Task<ModifyDBInstanceVipVportResponse> ModifyDBInstanceVipVport(ModifyDBInstanceVipVportRequest req)
        {
             JsonResponseModel<ModifyDBInstanceVipVportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceVipVport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceVipVportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the IP and port number of a TencentDB instance, switch from classic network to VPC, or change VPC subnets.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceVipVportRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceVipVportResponse"/></returns>
        public ModifyDBInstanceVipVportResponse ModifyDBInstanceVipVportSync(ModifyDBInstanceVipVportRequest req)
        {
             JsonResponseModel<ModifyDBInstanceVipVportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceVipVport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceVipVportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyInstanceParam) is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public async Task<ModifyInstanceParamResponse> ModifyInstanceParam(ModifyInstanceParamRequest req)
        {
             JsonResponseModel<ModifyInstanceParamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyInstanceParam) is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamResponse"/></returns>
        public ModifyInstanceParamResponse ModifyInstanceParamSync(ModifyInstanceParamRequest req)
        {
             JsonResponseModel<ModifyInstanceParamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceParam");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceParamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the password complexity of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyInstancePasswordComplexityResponse"/></returns>
        public async Task<ModifyInstancePasswordComplexityResponse> ModifyInstancePasswordComplexity(ModifyInstancePasswordComplexityRequest req)
        {
             JsonResponseModel<ModifyInstancePasswordComplexityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstancePasswordComplexity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancePasswordComplexityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the password complexity of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstancePasswordComplexityRequest"/></param>
        /// <returns><see cref="ModifyInstancePasswordComplexityResponse"/></returns>
        public ModifyInstancePasswordComplexityResponse ModifyInstancePasswordComplexitySync(ModifyInstancePasswordComplexityRequest req)
        {
             JsonResponseModel<ModifyInstancePasswordComplexityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstancePasswordComplexity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstancePasswordComplexityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyInstanceTag) is used to add, modify, or delete an instance tag.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTagRequest"/></param>
        /// <returns><see cref="ModifyInstanceTagResponse"/></returns>
        public async Task<ModifyInstanceTagResponse> ModifyInstanceTag(ModifyInstanceTagRequest req)
        {
             JsonResponseModel<ModifyInstanceTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyInstanceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyInstanceTag) is used to add, modify, or delete an instance tag.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceTagRequest"/></param>
        /// <returns><see cref="ModifyInstanceTagResponse"/></returns>
        public ModifyInstanceTagResponse ModifyInstanceTagSync(ModifyInstanceTagRequest req)
        {
             JsonResponseModel<ModifyInstanceTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyInstanceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyInstanceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the retention policy of local binlog of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="ModifyLocalBinlogConfigResponse"/></returns>
        public async Task<ModifyLocalBinlogConfigResponse> ModifyLocalBinlogConfig(ModifyLocalBinlogConfigRequest req)
        {
             JsonResponseModel<ModifyLocalBinlogConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLocalBinlogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLocalBinlogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the retention policy of local binlog of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyLocalBinlogConfigRequest"/></param>
        /// <returns><see cref="ModifyLocalBinlogConfigResponse"/></returns>
        public ModifyLocalBinlogConfigResponse ModifyLocalBinlogConfigSync(ModifyLocalBinlogConfigRequest req)
        {
             JsonResponseModel<ModifyLocalBinlogConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLocalBinlogConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLocalBinlogConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the name or description of a placement group.
        /// </summary>
        /// <param name="req"><see cref="ModifyNameOrDescByDpIdRequest"/></param>
        /// <returns><see cref="ModifyNameOrDescByDpIdResponse"/></returns>
        public async Task<ModifyNameOrDescByDpIdResponse> ModifyNameOrDescByDpId(ModifyNameOrDescByDpIdRequest req)
        {
             JsonResponseModel<ModifyNameOrDescByDpIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNameOrDescByDpId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNameOrDescByDpIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the name or description of a placement group.
        /// </summary>
        /// <param name="req"><see cref="ModifyNameOrDescByDpIdRequest"/></param>
        /// <returns><see cref="ModifyNameOrDescByDpIdResponse"/></returns>
        public ModifyNameOrDescByDpIdResponse ModifyNameOrDescByDpIdSync(ModifyNameOrDescByDpIdRequest req)
        {
             JsonResponseModel<ModifyNameOrDescByDpIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNameOrDescByDpId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNameOrDescByDpIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a parameter template. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public async Task<ModifyParamTemplateResponse> ModifyParamTemplate(ModifyParamTemplateRequest req)
        {
             JsonResponseModel<ModifyParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a parameter template. The common request parameter `Region` can only be set to `ap-guangzhou`.
        /// </summary>
        /// <param name="req"><see cref="ModifyParamTemplateRequest"/></param>
        /// <returns><see cref="ModifyParamTemplateResponse"/></returns>
        public ModifyParamTemplateResponse ModifyParamTemplateSync(ModifyParamTemplateRequest req)
        {
             JsonResponseModel<ModifyParamTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyParamTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParamTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration information of a remote TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyRemoteBackupConfigResponse"/></returns>
        public async Task<ModifyRemoteBackupConfigResponse> ModifyRemoteBackupConfig(ModifyRemoteBackupConfigRequest req)
        {
             JsonResponseModel<ModifyRemoteBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRemoteBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRemoteBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration information of a remote TencentDB instance backup.
        /// </summary>
        /// <param name="req"><see cref="ModifyRemoteBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyRemoteBackupConfigResponse"/></returns>
        public ModifyRemoteBackupConfigResponse ModifyRemoteBackupConfigSync(ModifyRemoteBackupConfigRequest req)
        {
             JsonResponseModel<ModifyRemoteBackupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRemoteBackupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRemoteBackupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of a TencentDB RO group, such as configuring a read-only instance removal policy in case of excessive delay, setting read weights of read-only instances, and setting the replication delay.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyRoGroupInfoResponse"/></returns>
        public async Task<ModifyRoGroupInfoResponse> ModifyRoGroupInfo(ModifyRoGroupInfoRequest req)
        {
             JsonResponseModel<ModifyRoGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRoGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update the information of a TencentDB RO group, such as configuring a read-only instance removal policy in case of excessive delay, setting read weights of read-only instances, and setting the replication delay.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyRoGroupInfoResponse"/></returns>
        public ModifyRoGroupInfoResponse ModifyRoGroupInfoSync(ModifyRoGroupInfoRequest req)
        {
             JsonResponseModel<ModifyRoGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRoGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyTimeWindow) is used to update the maintenance time window of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyTimeWindowResponse"/></returns>
        public async Task<ModifyTimeWindowResponse> ModifyTimeWindow(ModifyTimeWindowRequest req)
        {
             JsonResponseModel<ModifyTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyTimeWindow) is used to update the maintenance time window of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyTimeWindowRequest"/></param>
        /// <returns><see cref="ModifyTimeWindowResponse"/></returns>
        public ModifyTimeWindowResponse ModifyTimeWindowSync(ModifyTimeWindowRequest req)
        {
             JsonResponseModel<ModifyTimeWindowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTimeWindow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTimeWindowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (OfflineIsolatedInstances) is used to deactivate isolated TencentDB instances immediately. The instances must be in isolated status, i.e., their `Status` value is 5 in the return of the [instance list querying API](https://intl.cloud.tencent.com/document/api/236/15872?from_cn_redirect=1).
        /// 
        /// This is an asynchronous API. There may be a delay in repossessing some resources. You can query the details by using the [instance list querying API](https://intl.cloud.tencent.com/document/api/236/15872?from_cn_redirect=1) and specifying the InstanceId and the `Status` value as [5, 6, 7]. If the returned instance is empty, then all its resources have been released.
        /// 
        /// Note that once an instance is deactivated, its resources and data will not be recoverable. Please do so with caution.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedInstancesRequest"/></param>
        /// <returns><see cref="OfflineIsolatedInstancesResponse"/></returns>
        public async Task<OfflineIsolatedInstancesResponse> OfflineIsolatedInstances(OfflineIsolatedInstancesRequest req)
        {
             JsonResponseModel<OfflineIsolatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OfflineIsolatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineIsolatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (OfflineIsolatedInstances) is used to deactivate isolated TencentDB instances immediately. The instances must be in isolated status, i.e., their `Status` value is 5 in the return of the [instance list querying API](https://intl.cloud.tencent.com/document/api/236/15872?from_cn_redirect=1).
        /// 
        /// This is an asynchronous API. There may be a delay in repossessing some resources. You can query the details by using the [instance list querying API](https://intl.cloud.tencent.com/document/api/236/15872?from_cn_redirect=1) and specifying the InstanceId and the `Status` value as [5, 6, 7]. If the returned instance is empty, then all its resources have been released.
        /// 
        /// Note that once an instance is deactivated, its resources and data will not be recoverable. Please do so with caution.
        /// </summary>
        /// <param name="req"><see cref="OfflineIsolatedInstancesRequest"/></param>
        /// <returns><see cref="OfflineIsolatedInstancesResponse"/></returns>
        public OfflineIsolatedInstancesResponse OfflineIsolatedInstancesSync(OfflineIsolatedInstancesRequest req)
        {
             JsonResponseModel<OfflineIsolatedInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OfflineIsolatedInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OfflineIsolatedInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the audit service.
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public async Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
             JsonResponseModel<OpenAuditServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenAuditService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenAuditServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the audit service.
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
             JsonResponseModel<OpenAuditServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenAuditService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenAuditServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the encryption feature for instance data storage, and custom keys are supported.
        /// 
        /// Note: Before enabling data storage encryption for an instance, you need to perform the following operations:
        /// 
        /// 1. [Initialize an instance](https://intl.cloud.tencent.com/document/api/236/15873?from_cn_redirect=1).
        /// 
        /// 2. Enable [KMS service](https://console.cloud.tencent.com/kms2)
        /// 
        /// 3. [Grant permission to access KMS](https://console.cloud.tencent.com/cam/role) for TencentDB for MySQL. The role name is `MySQL_QCSRole`, and the preset policy name is `QcloudAccessForMySQLRole`.
        /// 
        /// This API calling may take up to 10 seconds, causing the client to time out. If it returns `InternalError`, call `DescribeDBInstanceInfo` to confirm whether the backend encryption is enabled successfully.
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceEncryptionRequest"/></param>
        /// <returns><see cref="OpenDBInstanceEncryptionResponse"/></returns>
        public async Task<OpenDBInstanceEncryptionResponse> OpenDBInstanceEncryption(OpenDBInstanceEncryptionRequest req)
        {
             JsonResponseModel<OpenDBInstanceEncryptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenDBInstanceEncryption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBInstanceEncryptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the encryption feature for instance data storage, and custom keys are supported.
        /// 
        /// Note: Before enabling data storage encryption for an instance, you need to perform the following operations:
        /// 
        /// 1. [Initialize an instance](https://intl.cloud.tencent.com/document/api/236/15873?from_cn_redirect=1).
        /// 
        /// 2. Enable [KMS service](https://console.cloud.tencent.com/kms2)
        /// 
        /// 3. [Grant permission to access KMS](https://console.cloud.tencent.com/cam/role) for TencentDB for MySQL. The role name is `MySQL_QCSRole`, and the preset policy name is `QcloudAccessForMySQLRole`.
        /// 
        /// This API calling may take up to 10 seconds, causing the client to time out. If it returns `InternalError`, call `DescribeDBInstanceInfo` to confirm whether the backend encryption is enabled successfully.
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceEncryptionRequest"/></param>
        /// <returns><see cref="OpenDBInstanceEncryptionResponse"/></returns>
        public OpenDBInstanceEncryptionResponse OpenDBInstanceEncryptionSync(OpenDBInstanceEncryptionRequest req)
        {
             JsonResponseModel<OpenDBInstanceEncryptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenDBInstanceEncryption");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBInstanceEncryptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (OpenDBInstanceGTID) is used to enable GTID for a TencentDB instance. Only instances on or above version 5.6 are supported.
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="OpenDBInstanceGTIDResponse"/></returns>
        public async Task<OpenDBInstanceGTIDResponse> OpenDBInstanceGTID(OpenDBInstanceGTIDRequest req)
        {
             JsonResponseModel<OpenDBInstanceGTIDResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenDBInstanceGTID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBInstanceGTIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (OpenDBInstanceGTID) is used to enable GTID for a TencentDB instance. Only instances on or above version 5.6 are supported.
        /// </summary>
        /// <param name="req"><see cref="OpenDBInstanceGTIDRequest"/></param>
        /// <returns><see cref="OpenDBInstanceGTIDResponse"/></returns>
        public OpenDBInstanceGTIDResponse OpenDBInstanceGTIDSync(OpenDBInstanceGTIDRequest req)
        {
             JsonResponseModel<OpenDBInstanceGTIDResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenDBInstanceGTID");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBInstanceGTIDResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (OpenWanService) is used to enable public network access for an instance.
        /// 
        /// Note that before enabling public network access, you need to first [initialize the instance](https://intl.cloud.tencent.com/document/api/236/15873?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="OpenWanServiceRequest"/></param>
        /// <returns><see cref="OpenWanServiceResponse"/></returns>
        public async Task<OpenWanServiceResponse> OpenWanService(OpenWanServiceRequest req)
        {
             JsonResponseModel<OpenWanServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenWanService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenWanServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (OpenWanService) is used to enable public network access for an instance.
        /// 
        /// Note that before enabling public network access, you need to first [initialize the instance](https://intl.cloud.tencent.com/document/api/236/15873?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="OpenWanServiceRequest"/></param>
        /// <returns><see cref="OpenWanServiceResponse"/></returns>
        public OpenWanServiceResponse OpenWanServiceSync(OpenWanServiceRequest req)
        {
             JsonResponseModel<OpenWanServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenWanService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenWanServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+DescribeCdbProxyInfo+进行替代。
        /// 
        /// This API has been deprecated and replaced with `DescribeCdbProxyInfo`. 
        /// 
        /// This API is used to query the proxy details.
        /// </summary>
        /// <param name="req"><see cref="QueryCDBProxyRequest"/></param>
        /// <returns><see cref="QueryCDBProxyResponse"/></returns>
        public async Task<QueryCDBProxyResponse> QueryCDBProxy(QueryCDBProxyRequest req)
        {
             JsonResponseModel<QueryCDBProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCDBProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCDBProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 当前接口已经废弃，请使用+DescribeCdbProxyInfo+进行替代。
        /// 
        /// This API has been deprecated and replaced with `DescribeCdbProxyInfo`. 
        /// 
        /// This API is used to query the proxy details.
        /// </summary>
        /// <param name="req"><see cref="QueryCDBProxyRequest"/></param>
        /// <returns><see cref="QueryCDBProxyResponse"/></returns>
        public QueryCDBProxyResponse QueryCDBProxySync(QueryCDBProxyRequest req)
        {
             JsonResponseModel<QueryCDBProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCDBProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCDBProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deisolate an isolated TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ReleaseIsolatedDBInstancesRequest"/></param>
        /// <returns><see cref="ReleaseIsolatedDBInstancesResponse"/></returns>
        public async Task<ReleaseIsolatedDBInstancesResponse> ReleaseIsolatedDBInstances(ReleaseIsolatedDBInstancesRequest req)
        {
             JsonResponseModel<ReleaseIsolatedDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReleaseIsolatedDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseIsolatedDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to deisolate an isolated TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ReleaseIsolatedDBInstancesRequest"/></param>
        /// <returns><see cref="ReleaseIsolatedDBInstancesResponse"/></returns>
        public ReleaseIsolatedDBInstancesResponse ReleaseIsolatedDBInstancesSync(ReleaseIsolatedDBInstancesRequest req)
        {
             JsonResponseModel<ReleaseIsolatedDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReleaseIsolatedDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReleaseIsolatedDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rebalance the load on database proxy.
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public async Task<ReloadBalanceProxyNodeResponse> ReloadBalanceProxyNode(ReloadBalanceProxyNodeRequest req)
        {
             JsonResponseModel<ReloadBalanceProxyNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReloadBalanceProxyNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReloadBalanceProxyNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rebalance the load on database proxy.
        /// </summary>
        /// <param name="req"><see cref="ReloadBalanceProxyNodeRequest"/></param>
        /// <returns><see cref="ReloadBalanceProxyNodeResponse"/></returns>
        public ReloadBalanceProxyNodeResponse ReloadBalanceProxyNodeSync(ReloadBalanceProxyNodeRequest req)
        {
             JsonResponseModel<ReloadBalanceProxyNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReloadBalanceProxyNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReloadBalanceProxyNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew a monthly subscribed TencentDB instance, and a pay-as-you-go instance can be renewed as a monthly subscribed one by this API.
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public async Task<RenewDBInstanceResponse> RenewDBInstance(RenewDBInstanceRequest req)
        {
             JsonResponseModel<RenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew a monthly subscribed TencentDB instance, and a pay-as-you-go instance can be renewed as a monthly subscribed one by this API.
        /// </summary>
        /// <param name="req"><see cref="RenewDBInstanceRequest"/></param>
        /// <returns><see cref="RenewDBInstanceResponse"/></returns>
        public RenewDBInstanceResponse RenewDBInstanceSync(RenewDBInstanceRequest req)
        {
             JsonResponseModel<RenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the root account and initialize the account permissions.
        /// </summary>
        /// <param name="req"><see cref="ResetRootAccountRequest"/></param>
        /// <returns><see cref="ResetRootAccountResponse"/></returns>
        public async Task<ResetRootAccountResponse> ResetRootAccount(ResetRootAccountRequest req)
        {
             JsonResponseModel<ResetRootAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetRootAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRootAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the root account and initialize the account permissions.
        /// </summary>
        /// <param name="req"><see cref="ResetRootAccountRequest"/></param>
        /// <returns><see cref="ResetRootAccountResponse"/></returns>
        public ResetRootAccountResponse ResetRootAccountSync(ResetRootAccountRequest req)
        {
             JsonResponseModel<ResetRootAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetRootAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetRootAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (RestartDBInstances) is used to restart TencentDB instances.
        /// 
        /// Note:
        /// 1. This API only supports restarting primary instances.
        /// 2. The instance status must be normal, and no other async tasks are in progress.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public async Task<RestartDBInstancesResponse> RestartDBInstances(RestartDBInstancesRequest req)
        {
             JsonResponseModel<RestartDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (RestartDBInstances) is used to restart TencentDB instances.
        /// 
        /// Note:
        /// 1. This API only supports restarting primary instances.
        /// 2. The instance status must be normal, and no other async tasks are in progress.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstancesRequest"/></param>
        /// <returns><see cref="RestartDBInstancesResponse"/></returns>
        public RestartDBInstancesResponse RestartDBInstancesSync(RestartDBInstancesRequest req)
        {
             JsonResponseModel<RestartDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (StartBatchRollback) is used to roll back the tables of a TencentDB instance in batches.
        /// </summary>
        /// <param name="req"><see cref="StartBatchRollbackRequest"/></param>
        /// <returns><see cref="StartBatchRollbackResponse"/></returns>
        public async Task<StartBatchRollbackResponse> StartBatchRollback(StartBatchRollbackRequest req)
        {
             JsonResponseModel<StartBatchRollbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartBatchRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartBatchRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (StartBatchRollback) is used to roll back the tables of a TencentDB instance in batches.
        /// </summary>
        /// <param name="req"><see cref="StartBatchRollbackRequest"/></param>
        /// <returns><see cref="StartBatchRollbackResponse"/></returns>
        public StartBatchRollbackResponse StartBatchRollbackSync(StartBatchRollbackRequest req)
        {
             JsonResponseModel<StartBatchRollbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartBatchRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartBatchRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start the data replication from the source instance to the read-only instance.
        /// </summary>
        /// <param name="req"><see cref="StartReplicationRequest"/></param>
        /// <returns><see cref="StartReplicationResponse"/></returns>
        public async Task<StartReplicationResponse> StartReplication(StartReplicationRequest req)
        {
             JsonResponseModel<StartReplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start the data replication from the source instance to the read-only instance.
        /// </summary>
        /// <param name="req"><see cref="StartReplicationRequest"/></param>
        /// <returns><see cref="StartReplicationResponse"/></returns>
        public StartReplicationResponse StartReplicationSync(StartReplicationRequest req)
        {
             JsonResponseModel<StartReplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (StopDBImportJob) is used to stop a data import task.
        /// </summary>
        /// <param name="req"><see cref="StopDBImportJobRequest"/></param>
        /// <returns><see cref="StopDBImportJobResponse"/></returns>
        public async Task<StopDBImportJobResponse> StopDBImportJob(StopDBImportJobRequest req)
        {
             JsonResponseModel<StopDBImportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopDBImportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopDBImportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (StopDBImportJob) is used to stop a data import task.
        /// </summary>
        /// <param name="req"><see cref="StopDBImportJobRequest"/></param>
        /// <returns><see cref="StopDBImportJobResponse"/></returns>
        public StopDBImportJobResponse StopDBImportJobSync(StopDBImportJobRequest req)
        {
             JsonResponseModel<StopDBImportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopDBImportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopDBImportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop the data replication from the source instance to the read-only instance.
        /// </summary>
        /// <param name="req"><see cref="StopReplicationRequest"/></param>
        /// <returns><see cref="StopReplicationResponse"/></returns>
        public async Task<StopReplicationResponse> StopReplication(StopReplicationRequest req)
        {
             JsonResponseModel<StopReplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop the data replication from the source instance to the read-only instance.
        /// </summary>
        /// <param name="req"><see cref="StopReplicationRequest"/></param>
        /// <returns><see cref="StopReplicationResponse"/></returns>
        public StopReplicationResponse StopReplicationSync(StopReplicationRequest req)
        {
             JsonResponseModel<StopReplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopReplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopReplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a rollback task in progress, and returns an async task ID. You can use the `DescribeAsyncRequestInfo` API to query the result of cancellation.
        /// </summary>
        /// <param name="req"><see cref="StopRollbackRequest"/></param>
        /// <returns><see cref="StopRollbackResponse"/></returns>
        public async Task<StopRollbackResponse> StopRollback(StopRollbackRequest req)
        {
             JsonResponseModel<StopRollbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a rollback task in progress, and returns an async task ID. You can use the `DescribeAsyncRequestInfo` API to query the result of cancellation.
        /// </summary>
        /// <param name="req"><see cref="StopRollbackRequest"/></param>
        /// <returns><see cref="StopRollbackResponse"/></returns>
        public StopRollbackResponse StopRollbackSync(StopRollbackRequest req)
        {
             JsonResponseModel<StopRollbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch database proxy after the proxy configuration is modified or the proxy version is upgraded.
        /// </summary>
        /// <param name="req"><see cref="SwitchCDBProxyRequest"/></param>
        /// <returns><see cref="SwitchCDBProxyResponse"/></returns>
        public async Task<SwitchCDBProxyResponse> SwitchCDBProxy(SwitchCDBProxyRequest req)
        {
             JsonResponseModel<SwitchCDBProxyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchCDBProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchCDBProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch database proxy after the proxy configuration is modified or the proxy version is upgraded.
        /// </summary>
        /// <param name="req"><see cref="SwitchCDBProxyRequest"/></param>
        /// <returns><see cref="SwitchCDBProxyResponse"/></returns>
        public SwitchCDBProxyResponse SwitchCDBProxySync(SwitchCDBProxyRequest req)
        {
             JsonResponseModel<SwitchCDBProxyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchCDBProxy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchCDBProxyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for source-to-replica switch.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceMasterSlaveRequest"/></param>
        /// <returns><see cref="SwitchDBInstanceMasterSlaveResponse"/></returns>
        public async Task<SwitchDBInstanceMasterSlaveResponse> SwitchDBInstanceMasterSlave(SwitchDBInstanceMasterSlaveRequest req)
        {
             JsonResponseModel<SwitchDBInstanceMasterSlaveResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDBInstanceMasterSlave");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDBInstanceMasterSlaveResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used for source-to-replica switch.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceMasterSlaveRequest"/></param>
        /// <returns><see cref="SwitchDBInstanceMasterSlaveResponse"/></returns>
        public SwitchDBInstanceMasterSlaveResponse SwitchDBInstanceMasterSlaveSync(SwitchDBInstanceMasterSlaveRequest req)
        {
             JsonResponseModel<SwitchDBInstanceMasterSlaveResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDBInstanceMasterSlave");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDBInstanceMasterSlaveResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to promote a disaster recovery instance to source instance. The request parameter `Region` must be the region of the disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="SwitchDrInstanceToMasterRequest"/></param>
        /// <returns><see cref="SwitchDrInstanceToMasterResponse"/></returns>
        public async Task<SwitchDrInstanceToMasterResponse> SwitchDrInstanceToMaster(SwitchDrInstanceToMasterRequest req)
        {
             JsonResponseModel<SwitchDrInstanceToMasterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDrInstanceToMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDrInstanceToMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to promote a disaster recovery instance to source instance. The request parameter `Region` must be the region of the disaster recovery instance.
        /// </summary>
        /// <param name="req"><see cref="SwitchDrInstanceToMasterRequest"/></param>
        /// <returns><see cref="SwitchDrInstanceToMasterResponse"/></returns>
        public SwitchDrInstanceToMasterResponse SwitchDrInstanceToMasterSync(SwitchDrInstanceToMasterRequest req)
        {
             JsonResponseModel<SwitchDrInstanceToMasterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDrInstanceToMaster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDrInstanceToMasterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (SwitchForUpgrade) is used to switch to a new instance. You can initiate this process when the primary instance being upgraded is pending switch.
        /// </summary>
        /// <param name="req"><see cref="SwitchForUpgradeRequest"/></param>
        /// <returns><see cref="SwitchForUpgradeResponse"/></returns>
        public async Task<SwitchForUpgradeResponse> SwitchForUpgrade(SwitchForUpgradeRequest req)
        {
             JsonResponseModel<SwitchForUpgradeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchForUpgrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchForUpgradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (SwitchForUpgrade) is used to switch to a new instance. You can initiate this process when the primary instance being upgraded is pending switch.
        /// </summary>
        /// <param name="req"><see cref="SwitchForUpgradeRequest"/></param>
        /// <returns><see cref="SwitchForUpgradeResponse"/></returns>
        public SwitchForUpgradeResponse SwitchForUpgradeSync(SwitchForUpgradeRequest req)
        {
             JsonResponseModel<SwitchForUpgradeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchForUpgrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchForUpgradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade the version of database proxy.
        /// </summary>
        /// <param name="req"><see cref="UpgradeCDBProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeCDBProxyVersionResponse"/></returns>
        public async Task<UpgradeCDBProxyVersionResponse> UpgradeCDBProxyVersion(UpgradeCDBProxyVersionRequest req)
        {
             JsonResponseModel<UpgradeCDBProxyVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeCDBProxyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeCDBProxyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade the version of database proxy.
        /// </summary>
        /// <param name="req"><see cref="UpgradeCDBProxyVersionRequest"/></param>
        /// <returns><see cref="UpgradeCDBProxyVersionResponse"/></returns>
        public UpgradeCDBProxyVersionResponse UpgradeCDBProxyVersionSync(UpgradeCDBProxyVersionRequest req)
        {
             JsonResponseModel<UpgradeCDBProxyVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeCDBProxyVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeCDBProxyVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade or downgrade a TencentDB instance, which can be a primary instance, disaster recovery instance, or read-only instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public async Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade or downgrade a TencentDB instance, which can be a primary instance, disaster recovery instance, or read-only instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UpgradeDBInstanceEngineVersion) is used to upgrade the version of a TencentDB instance, which can be a primary instance, disaster recovery instance, or read-only instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceEngineVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceEngineVersionResponse"/></returns>
        public async Task<UpgradeDBInstanceEngineVersionResponse> UpgradeDBInstanceEngineVersion(UpgradeDBInstanceEngineVersionRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceEngineVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstanceEngineVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceEngineVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UpgradeDBInstanceEngineVersion) is used to upgrade the version of a TencentDB instance, which can be a primary instance, disaster recovery instance, or read-only instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceEngineVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceEngineVersionResponse"/></returns>
        public UpgradeDBInstanceEngineVersionResponse UpgradeDBInstanceEngineVersionSync(UpgradeDBInstanceEngineVersionRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceEngineVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstanceEngineVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceEngineVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
