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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReadOnlyGroup : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReadOnlyGroupName")]
        public string ReadOnlyGroupName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsOfflineDelay")]
        public long? IsOfflineDelay{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReadOnlyMaxDelayTime")]
        public long? ReadOnlyMaxDelayTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MinReadOnlyInGroup")]
        public long? MinReadOnlyInGroup{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MasterInstanceId")]
        public string MasterInstanceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReadOnlyInstanceSet")]
        public ReadOnlyInstance[] ReadOnlyInstanceSet{ get; set; }

        /// <summary>
        /// RO group's public network address domain name
        /// </summary>
        [JsonProperty("DnsPodDomain")]
        public string DnsPodDomain{ get; set; }

        /// <summary>
        /// RO group's public network address port
        /// </summary>
        [JsonProperty("TgwWanVPort")]
        public ulong? TgwWanVPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupName", this.ReadOnlyGroupName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "IsOfflineDelay", this.IsOfflineDelay);
            this.SetParamSimple(map, prefix + "ReadOnlyMaxDelayTime", this.ReadOnlyMaxDelayTime);
            this.SetParamSimple(map, prefix + "MinReadOnlyInGroup", this.MinReadOnlyInGroup);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MasterInstanceId", this.MasterInstanceId);
            this.SetParamArrayObj(map, prefix + "ReadOnlyInstanceSet.", this.ReadOnlyInstanceSet);
            this.SetParamSimple(map, prefix + "DnsPodDomain", this.DnsPodDomain);
            this.SetParamSimple(map, prefix + "TgwWanVPort", this.TgwWanVPort);
        }
    }
}

