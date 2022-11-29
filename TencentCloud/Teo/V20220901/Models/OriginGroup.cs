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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginGroup : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// The ID of the origin group.
        /// </summary>
        [JsonProperty("OriginGroupId")]
        public string OriginGroupId{ get; set; }

        /// <summary>
        /// The origin type. Values:
        /// <li>`self`: Customer origin</li>
        /// <li>`third_party`: Third-party origin</li>
        /// <li>`cos`: Tencent Cloud COS origin</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// The name of the origin group.
        /// </summary>
        [JsonProperty("OriginGroupName")]
        public string OriginGroupName{ get; set; }

        /// <summary>
        /// The origin configuration type when `OriginType=self`. Values:
        /// <li>`area`: Configure by region.</li>
        /// <li>`weight`: Configure by weight.</li>
        /// <li>`proto`: Configure by HTTP protocol.</li>When `OriginType=third_party/cos`, leave this field empty.
        /// </summary>
        [JsonProperty("ConfigurationType")]
        public string ConfigurationType{ get; set; }

        /// <summary>
        /// The origin record information.
        /// </summary>
        [JsonProperty("OriginRecords")]
        public OriginRecord[] OriginRecords{ get; set; }

        /// <summary>
        /// The update time of the origin group.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The origin domain when `OriginType=self`.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "OriginGroupId", this.OriginGroupId);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "OriginGroupName", this.OriginGroupName);
            this.SetParamSimple(map, prefix + "ConfigurationType", this.ConfigurationType);
            this.SetParamArrayObj(map, prefix + "OriginRecords.", this.OriginRecords);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
        }
    }
}

