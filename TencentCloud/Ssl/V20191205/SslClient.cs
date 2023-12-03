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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SslClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to apply for a free certificate.
        /// </summary>
        /// <param name="req"><see cref="ApplyCertificateRequest"/></param>
        /// <returns><see cref="ApplyCertificateResponse"/></returns>
        public async Task<ApplyCertificateResponse> ApplyCertificate(ApplyCertificateRequest req)
        {
             JsonResponseModel<ApplyCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a free certificate.
        /// </summary>
        /// <param name="req"><see cref="ApplyCertificateRequest"/></param>
        /// <returns><see cref="ApplyCertificateResponse"/></returns>
        public ApplyCertificateResponse ApplyCertificateSync(ApplyCertificateRequest req)
        {
             JsonResponseModel<ApplyCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete CSRs.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteCSRRequest"/></param>
        /// <returns><see cref="BatchDeleteCSRResponse"/></returns>
        public async Task<BatchDeleteCSRResponse> BatchDeleteCSR(BatchDeleteCSRRequest req)
        {
             JsonResponseModel<BatchDeleteCSRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteCSR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteCSRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to batch delete CSRs.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteCSRRequest"/></param>
        /// <returns><see cref="BatchDeleteCSRResponse"/></returns>
        public BatchDeleteCSRResponse BatchDeleteCSRSync(BatchDeleteCSRRequest req)
        {
             JsonResponseModel<BatchDeleteCSRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteCSR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteCSRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel certificate review.
        /// </summary>
        /// <param name="req"><see cref="CancelAuditCertificateRequest"/></param>
        /// <returns><see cref="CancelAuditCertificateResponse"/></returns>
        public async Task<CancelAuditCertificateResponse> CancelAuditCertificate(CancelAuditCertificateRequest req)
        {
             JsonResponseModel<CancelAuditCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelAuditCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelAuditCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel certificate review.
        /// </summary>
        /// <param name="req"><see cref="CancelAuditCertificateRequest"/></param>
        /// <returns><see cref="CancelAuditCertificateResponse"/></returns>
        public CancelAuditCertificateResponse CancelAuditCertificateSync(CancelAuditCertificateRequest req)
        {
             JsonResponseModel<CancelAuditCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelAuditCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelAuditCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a certificate order.
        /// </summary>
        /// <param name="req"><see cref="CancelCertificateOrderRequest"/></param>
        /// <returns><see cref="CancelCertificateOrderResponse"/></returns>
        public async Task<CancelCertificateOrderResponse> CancelCertificateOrder(CancelCertificateOrderRequest req)
        {
             JsonResponseModel<CancelCertificateOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelCertificateOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelCertificateOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to cancel a certificate order.
        /// </summary>
        /// <param name="req"><see cref="CancelCertificateOrderRequest"/></param>
        /// <returns><see cref="CancelCertificateOrderResponse"/></returns>
        public CancelCertificateOrderResponse CancelCertificateOrderSync(CancelCertificateOrderRequest req)
        {
             JsonResponseModel<CancelCertificateOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelCertificateOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelCertificateOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit a certificate order.
        /// </summary>
        /// <param name="req"><see cref="CommitCertificateInformationRequest"/></param>
        /// <returns><see cref="CommitCertificateInformationResponse"/></returns>
        public async Task<CommitCertificateInformationResponse> CommitCertificateInformation(CommitCertificateInformationRequest req)
        {
             JsonResponseModel<CommitCertificateInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CommitCertificateInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitCertificateInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit a certificate order.
        /// </summary>
        /// <param name="req"><see cref="CommitCertificateInformationRequest"/></param>
        /// <returns><see cref="CommitCertificateInformationResponse"/></returns>
        public CommitCertificateInformationResponse CommitCertificateInformationSync(CommitCertificateInformationRequest req)
        {
             JsonResponseModel<CommitCertificateInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CommitCertificateInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CommitCertificateInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CSR.
        /// </summary>
        /// <param name="req"><see cref="CreateCSRRequest"/></param>
        /// <returns><see cref="CreateCSRResponse"/></returns>
        public async Task<CreateCSRResponse> CreateCSR(CreateCSRRequest req)
        {
             JsonResponseModel<CreateCSRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCSR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCSRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a CSR.
        /// </summary>
        /// <param name="req"><see cref="CreateCSRRequest"/></param>
        /// <returns><see cref="CreateCSRResponse"/></returns>
        public CreateCSRResponse CreateCSRSync(CreateCSRRequest req)
        {
             JsonResponseModel<CreateCSRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCSR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCSRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to purchase a certificate.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public async Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest req)
        {
             JsonResponseModel<CreateCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to purchase a certificate.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateRequest"/></param>
        /// <returns><see cref="CreateCertificateResponse"/></returns>
        public CreateCertificateResponse CreateCertificateSync(CreateCertificateRequest req)
        {
             JsonResponseModel<CreateCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an async task for querying the cloud resources associated with a certificate. If such a task already exists under the certificate ID, the ID of this task is returned as the result. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE). You can query the result of this task using the `DescribeCertificateBindResourceTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateBindResourceSyncTaskRequest"/></param>
        /// <returns><see cref="CreateCertificateBindResourceSyncTaskResponse"/></returns>
        public async Task<CreateCertificateBindResourceSyncTaskResponse> CreateCertificateBindResourceSyncTask(CreateCertificateBindResourceSyncTaskRequest req)
        {
             JsonResponseModel<CreateCertificateBindResourceSyncTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCertificateBindResourceSyncTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateBindResourceSyncTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an async task for querying the cloud resources associated with a certificate. If such a task already exists under the certificate ID, the ID of this task is returned as the result. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE). You can query the result of this task using the `DescribeCertificateBindResourceTaskResult` API.
        /// </summary>
        /// <param name="req"><see cref="CreateCertificateBindResourceSyncTaskRequest"/></param>
        /// <returns><see cref="CreateCertificateBindResourceSyncTaskResponse"/></returns>
        public CreateCertificateBindResourceSyncTaskResponse CreateCertificateBindResourceSyncTaskSync(CreateCertificateBindResourceSyncTaskRequest req)
        {
             JsonResponseModel<CreateCertificateBindResourceSyncTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCertificateBindResourceSyncTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCertificateBindResourceSyncTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public async Task<DeleteCertificateResponse> DeleteCertificate(DeleteCertificateRequest req)
        {
             JsonResponseModel<DeleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a certificate.
        /// </summary>
        /// <param name="req"><see cref="DeleteCertificateRequest"/></param>
        /// <returns><see cref="DeleteCertificateResponse"/></returns>
        public DeleteCertificateResponse DeleteCertificateSync(DeleteCertificateRequest req)
        {
             JsonResponseModel<DeleteCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a CSR.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSRRequest"/></param>
        /// <returns><see cref="DescribeCSRResponse"/></returns>
        public async Task<DescribeCSRResponse> DescribeCSR(DescribeCSRRequest req)
        {
             JsonResponseModel<DescribeCSRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCSR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCSRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a CSR.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSRRequest"/></param>
        /// <returns><see cref="DescribeCSRResponse"/></returns>
        public DescribeCSRResponse DescribeCSRSync(DescribeCSRRequest req)
        {
             JsonResponseModel<DescribeCSRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCSR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCSRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CSR list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSRSetRequest"/></param>
        /// <returns><see cref="DescribeCSRSetResponse"/></returns>
        public async Task<DescribeCSRSetResponse> DescribeCSRSet(DescribeCSRSetRequest req)
        {
             JsonResponseModel<DescribeCSRSetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCSRSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCSRSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CSR list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCSRSetRequest"/></param>
        /// <returns><see cref="DescribeCSRSetResponse"/></returns>
        public DescribeCSRSetResponse DescribeCSRSetSync(DescribeCSRSetRequest req)
        {
             JsonResponseModel<DescribeCSRSetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCSRSet");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCSRSetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateRequest"/></param>
        /// <returns><see cref="DescribeCertificateResponse"/></returns>
        public async Task<DescribeCertificateResponse> DescribeCertificate(DescribeCertificateRequest req)
        {
             JsonResponseModel<DescribeCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get certificate information.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateRequest"/></param>
        /// <returns><see cref="DescribeCertificateResponse"/></returns>
        public DescribeCertificateResponse DescribeCertificateSync(DescribeCertificateRequest req)
        {
             JsonResponseModel<DescribeCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of an async task created with `CreateCertificateBindResourceSyncTask` to query cloud resources associated with a certificate. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE).
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskDetailResponse"/></returns>
        public async Task<DescribeCertificateBindResourceTaskDetailResponse> DescribeCertificateBindResourceTaskDetail(DescribeCertificateBindResourceTaskDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateBindResourceTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateBindResourceTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateBindResourceTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of an async task created with `CreateCertificateBindResourceSyncTask` to query cloud resources associated with a certificate. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE).
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskDetailResponse"/></returns>
        public DescribeCertificateBindResourceTaskDetailResponse DescribeCertificateBindResourceTaskDetailSync(DescribeCertificateBindResourceTaskDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateBindResourceTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificateBindResourceTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateBindResourceTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of an async task created with `CreateCertificateBindResourceSyncTask` to query cloud resources associated with a certificate. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE).
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskResultResponse"/></returns>
        public async Task<DescribeCertificateBindResourceTaskResultResponse> DescribeCertificateBindResourceTaskResult(DescribeCertificateBindResourceTaskResultRequest req)
        {
             JsonResponseModel<DescribeCertificateBindResourceTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateBindResourceTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateBindResourceTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of an async task created with `CreateCertificateBindResourceSyncTask` to query cloud resources associated with a certificate. The following types of cloud resources are supported: CLB, CDN, WAF, LIVE, VOD, DDOS, TKE, APIGATEWAY, TCB, and TEO (EDGEONE).
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateBindResourceTaskResultRequest"/></param>
        /// <returns><see cref="DescribeCertificateBindResourceTaskResultResponse"/></returns>
        public DescribeCertificateBindResourceTaskResultResponse DescribeCertificateBindResourceTaskResultSync(DescribeCertificateBindResourceTaskResultRequest req)
        {
             JsonResponseModel<DescribeCertificateBindResourceTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificateBindResourceTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateBindResourceTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get certificate details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public async Task<DescribeCertificateDetailResponse> DescribeCertificateDetail(DescribeCertificateDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get certificate details.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateDetailRequest"/></param>
        /// <returns><see cref="DescribeCertificateDetailResponse"/></returns>
        public DescribeCertificateDetailResponse DescribeCertificateDetailSync(DescribeCertificateDetailRequest req)
        {
             JsonResponseModel<DescribeCertificateDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get certificate operation logs in the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateOperateLogsRequest"/></param>
        /// <returns><see cref="DescribeCertificateOperateLogsResponse"/></returns>
        public async Task<DescribeCertificateOperateLogsResponse> DescribeCertificateOperateLogs(DescribeCertificateOperateLogsRequest req)
        {
             JsonResponseModel<DescribeCertificateOperateLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificateOperateLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateOperateLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get certificate operation logs in the current account.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificateOperateLogsRequest"/></param>
        /// <returns><see cref="DescribeCertificateOperateLogsResponse"/></returns>
        public DescribeCertificateOperateLogsResponse DescribeCertificateOperateLogsSync(DescribeCertificateOperateLogsRequest req)
        {
             JsonResponseModel<DescribeCertificateOperateLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificateOperateLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificateOperateLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the certificate list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public async Task<DescribeCertificatesResponse> DescribeCertificates(DescribeCertificatesRequest req)
        {
             JsonResponseModel<DescribeCertificatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the certificate list.
        /// </summary>
        /// <param name="req"><see cref="DescribeCertificatesRequest"/></param>
        /// <returns><see cref="DescribeCertificatesResponse"/></returns>
        public DescribeCertificatesResponse DescribeCertificatesSync(DescribeCertificatesRequest req)
        {
             JsonResponseModel<DescribeCertificatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCertificates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCertificatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of EDGEONE instances to which a certificate can be deployed.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostTeoInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostTeoInstanceListResponse"/></returns>
        public async Task<DescribeHostTeoInstanceListResponse> DescribeHostTeoInstanceList(DescribeHostTeoInstanceListRequest req)
        {
             JsonResponseModel<DescribeHostTeoInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostTeoInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostTeoInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of EDGEONE instances to which a certificate can be deployed.
        /// </summary>
        /// <param name="req"><see cref="DescribeHostTeoInstanceListRequest"/></param>
        /// <returns><see cref="DescribeHostTeoInstanceListResponse"/></returns>
        public DescribeHostTeoInstanceListResponse DescribeHostTeoInstanceListSync(DescribeHostTeoInstanceListRequest req)
        {
             JsonResponseModel<DescribeHostTeoInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostTeoInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostTeoInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query certificate cloud resource update record list
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordResponse"/></returns>
        public async Task<DescribeHostUpdateRecordResponse> DescribeHostUpdateRecord(DescribeHostUpdateRecordRequest req)
        {
             JsonResponseModel<DescribeHostUpdateRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostUpdateRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostUpdateRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query certificate cloud resource update record list
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordResponse"/></returns>
        public DescribeHostUpdateRecordResponse DescribeHostUpdateRecordSync(DescribeHostUpdateRecordRequest req)
        {
             JsonResponseModel<DescribeHostUpdateRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostUpdateRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostUpdateRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query certificate cloud resource update record details list
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordDetailResponse"/></returns>
        public async Task<DescribeHostUpdateRecordDetailResponse> DescribeHostUpdateRecordDetail(DescribeHostUpdateRecordDetailRequest req)
        {
             JsonResponseModel<DescribeHostUpdateRecordDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHostUpdateRecordDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostUpdateRecordDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Query certificate cloud resource update record details list
        /// </summary>
        /// <param name="req"><see cref="DescribeHostUpdateRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeHostUpdateRecordDetailResponse"/></returns>
        public DescribeHostUpdateRecordDetailResponse DescribeHostUpdateRecordDetailSync(DescribeHostUpdateRecordDetailRequest req)
        {
             JsonResponseModel<DescribeHostUpdateRecordDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHostUpdateRecordDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHostUpdateRecordDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download a certificate.
        /// </summary>
        /// <param name="req"><see cref="DownloadCertificateRequest"/></param>
        /// <returns><see cref="DownloadCertificateResponse"/></returns>
        public async Task<DownloadCertificateResponse> DownloadCertificate(DownloadCertificateRequest req)
        {
             JsonResponseModel<DownloadCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to download a certificate.
        /// </summary>
        /// <param name="req"><see cref="DownloadCertificateRequest"/></param>
        /// <returns><see cref="DownloadCertificateResponse"/></returns>
        public DownloadCertificateResponse DownloadCertificateSync(DownloadCertificateRequest req)
        {
             JsonResponseModel<DownloadCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a CSR.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSRRequest"/></param>
        /// <returns><see cref="ModifyCSRResponse"/></returns>
        public async Task<ModifyCSRResponse> ModifyCSR(ModifyCSRRequest req)
        {
             JsonResponseModel<ModifyCSRResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCSR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCSRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a CSR.
        /// </summary>
        /// <param name="req"><see cref="ModifyCSRRequest"/></param>
        /// <returns><see cref="ModifyCSRResponse"/></returns>
        public ModifyCSRResponse ModifyCSRSync(ModifyCSRRequest req)
        {
             JsonResponseModel<ModifyCSRResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCSR");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCSRResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a certificate alias by passing in the certificate ID and new alias.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAliasRequest"/></param>
        /// <returns><see cref="ModifyCertificateAliasResponse"/></returns>
        public async Task<ModifyCertificateAliasResponse> ModifyCertificateAlias(ModifyCertificateAliasRequest req)
        {
             JsonResponseModel<ModifyCertificateAliasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a certificate alias by passing in the certificate ID and new alias.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateAliasRequest"/></param>
        /// <returns><see cref="ModifyCertificateAliasResponse"/></returns>
        public ModifyCertificateAliasResponse ModifyCertificateAliasSync(ModifyCertificateAliasRequest req)
        {
             JsonResponseModel<ModifyCertificateAliasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCertificateAlias");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateAliasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the projects of multiple certificates.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateProjectRequest"/></param>
        /// <returns><see cref="ModifyCertificateProjectResponse"/></returns>
        public async Task<ModifyCertificateProjectResponse> ModifyCertificateProject(ModifyCertificateProjectRequest req)
        {
             JsonResponseModel<ModifyCertificateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the projects of multiple certificates.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateProjectRequest"/></param>
        /// <returns><see cref="ModifyCertificateProjectResponse"/></returns>
        public ModifyCertificateProjectResponse ModifyCertificateProjectSync(ModifyCertificateProjectRequest req)
        {
             JsonResponseModel<ModifyCertificateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCertificateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to re-submit a review application for a paid certificate whose review failed or was canceled.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateResubmitRequest"/></param>
        /// <returns><see cref="ModifyCertificateResubmitResponse"/></returns>
        public async Task<ModifyCertificateResubmitResponse> ModifyCertificateResubmit(ModifyCertificateResubmitRequest req)
        {
             JsonResponseModel<ModifyCertificateResubmitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCertificateResubmit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateResubmitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to re-submit a review application for a paid certificate whose review failed or was canceled.
        /// </summary>
        /// <param name="req"><see cref="ModifyCertificateResubmitRequest"/></param>
        /// <returns><see cref="ModifyCertificateResubmitResponse"/></returns>
        public ModifyCertificateResubmitResponse ModifyCertificateResubmitSync(ModifyCertificateResubmitRequest req)
        {
             JsonResponseModel<ModifyCertificateResubmitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCertificateResubmit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCertificateResubmitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reissue a certificate. Note that if you have applied for a free certificate, only an RSA-2048 certificate will be reissued, and the certificate can be reissued only once.
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertificateRequest"/></param>
        /// <returns><see cref="ReplaceCertificateResponse"/></returns>
        public async Task<ReplaceCertificateResponse> ReplaceCertificate(ReplaceCertificateRequest req)
        {
             JsonResponseModel<ReplaceCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReplaceCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reissue a certificate. Note that if you have applied for a free certificate, only an RSA-2048 certificate will be reissued, and the certificate can be reissued only once.
        /// </summary>
        /// <param name="req"><see cref="ReplaceCertificateRequest"/></param>
        /// <returns><see cref="ReplaceCertificateResponse"/></returns>
        public ReplaceCertificateResponse ReplaceCertificateSync(ReplaceCertificateRequest req)
        {
             JsonResponseModel<ReplaceCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReplaceCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReplaceCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit certificate information.
        /// </summary>
        /// <param name="req"><see cref="SubmitCertificateInformationRequest"/></param>
        /// <returns><see cref="SubmitCertificateInformationResponse"/></returns>
        public async Task<SubmitCertificateInformationResponse> SubmitCertificateInformation(SubmitCertificateInformationRequest req)
        {
             JsonResponseModel<SubmitCertificateInformationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SubmitCertificateInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitCertificateInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit certificate information.
        /// </summary>
        /// <param name="req"><see cref="SubmitCertificateInformationRequest"/></param>
        /// <returns><see cref="SubmitCertificateInformationResponse"/></returns>
        public SubmitCertificateInformationResponse SubmitCertificateInformationSync(SubmitCertificateInformationRequest req)
        {
             JsonResponseModel<SubmitCertificateInformationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SubmitCertificateInformation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SubmitCertificateInformationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update old certificate resources with one click and is an asynchronous interface. After this API is called, the returned DeployRecordId being 0 indicates that the task is in progress, and the returned DeployRecordId being greater than 0 indicates that the task is successfully created. If the creation fails, an exception is returned.
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateInstanceRequest"/></param>
        /// <returns><see cref="UpdateCertificateInstanceResponse"/></returns>
        public async Task<UpdateCertificateInstanceResponse> UpdateCertificateInstance(UpdateCertificateInstanceRequest req)
        {
             JsonResponseModel<UpdateCertificateInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCertificateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCertificateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update old certificate resources with one click and is an asynchronous interface. After this API is called, the returned DeployRecordId being 0 indicates that the task is in progress, and the returned DeployRecordId being greater than 0 indicates that the task is successfully created. If the creation fails, an exception is returned.
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateInstanceRequest"/></param>
        /// <returns><see cref="UpdateCertificateInstanceResponse"/></returns>
        public UpdateCertificateInstanceResponse UpdateCertificateInstanceSync(UpdateCertificateInstanceRequest req)
        {
             JsonResponseModel<UpdateCertificateInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCertificateInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCertificateInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cloud resource update deployment retry record
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRetryRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRetryResponse"/></returns>
        public async Task<UpdateCertificateRecordRetryResponse> UpdateCertificateRecordRetry(UpdateCertificateRecordRetryRequest req)
        {
             JsonResponseModel<UpdateCertificateRecordRetryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCertificateRecordRetry");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCertificateRecordRetryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cloud resource update deployment retry record
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRetryRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRetryResponse"/></returns>
        public UpdateCertificateRecordRetryResponse UpdateCertificateRecordRetrySync(UpdateCertificateRecordRetryRequest req)
        {
             JsonResponseModel<UpdateCertificateRecordRetryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCertificateRecordRetry");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCertificateRecordRetryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cloud resource update one-click rollback
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRollbackRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRollbackResponse"/></returns>
        public async Task<UpdateCertificateRecordRollbackResponse> UpdateCertificateRecordRollback(UpdateCertificateRecordRollbackRequest req)
        {
             JsonResponseModel<UpdateCertificateRecordRollbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCertificateRecordRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCertificateRecordRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Cloud resource update one-click rollback
        /// </summary>
        /// <param name="req"><see cref="UpdateCertificateRecordRollbackRequest"/></param>
        /// <returns><see cref="UpdateCertificateRecordRollbackResponse"/></returns>
        public UpdateCertificateRecordRollbackResponse UpdateCertificateRecordRollbackSync(UpdateCertificateRecordRollbackRequest req)
        {
             JsonResponseModel<UpdateCertificateRecordRollbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCertificateRecordRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCertificateRecordRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload a certificate.
        /// </summary>
        /// <param name="req"><see cref="UploadCertificateRequest"/></param>
        /// <returns><see cref="UploadCertificateResponse"/></returns>
        public async Task<UploadCertificateResponse> UploadCertificate(UploadCertificateRequest req)
        {
             JsonResponseModel<UploadCertificateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload a certificate.
        /// </summary>
        /// <param name="req"><see cref="UploadCertificateRequest"/></param>
        /// <returns><see cref="UploadCertificateResponse"/></returns>
        public UploadCertificateResponse UploadCertificateSync(UploadCertificateRequest req)
        {
             JsonResponseModel<UploadCertificateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadCertificate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadCertificateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload the confirmation letter for a certificate.
        /// </summary>
        /// <param name="req"><see cref="UploadConfirmLetterRequest"/></param>
        /// <returns><see cref="UploadConfirmLetterResponse"/></returns>
        public async Task<UploadConfirmLetterResponse> UploadConfirmLetter(UploadConfirmLetterRequest req)
        {
             JsonResponseModel<UploadConfirmLetterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadConfirmLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadConfirmLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upload the confirmation letter for a certificate.
        /// </summary>
        /// <param name="req"><see cref="UploadConfirmLetterRequest"/></param>
        /// <returns><see cref="UploadConfirmLetterResponse"/></returns>
        public UploadConfirmLetterResponse UploadConfirmLetterSync(UploadConfirmLetterRequest req)
        {
             JsonResponseModel<UploadConfirmLetterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadConfirmLetter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadConfirmLetterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
