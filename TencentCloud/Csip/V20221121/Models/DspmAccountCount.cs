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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmAccountCount : AbstractModel
    {
        
        /// <summary>
        /// Number of cloud accounts
        /// </summary>
        [JsonProperty("UinAccountCount")]
        public long? UinAccountCount{ get; set; }

        /// <summary>
        /// Guest account count
        /// </summary>
        [JsonProperty("PersonCount")]
        public long? PersonCount{ get; set; }

        /// <summary>
        /// Number of unmanaged accounts
        /// </summary>
        [JsonProperty("UncontrolledAccountCount")]
        public long? UncontrolledAccountCount{ get; set; }

        /// <summary>
        /// Total number of accounts
        /// </summary>
        [JsonProperty("TotalAccountCount")]
        public long? TotalAccountCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UinAccountCount", this.UinAccountCount);
            this.SetParamSimple(map, prefix + "PersonCount", this.PersonCount);
            this.SetParamSimple(map, prefix + "UncontrolledAccountCount", this.UncontrolledAccountCount);
            this.SetParamSimple(map, prefix + "TotalAccountCount", this.TotalAccountCount);
        }
    }
}

