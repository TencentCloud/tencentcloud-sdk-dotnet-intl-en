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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageEnhanceConfig : AbstractModel
    {
        
        /// <summary>
        /// Super-resolution configuration.
        /// </summary>
        [JsonProperty("SuperResolution")]
        public SuperResolutionConfig SuperResolution{ get; set; }

        /// <summary>
        /// Color enhancement configuration.
        /// </summary>
        [JsonProperty("ColorEnhance")]
        public ColorEnhanceConfig ColorEnhance{ get; set; }

        /// <summary>
        /// Detail enhancement configuration.
        /// </summary>
        [JsonProperty("SharpEnhance")]
        public SharpEnhanceConfig SharpEnhance{ get; set; }

        /// <summary>
        /// Face enhancement configuration.
        /// </summary>
        [JsonProperty("FaceEnhance")]
        public FaceEnhanceConfig FaceEnhance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SuperResolution.", this.SuperResolution);
            this.SetParamObj(map, prefix + "ColorEnhance.", this.ColorEnhance);
            this.SetParamObj(map, prefix + "SharpEnhance.", this.SharpEnhance);
            this.SetParamObj(map, prefix + "FaceEnhance.", this.FaceEnhance);
        }
    }
}

