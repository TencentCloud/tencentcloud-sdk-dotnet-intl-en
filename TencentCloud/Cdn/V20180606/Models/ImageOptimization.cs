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

    public class ImageOptimization : AbstractModel
    {
        
        /// <summary>
        /// `WebpAdapter` configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WebpAdapter")]
        public WebpAdapter WebpAdapter{ get; set; }

        /// <summary>
        /// `TpgAdapter` configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TpgAdapter")]
        public TpgAdapter TpgAdapter{ get; set; }

        /// <summary>
        /// `GuetzliAdapter` configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("GuetzliAdapter")]
        public GuetzliAdapter GuetzliAdapter{ get; set; }

        /// <summary>
        /// AVIF adapter configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AvifAdapter")]
        public AvifAdapter AvifAdapter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "WebpAdapter.", this.WebpAdapter);
            this.SetParamObj(map, prefix + "TpgAdapter.", this.TpgAdapter);
            this.SetParamObj(map, prefix + "GuetzliAdapter.", this.GuetzliAdapter);
            this.SetParamObj(map, prefix + "AvifAdapter.", this.AvifAdapter);
        }
    }
}

