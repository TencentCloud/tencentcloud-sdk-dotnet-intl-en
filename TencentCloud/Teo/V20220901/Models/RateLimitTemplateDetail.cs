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

    public class RateLimitTemplateDetail : AbstractModel
    {
        
        /// <summary>
        /// Template level name. valid values:.
        /// <Li>Sup_loose: specifies super loose.</li>.
        /// <Li>`Loose`: loose</li>.
        /// <Li>`Emergency`: emergency</li>.
        /// <li>`normal`: moderate</li>.
        /// <li>strict</li>.
        /// <li>`close`: off, precise rate limiting effective.</li>.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Unique ID.
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Template action. valid values:.
        /// <li>alg: JavaScript challenge;</li>.
        /// <li>`monitor`: observe</li>.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Penalty time, value range 0-2 days, unit second.
        /// </summary>
        [JsonProperty("PunishTime")]
        public long? PunishTime{ get; set; }

        /// <summary>
        /// Statistical threshold, in times. Value range: 0-4294967294.
        /// </summary>
        [JsonProperty("Threshold")]
        public long? Threshold{ get; set; }

        /// <summary>
        /// Statistical cycle. Value range: 0-120 seconds.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "PunishTime", this.PunishTime);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Period", this.Period);
        }
    }
}

