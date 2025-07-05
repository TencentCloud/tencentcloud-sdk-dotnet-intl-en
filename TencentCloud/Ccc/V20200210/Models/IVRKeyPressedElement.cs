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

    public class IVRKeyPressedElement : AbstractModel
    {
        
        /// <summary>
        /// Hit keyword or press.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Tag associated with the key.
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// UNIX millisecond timestamp.
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// Node tags.
        /// </summary>
        [JsonProperty("NodeLabel")]
        public string NodeLabel{ get; set; }

        /// <summary>
        /// User'S original input.
        /// </summary>
        [JsonProperty("OriginalContent")]
        public string OriginalContent{ get; set; }

        /// <summary>
        /// TTS prompt content.
        /// </summary>
        [JsonProperty("TTSPrompt")]
        public string TTSPrompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "NodeLabel", this.NodeLabel);
            this.SetParamSimple(map, prefix + "OriginalContent", this.OriginalContent);
            this.SetParamSimple(map, prefix + "TTSPrompt", this.TTSPrompt);
        }
    }
}

