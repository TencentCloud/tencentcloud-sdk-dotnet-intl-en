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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyStreamLiveWatermarkRequest : AbstractModel
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
        /// Watermark image settings. This parameter is valid if `Type` is `STATIC_IMAGE`.
        /// </summary>
        [JsonProperty("ImageSettings")]
        public CreateImageSettings ImageSettings{ get; set; }

        /// <summary>
        /// Watermark text settings. This parameter is valid if `Type` is `TEXT`.
        /// </summary>
        [JsonProperty("TextSettings")]
        public CreateTextSettings TextSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "ImageSettings.", this.ImageSettings);
            this.SetParamObj(map, prefix + "TextSettings.", this.TextSettings);
        }
    }
}

