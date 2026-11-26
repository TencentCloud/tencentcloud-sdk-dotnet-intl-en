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

    public class AlgDetectSession : AbstractModel
    {
        
        /// <summary>
        /// Operation name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Verification method. Default value: update_detect. Valid values:
        /// <li>detect: verify;</li>
        /// <li>update_detect: refresh the Cookie and validate it.</li>
        /// </summary>
        [JsonProperty("DetectMode")]
        public string DetectMode{ get; set; }

        /// <summary>
        /// Switch for session rate and periodic feature verification. Default value: off. Valid values:
        /// <li>off: Disable;</li>
        /// <li>`on`: Enable.</li>
        /// </summary>
        [JsonProperty("SessionAnalyzeSwitch")]
        public string SessionAnalyzeSwitch{ get; set; }

        /// <summary>
        /// Statistical cycle for the check result indicating no Cookie is carried or the Cookie has expired. Unit: seconds. Default: 10. Value range: 5–3600.
        /// </summary>
        [JsonProperty("InvalidStatTime")]
        public long? InvalidStatTime{ get; set; }

        /// <summary>
        /// Trigger threshold for the check result indicating no Cookie is carried or the Cookie has expired. Unit: count. Default: 300. Value range: 1–100000000.
        /// </summary>
        [JsonProperty("InvalidThreshold")]
        public long? InvalidThreshold{ get; set; }

        /// <summary>
        /// Cookie verification result.
        /// </summary>
        [JsonProperty("AlgDetectResults")]
        public AlgDetectResult[] AlgDetectResults{ get; set; }

        /// <summary>
        /// Session rate and periodic feature verification result.
        /// </summary>
        [JsonProperty("SessionBehaviors")]
        public AlgDetectResult[] SessionBehaviors{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "SessionAnalyzeSwitch", this.SessionAnalyzeSwitch);
            this.SetParamSimple(map, prefix + "InvalidStatTime", this.InvalidStatTime);
            this.SetParamSimple(map, prefix + "InvalidThreshold", this.InvalidThreshold);
            this.SetParamArrayObj(map, prefix + "AlgDetectResults.", this.AlgDetectResults);
            this.SetParamArrayObj(map, prefix + "SessionBehaviors.", this.SessionBehaviors);
        }
    }
}

