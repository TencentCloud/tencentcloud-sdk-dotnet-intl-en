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

    public class NodeRunContent : AbstractModel
    {
        
        /// <summary>
        /// Input variable information
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// Output variable information
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// Original output information. Only partial nodes have a value, such as tool nodes and code nodes.
        /// </summary>
        [JsonProperty("OriginalOutput")]
        public string OriginalOutput{ get; set; }

        /// <summary>
        /// URLs of the complete node Input content. (This field has a value only when the Input content exceeds the limit.)
        /// </summary>
        [JsonProperty("InputRef")]
        public string InputRef{ get; set; }

        /// <summary>
        /// URLs of the complete node Output. This field has a value only when the Output exceeds the limit.
        /// </summary>
        [JsonProperty("OutputRef")]
        public string OutputRef{ get; set; }

        /// <summary>
        /// URLs of the complete original output content of the task. (This field has a value only when the TaskOutput content exceeds the limit.)
        /// </summary>
        [JsonProperty("OriginalOutputRef")]
        public string OriginalOutputRef{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "OriginalOutput", this.OriginalOutput);
            this.SetParamSimple(map, prefix + "InputRef", this.InputRef);
            this.SetParamSimple(map, prefix + "OutputRef", this.OutputRef);
            this.SetParamSimple(map, prefix + "OriginalOutputRef", this.OriginalOutputRef);
        }
    }
}

