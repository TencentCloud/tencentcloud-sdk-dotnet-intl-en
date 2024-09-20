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

    public class TemplateListItem : AbstractModel
    {
        
        /// <summary>
        /// Template library ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// Template library name
        /// </summary>
        [JsonProperty("TemplateTitle")]
        public string TemplateTitle{ get; set; }

        /// <summary>
        /// Template library description
        /// </summary>
        [JsonProperty("TemplateDescription")]
        public string TemplateDescription{ get; set; }

        /// <summary>
        /// Template library tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TemplateTag")]
        public string TemplateTag{ get; set; }

        /// <summary>
        /// Template library status. 1: in use; 2: not in use.
        /// </summary>
        [JsonProperty("TemplateIsUsed")]
        public long? TemplateIsUsed{ get; set; }

        /// <summary>
        /// Template library creation time
        /// </summary>
        [JsonProperty("TemplateCreateTime")]
        public string TemplateCreateTime{ get; set; }

        /// <summary>
        /// Template library update time
        /// </summary>
        [JsonProperty("TemplateUpdateTime")]
        public string TemplateUpdateTime{ get; set; }

        /// <summary>
        /// Number of tasks associated with the template library
        /// </summary>
        [JsonProperty("TemplateUsedNum")]
        public long? TemplateUsedNum{ get; set; }

        /// <summary>
        /// Template library source. 0: self-built; 1: recommended by experts.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TemplateSource")]
        public long? TemplateSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateTitle", this.TemplateTitle);
            this.SetParamSimple(map, prefix + "TemplateDescription", this.TemplateDescription);
            this.SetParamSimple(map, prefix + "TemplateTag", this.TemplateTag);
            this.SetParamSimple(map, prefix + "TemplateIsUsed", this.TemplateIsUsed);
            this.SetParamSimple(map, prefix + "TemplateCreateTime", this.TemplateCreateTime);
            this.SetParamSimple(map, prefix + "TemplateUpdateTime", this.TemplateUpdateTime);
            this.SetParamSimple(map, prefix + "TemplateUsedNum", this.TemplateUsedNum);
            this.SetParamSimple(map, prefix + "TemplateSource", this.TemplateSource);
        }
    }
}

