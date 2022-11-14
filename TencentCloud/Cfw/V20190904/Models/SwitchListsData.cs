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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SwitchListsData : AbstractModel
    {
        
        /// <summary>
        /// Public IP
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Private IP
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IntranetIp")]
        public string IntranetIp{ get; set; }

        /// <summary>
        /// Instance name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance ID
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Asset type
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Region
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Firewall toggle
        /// </summary>
        [JsonProperty("Switch")]
        public long? Switch{ get; set; }

        /// <summary>
        /// ID value
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Public IP type
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PublicIpType")]
        public ulong? PublicIpType{ get; set; }

        /// <summary>
        /// Number of risky ports
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PortTimes")]
        public ulong? PortTimes{ get; set; }

        /// <summary>
        /// Last scan time
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// Scan mode
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ScanMode")]
        public string ScanMode{ get; set; }

        /// <summary>
        /// Scan status
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ScanStatus")]
        public ulong? ScanStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "IntranetIp", this.IntranetIp);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PublicIpType", this.PublicIpType);
            this.SetParamSimple(map, prefix + "PortTimes", this.PortTimes);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "ScanMode", this.ScanMode);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
        }
    }
}

