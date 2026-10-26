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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVideoSnapshotTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Template name: Chinese, English, digits, "-", "_", with a length not exceeding 128 characters</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Screenshot type: 1-Real-time frame capture 2-Low frequency frame capture<br>Note: Real-time frame capture pulls the real-time stream throughout the effective period. Low frequency frame capture pulls the real-time stream as needed during the effective period, with a minimum duration of not less than 1 minute each time.</p><p>Enumeration values:</p><ul><li>1: Real-time frame capture</li><li>2: Low frequency frame capture</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>Frame capturing frequency: When Type = 1, the value range is [5, 180] seconds; when Type = 2, the value range is [30, 36000] seconds</p>
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// <p>Effective period. Note: The array size is no more than 100, and each time period is not less than 1 minute.</p>
        /// </summary>
        [JsonProperty("Times")]
        public EffectiveTime[] Times{ get; set; }

        /// <summary>
        /// <p>Multiple mode</p>
        /// </summary>
        [JsonProperty("MultiMode")]
        public MultiVideoSnapshotMode MultiMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Times.", this.Times);
            this.SetParamObj(map, prefix + "MultiMode.", this.MultiMode);
        }
    }
}

