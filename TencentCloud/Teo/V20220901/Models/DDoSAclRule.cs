/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DDoSAclRule : AbstractModel
    {
        
        /// <summary>
        /// End of the destination port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("DportEnd")]
        public long? DportEnd{ get; set; }

        /// <summary>
        /// Start of the destination port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("DportStart")]
        public long? DportStart{ get; set; }

        /// <summary>
        /// End of the source port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("SportEnd")]
        public long? SportEnd{ get; set; }

        /// <summary>
        /// Start of the source port. Value range: 0–65535.
        /// </summary>
        [JsonProperty("SportStart")]
        public long? SportStart{ get; set; }

        /// <summary>
        /// The protocol. Values:
        /// <li>`tcp`: TCP protocol</li>
        /// <li>`udp`: UDP protocol</li>
        /// <li>`all`: All protocols</li>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Action to be executed. Values:
        /// <li>`drop`: Discard</li>
        /// <li>`transmit`: Allow</li>
        /// <li>`forward`: Continue protection</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

