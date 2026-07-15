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

    public class ImageTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Image encoding configuration.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EncodeConfig")]
        public ImageEncodeConfig EncodeConfig{ get; set; }

        /// <summary>
        /// <p>Image enhancement configuration.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnhanceConfig")]
        public ImageEnhanceConfig EnhanceConfig{ get; set; }

        /// <summary>
        /// <p>Image erasing configuration.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EraseConfig")]
        public ImageEraseConfig EraseConfig{ get; set; }

        /// <summary>
        /// <p>AI image set configuration.</p>
        /// </summary>
        [JsonProperty("AiPosterSuiteConfig")]
        public AiPosterSuiteConfig AiPosterSuiteConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EncodeConfig.", this.EncodeConfig);
            this.SetParamObj(map, prefix + "EnhanceConfig.", this.EnhanceConfig);
            this.SetParamObj(map, prefix + "EraseConfig.", this.EraseConfig);
            this.SetParamObj(map, prefix + "AiPosterSuiteConfig.", this.AiPosterSuiteConfig);
        }
    }
}

