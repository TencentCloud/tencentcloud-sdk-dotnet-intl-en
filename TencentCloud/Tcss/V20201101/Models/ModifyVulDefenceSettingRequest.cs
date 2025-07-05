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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVulDefenceSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether it is enabled. Valid values: `0` (disabled); `1` (enabled).
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// Servers to enable exploit prevention. Values: `0` (custom); `1` (all).
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// Specified servers with exploit prevention enabled
        /// </summary>
        [JsonProperty("HostIDs")]
        public string[] HostIDs{ get; set; }

        /// <summary>
        /// Super nodes to enable exploit prevention. Values: `0` (custom); `1` (all).
        /// </summary>
        [JsonProperty("SuperScope")]
        public long? SuperScope{ get; set; }

        /// <summary>
        /// List of super node IDs
        /// </summary>
        [JsonProperty("NodeIds")]
        public string[] NodeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "HostIDs.", this.HostIDs);
            this.SetParamSimple(map, prefix + "SuperScope", this.SuperScope);
            this.SetParamArraySimple(map, prefix + "NodeIds.", this.NodeIds);
        }
    }
}

