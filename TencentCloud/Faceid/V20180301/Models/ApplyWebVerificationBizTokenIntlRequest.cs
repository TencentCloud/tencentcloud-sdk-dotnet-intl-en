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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyWebVerificationBizTokenIntlRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>The Web redirect URL after verification, including the protocol header, host name, and path, for example, https://www.tencentcloud.com/products/faceid.<br>After the verification process is completed, the BizToken of the current process is appended to the redirect URL, and the redirect is performed in the format of https://www.tencentcloud.com/products/faceid?token={BizToken}.</p>
        /// </summary>
        [JsonProperty("RedirectURL")]
        public string RedirectURL{ get; set; }

        /// <summary>
        /// <p>Base64-encoded string of the comparison photo. The Data URI scheme header needs to be removed from the encoded string, and the size cannot exceed 8 MB.</p>
        /// </summary>
        [JsonProperty("CompareImageBase64")]
        public string CompareImageBase64{ get; set; }

        /// <summary>
        /// <p>Business passthrough parameter, with a maximum length of 1,000 characters. It is returned in the GetWebVerificationResultIntl API.</p>
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// <p>Id generated in the console configuration</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>Related configurations of the custom verification page.</p>
        /// </summary>
        [JsonProperty("Config")]
        public WebVerificationConfigIntl Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RedirectURL", this.RedirectURL);
            this.SetParamSimple(map, prefix + "CompareImageBase64", this.CompareImageBase64);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

