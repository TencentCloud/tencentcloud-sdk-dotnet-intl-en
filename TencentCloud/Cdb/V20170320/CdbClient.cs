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
        /// This API (CreateAccounts) is used to create TencentDB accounts. The new account names, domain names, and passwords need to be specified, and account remarks can also be added.
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
        /// This API is used to create a placement group for placing instances.
        /// </summary>
        /// <param name="req"><see cref="CreateDeployGroupRequest"/></param>
        /// <returns><see cref="CreateDeployGroupResponse"/></returns>
        public async Task<CreateDeployGroupResponse> CreateDeployGroup(CreateDeployGroupRequest req)
        {
             JsonResponseModel<CreateDeployGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDeployGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeployGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateParamTemplate) is used to create a parameter template.
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
        /// This API (DeleteBackup) is used to delete a TencentDB instance backup.
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
        /// This API is used to delete placement groups by placement group ID (a placement group cannot be deleted if it contains resources).
        /// </summary>
        /// <param name="req"><see cref="DeleteDeployGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeployGroupsResponse"/></returns>
        public async Task<DeleteDeployGroupsResponse> DeleteDeployGroups(DeleteDeployGroupsRequest req)
        {
             JsonResponseModel<DeleteDeployGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeployGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeployGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteParamTemplate) is used to delete a parameter template.
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
        /// This API (DescribeAccounts) is used to query information of all TencentDB accounts.
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
        /// This API is used to query the databases contained in a backup file. It has been disused.
        /// After the legacy version becomes capable of full backup, if you want to download logical backup files by table, you need to use this API.
        /// The new API (CreateBackup) can specify the table to be backed up when a logical backup file is created, which can be downloaded directly.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDatabasesRequest"/></param>
        /// <returns><see cref="DescribeBackupDatabasesResponse"/></returns>
        public async Task<DescribeBackupDatabasesResponse> DescribeBackupDatabases(DescribeBackupDatabasesRequest req)
        {
             JsonResponseModel<DescribeBackupDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDatabasesResponse>>(strResp);
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
        /// This API is used to query the backup tables of the specified database. It has been disused.
        /// After the legacy version becomes capable of full backup, if you want to download logical backup files by table, you need to use this API.
        /// The new API (CreateBackup) can specify the table to be backed up when a logical backup file is created, which can be downloaded directly.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupTablesRequest"/></param>
        /// <returns><see cref="DescribeBackupTablesResponse"/></returns>
        public async Task<DescribeBackupTablesResponse> DescribeBackupTables(DescribeBackupTablesRequest req)
        {
             JsonResponseModel<DescribeBackupTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupTablesResponse>>(strResp);
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
        /// This API (DescribeDBInstances) is used to query the list of TencentDB instances (which can be master, disaster recovery, or read-only instances). It supports filtering instances by project ID, instance ID, access address, and instance status.
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
        /// This API (DescribeDBZoneConfig) is used to query the specifications of TencentDB instances purchasable in a region.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBZoneConfigRequest"/></param>
        /// <returns><see cref="DescribeDBZoneConfigResponse"/></returns>
        public async Task<DescribeDBZoneConfigResponse> DescribeDBZoneConfig(DescribeDBZoneConfigRequest req)
        {
             JsonResponseModel<DescribeDBZoneConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBZoneConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBZoneConfigResponse>>(strResp);
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
        /// This API (DescribeDatabases) is used to query the information of databases of a TencentDB instance.
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
        /// This API is used to query the list of placement groups of a user. You can specify the placement group ID or name.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeployGroupListRequest"/></param>
        /// <returns><see cref="DescribeDeployGroupListResponse"/></returns>
        public async Task<DescribeDeployGroupListResponse> DescribeDeployGroupList(DescribeDeployGroupListRequest req)
        {
             JsonResponseModel<DescribeDeployGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeployGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeployGroupListResponse>>(strResp);
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
        /// This API (DescribeParamTemplateInfo) is used to query parameter template details.
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
        /// This API (DescribeParamTemplates) is used to query the list of parameter templates
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
        /// This API (DescribeTables) is used to query the database tables of a TencentDB instance.
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
        /// This API (InitDBInstances) is used to initialize instances, including their password, default character set, and instance port number.
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
        /// This API is used to modify the permissions of a TencentDB instance account.
        /// 
        /// Note that when modifying account permissions, you need to pass in the full permission information of the account. You can [query the account permission information
        /// ](https://cloud.tencent.com/document/api/236/17500) first before modifying permissions.
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
        /// This API (ModifyDBInstanceVipVport) is used to modify the IP and port number of a TencentDB instance, switch from the basic network to VPC, or change VPC subnets.
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
        /// This API (ModifyParamTemplate) is used to modify a parameter template.
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
        /// This API is used to update the information of a TencentDB RO group, such as configuring an instance removal policy in case of excessive delay and setting read weights of RO instances.
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
        /// This API (OfflineIsolatedInstances) is used to deactivate isolated TencentDB instances immediately. The instances must be in isolated status, i.e., their `Status` value is 5 in the return of the [instance list querying API](https://cloud.tencent.com/document/api/236/15872).
        /// 
        /// This is an asynchronous API. There may be a delay in repossessing some resources. You can query the details by using the [instance list querying API](https://cloud.tencent.com/document/api/236/15872) and specifying the InstanceId and the `Status` value as [5, 6, 7]. If the returned instance is empty, then all its resources have been released.
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
        /// This API (OpenWanService) is used to enable public network access for an instance.
        /// 
        /// Note that before enabling public network access, you need to first [initialize the instance](https://cloud.tencent.com/document/api/236/15873).
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
        /// This API (RestartDBInstances) is used to restart TencentDB instances.
        /// 
        /// Note:
        /// 1. This API only supports restarting master instances.
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
        /// This API (SwitchForUpgrade) is used to switch to a new instance. You can initiate this process when the master instance being upgraded is pending switch.
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
        /// This API (UpgradeDBInstanceEngineVersion) is used to upgrade the version of a TencentDB instance, which can be a master instance, disaster recovery instance, or read-only instance.
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

    }
}
