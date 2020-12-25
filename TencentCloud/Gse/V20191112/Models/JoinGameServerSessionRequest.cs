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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JoinGameServerSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// Game server session ID. It should contain 1 to 256 ASCII characters.
        /// </summary>
        [JsonProperty("GameServerSessionId")]
        public string GameServerSessionId{ get; set; }

        /// <summary>
        /// Player ID. Up to 1024 ASCII characters are allowed.
        /// </summary>
        [JsonProperty("PlayerId")]
        public string PlayerId{ get; set; }

        /// <summary>
        /// Player custom data. Up to 2048 ASCII characters are allowed.
        /// </summary>
        [JsonProperty("PlayerData")]
        public string PlayerData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GameServerSessionId", this.GameServerSessionId);
            this.SetParamSimple(map, prefix + "PlayerId", this.PlayerId);
            this.SetParamSimple(map, prefix + "PlayerData", this.PlayerData);
        }
    }
}

