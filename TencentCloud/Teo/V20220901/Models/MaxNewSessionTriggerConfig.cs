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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MaxNewSessionTriggerConfig : AbstractModel
    {
        
        /// <summary>
        /// Time window for trigger threshold statistics. valid values: <li>5s: within 5 seconds;</li><li>10s: within 10 seconds;</li><li>15s: within 15 seconds;</li><li>30s: within 30 seconds;</li><li>60s: within 60 seconds;</li><li>5m: within 5 minutes;</li><li>10m: within 10 minutes;</li><li>30m: within 30 minutes;</li><li>60m: within 60 minutes.</li>.
        /// </summary>
        [JsonProperty("MaxNewSessionCountInterval")]
        public string MaxNewSessionCountInterval{ get; set; }

        /// <summary>
        /// Trigger threshold cumulative count. value range: 1-100000000.
        /// </summary>
        [JsonProperty("MaxNewSessionCountThreshold")]
        public long? MaxNewSessionCountThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxNewSessionCountInterval", this.MaxNewSessionCountInterval);
            this.SetParamSimple(map, prefix + "MaxNewSessionCountThreshold", this.MaxNewSessionCountThreshold);
        }
    }
}

