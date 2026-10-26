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

    public class ModifyVideoSnapshotConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Screenshot configuration Id</p>
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// <p>Screenshot configuration name</p><p>Input parameter limits: Chinese, English, digits, "-", "_", length not exceeding 128 characters</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Screenshot template Id</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>Hot storage days of image files</p><p>Enumeration values:</p><ul><li>7: 7 days</li><li>15: 15 days</li><li>30: 30 days</li><li>60: 60 days</li><li>90: 90 days</li><li>180: 180 days</li><li>270: 270 days</li><li>360: 360 days</li><li>540: 540 days</li><li>720: 720 days</li><li>900: 900 days</li><li>1080: 1080 days</li></ul>
        /// </summary>
        [JsonProperty("FileExpires")]
        public long? FileExpires{ get; set; }

        /// <summary>
        /// <p>Callback configuration</p>
        /// </summary>
        [JsonProperty("Callback")]
        public CallbackURL Callback{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "FileExpires", this.FileExpires);
            this.SetParamObj(map, prefix + "Callback.", this.Callback);
        }
    }
}

