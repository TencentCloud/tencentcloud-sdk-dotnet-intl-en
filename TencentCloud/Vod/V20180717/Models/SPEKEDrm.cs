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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SPEKEDrm : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("KeyServerUrl")]
        public string KeyServerUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Vector")]
        public string Vector{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EncryptionMethod")]
        public string EncryptionMethod{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EncryptionPreset")]
        public string EncryptionPreset{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("KeyAcquireMode")]
        public string KeyAcquireMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "KeyServerUrl", this.KeyServerUrl);
            this.SetParamSimple(map, prefix + "Vector", this.Vector);
            this.SetParamSimple(map, prefix + "EncryptionMethod", this.EncryptionMethod);
            this.SetParamSimple(map, prefix + "EncryptionPreset", this.EncryptionPreset);
            this.SetParamSimple(map, prefix + "KeyAcquireMode", this.KeyAcquireMode);
        }
    }
}

