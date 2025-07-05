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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OwnNumberApplyDetailItem : AbstractModel
    {
        
        /// <summary>
        /// Number type: 0 - inbound | 1 - outbound | 2 - inbound and outbound.
        /// </summary>
        [JsonProperty("CallType")]
        public long? CallType{ get; set; }

        /// <summary>
        /// Line number.
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// Maximum concurrent call number.
        /// </summary>
        [JsonProperty("MaxCallCount")]
        public long? MaxCallCount{ get; set; }

        /// <summary>
        /// Maximum number of concurrencies per second.
        /// </summary>
        [JsonProperty("MaxCallPSec")]
        public long? MaxCallPSec{ get; set; }

        /// <summary>
        /// Outbound called number format, use {+e.164} or {e.164}. 
        /// </summary>
        [JsonProperty("OutboundCalleeFormat")]
        public string OutboundCalleeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "MaxCallCount", this.MaxCallCount);
            this.SetParamSimple(map, prefix + "MaxCallPSec", this.MaxCallPSec);
            this.SetParamSimple(map, prefix + "OutboundCalleeFormat", this.OutboundCalleeFormat);
        }
    }
}

