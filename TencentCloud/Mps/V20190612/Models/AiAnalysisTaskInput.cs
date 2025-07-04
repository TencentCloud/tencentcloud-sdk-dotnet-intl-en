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

    public class AiAnalysisTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Video content analysis template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Additional parameter. Its value is a serialized JSON string.
        /// Note: This parameter is used to meet customization requirements. References:
        /// [Smart Erase Tutorial]: https://intl.cloud.tencent.com/document/product/862/101530?from_cn_redirect=1
        /// [Video Splitting (Long Videos to Short Videos) Tutorial](https://intl.cloud.tencent.com/document/product/862/112098?from_cn_redirect=1)
        /// [Intelligent Highlights Tutorial](https://intl.cloud.tencent.com/document/product/862/107280?from_cn_redirect=1)
        /// [Horizontal-to-Vertical Video Transformation Tutorial](https://intl.cloud.tencent.com/document/product/862/112112?from_cn_redirect=1)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExtendedParameter")]
        public string ExtendedParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ExtendedParameter", this.ExtendedParameter);
        }
    }
}

