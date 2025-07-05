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

    public class AttrLabelDetail : AbstractModel
    {
        
        /// <summary>
        /// Label ID.
        /// </summary>
        [JsonProperty("AttrBizId")]
        public string AttrBizId{ get; set; }

        /// <summary>
        /// Label identification.
        /// </summary>
        [JsonProperty("AttrKey")]
        public string AttrKey{ get; set; }

        /// <summary>
        /// Label name.
        /// </summary>
        [JsonProperty("AttrName")]
        public string AttrName{ get; set; }

        /// <summary>
        /// Label value name.
        /// </summary>
        [JsonProperty("LabelNames")]
        public string[] LabelNames{ get; set; }

        /// <summary>
        /// Whether the label is being updated.
        /// </summary>
        [JsonProperty("IsUpdating")]
        public bool? IsUpdating{ get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Status description.
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// Total number of label values.
        /// </summary>
        [JsonProperty("LabelTotalCount")]
        public string LabelTotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttrBizId", this.AttrBizId);
            this.SetParamSimple(map, prefix + "AttrKey", this.AttrKey);
            this.SetParamSimple(map, prefix + "AttrName", this.AttrName);
            this.SetParamArraySimple(map, prefix + "LabelNames.", this.LabelNames);
            this.SetParamSimple(map, prefix + "IsUpdating", this.IsUpdating);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "LabelTotalCount", this.LabelTotalCount);
        }
    }
}

