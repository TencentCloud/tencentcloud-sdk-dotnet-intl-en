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

    public class InstanceUpgradePreCheckResultItem : AbstractModel
    {
        
        /// <summary>
        /// The namespace of the workload
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Workload type
        /// </summary>
        [JsonProperty("WorkLoadKind")]
        public string WorkLoadKind{ get; set; }

        /// <summary>
        /// Workload name
        /// </summary>
        [JsonProperty("WorkLoadName")]
        public string WorkLoadName{ get; set; }

        /// <summary>
        /// The number of running pods in the workload before draining the node
        /// </summary>
        [JsonProperty("Before")]
        public ulong? Before{ get; set; }

        /// <summary>
        /// The number of running pods in the workload after draining the node
        /// </summary>
        [JsonProperty("After")]
        public ulong? After{ get; set; }

        /// <summary>
        /// The pod list of the workload on this node
        /// </summary>
        [JsonProperty("Pods")]
        public string[] Pods{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "WorkLoadKind", this.WorkLoadKind);
            this.SetParamSimple(map, prefix + "WorkLoadName", this.WorkLoadName);
            this.SetParamSimple(map, prefix + "Before", this.Before);
            this.SetParamSimple(map, prefix + "After", this.After);
            this.SetParamArraySimple(map, prefix + "Pods.", this.Pods);
        }
    }
}

