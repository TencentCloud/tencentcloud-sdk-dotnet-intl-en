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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTemplateListRequest : AbstractModel
    {
        
        /// <summary>
        /// Pagination limit.Maximum value:100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Pagination offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Experiment name
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// Tag key
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }

        /// <summary>
        /// Status. 1: in use; 2: not in use.
        /// </summary>
        [JsonProperty("IsUsed")]
        public long? IsUsed{ get; set; }

        /// <summary>
        /// Tag pair
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithDescribe[] Tags{ get; set; }

        /// <summary>
        /// Template library source. 0: self-built; 1: recommended by experts.
        /// </summary>
        [JsonProperty("TemplateSource")]
        public long? TemplateSource{ get; set; }

        /// <summary>
        /// Template ID
        /// </summary>
        [JsonProperty("TemplateIdList")]
        public long?[] TemplateIdList{ get; set; }

        /// <summary>
        /// Filter parameters
        /// </summary>
        [JsonProperty("Filters")]
        public ActionFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "IsUsed", this.IsUsed);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TemplateSource", this.TemplateSource);
            this.SetParamArraySimple(map, prefix + "TemplateIdList.", this.TemplateIdList);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

