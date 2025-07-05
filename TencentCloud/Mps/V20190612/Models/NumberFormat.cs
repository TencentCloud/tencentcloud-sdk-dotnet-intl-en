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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NumberFormat : AbstractModel
    {
        
        /// <summary>
        /// Start value of the `{number}` variable. Default value: 0.
        /// </summary>
        [JsonProperty("InitialValue")]
        public ulong? InitialValue{ get; set; }

        /// <summary>
        /// Increment of the `{number}` variable. Default value: 1.
        /// </summary>
        [JsonProperty("Increment")]
        public ulong? Increment{ get; set; }

        /// <summary>
        /// Minimum length of the `{number}` variable. A placeholder will be used if the variable length is below the minimum requirement. Default value: 1.
        /// </summary>
        [JsonProperty("MinLength")]
        public ulong? MinLength{ get; set; }

        /// <summary>
        /// Placeholder used when the `{number}` variable length is below the minimum requirement. Default value: 0.
        /// </summary>
        [JsonProperty("PlaceHolder")]
        public string PlaceHolder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InitialValue", this.InitialValue);
            this.SetParamSimple(map, prefix + "Increment", this.Increment);
            this.SetParamSimple(map, prefix + "MinLength", this.MinLength);
            this.SetParamSimple(map, prefix + "PlaceHolder", this.PlaceHolder);
        }
    }
}

