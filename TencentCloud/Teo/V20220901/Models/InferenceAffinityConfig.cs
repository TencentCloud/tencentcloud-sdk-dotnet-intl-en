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

    public class InferenceAffinityConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Master switch for inference service affinity.</p><p>Enumeration values:</p><ul><li>On: Enable inference service affinity;</li><li>Off: Disable inference service affinity.</li></ul>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>Affinity approach for inference service.</p><p>Enumeration values:</p><ul><li>SessionId: Affinity based on session ID.</li></ul><p>Default value: SessionId.</p>
        /// </summary>
        [JsonProperty("AffinityMode")]
        public string AffinityMode{ get; set; }

        /// <summary>
        /// <p>Inference service affinity configuration. Required when AffinityMode is SessionId.</p>
        /// </summary>
        [JsonProperty("SessionIdAffinityConfig")]
        public SessionIdAffinityConfig SessionIdAffinityConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "AffinityMode", this.AffinityMode);
            this.SetParamObj(map, prefix + "SessionIdAffinityConfig.", this.SessionIdAffinityConfig);
        }
    }
}

