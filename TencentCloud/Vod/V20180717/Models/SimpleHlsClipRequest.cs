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
        /// Tencent Cloud VOD HLS video URL that needs to be cropped.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Crop start offset time, in seconds. Default 0, crop from the beginning of the video. Negative numbers indicate how many seconds from the end of the video to start cropping. For example, -10 means start trimming from 10 seconds before the end.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// Crop end offset time in seconds. Default is 0, which means crop to the end of the video. Negative numbers indicate how many seconds from the end of the video to end cropping. For example, -10 means end cropping at 10 seconds before the end.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Whether solidified. 0: not solidified, 1: solidified. Default non-permanent.
        /// </summary>
        [JsonProperty("IsPersistence")]
        public long? IsPersistence{ get; set; }

        /// <summary>
        /// Video storage expiry time after editing solidification. Format reference [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I). Enter "9999-12-31T23:59:59Z" to indicate the video never expires. After expiry, the media file and its related resources (transcoding result, sprites) will be permanently deleted. Valid at that time only when IsPersistence is 1. The default video editing never expires.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Post-editing Solidified Video On-demand Task Flow Processing. For details, see upload specified task flow (https://www.tencentcloud.com/document/product/266/9759?from_cn_redirect=1). Valid only when IsPersistence is 1.
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// Category ID, used to categorize and manage media. You can create a category and obtain the category ID via the [create category](https://www.tencentcloud.com/document/product/266/31772?from_cn_redirect=1) API.
        /// <li>Default value: 0, indicating other categories.</li>
        /// Valid when IsPersistence is 1.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// Source context, used to pass through user request information. The [callback on upload completion](https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1) will return the value of this field, up to 250 characters. Valid when IsPersistence is 1.
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// Session context, used to pass through user request information. When specifying the Procedure parameter, the [task flow status change callback](https://www.tencentcloud.com/document/product/266/9636?from_cn_redirect=1) will return the value of this field, up to 1000 characters. Valid only when IsPersistence is 1.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Deprecated.
        /// </summary>
        [JsonProperty("Precision")]
        [System.Obsolete]
        public string Precision{ get; set; }

        /// <summary>
        /// Output video type. Valid values: <li>hls: Output hls file.</li>Default value hls.
        /// </summary>
        [JsonProperty("OutputMediaType")]
        public string OutputMediaType{ get; set; }

        /// <summary>
        /// Reserved field, used when special purpose. Example value: ""
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

