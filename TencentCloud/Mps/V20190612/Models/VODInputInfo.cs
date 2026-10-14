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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VODInputInfo : AbstractModel
    {
        
        /// <summary>
        /// <p><em>Bucket ID</em> where the media processing object file resides</p>
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// <p>Region of the Bucket where the media processing object file resides</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Input path of the media processing object file</p>
        /// </summary>
        [JsonProperty("Object")]
        public string Object{ get; set; }

        /// <summary>
        /// <p>VOD application ID.</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Whether to use VOD Standard Edition.<br>Attention: If left empty, VOD Pro Edition is used.</p><p>Enumeration values: </p><ul><li>Use VOD Pro Edition</li><li>Use VOD Standard Edition, allowing tasks to be initiated with FileId</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("VodBasic")]
        public long? VodBasic{ get; set; }

        /// <summary>
        /// <p>VOD Standard Edition FileId</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Object", this.Object);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "VodBasic", this.VodBasic);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

