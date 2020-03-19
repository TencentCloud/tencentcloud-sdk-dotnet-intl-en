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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to add an SMS signature. Please read the [Tencent Cloud SMS Signature Review Standards](https://cloud.tencent.com/document/product/382/39022) before starting an application.
        /// >⚠️ Note: individual users cannot use this API to apply for SMS signatures. For more information, please see [Identity Verification Overview](https://cloud.tencent.com/document/product/378/3629). If your account identity is individual, please log in to the console to apply for SMS signatures. For detailed directions, please see [Creating SMS Signatures](https://cloud.tencent.com/document/product/382/36136#Sign).
        /// </summary>
        /// <param name="req"><see cref="AddSmsSignRequest"/></param>
        /// <returns><see cref="AddSmsSignResponse"/></returns>
        public async Task<AddSmsSignResponse> AddSmsSign(AddSmsSignRequest req)
        {
             JsonResponseModel<AddSmsSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddSmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add an SMS template. Please read the [Tencent Cloud SMS Body Template Review Standards](https://cloud.tencent.com/document/product/382/39023) before starting an application.
        /// >⚠️ Note: individual users cannot use this API to apply for SMS body templates. For more information, please see [Identity Verification Overview](https://cloud.tencent.com/document/product/378/3629). If your account identity is individual, please log in to the console to apply for SMS body templates. For detailed directions, please see [Creating SMS Body Templates](https://cloud.tencent.com/document/product/382/36136#Template).
        /// </summary>
        /// <param name="req"><see cref="AddSmsTemplateRequest"/></param>
        /// <returns><see cref="AddSmsTemplateResponse"/></returns>
        public async Task<AddSmsTemplateResponse> AddSmsTemplate(AddSmsTemplateRequest req)
        {
             JsonResponseModel<AddSmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddSmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddSmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to collect statistics on user receipts.
        /// </summary>
        /// <param name="req"><see cref="CallbackStatusStatisticsRequest"/></param>
        /// <returns><see cref="CallbackStatusStatisticsResponse"/></returns>
        public async Task<CallbackStatusStatisticsResponse> CallbackStatusStatistics(CallbackStatusStatisticsRequest req)
        {
             JsonResponseModel<CallbackStatusStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CallbackStatusStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallbackStatusStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// >⚠️ Note: individual users cannot use this API to delete SMS signatures. For more information, please see [Identity Verification Overview](https://cloud.tencent.com/document/product/378/3629). You can log in to the console to delete SMS signatures. For detailed directions, please see the notes on deleting SMS signatures in [SMS Signature Operations](https://cloud.tencent.com/document/product/382/36136#Sign).
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsSignRequest"/></param>
        /// <returns><see cref="DeleteSmsSignResponse"/></returns>
        public async Task<DeleteSmsSignResponse> DeleteSmsSign(DeleteSmsSignRequest req)
        {
             JsonResponseModel<DeleteSmsSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// >⚠️ Note: individual users cannot use this API to delete SMS body templates. For more information, please see [Identity Verification Overview](https://cloud.tencent.com/document/product/378/3629). You can log in to the console to delete SMS body templates. For detailed directions, please see the notes on deleting SMS body templates in [SMS Body Template Operations](https://cloud.tencent.com/document/product/382/36136#Template).
        /// </summary>
        /// <param name="req"><see cref="DeleteSmsTemplateRequest"/></param>
        /// <returns><see cref="DeleteSmsTemplateResponse"/></returns>
        public async Task<DeleteSmsTemplateResponse> DeleteSmsTemplate(DeleteSmsTemplateRequest req)
        {
             JsonResponseModel<DeleteSmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// >⚠️ Note: individual users cannot use this API to query SMS signatures. For more information, please see [Identity Verification Overview](https://cloud.tencent.com/document/product/378/3629).
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsSignListRequest"/></param>
        /// <returns><see cref="DescribeSmsSignListResponse"/></returns>
        public async Task<DescribeSmsSignListResponse> DescribeSmsSignList(DescribeSmsSignListRequest req)
        {
             JsonResponseModel<DescribeSmsSignListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmsSignList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsSignListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// >⚠️ Note: individual users cannot use this API to query SMS body templates. For more information, please see [Identity Verification Overview](https://cloud.tencent.com/document/product/378/3629).
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeSmsTemplateListResponse"/></returns>
        public async Task<DescribeSmsTemplateListResponse> DescribeSmsTemplateList(DescribeSmsTemplateListRequest req)
        {
             JsonResponseModel<DescribeSmsTemplateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSmsTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an SMS signature. Please read the [Tencent Cloud SMS Signature Review Standards](https://cloud.tencent.com/document/product/382/39022) before making a modification.
        /// >- ⚠️ Note: individual users cannot use this API to modify SMS signatures. For more information, please see [Identity Verification Overview](https://cloud.tencent.com/document/product/378/3629). If your account identity is individual, you can log in to the console to modify SMS signatures.
        /// >- Modifications can be made only if the signature status is **pending review** or **rejected**. **Approved** signatures cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsSignRequest"/></param>
        /// <returns><see cref="ModifySmsSignResponse"/></returns>
        public async Task<ModifySmsSignResponse> ModifySmsSign(ModifySmsSignRequest req)
        {
             JsonResponseModel<ModifySmsSignResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySmsSign");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySmsSignResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an SMS body template. Please read the [Tencent Cloud SMS Body Template Review Standards](https://cloud.tencent.com/document/product/382/39023) before making a modification.
        /// >- ⚠️ Note: individual users cannot use this API to modify SMS body templates. For more information, please see [Identity Verification Overview](https://cloud.tencent.com/document/product/378/3629). If your account identity is individual, you can log in to the console to modify SMS body templates.
        /// >- Modifications can be made only if the body template status is **pending review** or **rejected**. **Approved** body templates cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifySmsTemplateRequest"/></param>
        /// <returns><see cref="ModifySmsTemplateResponse"/></returns>
        public async Task<ModifySmsTemplateResponse> ModifySmsTemplate(ModifySmsTemplateRequest req)
        {
             JsonResponseModel<ModifySmsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySmsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySmsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull SMS reply status.
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusResponse"/></returns>
        public async Task<PullSmsReplyStatusResponse> PullSmsReplyStatus(PullSmsReplyStatusRequest req)
        {
             JsonResponseModel<PullSmsReplyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsReplyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsReplyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull SMS reply status for one single number.
        /// </summary>
        /// <param name="req"><see cref="PullSmsReplyStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsReplyStatusByPhoneNumberResponse"/></returns>
        public async Task<PullSmsReplyStatusByPhoneNumberResponse> PullSmsReplyStatusByPhoneNumber(PullSmsReplyStatusByPhoneNumberRequest req)
        {
             JsonResponseModel<PullSmsReplyStatusByPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsReplyStatusByPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsReplyStatusByPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull SMS delivery status.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusResponse"/></returns>
        public async Task<PullSmsSendStatusResponse> PullSmsSendStatus(PullSmsSendStatusRequest req)
        {
             JsonResponseModel<PullSmsSendStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsSendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsSendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pull SMS delivery status for one single number.
        /// </summary>
        /// <param name="req"><see cref="PullSmsSendStatusByPhoneNumberRequest"/></param>
        /// <returns><see cref="PullSmsSendStatusByPhoneNumberResponse"/></returns>
        public async Task<PullSmsSendStatusByPhoneNumberResponse> PullSmsSendStatusByPhoneNumber(PullSmsSendStatusByPhoneNumberRequest req)
        {
             JsonResponseModel<PullSmsSendStatusByPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsSendStatusByPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsSendStatusByPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to send SMS verification codes, notification, or marketing messages to users.
        /// 
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public async Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to collect statistics on SMS sent by users.
        /// </summary>
        /// <param name="req"><see cref="SendStatusStatisticsRequest"/></param>
        /// <returns><see cref="SendStatusStatisticsResponse"/></returns>
        public async Task<SendStatusStatisticsResponse> SendStatusStatistics(SendStatusStatisticsRequest req)
        {
             JsonResponseModel<SendStatusStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendStatusStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendStatusStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to collect statistics on user's packages.
        /// </summary>
        /// <param name="req"><see cref="SmsPackagesStatisticsRequest"/></param>
        /// <returns><see cref="SmsPackagesStatisticsResponse"/></returns>
        public async Task<SmsPackagesStatisticsResponse> SmsPackagesStatistics(SmsPackagesStatisticsRequest req)
        {
             JsonResponseModel<SmsPackagesStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SmsPackagesStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SmsPackagesStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
