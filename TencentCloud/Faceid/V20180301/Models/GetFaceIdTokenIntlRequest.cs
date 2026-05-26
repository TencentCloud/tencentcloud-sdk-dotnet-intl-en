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

    public class GetFaceIdTokenIntlRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Indicates the detection mode. Parameter values as follows:<br>"liveness": liveness detection only;<br>"compare": liveness detection + face comparison;<br>Default value: "liveness".</p>
        /// </summary>
        [JsonProperty("CheckMode")]
        public string CheckMode{ get; set; }

        /// <summary>
        /// <p>Indicates the security level of authentication. Security levels are divided into:<br>"1": silent liveness;<br>"2": action liveness detection;<br>"3": light liveness;<br>"4": action + light liveness;<br>Default value is "4".</p>
        /// **Note:** Security level increases from `1` to `4`, with `4` providing the highest security.
        /// </summary>
        [JsonProperty("SecureLevel")]
        public string SecureLevel{ get; set; }

        /// <summary>
        /// <p>The base64 code of the image for comparison, used for the "liveness comparison" mode. This parameter is required when CheckMode is "compare".</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>This parameter is a business passthrough parameter and can be omitted unless otherwise needed.</p>
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// <p>This API is used to control the sequence of actions. The action types are as follows:<br>"blink"<br>"mouth"<br>"nod"<br>"shake"<br>Choose 1-2 actions from the four.<br>Single action example: "blink"<br>Multi-action example: "blink,mouth".<br>Default value is blink.<br>Input this parameter only when SecureLevel is 2 or 4 for different action types to take effect; otherwise, the API returns an error.</p>
        /// </summary>
        [JsonProperty("ActionList")]
        public string ActionList{ get; set; }

        /// <summary>
        /// <p>PLUS: PLUS version, PRO: PRO version, ENHANCED: enhanced, BASIC: basic (default)</p>
        /// </summary>
        [JsonProperty("SdkVersion")]
        public string SdkVersion{ get; set; }

        /// <summary>
        /// <p>Liveness retry count</p><p>Value ranges from 1 to 5</p><p>Default value: 5</p>
        /// </summary>
        [JsonProperty("RetryLimit")]
        public long? RetryLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckMode", this.CheckMode);
            this.SetParamSimple(map, prefix + "SecureLevel", this.SecureLevel);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "ActionList", this.ActionList);
            this.SetParamSimple(map, prefix + "SdkVersion", this.SdkVersion);
            this.SetParamSimple(map, prefix + "RetryLimit", this.RetryLimit);
        }
    }
}

