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

    public class Plugin : AbstractModel
    {
        
        /// <summary>
        /// Plug-in configuration
        /// </summary>
        [JsonProperty("Config")]
        public PluginConfig Config{ get; set; }

        /// <summary>
        /// Creation time, Unix Timestamp
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Plug-in operation management information
        /// </summary>
        [JsonProperty("Operation")]
        public PluginOperation Operation{ get; set; }

        /// <summary>
        /// Plugin ID
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// Plugin version number
        /// </summary>
        [JsonProperty("PluginVersion")]
        public long? PluginVersion{ get; set; }

        /// <summary>
        /// Basic plug-in information.
        /// </summary>
        [JsonProperty("Profile")]
        public PluginProfile Profile{ get; set; }

        /// <summary>
        /// Plug-in statistical information
        /// </summary>
        [JsonProperty("Statistics")]
        public PluginStatistics Statistics{ get; set; }

        /// <summary>
        /// <p>Plug-in status. 1: available, 2: unavailable </p><p>Enumeration values:</p><ul><li>1: available</li><li>2: unavailable</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Tool list
        /// </summary>
        [JsonProperty("ToolList")]
        public Tool[] ToolList{ get; set; }

        /// <summary>
        /// Update time, Unix timestamp
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Plugin status information by user dimension
        /// </summary>
        [JsonProperty("UserState")]
        public PluginUserState UserState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "Operation.", this.Operation);
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "PluginVersion", this.PluginVersion);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamObj(map, prefix + "Statistics.", this.Statistics);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "ToolList.", this.ToolList);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamObj(map, prefix + "UserState.", this.UserState);
        }
    }
}

