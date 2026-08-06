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

namespace TencentCloud.Tmt.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Original text of the current row</p>
        /// </summary>
        [JsonProperty("SourceLineText")]
        public string SourceLineText{ get; set; }

        /// <summary>
        /// <p>Translation of the current row</p>
        /// </summary>
        [JsonProperty("TargetLineText")]
        public string TargetLineText{ get; set; }

        /// <summary>
        /// <p>Paragraph text box location</p>
        /// </summary>
        [JsonProperty("BoundingBox")]
        public BoundingBox BoundingBox{ get; set; }

        /// <summary>
        /// <p>Row count</p>
        /// </summary>
        [JsonProperty("LinesCount")]
        public long? LinesCount{ get; set; }

        /// <summary>
        /// <p>Line height.</p><p>Unit: px.</p>
        /// </summary>
        [JsonProperty("LineHeight")]
        public long? LineHeight{ get; set; }

        /// <summary>
        /// <p>The spam_code field is 0 in a normal paragraph; if the spam_code field exists and its value is above 0 (1: hit garbage check; 2: hit security policy; 3: another.), then the security check hit is filtered.</p>
        /// </summary>
        [JsonProperty("SpamCode")]
        public long? SpamCode{ get; set; }

        /// <summary>
        /// <p>Rotation information of paragraph text. Coordinates are valid only when valid is true.</p>
        /// </summary>
        [JsonProperty("RotateParagraphRect")]
        public RotateParagraphRect RotateParagraphRect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceLineText", this.SourceLineText);
            this.SetParamSimple(map, prefix + "TargetLineText", this.TargetLineText);
            this.SetParamObj(map, prefix + "BoundingBox.", this.BoundingBox);
            this.SetParamSimple(map, prefix + "LinesCount", this.LinesCount);
            this.SetParamSimple(map, prefix + "LineHeight", this.LineHeight);
            this.SetParamSimple(map, prefix + "SpamCode", this.SpamCode);
            this.SetParamObj(map, prefix + "RotateParagraphRect.", this.RotateParagraphRect);
        }
    }
}

