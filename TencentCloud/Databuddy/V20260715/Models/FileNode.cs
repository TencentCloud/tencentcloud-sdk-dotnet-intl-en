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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileNode : AbstractModel
    {
        
        /// <summary>
        /// <p>Current node</p>
        /// </summary>
        [JsonProperty("Node")]
        public FileMeta Node{ get; set; }

        /// <summary>
        /// <p>Parent node</p>
        /// </summary>
        [JsonProperty("Parent")]
        public FileMeta Parent{ get; set; }

        /// <summary>
        /// <p>Creator</p>
        /// </summary>
        [JsonProperty("Creator")]
        public UserInfo Creator{ get; set; }

        /// <summary>
        /// <p>Owner</p>
        /// </summary>
        [JsonProperty("Owner")]
        public UserInfo Owner{ get; set; }

        /// <summary>
        /// <p>Node type.</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Original path</p>
        /// </summary>
        [JsonProperty("OriginPath")]
        public string OriginPath{ get; set; }

        /// <summary>
        /// <p>Recycle time</p>
        /// </summary>
        [JsonProperty("DeleteTime")]
        public string DeleteTime{ get; set; }

        /// <summary>
        /// <p>File git configuration.</p>
        /// </summary>
        [JsonProperty("GitConfig")]
        public GitRepoConfig GitConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Node.", this.Node);
            this.SetParamObj(map, prefix + "Parent.", this.Parent);
            this.SetParamObj(map, prefix + "Creator.", this.Creator);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "OriginPath", this.OriginPath);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamObj(map, prefix + "GitConfig.", this.GitConfig);
        }
    }
}

