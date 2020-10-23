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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Component : AbstractModel
    {
        
        /// <summary>
        /// Unique ID.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// CWP agent `Uuid`.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Private IP of server.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Server name.
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Component version number.
        /// </summary>
        [JsonProperty("ComponentVersion")]
        public string ComponentVersion{ get; set; }

        /// <summary>
        /// Component type.
        /// <li>SYSTEM: system component</li>
        /// <li>WEB: web component</li>
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// Component name.
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// Component detection update time.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "ComponentVersion", this.ComponentVersion);
            this.SetParamSimple(map, prefix + "ComponentType", this.ComponentType);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

