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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetAttackSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>0: disable network attack detection; 1: enable network attack detection</p>
        /// </summary>
        [JsonProperty("NetAttackEnable")]
        public ulong? NetAttackEnable{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>0: new warning events pending processing by default; 1: new warning events processed by default; 3: new warning events ignored by default</p>
        /// </summary>
        [JsonProperty("NetAttackAlarmStatus")]
        public ulong? NetAttackAlarmStatus{ get; set; }

        /// <summary>
        /// <p>Automatic inclusion of new assets: 0 means not included, and 1 means included</p>
        /// </summary>
        [JsonProperty("AutoInclude")]
        public ulong? AutoInclude{ get; set; }

        /// <summary>
        /// <p>Host range: 0 - specify 1 - all 2 - Pro Edition 3 - Flagship Edition 4 - Pro + Flagship</p>
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// <p>Specify the host list (used when CWPScope=0)</p>
        /// </summary>
        [JsonProperty("InstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] InstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Host exclusion list</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] ExcludeInstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Tag ID list</p>
        /// </summary>
        [JsonProperty("TagIDs")]
        public string[] TagIDs{ get; set; }

        /// <summary>
        /// <p>Container scope: 0-within specified clusters 1-all clusters</p>
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// <p>Specify the cluster list (used when TCSSScope=0)</p>
        /// </summary>
        [JsonProperty("ClusterIDsWithAppId")]
        public ClusterIDWithAppIdItem[] ClusterIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>Cluster exclusion list</p>
        /// </summary>
        [JsonProperty("ExcludeClusterIDsWithAppId")]
        public ClusterIDWithAppIdItem[] ExcludeClusterIDsWithAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetAttackEnable", this.NetAttackEnable);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "NetAttackAlarmStatus", this.NetAttackAlarmStatus);
            this.SetParamSimple(map, prefix + "AutoInclude", this.AutoInclude);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamArrayObj(map, prefix + "InstanceIDsWithAppId.", this.InstanceIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeInstanceIDsWithAppId.", this.ExcludeInstanceIDsWithAppId);
            this.SetParamArraySimple(map, prefix + "TagIDs.", this.TagIDs);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamArrayObj(map, prefix + "ClusterIDsWithAppId.", this.ClusterIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeClusterIDsWithAppId.", this.ExcludeClusterIDsWithAppId);
        }
    }
}

