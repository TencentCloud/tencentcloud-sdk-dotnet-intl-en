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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Choice : AbstractModel
    {
        
        /// <summary>
        /// <p>End flag, which may be stop, sensitive, or tool_calls.<br>stop means the output ends normally.<br>sensitive means the security review is not passed.<br>tool_calls identifies a function call.</p><p>Note:<br>Partial content may have been output, but if the FinishReason value in the middle of the response is sensitive, it means the security review is not passed. If the business scenario requires real-time text display on the screen, manually withdraw the displayed content and recommend replacing it with a custom reminder, such as "I can't answer this issue. Let's try another topic," to ensure terminal experience.</p>
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// <p>Incremental return value. This field is used when streaming.</p>
        /// </summary>
        [JsonProperty("Delta")]
        public Delta Delta{ get; set; }

        /// <summary>
        /// <p>Return value, used when Non-streaming calls.</p>
        /// </summary>
        [JsonProperty("Message")]
        public Message Message{ get; set; }

        /// <summary>
        /// <p>Index value. This field is used when streaming.</p>
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

