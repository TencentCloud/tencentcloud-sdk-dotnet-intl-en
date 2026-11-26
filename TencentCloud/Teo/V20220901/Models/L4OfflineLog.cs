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

    public class L4OfflineLog : AbstractModel
    {
        
        /// <summary>
        /// Layer 4 Proxy Instance ID.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Log region. Valid values:
        /// <li>mainland: within the Chinese mainland;</li>
        /// <li>overseas: global (excluding the Chinese mainland).</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Name of the offline log data packet.
        /// </summary>
        [JsonProperty("LogPacketName")]
        public string LogPacketName{ get; set; }

        /// <summary>
        /// Offline log download URL.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Log packaging time. This parameter has been deprecated.
        /// </summary>
        [JsonProperty("LogTime")]
        public long? LogTime{ get; set; }

        /// <summary>
        /// Start time for log packaging.
        /// </summary>
        [JsonProperty("LogStartTime")]
        public string LogStartTime{ get; set; }

        /// <summary>
        /// Log packaging end time.
        /// </summary>
        [JsonProperty("LogEndTime")]
        public string LogEndTime{ get; set; }

        /// <summary>
        /// Log size in bytes.
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "LogPacketName", this.LogPacketName);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "LogTime", this.LogTime);
            this.SetParamSimple(map, prefix + "LogStartTime", this.LogStartTime);
            this.SetParamSimple(map, prefix + "LogEndTime", this.LogEndTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
        }
    }
}

