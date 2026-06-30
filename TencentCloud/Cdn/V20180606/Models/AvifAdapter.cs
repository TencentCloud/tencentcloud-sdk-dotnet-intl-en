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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvifAdapter : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable `AvifAdapter` for image optimization. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// Note: This field may return·`null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// When the original image is avif and the client Accept header contains image/avif, return directly the original image.
        /// When the original image is in avif format and the client Accept header does not include image/avif but includes image/webp, convert avif to webp format and return. if the Accept header does not include image/webp, convert to jpeg and return.
        /// 
        /// Valid values:. 
        /// - []
        /// - ["webp"]
        /// - ["jpeg"]
        /// - ["webp", "jpeg"]
        /// 
        /// "Webp": whether avif to webp is enabled, "jpeg": whether avif to jpeg is enabled. if both webp and jpeg are enabled, webp must be before jpeg.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FallbackFormats")]
        public string[] FallbackFormats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "FallbackFormats.", this.FallbackFormats);
        }
    }
}

