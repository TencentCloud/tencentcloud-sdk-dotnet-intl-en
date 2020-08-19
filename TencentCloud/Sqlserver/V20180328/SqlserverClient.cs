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

namespace TencentCloud.Sqlserver.V20180328
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sqlserver.V20180328.Models;

   public class SqlserverClient : AbstractClient{

       private const string endpoint = "sqlserver.tencentcloudapi.com";
       private const string version = "2018-03-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SqlserverClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SqlserverClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create an instance account.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public async Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance account.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a backup.
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
        /// This API is used to create a backup.
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
        /// This API is used to create a database.
        /// </summary>
        /// <param name="req"><see cref="CreateDBRequest"/></param>
        /// <returns><see cref="CreateDBResponse"/></returns>
        public async Task<CreateDBResponse> CreateDB(CreateDBRequest req)
        {
             JsonResponseModel<CreateDBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a database.
        /// </summary>
        /// <param name="req"><see cref="CreateDBRequest"/></param>
        /// <returns><see cref="CreateDBResponse"/></returns>
        public CreateDBResponse CreateDBSync(CreateDBRequest req)
        {
             JsonResponseModel<CreateDBResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public async Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
             JsonResponseModel<CreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
             JsonResponseModel<CreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a migration task.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationRequest"/></param>
        /// <returns><see cref="CreateMigrationResponse"/></returns>
        public async Task<CreateMigrationResponse> CreateMigration(CreateMigrationRequest req)
        {
             JsonResponseModel<CreateMigrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a migration task.
        /// </summary>
        /// <param name="req"><see cref="CreateMigrationRequest"/></param>
        /// <returns><see cref="CreateMigrationResponse"/></returns>
        public CreateMigrationResponse CreateMigrationSync(CreateMigrationRequest req)
        {
             JsonResponseModel<CreateMigrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an instance account.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public async Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
             JsonResponseModel<DeleteAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an instance account.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
             JsonResponseModel<DeleteAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to drop a database.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBRequest"/></param>
        /// <returns><see cref="DeleteDBResponse"/></returns>
        public async Task<DeleteDBResponse> DeleteDB(DeleteDBRequest req)
        {
             JsonResponseModel<DeleteDBResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to drop a database.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBRequest"/></param>
        /// <returns><see cref="DeleteDBResponse"/></returns>
        public DeleteDBResponse DeleteDBSync(DeleteDBRequest req)
        {
             JsonResponseModel<DeleteDBResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDB");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a migration task.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationRequest"/></param>
        /// <returns><see cref="DeleteMigrationResponse"/></returns>
        public async Task<DeleteMigrationResponse> DeleteMigration(DeleteMigrationRequest req)
        {
             JsonResponseModel<DeleteMigrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a migration task.
        /// </summary>
        /// <param name="req"><see cref="DeleteMigrationRequest"/></param>
        /// <returns><see cref="DeleteMigrationResponse"/></returns>
        public DeleteMigrationResponse DeleteMigrationSync(DeleteMigrationRequest req)
        {
             JsonResponseModel<DeleteMigrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull the list of instance accounts.
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
        /// This API is used to pull the list of instance accounts.
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
        /// This API is used to query the list of backups.
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
        /// This API is used to query the list of backups.
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
        /// This API is used to query the list of instances.
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
        /// This API is used to query the list of instances.
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
        /// This API is used to query the list of databases
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsRequest"/></param>
        /// <returns><see cref="DescribeDBsResponse"/></returns>
        public async Task<DescribeDBsResponse> DescribeDBs(DescribeDBsRequest req)
        {
             JsonResponseModel<DescribeDBsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of databases
        /// </summary>
        /// <param name="req"><see cref="DescribeDBsRequest"/></param>
        /// <returns><see cref="DescribeDBsResponse"/></returns>
        public DescribeDBsResponse DescribeDBsSync(DescribeDBsRequest req)
        {
             JsonResponseModel<DescribeDBsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query flow status.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowStatusRequest"/></param>
        /// <returns><see cref="DescribeFlowStatusResponse"/></returns>
        public async Task<DescribeFlowStatusResponse> DescribeFlowStatus(DescribeFlowStatusRequest req)
        {
             JsonResponseModel<DescribeFlowStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query flow status.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowStatusRequest"/></param>
        /// <returns><see cref="DescribeFlowStatusResponse"/></returns>
        public DescribeFlowStatusResponse DescribeFlowStatusSync(DescribeFlowStatusRequest req)
        {
             JsonResponseModel<DescribeFlowStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query migration task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public async Task<DescribeMigrationDetailResponse> DescribeMigrationDetail(DescribeMigrationDetailRequest req)
        {
             JsonResponseModel<DescribeMigrationDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query migration task details.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationDetailRequest"/></param>
        /// <returns><see cref="DescribeMigrationDetailResponse"/></returns>
        public DescribeMigrationDetailResponse DescribeMigrationDetailSync(DescribeMigrationDetailRequest req)
        {
             JsonResponseModel<DescribeMigrationDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrationDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of eligible migration tasks based on the entered criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationsRequest"/></param>
        /// <returns><see cref="DescribeMigrationsResponse"/></returns>
        public async Task<DescribeMigrationsResponse> DescribeMigrations(DescribeMigrationsRequest req)
        {
             JsonResponseModel<DescribeMigrationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMigrations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of eligible migration tasks based on the entered criteria.
        /// </summary>
        /// <param name="req"><see cref="DescribeMigrationsRequest"/></param>
        /// <returns><see cref="DescribeMigrationsResponse"/></returns>
        public DescribeMigrationsResponse DescribeMigrationsSync(DescribeMigrationsRequest req)
        {
             JsonResponseModel<DescribeMigrationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMigrations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMigrationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public async Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query purchasable specification configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public async Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
             JsonResponseModel<DescribeProductConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query purchasable specification configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public DescribeProductConfigResponse DescribeProductConfigSync(DescribeProductConfigRequest req)
        {
             JsonResponseModel<DescribeProductConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query purchasable regions.
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
        /// This API is used to query purchasable regions.
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
        /// This API is used to query the time range available for instance rollback.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeResponse"/></returns>
        public async Task<DescribeRollbackTimeResponse> DescribeRollbackTime(DescribeRollbackTimeRequest req)
        {
             JsonResponseModel<DescribeRollbackTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRollbackTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the time range available for instance rollback.
        /// </summary>
        /// <param name="req"><see cref="DescribeRollbackTimeRequest"/></param>
        /// <returns><see cref="DescribeRollbackTimeResponse"/></returns>
        public DescribeRollbackTimeResponse DescribeRollbackTimeSync(DescribeRollbackTimeRequest req)
        {
             JsonResponseModel<DescribeRollbackTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRollbackTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRollbackTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get file information of slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeSlowlogsResponse"/></returns>
        public async Task<DescribeSlowlogsResponse> DescribeSlowlogs(DescribeSlowlogsRequest req)
        {
             JsonResponseModel<DescribeSlowlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get file information of slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeSlowlogsResponse"/></returns>
        public DescribeSlowlogsResponse DescribeSlowlogsSync(DescribeSlowlogsRequest req)
        {
             JsonResponseModel<DescribeSlowlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query currently purchasable AZs.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query currently purchasable AZs.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of requested instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public async Task<InquiryPriceCreateDBInstancesResponse> InquiryPriceCreateDBInstances(InquiryPriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the price of requested instances.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public InquiryPriceCreateDBInstancesResponse InquiryPriceCreateDBInstancesSync(InquiryPriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the upgrade price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public async Task<InquiryPriceUpgradeDBInstanceResponse> InquiryPriceUpgradeDBInstance(InquiryPriceUpgradeDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the upgrade price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public InquiryPriceUpgradeDBInstanceResponse InquiryPriceUpgradeDBInstanceSync(InquiryPriceUpgradeDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance account permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegeResponse"/></returns>
        public async Task<ModifyAccountPrivilegeResponse> ModifyAccountPrivilege(ModifyAccountPrivilegeRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountPrivilege");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance account permissions.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegeResponse"/></returns>
        public ModifyAccountPrivilegeResponse ModifyAccountPrivilegeSync(ModifyAccountPrivilegeRequest req)
        {
             JsonResponseModel<ModifyAccountPrivilegeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountPrivilege");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountPrivilegeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify account remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public async Task<ModifyAccountRemarkResponse> ModifyAccountRemark(ModifyAccountRemarkRequest req)
        {
             JsonResponseModel<ModifyAccountRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify account remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public ModifyAccountRemarkResponse ModifyAccountRemarkSync(ModifyAccountRemarkRequest req)
        {
             JsonResponseModel<ModifyAccountRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the backup policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyBackupStrategyResponse"/></returns>
        public async Task<ModifyBackupStrategyResponse> ModifyBackupStrategy(ModifyBackupStrategyRequest req)
        {
             JsonResponseModel<ModifyBackupStrategyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the backup policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupStrategyRequest"/></param>
        /// <returns><see cref="ModifyBackupStrategyResponse"/></returns>
        public ModifyBackupStrategyResponse ModifyBackupStrategySync(ModifyBackupStrategyRequest req)
        {
             JsonResponseModel<ModifyBackupStrategyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupStrategy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupStrategyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename an instance.
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
        /// This API is used to rename an instance.
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
        /// This API is used to modify the project to which a database instance belongs.
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
        /// This API is used to modify the project to which a database instance belongs.
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
        /// This API is used to rename a database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBNameRequest"/></param>
        /// <returns><see cref="ModifyDBNameResponse"/></returns>
        public async Task<ModifyDBNameResponse> ModifyDBName(ModifyDBNameRequest req)
        {
             JsonResponseModel<ModifyDBNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a database.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBNameRequest"/></param>
        /// <returns><see cref="ModifyDBNameResponse"/></returns>
        public ModifyDBNameResponse ModifyDBNameSync(ModifyDBNameRequest req)
        {
             JsonResponseModel<ModifyDBNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify database remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBRemarkRequest"/></param>
        /// <returns><see cref="ModifyDBRemarkResponse"/></returns>
        public async Task<ModifyDBRemarkResponse> ModifyDBRemark(ModifyDBRemarkRequest req)
        {
             JsonResponseModel<ModifyDBRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify database remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBRemarkRequest"/></param>
        /// <returns><see cref="ModifyDBRemarkResponse"/></returns>
        public ModifyDBRemarkResponse ModifyDBRemarkSync(ModifyDBRemarkRequest req)
        {
             JsonResponseModel<ModifyDBRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an existing migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationRequest"/></param>
        /// <returns><see cref="ModifyMigrationResponse"/></returns>
        public async Task<ModifyMigrationResponse> ModifyMigration(ModifyMigrationRequest req)
        {
             JsonResponseModel<ModifyMigrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an existing migration task.
        /// </summary>
        /// <param name="req"><see cref="ModifyMigrationRequest"/></param>
        /// <returns><see cref="ModifyMigrationResponse"/></returns>
        public ModifyMigrationResponse ModifyMigrationSync(ModifyMigrationRequest req)
        {
             JsonResponseModel<ModifyMigrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the account password of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public async Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the account password of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart a database instance.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public async Task<RestartDBInstanceResponse> RestartDBInstance(RestartDBInstanceRequest req)
        {
             JsonResponseModel<RestartDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart a database instance.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public RestartDBInstanceResponse RestartDBInstanceSync(RestartDBInstanceRequest req)
        {
             JsonResponseModel<RestartDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restore an instance from a backup file.
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
        /// This API is used to restore an instance from a backup file.
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
        /// This API is used to roll back an instance.
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRequest"/></param>
        /// <returns><see cref="RollbackInstanceResponse"/></returns>
        public async Task<RollbackInstanceResponse> RollbackInstance(RollbackInstanceRequest req)
        {
             JsonResponseModel<RollbackInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to roll back an instance.
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRequest"/></param>
        /// <returns><see cref="RollbackInstanceResponse"/></returns>
        public RollbackInstanceResponse RollbackInstanceSync(RollbackInstanceRequest req)
        {
             JsonResponseModel<RollbackInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start running a migration task.
        /// </summary>
        /// <param name="req"><see cref="RunMigrationRequest"/></param>
        /// <returns><see cref="RunMigrationResponse"/></returns>
        public async Task<RunMigrationResponse> RunMigration(RunMigrationRequest req)
        {
             JsonResponseModel<RunMigrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start running a migration task.
        /// </summary>
        /// <param name="req"><see cref="RunMigrationRequest"/></param>
        /// <returns><see cref="RunMigrationResponse"/></returns>
        public RunMigrationResponse RunMigrationSync(RunMigrationRequest req)
        {
             JsonResponseModel<RunMigrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunMigration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunMigrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manually terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public async Task<TerminateDBInstanceResponse> TerminateDBInstance(TerminateDBInstanceRequest req)
        {
             JsonResponseModel<TerminateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to manually terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDBInstanceResponse"/></returns>
        public TerminateDBInstanceResponse TerminateDBInstanceSync(TerminateDBInstanceRequest req)
        {
             JsonResponseModel<TerminateDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateDBInstanceResponse>>(strResp);
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
        /// This API is used to upgrade an instance.
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

    }
}
