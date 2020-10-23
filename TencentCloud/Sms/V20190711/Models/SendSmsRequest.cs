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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendSmsRequest : AbstractModel
    {
        
        /// <summary>
        /// Target mobile number in the e.164 standard in the format of +[country/region code][mobile number]. Up to 200 mobile numbers are supported in one request (which should be all Mainland China mobile numbers or all global mobile numbers).
        /// Example: +8613711112222, which has a + sign followed by 86 (country/region code) and then by 13711112222 (mobile number).
        /// </summary>
        [JsonProperty("PhoneNumberSet")]
        public string[] PhoneNumberSet{ get; set; }

        /// <summary>
        /// Template ID. You must enter the ID of an approved template, which can be viewed in the [SMS Console](https://console.cloud.tencent.com/sms/smslist).
        /// </summary>
        [JsonProperty("TemplateID")]
        public string TemplateID{ get; set; }

        /// <summary>
        /// SMS `SdkAppid` actually generated after an application is added in the [SMS Console](https://console.cloud.tencent.com/sms/smslist), such as 1400006666.
        /// </summary>
        [JsonProperty("SmsSdkAppid")]
        public string SmsSdkAppid{ get; set; }

        /// <summary>
        /// The content of SMS signature should be encoded in UTF-8. You must enter an approved signature, which can be viewed in the [SMS Console](https://console.cloud.tencent.com/sms/smslist). Note: this parameter is required for Mainland China SMS.
        /// </summary>
        [JsonProperty("Sign")]
        public string Sign{ get; set; }

        /// <summary>
        /// Template parameter. If there is no template parameter, leave this parameter blank.
        /// </summary>
        [JsonProperty("TemplateParamSet")]
        public string[] TemplateParamSet{ get; set; }

        /// <summary>
        /// SMS code number extension, which is not activated by default. If you need to activate it, please contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ExtendCode")]
        public string ExtendCode{ get; set; }

        /// <summary>
        /// User session content, which can carry context information such as user-side ID and will be returned as-is by the server.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// `senderid` for Global SMS, which is not activated by default. If you need to activate it, please contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1) for assistance. This parameter should be empty for Mainland China SMS.
        /// </summary>
        [JsonProperty("SenderId")]
        public string SenderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PhoneNumberSet.", this.PhoneNumberSet);
            this.SetParamSimple(map, prefix + "TemplateID", this.TemplateID);
            this.SetParamSimple(map, prefix + "SmsSdkAppid", this.SmsSdkAppid);
            this.SetParamSimple(map, prefix + "Sign", this.Sign);
            this.SetParamArraySimple(map, prefix + "TemplateParamSet.", this.TemplateParamSet);
            this.SetParamSimple(map, prefix + "ExtendCode", this.ExtendCode);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SenderId", this.SenderId);
        }
    }
}

