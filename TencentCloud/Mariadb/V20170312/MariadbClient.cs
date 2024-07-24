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
       private const string sdkVersion = "SDK_NET_3.0.947";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MariadbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
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
        /// Note: accounts with the same username but different hosts are different accounts. Permissions can only be copied between accounts with the same `Readonly` attribute.
        /// </summary>
        /// <param name="req"><see cref="CopyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="CopyAccountPrivilegesResponse"/></returns>
        public Task<CopyAccountPrivilegesResponse> CopyAccountPrivileges(CopyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<CopyAccountPrivilegesResponse>(req, "CopyAccountPrivileges");
        }

        /// <summary>
        /// This API is used to copy the permissions of a TencentDB account.
        /// Note: accounts with the same username but different hosts are different accounts. Permissions can only be copied between accounts with the same `Readonly` attribute.
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
        /// This API is used to create a monthly subscribed TencentDB for MariaDB instance by passing in information such as instance specifications, database version number, validity period, and quantity.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public Task<CreateDBInstanceResponse> CreateDBInstance(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance");
        }

        /// <summary>
        /// This API is used to create a monthly subscribed TencentDB for MariaDB instance by passing in information such as instance specifications, database version number, validity period, and quantity.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceRequest"/></param>
        /// <returns><see cref="CreateDBInstanceResponse"/></returns>
        public CreateDBInstanceResponse CreateDBInstanceSync(CreateDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateDBInstanceResponse>(req, "CreateDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go TencentDB for MariaDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHourDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDBInstanceResponse"/></returns>
        public Task<CreateHourDBInstanceResponse> CreateHourDBInstance(CreateHourDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateHourDBInstanceResponse>(req, "CreateHourDBInstance");
        }

        /// <summary>
        /// This API is used to create a pay-as-you-go TencentDB for MariaDB instance.
        /// </summary>
        /// <param name="req"><see cref="CreateHourDBInstanceRequest"/></param>
        /// <returns><see cref="CreateHourDBInstanceResponse"/></returns>
        public CreateHourDBInstanceResponse CreateHourDBInstanceSync(CreateHourDBInstanceRequest req)
        {
            return InternalRequestAsync<CreateHourDBInstanceResponse>(req, "CreateHourDBInstance")
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
        /// Note: Accounts with the same username but different hosts are different accounts.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeAccountPrivilegesResponse"/></returns>
        public Task<DescribeAccountPrivilegesResponse> DescribeAccountPrivileges(DescribeAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeAccountPrivilegesResponse>(req, "DescribeAccountPrivileges");
        }

        /// <summary>
        /// This API is used to query the permissions of a TencentDB account.
        /// Note: Accounts with the same username but different hosts are different accounts.
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
        /// This API is used to query the details of a specified instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDetailResponse"/></returns>
        public Task<DescribeDBInstanceDetailResponse> DescribeDBInstanceDetail(DescribeDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDetailResponse>(req, "DescribeDBInstanceDetail");
        }

        /// <summary>
        /// This API is used to query the details of a specified instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceDetailResponse"/></returns>
        public DescribeDBInstanceDetailResponse DescribeDBInstanceDetailSync(DescribeDBInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribeDBInstanceDetailResponse>(req, "DescribeDBInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the TencentDB instance list. It supports filtering instances by project ID, instance ID, private address, and instance name.
        /// If no filter is specified, 20 instances will be returned by default. Up to 100 instances can be returned for a single request.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances");
        }

        /// <summary>
        /// This API is used to query the TencentDB instance list. It supports filtering instances by project ID, instance ID, private address, and instance name.
        /// If no filter is specified, 20 instances will be returned by default. Up to 100 instances can be returned for a single request.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBInstancesResponse>(req, "DescribeDBInstances")
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
        /// This API is used to query the security group details of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// This API is used to query the security group details of an instance.
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
        /// This API is used to obtain a temp u200drollback instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBTmpInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBTmpInstancesResponse"/></returns>
        public Task<DescribeDBTmpInstancesResponse> DescribeDBTmpInstances(DescribeDBTmpInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBTmpInstancesResponse>(req, "DescribeDBTmpInstances");
        }

        /// <summary>
        /// This API is used to obtain a temp u200drollback instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBTmpInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBTmpInstancesResponse"/></returns>
        public DescribeDBTmpInstancesResponse DescribeDBTmpInstancesSync(DescribeDBTmpInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDBTmpInstancesResponse>(req, "DescribeDBTmpInstances")
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
        /// This API is used to query the information of primary and replica nodes of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public Task<DescribeInstanceNodeInfoResponse> DescribeInstanceNodeInfo(DescribeInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodeInfoResponse>(req, "DescribeInstanceNodeInfo");
        }

        /// <summary>
        /// This API is used to query the information of primary and replica nodes of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public DescribeInstanceNodeInfoResponse DescribeInstanceNodeInfoSync(DescribeInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodeInfoResponse>(req, "DescribeInstanceNodeInfo")
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
        /// This API is used to query TencentDB order information. You can pass in an order ID to query the TencentDB instance associated with the order and the corresponding task process ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders");
        }

        /// <summary>
        /// This API is used to query TencentDB order information. You can pass in an order ID to query the TencentDB instance associated with the order and the corresponding task process ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance price before you purchase it.
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRequest"/></param>
        /// <returns><see cref="DescribePriceResponse"/></returns>
        public Task<DescribePriceResponse> DescribePrice(DescribePriceRequest req)
        {
            return InternalRequestAsync<DescribePriceResponse>(req, "DescribePrice");
        }

        /// <summary>
        /// This API is used to query the instance price before you purchase it.
        /// </summary>
        /// <param name="req"><see cref="DescribePriceRequest"/></param>
        /// <returns><see cref="DescribePriceResponse"/></returns>
        public DescribePriceResponse DescribePriceSync(DescribePriceRequest req)
        {
            return InternalRequestAsync<DescribePriceResponse>(req, "DescribePrice")
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
        /// This API is used to terminate an isolated monthly subscribed instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public Task<DestroyDBInstanceResponse> DestroyDBInstance(DestroyDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDBInstanceResponse>(req, "DestroyDBInstance");
        }

        /// <summary>
        /// This API is used to terminate an isolated monthly subscribed instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public DestroyDBInstanceResponse DestroyDBInstanceSync(DestroyDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyDBInstanceResponse>(req, "DestroyDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go TencentDB for MariaDB instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDBInstanceResponse"/></returns>
        public Task<DestroyHourDBInstanceResponse> DestroyHourDBInstance(DestroyHourDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyHourDBInstanceResponse>(req, "DestroyHourDBInstance");
        }

        /// <summary>
        /// This API is used to terminate a pay-as-you-go TencentDB for MariaDB instance.
        /// </summary>
        /// <param name="req"><see cref="DestroyHourDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyHourDBInstanceResponse"/></returns>
        public DestroyHourDBInstanceResponse DestroyHourDBInstanceSync(DestroyHourDBInstanceRequest req)
        {
            return InternalRequestAsync<DestroyHourDBInstanceResponse>(req, "DestroyHourDBInstance")
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
        /// This API is used to isolate a monthly subscribed TencentDB for MariaDB instance, which will no longer be accessible via IP and port.  The isolated instance can be started up in the recycle bin.  If it is isolated due to overdue payments, top up your account as soon as possible.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public Task<IsolateDBInstanceResponse> IsolateDBInstance(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance");
        }

        /// <summary>
        /// This API is used to isolate a monthly subscribed TencentDB for MariaDB instance, which will no longer be accessible via IP and port.  The isolated instance can be started up in the recycle bin.  If it is isolated due to overdue payments, top up your account as soon as possible.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstanceRequest"/></param>
        /// <returns><see cref="IsolateDBInstanceResponse"/></returns>
        public IsolateDBInstanceResponse IsolateDBInstanceSync(IsolateDBInstanceRequest req)
        {
            return InternalRequestAsync<IsolateDBInstanceResponse>(req, "IsolateDBInstance")
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
        /// This API is used to modify the permissions of a TencentDB instance account. \n\n**Note**\n-Only the SELECT permission (that is, set the permission parameter to `["SELECT"]`) of the system database `mysql` can be granted.An error will be reported if read-write permissions are granted to a read-only account. If the parameter is not passed in, no change will be made to the granted table permissions. To clear the granted view permissions, set `Privileges` to an empty array.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyAccountPrivilegesResponse"/></returns>
        public Task<ModifyAccountPrivilegesResponse> ModifyAccountPrivileges(ModifyAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyAccountPrivilegesResponse>(req, "ModifyAccountPrivileges");
        }

        /// <summary>
        /// This API is used to modify the permissions of a TencentDB instance account. \n\n**Note**\n-Only the SELECT permission (that is, set the permission parameter to `["SELECT"]`) of the system database `mysql` can be granted.An error will be reported if read-write permissions are granted to a read-only account. If the parameter is not passed in, no change will be made to the granted table permissions. To clear the granted view permissions, set `Privileges` to an empty array.
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
        /// This API is used to modify sync task attributes (currently, only the task name can be modified).
        /// </summary>
        /// <param name="req"><see cref="ModifySyncTaskAttributeRequest"/></param>
        /// <returns><see cref="ModifySyncTaskAttributeResponse"/></returns>
        public Task<ModifySyncTaskAttributeResponse> ModifySyncTaskAttribute(ModifySyncTaskAttributeRequest req)
        {
            return InternalRequestAsync<ModifySyncTaskAttributeResponse>(req, "ModifySyncTaskAttribute");
        }

        /// <summary>
        /// This API is used to modify sync task attributes (currently, only the task name can be modified).
        /// </summary>
        /// <param name="req"><see cref="ModifySyncTaskAttributeRequest"/></param>
        /// <returns><see cref="ModifySyncTaskAttributeResponse"/></returns>
        public ModifySyncTaskAttributeResponse ModifySyncTaskAttributeSync(ModifySyncTaskAttributeRequest req)
        {
            return InternalRequestAsync<ModifySyncTaskAttributeResponse>(req, "ModifySyncTaskAttribute")
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
        /// This API is used to terminate the isolated dedicated TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDedicatedDBInstanceResponse"/></returns>
        public Task<TerminateDedicatedDBInstanceResponse> TerminateDedicatedDBInstance(TerminateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDedicatedDBInstanceResponse>(req, "TerminateDedicatedDBInstance");
        }

        /// <summary>
        /// This API is used to terminate the isolated dedicated TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="TerminateDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="TerminateDedicatedDBInstanceResponse"/></returns>
        public TerminateDedicatedDBInstanceResponse TerminateDedicatedDBInstanceSync(TerminateDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<TerminateDedicatedDBInstanceResponse>(req, "TerminateDedicatedDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to expand the dedicated TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDedicatedDBInstanceResponse"/></returns>
        public Task<UpgradeDedicatedDBInstanceResponse> UpgradeDedicatedDBInstance(UpgradeDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDedicatedDBInstanceResponse>(req, "UpgradeDedicatedDBInstance");
        }

        /// <summary>
        /// This API is used to expand the dedicated TencentDB instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDedicatedDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDedicatedDBInstanceResponse"/></returns>
        public UpgradeDedicatedDBInstanceResponse UpgradeDedicatedDBInstanceSync(UpgradeDedicatedDBInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeDedicatedDBInstanceResponse>(req, "UpgradeDedicatedDBInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
