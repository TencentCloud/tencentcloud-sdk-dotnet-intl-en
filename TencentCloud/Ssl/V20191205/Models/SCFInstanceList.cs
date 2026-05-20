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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SCFInstanceList : AbstractModel
    {
        
        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>SCF instance details</p>
        /// </summary>
        [JsonProperty("InstanceList")]
        public SCFInstanceDetail[] InstanceList{ get; set; }

        /// <summary>
        /// <p>Error message</p>
        /// </summary>
        [JsonProperty("Error")]
        public string Error{ get; set; }

        /// <summary>
        /// <p>Total count in the region</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "InstanceList.", this.InstanceList);
            this.SetParamSimple(map, prefix + "Error", this.Error);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

