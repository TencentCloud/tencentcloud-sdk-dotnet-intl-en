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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MPSAiAnalysisTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>ID of the video analysis template.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <p>Additional parameters, whose value is a serialized json string. Note: This parameter is for customization requirements. See the following: <a href="https://www.tencentcloud.com/document/product/862/101530?from_cn_redirect=1">Intelligent Erasure</a><a href="https://www.tencentcloud.com/document/product/862/112098?from_cn_redirect=1">Intelligent Splitting</a><a href="https://www.tencentcloud.com/document/product/862/107280?from_cn_redirect=1">Highlight</a><a href="https://www.tencentcloud.com/document/product/862/112112?from_cn_redirect=1">Intelligent Landscape-to-Portrait</a></p>
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

