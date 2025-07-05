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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeParamTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// Engine version. If it is left empty, all parameter templates will be queried.
        /// </summary>
        [JsonProperty("EngineVersions")]
        public string[] EngineVersions{ get; set; }

        /// <summary>
        /// Engine type. If it is left empty, all engine types will be queried.
        /// </summary>
        [JsonProperty("EngineTypes")]
        public string[] EngineTypes{ get; set; }

        /// <summary>
        /// Template name. If it is left empty, all template names will be queried.
        /// </summary>
        [JsonProperty("TemplateNames")]
        public string[] TemplateNames{ get; set; }

        /// <summary>
        /// Template ID. If it is left empty, all template IDs will be queried.
        /// </summary>
        [JsonProperty("TemplateIds")]
        public long?[] TemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EngineVersions.", this.EngineVersions);
            this.SetParamArraySimple(map, prefix + "EngineTypes.", this.EngineTypes);
            this.SetParamArraySimple(map, prefix + "TemplateNames.", this.TemplateNames);
            this.SetParamArraySimple(map, prefix + "TemplateIds.", this.TemplateIds);
        }
    }
}

