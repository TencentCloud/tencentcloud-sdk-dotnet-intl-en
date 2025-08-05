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
        /// Authentication option ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Specifies the authentication option name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Authentication rule type. only returned in the response. valid values:.
        /// <li>PRESET: system PRESET rule. only AttesterDuration can be modified.</li>.
        /// <Li>CUSTOM: user-defined rules.</li>.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Authentication method. valid values:.
        /// <Li>TC-RCE: uses the full-stack risk control engine for authentication.</li>.
        /// <Li>TC-CAPTCHA-Intl: specifies authentication using captcha-intl.</li>.
        /// </summary>
        [JsonProperty("AttesterSource")]
        public string AttesterSource{ get; set; }

        /// <summary>
        /// Validity time of the authentication. defaults to 60s. supported measurement units:.
        /// <Li>S: specifies seconds. value range: 60–43200.</li>.
        /// <Li>M: specifies minutes. value range: 1–720.</li>.
        /// <Li>H. specifies the hour. value range: 1–12.</li>.
        /// </summary>
        [JsonProperty("AttesterDuration")]
        public string AttesterDuration{ get; set; }

        /// <summary>
        /// TC-RCE authentication configuration message.
        /// <li>Specifies the required field when the AttesterSource parameter value is TC-RCE.</li>.
        /// </summary>
        [JsonProperty("TCRCEOption")]
        public TCRCEOption TCRCEOption{ get; set; }

        /// <summary>
        /// Specifies the configuration message for TC-CAPTCHA certification.
        /// <li>Specifies the required field when the AttesterSource parameter value is TC-CAPTCHA.</li>.
        /// </summary>
        [JsonProperty("TCCaptchaOption")]
        public TCCaptchaOption TCCaptchaOption{ get; set; }


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
            this.SetParamObj(map, prefix + "TCRCEOption.", this.TCRCEOption);
            this.SetParamObj(map, prefix + "TCCaptchaOption.", this.TCCaptchaOption);
        }
    }
}

