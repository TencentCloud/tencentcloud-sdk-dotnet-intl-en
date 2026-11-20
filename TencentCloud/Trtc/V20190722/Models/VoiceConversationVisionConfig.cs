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

    public class VoiceConversationVisionConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to enable visual understanding.</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>Storage type.</p><p>Enumeration values:</p><ul><li>0: Do not store.</li><li>1: Specify cloud storage. In such cases, the CloudStorage parameter is required.</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public ulong? StorageType{ get; set; }

        /// <summary>
        /// <p>Third-party Cloud Storage archive configuration. After configuration, the backend will automatically upload I-frames received from the SDK to the designated cloud bucket for persistent storage.</p>
        /// </summary>
        [JsonProperty("CloudStorage")]
        public CloudStorage CloudStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamObj(map, prefix + "CloudStorage.", this.CloudStorage);
        }
    }
}

