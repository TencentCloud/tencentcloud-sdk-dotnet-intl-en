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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowPackageInfo : AbstractModel
    {
        
        /// <summary>
        /// Unique resource ID of the data transfer plan
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// User AppId belonging to the data transfer plan
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Traffic package specification type. Values are as follows:
        /// DEVICE_1_FLOW_20G,DEVICE_2_FLOW_50G,
        /// DEVICE_3_FLOW_100G,
        /// DEVICE_5_FLOW_500G represents traffic packages of 20G, 50G, 100G, and 500G gear selection.
        /// Gear selection also impacts the bandwidth cap of the data transfer plan.
        /// 20G: Bind up to 1 device.
        /// 50G: Bind up to 2 devices.
        /// 100G: Bind up to 3 devices.
        /// 500G: Bind up to 5 devices.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Traffic packet status. 0: Inactive, 1: Within validity period, 2: Expired.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Purchase time, Unix timestamp format, unit: second
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Effective time, Unix Timestamp Format, unit: second
        /// </summary>
        [JsonProperty("ActiveTime")]
        public long? ActiveTime{ get; set; }

        /// <summary>
        /// Expiration time, Unix Timestamp Format, unit: second
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// Device ID list bound to the data transfer plan
        /// </summary>
        [JsonProperty("DeviceList")]
        public string[] DeviceList{ get; set; }

        /// <summary>
        /// Total traffic plan capacity (unit: MB)
        /// </summary>
        [JsonProperty("CapacitySize")]
        public ulong? CapacitySize{ get; set; }

        /// <summary>
        /// Remaining data transfer plan, unit: MB
        /// </summary>
        [JsonProperty("CapacityRemain")]
        public ulong? CapacityRemain{ get; set; }

        /// <summary>
        /// Auto-renewal flag. true represents auto-renewal, false represents no auto-renewal.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public bool? RenewFlag{ get; set; }

        /// <summary>
        /// Resource package change status: 0: No change; 1: Changing; 2: Changed or renewed
        /// </summary>
        [JsonProperty("ModifyStatus")]
        public long? ModifyStatus{ get; set; }

        /// <summary>
        /// Traffic truncation flag. true to enable traffic truncation, false to disable traffic truncation.
        /// </summary>
        [JsonProperty("TruncFlag")]
        public bool? TruncFlag{ get; set; }

        /// <summary>
        /// Precise remaining data transfer plan, unit: MB
        /// </summary>
        [JsonProperty("CapacityRemainPrecise")]
        public ulong? CapacityRemainPrecise{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArraySimple(map, prefix + "DeviceList.", this.DeviceList);
            this.SetParamSimple(map, prefix + "CapacitySize", this.CapacitySize);
            this.SetParamSimple(map, prefix + "CapacityRemain", this.CapacityRemain);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ModifyStatus", this.ModifyStatus);
            this.SetParamSimple(map, prefix + "TruncFlag", this.TruncFlag);
            this.SetParamSimple(map, prefix + "CapacityRemainPrecise", this.CapacityRemainPrecise);
        }
    }
}

