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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVulDefenceSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// Defense switch: 0 - off; 1 - on
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 1 - All Ultimate edition hosts; 0 - list of hosts with Quuids
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// List of Ultimate Edition hosts within the scope
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// Exclude the list of Ultimate Edition hosts within the scope
        /// </summary>
        [JsonProperty("ExcludeInstanceIds")]
        public string[] ExcludeInstanceIds{ get; set; }

        /// <summary>
        /// New assets automatically include: 0 - Do not include, 1 - include.
        /// </summary>
        [JsonProperty("AutoInclude")]
        public ulong? AutoInclude{ get; set; }

        /// <summary>
        /// List of Ultimate Edition hosts within the scope
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIds.", this.ExcludeInstanceIds);
            this.SetParamSimple(map, prefix + "AutoInclude", this.AutoInclude);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
        }
    }
}

