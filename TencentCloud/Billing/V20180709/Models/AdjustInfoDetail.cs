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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdjustInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// Payer UIN: Account ID of the payer, which is the unique account identifier for the user in Tencent Cloud.
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// Bill month, formatted as yyyy-MM.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Adjustment type
        /// Bill adjustment: manualAdjustment
        /// Supplementary settlement: supplementarySettlement
        /// Re-settlement
        /// </summary>
        [JsonProperty("AdjustType")]
        public string AdjustType{ get; set; }

        /// <summary>
        /// Adjustment Number
        /// </summary>
        [JsonProperty("AdjustNum")]
        public string AdjustNum{ get; set; }

        /// <summary>
        /// Abnormal adjustment completion time. Format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("AdjustCompletionTime")]
        public string AdjustCompletionTime{ get; set; }

        /// <summary>
        /// Adjustment Amount
        /// </summary>
        [JsonProperty("AdjustAmount")]
        public float? AdjustAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "AdjustType", this.AdjustType);
            this.SetParamSimple(map, prefix + "AdjustNum", this.AdjustNum);
            this.SetParamSimple(map, prefix + "AdjustCompletionTime", this.AdjustCompletionTime);
            this.SetParamSimple(map, prefix + "AdjustAmount", this.AdjustAmount);
        }
    }
}

