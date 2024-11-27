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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedClusterOrderItem : AbstractModel
    {
        
        /// <summary>
        /// CDC type id
        /// </summary>
        [JsonProperty("DedicatedClusterTypeId")]
        public string DedicatedClusterTypeId{ get; set; }

        /// <summary>
        /// List of supported storage types
        /// </summary>
        [JsonProperty("SupportedStorageType")]
        public string[] SupportedStorageType{ get; set; }

        /// <summary>
        /// Supported uplink switch transmission rate (GiB)
        /// </summary>
        [JsonProperty("SupportedUplinkSpeed")]
        public long?[] SupportedUplinkSpeed{ get; set; }

        /// <summary>
        /// List of supported instance families
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
        [JsonProperty("SubOrderStatus")]
        public string SubOrderStatus{ get; set; }

        /// <summary>
        /// Order creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Sub-order ID
        /// </summary>
        [JsonProperty("SubOrderId")]
        public string SubOrderId{ get; set; }

        /// <summary>
        /// Number of linked cluster types
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Brief description of type
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Detailed description of type
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Number of CPUs
        /// </summary>
        [JsonProperty("TotalCpu")]
        public long? TotalCpu{ get; set; }

        /// <summary>
        /// Number of memories
        /// </summary>
        [JsonProperty("TotalMem")]
        public long? TotalMem{ get; set; }

        /// <summary>
        /// Total GPUs
        /// </summary>
        [JsonProperty("TotalGpu")]
        public long? TotalGpu{ get; set; }

        /// <summary>
        /// English type name
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// Type display 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ComputeFormat")]
        public string ComputeFormat{ get; set; }

        /// <summary>
        /// Type family 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("TypeFamily")]
        public string TypeFamily{ get; set; }

        /// <summary>
        /// 0 for unpaid, 1 for paid 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("SubOrderPayStatus")]
        public long? SubOrderPayStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedClusterTypeId", this.DedicatedClusterTypeId);
            this.SetParamArraySimple(map, prefix + "SupportedStorageType.", this.SupportedStorageType);
            this.SetParamArraySimple(map, prefix + "SupportedUplinkSpeed.", this.SupportedUplinkSpeed);
            this.SetParamArraySimple(map, prefix + "SupportedInstanceFamily.", this.SupportedInstanceFamily);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "PowerDraw", this.PowerDraw);
            this.SetParamSimple(map, prefix + "SubOrderStatus", this.SubOrderStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SubOrderId", this.SubOrderId);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TotalCpu", this.TotalCpu);
            this.SetParamSimple(map, prefix + "TotalMem", this.TotalMem);
            this.SetParamSimple(map, prefix + "TotalGpu", this.TotalGpu);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "ComputeFormat", this.ComputeFormat);
            this.SetParamSimple(map, prefix + "TypeFamily", this.TypeFamily);
            this.SetParamSimple(map, prefix + "SubOrderPayStatus", this.SubOrderPayStatus);
        }
    }
}

