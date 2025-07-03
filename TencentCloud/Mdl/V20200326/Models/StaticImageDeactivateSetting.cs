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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StaticImageDeactivateSetting : AbstractModel
    {
        
        /// <summary>
        /// The overlay level to be canceled, range 0-7, default value 0.
        /// </summary>
        [JsonProperty("Layer")]
        public long? Layer{ get; set; }

        /// <summary>
        /// Fade-out duration, in milliseconds, range 0-5000; default value 0, 0 means no fade-out effect.
        /// </summary>
        [JsonProperty("FadeOut")]
        public long? FadeOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Layer", this.Layer);
            this.SetParamSimple(map, prefix + "FadeOut", this.FadeOut);
        }
    }
}

