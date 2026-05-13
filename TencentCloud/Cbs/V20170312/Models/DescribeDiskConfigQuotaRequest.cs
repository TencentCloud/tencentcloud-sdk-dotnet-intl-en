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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDiskConfigQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// INQUIRY type. valid values:<br>INQUIRY_CBS_CONFIG: query the cloud disk configuration list<br>INQUIRY_CVM_CONFIG: query the configuration list of cloud disks with instances.
        /// </summary>
        [JsonProperty("InquiryType")]
        public string InquiryType{ get; set; }

        /// <summary>
        /// Billing mode. Value range: <br><li>POSTPAID_BY_HOUR: postpaid.
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// Filter by the instance model series, such as S1, I1 and M1. For more information, please see [Instance Types](https://intl.cloud.tencent.com/document/product/213/11518?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("InstanceFamilies")]
        public string[] InstanceFamilies{ get; set; }

        /// <summary>
        /// Hard disk media type. valid values: <br> CLOUD_BASIC: BASIC CLOUD disk <br> CLOUD_PREMIUM: high-performance CLOUD block storage <br> CLOUD_SSD: SSD CLOUD disk <br> CLOUD_HSSD: enhanced SSD CLOUD disk.
        /// </summary>
        [JsonProperty("DiskTypes")]
        public string[] DiskTypes{ get; set; }

        /// <summary>
        /// Query configuration under one or more [availability zone](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#ZoneInfo).
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Instance memory size in GB.
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// SYSTEM DISK or DATA DISK. valid values:<br>SYSTEM_DISK: SYSTEM DISK<br>DATA_DISK: DATA DISK.
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// Instance CPU cores.
        /// </summary>
        [JsonProperty("CPU")]
        public ulong? CPU{ get; set; }

        /// <summary>
        /// Dedicated cluster ID.
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InquiryType", this.InquiryType);
            this.SetParamSimple(map, prefix + "DiskChargeType", this.DiskChargeType);
            this.SetParamArraySimple(map, prefix + "InstanceFamilies.", this.InstanceFamilies);
            this.SetParamArraySimple(map, prefix + "DiskTypes.", this.DiskTypes);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
        }
    }
}

