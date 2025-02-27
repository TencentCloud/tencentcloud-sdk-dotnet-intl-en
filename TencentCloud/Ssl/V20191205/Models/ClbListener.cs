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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClbListener : AbstractModel
    {
        
        /// <summary>
        /// The listener ID.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// The listener name.
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// Whether to enable SNI. Valid values: `1` (enable) and `0` (disable).
        /// </summary>
        [JsonProperty("SniSwitch")]
        public ulong? SniSwitch{ get; set; }

        /// <summary>
        /// The listener protocol type. Valid values: `HTTPS` and `TCP_SSL`.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Data of certificate bound to the listener.
        /// </summary>
        [JsonProperty("Certificate")]
        public Certificate Certificate{ get; set; }

        /// <summary>
        /// List of listener rules.
        /// </summary>
        [JsonProperty("Rules")]
        public ClbListenerRule[] Rules{ get; set; }

        /// <summary>
        /// Domain list not matched.
        /// </summary>
        [JsonProperty("NoMatchDomains")]
        public string[] NoMatchDomains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "SniSwitch", this.SniSwitch);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamArraySimple(map, prefix + "NoMatchDomains.", this.NoMatchDomains);
        }
    }
}

