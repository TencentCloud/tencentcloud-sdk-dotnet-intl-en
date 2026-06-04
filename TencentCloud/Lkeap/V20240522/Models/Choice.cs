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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Choice : AbstractModel
    {
        
        /// <summary>
        /// The end flag, which can be "stop" or "content_filter."
        /// "Stop" indicates normal output end.
        /// "Content_filter" appears only when streaming output review is enabled, indicating that the security review has not passed.
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// Incremental return value, used when making streaming calls.
        /// </summary>
        [JsonProperty("Delta")]
        public Delta Delta{ get; set; }

        /// <summary>
        /// Return value, used when making non-streaming calls.
        /// </summary>
        [JsonProperty("Message")]
        public Message Message{ get; set; }

        /// <summary>
        /// Index value, used when making streaming calls.
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamObj(map, prefix + "Delta.", this.Delta);
            this.SetParamObj(map, prefix + "Message.", this.Message);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

