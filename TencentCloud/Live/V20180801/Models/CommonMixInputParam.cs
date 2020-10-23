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

    public class CommonMixInputParam : AbstractModel
    {
        
        /// <summary>
        /// Input stream name of up to 80 bytes, which is a string containing letters, digits, and underscores.
        /// </summary>
        [JsonProperty("InputStreamName")]
        public string InputStreamName{ get; set; }

        /// <summary>
        /// Input stream layout parameter.
        /// </summary>
        [JsonProperty("LayoutParams")]
        public CommonMixLayoutParams LayoutParams{ get; set; }

        /// <summary>
        /// Input stream crop parameter.
        /// </summary>
        [JsonProperty("CropParams")]
        public CommonMixCropParams CropParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputStreamName", this.InputStreamName);
            this.SetParamObj(map, prefix + "LayoutParams.", this.LayoutParams);
            this.SetParamObj(map, prefix + "CropParams.", this.CropParams);
        }
    }
}

