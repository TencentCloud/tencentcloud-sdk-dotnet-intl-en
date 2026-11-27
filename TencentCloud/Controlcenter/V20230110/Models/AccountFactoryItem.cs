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

namespace TencentCloud.Controlcenter.V20230110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountFactoryItem : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the Account Factory baseline item, which can contain only English letters, numbers, and symbols (@,._[]-:()+=), and must be 2 to 128 characters in length.
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// Baseline item name, which is unique, supports only the combination of English letters, digits, and symbols (@&_[]-), and is 1 to 25 characters in length.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Baseline item English name, which must be unique, can contain only English letters, numbers, spaces, and symbols (@&_[]-), and must be 1 to 64 characters in length.
        /// </summary>
        [JsonProperty("NameEn")]
        public string NameEn{ get; set; }

        /// <summary>
        /// Baseline item weight. A smaller value indicates a higher priority. Value range: greater than or equal to 0.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Whether the baseline item is required. Valid values: 1 (yes) and 0 (no).
        /// </summary>
        [JsonProperty("Required")]
        public long? Required{ get; set; }

        /// <summary>
        /// Baseline item dependencies. The value range of N depends on the number of other baseline items that the current baseline item depends on.
        /// </summary>
        [JsonProperty("DependsOn")]
        public DependsOnItem[] DependsOn{ get; set; }

        /// <summary>
        /// Baseline description, which is 2 to 256 English characters in length. The default value is empty.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Baseline item English description, which is 2 to 1024 English characters in length. The default value is empty.
        /// </summary>
        [JsonProperty("DescriptionEn")]
        public string DescriptionEn{ get; set; }

        /// <summary>
        /// Baseline category, which is 2 to 32 English characters in length and cannot be empty.
        /// </summary>
        [JsonProperty("Classify")]
        public string Classify{ get; set; }

        /// <summary>
        /// Baseline English category, which is 2 to 64 English characters in length and cannot be empty.
        /// </summary>
        [JsonProperty("ClassifyEn")]
        public string ClassifyEn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NameEn", this.NameEn);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamArrayObj(map, prefix + "DependsOn.", this.DependsOn);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DescriptionEn", this.DescriptionEn);
            this.SetParamSimple(map, prefix + "Classify", this.Classify);
            this.SetParamSimple(map, prefix + "ClassifyEn", this.ClassifyEn);
        }
    }
}

