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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlgDetectSession : AbstractModel
    {
        
        /// <summary>
        /// Method to validate Cookie.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The validation mode. Values:
        /// <li>`detect`: Validate only</li>
        /// <li>`update_detect` (default): Update Cookie and validate</li>
        /// </summary>
        [JsonProperty("DetectMode")]
        public string DetectMode{ get; set; }

        /// <summary>
        /// Whether to enable Cookie-based session check. The default value is `off`. Values:
        /// <li>`off`: Disable</li>
        /// <li>`on`: Enable</li>
        /// </summary>
        [JsonProperty("SessionAnalyzeSwitch")]
        public string SessionAnalyzeSwitch{ get; set; }

        /// <summary>
        /// The period threshold for validating the result "No Cookie/Cookie expired" in seconds. Value range: 5-3600. Default value: 10.
        /// </summary>
        [JsonProperty("InvalidStatTime")]
        public long? InvalidStatTime{ get; set; }

        /// <summary>
        /// The number of times for the result "No Cookie/Cookie expired" occurred in the specified period. Value range: 1-100000000. Default value: 300.
        /// </summary>
        [JsonProperty("InvalidThreshold")]
        public long? InvalidThreshold{ get; set; }

        /// <summary>
        /// Cookie validation results.
        /// </summary>
        [JsonProperty("AlgDetectResults")]
        public AlgDetectResult[] AlgDetectResults{ get; set; }

        /// <summary>
        /// Cookie-based session check results.
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

