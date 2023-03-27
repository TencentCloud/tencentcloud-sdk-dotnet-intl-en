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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MessageItem : AbstractModel
    {
        
        /// <summary>
        /// The message type. `0`: Text; `1`: Image.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageType")]
        public long? MessageType{ get; set; }

        /// <summary>
        /// The text. This parameter is valid if `MessageType` is `0`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TextMessage")]
        public string TextMessage{ get; set; }

        /// <summary>
        /// The image URL. This parameter is valid if `MessageType` is `1`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageMessage")]
        public string ImageMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MessageType", this.MessageType);
            this.SetParamSimple(map, prefix + "TextMessage", this.TextMessage);
            this.SetParamSimple(map, prefix + "ImageMessage", this.ImageMessage);
        }
    }
}

