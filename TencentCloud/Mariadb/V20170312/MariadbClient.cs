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

namespace TencentCloud.Mariadb.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mariadb.V20170312.Models;

   public class MariadbClient : AbstractClient{

       private const string endpoint = "mariadb.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MariadbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MariadbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to associate security groups with Tencent Cloud resources in batches.
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
        /// This API is used to associate security groups with Tencent Cloud resources in batches.
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
        /// This API is used to cancel DCN synchronization.
        /// </summary>
        /// <param name="req"><see cref="CancelDcnJobRequest"/></param>
        /// <returns><see cref="CancelDcnJobResponse"/></returns>
        public async Task<CancelDcnJobResponse> CancelDcnJob(CancelDcnJobRequest req)
        {
             JsonResponseModel<CancelDcnJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelDcnJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelDcnJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel DCN synchronization.
        /// </summary>
        /// <param name="req"><see cref="CancelDcnJobRequest"/></param>
        /// <returns><see cref="CancelDcnJobResponse"/></returns>
        public CancelDcnJobResponse CancelDcnJobSync(CancelDcnJobRequest req)
        {
             JsonResponseModel<CancelDcnJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelDcnJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelDcnJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clone an instance account.
        /// </summary>
        /// <param name="req"><see cref="CloneAccountRequest"/></param>
        /// <returns><see cref="CloneAccountResponse"/></returns>
        public async Task<CloneAccountResponse> CloneAccount(CloneAccountRequest req)
        {
             JsonResponseModel<CloneAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clone an instance account.
        /// </summary>
        /// <param name="req"><see cref="CloneAccountRequest"/></param>
        /// <returns><see cref="CloneAccountResponse"/></returns>
        public CloneAccountResponse CloneAccountSync(CloneAccountRequest req)
        {
             JsonResponseModel<CloneAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable public network access for a TencentDB instance, which will make the public IP address inaccessible. The `DescribeDCDBInstances` API will not return the public domain name and port information of the corresponding instance.
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public async Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable public network access for a TencentDB instance, which will make the public IP address inaccessible. The `DescribeDCDBInstances` API will not return the public domain name and port information of the corresponding instance.
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public CloseDBExtranetAccessResponse CloseDBExtranetAccessSync(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to copy the permissions of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts. Permissions can only be copied between accounts with the same `Readonly` attribute.
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public async Task<CopyAccountPrivilegesResponse> CopyAccountPrivileges(CopyAccountPrivilegesRequest req)
        {
             JsonResponseModel<CopyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to copy the permissions of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts. Permissions can only be copied between accounts with the same `Readonly` attribute.
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public CopyAccountPrivilegesResponse CopyAccountPrivilegesSync(CopyAccountPrivilegesRequest req)
        {
             JsonResponseModel<CopyAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TencentDB account. Multiple accounts can be created for one instance. Accounts with the same username but different hosts are different accounts.
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
        /// This API is used to create a TencentDB account. Multiple accounts can be created for one instance. Accounts with the same username but different hosts are different accounts.
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
        /// This API is used to create pay-as-you-go instances.
        /// </summary>
        /// <param name="req"><see cref="CreateHourDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDBInstanceResponse"/></returns>
        public async Task<CreateHourDBInstanceResponse> CreateHourDBInstance(CreateHourDBInstanceRequest req)
        {
             JsonResponseModel<CreateHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create pay-as-you-go instances.
        /// </summary>
        /// <param name="req"><see cref="CreateHourDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDBInstanceResponse"/></returns>
        public CreateHourDBInstanceResponse CreateHourDBInstanceSync(CreateHourDBInstanceRequest req)
        {
             JsonResponseModel<CreateHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a TencentDB account, which is uniquely identified by username and host.
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
        /// This API is used to delete a TencentDB account, which is uniquely identified by username and host.
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
        /// This API is used to query the permissions of a TencentDB account.
        /// Note: Accounts with the same username but different hosts are different accounts.
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
        /// This API is used to query the permissions of a TencentDB account.
        /// Note: Accounts with the same username but different hosts are different accounts.
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
        /// This API is used to query the list of accounts of a specified TencentDB instance.
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
        /// This API is used to query the list of accounts of a specified TencentDB instance.
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
        /// This API is used to query the TencentDB instance list. It supports filtering instances by project ID, instance ID, private address, and instance name.
        /// If no filter is specified, 20 instances will be returned by default. Up to 100 instances can be returned for a single request.
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
        /// This API is used to query the TencentDB instance list. It supports filtering instances by project ID, instance ID, private address, and instance name.
        /// If no filter is specified, 20 instances will be returned by default. Up to 100 instances can be returned for a single request.
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
        /// This API is used to get the list of various logs of a database, including cold backups, binlogs, errlogs, and slowlogs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns><see cref="DescribeDBLogFilesResponse"/></returns>
        public async Task<DescribeDBLogFilesResponse> DescribeDBLogFiles(DescribeDBLogFilesRequest req)
        {
             JsonResponseModel<DescribeDBLogFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBLogFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBLogFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of various logs of a database, including cold backups, binlogs, errlogs, and slowlogs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns><see cref="DescribeDBLogFilesResponse"/></returns>
        public DescribeDBLogFilesResponse DescribeDBLogFilesSync(DescribeDBLogFilesRequest req)
        {
             JsonResponseModel<DescribeDBLogFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBLogFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBLogFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the current parameter settings of a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public async Task<DescribeDBParametersResponse> DescribeDBParameters(DescribeDBParametersRequest req)
        {
             JsonResponseModel<DescribeDBParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the current parameter settings of a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public DescribeDBParametersResponse DescribeDBParametersSync(DescribeDBParametersRequest req)
        {
             JsonResponseModel<DescribeDBParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group details of an instance.
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
        /// This API is used to query the security group details of an instance.
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
        /// This API is used to query the list of slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowLogsResponse"/></returns>
        public async Task<DescribeDBSlowLogsResponse> DescribeDBSlowLogs(DescribeDBSlowLogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowLogsResponse"/></returns>
        public DescribeDBSlowLogsResponse DescribeDBSlowLogsSync(DescribeDBSlowLogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of database objects in a TencentDB instance, including tables, stored procedures, views, and functions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public async Task<DescribeDatabaseObjectsResponse> DescribeDatabaseObjects(DescribeDatabaseObjectsRequest req)
        {
             JsonResponseModel<DescribeDatabaseObjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of database objects in a TencentDB instance, including tables, stored procedures, views, and functions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public DescribeDatabaseObjectsResponse DescribeDatabaseObjectsSync(DescribeDatabaseObjectsRequest req)
        {
             JsonResponseModel<DescribeDatabaseObjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabaseObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the table information of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public async Task<DescribeDatabaseTableResponse> DescribeDatabaseTable(DescribeDatabaseTableRequest req)
        {
             JsonResponseModel<DescribeDatabaseTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabaseTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the table information of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public DescribeDatabaseTableResponse DescribeDatabaseTableSync(DescribeDatabaseTableRequest req)
        {
             JsonResponseModel<DescribeDatabaseTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabaseTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabaseTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the database list of a TencentDB instance.
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
        /// This API is used to query the database list of a TencentDB instance.
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
        /// This API is used to query the disaster recovery details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDcnDetailRequest"/></param>
        /// <returns><see cref="DescribeDcnDetailResponse"/></returns>
        public async Task<DescribeDcnDetailResponse> DescribeDcnDetail(DescribeDcnDetailRequest req)
        {
             JsonResponseModel<DescribeDcnDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDcnDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDcnDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the disaster recovery details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDcnDetailRequest"/></param>
        /// <returns><see cref="DescribeDcnDetailResponse"/></returns>
        public DescribeDcnDetailResponse DescribeDcnDetailSync(DescribeDcnDetailRequest req)
        {
             JsonResponseModel<DescribeDcnDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDcnDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDcnDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the download URL of a specific backup or log file of a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadUrlResponse"/></returns>
        public async Task<DescribeFileDownloadUrlResponse> DescribeFileDownloadUrl(DescribeFileDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeFileDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the download URL of a specific backup or log file of a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadUrlResponse"/></returns>
        public DescribeFileDownloadUrlResponse DescribeFileDownloadUrlSync(DescribeFileDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeFileDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of primary and replica nodes of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public async Task<DescribeInstanceNodeInfoResponse> DescribeInstanceNodeInfo(DescribeInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of primary and replica nodes of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public DescribeInstanceNodeInfoResponse DescribeInstanceNodeInfoSync(DescribeInstanceNodeInfoRequest req)
        {
             JsonResponseModel<DescribeInstanceNodeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceNodeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceNodeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query TencentDB order information. You can pass in an order ID to query the TencentDB instance associated with the order and the corresponding task process ID.
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
        /// This API is used to query TencentDB order information. You can pass in an order ID to query the TencentDB instance associated with the order and the corresponding task process ID.
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
        /// This API is used to query the security group details of a project.
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
        /// This API is used to query the security group details of a project.
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
        /// This API is used to terminate a pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDBInstanceResponse"/></returns>
        public async Task<DestroyHourDBInstanceResponse> DestroyHourDBInstance(DestroyHourDBInstanceRequest req)
        {
             JsonResponseModel<DestroyHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyHourDBInstanceResponse>>(strResp);
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
        /// <param name="req"><see cref="DestroyHourDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDBInstanceResponse"/></returns>
        public DestroyHourDBInstanceResponse DestroyHourDBInstanceSync(DestroyHourDBInstanceRequest req)
        {
             JsonResponseModel<DestroyHourDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyHourDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyHourDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unassociate security groups from instances in batches.
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
        /// This API is used to unassociate security groups from instances in batches.
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
        /// This API is used to grant permissions to a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public async Task<GrantAccountPrivilegesResponse> GrantAccountPrivileges(GrantAccountPrivilegesRequest req)
        {
             JsonResponseModel<GrantAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GrantAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GrantAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to grant permissions to a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public GrantAccountPrivilegesResponse GrantAccountPrivilegesSync(GrantAccountPrivilegesRequest req)
        {
             JsonResponseModel<GrantAccountPrivilegesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GrantAccountPrivileges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GrantAccountPrivilegesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the remarks of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
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
        /// This API is used to modify the remarks of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
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
        /// This API is used to modify the permissions of a TencentDB instance account.
        /// 
        /// **Notes**
        /// - Only the SELECT permission (that is, set the permission parameter to `["SELECT"]`) of the system database `mysql` can be granted.
        /// - An error will be reported if read-write permissions are granted to a read-only account.
        /// - If the parameter of permissions at a level is left empty, no change will be made to the permissions at the level that have been granted. To clear granted permissions at a level, set `GlobalPrivileges.N` or `Privileges` to an empty array.
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
        /// **Notes**
        /// - Only the SELECT permission (that is, set the permission parameter to `["SELECT"]`) of the system database `mysql` can be granted.
        /// - An error will be reported if read-write permissions are granted to a read-only account.
        /// - If the parameter of permissions at a level is left empty, no change will be made to the permissions at the level that have been granted. To clear granted permissions at a level, set `GlobalPrivileges.N` or `Privileges` to an empty array.
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
        /// This API is used to modify the project to which TencentDB instances belong.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public async Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the project to which TencentDB instances belong.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public ModifyDBInstancesProjectResponse ModifyDBInstancesProjectSync(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify database parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public async Task<ModifyDBParametersResponse> ModifyDBParameters(ModifyDBParametersRequest req)
        {
             JsonResponseModel<ModifyDBParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify database parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public ModifyDBParametersResponse ModifyDBParametersSync(ModifyDBParametersRequest req)
        {
             JsonResponseModel<ModifyDBParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the sync mode of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns><see cref="ModifyDBSyncModeResponse"/></returns>
        public async Task<ModifyDBSyncModeResponse> ModifyDBSyncMode(ModifyDBSyncModeRequest req)
        {
             JsonResponseModel<ModifyDBSyncModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBSyncMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBSyncModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the sync mode of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns><see cref="ModifyDBSyncModeResponse"/></returns>
        public ModifyDBSyncModeResponse ModifyDBSyncModeSync(ModifyDBSyncModeRequest req)
        {
             JsonResponseModel<ModifyDBSyncModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBSyncMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBSyncModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify sync task attributes (currently, only the task name can be modified).
        /// </summary>
        /// <param name="req"><see cref="ModifySyncTaskAttributeRequest"/></param>
        /// <returns><see cref="ModifySyncTaskAttributeResponse"/></returns>
        public async Task<ModifySyncTaskAttributeResponse> ModifySyncTaskAttribute(ModifySyncTaskAttributeRequest req)
        {
             JsonResponseModel<ModifySyncTaskAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySyncTaskAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySyncTaskAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify sync task attributes (currently, only the task name can be modified).
        /// </summary>
        /// <param name="req"><see cref="ModifySyncTaskAttributeRequest"/></param>
        /// <returns><see cref="ModifySyncTaskAttributeResponse"/></returns>
        public ModifySyncTaskAttributeResponse ModifySyncTaskAttributeSync(ModifySyncTaskAttributeRequest req)
        {
             JsonResponseModel<ModifySyncTaskAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySyncTaskAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySyncTaskAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the password of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
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
        /// This API is used to reset the password of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
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

    }
}
