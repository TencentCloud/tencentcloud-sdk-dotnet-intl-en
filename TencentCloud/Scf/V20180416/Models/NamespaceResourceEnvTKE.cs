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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NamespaceResourceEnvTKE : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubnetID")]
        public string SubnetID{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DataPath")]
        public string DataPath{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NodeSelector")]
        public K8SLabel[] NodeSelector{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Tolerations")]
        public K8SToleration[] Tolerations{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PodTemplatePatch")]
        public string PodTemplatePatch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "SubnetID", this.SubnetID);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "DataPath", this.DataPath);
            this.SetParamArrayObj(map, prefix + "NodeSelector.", this.NodeSelector);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "PodTemplatePatch", this.PodTemplatePatch);
        }
    }
}

