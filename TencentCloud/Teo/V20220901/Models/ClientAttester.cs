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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClientAttester : AbstractModel
    {
        
        /// <summary>
        /// <p>Option ID for certification.</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Option name for authentication.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Authentication rule type. Returned only in the response. Valid values:</p><li>PRESET: System preset rule. Only AttesterDuration can be modified.</li><li>CUSTOM: User-defined rule.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Authentication method. Valid values:</p><li>TC-RCE: Use risk identification RCE for authentication;</li><li>TC-CAPTCHA: Use Tianyu verification code for authentication;</li><li>TC-EO-CAPTCHA: Use EdgeOne human-machine verification for authentication.</li>
        /// </summary>
        [JsonProperty("AttesterSource")]
        public string AttesterSource{ get; set; }

        /// <summary>
        /// <p>Authentication validity time. Default value is 60s. Supported measurement units:</p><li>s: second, value ranges from 60 to 43200.</li><li>m: minute, value ranges from 1 to 720.</li><li>h: hour, value ranges from 1 to 12.</li>
        /// </summary>
        [JsonProperty("AttesterDuration")]
        public string AttesterDuration{ get; set; }

        /// <summary>
        /// <p>Whether to enable the usage limit for attestation results. </p><p>Valid values:</p><ul><li>on: Enabled</li><li>off: Disabled</li></ul><p>Default value: off</p>
        /// </summary>
        [JsonProperty("UsageLimit")]
        public string UsageLimit{ get; set; }

        /// <summary>
        /// <p>Whether to enable the usage limit for attestation results. </p><p>Valid values:</p><ul><li>on: Enabled</li><li>off: Disabled</li></ul><p>Default value: off</p>
        /// </summary>
        [JsonProperty("MaxUsageCount")]
        public long? MaxUsageCount{ get; set; }

        /// <summary>
        /// <p>Configuration message for TC-RCE certification.</p><li>This field is required when the AttesterSource parameter value is TC-RCE.</li>
        /// </summary>
        [JsonProperty("TCRCEOption")]
        public TCRCEOption TCRCEOption{ get; set; }

        /// <summary>
        /// <p>Configuration message for TC-CAPTCHA certification.</p><li>This field is required when the AttesterSource parameter value is TC-CAPTCHA.</li>
        /// </summary>
        [JsonProperty("TCCaptchaOption")]
        public TCCaptchaOption TCCaptchaOption{ get; set; }

        /// <summary>
        /// <p>Configuration message for TC-EO-CAPTCHA certification.</p><li>This field is required when the AttesterSource parameter value is TC-EO-CAPTCHA.</li>
        /// </summary>
        [JsonProperty("TCEOCaptchaOption")]
        public TCEOCaptchaOption TCEOCaptchaOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AttesterSource", this.AttesterSource);
            this.SetParamSimple(map, prefix + "AttesterDuration", this.AttesterDuration);
            this.SetParamSimple(map, prefix + "UsageLimit", this.UsageLimit);
            this.SetParamSimple(map, prefix + "MaxUsageCount", this.MaxUsageCount);
            this.SetParamObj(map, prefix + "TCRCEOption.", this.TCRCEOption);
            this.SetParamObj(map, prefix + "TCCaptchaOption.", this.TCCaptchaOption);
            this.SetParamObj(map, prefix + "TCEOCaptchaOption.", this.TCEOCaptchaOption);
        }
    }
}

