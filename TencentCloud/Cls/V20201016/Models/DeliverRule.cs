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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeliverRule : AbstractModel
    {
        
        /// <summary>
        /// <p>Data delivery range.</p><p>Enumeration values:</p><ul><li>1: History + newly added data</li><li>2: Custom time range</li><li>3: New additions only</li></ul><p>This time, only 3 newly added data is supported. Subsequent support: 2 custom time range and 1 history + newly added data</p>
        /// </summary>
        [JsonProperty("DataScope")]
        public ulong? DataScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataScope", this.DataScope);
        }
    }
}

