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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceNewRequest : AbstractModel
    {
        
        /// <summary>
        /// Availability zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// FE specifications
        /// </summary>
        [JsonProperty("FeSpec")]
        public CreateInstanceSpec FeSpec{ get; set; }

        /// <summary>
        /// BE specifications.
        /// </summary>
        [JsonProperty("BeSpec")]
        public CreateInstanceSpec BeSpec{ get; set; }

        /// <summary>
        /// Whether it is highly available.
        /// </summary>
        [JsonProperty("HaFlag")]
        public bool? HaFlag{ get; set; }

        /// <summary>
        /// User VPCID
        /// </summary>
        [JsonProperty("UserVPCId")]
        public string UserVPCId{ get; set; }

        /// <summary>
        /// User subnet ID
        /// </summary>
        [JsonProperty("UserSubnetId")]
        public string UserSubnetId{ get; set; }

        /// <summary>
        /// Product version number
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// Payment type
        /// </summary>
        [JsonProperty("ChargeProperties")]
        public ChargeProperties ChargeProperties{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Database password
        /// </summary>
        [JsonProperty("DorisUserPwd")]
        public string DorisUserPwd{ get; set; }

        /// <summary>
        /// Tag list
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// High availability type:
        /// 0 indicates non-high availability (only one FE, FeSpec.CreateInstanceSpec.Count=1),
        /// 1 indicates read high availability (at least 3 FEs must be deployed, FeSpec.CreateInstanceSpec.Count>=3, and it must be an odd number),
        /// 2 indicates read and write high availability (at least 5 FEs must be deployed, FeSpec.CreateInstanceSpec.Count>=5, and it must be an odd number).
        /// </summary>
        [JsonProperty("HaType")]
        public long? HaType{ get; set; }

        /// <summary>
        /// Whether the table name is case sensitive, 0 refers to sensitive, 1 refers to insensitive, compared in lowercase; 2 refers to insensitive, and the table name is changed to lowercase for storage.
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public long? CaseSensitive{ get; set; }

        /// <summary>
        /// Whether to enable multi-availability zone.
        /// </summary>
        [JsonProperty("EnableMultiZones")]
        public bool? EnableMultiZones{ get; set; }

        /// <summary>
        /// After the Multi-AZ is enabled, all user's Availability Zones and Subnets information are shown.
        /// </summary>
        [JsonProperty("UserMultiZoneInfos")]
        public NetworkInfo UserMultiZoneInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamObj(map, prefix + "FeSpec.", this.FeSpec);
            this.SetParamObj(map, prefix + "BeSpec.", this.BeSpec);
            this.SetParamSimple(map, prefix + "HaFlag", this.HaFlag);
            this.SetParamSimple(map, prefix + "UserVPCId", this.UserVPCId);
            this.SetParamSimple(map, prefix + "UserSubnetId", this.UserSubnetId);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamObj(map, prefix + "ChargeProperties.", this.ChargeProperties);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "DorisUserPwd", this.DorisUserPwd);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HaType", this.HaType);
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
            this.SetParamSimple(map, prefix + "EnableMultiZones", this.EnableMultiZones);
            this.SetParamObj(map, prefix + "UserMultiZoneInfos.", this.UserMultiZoneInfos);
        }
    }
}

