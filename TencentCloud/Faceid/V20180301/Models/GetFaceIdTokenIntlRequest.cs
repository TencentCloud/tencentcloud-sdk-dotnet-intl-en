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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFaceIdTokenIntlRequest : AbstractModel
    {
        
        /// <summary>
        /// The detection mode. Valid values:
        /// `liveness`: Liveness detection only.
        /// `compare`: Liveness detection and face comparison.
        /// Default value: `liveness`.
        /// </summary>
        [JsonProperty("CheckMode")]
        public string CheckMode{ get; set; }

        /// <summary>
        /// The verification security level. Valid values:
        /// `1`: Video-based liveness detection.
        /// `2`: Motion-based liveness detection.
        /// `3`: Reflection-based liveness detection.
        /// `4`: Motion- and reflection-based liveness detection.
        /// Default value: `4`.
        /// </summary>
        [JsonProperty("SecureLevel")]
        public string SecureLevel{ get; set; }

        /// <summary>
        /// The image for comparison in the `compare` (liveness detection and face comparison) mode. This parameter is required when the value of `CheckMode` is `compare`.
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// The pass-through parameter.
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckMode", this.CheckMode);
            this.SetParamSimple(map, prefix + "SecureLevel", this.SecureLevel);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

