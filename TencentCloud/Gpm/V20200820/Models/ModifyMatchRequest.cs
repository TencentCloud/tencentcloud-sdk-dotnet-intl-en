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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMatchRequest : AbstractModel
    {
        
        /// <summary>
        /// Match name. It can contain up to 128 bytes, supporting [a-zA-Z0-9-\.]*.
        /// </summary>
        [JsonProperty("MatchName")]
        public string MatchName{ get; set; }

        /// <summary>
        /// RuleCode
        /// </summary>
        [JsonProperty("RuleCode")]
        public string RuleCode{ get; set; }

        /// <summary>
        /// Timeout period in seconds. Value range: 1 600
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Whether to request server resources for the matchmaking results. 0: no, 1: request GSE resources
        /// </summary>
        [JsonProperty("ServerType")]
        public long? ServerType{ get; set; }

        /// <summary>
        /// MatchCode
        /// </summary>
        [JsonProperty("MatchCode")]
        public string MatchCode{ get; set; }

        /// <summary>
        /// Matchmaking description. Up to 1024 bytes are allowed.
        /// </summary>
        [JsonProperty("MatchDesc")]
        public string MatchDesc{ get; set; }

        /// <summary>
        /// Only HTTP and HTTPS protocols are supported.
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// Region of the game server queue
        /// </summary>
        [JsonProperty("ServerRegion")]
        public string ServerRegion{ get; set; }

        /// <summary>
        /// Game server queue
        /// </summary>
        [JsonProperty("ServerQueue")]
        public string ServerQueue{ get; set; }

        /// <summary>
        /// Custom push data
        /// </summary>
        [JsonProperty("CustomPushData")]
        public string CustomPushData{ get; set; }

        /// <summary>
        /// Game server session data
        /// </summary>
        [JsonProperty("ServerSessionData")]
        public string ServerSessionData{ get; set; }

        /// <summary>
        /// Game attribute. It is an array of key-value structure.
        /// </summary>
        [JsonProperty("GameProperties")]
        public StringKV[] GameProperties{ get; set; }

        /// <summary>
        /// Enable or disable the log. 0: disable, 1: enable
        /// </summary>
        [JsonProperty("LogSwitch")]
        public long? LogSwitch{ get; set; }

        /// <summary>
        /// Tag. It is an array of key-value structure.
        /// </summary>
        [JsonProperty("Tags")]
        public StringKV[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MatchName", this.MatchName);
            this.SetParamSimple(map, prefix + "RuleCode", this.RuleCode);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "MatchCode", this.MatchCode);
            this.SetParamSimple(map, prefix + "MatchDesc", this.MatchDesc);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "ServerRegion", this.ServerRegion);
            this.SetParamSimple(map, prefix + "ServerQueue", this.ServerQueue);
            this.SetParamSimple(map, prefix + "CustomPushData", this.CustomPushData);
            this.SetParamSimple(map, prefix + "ServerSessionData", this.ServerSessionData);
            this.SetParamArrayObj(map, prefix + "GameProperties.", this.GameProperties);
            this.SetParamSimple(map, prefix + "LogSwitch", this.LogSwitch);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

