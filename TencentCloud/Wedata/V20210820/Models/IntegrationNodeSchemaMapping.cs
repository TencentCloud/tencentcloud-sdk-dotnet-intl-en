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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntegrationNodeSchemaMapping : AbstractModel
    {
        
        /// <summary>
        /// Task Node Source Schema ID
        /// </summary>
        [JsonProperty("SourceSchemaId")]
        public string SourceSchemaId{ get; set; }

        /// <summary>
        /// Task Node Target Schema ID
        /// </summary>
        [JsonProperty("SinkSchemaId")]
        public string SinkSchemaId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceSchemaId", this.SourceSchemaId);
            this.SetParamSimple(map, prefix + "SinkSchemaId", this.SinkSchemaId);
        }
    }
}

