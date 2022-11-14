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

namespace TencentCloud.Ses.V20201002
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ses.V20201002.Models;

   public class SesClient : AbstractClient{

       private const string endpoint = "ses.tencentcloudapi.com";
       private const string version = "2020-10-02";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SesClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SesClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to send a TEXT or HTML email to multiple recipients at a time for marketing or notification purposes. By default, you can send emails using a template only. You need to create a recipient group with email addresses first and then send emails by group ID. SES supports scheduled and recurring email sending tasks. You need to pass in `TimedParam` for a scheduled task and `CycleParam` for a recurring one.
        /// </summary>
        /// <param name="req"><see cref="BatchSendEmailRequest"/></param>
        /// <returns><see cref="BatchSendEmailResponse"/></returns>
        public async Task<BatchSendEmailResponse> BatchSendEmail(BatchSendEmailRequest req)
        {
             JsonResponseModel<BatchSendEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchSendEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchSendEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send a TEXT or HTML email to multiple recipients at a time for marketing or notification purposes. By default, you can send emails using a template only. You need to create a recipient group with email addresses first and then send emails by group ID. SES supports scheduled and recurring email sending tasks. You need to pass in `TimedParam` for a scheduled task and `CycleParam` for a recurring one.
        /// </summary>
        /// <param name="req"><see cref="BatchSendEmailRequest"/></param>
        /// <returns><see cref="BatchSendEmailResponse"/></returns>
        public BatchSendEmailResponse BatchSendEmailSync(BatchSendEmailRequest req)
        {
             JsonResponseModel<BatchSendEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchSendEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchSendEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After the sender domain is verified, you need a sender address to send emails. For example, if your sender domain is mail.qcloud.com, your sender address can be service@mail.qcloud.com. If you want to display your name (such as "Tencent Cloud") in the inbox list of the recipients, the sender address should be in the format of `Tencent Cloud <email address>`. Please note that there must be a space between your name and the first angle bracket.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailAddressRequest"/></param>
        /// <returns><see cref="CreateEmailAddressResponse"/></returns>
        public async Task<CreateEmailAddressResponse> CreateEmailAddress(CreateEmailAddressRequest req)
        {
             JsonResponseModel<CreateEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// After the sender domain is verified, you need a sender address to send emails. For example, if your sender domain is mail.qcloud.com, your sender address can be service@mail.qcloud.com. If you want to display your name (such as "Tencent Cloud") in the inbox list of the recipients, the sender address should be in the format of `Tencent Cloud <email address>`. Please note that there must be a space between your name and the first angle bracket.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailAddressRequest"/></param>
        /// <returns><see cref="CreateEmailAddressResponse"/></returns>
        public CreateEmailAddressResponse CreateEmailAddressSync(CreateEmailAddressRequest req)
        {
             JsonResponseModel<CreateEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a sender domain. Before you can send an email using Tencent Cloud SES, you must create a sender domain as your identity. It can be the domain of your website or mobile app. You must verify the domain to prove that you own it and authorize Tencent Cloud SES to use it to send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailIdentityRequest"/></param>
        /// <returns><see cref="CreateEmailIdentityResponse"/></returns>
        public async Task<CreateEmailIdentityResponse> CreateEmailIdentity(CreateEmailIdentityRequest req)
        {
             JsonResponseModel<CreateEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a sender domain. Before you can send an email using Tencent Cloud SES, you must create a sender domain as your identity. It can be the domain of your website or mobile app. You must verify the domain to prove that you own it and authorize Tencent Cloud SES to use it to send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailIdentityRequest"/></param>
        /// <returns><see cref="CreateEmailIdentityResponse"/></returns>
        public CreateEmailIdentityResponse CreateEmailIdentitySync(CreateEmailIdentityRequest req)
        {
             JsonResponseModel<CreateEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TEXT or HTML email template. To create an HTML template, ensure that it does not include external CSS files. You can use {{variable name}} to specify a variable in the template.
        /// Note: Only an approved template can be used to send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailTemplateRequest"/></param>
        /// <returns><see cref="CreateEmailTemplateResponse"/></returns>
        public async Task<CreateEmailTemplateResponse> CreateEmailTemplate(CreateEmailTemplateRequest req)
        {
             JsonResponseModel<CreateEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a TEXT or HTML email template. To create an HTML template, ensure that it does not include external CSS files. You can use {{variable name}} to specify a variable in the template.
        /// Note: Only an approved template can be used to send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailTemplateRequest"/></param>
        /// <returns><see cref="CreateEmailTemplateResponse"/></returns>
        public CreateEmailTemplateResponse CreateEmailTemplateSync(CreateEmailTemplateRequest req)
        {
             JsonResponseModel<CreateEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a recipient group, which is the list of target email addresses for batch sending emails. After creating a group, you need to upload recipient email addresses. Then, you can create a sending task and select the group to batch send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverRequest"/></param>
        /// <returns><see cref="CreateReceiverResponse"/></returns>
        public async Task<CreateReceiverResponse> CreateReceiver(CreateReceiverRequest req)
        {
             JsonResponseModel<CreateReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a recipient group, which is the list of target email addresses for batch sending emails. After creating a group, you need to upload recipient email addresses. Then, you can create a sending task and select the group to batch send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverRequest"/></param>
        /// <returns><see cref="CreateReceiverResponse"/></returns>
        public CreateReceiverResponse CreateReceiverSync(CreateReceiverRequest req)
        {
             JsonResponseModel<CreateReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add recipient email addresses (up to 20,000 at a time) to a recipient group. This will be processed asynchronously. If the data volume is large, it may take some time to upload. You can check the recipient group for the upload status and upload quantity. This API has basically the same feature as that of `CreateReceiverDetailWithData` except that it doesn't support uploading template parameters for email sending. You need to first call the `CreateReceiver` API to create a recipient group, then call this API to pass in recipient addresses, and finally call the `BatchSendEmail` API to batch send emails. This API supports adding more recipient addresses during upload but not address deduplication, so you need to make sure that the recipient addresses are not duplicate by yourself. This API can request up to 20,000 recipient addresses at a time, but the recipient group can contain up to 50,000 addresses currently.
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverDetailRequest"/></param>
        /// <returns><see cref="CreateReceiverDetailResponse"/></returns>
        public async Task<CreateReceiverDetailResponse> CreateReceiverDetail(CreateReceiverDetailRequest req)
        {
             JsonResponseModel<CreateReceiverDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReceiverDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReceiverDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add recipient email addresses (up to 20,000 at a time) to a recipient group. This will be processed asynchronously. If the data volume is large, it may take some time to upload. You can check the recipient group for the upload status and upload quantity. This API has basically the same feature as that of `CreateReceiverDetailWithData` except that it doesn't support uploading template parameters for email sending. You need to first call the `CreateReceiver` API to create a recipient group, then call this API to pass in recipient addresses, and finally call the `BatchSendEmail` API to batch send emails. This API supports adding more recipient addresses during upload but not address deduplication, so you need to make sure that the recipient addresses are not duplicate by yourself. This API can request up to 20,000 recipient addresses at a time, but the recipient group can contain up to 50,000 addresses currently.
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverDetailRequest"/></param>
        /// <returns><see cref="CreateReceiverDetailResponse"/></returns>
        public CreateReceiverDetailResponse CreateReceiverDetailSync(CreateReceiverDetailRequest req)
        {
             JsonResponseModel<CreateReceiverDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReceiverDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReceiverDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unblocklist email addresses. If you confirm that a blocklisted recipient address is valid and active, you can remove it from Tencent Cloud’s address blocklist database.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackListRequest"/></param>
        /// <returns><see cref="DeleteBlackListResponse"/></returns>
        public async Task<DeleteBlackListResponse> DeleteBlackList(DeleteBlackListRequest req)
        {
             JsonResponseModel<DeleteBlackListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBlackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unblocklist email addresses. If you confirm that a blocklisted recipient address is valid and active, you can remove it from Tencent Cloud’s address blocklist database.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackListRequest"/></param>
        /// <returns><see cref="DeleteBlackListResponse"/></returns>
        public DeleteBlackListResponse DeleteBlackListSync(DeleteBlackListRequest req)
        {
             JsonResponseModel<DeleteBlackListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBlackList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBlackListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a sender address.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailAddressRequest"/></param>
        /// <returns><see cref="DeleteEmailAddressResponse"/></returns>
        public async Task<DeleteEmailAddressResponse> DeleteEmailAddress(DeleteEmailAddressRequest req)
        {
             JsonResponseModel<DeleteEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a sender address.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailAddressRequest"/></param>
        /// <returns><see cref="DeleteEmailAddressResponse"/></returns>
        public DeleteEmailAddressResponse DeleteEmailAddressSync(DeleteEmailAddressRequest req)
        {
             JsonResponseModel<DeleteEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a sender domain. After deleted, the sender domain can no longer be used to send emails.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailIdentityRequest"/></param>
        /// <returns><see cref="DeleteEmailIdentityResponse"/></returns>
        public async Task<DeleteEmailIdentityResponse> DeleteEmailIdentity(DeleteEmailIdentityRequest req)
        {
             JsonResponseModel<DeleteEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a sender domain. After deleted, the sender domain can no longer be used to send emails.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailIdentityRequest"/></param>
        /// <returns><see cref="DeleteEmailIdentityResponse"/></returns>
        public DeleteEmailIdentityResponse DeleteEmailIdentitySync(DeleteEmailIdentityRequest req)
        {
             JsonResponseModel<DeleteEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an email template.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailTemplateRequest"/></param>
        /// <returns><see cref="DeleteEmailTemplateResponse"/></returns>
        public async Task<DeleteEmailTemplateResponse> DeleteEmailTemplate(DeleteEmailTemplateRequest req)
        {
             JsonResponseModel<DeleteEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an email template.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailTemplateRequest"/></param>
        /// <returns><see cref="DeleteEmailTemplateResponse"/></returns>
        public DeleteEmailTemplateResponse DeleteEmailTemplateSync(DeleteEmailTemplateRequest req)
        {
             JsonResponseModel<DeleteEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recipient group and all recipient email addresses in the group based on the recipient group ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteReceiverRequest"/></param>
        /// <returns><see cref="DeleteReceiverResponse"/></returns>
        public async Task<DeleteReceiverResponse> DeleteReceiver(DeleteReceiverRequest req)
        {
             JsonResponseModel<DeleteReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a recipient group and all recipient email addresses in the group based on the recipient group ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteReceiverRequest"/></param>
        /// <returns><see cref="DeleteReceiverResponse"/></returns>
        public DeleteReceiverResponse DeleteReceiverSync(DeleteReceiverRequest req)
        {
             JsonResponseModel<DeleteReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the configuration details of a sender domain.
        /// </summary>
        /// <param name="req"><see cref="GetEmailIdentityRequest"/></param>
        /// <returns><see cref="GetEmailIdentityResponse"/></returns>
        public async Task<GetEmailIdentityResponse> GetEmailIdentity(GetEmailIdentityRequest req)
        {
             JsonResponseModel<GetEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the configuration details of a sender domain.
        /// </summary>
        /// <param name="req"><see cref="GetEmailIdentityRequest"/></param>
        /// <returns><see cref="GetEmailIdentityResponse"/></returns>
        public GetEmailIdentityResponse GetEmailIdentitySync(GetEmailIdentityRequest req)
        {
             JsonResponseModel<GetEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a template.
        /// </summary>
        /// <param name="req"><see cref="GetEmailTemplateRequest"/></param>
        /// <returns><see cref="GetEmailTemplateResponse"/></returns>
        public async Task<GetEmailTemplateResponse> GetEmailTemplate(GetEmailTemplateRequest req)
        {
             JsonResponseModel<GetEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a template.
        /// </summary>
        /// <param name="req"><see cref="GetEmailTemplateRequest"/></param>
        /// <returns><see cref="GetEmailTemplateResponse"/></returns>
        public GetEmailTemplateResponse GetEmailTemplateSync(GetEmailTemplateRequest req)
        {
             JsonResponseModel<GetEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get email sending status. Only data within 30 days can be queried.
        /// Default API request rate limit: 1 request/sec.
        /// </summary>
        /// <param name="req"><see cref="GetSendEmailStatusRequest"/></param>
        /// <returns><see cref="GetSendEmailStatusResponse"/></returns>
        public async Task<GetSendEmailStatusResponse> GetSendEmailStatus(GetSendEmailStatusRequest req)
        {
             JsonResponseModel<GetSendEmailStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSendEmailStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSendEmailStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get email sending status. Only data within 30 days can be queried.
        /// Default API request rate limit: 1 request/sec.
        /// </summary>
        /// <param name="req"><see cref="GetSendEmailStatusRequest"/></param>
        /// <returns><see cref="GetSendEmailStatusResponse"/></returns>
        public GetSendEmailStatusResponse GetSendEmailStatusSync(GetSendEmailStatusRequest req)
        {
             JsonResponseModel<GetSendEmailStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSendEmailStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSendEmailStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the email sending statistics over a recent period, including data on sent emails, delivery success rate, open rate, bounce rate, and so on.
        /// </summary>
        /// <param name="req"><see cref="GetStatisticsReportRequest"/></param>
        /// <returns><see cref="GetStatisticsReportResponse"/></returns>
        public async Task<GetStatisticsReportResponse> GetStatisticsReport(GetStatisticsReportRequest req)
        {
             JsonResponseModel<GetStatisticsReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetStatisticsReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStatisticsReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the email sending statistics over a recent period, including data on sent emails, delivery success rate, open rate, bounce rate, and so on.
        /// </summary>
        /// <param name="req"><see cref="GetStatisticsReportRequest"/></param>
        /// <returns><see cref="GetStatisticsReportResponse"/></returns>
        public GetStatisticsReportResponse GetStatisticsReportSync(GetStatisticsReportRequest req)
        {
             JsonResponseModel<GetStatisticsReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetStatisticsReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetStatisticsReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The API is used to get blocklisted addresses. In the case of a hard bounce, Tencent Cloud will blocklist the recipient address and do not allow any user to send emails to this address. If you confirm that this is a misjudgment, you can remove it from the blocklist.
        /// </summary>
        /// <param name="req"><see cref="ListBlackEmailAddressRequest"/></param>
        /// <returns><see cref="ListBlackEmailAddressResponse"/></returns>
        public async Task<ListBlackEmailAddressResponse> ListBlackEmailAddress(ListBlackEmailAddressRequest req)
        {
             JsonResponseModel<ListBlackEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListBlackEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListBlackEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// The API is used to get blocklisted addresses. In the case of a hard bounce, Tencent Cloud will blocklist the recipient address and do not allow any user to send emails to this address. If you confirm that this is a misjudgment, you can remove it from the blocklist.
        /// </summary>
        /// <param name="req"><see cref="ListBlackEmailAddressRequest"/></param>
        /// <returns><see cref="ListBlackEmailAddressResponse"/></returns>
        public ListBlackEmailAddressResponse ListBlackEmailAddressSync(ListBlackEmailAddressRequest req)
        {
             JsonResponseModel<ListBlackEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListBlackEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListBlackEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of sender addresses.
        /// </summary>
        /// <param name="req"><see cref="ListEmailAddressRequest"/></param>
        /// <returns><see cref="ListEmailAddressResponse"/></returns>
        public async Task<ListEmailAddressResponse> ListEmailAddress(ListEmailAddressRequest req)
        {
             JsonResponseModel<ListEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of sender addresses.
        /// </summary>
        /// <param name="req"><see cref="ListEmailAddressRequest"/></param>
        /// <returns><see cref="ListEmailAddressResponse"/></returns>
        public ListEmailAddressResponse ListEmailAddressSync(ListEmailAddressRequest req)
        {
             JsonResponseModel<ListEmailAddressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEmailAddress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailAddressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of sender domains, including verified and unverified domains.
        /// </summary>
        /// <param name="req"><see cref="ListEmailIdentitiesRequest"/></param>
        /// <returns><see cref="ListEmailIdentitiesResponse"/></returns>
        public async Task<ListEmailIdentitiesResponse> ListEmailIdentities(ListEmailIdentitiesRequest req)
        {
             JsonResponseModel<ListEmailIdentitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEmailIdentities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailIdentitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of sender domains, including verified and unverified domains.
        /// </summary>
        /// <param name="req"><see cref="ListEmailIdentitiesRequest"/></param>
        /// <returns><see cref="ListEmailIdentitiesResponse"/></returns>
        public ListEmailIdentitiesResponse ListEmailIdentitiesSync(ListEmailIdentitiesRequest req)
        {
             JsonResponseModel<ListEmailIdentitiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEmailIdentities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailIdentitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of email templates.
        /// </summary>
        /// <param name="req"><see cref="ListEmailTemplatesRequest"/></param>
        /// <returns><see cref="ListEmailTemplatesResponse"/></returns>
        public async Task<ListEmailTemplatesResponse> ListEmailTemplates(ListEmailTemplatesRequest req)
        {
             JsonResponseModel<ListEmailTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListEmailTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of email templates.
        /// </summary>
        /// <param name="req"><see cref="ListEmailTemplatesRequest"/></param>
        /// <returns><see cref="ListEmailTemplatesResponse"/></returns>
        public ListEmailTemplatesResponse ListEmailTemplatesSync(ListEmailTemplatesRequest req)
        {
             JsonResponseModel<ListEmailTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListEmailTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListEmailTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query recipient groups. It supports pagination, fuzzy query, and query by status.
        /// </summary>
        /// <param name="req"><see cref="ListReceiversRequest"/></param>
        /// <returns><see cref="ListReceiversResponse"/></returns>
        public async Task<ListReceiversResponse> ListReceivers(ListReceiversRequest req)
        {
             JsonResponseModel<ListReceiversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query recipient groups. It supports pagination, fuzzy query, and query by status.
        /// </summary>
        /// <param name="req"><see cref="ListReceiversRequest"/></param>
        /// <returns><see cref="ListReceiversResponse"/></returns>
        public ListReceiversResponse ListReceiversSync(ListReceiversRequest req)
        {
             JsonResponseModel<ListReceiversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query batch email sending tasks (including immediate, scheduled, and recurring tasks) by page. You can query task data including the number of emails requested to be sent, the number of sent emails, the number of cached emails, and task status.
        /// </summary>
        /// <param name="req"><see cref="ListSendTasksRequest"/></param>
        /// <returns><see cref="ListSendTasksResponse"/></returns>
        public async Task<ListSendTasksResponse> ListSendTasks(ListSendTasksRequest req)
        {
             JsonResponseModel<ListSendTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListSendTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSendTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query batch email sending tasks (including immediate, scheduled, and recurring tasks) by page. You can query task data including the number of emails requested to be sent, the number of sent emails, the number of cached emails, and task status.
        /// </summary>
        /// <param name="req"><see cref="ListSendTasksRequest"/></param>
        /// <returns><see cref="ListSendTasksResponse"/></returns>
        public ListSendTasksResponse ListSendTasksSync(ListSendTasksRequest req)
        {
             JsonResponseModel<ListSendTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListSendTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListSendTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send an HTML or TEXT email triggered for authentication or transaction. By default, you can send emails using a template only.
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public async Task<SendEmailResponse> SendEmail(SendEmailRequest req)
        {
             JsonResponseModel<SendEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send an HTML or TEXT email triggered for authentication or transaction. By default, you can send emails using a template only.
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public SendEmailResponse SendEmailSync(SendEmailRequest req)
        {
             JsonResponseModel<SendEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify whether your DNS configuration is correct.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailIdentityRequest"/></param>
        /// <returns><see cref="UpdateEmailIdentityResponse"/></returns>
        public async Task<UpdateEmailIdentityResponse> UpdateEmailIdentity(UpdateEmailIdentityRequest req)
        {
             JsonResponseModel<UpdateEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to verify whether your DNS configuration is correct.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailIdentityRequest"/></param>
        /// <returns><see cref="UpdateEmailIdentityResponse"/></returns>
        public UpdateEmailIdentityResponse UpdateEmailIdentitySync(UpdateEmailIdentityRequest req)
        {
             JsonResponseModel<UpdateEmailIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEmailIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEmailIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update an email template. An updated template must be approved again before it can be used.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailTemplateRequest"/></param>
        /// <returns><see cref="UpdateEmailTemplateResponse"/></returns>
        public async Task<UpdateEmailTemplateResponse> UpdateEmailTemplate(UpdateEmailTemplateRequest req)
        {
             JsonResponseModel<UpdateEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to update an email template. An updated template must be approved again before it can be used.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailTemplateRequest"/></param>
        /// <returns><see cref="UpdateEmailTemplateResponse"/></returns>
        public UpdateEmailTemplateResponse UpdateEmailTemplateSync(UpdateEmailTemplateRequest req)
        {
             JsonResponseModel<UpdateEmailTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateEmailTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateEmailTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
