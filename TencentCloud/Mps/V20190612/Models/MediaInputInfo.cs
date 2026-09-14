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

    public class MediaInputInfo : AbstractModel
    {
        
        /// <summary>
        /// Type of the input source object. Supported values:
        /// <li>COS: COS origin</li>
        /// <li> URL: URL source</li>
        /// <li> AWS-S3: AWS source, currently only support transcoding task </li>
        /// <li> VOD: VOD Pro Edition </li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Required when `Type` is `COS`. It represents the COS object information for media processing.
        /// </summary>
        [JsonProperty("CosInputInfo")]
        public CosInputInfo CosInputInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UrlInputInfo")]
        public UrlInputInfo UrlInputInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("S3InputInfo")]
        public S3InputInfo S3InputInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VODInputInfo")]
        public VODInputInfo VODInputInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CosInputInfo.", this.CosInputInfo);
            this.SetParamObj(map, prefix + "UrlInputInfo.", this.UrlInputInfo);
            this.SetParamObj(map, prefix + "S3InputInfo.", this.S3InputInfo);
            this.SetParamObj(map, prefix + "VODInputInfo.", this.VODInputInfo);
        }
    }
}

