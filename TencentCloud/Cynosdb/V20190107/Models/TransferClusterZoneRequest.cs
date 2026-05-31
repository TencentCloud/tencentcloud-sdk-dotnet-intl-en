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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransferClusterZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// Source Cluster Id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Target availability zone
        /// </summary>
        [JsonProperty("DstZone")]
        public string DstZone{ get; set; }

        /// <summary>
        /// Cross-AZ migration master-slave data delay verification threshold, milliseconds (ms)
        /// </summary>
        [JsonProperty("MaxLag")]
        public long? MaxLag{ get; set; }

        /// <summary>
        /// Immediate: Immediate execution, InMaintain: Time window execution
        /// </summary>
        [JsonProperty("TransferType")]
        public string TransferType{ get; set; }

        /// <summary>
        /// Multi-availability zone backup zone
        /// </summary>
        [JsonProperty("DstSlaveZone")]
        public string DstSlaveZone{ get; set; }

        /// <summary>
        /// Target zone info for proxy migration
        /// </summary>
        [JsonProperty("ProxyZones")]
        public ProxyZone[] ProxyZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DstZone", this.DstZone);
            this.SetParamSimple(map, prefix + "MaxLag", this.MaxLag);
            this.SetParamSimple(map, prefix + "TransferType", this.TransferType);
            this.SetParamSimple(map, prefix + "DstSlaveZone", this.DstSlaveZone);
            this.SetParamArrayObj(map, prefix + "ProxyZones.", this.ProxyZones);
        }
    }
}

