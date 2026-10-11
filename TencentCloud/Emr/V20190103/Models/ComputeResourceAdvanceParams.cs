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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComputeResourceAdvanceParams : AbstractModel
    {
        
        /// <summary>
        /// <p>Node Label array.</p>
        /// </summary>
        [JsonProperty("Labels")]
        public TkeLabel[] Labels{ get; set; }

        /// <summary>
        /// <p>Node taint.</p>
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// <p>Base64-encoded user script, which is executed before node initialization.</p>
        /// </summary>
        [JsonProperty("PreStartUserScript")]
        public string PreStartUserScript{ get; set; }

        /// <summary>
        /// <p>Base64-encoded user script, which is executed after the Kubernetes component starts. You need to guarantee the script reentrancy and retry logic. The script and generated log files can be viewed in the /data/ccs_userscript/ directory on the node.</p>
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }

        /// <summary>
        /// <p>Node group ID.</p>
        /// </summary>
        [JsonProperty("TkeClusterNodePool")]
        public string TkeClusterNodePool{ get; set; }

        /// <summary>
        /// <p>Mode of joining a node pool.</p><p>Enumeration values:</p><ul><li>Inherit: inherits the configuration from the node pool.</li><li>OnlyJoin: joins the node pool only without inheriting the configuration.</li></ul><p>Default value: Inherit.</p>
        /// </summary>
        [JsonProperty("NodePoolJoinMode")]
        public string NodePoolJoinMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamSimple(map, prefix + "PreStartUserScript", this.PreStartUserScript);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
            this.SetParamSimple(map, prefix + "TkeClusterNodePool", this.TkeClusterNodePool);
            this.SetParamSimple(map, prefix + "NodePoolJoinMode", this.NodePoolJoinMode);
        }
    }
}

