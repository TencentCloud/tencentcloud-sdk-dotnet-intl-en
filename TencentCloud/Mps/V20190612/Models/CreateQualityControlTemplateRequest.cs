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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateQualityControlTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Media quality inspection template name, with a length limit of 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Media quality inspection control parameters.
        /// </summary>
        [JsonProperty("QualityControlItemSet")]
        public QualityControlItemConfig[] QualityControlItemSet{ get; set; }

        /// <summary>
        /// Media quality inspection template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Recording file format. Valid values:
        /// <li>PNG: PNG image.</li>
        /// </summary>
        [JsonProperty("RecordFormat")]
        public string RecordFormat{ get; set; }

        /// <summary>
        /// Spot check policy for media quality inspection.
        /// </summary>
        [JsonProperty("Strategy")]
        public QualityControlStrategy Strategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "QualityControlItemSet.", this.QualityControlItemSet);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "RecordFormat", this.RecordFormat);
            this.SetParamObj(map, prefix + "Strategy.", this.Strategy);
        }
    }
}

