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

namespace TencentCloud.Dcdb.V20180411
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dcdb.V20180411.Models;

   public class DcdbClient : AbstractClient{

       private const string endpoint = "dcdb.tencentcloudapi.com";
       private const string version = "2018-04-11";
       private const string sdkVersion = "SDK_NET_3.0.914";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DcdbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DcdbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to remove a pay-as-you-go TDSQL instance from isolation.
        /// </summary>
        /// <param name="req"><see cref="ActiveHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="ActiveHourDCDBInstanceResponse"/></returns>
        public Task<ActiveHourDCDBInstanceResponse> ActiveHourDCDBInstance(ActiveHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<ActiveHourDCDBInstanceResponse>(req, "ActiveHourDCDBInstance");
        }

        /// <summary>
        /// This API is used to remove a pay-as-you-go TDSQL instance from isolation.
        /// </summary>
        /// <param name="req"><see cref="ActiveHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="ActiveHourDCDBInstanceResponse"/></returns>
        public ActiveHourDCDBInstanceResponse ActiveHourDCDBInstanceSync(ActiveHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<ActiveHourDCDBInstanceResponse>(req, "ActiveHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate security groups with Tencent Cloud resources in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to associate security groups with Tencent Cloud resources in batches.
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel DCN synchronization.
        /// </summary>
        /// <param name="req"><see cref="CancelDcnJobRequest"/></param>
        /// <returns><see cref="CancelDcnJobResponse"/></returns>
        public Task<CancelDcnJobResponse> CancelDcnJob(CancelDcnJobRequest req)
        {
            return InternalRequestAsync<CancelDcnJobResponse>(req, "CancelDcnJob");
        }

        /// <summary>
        /// This API is used to cancel DCN synchronization.
        /// </summary>
        /// <param name="req"><see cref="CancelDcnJobRequest"/></param>
        /// <returns><see cref="CancelDcnJobResponse"/></returns>
        public CancelDcnJobResponse CancelDcnJobSync(CancelDcnJobRequest req)
        {
            return InternalRequestAsync<CancelDcnJobResponse>(req, "CancelDcnJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clone an instance account.
        /// </summary>
        /// <param name="req"><see cref="CloneAccountRequest"/></param>
        /// <returns><see cref="CloneAccountResponse"/></returns>
        public Task<CloneAccountResponse> CloneAccount(CloneAccountRequest req)
        {
            return InternalRequestAsync<CloneAccountResponse>(req, "CloneAccount");
        }

        /// <summary>
        /// This API is used to clone an instance account.
        /// </summary>
        /// <param name="req"><see cref="CloneAccountRequest"/></param>
        /// <returns><see cref="CloneAccountResponse"/></returns>
        public CloneAccountResponse CloneAccountSync(CloneAccountRequest req)
        {
            return InternalRequestAsync<CloneAccountResponse>(req, "CloneAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable public network access for a TencentDB instance, which will make the public IP address inaccessible. The `DescribeDCDBInstances` API will not return the public domain name and port information of the corresponding instance.
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseDBExtranetAccessResponse>(req, "CloseDBExtranetAccess");
        }

        /// <summary>
        /// This API is used to disable public network access for a TencentDB instance, which will make the public IP address inaccessible. The `DescribeDCDBInstances` API will not return the public domain name and port information of the corresponding instance.
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public CloseDBExtranetAccessResponse CloseDBExtranetAccessSync(CloseDBExtranetAccessRequest req)
        {
            return InternalRequestAsync<CloseDBExtranetAccessResponse>(req, "CloseDBExtranetAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to copy the permissions of a TencentDB account.
        /// Note: Accounts with the same username but different hosts are different accounts. Permissions can only be copied between accounts with the same `Readonly` attribute.
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public Task<CopyAccountPrivilegesResponse> CopyAccountPrivileges(CopyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<CopyAccountPrivilegesResponse>(req, "CopyAccountPrivileges");
        }

        /// <summary>
        /// This API is used to copy the permissions of a TencentDB account.
        /// Note: Accounts with the same username but different hosts are different accounts. Permissions can only be copied between accounts with the same `Readonly` attribute.
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public CopyAccountPrivilegesResponse CopyAccountPrivilegesSync(CopyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<CopyAccountPrivilegesResponse>(req, "CopyAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TencentDB account. Multiple accounts can be created for one instance. Accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount");
        }

        /// <summary>
        /// This API is used to create a TencentDB account. Multiple accounts can be created for one instance. Accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
            return InternalRequestAsync<CreateAccountResponse>(req, "CreateAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a monthly subscribed TDSQL instance by passing in information such as instance specifications, database version number, and purchased duration.
        /// </summary>
        /// <param name="req"><see cref="CreateDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDCDBInstanceResponse"/></returns>
        public Task<CreateDCDBInstanceResponse> CreateDCDBInstance(CreateDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDCDBInstanceResponse>(req, "CreateDCDBInstance");
        }

        /// <summary>
        /// This API is used to create a monthly subscribed TDSQL instance by passing in information such as instance specifications, database version number, and purchased duration.
        /// </summary>
        /// <param name="req"><see cref="CreateDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDCDBInstanceResponse"/></returns>
        public CreateDCDBInstanceResponse CreateDCDBInstanceSync(CreateDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDCDBInstanceResponse>(req, "CreateDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a dedicated TDSQL cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterDCDBInstanceResponse"/></returns>
        public Task<CreateDedicatedClusterDCDBInstanceResponse> CreateDedicatedClusterDCDBInstance(CreateDedicatedClusterDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDedicatedClusterDCDBInstanceResponse>(req, "CreateDedicatedClusterDCDBInstance");
        }

        /// <summary>
        /// This API is used to create a dedicated TDSQL cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDedicatedClusterDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDedicatedClusterDCDBInstanceResponse"/></returns>
        public CreateDedicatedClusterDCDBInstanceResponse CreateDedicatedClusterDCDBInstanceSync(CreateDedicatedClusterDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDedicatedClusterDCDBInstanceResponse>(req, "CreateDedicatedClusterDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDCDBInstanceResponse"/></returns>
        public Task<CreateHourDCDBInstanceResponse> CreateHourDCDBInstance(CreateHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateHourDCDBInstanceResponse>(req, "CreateHourDCDBInstance");
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDCDBInstanceResponse"/></returns>
        public CreateHourDCDBInstanceResponse CreateHourDCDBInstanceSync(CreateHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateHourDCDBInstanceResponse>(req, "CreateHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a TencentDB account, which is uniquely identified by username and host.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount");
        }

        /// <summary>
        /// This API is used to delete a TencentDB account, which is uniquely identified by username and host.
        /// </summary>
        /// <param name="req"><see cref="DeleteAccountRequest"/></param>
        /// <returns><see cref="DeleteAccountResponse"/></returns>
        public DeleteAccountResponse DeleteAccountSync(DeleteAccountRequest req)
        {
            return InternalRequestAsync<DeleteAccountResponse>(req, "DeleteAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the permissions of a TencentDB account.
        /// Note: Accounts with the same username but different hosts are considered as different accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges");
        }

        /// <summary>
        /// This API is used to query the permissions of a TencentDB account.
        /// Note: Accounts with the same username but different hosts are considered as different accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public DescribeAccountPrivilegesResponse DescribeAccountPrivilegesSync(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of accounts of a specified TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// This API is used to query the list of accounts of a specified TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of backup files.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public Task<DescribeBackupFilesResponse> DescribeBackupFiles(DescribeBackupFilesRequest req)
        {
            return InternalRequestAsync<DescribeBackupFilesResponse>(req, "DescribeBackupFiles");
        }

        /// <summary>
        /// This API is used to query the list of backup files.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupFilesRequest"/></param>
        /// <returns><see cref="DescribeBackupFilesResponse"/></returns>
        public DescribeBackupFilesResponse DescribeBackupFilesSync(DescribeBackupFilesRequest req)
        {
            return InternalRequestAsync<DescribeBackupFilesResponse>(req, "DescribeBackupFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the encryption status of the instance data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="DescribeDBEncryptAttributesResponse"/></returns>
        public Task<DescribeDBEncryptAttributesResponse> DescribeDBEncryptAttributes(DescribeDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<DescribeDBEncryptAttributesResponse>(req, "DescribeDBEncryptAttributes");
        }

        /// <summary>
        /// This API is used to query the encryption status of the instance data.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="DescribeDBEncryptAttributesResponse"/></returns>
        public DescribeDBEncryptAttributesResponse DescribeDBEncryptAttributesSync(DescribeDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<DescribeDBEncryptAttributesResponse>(req, "DescribeDBEncryptAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of various logs of a database, including cold backups, binlogs, errlogs, and slowlogs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns><see cref="DescribeDBLogFilesResponse"/></returns>
        public Task<DescribeDBLogFilesResponse> DescribeDBLogFiles(DescribeDBLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeDBLogFilesResponse>(req, "DescribeDBLogFiles");
        }

        /// <summary>
        /// This API is used to get the list of various logs of a database, including cold backups, binlogs, errlogs, and slowlogs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBLogFilesRequest"/></param>
        /// <returns><see cref="DescribeDBLogFilesResponse"/></returns>
        public DescribeDBLogFilesResponse DescribeDBLogFilesSync(DescribeDBLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeDBLogFilesResponse>(req, "DescribeDBLogFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the current parameter settings of a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public Task<DescribeDBParametersResponse> DescribeDBParameters(DescribeDBParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBParametersResponse>(req, "DescribeDBParameters");
        }

        /// <summary>
        /// This API is used to get the current parameter settings of a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBParametersRequest"/></param>
        /// <returns><see cref="DescribeDBParametersResponse"/></returns>
        public DescribeDBParametersResponse DescribeDBParametersSync(DescribeDBParametersRequest req)
        {
            return InternalRequestAsync<DescribeDBParametersResponse>(req, "DescribeDBParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security group information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// This API is used to query the security group information of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowLogsResponse"/></returns>
        public Task<DescribeDBSlowLogsResponse> DescribeDBSlowLogs(DescribeDBSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSlowLogsResponse>(req, "DescribeDBSlowLogs");
        }

        /// <summary>
        /// This API is used to query the list of slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowLogsResponse"/></returns>
        public DescribeDBSlowLogsResponse DescribeDBSlowLogsSync(DescribeDBSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeDBSlowLogsResponse>(req, "DescribeDBSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the sync mode of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSyncModeRequest"/></param>
        /// <returns><see cref="DescribeDBSyncModeResponse"/></returns>
        public Task<DescribeDBSyncModeResponse> DescribeDBSyncMode(DescribeDBSyncModeRequest req)
        {
            return InternalRequestAsync<DescribeDBSyncModeResponse>(req, "DescribeDBSyncMode");
        }

        /// <summary>
        /// This API is used to query the sync mode of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSyncModeRequest"/></param>
        /// <returns><see cref="DescribeDBSyncModeResponse"/></returns>
        public DescribeDBSyncModeResponse DescribeDBSyncModeSync(DescribeDBSyncModeRequest req)
        {
            return InternalRequestAsync<DescribeDBSyncModeResponse>(req, "DescribeDBSyncMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain u200da temp rollback instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBTmpInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBTmpInstancesResponse"/></returns>
        public Task<DescribeDBTmpInstancesResponse> DescribeDBTmpInstances(DescribeDBTmpInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBTmpInstancesResponse>(req, "DescribeDBTmpInstances");
        }

        /// <summary>
        /// This API is used to obtain u200da temp rollback instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBTmpInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBTmpInstancesResponse"/></returns>
        public DescribeDBTmpInstancesResponse DescribeDBTmpInstancesSync(DescribeDBTmpInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBTmpInstancesResponse>(req, "DescribeDBTmpInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceDetailResponse"/></returns>
        public Task<DescribeDCDBInstanceDetailResponse> DescribeDCDBInstanceDetail(DescribeDCDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstanceDetailResponse>(req, "DescribeDCDBInstanceDetail");
        }

        /// <summary>
        /// This API is used to get the details of a TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceDetailResponse"/></returns>
        public DescribeDCDBInstanceDetailResponse DescribeDCDBInstanceDetailSync(DescribeDCDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstanceDetailResponse>(req, "DescribeDCDBInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of instance nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceNodeInfoResponse"/></returns>
        public Task<DescribeDCDBInstanceNodeInfoResponse> DescribeDCDBInstanceNodeInfo(DescribeDCDBInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstanceNodeInfoResponse>(req, "DescribeDCDBInstanceNodeInfo");
        }

        /// <summary>
        /// This API is used to query the information of instance nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstanceNodeInfoResponse"/></returns>
        public DescribeDCDBInstanceNodeInfoResponse DescribeDCDBInstanceNodeInfoSync(DescribeDCDBInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstanceNodeInfoResponse>(req, "DescribeDCDBInstanceNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of TencentDB instances. It supports filtering instances by project ID, instance ID, private network address, and instance name.
        /// If no filter is specified, 10 instances will be returned by default. Up to 100 instances can be returned for a single request.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstancesResponse"/></returns>
        public Task<DescribeDCDBInstancesResponse> DescribeDCDBInstances(DescribeDCDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstancesResponse>(req, "DescribeDCDBInstances");
        }

        /// <summary>
        /// This API is used to query the list of TencentDB instances. It supports filtering instances by project ID, instance ID, private network address, and instance name.
        /// If no filter is specified, 10 instances will be returned by default. Up to 100 instances can be returned for a single request.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDCDBInstancesResponse"/></returns>
        public DescribeDCDBInstancesResponse DescribeDCDBInstancesSync(DescribeDCDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDCDBInstancesResponse>(req, "DescribeDCDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price of an instance before you purchase it.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBPriceResponse"/></returns>
        public Task<DescribeDCDBPriceResponse> DescribeDCDBPrice(DescribeDCDBPriceRequest req)
        {
            return InternalRequestAsync<DescribeDCDBPriceResponse>(req, "DescribeDCDBPrice");
        }

        /// <summary>
        /// This API is used to query the price of an instance before you purchase it.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBPriceRequest"/></param>
        /// <returns><see cref="DescribeDCDBPriceResponse"/></returns>
        public DescribeDCDBPriceResponse DescribeDCDBPriceSync(DescribeDCDBPriceRequest req)
        {
            return InternalRequestAsync<DescribeDCDBPriceResponse>(req, "DescribeDCDBPrice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of shards of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBShardsRequest"/></param>
        /// <returns><see cref="DescribeDCDBShardsResponse"/></returns>
        public Task<DescribeDCDBShardsResponse> DescribeDCDBShards(DescribeDCDBShardsRequest req)
        {
            return InternalRequestAsync<DescribeDCDBShardsResponse>(req, "DescribeDCDBShards");
        }

        /// <summary>
        /// This API is used to query the information of shards of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDCDBShardsRequest"/></param>
        /// <returns><see cref="DescribeDCDBShardsResponse"/></returns>
        public DescribeDCDBShardsResponse DescribeDCDBShardsSync(DescribeDCDBShardsRequest req)
        {
            return InternalRequestAsync<DescribeDCDBShardsResponse>(req, "DescribeDCDBShards")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of database objects in a TencentDB instance, including tables, stored procedures, views, and functions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public Task<DescribeDatabaseObjectsResponse> DescribeDatabaseObjects(DescribeDatabaseObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseObjectsResponse>(req, "DescribeDatabaseObjects");
        }

        /// <summary>
        /// This API is used to query the list of database objects in a TencentDB instance, including tables, stored procedures, views, and functions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseObjectsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseObjectsResponse"/></returns>
        public DescribeDatabaseObjectsResponse DescribeDatabaseObjectsSync(DescribeDatabaseObjectsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseObjectsResponse>(req, "DescribeDatabaseObjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the table information of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public Task<DescribeDatabaseTableResponse> DescribeDatabaseTable(DescribeDatabaseTableRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseTableResponse>(req, "DescribeDatabaseTable");
        }

        /// <summary>
        /// This API is used to query the table information of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseTableRequest"/></param>
        /// <returns><see cref="DescribeDatabaseTableResponse"/></returns>
        public DescribeDatabaseTableResponse DescribeDatabaseTableSync(DescribeDatabaseTableRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseTableResponse>(req, "DescribeDatabaseTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the database list of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// This API is used to query the database list of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the disaster recovery details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDcnDetailRequest"/></param>
        /// <returns><see cref="DescribeDcnDetailResponse"/></returns>
        public Task<DescribeDcnDetailResponse> DescribeDcnDetail(DescribeDcnDetailRequest req)
        {
            return InternalRequestAsync<DescribeDcnDetailResponse>(req, "DescribeDcnDetail");
        }

        /// <summary>
        /// This API is used to query the disaster recovery details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDcnDetailRequest"/></param>
        /// <returns><see cref="DescribeDcnDetailResponse"/></returns>
        public DescribeDcnDetailResponse DescribeDcnDetailSync(DescribeDcnDetailRequest req)
        {
            return InternalRequestAsync<DescribeDcnDetailResponse>(req, "DescribeDcnDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the download URL of a specific backup or log file of a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadUrlResponse"/></returns>
        public Task<DescribeFileDownloadUrlResponse> DescribeFileDownloadUrl(DescribeFileDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeFileDownloadUrlResponse>(req, "DescribeFileDownloadUrl");
        }

        /// <summary>
        /// This API is used to get the download URL of a specific backup or log file of a database.
        /// </summary>
        /// <param name="req"><see cref="DescribeFileDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeFileDownloadUrlResponse"/></returns>
        public DescribeFileDownloadUrlResponse DescribeFileDownloadUrlSync(DescribeFileDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeFileDownloadUrlResponse>(req, "DescribeFileDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query task status.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public Task<DescribeFlowResponse> DescribeFlow(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow");
        }

        /// <summary>
        /// This API is used to query task status.
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowRequest"/></param>
        /// <returns><see cref="DescribeFlowResponse"/></returns>
        public DescribeFlowResponse DescribeFlowSync(DescribeFlowRequest req)
        {
            return InternalRequestAsync<DescribeFlowResponse>(req, "DescribeFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the backup log retention days.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogFileRetentionPeriodRequest"/></param>
        /// <returns><see cref="DescribeLogFileRetentionPeriodResponse"/></returns>
        public Task<DescribeLogFileRetentionPeriodResponse> DescribeLogFileRetentionPeriod(DescribeLogFileRetentionPeriodRequest req)
        {
            return InternalRequestAsync<DescribeLogFileRetentionPeriodResponse>(req, "DescribeLogFileRetentionPeriod");
        }

        /// <summary>
        /// This API is used to view the backup log retention days.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogFileRetentionPeriodRequest"/></param>
        /// <returns><see cref="DescribeLogFileRetentionPeriodResponse"/></returns>
        public DescribeLogFileRetentionPeriodResponse DescribeLogFileRetentionPeriodSync(DescribeLogFileRetentionPeriodRequest req)
        {
            return InternalRequestAsync<DescribeLogFileRetentionPeriodResponse>(req, "DescribeLogFileRetentionPeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query TDSQL order information. You can pass in an order ID to query the TDSQL instance associated with the order and the corresponding task process ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders");
        }

        /// <summary>
        /// This API is used to query TDSQL order information. You can pass in an order ID to query the TDSQL instance associated with the order and the corresponding task process ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// This API is used to query the security group details of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate an isolated monthly subscribed TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDCDBInstanceResponse"/></returns>
        public Task<DestroyDCDBInstanceResponse> DestroyDCDBInstance(DestroyDCDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDCDBInstanceResponse>(req, "DestroyDCDBInstance");
        }

        /// <summary>
        /// This API is used to terminate an isolated monthly subscribed TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDCDBInstanceResponse"/></returns>
        public DestroyDCDBInstanceResponse DestroyDCDBInstanceSync(DestroyDCDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDCDBInstanceResponse>(req, "DestroyDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDCDBInstanceResponse"/></returns>
        public Task<DestroyHourDCDBInstanceResponse> DestroyHourDCDBInstance(DestroyHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyHourDCDBInstanceResponse>(req, "DestroyHourDCDBInstance");
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDCDBInstanceResponse"/></returns>
        public DestroyHourDCDBInstanceResponse DestroyHourDCDBInstanceSync(DestroyHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyHourDCDBInstanceResponse>(req, "DestroyHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unassociate security groups from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// This API is used to unassociate security groups from instances in batches.
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to grant permissions to a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public Task<GrantAccountPrivilegesResponse> GrantAccountPrivileges(GrantAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<GrantAccountPrivilegesResponse>(req, "GrantAccountPrivileges");
        }

        /// <summary>
        /// This API is used to grant permissions to a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="GrantAccountPrivilegesRequest"/></param>
        /// <returns><see cref="GrantAccountPrivilegesResponse"/></returns>
        public GrantAccountPrivilegesResponse GrantAccountPrivilegesSync(GrantAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<GrantAccountPrivilegesResponse>(req, "GrantAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to initialize instances, including setting the default character set and table name case sensitivity.
        /// </summary>
        /// <param name="req"><see cref="InitDCDBInstancesRequest"/></param>
        /// <returns><see cref="InitDCDBInstancesResponse"/></returns>
        public Task<InitDCDBInstancesResponse> InitDCDBInstances(InitDCDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDCDBInstancesResponse>(req, "InitDCDBInstances");
        }

        /// <summary>
        /// This API is used to initialize instances, including setting the default character set and table name case sensitivity.
        /// </summary>
        /// <param name="req"><see cref="InitDCDBInstancesRequest"/></param>
        /// <returns><see cref="InitDCDBInstancesResponse"/></returns>
        public InitDCDBInstancesResponse InitDCDBInstancesSync(InitDCDBInstancesRequest req)
        {
            return InternalRequestAsync<InitDCDBInstancesResponse>(req, "InitDCDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate a monthly subscribed TDSQL instance, which will no longer be accessible via IP and port.  The isolated instance can be started up in the recycle bin.  If it is isolated due to overdue payments, top up your account as soon as possible.
        /// </summary>
        /// <param name="req"><see cref="IsolateDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDCDBInstanceResponse"/></returns>
        public Task<IsolateDCDBInstanceResponse> IsolateDCDBInstance(IsolateDCDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDCDBInstanceResponse>(req, "IsolateDCDBInstance");
        }

        /// <summary>
        /// This API is used to isolate a monthly subscribed TDSQL instance, which will no longer be accessible via IP and port.  The isolated instance can be started up in the recycle bin.  If it is isolated due to overdue payments, top up your account as soon as possible.
        /// </summary>
        /// <param name="req"><see cref="IsolateDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDCDBInstanceResponse"/></returns>
        public IsolateDCDBInstanceResponse IsolateDCDBInstanceSync(IsolateDCDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDCDBInstanceResponse>(req, "IsolateDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate a dedicated TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDedicatedDBInstanceResponse"/></returns>
        public Task<IsolateDedicatedDBInstanceResponse> IsolateDedicatedDBInstance(IsolateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDedicatedDBInstanceResponse>(req, "IsolateDedicatedDBInstance");
        }

        /// <summary>
        /// This API is used to isolate a dedicated TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDedicatedDBInstanceResponse"/></returns>
        public IsolateDedicatedDBInstanceResponse IsolateDedicatedDBInstanceSync(IsolateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDedicatedDBInstanceResponse>(req, "IsolateDedicatedDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to isolate a pay-as-you-go TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateHourDCDBInstanceResponse"/></returns>
        public Task<IsolateHourDCDBInstanceResponse> IsolateHourDCDBInstance(IsolateHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateHourDCDBInstanceResponse>(req, "IsolateHourDCDBInstance");
        }

        /// <summary>
        /// This API is used to isolate a pay-as-you-go TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateHourDCDBInstanceResponse"/></returns>
        public IsolateHourDCDBInstanceResponse IsolateHourDCDBInstanceSync(IsolateHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateHourDCDBInstanceResponse>(req, "IsolateHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to kill the specified session.
        /// </summary>
        /// <param name="req"><see cref="KillSessionRequest"/></param>
        /// <returns><see cref="KillSessionResponse"/></returns>
        public Task<KillSessionResponse> KillSession(KillSessionRequest req)
        {
            return InternalRequestAsync<KillSessionResponse>(req, "KillSession");
        }

        /// <summary>
        /// This API is used to kill the specified session.
        /// </summary>
        /// <param name="req"><see cref="KillSessionRequest"/></param>
        /// <returns><see cref="KillSessionResponse"/></returns>
        public KillSessionResponse KillSessionSync(KillSessionRequest req)
        {
            return InternalRequestAsync<KillSessionResponse>(req, "KillSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the configurations of an account, such as `max_user_connections`.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountConfigRequest"/></param>
        /// <returns><see cref="ModifyAccountConfigResponse"/></returns>
        public Task<ModifyAccountConfigResponse> ModifyAccountConfig(ModifyAccountConfigRequest req)
        {
            return InternalRequestAsync<ModifyAccountConfigResponse>(req, "ModifyAccountConfig");
        }

        /// <summary>
        /// This API is used to modify the configurations of an account, such as `max_user_connections`.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountConfigRequest"/></param>
        /// <returns><see cref="ModifyAccountConfigResponse"/></returns>
        public ModifyAccountConfigResponse ModifyAccountConfigSync(ModifyAccountConfigRequest req)
        {
            return InternalRequestAsync<ModifyAccountConfigResponse>(req, "ModifyAccountConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the remarks of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription");
        }

        /// <summary>
        /// This API is used to modify the remarks of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the permissions of a TencentDB instance account. \n\n**Note**\n-Only the SELECT permission (that is, set the permission parameter to `["SELECT"]`) of the system database `mysql` can be granted. An error will be reported if read-write permissions are granted to a read-only account. If the parameter is not passed in, no change will be made to the granted table permissions. To clear the granted view permissions, set `Privileges` to an empty array.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges");
        }

        /// <summary>
        /// This API is used to modify the permissions of a TencentDB instance account. \n\n**Note**\n-Only the SELECT permission (that is, set the permission parameter to `["SELECT"]`) of the system database `mysql` can be granted. An error will be reported if read-write permissions are granted to a read-only account. If the parameter is not passed in, no change will be made to the granted table permissions. To clear the granted view permissions, set `Privileges` to an empty array.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public ModifyAccountPrivilegesResponse ModifyAccountPrivilegesSync(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the instance data encryption.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public Task<ModifyDBEncryptAttributesResponse> ModifyDBEncryptAttributes(ModifyDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDBEncryptAttributesResponse>(req, "ModifyDBEncryptAttributes");
        }

        /// <summary>
        /// This API is used to modify the instance data encryption.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBEncryptAttributesRequest"/></param>
        /// <returns><see cref="ModifyDBEncryptAttributesResponse"/></returns>
        public ModifyDBEncryptAttributesResponse ModifyDBEncryptAttributesSync(ModifyDBEncryptAttributesRequest req)
        {
            return InternalRequestAsync<ModifyDBEncryptAttributesResponse>(req, "ModifyDBEncryptAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance name.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName");
        }

        /// <summary>
        /// This API is used to modify instance name.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceNameResponse>(req, "ModifyDBInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the security groups associated with TencentDB.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// This API is used to modify the security groups associated with TencentDB.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the project to which TencentDB instances belong.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstancesProjectResponse>(req, "ModifyDBInstancesProject");
        }

        /// <summary>
        /// This API is used to modify the project to which TencentDB instances belong.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public ModifyDBInstancesProjectResponse ModifyDBInstancesProjectSync(ModifyDBInstancesProjectRequest req)
        {
            return InternalRequestAsync<ModifyDBInstancesProjectResponse>(req, "ModifyDBInstancesProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify database parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public Task<ModifyDBParametersResponse> ModifyDBParameters(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters");
        }

        /// <summary>
        /// This API is used to modify database parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBParametersRequest"/></param>
        /// <returns><see cref="ModifyDBParametersResponse"/></returns>
        public ModifyDBParametersResponse ModifyDBParametersSync(ModifyDBParametersRequest req)
        {
            return InternalRequestAsync<ModifyDBParametersResponse>(req, "ModifyDBParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the sync mode of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns><see cref="ModifyDBSyncModeResponse"/></returns>
        public Task<ModifyDBSyncModeResponse> ModifyDBSyncMode(ModifyDBSyncModeRequest req)
        {
            return InternalRequestAsync<ModifyDBSyncModeResponse>(req, "ModifyDBSyncMode");
        }

        /// <summary>
        /// This API is used to modify the sync mode of a TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBSyncModeRequest"/></param>
        /// <returns><see cref="ModifyDBSyncModeResponse"/></returns>
        public ModifyDBSyncModeResponse ModifyDBSyncModeSync(ModifyDBSyncModeRequest req)
        {
            return InternalRequestAsync<ModifyDBSyncModeResponse>(req, "ModifyDBSyncMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance network.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyInstanceNetworkResponse"/></returns>
        public Task<ModifyInstanceNetworkResponse> ModifyInstanceNetwork(ModifyInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNetworkResponse>(req, "ModifyInstanceNetwork");
        }

        /// <summary>
        /// This API is used to modify instance network.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceNetworkRequest"/></param>
        /// <returns><see cref="ModifyInstanceNetworkResponse"/></returns>
        public ModifyInstanceNetworkResponse ModifyInstanceNetworkSync(ModifyInstanceNetworkRequest req)
        {
            return InternalRequestAsync<ModifyInstanceNetworkResponse>(req, "ModifyInstanceNetwork")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance VIP.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVipRequest"/></param>
        /// <returns><see cref="ModifyInstanceVipResponse"/></returns>
        public Task<ModifyInstanceVipResponse> ModifyInstanceVip(ModifyInstanceVipRequest req)
        {
            return InternalRequestAsync<ModifyInstanceVipResponse>(req, "ModifyInstanceVip");
        }

        /// <summary>
        /// This API is used to modify instance VIP.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVipRequest"/></param>
        /// <returns><see cref="ModifyInstanceVipResponse"/></returns>
        public ModifyInstanceVipResponse ModifyInstanceVipSync(ModifyInstanceVipRequest req)
        {
            return InternalRequestAsync<ModifyInstanceVipResponse>(req, "ModifyInstanceVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify instance Vport.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVportRequest"/></param>
        /// <returns><see cref="ModifyInstanceVportResponse"/></returns>
        public Task<ModifyInstanceVportResponse> ModifyInstanceVport(ModifyInstanceVportRequest req)
        {
            return InternalRequestAsync<ModifyInstanceVportResponse>(req, "ModifyInstanceVport");
        }

        /// <summary>
        /// This API is used to modify instance Vport.
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceVportRequest"/></param>
        /// <returns><see cref="ModifyInstanceVportResponse"/></returns>
        public ModifyInstanceVportResponse ModifyInstanceVportSync(ModifyInstanceVportRequest req)
        {
            return InternalRequestAsync<ModifyInstanceVportResponse>(req, "ModifyInstanceVport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reset the password of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// This API is used to reset the password of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a source-replica switch of instances.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceHARequest"/></param>
        /// <returns><see cref="SwitchDBInstanceHAResponse"/></returns>
        public Task<SwitchDBInstanceHAResponse> SwitchDBInstanceHA(SwitchDBInstanceHARequest req)
        {
            return InternalRequestAsync<SwitchDBInstanceHAResponse>(req, "SwitchDBInstanceHA");
        }

        /// <summary>
        /// This API is used to start a source-replica switch of instances.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstanceHARequest"/></param>
        /// <returns><see cref="SwitchDBInstanceHAResponse"/></returns>
        public SwitchDBInstanceHAResponse SwitchDBInstanceHASync(SwitchDBInstanceHARequest req)
        {
            return InternalRequestAsync<SwitchDBInstanceHAResponse>(req, "SwitchDBInstanceHA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate the isolated dedicated TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDedicatedDBInstanceResponse"/></returns>
        public Task<TerminateDedicatedDBInstanceResponse> TerminateDedicatedDBInstance(TerminateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDedicatedDBInstanceResponse>(req, "TerminateDedicatedDBInstance");
        }

        /// <summary>
        /// This API is used to terminate the isolated dedicated TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDedicatedDBInstanceResponse"/></returns>
        public TerminateDedicatedDBInstanceResponse TerminateDedicatedDBInstanceSync(TerminateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDedicatedDBInstanceResponse>(req, "TerminateDedicatedDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to u200dupgrade a dedicated TDSQL cluster instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDedicatedDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDedicatedDCDBInstanceResponse"/></returns>
        public Task<UpgradeDedicatedDCDBInstanceResponse> UpgradeDedicatedDCDBInstance(UpgradeDedicatedDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDedicatedDCDBInstanceResponse>(req, "UpgradeDedicatedDCDBInstance");
        }

        /// <summary>
        /// This API is used to u200dupgrade a dedicated TDSQL cluster instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDedicatedDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDedicatedDCDBInstanceResponse"/></returns>
        public UpgradeDedicatedDCDBInstanceResponse UpgradeDedicatedDCDBInstanceSync(UpgradeDedicatedDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDedicatedDCDBInstanceResponse>(req, "UpgradeDedicatedDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade a pay-as-you-go TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeHourDCDBInstanceResponse"/></returns>
        public Task<UpgradeHourDCDBInstanceResponse> UpgradeHourDCDBInstance(UpgradeHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeHourDCDBInstanceResponse>(req, "UpgradeHourDCDBInstance");
        }

        /// <summary>
        /// This API is used to upgrade a pay-as-you-go TDSQL instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeHourDCDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeHourDCDBInstanceResponse"/></returns>
        public UpgradeHourDCDBInstanceResponse UpgradeHourDCDBInstanceSync(UpgradeHourDCDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeHourDCDBInstanceResponse>(req, "UpgradeHourDCDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
