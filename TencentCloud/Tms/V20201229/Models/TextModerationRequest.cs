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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the text content of the object to be moderated. The text needs to be encoded in utf-8 format and encrypted with Base64. It can contain up to 10,000 characters, calculated by unicode encoding.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// This field indicates the specific policy number, which is used for the API call and can be configured in the CMS console. If it's not entered (left empty), the default moderation policy is adopted. If it's entered, the moderation policies are specified for business scenarios. <br>Note: Biztype contains 3 to 32 characters, including numbers, letters and underscores only. Different Biztypes are associated with different business scenarios and moderation policies. Ensure that you use the Biztype corresponding to the policy you want to apply.
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// This field indicates the data ID you assigned to the object to be moderated, which is convenient for you to identify and manage the file. <br>Value: this field can contain **up to 64 characters**, including uppercase and lowercase letters, numbers and four special symbols (_, -, @, #)
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// This field indicates the user information related with the object to be moderated, which can be used to identify violating users at risk.
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }

        /// <summary>
        /// This field indicates the device information related with the object to be moderated, which can be used to identify violating devices at risk.
        /// </summary>
        [JsonProperty("Device")]
        public Device Device{ get; set; }

        /// <summary>
        /// This field Indicates the original language of the content.The enumeration values are ("en", "zh", ""), where en means English, zh means Chinese, and an empty string means the default language is Chinese. It is recommended to enter "en" only when the language of the content is clearly "English".
        /// </summary>
        [JsonProperty("SourceLanguage")]
        public string SourceLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamObj(map, prefix + "User.", this.User);
            this.SetParamObj(map, prefix + "Device.", this.Device);
            this.SetParamSimple(map, prefix + "SourceLanguage", this.SourceLanguage);
        }
    }
}

