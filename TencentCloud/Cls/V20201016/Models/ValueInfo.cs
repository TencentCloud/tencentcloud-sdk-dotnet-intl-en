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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ValueInfo : AbstractModel
    {
        
        /// <summary>
        /// Field type. Supported types: long, text, double, json.
        /// Note: The json data type is currently supported by partial users or log topics. If needed, contact us to enable the allowlist.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Separator of fields. Each character represents a separator.
        /// Only symbols, \n\t\r, and escape character \ are supported.
        /// `long` and `double` fields need to be null.
        /// Note: \n\t\r can be directly enclosed in double quotes as the input parameter without escaping. When debugging with API Explorer, use the JSON parameter input method to avoid repeated escaping of \n\t\r.
        /// </summary>
        [JsonProperty("Tokenizer")]
        public string Tokenizer{ get; set; }

        /// <summary>
        /// Whether the analysis feature is enabled for the field
        /// </summary>
        [JsonProperty("SqlFlag")]
        public bool? SqlFlag{ get; set; }

        /// <summary>
        /// Whether to include node data. Set this parameter to false for the long and double fields.
        /// </summary>
        [JsonProperty("ContainZH")]
        public bool? ContainZH{ get; set; }

        /// <summary>
        /// field alias
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Enable index only for sub-node. This field is not enabled.
        /// Note: Only json type fields can configure this parameter.
        /// </summary>
        [JsonProperty("OpenIndexForChildOnly")]
        public bool? OpenIndexForChildOnly{ get; set; }

        /// <summary>
        /// subnode list
        /// Note: Only json type fields can configure this parameter.
        /// </summary>
        [JsonProperty("ChildNode")]
        public KeyValueInfo[] ChildNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Tokenizer", this.Tokenizer);
            this.SetParamSimple(map, prefix + "SqlFlag", this.SqlFlag);
            this.SetParamSimple(map, prefix + "ContainZH", this.ContainZH);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "OpenIndexForChildOnly", this.OpenIndexForChildOnly);
            this.SetParamArrayObj(map, prefix + "ChildNode.", this.ChildNode);
        }
    }
}

