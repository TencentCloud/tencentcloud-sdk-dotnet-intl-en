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

    public class ModifyNetAttackSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 0 - Disable Network Attack Detection; 1 - Enable Network Attack Detection.
        /// </summary>
        [JsonProperty("NetAttackEnable")]
        public ulong? NetAttackEnable{ get; set; }

        /// <summary>
        /// 0: New warning events pending processing by default, 1: New warning events processed by default, 3: New warning events ignored by default.
        /// </summary>
        [JsonProperty("NetAttackAlarmStatus")]
        public ulong? NetAttackAlarmStatus{ get; set; }

        /// <summary>
        /// 1 - All Ultimate edition hosts; 0 - list of hosts with Quuids
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// Specified hosts
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Manually Excluded Hosts
        /// </summary>
        [JsonProperty("ExcludeInstanceIds")]
        public string[] ExcludeInstanceIds{ get; set; }

        /// <summary>
        /// New assets automatically include: 0 - Do not include, 1 - include.
        /// </summary>
        [JsonProperty("AutoInclude")]
        public ulong? AutoInclude{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetAttackEnable", this.NetAttackEnable);
            this.SetParamSimple(map, prefix + "NetAttackAlarmStatus", this.NetAttackAlarmStatus);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIds.", this.ExcludeInstanceIds);
            this.SetParamSimple(map, prefix + "AutoInclude", this.AutoInclude);
        }
    }
}

