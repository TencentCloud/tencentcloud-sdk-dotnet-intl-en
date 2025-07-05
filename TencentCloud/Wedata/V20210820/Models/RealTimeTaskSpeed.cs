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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RealTimeTaskSpeed : AbstractModel
    {
        
        /// <summary>
        /// Synchronous Speed Bar/s List
        /// </summary>
        [JsonProperty("RecordsSpeedList")]
        public RecordsSpeed[] RecordsSpeedList{ get; set; }

        /// <summary>
        /// Synchronous Speed Bytes/s List
        /// </summary>
        [JsonProperty("BytesSpeedList")]
        public BytesSpeed[] BytesSpeedList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RecordsSpeedList.", this.RecordsSpeedList);
            this.SetParamArrayObj(map, prefix + "BytesSpeedList.", this.BytesSpeedList);
        }
    }
}

