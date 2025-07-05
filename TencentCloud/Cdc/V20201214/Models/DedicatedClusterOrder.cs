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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedClusterOrder : AbstractModel
    {
        
        /// <summary>
        /// CDC id
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// CDC type id (moved to the next level, obsolete and will be deleted later)
        /// </summary>
        [JsonProperty("DedicatedClusterTypeId")]
        public string DedicatedClusterTypeId{ get; set; }

        /// <summary>
        /// List of supported storage types (moved to the next level, obsolete and will be deleted later)
        /// </summary>
        [JsonProperty("SupportedStorageType")]
        public string[] SupportedStorageType{ get; set; }

        /// <summary>
        /// Supported uplink switch transmission rate (GiB) (moved to the next level, obsolete and will be deleted later)
        /// </summary>
        [JsonProperty("SupportedUplinkSpeed")]
        public long?[] SupportedUplinkSpeed{ get; set; }

        /// <summary>
        /// List of supported instance families (moved to the next level, obsolete and will be deleted later)
        /// </summary>
        [JsonProperty("SupportedInstanceFamily")]
        public string[] SupportedInstanceFamily{ get; set; }

        /// <summary>
        /// Floor weight capacity (KG)
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Power requirements (KW)
        /// </summary>
        [JsonProperty("PowerDraw")]
        public float? PowerDraw{ get; set; }

        /// <summary>
        /// Order status
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus{ get; set; }

        /// <summary>
        /// Order creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Large order ID
        /// </summary>
        [JsonProperty("DedicatedClusterOrderId")]
        public string DedicatedClusterOrderId{ get; set; }

        /// <summary>
        /// Order type, CREATE or EXTEND
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// List of sub-order details 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("DedicatedClusterOrderItems")]
        public DedicatedClusterOrderItem[] DedicatedClusterOrderItems{ get; set; }

        /// <summary>
        /// CPU value 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// MEM value 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Mem")]
        public long? Mem{ get; set; }

        /// <summary>
        /// GPU value 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Gpu")]
        public long? Gpu{ get; set; }

        /// <summary>
        /// 0 for unpaid, 1 for paid 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("PayStatus")]
        public long? PayStatus{ get; set; }

        /// <summary>
        /// Payment method: lump-sum, monthly, and annually 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// Unit of purchased period 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Purchased period 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Order type 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeliverExpectTime")]
        public string DeliverExpectTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeliverFinishTime")]
        public string DeliverFinishTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CheckExpectTime")]
        public string CheckExpectTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CheckFinishTime")]
        public string CheckFinishTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OrderSLA")]
        public string OrderSLA{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OrderPayPlan")]
        public string OrderPayPlan{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "DedicatedClusterTypeId", this.DedicatedClusterTypeId);
            this.SetParamArraySimple(map, prefix + "SupportedStorageType.", this.SupportedStorageType);
            this.SetParamArraySimple(map, prefix + "SupportedUplinkSpeed.", this.SupportedUplinkSpeed);
            this.SetParamArraySimple(map, prefix + "SupportedInstanceFamily.", this.SupportedInstanceFamily);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "PowerDraw", this.PowerDraw);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DedicatedClusterOrderId", this.DedicatedClusterOrderId);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArrayObj(map, prefix + "DedicatedClusterOrderItems.", this.DedicatedClusterOrderItems);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "PayStatus", this.PayStatus);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "DeliverExpectTime", this.DeliverExpectTime);
            this.SetParamSimple(map, prefix + "DeliverFinishTime", this.DeliverFinishTime);
            this.SetParamSimple(map, prefix + "CheckExpectTime", this.CheckExpectTime);
            this.SetParamSimple(map, prefix + "CheckFinishTime", this.CheckFinishTime);
            this.SetParamSimple(map, prefix + "OrderSLA", this.OrderSLA);
            this.SetParamSimple(map, prefix + "OrderPayPlan", this.OrderPayPlan);
        }
    }
}

