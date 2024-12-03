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

namespace TencentCloud.Sms.V20210111
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sms.V20210111.Models;

   public class SmsClient : AbstractClient{

       private const string endpoint = "sms.tencentcloudapi.com";
       private const string version = "2021-01-11";
       private const string sdkVersion = "SDK_NET_3.0.1025";

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
        /// 1. This API is used to add an SMS signature. You need to read the [Tencent Cloud SMS Signature Review Standards](https://intl.cloud.tencent.com/zh/document/product/382/40658) before starting an application.
        /// 2. ⚠️ Note: individual users cannot use this API to apply for SMS signatures. For more information, see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the console to apply for SMS signatures.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public Task<AddSmsSignResponse> AddSmsSign(AddSmsSignRequest req)
        {
            return InternalRequestAsync<AddSmsSignResponse>(req, "AddSmsSign");
        }

        /// <summary>
        /// 1. This API is used to add an SMS signature. You need to read the [Tencent Cloud SMS Signature Review Standards](https://intl.cloud.tencent.com/zh/document/product/382/40658) before starting an application.
        /// 2. ⚠️ Note: individual users cannot use this API to apply for SMS signatures. For more information, see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the console to apply for SMS signatures.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public AddSmsSignResponse AddSmsSignSync(AddSmsSignRequest req)
        {
            return InternalRequestAsync<AddSmsSignResponse>(req, "AddSmsSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. This API is used to add an SMS template. You need to read the [Tencent Cloud SMS Body Template Review Standards](https://intl.cloud.tencent.com/zh/document/product/382/40659) before starting an application.
        /// 2. Note: individual users cannot use this API to apply for SMS body templates. For more information, see [Identity Verification Overview](https://intl.cloud.tencent.com/zh/document/product/378/3629). If your account identity is individual, you can log in to the [console](https://console.cloud.tencent.com/smsv2) to apply for SMS body templates.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="AddSmsTemplateRequest"/></param>
        /// <returns><see cref="AddSmsTemplateResponse"/></returns>
        public Task<AddSmsTemplateResponse> AddSmsTemplate(AddSmsTemplateRequest req)
        {
            return InternalRequestAsync<AddSmsTemplateResponse>(req, "AddSmsTemplate");
        }

        /// <summary>
        /// 1. This API is used to add an SMS template. You need to read the [Tencent Cloud SMS Body Template Review Standards](https://intl.cloud.tencent.com/zh/document/product/382/40659) before starting an application.
        /// 2. Note: individual users cannot use this API to apply for SMS body templates. For more information, see [Identity Verification Overview](https://intl.cloud.tencent.com/zh/document/product/378/3629). If your account identity is individual, you can log in to the [console](https://console.cloud.tencent.com/smsv2) to apply for SMS body templates.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
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
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="CallbackStatusStatisticsRequest"/></param>
        /// <returns><see cref="CallbackStatusStatisticsResponse"/></returns>
        public Task<CallbackStatusStatisticsResponse> CallbackStatusStatistics(CallbackStatusStatisticsRequest req)
        {
            return InternalRequestAsync<CallbackStatusStatisticsResponse>(req, "CallbackStatusStatistics");
        }

        /// <summary>
        /// This API is used to collect statistics on user receipts.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="CallbackStatusStatisticsRequest"/></param>
        /// <returns><see cref="CallbackStatusStatisticsResponse"/></returns>
        public CallbackStatusStatisticsResponse CallbackStatusStatisticsSync(CallbackStatusStatisticsRequest req)
        {
            return InternalRequestAsync<CallbackStatusStatisticsResponse>(req, "CallbackStatusStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ⚠️ Note: individual users cannot use this API to delete SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). Please log in to the [console](https://console.cloud.tencent.com/smsv2) to delete SMS signatures.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsSignRequest"/></param>
        /// <returns><see cref="DeleteSmsSignResponse"/></returns>
        public Task<DeleteSmsSignResponse> DeleteSmsSign(DeleteSmsSignRequest req)
        {
            return InternalRequestAsync<DeleteSmsSignResponse>(req, "DeleteSmsSign");
        }

        /// <summary>
        /// ⚠️ Note: individual users cannot use this API to delete SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). Please log in to the [console](https://console.cloud.tencent.com/smsv2) to delete SMS signatures.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsSignRequest"/></param>
        /// <returns><see cref="DeleteSmsSignResponse"/></returns>
        public DeleteSmsSignResponse DeleteSmsSignSync(DeleteSmsSignRequest req)
        {
            return InternalRequestAsync<DeleteSmsSignResponse>(req, "DeleteSmsSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ⚠️ Note: individual users cannot use this API to delete SMS body templates. Please log in to the [console](https://console.cloud.tencent.com/smsv2) to do so. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1).
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmsTemplateResponse"/></returns>
        public Task<DeleteSmsTemplateResponse> DeleteSmsTemplate(DeleteSmsTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSmsTemplateResponse>(req, "DeleteSmsTemplate");
        }

        /// <summary>
        /// ⚠️ Note: individual users cannot use this API to delete SMS body templates. Please log in to the [console](https://console.cloud.tencent.com/smsv2) to do so. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1).
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmsTemplateResponse"/></returns>
        public DeleteSmsTemplateResponse DeleteSmsTemplateSync(DeleteSmsTemplateRequest req)
        {
            return InternalRequestAsync<DeleteSmsTemplateResponse>(req, "DeleteSmsTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a phone number, including country/region code and standardized E.164 format number.
        /// >- For example, if you query the number +86018845720123, you can get the country/region code 86 and the standardized E.164 number +8618845720123.
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneNumberInfoRequest"/></param>
        /// <returns><see cref="DescribePhoneNumberInfoResponse"/></returns>
        public Task<DescribePhoneNumberInfoResponse> DescribePhoneNumberInfo(DescribePhoneNumberInfoRequest req)
        {
            return InternalRequestAsync<DescribePhoneNumberInfoResponse>(req, "DescribePhoneNumberInfo");
        }

        /// <summary>
        /// This API is used to query the information of a phone number, including country/region code and standardized E.164 format number.
        /// >- For example, if you query the number +86018845720123, you can get the country/region code 86 and the standardized E.164 number +8618845720123.
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneNumberInfoRequest"/></param>
        /// <returns><see cref="DescribePhoneNumberInfoResponse"/></returns>
        public DescribePhoneNumberInfoResponse DescribePhoneNumberInfoSync(DescribePhoneNumberInfoRequest req)
        {
            return InternalRequestAsync<DescribePhoneNumberInfoResponse>(req, "DescribePhoneNumberInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ⚠️ Note: individual users cannot use this API to query SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the [console](https://console.cloud.tencent.com/smsv2) to query SMS signatures.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public Task<DescribeSmsSignListResponse> DescribeSmsSignList(DescribeSmsSignListRequest req)
        {
            return InternalRequestAsync<DescribeSmsSignListResponse>(req, "DescribeSmsSignList");
        }

        /// <summary>
        /// ⚠️ Note: individual users cannot use this API to query SMS signatures. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the [console](https://console.cloud.tencent.com/smsv2) to query SMS signatures.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public DescribeSmsSignListResponse DescribeSmsSignListSync(DescribeSmsSignListRequest req)
        {
            return InternalRequestAsync<DescribeSmsSignListResponse>(req, "DescribeSmsSignList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ⚠️ Note: individual users cannot use this API to query SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1).
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public Task<DescribeSmsTemplateListResponse> DescribeSmsTemplateList(DescribeSmsTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeSmsTemplateListResponse>(req, "DescribeSmsTemplateList");
        }

        /// <summary>
        /// ⚠️ Note: individual users cannot use this API to query SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1).
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public DescribeSmsTemplateListResponse DescribeSmsTemplateListSync(DescribeSmsTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeSmsTemplateListResponse>(req, "DescribeSmsTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. This API is used to modify an SMS signature. Read the [Tencent Cloud SMS signature review standards](https://intl.cloud.tencent.com/document/product/382/40658) before making a modification.
        /// 2. ⚠️ Note: Individual users cannot use this API to modify SMS signatures. For more information, see [Identity Verification Guide](https://intl.cloud.tencent.com/document/product/378/3629). If your account identity is individual, you can log in to the [console](https://console.cloud.tencent.com/smsv2) to modify SMS signatures.
        /// 3. Modifications can be made only if the signature status is **Pending Review** or **Rejected**. **Approved** signatures cannot be modified.
        /// >- Note: Because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsSignRequest"/></param>
        /// <returns><see cref="ModifySmsSignResponse"/></returns>
        public Task<ModifySmsSignResponse> ModifySmsSign(ModifySmsSignRequest req)
        {
            return InternalRequestAsync<ModifySmsSignResponse>(req, "ModifySmsSign");
        }

        /// <summary>
        /// 1. This API is used to modify an SMS signature. Read the [Tencent Cloud SMS signature review standards](https://intl.cloud.tencent.com/document/product/382/40658) before making a modification.
        /// 2. ⚠️ Note: Individual users cannot use this API to modify SMS signatures. For more information, see [Identity Verification Guide](https://intl.cloud.tencent.com/document/product/378/3629). If your account identity is individual, you can log in to the [console](https://console.cloud.tencent.com/smsv2) to modify SMS signatures.
        /// 3. Modifications can be made only if the signature status is **Pending Review** or **Rejected**. **Approved** signatures cannot be modified.
        /// >- Note: Because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsSignRequest"/></param>
        /// <returns><see cref="ModifySmsSignResponse"/></returns>
        public ModifySmsSignResponse ModifySmsSignSync(ModifySmsSignRequest req)
        {
            return InternalRequestAsync<ModifySmsSignResponse>(req, "ModifySmsSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 1. This API is used to modify an SMS body template. Please read the [Tencent Cloud SMS Body Template Review Standards](https://intl.cloud.tencent.com/document/product/382/39023?from_cn_redirect=1) before making a modification.
        /// 2. Note: individual users cannot use this API to modify SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the [console](https://console.cloud.tencent.com/smsv2) to modify SMS body templates.
        /// 3. Modifications can be made only if the body template status is **Pending Review** or **Rejected**. **Approved** body templates cannot be modified.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2019-07-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsTemplateRequest"/></param>
        /// <returns><see cref="ModifySmsTemplateResponse"/></returns>
        public Task<ModifySmsTemplateResponse> ModifySmsTemplate(ModifySmsTemplateRequest req)
        {
            return InternalRequestAsync<ModifySmsTemplateResponse>(req, "ModifySmsTemplate");
        }

        /// <summary>
        /// 1. This API is used to modify an SMS body template. Please read the [Tencent Cloud SMS Body Template Review Standards](https://intl.cloud.tencent.com/document/product/382/39023?from_cn_redirect=1) before making a modification.
        /// 2. Note: individual users cannot use this API to modify SMS body templates. For more information, please see [Identity Verification Overview](https://intl.cloud.tencent.com/document/product/378/3629?from_cn_redirect=1). If your account identity is individual, you can log in to the [console](https://console.cloud.tencent.com/smsv2) to modify SMS body templates.
        /// 3. Modifications can be made only if the body template status is **Pending Review** or **Rejected**. **Approved** body templates cannot be modified.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2019-07-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
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
        /// Currently, you can also [configure the reply callback](https://intl.cloud.tencent.com/document/product/382/42907?from_cn_redirect=1) to get replies.
        /// >- Note: You need to contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) to activate this API.
        /// >- Note: Because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusResponse"/></returns>
        public Task<PullSmsReplyStatusResponse> PullSmsReplyStatus(PullSmsReplyStatusRequest req)
        {
            return InternalRequestAsync<PullSmsReplyStatusResponse>(req, "PullSmsReplyStatus");
        }

        /// <summary>
        /// This API is used to pull SMS reply status.
        /// Currently, you can also [configure the reply callback](https://intl.cloud.tencent.com/document/product/382/42907?from_cn_redirect=1) to get replies.
        /// >- Note: You need to contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) to activate this API.
        /// >- Note: Because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
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
        /// Currently, you can also [configure the reply callback](https://intl.cloud.tencent.com/document/product/382/42907?from_cn_redirect=1) to get replies.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusByPhoneNumberResponse"/></returns>
        public Task<PullSmsReplyStatusByPhoneNumberResponse> PullSmsReplyStatusByPhoneNumber(PullSmsReplyStatusByPhoneNumberRequest req)
        {
            return InternalRequestAsync<PullSmsReplyStatusByPhoneNumberResponse>(req, "PullSmsReplyStatusByPhoneNumber");
        }

        /// <summary>
        /// This API is used to pull SMS reply status for one single number.
        /// Currently, you can also [configure the reply callback](https://intl.cloud.tencent.com/document/product/382/42907?from_cn_redirect=1) to get replies.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
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
        /// Currently, you can also [configure the callback](https://intl.cloud.tencent.com/document/product/382/37809?from_cn_redirect=1#.E8.AE.BE.E7.BD.AE.E4.BA.8B.E4.BB.B6.E5.9B.9E.E8.B0.83.E9.85.8D.E7.BD.AE) to get the delivery status.
        /// >- Note: you need to contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) to activate this API.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusResponse"/></returns>
        public Task<PullSmsSendStatusResponse> PullSmsSendStatus(PullSmsSendStatusRequest req)
        {
            return InternalRequestAsync<PullSmsSendStatusResponse>(req, "PullSmsSendStatus");
        }

        /// <summary>
        /// This API is used to pull SMS delivery status.
        /// Currently, you can also [configure the callback](https://intl.cloud.tencent.com/document/product/382/37809?from_cn_redirect=1#.E8.AE.BE.E7.BD.AE.E4.BA.8B.E4.BB.B6.E5.9B.9E.E8.B0.83.E9.85.8D.E7.BD.AE) to get the delivery status.
        /// >- Note: you need to contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81) to activate this API.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
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
        /// Currently, you can also [configure the callback](https://intl.cloud.tencent.com/document/product/382/37809?from_cn_redirect=1#.E8.AE.BE.E7.BD.AE.E4.BA.8B.E4.BB.B6.E5.9B.9E.E8.B0.83.E9.85.8D.E7.BD.AE) to get the delivery status.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) to eliminate the need to calculate signatures. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusByPhoneNumberResponse"/></returns>
        public Task<PullSmsSendStatusByPhoneNumberResponse> PullSmsSendStatusByPhoneNumber(PullSmsSendStatusByPhoneNumberRequest req)
        {
            return InternalRequestAsync<PullSmsSendStatusByPhoneNumberResponse>(req, "PullSmsSendStatusByPhoneNumber");
        }

        /// <summary>
        /// This API is used to pull SMS delivery status for one single number.
        /// Currently, you can also [configure the callback](https://intl.cloud.tencent.com/document/product/382/37809?from_cn_redirect=1#.E8.AE.BE.E7.BD.AE.E4.BA.8B.E4.BB.B6.E5.9B.9E.E8.B0.83.E9.85.8D.E7.BD.AE) to get the delivery status.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms) to eliminate the need to calculate signatures. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusByPhoneNumberResponse"/></returns>
        public PullSmsSendStatusByPhoneNumberResponse PullSmsSendStatusByPhoneNumberSync(PullSmsSendStatusByPhoneNumberRequest req)
        {
            return InternalRequestAsync<PullSmsSendStatusByPhoneNumberResponse>(req, "PullSmsSendStatusByPhoneNumber")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to report the SMS conversion rate (SMS conversion rate = the number of returned verification codes / the number of verification codes sent) and report the serial numbers of received SMS messages to Tencent Cloud SMS.
        /// >- Note: To call this API, you need to be added to the allowlist first. If you have any questions, contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81).
        /// </summary>
        /// <param name="req"><see cref="ReportConversionRequest"/></param>
        /// <returns><see cref="ReportConversionResponse"/></returns>
        public Task<ReportConversionResponse> ReportConversion(ReportConversionRequest req)
        {
            return InternalRequestAsync<ReportConversionResponse>(req, "ReportConversion");
        }

        /// <summary>
        /// This API is used to report the SMS conversion rate (SMS conversion rate = the number of returned verification codes / the number of verification codes sent) and report the serial numbers of received SMS messages to Tencent Cloud SMS.
        /// >- Note: To call this API, you need to be added to the allowlist first. If you have any questions, contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81).
        /// </summary>
        /// <param name="req"><see cref="ReportConversionRequest"/></param>
        /// <returns><see cref="ReportConversionResponse"/></returns>
        public ReportConversionResponse ReportConversionSync(ReportConversionRequest req)
        {
            return InternalRequestAsync<ReportConversionResponse>(req, "ReportConversion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to send SMS verification codes, notification, or marketing messages to users.
        /// >- Note: Because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the [SDK](https://intl.cloud.tencent.com/document/product/382/43193?from_cn_redirect=1).
        /// >- Note: You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
            return InternalRequestAsync<SendSmsResponse>(req, "SendSms");
        }

        /// <summary>
        /// This API is used to send SMS verification codes, notification, or marketing messages to users.
        /// >- Note: Because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the [SDK](https://intl.cloud.tencent.com/document/product/382/43193?from_cn_redirect=1).
        /// >- Note: You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public SendSmsResponse SendSmsSync(SendSmsRequest req)
        {
            return InternalRequestAsync<SendSmsResponse>(req, "SendSms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to collect statistics on SMS messages sent by users.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="SendStatusStatisticsRequest"/></param>
        /// <returns><see cref="SendStatusStatisticsResponse"/></returns>
        public Task<SendStatusStatisticsResponse> SendStatusStatistics(SendStatusStatisticsRequest req)
        {
            return InternalRequestAsync<SendStatusStatisticsResponse>(req, "SendStatusStatistics");
        }

        /// <summary>
        /// This API is used to collect statistics on SMS messages sent by users.
        /// >- Note: because of the improved security of **TencentCloud API 3.0**, **API authentication** is more complicated. We recommend you use the Tencent Cloud SMS service with the SDK.
        /// >- You can run this API directly in [API 3.0 Explorer](https://console.cloud.tencent.com/api/explorer?Product=sms&Version=2021-01-11&Action=SendSms), which eliminates the signature calculation steps. After it is executed successfully, API Explorer can **automatically generate** SDK code samples.
        /// </summary>
        /// <param name="req"><see cref="SendStatusStatisticsRequest"/></param>
        /// <returns><see cref="SendStatusStatisticsResponse"/></returns>
        public SendStatusStatisticsResponse SendStatusStatisticsSync(SendStatusStatisticsRequest req)
        {
            return InternalRequestAsync<SendStatusStatisticsResponse>(req, "SendStatusStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
