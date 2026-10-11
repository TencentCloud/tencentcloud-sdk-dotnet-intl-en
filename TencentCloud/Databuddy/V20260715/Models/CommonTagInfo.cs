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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonTagInfo : AbstractModel
    {
        
        /// <summary>
        /// Tag ID
        /// </summary>
        [JsonProperty("LabelId")]
        public string LabelId{ get; set; }

        /// <summary>
        /// Tag name.
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// Tag value ID. For property tags (LabelType=3), it can be 0.
        /// </summary>
        [JsonProperty("LabelValueId")]
        public string LabelValueId{ get; set; }

        /// <summary>
        /// Tag value. It can be empty for a masking tag (LabelType=4).
        /// </summary>
        [JsonProperty("LabelValue")]
        public string LabelValue{ get; set; }

        /// <summary>
        /// Tag type. For valid values, see the LabelType enum definition: 1 - governance tag, 2 - custom tag, 3 - property tag, 4 - masking tag.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Whether the tag has been deleted. true indicates that no record of this LabelId is found in meta_biz_label and the tag has been physically deleted; false (default) indicates that the tag still exists.
        /// </summary>
        [JsonProperty("Deleted")]
        public bool? Deleted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LabelId", this.LabelId);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "LabelValueId", this.LabelValueId);
            this.SetParamSimple(map, prefix + "LabelValue", this.LabelValue);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Deleted", this.Deleted);
        }
    }
}

