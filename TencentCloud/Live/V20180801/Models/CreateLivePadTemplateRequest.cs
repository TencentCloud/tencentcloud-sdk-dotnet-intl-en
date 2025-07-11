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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLivePadTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Template name. Maximum length: 255 bytes. Only Chinese, English, numbers, _, and - are supported.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Gasket content.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Description information. Maximum length: 1024 bytes. Only Chinese, English, numbers, _, and - are supported.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The waiting time for disconnection. Value range: 0-30000. Unit: ms.
        /// </summary>
        [JsonProperty("WaitDuration")]
        public ulong? WaitDuration{ get; set; }

        /// <summary>
        /// Maximum shim duration. Value range: 0 - positive infinity. Unit: ms.
        /// </summary>
        [JsonProperty("MaxDuration")]
        public ulong? MaxDuration{ get; set; }

        /// <summary>
        /// Shim content type: 1: image, 2: video. Default value: 1.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "WaitDuration", this.WaitDuration);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

