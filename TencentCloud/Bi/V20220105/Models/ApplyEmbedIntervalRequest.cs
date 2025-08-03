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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyEmbedIntervalRequest : AbstractModel
    {
        
        /// <summary>
        /// Shares the project ID. Required.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Shares the page ID. This field is empty (0) for embedding a dashboard and is not passed for embedding ChatBI.
        /// </summary>
        [JsonProperty("PageId")]
        public ulong? PageId{ get; set; }

        /// <summary>
        /// Token requiring extension.
        /// </summary>
        [JsonProperty("BIToken")]
        public string BIToken{ get; set; }

        /// <summary>
        /// Alternate field.
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// embed: page/dashboard embedding.
        /// chatBIEmbed: ChatBI embedding.
        /// </summary>
        [JsonProperty("Intention")]
        public string Intention{ get; set; }

        /// <summary>
        /// panel: dashboard; page: page.
        /// project, during ChatBI embedding.
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "BIToken", this.BIToken);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "Intention", this.Intention);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
        }
    }
}

