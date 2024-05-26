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
       private const string sdkVersion = "SDK_NET_3.0.905";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SesClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to send a TEXT or HTML email to multiple recipients at a time for marketing or notification purposes. By default, you can send emails using a template only. You need to create a recipient group with email addresses first and then send emails by group ID. SES supports scheduled and recurring email sending tasks. You need to pass in `TimedParam` for a scheduled task and `CycleParam` for a recurring one.
        /// </summary>
        /// <param name="req"><see cref="BatchSendEmailRequest"/></param>
        /// <returns><see cref="BatchSendEmailResponse"/></returns>
        public Task<BatchSendEmailResponse> BatchSendEmail(BatchSendEmailRequest req)
        {
            return InternalRequestAsync<BatchSendEmailResponse>(req, "BatchSendEmail");
        }

        /// <summary>
        /// This API is used to send a TEXT or HTML email to multiple recipients at a time for marketing or notification purposes. By default, you can send emails using a template only. You need to create a recipient group with email addresses first and then send emails by group ID. SES supports scheduled and recurring email sending tasks. You need to pass in `TimedParam` for a scheduled task and `CycleParam` for a recurring one.
        /// </summary>
        /// <param name="req"><see cref="BatchSendEmailRequest"/></param>
        /// <returns><see cref="BatchSendEmailResponse"/></returns>
        public BatchSendEmailResponse BatchSendEmailSync(BatchSendEmailRequest req)
        {
            return InternalRequestAsync<BatchSendEmailResponse>(req, "BatchSendEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// After the sender domain is verified, you need a sender address to send emails. For example, if your sender domain is mail.qcloud.com, your sender address can be service@mail.qcloud.com. If you want to display your name (such as "Tencent Cloud") in the inbox list of the recipients, the sender address should be in the format of `Tencent Cloud <email address>`. Please note that there must be a space between your name and the first angle bracket.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailAddressRequest"/></param>
        /// <returns><see cref="CreateEmailAddressResponse"/></returns>
        public Task<CreateEmailAddressResponse> CreateEmailAddress(CreateEmailAddressRequest req)
        {
            return InternalRequestAsync<CreateEmailAddressResponse>(req, "CreateEmailAddress");
        }

        /// <summary>
        /// After the sender domain is verified, you need a sender address to send emails. For example, if your sender domain is mail.qcloud.com, your sender address can be service@mail.qcloud.com. If you want to display your name (such as "Tencent Cloud") in the inbox list of the recipients, the sender address should be in the format of `Tencent Cloud <email address>`. Please note that there must be a space between your name and the first angle bracket.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailAddressRequest"/></param>
        /// <returns><see cref="CreateEmailAddressResponse"/></returns>
        public CreateEmailAddressResponse CreateEmailAddressSync(CreateEmailAddressRequest req)
        {
            return InternalRequestAsync<CreateEmailAddressResponse>(req, "CreateEmailAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a sender domain. Before you can send an email using Tencent Cloud SES, you must create a sender domain as your identity. It can be the domain of your website or mobile app. You must verify the domain to prove that you own it and authorize Tencent Cloud SES to use it to send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailIdentityRequest"/></param>
        /// <returns><see cref="CreateEmailIdentityResponse"/></returns>
        public Task<CreateEmailIdentityResponse> CreateEmailIdentity(CreateEmailIdentityRequest req)
        {
            return InternalRequestAsync<CreateEmailIdentityResponse>(req, "CreateEmailIdentity");
        }

        /// <summary>
        /// This API is used to create a sender domain. Before you can send an email using Tencent Cloud SES, you must create a sender domain as your identity. It can be the domain of your website or mobile app. You must verify the domain to prove that you own it and authorize Tencent Cloud SES to use it to send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailIdentityRequest"/></param>
        /// <returns><see cref="CreateEmailIdentityResponse"/></returns>
        public CreateEmailIdentityResponse CreateEmailIdentitySync(CreateEmailIdentityRequest req)
        {
            return InternalRequestAsync<CreateEmailIdentityResponse>(req, "CreateEmailIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a TEXT or HTML email template. To create an HTML template, ensure that it does not include external CSS files. You can use {{variable name}} to specify a variable in the template.
        /// Note: Only an approved template can be used to send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailTemplateRequest"/></param>
        /// <returns><see cref="CreateEmailTemplateResponse"/></returns>
        public Task<CreateEmailTemplateResponse> CreateEmailTemplate(CreateEmailTemplateRequest req)
        {
            return InternalRequestAsync<CreateEmailTemplateResponse>(req, "CreateEmailTemplate");
        }

        /// <summary>
        /// This API is used to create a TEXT or HTML email template. To create an HTML template, ensure that it does not include external CSS files. You can use {{variable name}} to specify a variable in the template.
        /// Note: Only an approved template can be used to send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateEmailTemplateRequest"/></param>
        /// <returns><see cref="CreateEmailTemplateResponse"/></returns>
        public CreateEmailTemplateResponse CreateEmailTemplateSync(CreateEmailTemplateRequest req)
        {
            return InternalRequestAsync<CreateEmailTemplateResponse>(req, "CreateEmailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a recipient group, which is the list of target email addresses for batch sending emails. After creating a group, you need to upload recipient email addresses. Then, you can create a sending task and select the group to batch send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverRequest"/></param>
        /// <returns><see cref="CreateReceiverResponse"/></returns>
        public Task<CreateReceiverResponse> CreateReceiver(CreateReceiverRequest req)
        {
            return InternalRequestAsync<CreateReceiverResponse>(req, "CreateReceiver");
        }

        /// <summary>
        /// This API is used to create a recipient group, which is the list of target email addresses for batch sending emails. After creating a group, you need to upload recipient email addresses. Then, you can create a sending task and select the group to batch send emails.
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverRequest"/></param>
        /// <returns><see cref="CreateReceiverResponse"/></returns>
        public CreateReceiverResponse CreateReceiverSync(CreateReceiverRequest req)
        {
            return InternalRequestAsync<CreateReceiverResponse>(req, "CreateReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add recipient email addresses (up to 20,000 at a time) to a recipient group. This will be processed asynchronously. If the data volume is large, it may take some time to upload. You can check the recipient group for the upload status and upload quantity. This API has basically the same feature as that of `CreateReceiverDetailWithData` except that it doesn't support uploading template parameters for email sending. You need to first call the `CreateReceiver` API to create a recipient group, then call this API to pass in recipient addresses, and finally call the `BatchSendEmail` API to batch send emails. This API supports adding more recipient addresses during upload but not address deduplication, so you need to make sure that the recipient addresses are not duplicate by yourself. This API can request up to 20,000 recipient addresses at a time, but the recipient group can contain up to 50,000 addresses currently.
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverDetailRequest"/></param>
        /// <returns><see cref="CreateReceiverDetailResponse"/></returns>
        public Task<CreateReceiverDetailResponse> CreateReceiverDetail(CreateReceiverDetailRequest req)
        {
            return InternalRequestAsync<CreateReceiverDetailResponse>(req, "CreateReceiverDetail");
        }

        /// <summary>
        /// This API is used to add recipient email addresses (up to 20,000 at a time) to a recipient group. This will be processed asynchronously. If the data volume is large, it may take some time to upload. You can check the recipient group for the upload status and upload quantity. This API has basically the same feature as that of `CreateReceiverDetailWithData` except that it doesn't support uploading template parameters for email sending. You need to first call the `CreateReceiver` API to create a recipient group, then call this API to pass in recipient addresses, and finally call the `BatchSendEmail` API to batch send emails. This API supports adding more recipient addresses during upload but not address deduplication, so you need to make sure that the recipient addresses are not duplicate by yourself. This API can request up to 20,000 recipient addresses at a time, but the recipient group can contain up to 50,000 addresses currently.
        /// </summary>
        /// <param name="req"><see cref="CreateReceiverDetailRequest"/></param>
        /// <returns><see cref="CreateReceiverDetailResponse"/></returns>
        public CreateReceiverDetailResponse CreateReceiverDetailSync(CreateReceiverDetailRequest req)
        {
            return InternalRequestAsync<CreateReceiverDetailResponse>(req, "CreateReceiverDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unblocklist email addresses. If you confirm that a blocklisted recipient address is valid and active, you can remove it from Tencent Cloud’s address blocklist database.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackListRequest"/></param>
        /// <returns><see cref="DeleteBlackListResponse"/></returns>
        public Task<DeleteBlackListResponse> DeleteBlackList(DeleteBlackListRequest req)
        {
            return InternalRequestAsync<DeleteBlackListResponse>(req, "DeleteBlackList");
        }

        /// <summary>
        /// This API is used to unblocklist email addresses. If you confirm that a blocklisted recipient address is valid and active, you can remove it from Tencent Cloud’s address blocklist database.
        /// </summary>
        /// <param name="req"><see cref="DeleteBlackListRequest"/></param>
        /// <returns><see cref="DeleteBlackListResponse"/></returns>
        public DeleteBlackListResponse DeleteBlackListSync(DeleteBlackListRequest req)
        {
            return InternalRequestAsync<DeleteBlackListResponse>(req, "DeleteBlackList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a sender address.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailAddressRequest"/></param>
        /// <returns><see cref="DeleteEmailAddressResponse"/></returns>
        public Task<DeleteEmailAddressResponse> DeleteEmailAddress(DeleteEmailAddressRequest req)
        {
            return InternalRequestAsync<DeleteEmailAddressResponse>(req, "DeleteEmailAddress");
        }

        /// <summary>
        /// This API is used to delete a sender address.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailAddressRequest"/></param>
        /// <returns><see cref="DeleteEmailAddressResponse"/></returns>
        public DeleteEmailAddressResponse DeleteEmailAddressSync(DeleteEmailAddressRequest req)
        {
            return InternalRequestAsync<DeleteEmailAddressResponse>(req, "DeleteEmailAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a sender domain. After deleted, the sender domain can no longer be used to send emails.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailIdentityRequest"/></param>
        /// <returns><see cref="DeleteEmailIdentityResponse"/></returns>
        public Task<DeleteEmailIdentityResponse> DeleteEmailIdentity(DeleteEmailIdentityRequest req)
        {
            return InternalRequestAsync<DeleteEmailIdentityResponse>(req, "DeleteEmailIdentity");
        }

        /// <summary>
        /// This API is used to delete a sender domain. After deleted, the sender domain can no longer be used to send emails.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailIdentityRequest"/></param>
        /// <returns><see cref="DeleteEmailIdentityResponse"/></returns>
        public DeleteEmailIdentityResponse DeleteEmailIdentitySync(DeleteEmailIdentityRequest req)
        {
            return InternalRequestAsync<DeleteEmailIdentityResponse>(req, "DeleteEmailIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an email template.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailTemplateRequest"/></param>
        /// <returns><see cref="DeleteEmailTemplateResponse"/></returns>
        public Task<DeleteEmailTemplateResponse> DeleteEmailTemplate(DeleteEmailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEmailTemplateResponse>(req, "DeleteEmailTemplate");
        }

        /// <summary>
        /// This API is used to delete an email template.
        /// </summary>
        /// <param name="req"><see cref="DeleteEmailTemplateRequest"/></param>
        /// <returns><see cref="DeleteEmailTemplateResponse"/></returns>
        public DeleteEmailTemplateResponse DeleteEmailTemplateSync(DeleteEmailTemplateRequest req)
        {
            return InternalRequestAsync<DeleteEmailTemplateResponse>(req, "DeleteEmailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a recipient group and all recipient email addresses in the group based on the recipient group ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteReceiverRequest"/></param>
        /// <returns><see cref="DeleteReceiverResponse"/></returns>
        public Task<DeleteReceiverResponse> DeleteReceiver(DeleteReceiverRequest req)
        {
            return InternalRequestAsync<DeleteReceiverResponse>(req, "DeleteReceiver");
        }

        /// <summary>
        /// This API is used to delete a recipient group and all recipient email addresses in the group based on the recipient group ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteReceiverRequest"/></param>
        /// <returns><see cref="DeleteReceiverResponse"/></returns>
        public DeleteReceiverResponse DeleteReceiverSync(DeleteReceiverRequest req)
        {
            return InternalRequestAsync<DeleteReceiverResponse>(req, "DeleteReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the configuration details of a sender domain.
        /// </summary>
        /// <param name="req"><see cref="GetEmailIdentityRequest"/></param>
        /// <returns><see cref="GetEmailIdentityResponse"/></returns>
        public Task<GetEmailIdentityResponse> GetEmailIdentity(GetEmailIdentityRequest req)
        {
            return InternalRequestAsync<GetEmailIdentityResponse>(req, "GetEmailIdentity");
        }

        /// <summary>
        /// This API is used to get the configuration details of a sender domain.
        /// </summary>
        /// <param name="req"><see cref="GetEmailIdentityRequest"/></param>
        /// <returns><see cref="GetEmailIdentityResponse"/></returns>
        public GetEmailIdentityResponse GetEmailIdentitySync(GetEmailIdentityRequest req)
        {
            return InternalRequestAsync<GetEmailIdentityResponse>(req, "GetEmailIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a template.
        /// </summary>
        /// <param name="req"><see cref="GetEmailTemplateRequest"/></param>
        /// <returns><see cref="GetEmailTemplateResponse"/></returns>
        public Task<GetEmailTemplateResponse> GetEmailTemplate(GetEmailTemplateRequest req)
        {
            return InternalRequestAsync<GetEmailTemplateResponse>(req, "GetEmailTemplate");
        }

        /// <summary>
        /// This API is used to get the details of a template.
        /// </summary>
        /// <param name="req"><see cref="GetEmailTemplateRequest"/></param>
        /// <returns><see cref="GetEmailTemplateResponse"/></returns>
        public GetEmailTemplateResponse GetEmailTemplateSync(GetEmailTemplateRequest req)
        {
            return InternalRequestAsync<GetEmailTemplateResponse>(req, "GetEmailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get email sending status. Only data within 30 days can be queried.
        /// Default API request rate limit: 1 request/sec.
        /// </summary>
        /// <param name="req"><see cref="GetSendEmailStatusRequest"/></param>
        /// <returns><see cref="GetSendEmailStatusResponse"/></returns>
        public Task<GetSendEmailStatusResponse> GetSendEmailStatus(GetSendEmailStatusRequest req)
        {
            return InternalRequestAsync<GetSendEmailStatusResponse>(req, "GetSendEmailStatus");
        }

        /// <summary>
        /// This API is used to get email sending status. Only data within 30 days can be queried.
        /// Default API request rate limit: 1 request/sec.
        /// </summary>
        /// <param name="req"><see cref="GetSendEmailStatusRequest"/></param>
        /// <returns><see cref="GetSendEmailStatusResponse"/></returns>
        public GetSendEmailStatusResponse GetSendEmailStatusSync(GetSendEmailStatusRequest req)
        {
            return InternalRequestAsync<GetSendEmailStatusResponse>(req, "GetSendEmailStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the email sending statistics over a recent period, including data on sent emails, delivery success rate, open rate, bounce rate, and so on.
        /// </summary>
        /// <param name="req"><see cref="GetStatisticsReportRequest"/></param>
        /// <returns><see cref="GetStatisticsReportResponse"/></returns>
        public Task<GetStatisticsReportResponse> GetStatisticsReport(GetStatisticsReportRequest req)
        {
            return InternalRequestAsync<GetStatisticsReportResponse>(req, "GetStatisticsReport");
        }

        /// <summary>
        /// This API is used to get the email sending statistics over a recent period, including data on sent emails, delivery success rate, open rate, bounce rate, and so on.
        /// </summary>
        /// <param name="req"><see cref="GetStatisticsReportRequest"/></param>
        /// <returns><see cref="GetStatisticsReportResponse"/></returns>
        public GetStatisticsReportResponse GetStatisticsReportSync(GetStatisticsReportRequest req)
        {
            return InternalRequestAsync<GetStatisticsReportResponse>(req, "GetStatisticsReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The API is used to get blocklisted addresses. In the case of a hard bounce, Tencent Cloud will blocklist the recipient address and do not allow any user to send emails to this address. If you confirm that this is a misjudgment, you can remove it from the blocklist.
        /// </summary>
        /// <param name="req"><see cref="ListBlackEmailAddressRequest"/></param>
        /// <returns><see cref="ListBlackEmailAddressResponse"/></returns>
        public Task<ListBlackEmailAddressResponse> ListBlackEmailAddress(ListBlackEmailAddressRequest req)
        {
            return InternalRequestAsync<ListBlackEmailAddressResponse>(req, "ListBlackEmailAddress");
        }

        /// <summary>
        /// The API is used to get blocklisted addresses. In the case of a hard bounce, Tencent Cloud will blocklist the recipient address and do not allow any user to send emails to this address. If you confirm that this is a misjudgment, you can remove it from the blocklist.
        /// </summary>
        /// <param name="req"><see cref="ListBlackEmailAddressRequest"/></param>
        /// <returns><see cref="ListBlackEmailAddressResponse"/></returns>
        public ListBlackEmailAddressResponse ListBlackEmailAddressSync(ListBlackEmailAddressRequest req)
        {
            return InternalRequestAsync<ListBlackEmailAddressResponse>(req, "ListBlackEmailAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of sender addresses.
        /// </summary>
        /// <param name="req"><see cref="ListEmailAddressRequest"/></param>
        /// <returns><see cref="ListEmailAddressResponse"/></returns>
        public Task<ListEmailAddressResponse> ListEmailAddress(ListEmailAddressRequest req)
        {
            return InternalRequestAsync<ListEmailAddressResponse>(req, "ListEmailAddress");
        }

        /// <summary>
        /// This API is used to get the list of sender addresses.
        /// </summary>
        /// <param name="req"><see cref="ListEmailAddressRequest"/></param>
        /// <returns><see cref="ListEmailAddressResponse"/></returns>
        public ListEmailAddressResponse ListEmailAddressSync(ListEmailAddressRequest req)
        {
            return InternalRequestAsync<ListEmailAddressResponse>(req, "ListEmailAddress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of sender domains, including verified and unverified domains.
        /// </summary>
        /// <param name="req"><see cref="ListEmailIdentitiesRequest"/></param>
        /// <returns><see cref="ListEmailIdentitiesResponse"/></returns>
        public Task<ListEmailIdentitiesResponse> ListEmailIdentities(ListEmailIdentitiesRequest req)
        {
            return InternalRequestAsync<ListEmailIdentitiesResponse>(req, "ListEmailIdentities");
        }

        /// <summary>
        /// This API is used to get the list of sender domains, including verified and unverified domains.
        /// </summary>
        /// <param name="req"><see cref="ListEmailIdentitiesRequest"/></param>
        /// <returns><see cref="ListEmailIdentitiesResponse"/></returns>
        public ListEmailIdentitiesResponse ListEmailIdentitiesSync(ListEmailIdentitiesRequest req)
        {
            return InternalRequestAsync<ListEmailIdentitiesResponse>(req, "ListEmailIdentities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of email templates.
        /// </summary>
        /// <param name="req"><see cref="ListEmailTemplatesRequest"/></param>
        /// <returns><see cref="ListEmailTemplatesResponse"/></returns>
        public Task<ListEmailTemplatesResponse> ListEmailTemplates(ListEmailTemplatesRequest req)
        {
            return InternalRequestAsync<ListEmailTemplatesResponse>(req, "ListEmailTemplates");
        }

        /// <summary>
        /// This API is used to get the list of email templates.
        /// </summary>
        /// <param name="req"><see cref="ListEmailTemplatesRequest"/></param>
        /// <returns><see cref="ListEmailTemplatesResponse"/></returns>
        public ListEmailTemplatesResponse ListEmailTemplatesSync(ListEmailTemplatesRequest req)
        {
            return InternalRequestAsync<ListEmailTemplatesResponse>(req, "ListEmailTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query recipient groups. It supports pagination, fuzzy query, and query by status.
        /// </summary>
        /// <param name="req"><see cref="ListReceiversRequest"/></param>
        /// <returns><see cref="ListReceiversResponse"/></returns>
        public Task<ListReceiversResponse> ListReceivers(ListReceiversRequest req)
        {
            return InternalRequestAsync<ListReceiversResponse>(req, "ListReceivers");
        }

        /// <summary>
        /// This API is used to query recipient groups. It supports pagination, fuzzy query, and query by status.
        /// </summary>
        /// <param name="req"><see cref="ListReceiversRequest"/></param>
        /// <returns><see cref="ListReceiversResponse"/></returns>
        public ListReceiversResponse ListReceiversSync(ListReceiversRequest req)
        {
            return InternalRequestAsync<ListReceiversResponse>(req, "ListReceivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query batch email sending tasks (including immediate, scheduled, and recurring tasks) by page. You can query task data including the number of emails requested to be sent, the number of sent emails, the number of cached emails, and task status.
        /// </summary>
        /// <param name="req"><see cref="ListSendTasksRequest"/></param>
        /// <returns><see cref="ListSendTasksResponse"/></returns>
        public Task<ListSendTasksResponse> ListSendTasks(ListSendTasksRequest req)
        {
            return InternalRequestAsync<ListSendTasksResponse>(req, "ListSendTasks");
        }

        /// <summary>
        /// This API is used to query batch email sending tasks (including immediate, scheduled, and recurring tasks) by page. You can query task data including the number of emails requested to be sent, the number of sent emails, the number of cached emails, and task status.
        /// </summary>
        /// <param name="req"><see cref="ListSendTasksRequest"/></param>
        /// <returns><see cref="ListSendTasksResponse"/></returns>
        public ListSendTasksResponse ListSendTasksSync(ListSendTasksRequest req)
        {
            return InternalRequestAsync<ListSendTasksResponse>(req, "ListSendTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send an HTML or TEXT email triggered for authentication or transaction. By default, you can send emails using a template only.
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public Task<SendEmailResponse> SendEmail(SendEmailRequest req)
        {
            return InternalRequestAsync<SendEmailResponse>(req, "SendEmail");
        }

        /// <summary>
        /// This API is used to send an HTML or TEXT email triggered for authentication or transaction. By default, you can send emails using a template only.
        /// </summary>
        /// <param name="req"><see cref="SendEmailRequest"/></param>
        /// <returns><see cref="SendEmailResponse"/></returns>
        public SendEmailResponse SendEmailSync(SendEmailRequest req)
        {
            return InternalRequestAsync<SendEmailResponse>(req, "SendEmail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify whether your DNS configuration is correct.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailIdentityRequest"/></param>
        /// <returns><see cref="UpdateEmailIdentityResponse"/></returns>
        public Task<UpdateEmailIdentityResponse> UpdateEmailIdentity(UpdateEmailIdentityRequest req)
        {
            return InternalRequestAsync<UpdateEmailIdentityResponse>(req, "UpdateEmailIdentity");
        }

        /// <summary>
        /// This API is used to verify whether your DNS configuration is correct.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailIdentityRequest"/></param>
        /// <returns><see cref="UpdateEmailIdentityResponse"/></returns>
        public UpdateEmailIdentityResponse UpdateEmailIdentitySync(UpdateEmailIdentityRequest req)
        {
            return InternalRequestAsync<UpdateEmailIdentityResponse>(req, "UpdateEmailIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the SMTP password. Initially, no SMTP password is set for your email address, so emails cannot be sent over SMTP. To send emails over SMTP, you must set the SMTP password. The set password can be changed subsequently.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailSmtpPassWordRequest"/></param>
        /// <returns><see cref="UpdateEmailSmtpPassWordResponse"/></returns>
        public Task<UpdateEmailSmtpPassWordResponse> UpdateEmailSmtpPassWord(UpdateEmailSmtpPassWordRequest req)
        {
            return InternalRequestAsync<UpdateEmailSmtpPassWordResponse>(req, "UpdateEmailSmtpPassWord");
        }

        /// <summary>
        /// This API is used to set the SMTP password. Initially, no SMTP password is set for your email address, so emails cannot be sent over SMTP. To send emails over SMTP, you must set the SMTP password. The set password can be changed subsequently.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailSmtpPassWordRequest"/></param>
        /// <returns><see cref="UpdateEmailSmtpPassWordResponse"/></returns>
        public UpdateEmailSmtpPassWordResponse UpdateEmailSmtpPassWordSync(UpdateEmailSmtpPassWordRequest req)
        {
            return InternalRequestAsync<UpdateEmailSmtpPassWordResponse>(req, "UpdateEmailSmtpPassWord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update an email template. An updated template must be approved again before it can be used.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailTemplateRequest"/></param>
        /// <returns><see cref="UpdateEmailTemplateResponse"/></returns>
        public Task<UpdateEmailTemplateResponse> UpdateEmailTemplate(UpdateEmailTemplateRequest req)
        {
            return InternalRequestAsync<UpdateEmailTemplateResponse>(req, "UpdateEmailTemplate");
        }

        /// <summary>
        /// This API is used to update an email template. An updated template must be approved again before it can be used.
        /// </summary>
        /// <param name="req"><see cref="UpdateEmailTemplateRequest"/></param>
        /// <returns><see cref="UpdateEmailTemplateResponse"/></returns>
        public UpdateEmailTemplateResponse UpdateEmailTemplateSync(UpdateEmailTemplateRequest req)
        {
            return InternalRequestAsync<UpdateEmailTemplateResponse>(req, "UpdateEmailTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
