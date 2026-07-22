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

    public class SimpleHlsClipRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Tencent Cloud Video on Demand (VOD) HLS video URL that needs to crop.</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574">application</a> ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether it is the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Crop start offset time in seconds. Default is 0, crop from the beginning of the video. Negative numbers indicate how many seconds from the end of the video to start cropping. For example, -10 means start trimming from 10 seconds before the end.</p>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// <p>Crop end offset time in seconds. Default is 0, which means crop to the end of the video. Negative numbers indicate how many seconds from the end of the video to end trimming. For example, -10 means end trimming at 10 seconds before the end.</p>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// <p>Whether solidified. 0 for default non-permanent, 1 for solidified. Default non-permanent.</p>
        /// </summary>
        [JsonProperty("IsPersistence")]
        public long? IsPersistence{ get; set; }

        /// <summary>
        /// <p>Video storage expiry time after editing solidification. Format reference <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>. Enter "9999-12-31T23:59:59Z" to indicate the video never expires. After expiry, the media file and its related resources (transcoding result, sprites) will be permanently deleted. Valid at that time only when IsPersistence is 1. The default video editing never expires.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Post-editing Solidified Video On-demand Task Flow Processing. For details, see <a href="https://www.tencentcloud.com/document/product/266/9759?from_cn_redirect=1">upload specified task flow</a>. Valid only when IsPersistence is 1.</p>
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category and obtain the category ID via the <a href="/document/product/266/31772">create category</a> API.</p><li>Default value: 0, indicating other categories.</li>Valid only when IsPersistence is 1.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass through user request information. The <a href="/document/product/266/7830">upload completion callback</a> returns the value of this field. The maximum length is 250 characters. Valid when IsPersistence is 1.</p>
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// <p>Session context. This is used to pass through user request information. When specifying the Procedure parameter, the <a href="/document/product/266/9636">task flow status change callback</a> returns the value of this field. The maximum length is 1000 characters. Valid only when IsPersistence is 1.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Deprecated.</p>
        /// </summary>
        [JsonProperty("Precision")]
        [System.Obsolete]
        public string Precision{ get; set; }

        /// <summary>
        /// <p>Output video type. Valid values: <li>hls: Output hls file.</li>Default value hls.</p>
        /// </summary>
        [JsonProperty("OutputMediaType")]
        public string OutputMediaType{ get; set; }

        /// <summary>
        /// <p>Reserved field, used for special purpose. Example value: ""</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "IsPersistence", this.IsPersistence);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "Precision", this.Precision);
            this.SetParamSimple(map, prefix + "OutputMediaType", this.OutputMediaType);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

