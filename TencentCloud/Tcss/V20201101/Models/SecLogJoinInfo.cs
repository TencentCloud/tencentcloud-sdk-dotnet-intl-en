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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecLogJoinInfo : AbstractModel
    {
        
        /// <summary>
        /// Number of accessed servers
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Whether it is accessed. Valid values: `true` (accessed); `false` (not accessed).
        /// </summary>
        [JsonProperty("IsJoined")]
        public bool? IsJoined{ get; set; }

        /// <summary>
        /// Log type (
        /// Container bash: "container_bash"
        /// Container startup: "container_launch"
        /// K8s API: "k8s_api"
        /// )
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "IsJoined", this.IsJoined);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
        }
    }
}

