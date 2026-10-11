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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeSpecInstanceType : AbstractModel
    {
        
        /// <summary>
        /// <p>Specifications.</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>4</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>8, unit: GB.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Sorting order. Smaller values come first.</p>
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// <p>Quantity.</p>
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// <p>Sold-out reason.</p>
        /// </summary>
        [JsonProperty("SellOutReason")]
        public string SellOutReason{ get; set; }

        /// <summary>
        /// <p>System disk.</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public NodeSpecDisk[] SystemDisk{ get; set; }

        /// <summary>
        /// <p>Data disk.</p>
        /// </summary>
        [JsonProperty("DataDisk")]
        public NodeSpecDisk[] DataDisk{ get; set; }

        /// <summary>
        /// <p>Local data disk.</p>
        /// </summary>
        [JsonProperty("LocalDataDisk")]
        public NodeSpecDisk[] LocalDataDisk{ get; set; }

        /// <summary>
        /// <p>Sold-out reason.</p>
        /// </summary>
        [JsonProperty("SoldOutReason")]
        public string SoldOutReason{ get; set; }

        /// <summary>
        /// <p>Instance family.</p>
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// <p>Node name.</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>Node type.</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Category.</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Category name.</p>
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// <p>Category classification.</p>
        /// </summary>
        [JsonProperty("FamilyName")]
        public string FamilyName{ get; set; }

        /// <summary>
        /// <p>CPU type.</p>
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// <p>RunOut: sold out; Less: low inventory; Enough: sufficient inventory</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Original price.</p>
        /// </summary>
        [JsonProperty("OriginPrice")]
        public float? OriginPrice{ get; set; }

        /// <summary>
        /// <p>Purchase duration supported by instance types using the committed use billing mode.</p>
        /// </summary>
        [JsonProperty("PrepaidUnderwritePeriods")]
        public long?[] PrepaidUnderwritePeriods{ get; set; }

        /// <summary>
        /// <p>GPU information.</p>
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }

        /// <summary>
        /// <p>Number of quotas.</p>
        /// </summary>
        [JsonProperty("QuotaNum")]
        public long? QuotaNum{ get; set; }

        /// <summary>
        /// <p>Quota unit.</p>
        /// </summary>
        [JsonProperty("QuotaUnit")]
        public string QuotaUnit{ get; set; }

        /// <summary>
        /// <p>Whether a high-performance computing cluster needs to be provided.</p>
        /// </summary>
        [JsonProperty("NeedHpcClusterId")]
        public bool? NeedHpcClusterId{ get; set; }

        /// <summary>
        /// <p>Whether it is a GPU instance type.</p>
        /// </summary>
        [JsonProperty("IsGpuInstance")]
        public bool? IsGpuInstance{ get; set; }

        /// <summary>
        /// <p>GPU resource definition in the Kubernetes scenario.</p>
        /// </summary>
        [JsonProperty("GpuResourceKey")]
        public string GpuResourceKey{ get; set; }

        /// <summary>
        /// <p>Number of GPU cards.</p>
        /// </summary>
        [JsonProperty("GpuNum")]
        public long? GpuNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "SellOutReason", this.SellOutReason);
            this.SetParamArrayObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisk.", this.DataDisk);
            this.SetParamArrayObj(map, prefix + "LocalDataDisk.", this.LocalDataDisk);
            this.SetParamSimple(map, prefix + "SoldOutReason", this.SoldOutReason);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "FamilyName", this.FamilyName);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "OriginPrice", this.OriginPrice);
            this.SetParamArraySimple(map, prefix + "PrepaidUnderwritePeriods.", this.PrepaidUnderwritePeriods);
            this.SetParamSimple(map, prefix + "GpuDesc", this.GpuDesc);
            this.SetParamSimple(map, prefix + "QuotaNum", this.QuotaNum);
            this.SetParamSimple(map, prefix + "QuotaUnit", this.QuotaUnit);
            this.SetParamSimple(map, prefix + "NeedHpcClusterId", this.NeedHpcClusterId);
            this.SetParamSimple(map, prefix + "IsGpuInstance", this.IsGpuInstance);
            this.SetParamSimple(map, prefix + "GpuResourceKey", this.GpuResourceKey);
            this.SetParamSimple(map, prefix + "GpuNum", this.GpuNum);
        }
    }
}

