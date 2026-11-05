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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MsgRecordSource : AbstractModel
    {
        
        /// <summary>
        /// Channel type for dialogue message access: 0=not specified, 1=agent, 2=experience page (Tencent Cloud), 3=evaluation dialogue, 4=experience page (phone number), 5=dialogue API connection, 6=evaluation task dialogue, 10=workflow debugging, 10000=WeChat official account, 10001=WeChat service account, 10002=WeCom app, 10003=web components, 10004=WeChat Customer Service, 10005=WeChat mini program, 10006=Yuanqi, 10007=App Treasure, 10008=Yuanbao, 10009=WeCom intelligent bot, 10010=Yuanqi API, 10011=LINE, 10012=Telegram, 10100=PC manager, 20001=honor Intelligent Agent platform, 20002=Xiaomi app store; user_id (string) is the unique ID of the visitor under this channel.
        /// </summary>
        [JsonProperty("ChannelType")]
        public ulong? ChannelType{ get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty("FromId")]
        public string FromId{ get; set; }

        /// <summary>
        /// User source type of the message sender: 1=user (visitor/C-end user), 2=robot (AI reply), 3=agent (human customer service); from_id (string) is the unique user ID under this source type.
        /// </summary>
        [JsonProperty("FromType")]
        public ulong? FromType{ get; set; }

        /// <summary>
        /// User profile photo
        /// </summary>
        [JsonProperty("UserAvatar")]
        public string UserAvatar{ get; set; }

        /// <summary>
        /// Visitor ID.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Visitor name
        /// </summary>
        [JsonProperty("UserNickname")]
        public string UserNickname{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelType", this.ChannelType);
            this.SetParamSimple(map, prefix + "FromId", this.FromId);
            this.SetParamSimple(map, prefix + "FromType", this.FromType);
            this.SetParamSimple(map, prefix + "UserAvatar", this.UserAvatar);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserNickname", this.UserNickname);
        }
    }
}

