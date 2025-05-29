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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppConfig : AbstractModel
    {
        
        /// <summary>
        /// Knowledge Q&A management application configuration
        /// </summary>
        [JsonProperty("KnowledgeQa")]
        public KnowledgeQaConfig KnowledgeQa{ get; set; }

        /// <summary>
        /// Knowledge summary application configuration.
        /// </summary>
        [JsonProperty("Summary")]
        public SummaryConfig Summary{ get; set; }

        /// <summary>
        /// Label extraction application configuration.
        /// </summary>
        [JsonProperty("Classify")]
        public ClassifyConfig Classify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "KnowledgeQa.", this.KnowledgeQa);
            this.SetParamObj(map, prefix + "Summary.", this.Summary);
            this.SetParamObj(map, prefix + "Classify.", this.Classify);
        }
    }
}

