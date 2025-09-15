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
        /// Node label array.
        /// </summary>
        [JsonProperty("Labels")]
        public TkeLabel[] Labels{ get; set; }

        /// <summary>
        /// Node taint.
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// Base64-encoded user script: executed before node initializing.
        /// </summary>
        [JsonProperty("PreStartUserScript")]
        public string PreStartUserScript{ get; set; }

        /// <summary>
        /// Base64-encoded user script. This script executes after Kubernetes components initialize. Users should ensure script reentrancy and implement retry logic. Both the script and its generated log files are accessible at the node path: /data/ccs_userscript/.
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamSimple(map, prefix + "PreStartUserScript", this.PreStartUserScript);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
        }
    }
}

