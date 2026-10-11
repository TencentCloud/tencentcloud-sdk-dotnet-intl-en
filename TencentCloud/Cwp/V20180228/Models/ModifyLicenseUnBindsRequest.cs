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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLicenseUnBindsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Resource ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>Authorization type</p><p>Enumeration values:</p><ul><li>1: Pro Edition - monthly subscription</li><li>2: Ultimate Edition - monthly subscription</li></ul>
        /// </summary>
        [JsonProperty("LicenseType")]
        public ulong? LicenseType{ get; set; }

        /// <summary>
        /// <p>Whether all machines (when the number of all machines exceeds the available licenses in the current order, extra machines will be skipped)</p>
        /// </summary>
        [JsonProperty("IsAll")]
        public bool? IsAll{ get; set; }

        /// <summary>
        /// <p>List of QUUIDs of machines to be bound. Required when IsAll = false; otherwise, ignore the parameter.<br>Maximum length: 100</p>
        /// </summary>
        [JsonProperty("QuuidList")]
        public string[] QuuidList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "IsAll", this.IsAll);
            this.SetParamArraySimple(map, prefix + "QuuidList.", this.QuuidList);
        }
    }
}

