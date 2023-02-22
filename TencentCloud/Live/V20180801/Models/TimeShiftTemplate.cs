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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimeShiftTemplate : AbstractModel
    {
        
        /// <summary>
        /// The template name.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// The time shifting duration.
        /// Unit: second
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// The segment size.
        /// Value range: 3-10.
        /// Unit: Second.
        /// Default value: 5
        /// </summary>
        [JsonProperty("ItemDuration")]
        public ulong? ItemDuration{ get; set; }

        /// <summary>
        /// The template ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public ulong? TemplateId{ get; set; }

        /// <summary>
        /// The template description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The region. Valid values:
        /// `Mainland`: The Chinese mainland.
        /// `Overseas`: Outside the Chinese mainland.
        /// Default value: `Mainland`.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Whether to remove watermarks.
        /// If you pass in `true`, the original stream will be recorded.
        /// Default value: `false`.
        /// </summary>
        [JsonProperty("RemoveWatermark")]
        public bool? RemoveWatermark{ get; set; }

        /// <summary>
        /// The transcoding template IDs.
        /// This API works only if `RemoveWatermark` is `false`.
        /// </summary>
        [JsonProperty("TranscodeTemplateIds")]
        public ulong?[] TranscodeTemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ItemDuration", this.ItemDuration);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "RemoveWatermark", this.RemoveWatermark);
            this.SetParamArraySimple(map, prefix + "TranscodeTemplateIds.", this.TranscodeTemplateIds);
        }
    }
}

