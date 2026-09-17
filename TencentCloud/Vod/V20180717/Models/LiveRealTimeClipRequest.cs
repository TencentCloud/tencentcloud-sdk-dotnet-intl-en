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

    public class LiveRealTimeClipRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Push stream live code.</p>
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// <p>Start time of stream clipping. For the format, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time of stream clipping. For the format, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p><b>On-demand <a href="/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services after December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications, whether in the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Whether solidified. 0: non-permanent, 1: solidified. Default non-permanent.</p>
        /// </summary>
        [JsonProperty("IsPersistence")]
        public long? IsPersistence{ get; set; }

        /// <summary>
        /// <p>Video storage expiry time after editing solidification. Format reference: <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>. Enter "9999-12-31T23:59:59Z" to indicate the video never expires. After expiry, the media file and its related resources (transcoding result, sprites, etc.) will be permanently deleted. Valid only when IsPersistence is 1. By default, the video after editing solidification never expires.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Post-editing Solidified Video On-demand Task Flow Processing. For details, see <a href="https://www.tencentcloud.com/document/product/266/9759?from_cn_redirect=1">upload specified task flow</a>. Valid only when IsPersistence is 1.</p>
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can obtain the category ID by creating a category through the <a href="/document/product/266/31772?from_cn_redirect=1">create category</a> API.</p><li>Default value: 0, indicating other categories.</li>Valid only when IsPersistence is 1.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The <a href="/document/product/266/7830?from_cn_redirect=1">upload completion callback</a> returns the value of this field. The maximum length is 250 characters. Valid only when IsPersistence is 1.</p>
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// <p>Session context. This is used to pass user request information. When the Procedure parameter is specified, the <a href="/document/product/266/9636?from_cn_redirect=1">task flow status change callback</a> returns the value of this field. The maximum length is 1000 characters. Valid only when IsPersistence is 1.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Whether to return edited video metadata. 0: not required, 1: required. By default, does not need.</p>
        /// </summary>
        [JsonProperty("MetaDataRequired")]
        public ulong? MetaDataRequired{ get; set; }

        /// <summary>
        /// <p>The domain name added in VOD for time shift playback must already have a <a href="https://www.tencentcloud.com/document/product/266/52220?from_cn_redirect=1#.E6.AD.A5.E9.AA.A43.EF.BC.9A.E5.85.B3.E8.81.94.E5.BD.95.E5.88.B6.E6.A8.A1.E6.9D.BF.3Ca-id.3D.22step3.22.3E.3C.2Fa.3E">recording template binding and time-shift service enabled</a> in cloud streaming. <strong>If the first call of this interface is after 2021-01-01T00:00:00Z, this field is required.</strong></p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>Live stream information for editing:</p><li>Edit the original stream by default.</li><li>If the Type specified in StreamInfo is Transcoding, edit the live streaming transcoding stream corresponding to TemplateId.</li>
        /// </summary>
        [JsonProperty("StreamInfo")]
        public LiveRealTimeClipStreamInfo StreamInfo{ get; set; }

        /// <summary>
        /// <p>System reserved field. Do not fill in.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "IsPersistence", this.IsPersistence);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "MetaDataRequired", this.MetaDataRequired);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamObj(map, prefix + "StreamInfo.", this.StreamInfo);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

