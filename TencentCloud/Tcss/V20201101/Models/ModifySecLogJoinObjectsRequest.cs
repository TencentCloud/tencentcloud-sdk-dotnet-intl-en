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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySecLogJoinObjectsRequest : AbstractModel
    {
        
        /// <summary>
        /// Log type
        /// Container bash: container_bash
        /// Container startup: container_launch
        /// K8s API: k8s_api
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Bound list
        /// </summary>
        [JsonProperty("BindList")]
        public string[] BindList{ get; set; }

        /// <summary>
        /// List of assets to be unbound. When the node scope involves all nodes, this parameter indicates the list of assets to be excluded.
        /// </summary>
        [JsonProperty("UnBindList")]
        public string[] UnBindList{ get; set; }

        /// <summary>
        /// Node type.
        /// `NORMAL`: General node (default)
        /// `SUPER`: Super node
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Log node scope type. 0: specified; 1: all.
        /// </summary>
        [JsonProperty("RangeType")]
        public long? RangeType{ get; set; }

        /// <summary>
        /// Whether new assets are accessed automatically. This parameter is valid only when the node scope involves all nodes.
        /// </summary>
        [JsonProperty("AutoJoin")]
        public bool? AutoJoin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamArraySimple(map, prefix + "BindList.", this.BindList);
            this.SetParamArraySimple(map, prefix + "UnBindList.", this.UnBindList);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "RangeType", this.RangeType);
            this.SetParamSimple(map, prefix + "AutoJoin", this.AutoJoin);
        }
    }
}

