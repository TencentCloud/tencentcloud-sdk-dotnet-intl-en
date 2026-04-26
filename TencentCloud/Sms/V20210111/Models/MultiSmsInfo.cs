/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MultiSmsInfo : AbstractModel
    {
        
        /// <summary>
        /// Target mobile number in the E.164 standard in the format of +[country/region code][mobile number]. Up to 200 mobile numbers are supported in one request (which should be all global mobile numbers). For example, +60198890000, which has a + sign followed by 60 (country/region code) and then by 198890000 (mobile number).
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// Template ID, which can be viewed on the **Body Templates** page in [Global SMS](https://console.cloud.tencent.com/smsv2/isms-template). You must enter the ID of an approved template.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Template parameter. If there is no template parameter, leave this field empty.
        /// <dx-alert infotype="notice" title="Note">The number of template parameters should be consistent with that of the template variables of `TemplateId`.</dx-alert>
        /// </summary>
        [JsonProperty("TemplateParamSet")]
        public string[] TemplateParamSet{ get; set; }

        /// <summary>
        /// Sender ID for Global SMS. For detail, please refer to the [Sender ID](https://www.tencentcloud.com/document/product/382/58270) Guidelines.
        /// Note: This parameter applies solely to Global SMS. If you do not require a dedicated Sender ID, the public Sender ID will be used by default, and this parameter may be left blank.
        /// Example: Qsms
        /// </summary>
        [JsonProperty("SenderId")]
        public string SenderId{ get; set; }

        /// <summary>
        /// User session content, which can carry context information such as user-side ID and will be returned as-is by the server. Note that the length must be less than 512 bytes.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArraySimple(map, prefix + "TemplateParamSet.", this.TemplateParamSet);
            this.SetParamSimple(map, prefix + "SenderId", this.SenderId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
        }
    }
}

