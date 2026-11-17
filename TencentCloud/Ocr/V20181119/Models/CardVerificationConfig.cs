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

    public class CardVerificationConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to perform card field recognition, true by default</p>
        /// </summary>
        [JsonProperty("EnableRecognition")]
        public bool? EnableRecognition{ get; set; }

        /// <summary>
        /// <p>Whether to perform quality detection (blurry/reflective/incomplete border/obstruction). false by default</p>
        /// </summary>
        [JsonProperty("EnableQualityCheck")]
        public bool? EnableQualityCheck{ get; set; }

        /// <summary>
        /// <p>Whether to perform tampering detection (PS/synthesis/electronic). false by default</p>
        /// </summary>
        [JsonProperty("EnableTamperCheck")]
        public bool? EnableTamperCheck{ get; set; }

        /// <summary>
        /// <p>Whether to perform photocopy detection. false by default</p>
        /// </summary>
        [JsonProperty("EnableCopyCheck")]
        public bool? EnableCopyCheck{ get; set; }

        /// <summary>
        /// <p>Whether to perform rephotography detection. false by default</p>
        /// </summary>
        [JsonProperty("EnableRecaptureCheck")]
        public bool? EnableRecaptureCheck{ get; set; }

        /// <summary>
        /// <p>Whether to perform format validation (dependent recognition). false by default</p>
        /// </summary>
        [JsonProperty("EnableFormatCheck")]
        public bool? EnableFormatCheck{ get; set; }

        /// <summary>
        /// <p>Whether to perform both sides consistency check (dependent on recognition), false by default</p>
        /// </summary>
        [JsonProperty("EnableConsistencyCheck")]
        public bool? EnableConsistencyCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableRecognition", this.EnableRecognition);
            this.SetParamSimple(map, prefix + "EnableQualityCheck", this.EnableQualityCheck);
            this.SetParamSimple(map, prefix + "EnableTamperCheck", this.EnableTamperCheck);
            this.SetParamSimple(map, prefix + "EnableCopyCheck", this.EnableCopyCheck);
            this.SetParamSimple(map, prefix + "EnableRecaptureCheck", this.EnableRecaptureCheck);
            this.SetParamSimple(map, prefix + "EnableFormatCheck", this.EnableFormatCheck);
            this.SetParamSimple(map, prefix + "EnableConsistencyCheck", this.EnableConsistencyCheck);
        }
    }
}

