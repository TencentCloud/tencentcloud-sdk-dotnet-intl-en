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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableInfo : AbstractModel
    {
        
        /// <summary>
        /// Cell content
        /// Note: This parameter may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cells")]
        public TableCellInfo[] Cells{ get; set; }

        /// <summary>
        /// Type of text in the image. Valid values:
        /// 0: Non-table text
        /// 1: Text in a bordered table
        /// 2: Text in a borderless table
        /// Note: This parameter may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// The coordinates of the four vertices (upper-left, upper-right, lower-right, and lower-left) of the table body.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableCoordPoint")]
        public Coord[] TableCoordPoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Cells.", this.Cells);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "TableCoordPoint.", this.TableCoordPoint);
        }
    }
}

