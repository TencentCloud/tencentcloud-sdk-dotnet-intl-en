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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBPriceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance duration, in months, minimum value 1, maximum value 36. This field is invalid when querying the pay-as-you-go rate.</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>AZ information, in the format of "ap-guangzhou-2". For available values, query the <a href="https://www.tencentcloud.com/document/api/236/17229?from_cn_redirect=1">DescribeDBZoneConfig</a> api. This parameter is required when InstanceId is empty.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>Instance count. Default value is 1, minimum value 1, maximum value 100. This parameter is required when InstanceId is empty.</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// <p>Instance memory size, measurement unit: MB. Required when InstanceId is empty. To ensure the input value is valid, please use the <a href="https://www.tencentcloud.com/document/product/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API to obtain the saleable instance memory size range.</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Instance disk size, unit: GB. This parameter is required when InstanceId is empty. To ensure the input value is valid, please use the <a href="https://www.tencentcloud.com/document/product/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API to get the saleable disk size range.</p>
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// <p>Instance type, defaults to master. Supported values include: master - primary instance, ro - read-only instance, dr - disaster recovery instance. Required when InstanceId is empty.</p>
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// <p>Payment type. Supported values: PRE_PAID (yearly/monthly subscription) and HOUR_PAID (pay-as-you-go). This parameter is required when InstanceId is empty.</p>
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// <p>Data replication method, defaults to 0. Supported values include: 0 - means async replication, 1 - means semi-sync replication, 2 - means strong sync replication.</p>
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// <p>Instance isolation type.</p><p>Enumeration value:</p><ul><li>UNIVERSAL: General-purpose instance</li><li>EXCLUSIVE: Dedicated instance</li><li>CLOUD_NATIVE_CLUSTER: Standard type of cloud disk edition</li><li>CLOUD_NATIVE_CLUSTER_EXCLUSIVE: Enhanced type of cloud disk edition</li><li>CLOUD_NATIVE_CLUSTER_ULTRA: Flagship type of cloud disk edition</li></ul><p>Default value: UNIVERSAL</p><p>If needed to query the price of a single-node instance of cloud disk edition, set up this parameter as CLOUD_NATIVE_CLUSTER and specify parameter InstanceNodes as 1.</p>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>Number of instance nodes.<br>1. When querying the price of a read-only instance or a single-node instance, the value of this field is 1.<br>2. When querying the price of a dual-node instance, the value of this field is 2.<br>3. When querying the price of a three-node instance, the value of this field is 3.<br>4. When querying the price of a cloud disk edition instance, the value range of this field can be 2 - 6. A value of 2 means the cloud disk edition instance has 1 read-write node + 1 read-only node. A value of 6 means the cloud disk edition instance has 1 read-write node + 5 read-only nodes. For other values (3 - 5), the rule is 1 read-write node + (value - 1) read-only nodes.</p>
        /// </summary>
        [JsonProperty("InstanceNodes")]
        public long? InstanceNodes{ get; set; }

        /// <summary>
        /// <p>The number of CPU cores of the price-query instance, measurement unit: core. To ensure the validity of the input CPU value, please use the <a href="https://www.tencentcloud.com/document/product/236/17229?from_cn_redirect=1">obtain the purchasable specifications of cloud databases</a> API acquisition to get the saleable number of cores. When this value is not specified, a default value will be padded based on the Memory size.</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Query the ID of the instance to be renewed. If needed, fill in InstanceId and Period to query instance renewal price.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Usage-based billing tier. Valid only when PayType=HOUR_PAID. Supported values include: 1, 2, 3. For step duration, see https://www.tencentcloud.com/document/product/236/18335.?from_cn_redirect=1</p>
        /// </summary>
        [JsonProperty("Ladder")]
        public ulong? Ladder{ get; set; }

        /// <summary>
        /// <p>Disk Type. Specify this parameter when querying the price of CLOUD disk edition or single-node instance of CLOUD disk edition. Default value: SSD CLOUD Block Storage.<br>Supported values include:<br>"CLOUD_SSD" - SSD CLOUD Block Storage.<br>"CLOUD_HSSD" - Enhanced SSD CLOUD Disk.<br>"CLOUD_PREMIUM" - High-performance CLOUD Block Storage.</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "InstanceNodes", this.InstanceNodes);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Ladder", this.Ladder);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
        }
    }
}

