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

    public class ClusterSlaveData : AbstractModel
    {
        
        /// <summary>
        /// Old primary availability zone.
        /// </summary>
        [JsonProperty("OldMasterZone")]
        public string OldMasterZone{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OldSlaveZone")]
        public string[] OldSlaveZone{ get; set; }

        /// <summary>
        /// New primary availability zone.
        /// </summary>
        [JsonProperty("NewMasterZone")]
        public string NewMasterZone{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NewSlaveZone")]
        public string[] NewSlaveZone{ get; set; }

        /// <summary>
        /// New from availability zone attribute.
        /// </summary>
        [JsonProperty("NewSlaveZoneAttr")]
        public SlaveZoneAttrItem[] NewSlaveZoneAttr{ get; set; }

        /// <summary>
        /// Old availability zone attributes.
        /// </summary>
        [JsonProperty("OldSlaveZoneAttr")]
        public SlaveZoneAttrItem[] OldSlaveZoneAttr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OldMasterZone", this.OldMasterZone);
            this.SetParamArraySimple(map, prefix + "OldSlaveZone.", this.OldSlaveZone);
            this.SetParamSimple(map, prefix + "NewMasterZone", this.NewMasterZone);
            this.SetParamArraySimple(map, prefix + "NewSlaveZone.", this.NewSlaveZone);
            this.SetParamArrayObj(map, prefix + "NewSlaveZoneAttr.", this.NewSlaveZoneAttr);
            this.SetParamArrayObj(map, prefix + "OldSlaveZoneAttr.", this.OldSlaveZoneAttr);
        }
    }
}

