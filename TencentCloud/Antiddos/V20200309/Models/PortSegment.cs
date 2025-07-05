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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PortSegment : AbstractModel
    {
        
        /// <summary>
        /// Start port. Value range: 1–65535.
        /// </summary>
        [JsonProperty("BeginPort")]
        public ulong? BeginPort{ get; set; }

        /// <summary>
        /// End port. The value should be in the range 1–65535 and cannot be less than that of the start port.
        /// </summary>
        [JsonProperty("EndPort")]
        public ulong? EndPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginPort", this.BeginPort);
            this.SetParamSimple(map, prefix + "EndPort", this.EndPort);
        }
    }
}

