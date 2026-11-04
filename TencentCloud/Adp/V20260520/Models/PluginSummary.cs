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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>Plug-in configuration message.</p>
        /// </summary>
        [JsonProperty("Config")]
        public PluginConfig Config{ get; set; }

        /// <summary>
        /// <p>Whether shared is configured</p>
        /// </summary>
        [JsonProperty("IsShared")]
        public bool? IsShared{ get; set; }

        /// <summary>
        /// <p>Plugin operation management information.</p>
        /// </summary>
        [JsonProperty("Operation")]
        public PluginOperation Operation{ get; set; }

        /// <summary>
        /// <p>plugin_id</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <p>Basic information of the plug-in.</p>
        /// </summary>
        [JsonProperty("Profile")]
        public PluginProfile Profile{ get; set; }

        /// <summary>
        /// <p>Space ID that the plug-in belongs to; empty for built-in plugins</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>Plugin statistical information.</p>
        /// </summary>
        [JsonProperty("Statistics")]
        public PluginStatistics Statistics{ get; set; }

        /// <summary>
        /// <p>Plug-in status. 1: available, 2: unavailable </p><p>Enumeration values:</p><ul><li>1: available</li><li>2: unavailable</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Tool information</p>
        /// </summary>
        [JsonProperty("ToolList")]
        public ToolSummary[] ToolList{ get; set; }

        /// <summary>
        /// <p>Plugin status information by user dimension</p>
        /// </summary>
        [JsonProperty("UserState")]
        public PluginUserState UserState{ get; set; }

        /// <summary>
        /// <p>Update time, Unix timestamp</p><p>Unit: seconds</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "IsShared", this.IsShared);
            this.SetParamObj(map, prefix + "Operation.", this.Operation);
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamObj(map, prefix + "Statistics.", this.Statistics);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "ToolList.", this.ToolList);
            this.SetParamObj(map, prefix + "UserState.", this.UserState);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

