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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CsvInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to print `key` on the first row of the CSV file
        /// </summary>
        [JsonProperty("PrintKey")]
        public bool? PrintKey{ get; set; }

        /// <summary>
        /// Names of keys
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// Field delimiter
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// Escape character used to enclose any field delimiter in field content. You can enter only a single quotation mark, double quotation mark, or an empty string.
        /// </summary>
        [JsonProperty("EscapeChar")]
        public string EscapeChar{ get; set; }

        /// <summary>
        /// Content used to populate non-existing fields
        /// </summary>
        [JsonProperty("NonExistingField")]
        public string NonExistingField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrintKey", this.PrintKey);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "EscapeChar", this.EscapeChar);
            this.SetParamSimple(map, prefix + "NonExistingField", this.NonExistingField);
        }
    }
}

