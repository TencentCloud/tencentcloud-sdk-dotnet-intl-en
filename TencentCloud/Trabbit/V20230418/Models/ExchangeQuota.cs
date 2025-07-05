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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExchangeQuota : AbstractModel
    {
        
        /// <summary>
        /// Specifies the maximum number of exchanges that can be created.
        /// </summary>
        [JsonProperty("MaxExchange")]
        public long? MaxExchange{ get; set; }

        /// <summary>
        /// Specifies the number of exchanges that have been created.
        /// </summary>
        [JsonProperty("UsedExchange")]
        public long? UsedExchange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxExchange", this.MaxExchange);
            this.SetParamSimple(map, prefix + "UsedExchange", this.UsedExchange);
        }
    }
}

