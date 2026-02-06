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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranslationChoice : AbstractModel
    {
        
        /// <summary>
        /// End flag, can be stop or sensitive.
        /// stop means output ends normally.
        /// sensitive only appears when streaming output review is enabled, indicating security review not passed.
        /// </summary>
        [JsonProperty("FinishReason")]
        public string FinishReason{ get; set; }

        /// <summary>
        /// Index value, used when streaming.
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }

        /// <summary>
        /// Incremental return value used when streaming this field.
        /// </summary>
        [JsonProperty("Delta")]
        public TranslationDelta Delta{ get; set; }

        /// <summary>
        /// Return value, used when non-streaming.
        /// </summary>
        [JsonProperty("Message")]
        public TranslationMessage Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinishReason", this.FinishReason);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamObj(map, prefix + "Delta.", this.Delta);
            this.SetParamObj(map, prefix + "Message.", this.Message);
        }
    }
}

