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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterPrintKey : AbstractModel
    {
        
        /// <summary>
        /// Watermark key ID
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Watermark key value
        /// </summary>
        [JsonProperty("KeyContent")]
        public string KeyContent{ get; set; }

        /// <summary>
        /// Watermark key version number
        /// </summary>
        [JsonProperty("KeyVersion")]
        public string KeyVersion{ get; set; }

        /// <summary>
        /// Whether it is enabled. Valid values: [0 (no), 1 (yes)]
        /// </summary>
        [JsonProperty("OpenStatus")]
        public ulong? OpenStatus{ get; set; }

        /// <summary>
        /// Key generation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyContent", this.KeyContent);
            this.SetParamSimple(map, prefix + "KeyVersion", this.KeyVersion);
            this.SetParamSimple(map, prefix + "OpenStatus", this.OpenStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

