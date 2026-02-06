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

    public class MNPPaymentOverview : AbstractModel
    {
        
        /// <summary>
        /// Number of mini programs involved in the order
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderMNPNum")]
        public long? OrderMNPNum{ get; set; }

        /// <summary>
        /// Total orders
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderNum")]
        public long? OrderNum{ get; set; }

        /// <summary>
        /// Total paid orders
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderPaidNum")]
        public long? OrderPaidNum{ get; set; }

        /// <summary>
        /// Total refunded orders
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderRefundNum")]
        public long? OrderRefundNum{ get; set; }

        /// <summary>
        /// Total unpaid orders
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderUnpaidNum")]
        public long? OrderUnpaidNum{ get; set; }

        /// <summary>
        /// Total order users
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderUserNum")]
        public long? OrderUserNum{ get; set; }

        /// <summary>
        /// Total paying users
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PaidUserNum")]
        public long? PaidUserNum{ get; set; }

        /// <summary>
        /// Amount paid
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PaidAmount")]
        public string PaidAmount{ get; set; }

        /// <summary>
        /// Total amount refunded
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RefundAmount")]
        public string RefundAmount{ get; set; }

        /// <summary>
        /// Total order amount
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalAmount")]
        public string TotalAmount{ get; set; }

        /// <summary>
        /// Unpaid amount
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnpaidAmount")]
        public string UnpaidAmount{ get; set; }

        /// <summary>
        /// Timestamp
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// Data date
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataTime")]
        public string DataTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderMNPNum", this.OrderMNPNum);
            this.SetParamSimple(map, prefix + "OrderNum", this.OrderNum);
            this.SetParamSimple(map, prefix + "OrderPaidNum", this.OrderPaidNum);
            this.SetParamSimple(map, prefix + "OrderRefundNum", this.OrderRefundNum);
            this.SetParamSimple(map, prefix + "OrderUnpaidNum", this.OrderUnpaidNum);
            this.SetParamSimple(map, prefix + "OrderUserNum", this.OrderUserNum);
            this.SetParamSimple(map, prefix + "PaidUserNum", this.PaidUserNum);
            this.SetParamSimple(map, prefix + "PaidAmount", this.PaidAmount);
            this.SetParamSimple(map, prefix + "RefundAmount", this.RefundAmount);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "UnpaidAmount", this.UnpaidAmount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DataTime", this.DataTime);
        }
    }
}

