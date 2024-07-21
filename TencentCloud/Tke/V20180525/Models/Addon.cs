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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Addon : AbstractModel
    {
        
        /// <summary>
        /// Add-on name
        /// </summary>
        [JsonProperty("AddonName")]
        public string AddonName{ get; set; }

        /// <summary>
        /// Add-on version
        /// </summary>
        [JsonProperty("AddonVersion")]
        public string AddonVersion{ get; set; }

        /// <summary>
        /// Add-on parameters, which are base64-encoded strings in JSON/
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RawValues")]
        public string RawValues{ get; set; }

        /// <summary>
        /// Add-on status
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Phase")]
        public string Phase{ get; set; }

        /// <summary>
        /// Reason for add-on failure
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddonName", this.AddonName);
            this.SetParamSimple(map, prefix + "AddonVersion", this.AddonVersion);
            this.SetParamSimple(map, prefix + "RawValues", this.RawValues);
            this.SetParamSimple(map, prefix + "Phase", this.Phase);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

