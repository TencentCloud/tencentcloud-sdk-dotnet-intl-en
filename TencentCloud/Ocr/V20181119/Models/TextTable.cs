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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextTable : AbstractModel
    {
        
        /// <summary>
        /// Column index of the top-left corner of the cell.
        /// </summary>
        [JsonProperty("ColTl")]
        public long? ColTl{ get; set; }

        /// <summary>
        /// Row index of the top-left corner of the cell.
        /// </summary>
        [JsonProperty("RowTl")]
        public long? RowTl{ get; set; }

        /// <summary>
        /// Column index of the bottom-right corner of the cell.
        /// </summary>
        [JsonProperty("ColBr")]
        public long? ColBr{ get; set; }

        /// <summary>
        /// Row index of the bottom-right corner of the cell.
        /// </summary>
        [JsonProperty("RowBr")]
        public long? RowBr{ get; set; }

        /// <summary>
        /// Cell text
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// Cell type. Valid values: body, header, footer
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Confidence. Value range: 0–100
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// Text line coordinates, which are represented as 4 vertex coordinates.
        /// </summary>
        [JsonProperty("Polygon")]
        public Coord[] Polygon{ get; set; }

        /// <summary>
        /// Extended field
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ColTl", this.ColTl);
            this.SetParamSimple(map, prefix + "RowTl", this.RowTl);
            this.SetParamSimple(map, prefix + "ColBr", this.ColBr);
            this.SetParamSimple(map, prefix + "RowBr", this.RowBr);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArrayObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
        }
    }
}

