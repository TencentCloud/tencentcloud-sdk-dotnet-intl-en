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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompressionRule : AbstractModel
    {
        
        /// <summary>
        /// true: must be set as true, enables compression
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Compress")]
        public bool? Compress{ get; set; }

        /// <summary>
        /// The minimum file size to trigger compression (in bytes)
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinLength")]
        public long? MinLength{ get; set; }

        /// <summary>
        /// The maximum file size to trigger compression (in bytes).
        /// The maximum value is 30 MB.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MaxLength")]
        public long? MaxLength{ get; set; }

        /// <summary>
        /// File compression algorithm
        /// `gzip`: Gzip compression
        /// `brotli`: Brotli compression
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Algorithms")]
        public string[] Algorithms{ get; set; }

        /// <summary>
        /// Compress based on file suffix.
        /// File suffixes such as jpg and txt are supported.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FileExtensions")]
        public string[] FileExtensions{ get; set; }

        /// <summary>
        /// Rule types:
        /// `all`: Apply to all files.
        /// `file`: Apply to files with the specified suffixes.
        /// `directory`: Apply to specified paths.
        /// `path`: Apply to specified absolute paths.
        /// `contentType`: Apply when the `ContentType` is specified.
        /// If this field is specified, `FileExtensions` does not take effect.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Content for each `CacheType`:
        /// For `all`, enter a wildcard `*`.
        /// For `file`, enter a suffix, e.g., `jpg` or `txt`.
        /// For `directory`, enter a path, e.g., `/xxx/test/`.
        /// For `path`, enter an absolute path, e.g., `/xxx/test.html`.
        /// For `contentType`, enter `text/html`.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Compress", this.Compress);
            this.SetParamSimple(map, prefix + "MinLength", this.MinLength);
            this.SetParamSimple(map, prefix + "MaxLength", this.MaxLength);
            this.SetParamArraySimple(map, prefix + "Algorithms.", this.Algorithms);
            this.SetParamArraySimple(map, prefix + "FileExtensions.", this.FileExtensions);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
        }
    }
}

