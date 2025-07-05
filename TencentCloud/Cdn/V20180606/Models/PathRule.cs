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

    public class PathRule : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable wildcard match (`*`).
        /// `false`: disabled
        /// `true`: enabled
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Regex")]
        public bool? Regex{ get; set; }

        /// <summary>
        /// Matched URL. Only URLs are supported, while parameters are not. The exact match is used by default. If wildcard match is enabled, up to 5 wildcards are supported. The URL can contain up to 1,024 characters.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Origin server when the path matches. COS origin with private read/write is not supported. The default origin server will be used by default when this field is left empty.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Origin server host header when the path matches. The default `ServerName` will be used by default when this field is left empty.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// Region of the origin server. Valid values: `CN` and `OV`.
        /// `CN`: Within the Chinese mainland
        /// `OV`: Outside the Chinese mainland
        /// Default value: `CN`.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginArea")]
        public string OriginArea{ get; set; }

        /// <summary>
        /// Origin server URI path when the path matches, starting with `/` and excluding parameters. The path can contain up to 1,024 characters. The wildcards in the match path can be respectively captured using `$1`, `$2`, `$3`, `$4`, and `$5`. Up to 10 values can be captured.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ForwardUri")]
        public string ForwardUri{ get; set; }

        /// <summary>
        /// Origin-pull header setting when the path matches.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RequestHeaders")]
        public HttpHeaderRule[] RequestHeaders{ get; set; }

        /// <summary>
        /// When `Regex` is `false`, this parameter should be `true`.
        /// `false`: Disabled
        /// `true`: enabled
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FullMatch")]
        public bool? FullMatch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "OriginArea", this.OriginArea);
            this.SetParamSimple(map, prefix + "ForwardUri", this.ForwardUri);
            this.SetParamArrayObj(map, prefix + "RequestHeaders.", this.RequestHeaders);
            this.SetParamSimple(map, prefix + "FullMatch", this.FullMatch);
        }
    }
}

