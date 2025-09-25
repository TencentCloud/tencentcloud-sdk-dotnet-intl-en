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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranslationConfig : AbstractModel
    {
        
        /// <summary>
        /// Target language, target language list (ISO 639-1).
        /// </summary>
        [JsonProperty("TargetLanguages")]
        public string[] TargetLanguages{ get; set; }

        /// <summary>
        /// 1: Only text translation, 2: Voice simultaneous interpretation.
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// Voice simultaneous interpretation configuration: When enabling simultaneous interpretation, this parameter needs to be passed.
        /// </summary>
        [JsonProperty("TTSConfig")]
        public TTSConfig TTSConfig{ get; set; }

        /// <summary>
        /// Translation terminology.
        /// </summary>
        [JsonProperty("Terminology")]
        public Terminology[] Terminology{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TargetLanguages.", this.TargetLanguages);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "TTSConfig.", this.TTSConfig);
            this.SetParamArrayObj(map, prefix + "Terminology.", this.Terminology);
        }
    }
}

