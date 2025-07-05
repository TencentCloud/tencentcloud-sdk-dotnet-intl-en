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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageBlur : AbstractModel
    {
        
        /// <summary>
        /// The blur type. Valid values:
        /// <li>`Gaussian`</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The radius of the blur. Value range: 1-50. This parameter is valid if `Type` is `Gaussian`.
        /// </summary>
        [JsonProperty("Radius")]
        public long? Radius{ get; set; }

        /// <summary>
        /// The standard deviation of the Gaussian distribution, which must be greater than 0. This parameter is valid if `Type` is `Gaussian`.
        /// </summary>
        [JsonProperty("Sigma")]
        public long? Sigma{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Radius", this.Radius);
            this.SetParamSimple(map, prefix + "Sigma", this.Sigma);
        }
    }
}

