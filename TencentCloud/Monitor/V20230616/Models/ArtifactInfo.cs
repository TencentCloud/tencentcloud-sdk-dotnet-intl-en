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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ArtifactInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Product ID</p>
        /// </summary>
        [JsonProperty("ArtifactId")]
        public string ArtifactId{ get; set; }

        /// <summary>
        /// <p>Product name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Physical type</p>
        /// </summary>
        [JsonProperty("MimeType")]
        public string MimeType{ get; set; }

        /// <summary>
        /// <p>File size (byte)</p>
        /// </summary>
        [JsonProperty("SizeBytes")]
        public long? SizeBytes{ get; set; }

        /// <summary>
        /// <p>Whether it is public</p>
        /// </summary>
        [JsonProperty("IsGlobal")]
        public bool? IsGlobal{ get; set; }

        /// <summary>
        /// <p>Creation time (Unix timestamp in seconds).</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public long? CreatedAt{ get; set; }

        /// <summary>
        /// <p>Modification time.</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public long? UpdatedAt{ get; set; }

        /// <summary>
        /// <p>Agent ID that generated the artifact</p>
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>Skill ID that generates the artifact</p>
        /// </summary>
        [JsonProperty("SkillId")]
        public string SkillId{ get; set; }

        /// <summary>
        /// <p>For parsing calls to the download API</p>
        /// </summary>
        [JsonProperty("StoragePath")]
        public string StoragePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ArtifactId", this.ArtifactId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MimeType", this.MimeType);
            this.SetParamSimple(map, prefix + "SizeBytes", this.SizeBytes);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "SkillId", this.SkillId);
            this.SetParamSimple(map, prefix + "StoragePath", this.StoragePath);
        }
    }
}

