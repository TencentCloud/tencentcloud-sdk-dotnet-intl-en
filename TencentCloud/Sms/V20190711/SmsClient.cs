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

namespace TencentCloud.Sms.V20190711
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sms.V20190711.Models;

   public class SmsClient : AbstractClient{

       private const string endpoint = "sms.tencentcloudapi.com";
       private const string version = "2019-07-11";
       private const string sdkVersion = "SDK_NET_3.0.954";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add an SMS signature. Please read the [Tencent Cloud SMS Signature Review Standards](https://intl.cloud.tencent.com/document/product/382/39022?from_cn_redirect=1) before starting an application.
        /// > Note: individual users cannot use this API to apply for SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, please log in to the console to apply for SMS signatures. For detailed directions, please see [Creating SMS Signatures](https://intl.cloud.tencent.com/document/product/382/36136?from_cn_redirect=1#Sign).
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public Task<AddSmsSignResponse> AddSmsSign(AddSmsSignRequest req)
        {
            return InternalRequestAsync<AddSmsSignResponse>(req, "AddSmsSign");
        }

        /// <summary>
        /// This API is used to add an SMS signature. Please read the [Tencent Cloud SMS Signature Review Standards](https://intl.cloud.tencent.com/document/product/382/39022?from_cn_redirect=1) before starting an application.
        /// > Note: individual users cannot use this API to apply for SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, please log in to the console to apply for SMS signatures. For detailed directions, please see [Creating SMS Signatures](https://intl.cloud.tencent.com/document/product/382/36136?from_cn_redirect=1#Sign).
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public AddSmsSignResponse AddSmsSignSync(AddSmsSignRequest req)
        {
            return InternalRequestAsync<AddSmsSignResponse>(req, "AddSmsSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add an SMS template. Please read the [Tencent Cloud SMS Body Template Review Standards](https://intl.cloud.tencent.com/document/product/382/39023?from_cn_redirect=1) before starting an application.
        /// > Note: individual users cannot use this API to apply for SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, please log in to the console to apply for SMS body templates. For detailed directions, please see [Creating SMS Body Templates](https://intl.cloud.tencent.com/document/product/382/36136?from_cn_redirect=1#Template).
        /// </summary>
        /// <param name="req"><see cref="AddSmsTemplateRequest"/></param>
        /// <returns><see cref="AddSmsTemplateResponse"/></returns>
        public Task<AddSmsTemplateResponse> AddSmsTemplate(AddSmsTemplateRequest req)
        {
            return InternalRequestAsync<AddSmsTemplateResponse>(req, "AddSmsTemplate");
        }

        /// <summary>
        /// This API is used to add an SMS template. Please read the [Tencent Cloud SMS Body Template Review Standards](https://intl.cloud.tencent.com/document/product/382/39023?from_cn_redirect=1) before starting an application.
        /// > Note: individual users cannot use this API to apply for SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, please log in to the console to apply for SMS body templates. For detailed directions, please see [Creating SMS Body Templates](https://intl.cloud.tencent.com/document/product/382/36136?from_cn_redirect=1#Template).
        /// </summary>
        /// <param name="req"><see cref="AddSmsTemplateRequest"/></param>
        /// <returns><see cref="AddSmsTemplateResponse"/></returns>
        public AddSmsTemplateResponse AddSmsTemplateSync(AddSmsTemplateRequest req)
        {
            return InternalRequestAsync<AddSmsTemplateResponse>(req, "AddSmsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to collect statistics on user receipts.
        /// </summary>
        /// <param name="req"><see cref="CallbackStatusStatisticsRequest"/></param>
        /// <returns><see cref="CallbackStatusStatisticsResponse"/></returns>
        public Task<CallbackStatusStatisticsResponse> CallbackStatusStatistics(CallbackStatusStatisticsRequest req)
        {
            return InternalRequestAsync<CallbackStatusStatisticsResponse>(req, "CallbackStatusStatistics");
        }

        /// <summary>
        /// This API is used to collect statistics on user receipts.
        /// </summary>
        /// <param name="req"><see cref="CallbackStatusStatisticsRequest"/></param>
        /// <returns><see cref="CallbackStatusStatisticsResponse"/></returns>
        public CallbackStatusStatisticsResponse CallbackStatusStatisticsSync(CallbackStatusStatisticsRequest req)
        {
            return InternalRequestAsync<CallbackStatusStatisticsResponse>(req, "CallbackStatusStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// > Note: individual users cannot use this API to delete SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). You can log in to the console to delete SMS signatures. For detailed directions, please see the notes on deleting SMS signatures in [SMS Signature Operations](https://intl.cloud.tencent.com/document/product/382/36136?from_cn_redirect=1#Sign).
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsSignRequest"/></param>
        /// <returns><see cref="DeleteSmsSignResponse"/></returns>
        public Task<DeleteSmsSignResponse> DeleteSmsSign(DeleteSmsSignRequest req)
        {
            return InternalRequestAsync<DeleteSmsSignResponse>(req, "DeleteSmsSign");
        }

        /// <summary>
        /// > Note: individual users cannot use this API to delete SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). You can log in to the console to delete SMS signatures. For detailed directions, please see the notes on deleting SMS signatures in [SMS Signature Operations](https://intl.cloud.tencent.com/document/product/382/36136?from_cn_redirect=1#Sign).
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsSignRequest"/></param>
        /// <returns><see cref="DeleteSmsSignResponse"/></returns>
        public DeleteSmsSignResponse DeleteSmsSignSync(DeleteSmsSignRequest req)
        {
            return InternalRequestAsync<DeleteSmsSignResponse>(req, "DeleteSmsSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// > Note: individual users cannot use this API to delete SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). You can log in to the console to delete SMS body templates. For detailed directions, please see the notes on deleting SMS body templates in [SMS Body Template Operations](https://intl.cloud.tencent.com/document/product/382/36136?from_cn_redirect=1#Template).
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmsTemplateResponse"/></returns>
        public Task<DeleteSmsTemplateResponse> DeleteSmsTemplate(DeleteSmsTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSmsTemplateResponse>(req, "DeleteSmsTemplate");
        }

        /// <summary>
        /// > Note: individual users cannot use this API to delete SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). You can log in to the console to delete SMS body templates. For detailed directions, please see the notes on deleting SMS body templates in [SMS Body Template Operations](https://intl.cloud.tencent.com/document/product/382/36136?from_cn_redirect=1#Template).
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmsTemplateResponse"/></returns>
        public DeleteSmsTemplateResponse DeleteSmsTemplateSync(DeleteSmsTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSmsTemplateResponse>(req, "DeleteSmsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// > Note: individual users cannot use this API to query SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public Task<DescribeSmsSignListResponse> DescribeSmsSignList(DescribeSmsSignListRequest req)
        {
            return InternalRequestAsync<DescribeSmsSignListResponse>(req, "DescribeSmsSignList");
        }

        /// <summary>
        /// > Note: individual users cannot use this API to query SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public DescribeSmsSignListResponse DescribeSmsSignListSync(DescribeSmsSignListRequest req)
        {
            return InternalRequestAsync<DescribeSmsSignListResponse>(req, "DescribeSmsSignList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// > Note: individual users cannot use this API to query SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public Task<DescribeSmsTemplateListResponse> DescribeSmsTemplateList(DescribeSmsTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeSmsTemplateListResponse>(req, "DescribeSmsTemplateList");
        }

        /// <summary>
        /// > Note: individual users cannot use this API to query SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public DescribeSmsTemplateListResponse DescribeSmsTemplateListSync(DescribeSmsTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeSmsTemplateListResponse>(req, "DescribeSmsTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an SMS signature. Please read the [Tencent Cloud SMS Signature Review Standards](https://intl.cloud.tencent.com/document/product/382/39022?from_cn_redirect=1) before making a modification.
        /// >-  Note: individual users cannot use this API to modify SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the console to modify SMS signatures.
        /// >- Modifications can be made only if the signature status is **pending review** or **rejected**. **Approved** signatures cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsSignRequest"/></param>
        /// <returns><see cref="ModifySmsSignResponse"/></returns>
        public Task<ModifySmsSignResponse> ModifySmsSign(ModifySmsSignRequest req)
        {
            return InternalRequestAsync<ModifySmsSignResponse>(req, "ModifySmsSign");
        }

        /// <summary>
        /// This API is used to modify an SMS signature. Please read the [Tencent Cloud SMS Signature Review Standards](https://intl.cloud.tencent.com/document/product/382/39022?from_cn_redirect=1) before making a modification.
        /// >-  Note: individual users cannot use this API to modify SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the console to modify SMS signatures.
        /// >- Modifications can be made only if the signature status is **pending review** or **rejected**. **Approved** signatures cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsSignRequest"/></param>
        /// <returns><see cref="ModifySmsSignResponse"/></returns>
        public ModifySmsSignResponse ModifySmsSignSync(ModifySmsSignRequest req)
        {
            return InternalRequestAsync<ModifySmsSignResponse>(req, "ModifySmsSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an SMS body template. Please read the [Tencent Cloud SMS Body Template Review Standards](https://intl.cloud.tencent.com/document/product/382/39023?from_cn_redirect=1) before making a modification.
        /// >-  Note: individual users cannot use this API to modify SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the console to modify SMS body templates.
        /// >- Modifications can be made only if the body template status is **pending review** or **rejected**. **Approved** body templates cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsTemplateRequest"/></param>
        /// <returns><see cref="ModifySmsTemplateResponse"/></returns>
        public Task<ModifySmsTemplateResponse> ModifySmsTemplate(ModifySmsTemplateRequest req)
        {
            return InternalRequestAsync<ModifySmsTemplateResponse>(req, "ModifySmsTemplate");
        }

        /// <summary>
        /// This API is used to modify an SMS body template. Please read the [Tencent Cloud SMS Body Template Review Standards](https://intl.cloud.tencent.com/document/product/382/39023?from_cn_redirect=1) before making a modification.
        /// >-  Note: individual users cannot use this API to modify SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the console to modify SMS body templates.
        /// >- Modifications can be made only if the body template status is **pending review** or **rejected**. **Approved** body templates cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsTemplateRequest"/></param>
        /// <returns><see cref="ModifySmsTemplateResponse"/></returns>
        public ModifySmsTemplateResponse ModifySmsTemplateSync(ModifySmsTemplateRequest req)
        {
            return InternalRequestAsync<ModifySmsTemplateResponse>(req, "ModifySmsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull SMS reply status.
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusResponse"/></returns>
        public Task<PullSmsReplyStatusResponse> PullSmsReplyStatus(PullSmsReplyStatusRequest req)
        {
            return InternalRequestAsync<PullSmsReplyStatusResponse>(req, "PullSmsReplyStatus");
        }

        /// <summary>
        /// This API is used to pull SMS reply status.
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusResponse"/></returns>
        public PullSmsReplyStatusResponse PullSmsReplyStatusSync(PullSmsReplyStatusRequest req)
        {
            return InternalRequestAsync<PullSmsReplyStatusResponse>(req, "PullSmsReplyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull SMS reply status for one single number.
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusByPhoneNumberResponse"/></returns>
        public Task<PullSmsReplyStatusByPhoneNumberResponse> PullSmsReplyStatusByPhoneNumber(PullSmsReplyStatusByPhoneNumberRequest req)
        {
            return InternalRequestAsync<PullSmsReplyStatusByPhoneNumberResponse>(req, "PullSmsReplyStatusByPhoneNumber");
        }

        /// <summary>
        /// This API is used to pull SMS reply status for one single number.
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusByPhoneNumberResponse"/></returns>
        public PullSmsReplyStatusByPhoneNumberResponse PullSmsReplyStatusByPhoneNumberSync(PullSmsReplyStatusByPhoneNumberRequest req)
        {
            return InternalRequestAsync<PullSmsReplyStatusByPhoneNumberResponse>(req, "PullSmsReplyStatusByPhoneNumber")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull SMS delivery status.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusResponse"/></returns>
        public Task<PullSmsSendStatusResponse> PullSmsSendStatus(PullSmsSendStatusRequest req)
        {
            return InternalRequestAsync<PullSmsSendStatusResponse>(req, "PullSmsSendStatus");
        }

        /// <summary>
        /// This API is used to pull SMS delivery status.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusResponse"/></returns>
        public PullSmsSendStatusResponse PullSmsSendStatusSync(PullSmsSendStatusRequest req)
        {
            return InternalRequestAsync<PullSmsSendStatusResponse>(req, "PullSmsSendStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull SMS delivery status for one single number.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusByPhoneNumberResponse"/></returns>
        public Task<PullSmsSendStatusByPhoneNumberResponse> PullSmsSendStatusByPhoneNumber(PullSmsSendStatusByPhoneNumberRequest req)
        {
            return InternalRequestAsync<PullSmsSendStatusByPhoneNumberResponse>(req, "PullSmsSendStatusByPhoneNumber");
        }

        /// <summary>
        /// This API is used to pull SMS delivery status for one single number.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusByPhoneNumberResponse"/></returns>
        public PullSmsSendStatusByPhoneNumberResponse PullSmsSendStatusByPhoneNumberSync(PullSmsSendStatusByPhoneNumberRequest req)
        {
            return InternalRequestAsync<PullSmsSendStatusByPhoneNumberResponse>(req, "PullSmsSendStatusByPhoneNumber")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send SMS verification codes, notification, or marketing messages to users.
        /// 
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
            return InternalRequestAsync<SendSmsResponse>(req, "SendSms");
        }

        /// <summary>
        /// This API is used to send SMS verification codes, notification, or marketing messages to users.
        /// 
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public SendSmsResponse SendSmsSync(SendSmsRequest req)
        {
            return InternalRequestAsync<SendSmsResponse>(req, "SendSms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to collect statistics on SMS sent by users.
        /// </summary>
        /// <param name="req"><see cref="SendStatusStatisticsRequest"/></param>
        /// <returns><see cref="SendStatusStatisticsResponse"/></returns>
        public Task<SendStatusStatisticsResponse> SendStatusStatistics(SendStatusStatisticsRequest req)
        {
            return InternalRequestAsync<SendStatusStatisticsResponse>(req, "SendStatusStatistics");
        }

        /// <summary>
        /// This API is used to collect statistics on SMS sent by users.
        /// </summary>
        /// <param name="req"><see cref="SendStatusStatisticsRequest"/></param>
        /// <returns><see cref="SendStatusStatisticsResponse"/></returns>
        public SendStatusStatisticsResponse SendStatusStatisticsSync(SendStatusStatisticsRequest req)
        {
            return InternalRequestAsync<SendStatusStatisticsResponse>(req, "SendStatusStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to collect statistics on user's packages.
        /// </summary>
        /// <param name="req"><see cref="SmsPackagesStatisticsRequest"/></param>
        /// <returns><see cref="SmsPackagesStatisticsResponse"/></returns>
        public Task<SmsPackagesStatisticsResponse> SmsPackagesStatistics(SmsPackagesStatisticsRequest req)
        {
            return InternalRequestAsync<SmsPackagesStatisticsResponse>(req, "SmsPackagesStatistics");
        }

        /// <summary>
        /// This API is used to collect statistics on user's packages.
        /// </summary>
        /// <param name="req"><see cref="SmsPackagesStatisticsRequest"/></param>
        /// <returns><see cref="SmsPackagesStatisticsResponse"/></returns>
        public SmsPackagesStatisticsResponse SmsPackagesStatisticsSync(SmsPackagesStatisticsRequest req)
        {
            return InternalRequestAsync<SmsPackagesStatisticsResponse>(req, "SmsPackagesStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
