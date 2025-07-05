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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTKEEdgeScriptRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Network Card Name, specifies the network card used by the kubelet on edge nodes to register with the apiserver.
        /// </summary>
        [JsonProperty("Interface")]
        public string Interface{ get; set; }

        /// <summary>
        /// Name of the name
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Node configuration in JSON format 
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// A legacy version of edgectl script can be downloaded. The latest version is downloaded by default. The version information can be checked in the script.
        /// </summary>
        [JsonProperty("ScriptVersion")]
        public string ScriptVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Interface", this.Interface);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "ScriptVersion", this.ScriptVersion);
        }
    }
}

