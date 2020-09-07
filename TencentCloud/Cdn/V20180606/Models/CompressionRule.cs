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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompressionRule : AbstractModel
    {
        
        /// <summary>
        /// true: must be set as true, enables compression
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Compress")]
        public bool? Compress{ get; set; }

        /// <summary>
        /// Compress according to the file suffix type
        /// Such as: jpg, txt
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileExtensions")]
        public string[] FileExtensions{ get; set; }

        /// <summary>
        /// The minimum file size to trigger compression (in bytes)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinLength")]
        public long? MinLength{ get; set; }

        /// <summary>
        /// The maximum file size to trigger compression (in bytes)
        /// The maximum value is 30 MB
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxLength")]
        public long? MaxLength{ get; set; }

        /// <summary>
        /// File compression algorithm
        /// gzip: specifies Gzip compression
        /// brotli: specifies Brotli compression
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Algorithms")]
        public string[] Algorithms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Compress", this.Compress);
            this.SetParamArraySimple(map, prefix + "FileExtensions.", this.FileExtensions);
            this.SetParamSimple(map, prefix + "MinLength", this.MinLength);
            this.SetParamSimple(map, prefix + "MaxLength", this.MaxLength);
            this.SetParamArraySimple(map, prefix + "Algorithms.", this.Algorithms);
        }
    }
}

