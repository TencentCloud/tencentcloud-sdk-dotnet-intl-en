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
        /// Specifies the unique identifier for account factory baseline item, can only contain english letters, digits, and @, ,._[]-:()()[]+=., with a length of 2-128 characters.
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// Baseline item name. specifies a unique name for the feature item. supports a combination of english letters, numbers, chinese characters, and symbols @, &, _, [, ], -. valid values: 1-25 chinese or english characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Baseline item english name. specifies a unique name for the baseline item. supports a combination of english letters, digits, spaces, and symbols @, &, _, [], -. valid values: 1-64 english characters.
        /// </summary>
        [JsonProperty("NameEn")]
        public string NameEn{ get; set; }

        /// <summary>
        /// Baseline item weight. the smaller the value, the higher the weight. value range equal to or greater than 0.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Specifies whether the baseline item is required (1: required; 0: optional).
        /// </summary>
        [JsonProperty("Required")]
        public long? Required{ get; set; }

        /// <summary>
        /// Baseline item dependency. value range of N depends on the count of other baseline items it relies on.
        /// </summary>
        [JsonProperty("DependsOn")]
        public DependsOnItem[] DependsOn{ get; set; }

        /// <summary>
        /// Baseline description, with a length of 2 to 256 english or chinese characters. it is empty by default.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Baseline item english description, with a length of 2 to 1024 english characters. it is empty by default.
        /// </summary>
        [JsonProperty("DescriptionEn")]
        public string DescriptionEn{ get; set; }

        /// <summary>
        /// Baseline classification. length: 2-32 english or chinese characters. values cannot be empty.
        /// </summary>
        [JsonProperty("Classify")]
        public string Classify{ get; set; }

        /// <summary>
        /// Baseline english classification, with a length of 2-64 english characters. cannot be empty.
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

