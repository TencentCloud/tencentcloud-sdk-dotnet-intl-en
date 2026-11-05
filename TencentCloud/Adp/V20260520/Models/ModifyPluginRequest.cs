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

    public class ModifyPluginRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Plugin_id</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <p>Plugin version number</p>
        /// </summary>
        [JsonProperty("PluginVersion")]
        public long? PluginVersion{ get; set; }

        /// <summary>
        /// <p>Plug-in basic information</p>
        /// </summary>
        [JsonProperty("Profile")]
        public PluginProfile Profile{ get; set; }

        /// <summary>
        /// <p>Plug-in type configuration</p>
        /// </summary>
        [JsonProperty("Config")]
        public PluginConfig Config{ get; set; }

        /// <summary>
        /// <p>Specify the fields to update to avoid full coverage</p>
        /// </summary>
        [JsonProperty("UpdateMask")]
        public FieldMask UpdateMask{ get; set; }

        /// <summary>
        /// <p>Tool list of the plug-in. This parameter is not required for mcp plug-ins.</p>
        /// </summary>
        [JsonProperty("ToolList")]
        public Tool[] ToolList{ get; set; }

        /// <summary>
        /// <p>User Main Account logged in (required in integrator mode)</p>
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// <p>User Sub-account logged in (required in integrator mode)</p>
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "PluginVersion", this.PluginVersion);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "UpdateMask.", this.UpdateMask);
            this.SetParamArrayObj(map, prefix + "ToolList.", this.ToolList);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
        }
    }
}

