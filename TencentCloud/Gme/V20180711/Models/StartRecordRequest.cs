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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// Room ID.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Recording mode. Valid values: `1`: single stream; `2`: mixed streams; `3`: single stream and mixed streams.
        /// </summary>
        [JsonProperty("RecordMode")]
        public ulong? RecordMode{ get; set; }

        /// <summary>
        /// Allowlist or blocklist for stream subscription. If you do not specify this parameter, the audio streams of all the users in the room are subscribed to by default.
        /// </summary>
        [JsonProperty("SubscribeRecordUserIds")]
        public SubscribeRecordUserIds SubscribeRecordUserIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RecordMode", this.RecordMode);
            this.SetParamObj(map, prefix + "SubscribeRecordUserIds.", this.SubscribeRecordUserIds);
        }
    }
}

