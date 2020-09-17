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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessPoint : AbstractModel
    {
        
        /// <summary>
        /// Access point name.
        /// </summary>
        [JsonProperty("AccessPointName")]
        public string AccessPointName{ get; set; }

        /// <summary>
        /// Unique ID of access point.
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// Access point status. Valid values: available, unavailable.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Access point location.
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Supported ISP list of access pint.
        /// </summary>
        [JsonProperty("LineOperator")]
        public string[] LineOperator{ get; set; }

        /// <summary>
        /// Region ID where the access point resides.
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Available port type at the access point. Valid values: 1000BASE-T: gigabit electrical port; 1000BASE-LX: 10 km gigabit single-mode optical port; 1000BASE-ZX: 80 km gigabit single-mode optical port; 10GBASE-LR: 10 km 10-gigabit single-mode optical port; 10GBASE-ZR: 80 km 10-gigabit single-mode optical port; 10GBASE-LH: 40 km 10-gigabit single-mode optical port; 100GBASE-LR4: 10 km 100-gigabit single-mode optical portfiber optic port.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AvailablePortType")]
        public string[] AvailablePortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessPointName", this.AccessPointName);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamArraySimple(map, prefix + "LineOperator.", this.LineOperator);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamArraySimple(map, prefix + "AvailablePortType.", this.AvailablePortType);
        }
    }
}

