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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillShare : AbstractModel
    {
        
        /// <summary>
        /// <p>Approval ID</p>
        /// </summary>
        [JsonProperty("ApprovalId")]
        public string ApprovalId{ get; set; }

        /// <summary>
        /// <p>New skill_id associated after sharing</p>
        /// </summary>
        [JsonProperty("ShareSkillId")]
        public string ShareSkillId{ get; set; }

        /// <summary>
        /// <p>Shared version, for example 1.0.0</p>
        /// </summary>
        [JsonProperty("ShareVersion")]
        public string ShareVersion{ get; set; }

        /// <summary>
        /// <p>Shared version ID</p>
        /// </summary>
        [JsonProperty("ShareVersionId")]
        public string ShareVersionId{ get; set; }

        /// <summary>
        /// <p>Original skill_id</p>
        /// </summary>
        [JsonProperty("SkillId")]
        public string SkillId{ get; set; }

        /// <summary>
        /// <p>Shared state</p><p>Enumeration values:<br>| uint | Description |<br>| --- | --- |<br>| 0 | Not shared |<br>| 1 | Shared |<br>| 2 | Pending Approval |</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Business share scope</p>
        /// </summary>
        [JsonProperty("CorpShareConfig")]
        public SkillCorpShareConfig CorpShareConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApprovalId", this.ApprovalId);
            this.SetParamSimple(map, prefix + "ShareSkillId", this.ShareSkillId);
            this.SetParamSimple(map, prefix + "ShareVersion", this.ShareVersion);
            this.SetParamSimple(map, prefix + "ShareVersionId", this.ShareVersionId);
            this.SetParamSimple(map, prefix + "SkillId", this.SkillId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "CorpShareConfig.", this.CorpShareConfig);
        }
    }
}

