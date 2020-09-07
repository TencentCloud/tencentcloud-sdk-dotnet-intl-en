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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Hair : AbstractModel
    {
        
        /// <summary>
        /// Hair length information.
        /// The `Type` values of the `AttributeItem` include: 0: shaved head, 1: short hair, 2: medium hair, 3: long hair, 4: braid.
        /// </summary>
        [JsonProperty("Length")]
        public AttributeItem Length{ get; set; }

        /// <summary>
        /// Bang information.
        /// The `Type` values of the `AttributeItem` include: 0: no bang; 1: bang detected.
        /// </summary>
        [JsonProperty("Bang")]
        public AttributeItem Bang{ get; set; }

        /// <summary>
        /// Hair color information.
        /// The `Type` values of the `AttributeItem` include: 0: black; 1: golden; 2: brown; 3: gray.
        /// </summary>
        [JsonProperty("Color")]
        public AttributeItem Color{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Length.", this.Length);
            this.SetParamObj(map, prefix + "Bang.", this.Bang);
            this.SetParamObj(map, prefix + "Color.", this.Color);
        }
    }
}

