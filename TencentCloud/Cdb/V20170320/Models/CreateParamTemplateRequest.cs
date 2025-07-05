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

    public class CreateParamTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Parameter template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Parameter template description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// MySQL version number.
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// Source parameter template ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// List of parameters.
        /// </summary>
        [JsonProperty("ParamList")]
        public Parameter[] ParamList{ get; set; }

        /// <summary>
        /// Type of the default parameter template. Valid values: `HIGH_STABILITY` (high-stability template), `HIGH_PERFORMANCE` (high-performance template).
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// Instance engine type. Valid values: `InnoDB` (default), `RocksDB`.
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
        }
    }
}

