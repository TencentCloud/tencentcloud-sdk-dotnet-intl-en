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

    public class PortRiskAdvanceCFGParamItem : AbstractModel
    {
        
        /// <summary>
        /// Port Collection, separated by commas.
        /// </summary>
        [JsonProperty("PortSets")]
        public string PortSets{ get; set; }

        /// <summary>
        /// Detection Item Type. 0-System-Defined; 1-User-Defined.
        /// </summary>
        [JsonProperty("CheckType")]
        public long? CheckType{ get; set; }

        /// <summary>
        /// Detection item description
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// Enable/Disable. 1-Enable; 0-Disable.
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PortSets", this.PortSets);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

