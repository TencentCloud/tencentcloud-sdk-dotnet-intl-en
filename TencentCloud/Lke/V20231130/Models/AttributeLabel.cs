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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttributeLabel : AbstractModel
    {
        
        /// <summary>
        /// Standard word ID.
        /// </summary>
        [JsonProperty("LabelBizId")]
        public string LabelBizId{ get; set; }

        /// <summary>
        /// Standard word name.
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// Synonym name.
        /// </summary>
        [JsonProperty("SimilarLabels")]
        public string[] SimilarLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LabelBizId", this.LabelBizId);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamArraySimple(map, prefix + "SimilarLabels.", this.SimilarLabels);
        }
    }
}

