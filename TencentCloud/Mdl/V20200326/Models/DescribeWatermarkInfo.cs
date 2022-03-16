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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWatermarkInfo : AbstractModel
    {
        
        /// <summary>
        /// Watermark ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Watermark name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Watermark type. Valid values: STATIC_IMAGE, TEXT.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Watermark image settings. This parameter is valid if `Type` is `STATIC_IMAGE`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ImageSettings")]
        public DescribeImageSettings ImageSettings{ get; set; }

        /// <summary>
        /// Watermark text settings. This parameter is valid if `Type` is `TEXT`.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("TextSettings")]
        public DescribeTextSettings TextSettings{ get; set; }

        /// <summary>
        /// Last modified time (UTC+0) of the watermark, in the format of `2020-01-01T12:00:00Z`
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// List of channel IDs the watermark is bound to
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AttachedChannels")]
        public string[] AttachedChannels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "ImageSettings.", this.ImageSettings);
            this.SetParamObj(map, prefix + "TextSettings.", this.TextSettings);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "AttachedChannels.", this.AttachedChannels);
        }
    }
}

