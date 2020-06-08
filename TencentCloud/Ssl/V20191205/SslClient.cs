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
        /// This API is used to obtain certificate information.
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
        /// This API is used to obtain certificate information.
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
        /// This API is used to obtain certificate details.
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
        /// This API is used to obtain certificate details.
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
        /// This API is used to obtain certificate operation logs in the current account.
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
        /// This API is used to obtain certificate operation logs in the current account.
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
        /// This API is used to obtain the certificate list.
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
        /// This API is used to obtain the certificate list.
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
        /// This API is used to modify certificate alias by inputting the certificate ID and new alias.
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
        /// This API is used to modify certificate alias by inputting the certificate ID and new alias.
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

    }
}
