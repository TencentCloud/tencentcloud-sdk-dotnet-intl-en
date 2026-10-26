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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVLPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Plan name. Supports Chinese, English, digits, _ and -. Up to 32 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>ID of the associated visual understanding template</p>
        /// </summary>
        [JsonProperty("VLTemplateId")]
        public string VLTemplateId{ get; set; }

        /// <summary>
        /// <p>Plan description. Up to 256 characters.</p>
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// <p>Number of days to store screenshot files. Value range: [7, 1080]. Required in image mode. Do not pass this parameter in video mode.</p>
        /// </summary>
        [JsonProperty("FileExpires")]
        public long? FileExpires{ get; set; }

        /// <summary>
        /// <p>Callback notification configuration</p>
        /// </summary>
        [JsonProperty("Callback")]
        public CallbackURL Callback{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VLTemplateId", this.VLTemplateId);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "FileExpires", this.FileExpires);
            this.SetParamObj(map, prefix + "Callback.", this.Callback);
        }
    }
}

