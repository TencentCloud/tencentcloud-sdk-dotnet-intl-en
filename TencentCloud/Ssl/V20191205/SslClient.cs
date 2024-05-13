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

namespace TencentCloud.Ssl.V20191205
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ssl.V20191205.Models;

   public class SslClient : AbstractClient{

       private const string endpoint = "ssl.tencentcloudapi.com";
       private const string version = "2019-12-05";
       private const string sdkVersion = "SDK_NET_3.0.894";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SslClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SslClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to apply for a free certificate.
        /// </summary>
        /// <param name="req"><see cref="ApplyCertificateRequest"/></param>
        /// <returns><see cref="ApplyCertificateResponse"/></returns>
        public Task<ApplyCertificateResponse> ApplyCertificate(ApplyCertificateRequest req)
        {
            return InternalRequestAsync<ApplyCertificateResponse>(req, "ApplyCertificate");
        }

        /// <summary>
        /// This API is used to apply for a free certificate.
        /// </summary>
        /// <param name="req"><see cref="ApplyCertificateRequest"/></param>
        /// <returns><see cref="ApplyCertificateResponse"/></returns>
        public ApplyCertificateResponse ApplyCertificateSync(ApplyCertificateRequest req)
        {
            return InternalRequestAsync<ApplyCertificateResponse>(req, "ApplyCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to batch delete CSRs.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteCSRRequest"/></param>
        /// <returns><see cref="BatchDeleteCSRResponse"/></returns>
        public Task<BatchDeleteCSRResponse> BatchDeleteCSR(BatchDeleteCSRRequest req)
        {
            return InternalRequestAsync<BatchDeleteCSRResponse>(req, "BatchDeleteCSR");
        }

        /// <summary>
        /// This API is used to batch delete CSRs.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteCSRRequest"/></param>
        /// <returns><see cref="BatchDeleteCSRResponse"/></returns>
        public BatchDeleteCSRResponse BatchDeleteCSRSync(BatchDeleteCSRRequest req)
        {
            return InternalRequestAsync<BatchDeleteCSRResponse>(req, "BatchDeleteCSR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel certificate review.
        /// </summary>
        /// <param name="req"><see cref="CancelAuditCertificateRequest"/></param>
        /// <returns><see cref="CancelAuditCertificateResponse"/></returns>
        public Task<CancelAuditCertificateResponse> CancelAuditCertificate(CancelAuditCertificateRequest req)
        {
            return InternalRequestAsync<CancelAuditCertificateResponse>(req, "CancelAuditCertificate");
        }

        /// <summary>
        /// This API is used to cancel certificate review.
        /// </summary>
        /// <param name="req"><see cref="CancelAuditCertificateRequest"/></param>
        /// <returns><see cref="CancelAuditCertificateResponse"/></returns>
        public CancelAuditCertificateResponse CancelAuditCertificateSync(CancelAuditCertificateRequest req)
        {
            return InternalRequestAsync<CancelAuditCertificateResponse>(req, "CancelAuditCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel a certificate order.
        /// </summary>
        /// <param name="req"><see cref="CancelCertificateOrderRequest"/></param>
        /// <returns><see cref="CancelCertificateOrderResponse"/></returns>
        public Task<CancelCertificateOrderResponse> CancelCertificateOrder(CancelCertificateOrderRequest req)
        {
            return InternalRequestAsync<CancelCertificateOrderResponse>(req, "CancelCertificateOrder");
        }

        /// <summary>
        /// This API is used to cancel a certificate order.
        /// </summary>
        /// <param name="req"><see cref="CancelCertificateOrderRequest"/></param>
        /// <returns><see cref="CancelCertificateOrderResponse"/></returns>
        public CancelCertificateOrderResponse CancelCertificateOrderSync(CancelCertificateOrderRequest req)
        {
            return InternalRequestAsync<CancelCertificateOrderResponse>(req, "CancelCertificateOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit a certificate order.
        /// </summary>
        /// <param name="req"><see cref="CommitCertificateInformationRequest"/></param>
        /// <returns><see cref="CommitCertificateInformationResponse"/></returns>
        public Task<CommitCertificateInformationResponse> CommitCertificateInformation(CommitCertificateInformationRequest req)
        {
            return InternalRequestAsync<CommitCertificateInformationResponse>(req, "CommitCertificateInformation");
        }

        /// <summary>
        /// This API is used to submit a certificate order.
        /// </summary>
        /// <param name="req"><see cref="CommitCertificateInformationRequest"/></param>
        /// <returns><see cref="CommitCertificateInformationResponse"/></returns>
        public CommitCertificateInformationResponse CommitCertificateInformationSync(CommitCertificateInformationRequest req)
        {
            return InternalRequestAsync<CommitCertificateInformationResponse>(req, "CommitCertificateInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a CSR.
        /// </summary>
        /// <param name="req"><see cref="CreateCSRRequest"/></param>
        /// <returns><see cref="CreateCSRResponse"/></returns>
        public Task<CreateCSRResponse> CreateCSR(CreateCSRRequest req)
        {
            return InternalRequestAsync<CreateCSRResponse>(req, "CreateCSR");
        }

        /// <summary>
        /// This API is used to create a CSR.
        /// </summary>
        /// <param name="req"><see cref="CreateCSRRequest"/></param>
        /// <returns><see cref="CreateCSRResponse"/></returns>
        public CreateCSRResponse CreateCSRSync(CreateCSRRequest req)
        {
            return InternalRequestAsync<CreateCSRResponse>(req, "CreateCSR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to purchase a certificate.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest req)
        {
            return InternalRequestAsync<CreateCertificateResponse>(req, "CreateCertificate");
        }

        /// <summary>
        /// This API is used to purchase a certificate.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public CreateCertificateResponse CreateCertificateSync(CreateCertificateRequest req)
        {
            return InternalRequestAsync<CreateCertificateResponse>(req, "CreateCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an async task for querying the cloud resources associated with a certificate. If such a task already exists under the certificate ID, the ID of this task is returned as the result. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE). You can query the result of this task using the `DescribeCertificateBindResourceTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateBindResourceSyncTaskRequest"/></param>
        /// <returns><see cref="CreateCertificateBindResourceSyncTaskResponse"/></returns>
        public Task<CreateCertificateBindResourceSyncTaskResponse> CreateCertificateBindResourceSyncTask(CreateCertificateBindResourceSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateCertificateBindResourceSyncTaskResponse>(req, "CreateCertificateBindResourceSyncTask");
        }

        /// <summary>
        /// This API is used to create an async task for querying the cloud resources associated with a certificate. If such a task already exists under the certificate ID, the ID of this task is returned as the result. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE). You can query the result of this task using the `DescribeCertificateBindResourceTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateBindResourceSyncTaskRequest"/></param>
        /// <returns><see cref="CreateCertificateBindResourceSyncTaskResponse"/></returns>
        public CreateCertificateBindResourceSyncTaskResponse CreateCertificateBindResourceSyncTaskSync(CreateCertificateBindResourceSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateCertificateBindResourceSyncTaskResponse>(req, "CreateCertificateBindResourceSyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public Task<DeleteCertificateResponse> DeleteCertificate(DeleteCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCertificateResponse>(req, "DeleteCertificate");
        }

        /// <summary>
        /// This API is used to delete a certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public DeleteCertificateResponse DeleteCertificateSync(DeleteCertificateRequest req)
        {
            return InternalRequestAsync<DeleteCertificateResponse>(req, "DeleteCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a CSR.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSRRequest"/></param>
        /// <returns><see cref="DescribeCSRResponse"/></returns>
        public Task<DescribeCSRResponse> DescribeCSR(DescribeCSRRequest req)
        {
            return InternalRequestAsync<DescribeCSRResponse>(req, "DescribeCSR");
        }

        /// <summary>
        /// This API is used to query the details of a CSR.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSRRequest"/></param>
        /// <returns><see cref="DescribeCSRResponse"/></returns>
        public DescribeCSRResponse DescribeCSRSync(DescribeCSRRequest req)
        {
            return InternalRequestAsync<DescribeCSRResponse>(req, "DescribeCSR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CSR list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSRSetRequest"/></param>
        /// <returns><see cref="DescribeCSRSetResponse"/></returns>
        public Task<DescribeCSRSetResponse> DescribeCSRSet(DescribeCSRSetRequest req)
        {
            return InternalRequestAsync<DescribeCSRSetResponse>(req, "DescribeCSRSet");
        }

        /// <summary>
        /// This API is used to query the CSR list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSRSetRequest"/></param>
        /// <returns><see cref="DescribeCSRSetResponse"/></returns>
        public DescribeCSRSetResponse DescribeCSRSetSync(DescribeCSRSetRequest req)
        {
            return InternalRequestAsync<DescribeCSRSetResponse>(req, "DescribeCSRSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateRequest"/></param>
        /// <returns><see cref="DescribeCertificateResponse"/></returns>
        public Task<DescribeCertificateResponse> DescribeCertificate(DescribeCertificateRequest req)
        {
            return InternalRequestAsync<DescribeCertificateResponse>(req, "DescribeCertificate");
        }

        /// <summary>
        /// This API is used to get certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateRequest"/></param>
        /// <returns><see cref="DescribeCertificateResponse"/></returns>
        public DescribeCertificateResponse DescribeCertificateSync(DescribeCertificateRequest req)
        {
            return InternalRequestAsync<DescribeCertificateResponse>(req, "DescribeCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of an async task created with `CreateCertificateBindResourceSyncTask` to query cloud resources associated with a certificate. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE).
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskDetailResponse"/></returns>
        public Task<DescribeCertificateBindResourceTaskDetailResponse> DescribeCertificateBindResourceTaskDetail(DescribeCertificateBindResourceTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateBindResourceTaskDetailResponse>(req, "DescribeCertificateBindResourceTaskDetail");
        }

        /// <summary>
        /// This API is used to query the result of an async task created with `CreateCertificateBindResourceSyncTask` to query cloud resources associated with a certificate. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE).
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskDetailResponse"/></returns>
        public DescribeCertificateBindResourceTaskDetailResponse DescribeCertificateBindResourceTaskDetailSync(DescribeCertificateBindResourceTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateBindResourceTaskDetailResponse>(req, "DescribeCertificateBindResourceTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of an async task created with `CreateCertificateBindResourceSyncTask` to query cloud resources associated with a certificate. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE).
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskResultResponse"/></returns>
        public Task<DescribeCertificateBindResourceTaskResultResponse> DescribeCertificateBindResourceTaskResult(DescribeCertificateBindResourceTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeCertificateBindResourceTaskResultResponse>(req, "DescribeCertificateBindResourceTaskResult");
        }

        /// <summary>
        /// This API is used to query the result of an async task created with `CreateCertificateBindResourceSyncTask` to query cloud resources associated with a certificate. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE).
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskResultResponse"/></returns>
        public DescribeCertificateBindResourceTaskResultResponse DescribeCertificateBindResourceTaskResultSync(DescribeCertificateBindResourceTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeCertificateBindResourceTaskResultResponse>(req, "DescribeCertificateBindResourceTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get certificate details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public Task<DescribeCertificateDetailResponse> DescribeCertificateDetail(DescribeCertificateDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateDetailResponse>(req, "DescribeCertificateDetail");
        }

        /// <summary>
        /// This API is used to get certificate details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public DescribeCertificateDetailResponse DescribeCertificateDetailSync(DescribeCertificateDetailRequest req)
        {
            return InternalRequestAsync<DescribeCertificateDetailResponse>(req, "DescribeCertificateDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get certificate operation logs in the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateOperateLogsRequest"/></param>
        /// <returns><see cref="DescribeCertificateOperateLogsResponse"/></returns>
        public Task<DescribeCertificateOperateLogsResponse> DescribeCertificateOperateLogs(DescribeCertificateOperateLogsRequest req)
        {
            return InternalRequestAsync<DescribeCertificateOperateLogsResponse>(req, "DescribeCertificateOperateLogs");
        }

        /// <summary>
        /// This API is used to get certificate operation logs in the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateOperateLogsRequest"/></param>
        /// <returns><see cref="DescribeCertificateOperateLogsResponse"/></returns>
        public DescribeCertificateOperateLogsResponse DescribeCertificateOperateLogsSync(DescribeCertificateOperateLogsRequest req)
        {
            return InternalRequestAsync<DescribeCertificateOperateLogsResponse>(req, "DescribeCertificateOperateLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the certificate list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public Task<DescribeCertificatesResponse> DescribeCertificates(DescribeCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCertificatesResponse>(req, "DescribeCertificates");
        }

        /// <summary>
        /// This API is used to get the certificate list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public DescribeCertificatesResponse DescribeCertificatesSync(DescribeCertificatesRequest req)
        {
            return InternalRequestAsync<DescribeCertificatesResponse>(req, "DescribeCertificates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of EDGEONE instances to which a certificate can be deployed.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostTeoInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostTeoInstanceListResponse"/></returns>
        public Task<DescribeHostTeoInstanceListResponse> DescribeHostTeoInstanceList(DescribeHostTeoInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostTeoInstanceListResponse>(req, "DescribeHostTeoInstanceList");
        }

        /// <summary>
        /// This API is used to query the list of EDGEONE instances to which a certificate can be deployed.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostTeoInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostTeoInstanceListResponse"/></returns>
        public DescribeHostTeoInstanceListResponse DescribeHostTeoInstanceListSync(DescribeHostTeoInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeHostTeoInstanceListResponse>(req, "DescribeHostTeoInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query certificate cloud resource update record list
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordResponse"/></returns>
        public Task<DescribeHostUpdateRecordResponse> DescribeHostUpdateRecord(DescribeHostUpdateRecordRequest req)
        {
            return InternalRequestAsync<DescribeHostUpdateRecordResponse>(req, "DescribeHostUpdateRecord");
        }

        /// <summary>
        /// Query certificate cloud resource update record list
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordResponse"/></returns>
        public DescribeHostUpdateRecordResponse DescribeHostUpdateRecordSync(DescribeHostUpdateRecordRequest req)
        {
            return InternalRequestAsync<DescribeHostUpdateRecordResponse>(req, "DescribeHostUpdateRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query certificate cloud resource update record details list
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordDetailResponse"/></returns>
        public Task<DescribeHostUpdateRecordDetailResponse> DescribeHostUpdateRecordDetail(DescribeHostUpdateRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeHostUpdateRecordDetailResponse>(req, "DescribeHostUpdateRecordDetail");
        }

        /// <summary>
        /// Query certificate cloud resource update record details list
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordDetailResponse"/></returns>
        public DescribeHostUpdateRecordDetailResponse DescribeHostUpdateRecordDetailSync(DescribeHostUpdateRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeHostUpdateRecordDetailResponse>(req, "DescribeHostUpdateRecordDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to download a certificate.
        /// </summary>
        /// <param name="req"><see cref="DownloadCertificateRequest"/></param>
        /// <returns><see cref="DownloadCertificateResponse"/></returns>
        public Task<DownloadCertificateResponse> DownloadCertificate(DownloadCertificateRequest req)
        {
            return InternalRequestAsync<DownloadCertificateResponse>(req, "DownloadCertificate");
        }

        /// <summary>
        /// This API is used to download a certificate.
        /// </summary>
        /// <param name="req"><see cref="DownloadCertificateRequest"/></param>
        /// <returns><see cref="DownloadCertificateResponse"/></returns>
        public DownloadCertificateResponse DownloadCertificateSync(DownloadCertificateRequest req)
        {
            return InternalRequestAsync<DownloadCertificateResponse>(req, "DownloadCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the information of a CSR.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSRRequest"/></param>
        /// <returns><see cref="ModifyCSRResponse"/></returns>
        public Task<ModifyCSRResponse> ModifyCSR(ModifyCSRRequest req)
        {
            return InternalRequestAsync<ModifyCSRResponse>(req, "ModifyCSR");
        }

        /// <summary>
        /// This API is used to modify the information of a CSR.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSRRequest"/></param>
        /// <returns><see cref="ModifyCSRResponse"/></returns>
        public ModifyCSRResponse ModifyCSRSync(ModifyCSRRequest req)
        {
            return InternalRequestAsync<ModifyCSRResponse>(req, "ModifyCSR")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a certificate alias by passing in the certificate ID and new alias.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAliasRequest"/></param>
        /// <returns><see cref="ModifyCertificateAliasResponse"/></returns>
        public Task<ModifyCertificateAliasResponse> ModifyCertificateAlias(ModifyCertificateAliasRequest req)
        {
            return InternalRequestAsync<ModifyCertificateAliasResponse>(req, "ModifyCertificateAlias");
        }

        /// <summary>
        /// This API is used to modify a certificate alias by passing in the certificate ID and new alias.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAliasRequest"/></param>
        /// <returns><see cref="ModifyCertificateAliasResponse"/></returns>
        public ModifyCertificateAliasResponse ModifyCertificateAliasSync(ModifyCertificateAliasRequest req)
        {
            return InternalRequestAsync<ModifyCertificateAliasResponse>(req, "ModifyCertificateAlias")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the projects of multiple certificates.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateProjectRequest"/></param>
        /// <returns><see cref="ModifyCertificateProjectResponse"/></returns>
        public Task<ModifyCertificateProjectResponse> ModifyCertificateProject(ModifyCertificateProjectRequest req)
        {
            return InternalRequestAsync<ModifyCertificateProjectResponse>(req, "ModifyCertificateProject");
        }

        /// <summary>
        /// This API is used to modify the projects of multiple certificates.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateProjectRequest"/></param>
        /// <returns><see cref="ModifyCertificateProjectResponse"/></returns>
        public ModifyCertificateProjectResponse ModifyCertificateProjectSync(ModifyCertificateProjectRequest req)
        {
            return InternalRequestAsync<ModifyCertificateProjectResponse>(req, "ModifyCertificateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to re-submit a review application for a paid certificate whose review failed or was canceled.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateResubmitRequest"/></param>
        /// <returns><see cref="ModifyCertificateResubmitResponse"/></returns>
        public Task<ModifyCertificateResubmitResponse> ModifyCertificateResubmit(ModifyCertificateResubmitRequest req)
        {
            return InternalRequestAsync<ModifyCertificateResubmitResponse>(req, "ModifyCertificateResubmit");
        }

        /// <summary>
        /// This API is used to re-submit a review application for a paid certificate whose review failed or was canceled.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateResubmitRequest"/></param>
        /// <returns><see cref="ModifyCertificateResubmitResponse"/></returns>
        public ModifyCertificateResubmitResponse ModifyCertificateResubmitSync(ModifyCertificateResubmitRequest req)
        {
            return InternalRequestAsync<ModifyCertificateResubmitResponse>(req, "ModifyCertificateResubmit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reissue a certificate. Note that if you have applied for a free certificate, only an RSA-2048 certificate will be reissued, and the certificate can be reissued only once.
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertificateRequest"/></param>
        /// <returns><see cref="ReplaceCertificateResponse"/></returns>
        public Task<ReplaceCertificateResponse> ReplaceCertificate(ReplaceCertificateRequest req)
        {
            return InternalRequestAsync<ReplaceCertificateResponse>(req, "ReplaceCertificate");
        }

        /// <summary>
        /// This API is used to reissue a certificate. Note that if you have applied for a free certificate, only an RSA-2048 certificate will be reissued, and the certificate can be reissued only once.
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertificateRequest"/></param>
        /// <returns><see cref="ReplaceCertificateResponse"/></returns>
        public ReplaceCertificateResponse ReplaceCertificateSync(ReplaceCertificateRequest req)
        {
            return InternalRequestAsync<ReplaceCertificateResponse>(req, "ReplaceCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit certificate information.
        /// </summary>
        /// <param name="req"><see cref="SubmitCertificateInformationRequest"/></param>
        /// <returns><see cref="SubmitCertificateInformationResponse"/></returns>
        public Task<SubmitCertificateInformationResponse> SubmitCertificateInformation(SubmitCertificateInformationRequest req)
        {
            return InternalRequestAsync<SubmitCertificateInformationResponse>(req, "SubmitCertificateInformation");
        }

        /// <summary>
        /// This API is used to submit certificate information.
        /// </summary>
        /// <param name="req"><see cref="SubmitCertificateInformationRequest"/></param>
        /// <returns><see cref="SubmitCertificateInformationResponse"/></returns>
        public SubmitCertificateInformationResponse SubmitCertificateInformationSync(SubmitCertificateInformationRequest req)
        {
            return InternalRequestAsync<SubmitCertificateInformationResponse>(req, "SubmitCertificateInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update old certificate resources with one click and is an asynchronous interface. After this API is called, the returned DeployRecordId being 0 indicates that the task is in progress, and the returned DeployRecordId being greater than 0 indicates that the task is successfully created. If the creation fails, an exception is returned.
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateInstanceRequest"/></param>
        /// <returns><see cref="UpdateCertificateInstanceResponse"/></returns>
        public Task<UpdateCertificateInstanceResponse> UpdateCertificateInstance(UpdateCertificateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateCertificateInstanceResponse>(req, "UpdateCertificateInstance");
        }

        /// <summary>
        /// This API is used to update old certificate resources with one click and is an asynchronous interface. After this API is called, the returned DeployRecordId being 0 indicates that the task is in progress, and the returned DeployRecordId being greater than 0 indicates that the task is successfully created. If the creation fails, an exception is returned.
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateInstanceRequest"/></param>
        /// <returns><see cref="UpdateCertificateInstanceResponse"/></returns>
        public UpdateCertificateInstanceResponse UpdateCertificateInstanceSync(UpdateCertificateInstanceRequest req)
        {
            return InternalRequestAsync<UpdateCertificateInstanceResponse>(req, "UpdateCertificateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud resource update deployment retry record
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRetryRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRetryResponse"/></returns>
        public Task<UpdateCertificateRecordRetryResponse> UpdateCertificateRecordRetry(UpdateCertificateRecordRetryRequest req)
        {
            return InternalRequestAsync<UpdateCertificateRecordRetryResponse>(req, "UpdateCertificateRecordRetry");
        }

        /// <summary>
        /// Cloud resource update deployment retry record
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRetryRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRetryResponse"/></returns>
        public UpdateCertificateRecordRetryResponse UpdateCertificateRecordRetrySync(UpdateCertificateRecordRetryRequest req)
        {
            return InternalRequestAsync<UpdateCertificateRecordRetryResponse>(req, "UpdateCertificateRecordRetry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cloud resource update one-click rollback
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRollbackRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRollbackResponse"/></returns>
        public Task<UpdateCertificateRecordRollbackResponse> UpdateCertificateRecordRollback(UpdateCertificateRecordRollbackRequest req)
        {
            return InternalRequestAsync<UpdateCertificateRecordRollbackResponse>(req, "UpdateCertificateRecordRollback");
        }

        /// <summary>
        /// Cloud resource update one-click rollback
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRollbackRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRollbackResponse"/></returns>
        public UpdateCertificateRecordRollbackResponse UpdateCertificateRecordRollbackSync(UpdateCertificateRecordRollbackRequest req)
        {
            return InternalRequestAsync<UpdateCertificateRecordRollbackResponse>(req, "UpdateCertificateRecordRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upload a certificate.
        /// </summary>
        /// <param name="req"><see cref="UploadCertificateRequest"/></param>
        /// <returns><see cref="UploadCertificateResponse"/></returns>
        public Task<UploadCertificateResponse> UploadCertificate(UploadCertificateRequest req)
        {
            return InternalRequestAsync<UploadCertificateResponse>(req, "UploadCertificate");
        }

        /// <summary>
        /// This API is used to upload a certificate.
        /// </summary>
        /// <param name="req"><see cref="UploadCertificateRequest"/></param>
        /// <returns><see cref="UploadCertificateResponse"/></returns>
        public UploadCertificateResponse UploadCertificateSync(UploadCertificateRequest req)
        {
            return InternalRequestAsync<UploadCertificateResponse>(req, "UploadCertificate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upload the confirmation letter for a certificate.
        /// </summary>
        /// <param name="req"><see cref="UploadConfirmLetterRequest"/></param>
        /// <returns><see cref="UploadConfirmLetterResponse"/></returns>
        public Task<UploadConfirmLetterResponse> UploadConfirmLetter(UploadConfirmLetterRequest req)
        {
            return InternalRequestAsync<UploadConfirmLetterResponse>(req, "UploadConfirmLetter");
        }

        /// <summary>
        /// This API is used to upload the confirmation letter for a certificate.
        /// </summary>
        /// <param name="req"><see cref="UploadConfirmLetterRequest"/></param>
        /// <returns><see cref="UploadConfirmLetterResponse"/></returns>
        public UploadConfirmLetterResponse UploadConfirmLetterSync(UploadConfirmLetterRequest req)
        {
            return InternalRequestAsync<UploadConfirmLetterResponse>(req, "UploadConfirmLetter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
