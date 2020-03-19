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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterAdvancedSettings : AbstractModel
    {
        
        /// <summary>
        /// Whether IPVS is enabled
        /// </summary>
        [JsonProperty("IPVS")]
        public bool? IPVS{ get; set; }

        /// <summary>
        /// Whether auto-scaling is enabled for nodes in the cluster (Enabling this function is not supported when you create a cluster)
        /// </summary>
        [JsonProperty("AsEnabled")]
        public bool? AsEnabled{ get; set; }

        /// <summary>
        /// Type of runtime component used by the cluster. The types include "docker" and "containerd". Default value: docker
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NodeNameType")]
        public string NodeNameType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPVS", this.IPVS);
            this.SetParamSimple(map, prefix + "AsEnabled", this.AsEnabled);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "NodeNameType", this.NodeNameType);
        }
    }
}

