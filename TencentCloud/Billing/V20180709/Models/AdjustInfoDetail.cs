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
        /// Payer UIN, namely the account ID of the payer. The account ID is the user's unique account identifier on Tencent Cloud.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// Example value: 909619400.
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// Bill month. Format: yyyy-MM.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// Example value: 2024-10.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Adjustment type.
        /// Adjustment: manualAdjustment.
        /// Supplementary settlement: supplementarySettlement.
        /// Re-settlement: reSettlement.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// Example value: manualAdjustment.
        /// </summary>
        [JsonProperty("AdjustType")]
        public string AdjustType{ get; set; }

        /// <summary>
        /// Adjustment order number.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// Example value: 2220726096135.
        /// </summary>
        [JsonProperty("AdjustNum")]
        public string AdjustNum{ get; set; }

        /// <summary>
        /// Completion time of exception adjustment. Format: yyyy-MM-dd HH:mm:ss.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// Example value: 2022-12-02 12:39:04.
        /// </summary>
        [JsonProperty("AdjustCompletionTime")]
        public string AdjustCompletionTime{ get; set; }

        /// <summary>
        /// Adjustment amount.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// Example value: 333.00000000.
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

