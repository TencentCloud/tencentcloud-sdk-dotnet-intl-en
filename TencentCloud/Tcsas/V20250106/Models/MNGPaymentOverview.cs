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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MNGPaymentOverview : AbstractModel
    {
        
        /// <summary>
        /// Paid revenue / Number of paying users * 100%
        /// </summary>
        [JsonProperty("ARPPu")]
        public string ARPPu{ get; set; }

        /// <summary>
        /// Data time in YYYYMMDD format
        /// </summary>
        [JsonProperty("DataTime")]
        public string DataTime{ get; set; }

        /// <summary>
        /// New paying user ratio = NewUserNum / OrderUserNum * 100%
        /// </summary>
        [JsonProperty("NewPaidUseRatio")]
        public string NewPaidUseRatio{ get; set; }

        /// <summary>
        /// Number of new paying users
        /// </summary>
        [JsonProperty("NewPaidUserNum")]
        public long? NewPaidUserNum{ get; set; }

        /// <summary>
        /// Total payment amount from new users
        /// </summary>
        [JsonProperty("NewUserPaidAmount")]
        public string NewUserPaidAmount{ get; set; }

        /// <summary>
        /// Total payment amount
        /// </summary>
        [JsonProperty("PaidAmount")]
        public string PaidAmount{ get; set; }

        /// <summary>
        /// Number of paying users
        /// </summary>
        [JsonProperty("PaidUserNum")]
        public long? PaidUserNum{ get; set; }

        /// <summary>
        /// Refund amount
        /// </summary>
        [JsonProperty("RefundAmount")]
        public string RefundAmount{ get; set; }

        /// <summary>
        /// Number of refund orders
        /// </summary>
        [JsonProperty("RefundNum")]
        public long? RefundNum{ get; set; }

        /// <summary>
        /// Update time (timestamp in seconds)
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ARPPu", this.ARPPu);
            this.SetParamSimple(map, prefix + "DataTime", this.DataTime);
            this.SetParamSimple(map, prefix + "NewPaidUseRatio", this.NewPaidUseRatio);
            this.SetParamSimple(map, prefix + "NewPaidUserNum", this.NewPaidUserNum);
            this.SetParamSimple(map, prefix + "NewUserPaidAmount", this.NewUserPaidAmount);
            this.SetParamSimple(map, prefix + "PaidAmount", this.PaidAmount);
            this.SetParamSimple(map, prefix + "PaidUserNum", this.PaidUserNum);
            this.SetParamSimple(map, prefix + "RefundAmount", this.RefundAmount);
            this.SetParamSimple(map, prefix + "RefundNum", this.RefundNum);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

