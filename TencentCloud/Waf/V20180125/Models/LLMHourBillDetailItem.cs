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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LLMHourBillDetailItem : AbstractModel
    {
        
        /// <summary>
        /// Hour range, for example, 00:00-01:00.
        /// </summary>
        [JsonProperty("TimeRange")]
        public string TimeRange{ get; set; }

        /// <summary>
        /// Prompt attack protection metering value (in tokens)
        /// </summary>
        [JsonProperty("PromptAttackUsage")]
        public long? PromptAttackUsage{ get; set; }

        /// <summary>
        /// Content compliance detection (text) metering value (in tokens)
        /// </summary>
        [JsonProperty("ContentTextUsage")]
        public long? ContentTextUsage{ get; set; }

        /// <summary>
        /// Content compliance detection (image) metering value (in images)
        /// </summary>
        [JsonProperty("ContentImageUsage")]
        public long? ContentImageUsage{ get; set; }

        /// <summary>
        /// Sensitive data detection metering value (in tokens)
        /// </summary>
        [JsonProperty("SensitiveDataUsage")]
        public long? SensitiveDataUsage{ get; set; }

        /// <summary>
        /// Prompt attack protection cost for the hour (in CNY)
        /// </summary>
        [JsonProperty("PromptAttackFee")]
        public string PromptAttackFee{ get; set; }

        /// <summary>
        /// Content compliance detection (text) cost for the hour (in CNY)
        /// </summary>
        [JsonProperty("ContentTextFee")]
        public string ContentTextFee{ get; set; }

        /// <summary>
        /// Content compliance detection (image) cost for the hour (in CNY)
        /// </summary>
        [JsonProperty("ContentImageFee")]
        public string ContentImageFee{ get; set; }

        /// <summary>
        /// Sensitive data detection cost for the hour (in CNY)
        /// </summary>
        [JsonProperty("SensitiveDataFee")]
        public string SensitiveDataFee{ get; set; }

        /// <summary>
        /// Total bill amount for the hour (in CNY, net cost)
        /// </summary>
        [JsonProperty("TotalFee")]
        public string TotalFee{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
            this.SetParamSimple(map, prefix + "PromptAttackUsage", this.PromptAttackUsage);
            this.SetParamSimple(map, prefix + "ContentTextUsage", this.ContentTextUsage);
            this.SetParamSimple(map, prefix + "ContentImageUsage", this.ContentImageUsage);
            this.SetParamSimple(map, prefix + "SensitiveDataUsage", this.SensitiveDataUsage);
            this.SetParamSimple(map, prefix + "PromptAttackFee", this.PromptAttackFee);
            this.SetParamSimple(map, prefix + "ContentTextFee", this.ContentTextFee);
            this.SetParamSimple(map, prefix + "ContentImageFee", this.ContentImageFee);
            this.SetParamSimple(map, prefix + "SensitiveDataFee", this.SensitiveDataFee);
            this.SetParamSimple(map, prefix + "TotalFee", this.TotalFee);
        }
    }
}

