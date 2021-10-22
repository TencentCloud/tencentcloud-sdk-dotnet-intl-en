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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Bundle : AbstractModel
    {
        
        /// <summary>
        /// Package ID.
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// Memory size in GB.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// System disk type.
        /// Valid values: 
        /// <li> LOCAL_BASIC: local disk</li><li> LOCAL_SSD: local SSD disk</li><li> CLOUD_BASIC: HDD cloud disk</li><li> CLOUD_SSD: SSD cloud disk</li><li> CLOUD_PREMIUM: Premium Cloud Storage</li>
        /// </summary>
        [JsonProperty("SystemDiskType")]
        public string SystemDiskType{ get; set; }

        /// <summary>
        /// System disk size.
        /// </summary>
        [JsonProperty("SystemDiskSize")]
        public long? SystemDiskSize{ get; set; }

        /// <summary>
        /// Monthly network traffic in Gb.
        /// </summary>
        [JsonProperty("MonthlyTraffic")]
        public long? MonthlyTraffic{ get; set; }

        /// <summary>
        /// Whether Linux/Unix is supported.
        /// </summary>
        [JsonProperty("SupportLinuxUnixPlatform")]
        public bool? SupportLinuxUnixPlatform{ get; set; }

        /// <summary>
        /// Whether Windows is supported.
        /// </summary>
        [JsonProperty("SupportWindowsPlatform")]
        public bool? SupportWindowsPlatform{ get; set; }

        /// <summary>
        /// Current package unit price information.
        /// </summary>
        [JsonProperty("Price")]
        public Price Price{ get; set; }

        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// Peak bandwidth in Mbps.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Network billing mode.
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// Package sale status. Valid values: AVAILABLE, SOLD_OUT
        /// </summary>
        [JsonProperty("BundleSalesState")]
        public string BundleSalesState{ get; set; }

        /// <summary>
        /// Package type.
        /// Valid values:
        /// <li> GENERAL_BUNDLE: general</li><li> STORAGE_BUNDLE: Storage</li>
        /// </summary>
        [JsonProperty("BundleType")]
        public string BundleType{ get; set; }

        /// <summary>
        /// Package tag.
        /// Valid values:
        /// "ACTIVITY": promotional package
        /// "NORMAL": regular package
        /// "CAREFREE": carefree package
        /// </summary>
        [JsonProperty("BundleDisplayLabel")]
        public string BundleDisplayLabel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "SystemDiskType", this.SystemDiskType);
            this.SetParamSimple(map, prefix + "SystemDiskSize", this.SystemDiskSize);
            this.SetParamSimple(map, prefix + "MonthlyTraffic", this.MonthlyTraffic);
            this.SetParamSimple(map, prefix + "SupportLinuxUnixPlatform", this.SupportLinuxUnixPlatform);
            this.SetParamSimple(map, prefix + "SupportWindowsPlatform", this.SupportWindowsPlatform);
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "BundleSalesState", this.BundleSalesState);
            this.SetParamSimple(map, prefix + "BundleType", this.BundleType);
            this.SetParamSimple(map, prefix + "BundleDisplayLabel", this.BundleDisplayLabel);
        }
    }
}
