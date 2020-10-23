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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceTypeQuotaItem : AbstractModel
    {
        
        /// <summary>
        /// Availability zone.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Instance model.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance billing plan. Valid values: <br><li>POSTPAID_BY_HOUR: pay after use. You are billed for your traffic by the hour.<br><li>`CDHPAID`: [`CDH`](https://intl.cloud.tencent.com/document/product/416?from_cn_redirect=1) billing plan. Applicable to `CDH` only, not the instances on the host.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// ENI type. For example, 25 represents an ENI of 25 GB.
        /// </summary>
        [JsonProperty("NetworkCard")]
        public long? NetworkCard{ get; set; }

        /// <summary>
        /// Additional data.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Externals")]
        public Externals Externals{ get; set; }

        /// <summary>
        /// Number of CPU cores of an instance model.
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Instance memory capacity; unit: `GB`.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance model family.
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// Model name.
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// List of local disk specifications. If the parameter returns null, it means that local disks cannot be created.
        /// </summary>
        [JsonProperty("LocalDiskTypeList")]
        public LocalDiskType[] LocalDiskTypeList{ get; set; }

        /// <summary>
        /// Whether an instance model is available. Valid values: <br><li>SELL: available <br><li>SOLD_OUT: sold out
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Price of an instance model.
        /// </summary>
        [JsonProperty("Price")]
        public ItemPrice Price{ get; set; }

        /// <summary>
        /// Details of out-of-stock items
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("SoldOutReason")]
        public string SoldOutReason{ get; set; }

        /// <summary>
        /// Private network bandwidth, in Gbps.
        /// </summary>
        [JsonProperty("InstanceBandwidth")]
        public float? InstanceBandwidth{ get; set; }

        /// <summary>
        /// The max packet sending and receiving capability (in 10k PPS).
        /// </summary>
        [JsonProperty("InstancePps")]
        public long? InstancePps{ get; set; }

        /// <summary>
        /// Number of local storage blocks.
        /// </summary>
        [JsonProperty("StorageBlockAmount")]
        public long? StorageBlockAmount{ get; set; }

        /// <summary>
        /// CPU type.
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// Number of GPUs of the instance.
        /// </summary>
        [JsonProperty("Gpu")]
        public long? Gpu{ get; set; }

        /// <summary>
        /// Number of FPGAs of the instance.
        /// </summary>
        [JsonProperty("Fpga")]
        public long? Fpga{ get; set; }

        /// <summary>
        /// Descriptive information of the instance.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "NetworkCard", this.NetworkCard);
            this.SetParamObj(map, prefix + "Externals.", this.Externals);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamArrayObj(map, prefix + "LocalDiskTypeList.", this.LocalDiskTypeList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamSimple(map, prefix + "SoldOutReason", this.SoldOutReason);
            this.SetParamSimple(map, prefix + "InstanceBandwidth", this.InstanceBandwidth);
            this.SetParamSimple(map, prefix + "InstancePps", this.InstancePps);
            this.SetParamSimple(map, prefix + "StorageBlockAmount", this.StorageBlockAmount);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "Fpga", this.Fpga);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

