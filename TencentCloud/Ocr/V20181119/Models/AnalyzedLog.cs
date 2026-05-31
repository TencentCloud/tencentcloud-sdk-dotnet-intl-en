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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalyzedLog : AbstractModel
    {
        
        /// <summary>
        /// <p>Indexes of the procedure.</p><p>Enumeration value:</p><ul><li>L1_IMAGE_QUALITY: Image quality detection</li><li>L2_RULE_ENGINE: Rule verification</li><li>L3_LLM_JUDGE: Large model judgment</li></ul>
        /// </summary>
        [JsonProperty("StepKey")]
        public string StepKey{ get; set; }

        /// <summary>
        /// <p>Compliant and non-compliant are final states; to be determined is an intermediate state. Judgment status of each layer: Compliant Non-Compliant Pending.</p>
        /// </summary>
        [JsonProperty("Decision")]
        public string Decision{ get; set; }

        /// <summary>
        /// <p>Reason for the current layer judgment</p>
        /// </summary>
        [JsonProperty("DecisionMessage")]
        public string DecisionMessage{ get; set; }

        /// <summary>
        /// <p>Time taken by the current layer</p><p>Unit: ms</p>
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StepKey", this.StepKey);
            this.SetParamSimple(map, prefix + "Decision", this.Decision);
            this.SetParamSimple(map, prefix + "DecisionMessage", this.DecisionMessage);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
        }
    }
}

