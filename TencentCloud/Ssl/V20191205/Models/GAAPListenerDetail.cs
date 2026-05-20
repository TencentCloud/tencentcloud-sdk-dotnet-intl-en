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

    public class GAAPListenerDetail : AbstractModel
    {
        
        /// <summary>
        /// Listener status
        /// </summary>
        [JsonProperty("ListenerStatus")]
        public string ListenerStatus{ get; set; }

        /// <summary>
        /// listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// listener name
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// Mismatched domain name list
        /// </summary>
        [JsonProperty("NoMatchDomains")]
        public string[] NoMatchDomains{ get; set; }

        /// <summary>
        /// Certificate list associated with CVM instances	
        /// </summary>
        [JsonProperty("CertIdList")]
        public string[] CertIdList{ get; set; }

        /// <summary>
        /// Listener protocol
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerStatus", this.ListenerStatus);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamArraySimple(map, prefix + "NoMatchDomains.", this.NoMatchDomains);
            this.SetParamArraySimple(map, prefix + "CertIdList.", this.CertIdList);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
        }
    }
}

