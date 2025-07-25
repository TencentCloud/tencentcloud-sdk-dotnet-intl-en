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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestartClusterForNodeRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID, such as cdwch-xxxx
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Configuration file's name
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// Each batch of restarts
        /// </summary>
        [JsonProperty("BatchSize")]
        public long? BatchSize{ get; set; }

        /// <summary>
        /// Restart node
        /// </summary>
        [JsonProperty("NodeList")]
        public string[] NodeList{ get; set; }

        /// <summary>
        /// False means non-rolling restart, and true means rolling restart.
        /// </summary>
        [JsonProperty("RollingRestart")]
        public bool? RollingRestart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "BatchSize", this.BatchSize);
            this.SetParamArraySimple(map, prefix + "NodeList.", this.NodeList);
            this.SetParamSimple(map, prefix + "RollingRestart", this.RollingRestart);
        }
    }
}

