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

    public class RateLimitTemplate : AbstractModel
    {
        
        /// <summary>
        /// Template level name. Valid values:
        /// <li>sup_loose: super loose;</li>
        /// <li>loose: loose;</li>
        /// <li>emergency: emergency;</li>
        /// <li>normal: moderate;</li>
        /// <li>strict: strict;</li>
        /// <li>close: disabled, effective only for precise rate limiting.</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Template action. Valid values:
        /// <li>alg: JavaScript challenge;</li>
        /// <li>monitor: observe.</li>Default value: alg if not specified.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Description of the template value. Returned only as an output parameter.
        /// </summary>
        [JsonProperty("RateLimitTemplateDetail")]
        public RateLimitTemplateDetail RateLimitTemplateDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamObj(map, prefix + "RateLimitTemplateDetail.", this.RateLimitTemplateDetail);
        }
    }
}

